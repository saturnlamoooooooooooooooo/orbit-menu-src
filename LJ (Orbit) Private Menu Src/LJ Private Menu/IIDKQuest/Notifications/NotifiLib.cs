using System;
using System.Linq;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

namespace IIDKQuest.Notifications
{
	// Token: 0x02000008 RID: 8
	[RegisterTypeInIl2Cpp]
	public class NotifiLib : MonoBehaviour
	{
		// Token: 0x0600005B RID: 91 RVA: 0x000048DC File Offset: 0x00002ADC
		public NotifiLib(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004907 File Offset: 0x00002B07
		private void Awake()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000490C File Offset: 0x00002B0C
		private void Init()
		{
			this.MainCamera = GameObject.Find("Main Camera");
			this.HUDObj = new GameObject();
			this.HUDObj2 = new GameObject();
			this.HUDObj2.name = "NOTIFICATIONLIB_HUD_OBJ";
			this.HUDObj.name = "NOTIFICATIONLIB_HUD_OBJ";
			this.HUDObj.AddComponent<Canvas>();
			this.HUDObj.AddComponent<CanvasScaler>();
			this.HUDObj.AddComponent<GraphicRaycaster>();
			this.HUDObj.GetComponent<Canvas>().enabled = true;
			this.HUDObj.GetComponent<Canvas>().renderMode = 2;
			this.HUDObj.GetComponent<Canvas>().worldCamera = this.MainCamera.GetComponent<Camera>();
			this.HUDObj.GetComponent<RectTransform>().sizeDelta = new Vector2(5f, 5f);
			this.HUDObj.GetComponent<RectTransform>().position = new Vector3(this.MainCamera.transform.position.x, this.MainCamera.transform.position.y, this.MainCamera.transform.position.z);
			this.HUDObj2.transform.position = new Vector3(this.MainCamera.transform.position.x, this.MainCamera.transform.position.y, this.MainCamera.transform.position.z - 4.6f);
			this.HUDObj.transform.parent = this.HUDObj2.transform;
			this.HUDObj.GetComponent<RectTransform>().localPosition = new Vector3(0f, 0f, 1.6f);
			Vector3 eulerAngles = this.HUDObj.GetComponent<RectTransform>().rotation.eulerAngles;
			eulerAngles.y = -270f;
			this.HUDObj.transform.localScale = new Vector3(1f, 1f, 1f);
			this.HUDObj.GetComponent<RectTransform>().rotation = Quaternion.Euler(eulerAngles);
			this.Testtext = new GameObject
			{
				transform = 
				{
					parent = this.HUDObj.transform
				}
			}.AddComponent<Text>();
			this.Testtext.text = "";
			this.Testtext.fontSize = 30;
			this.Testtext.font = Settings.currentFont;
			this.Testtext.rectTransform.sizeDelta = new Vector2(450f, 210f);
			this.Testtext.alignment = 6;
			this.Testtext.rectTransform.localScale = new Vector3(0.0033333334f, 0.0033333334f, 0.33333334f);
			this.Testtext.rectTransform.localPosition = new Vector3(-1f, -1f, -0.5f);
			this.Testtext.material = this.AlertText;
			NotifiLib.NotifiText = this.Testtext;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004C24 File Offset: 0x00002E24
		private void FixedUpdate()
		{
			bool flag = !this.HasInit && GameObject.Find("Main Camera") != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.Init();
				this.HasInit = true;
			}
			this.HUDObj2.transform.position = new Vector3(this.MainCamera.transform.position.x, this.MainCamera.transform.position.y, this.MainCamera.transform.position.z);
			this.HUDObj2.transform.rotation = this.MainCamera.transform.rotation;
			bool flag3 = this.Testtext.text != "";
			if (flag3)
			{
				this.NotificationDecayTimeCounter++;
				bool flag4 = this.NotificationDecayTimeCounter > this.NotificationDecayTime;
				if (flag4)
				{
					this.Notifilines = null;
					this.newtext = "";
					this.NotificationDecayTimeCounter = 0;
					this.Notifilines = this.Testtext.text.Split(Environment.NewLine.ToCharArray()).Skip(1).ToArray<string>();
					foreach (string text in this.Notifilines)
					{
						bool flag5 = text != "";
						if (flag5)
						{
							this.newtext = this.newtext + text + "\n";
						}
					}
					this.Testtext.text = this.newtext;
				}
			}
			else
			{
				this.NotificationDecayTimeCounter = 0;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004DD0 File Offset: 0x00002FD0
		public static void SendNotification(string NotificationText)
		{
			bool flag = !Settings.disableNotifications;
			if (flag)
			{
				try
				{
					bool flag2 = NotifiLib.IsEnabled && NotifiLib.PreviousNotifi != NotificationText;
					if (flag2)
					{
						bool flag3 = !NotificationText.Contains(Environment.NewLine);
						if (flag3)
						{
							NotificationText += Environment.NewLine;
						}
						NotifiLib.NotifiText.text = NotifiLib.NotifiText.text + NotificationText;
						NotifiLib.NotifiText.supportRichText = true;
						NotifiLib.PreviousNotifi = NotificationText;
					}
				}
				catch
				{
					Debug.LogError("Notification failed, object probably nil due to third person ; " + NotificationText);
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004E88 File Offset: 0x00003088
		public static void ClearAllNotifications()
		{
			NotifiLib.NotifiText.text = "";
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004E9C File Offset: 0x0000309C
		public static void ClearPastNotifications(int amount)
		{
			string text = "";
			foreach (string text2 in NotifiLib.NotifiText.text.Split(Environment.NewLine.ToCharArray()).Skip(amount).ToArray<string>())
			{
				bool flag = text2 != "";
				if (flag)
				{
					text = text + text2 + "\n";
				}
			}
			NotifiLib.NotifiText.text = text;
		}

		// Token: 0x04000063 RID: 99
		private GameObject HUDObj;

		// Token: 0x04000064 RID: 100
		private GameObject HUDObj2;

		// Token: 0x04000065 RID: 101
		private GameObject MainCamera;

		// Token: 0x04000066 RID: 102
		private Text Testtext;

		// Token: 0x04000067 RID: 103
		private Material AlertText = new Material(Shader.Find("GUI/Text Shader"));

		// Token: 0x04000068 RID: 104
		private int NotificationDecayTime = 144;

		// Token: 0x04000069 RID: 105
		private int NotificationDecayTimeCounter;

		// Token: 0x0400006A RID: 106
		public static int NoticationThreshold = 30;

		// Token: 0x0400006B RID: 107
		private string[] Notifilines;

		// Token: 0x0400006C RID: 108
		private string newtext;

		// Token: 0x0400006D RID: 109
		public static string PreviousNotifi;

		// Token: 0x0400006E RID: 110
		private bool HasInit;

		// Token: 0x0400006F RID: 111
		private static Text NotifiText;

		// Token: 0x04000070 RID: 112
		public static bool IsEnabled = true;
	}
}
