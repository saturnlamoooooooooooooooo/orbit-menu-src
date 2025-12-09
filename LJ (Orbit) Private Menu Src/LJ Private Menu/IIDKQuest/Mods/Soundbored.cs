using System;
using System.IO;
using System.Reflection;
using Photon.Voice.Unity;
using UnityEngine;

namespace IIDKQuest.Mods
{
	// Token: 0x02000014 RID: 20
	internal class Soundbored
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000842C File Offset: 0x0000662C
		public static byte[] LoadEmbeddedSound(string resourceName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			byte[] result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(resourceName))
			{
				bool flag = manifestResourceStream == null;
				if (flag)
				{
					result = null;
				}
				else
				{
					byte[] array = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(array, 0, array.Length);
					result = array;
				}
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008494 File Offset: 0x00006694
		public static void PlayEmbeddedSoundOnHand(string resourceName)
		{
			byte[] array = Soundbored.LoadEmbeddedSound(resourceName);
			bool flag = array == null;
			if (!flag)
			{
				AudioClip audioClip = Soundbored.WavToAudioClip(array);
				bool flag2 = audioClip == null;
				if (!flag2)
				{
					AudioSource leftHandPlayer = GorillaTagger.Instance.offlineVRRig.leftHandPlayer;
					leftHandPlayer.clip = audioClip;
					leftHandPlayer.volume = 0.5f;
					leftHandPlayer.loop = false;
					leftHandPlayer.Play();
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008500 File Offset: 0x00006700
		public static void RestoreMic()
		{
			GameObject gameObject = GameObject.Find("NetworkVoice");
			Recorder recorder;
			if ((recorder = ((gameObject != null) ? gameObject.GetComponent<Recorder>() : null)) == null)
			{
				GameObject gameObject2 = GameObject.Find("Photon Manager");
				recorder = ((gameObject2 != null) ? gameObject2.GetComponent<Recorder>() : null);
			}
			Recorder recorder2 = recorder;
			bool flag = recorder2 != null;
			if (flag)
			{
				Recorder component = recorder2.GetComponent<Recorder>();
				bool flag2 = component != null;
				if (flag2)
				{
					component.SourceType = 0;
					component.AudioClip = null;
					component.RestartRecording(true);
					component.DebugEchoMode = false;
				}
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00008580 File Offset: 0x00006780
		public static void SounboardPlay(string path)
		{
			byte[] fileBytes;
			try
			{
				fileBytes = File.ReadAllBytes(path);
			}
			catch (Exception)
			{
				return;
			}
			AudioClip audioClip = Soundbored.WavToAudioClip(fileBytes);
			bool flag = audioClip == null;
			if (!flag)
			{
				GameObject gameObject = GameObject.Find("NetworkVoice");
				Recorder recorder;
				if ((recorder = ((gameObject != null) ? gameObject.GetComponent<Recorder>() : null)) == null)
				{
					GameObject gameObject2 = GameObject.Find("Photon Manager");
					recorder = ((gameObject2 != null) ? gameObject2.GetComponent<Recorder>() : null);
				}
				Recorder recorder2 = recorder;
				bool flag2 = recorder2 == null;
				if (!flag2)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
					try
					{
						recorder2.SourceType = 1;
						recorder2.AudioClip = audioClip;
						recorder2.RestartRecording(true);
						recorder2.DebugEchoMode = true;
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008644 File Offset: 0x00006844
		private static AudioClip WavToAudioClip(byte[] fileBytes)
		{
			bool flag = fileBytes.Length < 44;
			AudioClip result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num = BitConverter.ToInt32(fileBytes, 24);
				int num2 = (int)BitConverter.ToInt16(fileBytes, 22);
				int num3 = fileBytes.Length - 44;
				int num4 = num3 / 2;
				float[] array = new float[num4];
				for (int i = 0; i < num4; i++)
				{
					short num5 = BitConverter.ToInt16(fileBytes, 44 + i * 2);
					array[i] = (float)num5 / 32768f;
				}
				AudioClip audioClip = AudioClip.Create("sound", num4 / num2, num2, num, false);
				audioClip.SetData(array, 0);
				result = audioClip;
			}
			return result;
		}
	}
}
