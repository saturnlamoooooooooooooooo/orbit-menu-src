using System;
using System.Linq;
using easyInputs;
using IIDKQuest.Classes;
using IIDKQuest.Notifications;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace IIDKQuest.Menu
{
	// Token: 0x02000019 RID: 25
	public class Main : MelonMod
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0000AB48 File Offset: 0x00008D48
		public override void OnApplicationStart()
		{
			ClassInjector.RegisterTypeInIl2Cpp<NotifiLib>();
			ClassInjector.RegisterTypeInIl2Cpp<TimedBehaviour>();
			ClassInjector.RegisterTypeInIl2Cpp<RigManager>();
			ClassInjector.RegisterTypeInIl2Cpp<ColorChanger>();
			ClassInjector.RegisterTypeInIl2Cpp<Button>();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000AB6C File Offset: 0x00008D6C
		public override void OnUpdate()
		{
			try
			{
				bool flag = (!Settings.rightHanded && EasyInputs.GetSecondaryButtonDown(0)) || (Settings.rightHanded && EasyInputs.GetSecondaryButtonDown(1));
				bool flag2 = false;
				bool flag3 = Main.menu == null;
				if (flag3)
				{
					bool flag4 = flag || flag2;
					if (flag4)
					{
						Main.CreateMenu();
						Main.RecenterMenu(Settings.rightHanded, flag2);
						bool flag5 = Main.reference == null;
						if (flag5)
						{
							Main.CreateReference(Settings.rightHanded);
						}
					}
				}
				else
				{
					bool flag6 = flag || flag2;
					if (flag6)
					{
						Main.RecenterMenu(Settings.rightHanded, flag2);
					}
					else
					{
						Rigidbody rigidbody = Main.menu.AddComponent(Il2CppType.From(typeof(Rigidbody))) as Rigidbody;
						Object.Destroy(Main.menu);
						Main.menu = null;
						Object.Destroy(Main.reference);
						Main.reference = null;
					}
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format("{0} // Error initializing at {1}: {2}", "LJ Private Menu", ex.StackTrace, ex.Message));
			}
			try
			{
				bool flag7 = Main.fpsObject != null;
				if (flag7)
				{
					Main.fpsObject.text = "FPS: " + Mathf.Ceil(1f / Time.unscaledDeltaTime).ToString();
				}
				foreach (ButtonInfo[] array in Buttons.buttons)
				{
					foreach (ButtonInfo buttonInfo in array)
					{
						bool enabled = buttonInfo.enabled;
						if (enabled)
						{
							bool flag8 = buttonInfo.method != null;
							if (flag8)
							{
								try
								{
									buttonInfo.method();
								}
								catch (Exception ex2)
								{
									Debug.LogError(string.Format("{0} // Error with mod {1} at {2}: {3}", new object[]
									{
										"LJ Private Menu",
										buttonInfo.buttonText,
										ex2.StackTrace,
										ex2.Message
									}));
								}
							}
						}
					}
				}
			}
			catch (Exception ex3)
			{
				Debug.LogError(string.Format("{0} // Error with executing mods at {1}: {2}", "LJ Private Menu", ex3.StackTrace, ex3.Message));
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000AE08 File Offset: 0x00009008
		public static void CreateMenu()
		{
			Main.menu = GameObject.CreatePrimitive(3);
			Object.Destroy(Main.menu.GetComponent<Rigidbody>());
			Object.Destroy(Main.menu.GetComponent<BoxCollider>());
			Object.Destroy(Main.menu.GetComponent<Renderer>());
			Main.menu.transform.localScale = new Vector3(0.1f, 0.3f, 0.3825f);
			Main.menuBackground = GameObject.CreatePrimitive(3);
			Object.Destroy(Main.menuBackground.GetComponent<Rigidbody>());
			Object.Destroy(Main.menuBackground.GetComponent<BoxCollider>());
			Main.menuBackground.transform.parent = Main.menu.transform;
			Main.menuBackground.transform.rotation = Quaternion.identity;
			Main.menuBackground.transform.localScale = Settings.menuSize;
			Main.menuBackground.GetComponent<Renderer>().material.color = Settings.backgroundColor.colors[0].color;
			Main.menuBackground.transform.position = new Vector3(0.05f, 0f, 0f);
			ColorChanger colorChanger = Main.menuBackground.AddComponent<ColorChanger>();
			colorChanger.colorInfo = Settings.backgroundColor;
			colorChanger.Start();
			Main.canvasObject = new GameObject();
			Main.canvasObject.transform.parent = Main.menu.transform;
			Canvas canvas = Main.canvasObject.AddComponent<Canvas>();
			CanvasScaler canvasScaler = Main.canvasObject.AddComponent<CanvasScaler>();
			Main.canvasObject.AddComponent<GraphicRaycaster>();
			canvas.renderMode = 2;
			canvasScaler.dynamicPixelsPerUnit = 5000f;
			Text text = new GameObject
			{
				transform = 
				{
					parent = Main.canvasObject.transform
				}
			}.AddComponent<Text>();
			text.font = Settings.currentFont;
			text.text = "LJ Private Menu";
			text.fontSize = 1;
			text.color = Settings.textColors[0];
			text.supportRichText = true;
			text.fontStyle = 2;
			text.alignment = 4;
			text.resizeTextForBestFit = true;
			text.resizeTextMinSize = 0;
			RectTransform component = text.GetComponent<RectTransform>();
			component.localPosition = Vector3.zero;
			component.sizeDelta = new Vector2(0.28f, 0.05f);
			component.position = new Vector3(0.06f, 0f, 0.165f);
			component.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
			bool fpsCounter = Settings.fpsCounter;
			if (fpsCounter)
			{
				Main.fpsObject = new GameObject
				{
					transform = 
					{
						parent = Main.canvasObject.transform
					}
				}.AddComponent<Text>();
				Main.fpsObject.font = Settings.currentFont;
				Main.fpsObject.text = "FPS: " + Mathf.Ceil(1f / Time.unscaledDeltaTime).ToString();
				Main.fpsObject.color = Settings.textColors[0];
				Main.fpsObject.fontSize = 1;
				Main.fpsObject.supportRichText = true;
				Main.fpsObject.fontStyle = 2;
				Main.fpsObject.alignment = 4;
				Main.fpsObject.horizontalOverflow = 1;
				Main.fpsObject.resizeTextForBestFit = true;
				Main.fpsObject.resizeTextMinSize = 0;
				RectTransform component2 = Main.fpsObject.GetComponent<RectTransform>();
				component2.localPosition = Vector3.zero;
				component2.sizeDelta = new Vector2(0.28f, 0.02f);
				component2.position = new Vector3(0.06f, 0f, 0.135f);
				component2.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
			}
			bool disconnectButton = Settings.disconnectButton;
			if (disconnectButton)
			{
				GameObject gameObject = GameObject.CreatePrimitive(3);
				Object.Destroy(gameObject.GetComponent<Rigidbody>());
				gameObject.GetComponent<BoxCollider>().isTrigger = true;
				gameObject.transform.parent = Main.menu.transform;
				gameObject.transform.rotation = Quaternion.identity;
				gameObject.transform.localScale = new Vector3(0.09f, 0.9f, 0.08f);
				gameObject.transform.localPosition = new Vector3(0.56f, 0f, 0.6f);
				gameObject.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
				gameObject.AddComponent<Button>().relatedText = "Disconnect";
				colorChanger = gameObject.AddComponent<ColorChanger>();
				colorChanger.colorInfo = Settings.buttonColors[0];
				colorChanger.Start();
				Text text2 = new GameObject
				{
					transform = 
					{
						parent = Main.canvasObject.transform
					}
				}.AddComponent<Text>();
				text2.text = "Disconnect";
				text2.font = Settings.currentFont;
				text2.fontSize = 1;
				text2.color = Settings.textColors[0];
				text2.alignment = 4;
				text2.resizeTextForBestFit = true;
				text2.resizeTextMinSize = 0;
				RectTransform component3 = text2.GetComponent<RectTransform>();
				component3.localPosition = Vector3.zero;
				component3.sizeDelta = new Vector2(0.2f, 0.03f);
				component3.localPosition = new Vector3(0.064f, 0f, 0.23f);
				component3.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
			}
			Text text3 = new GameObject
			{
				transform = 
				{
					parent = Main.canvasObject.transform
				}
			}.AddComponent<Text>();
			text3.text = "LJ's Private Menu Made By LJ";
			text3.font = Settings.currentFont;
			text3.fontSize = 2;
			text3.color = Settings.textColors[0];
			text3.alignment = 4;
			text3.resizeTextForBestFit = true;
			text3.resizeTextMinSize = 0;
			RectTransform component4 = text3.GetComponent<RectTransform>();
			component4.localPosition = Vector3.zero;
			component4.sizeDelta = new Vector2(0.2f, 0.02f);
			component4.localPosition = new Vector3(0.062f, 0f, -0.23f);
			component4.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
			GameObject gameObject2 = GameObject.CreatePrimitive(3);
			GameObject.CreatePrimitive(3);
			Object.Destroy(gameObject2.GetComponent<Rigidbody>());
			gameObject2.GetComponent<BoxCollider>().isTrigger = true;
			gameObject2.transform.parent = Main.menu.transform;
			gameObject2.transform.rotation = Quaternion.identity;
			gameObject2.transform.localScale = new Vector3(0.09f, 0.2f, 0.9f);
			gameObject2.transform.localPosition = new Vector3(0.56f, 0.65f, 0f);
			gameObject2.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
			gameObject2.AddComponent<Button>().relatedText = "PreviousPage";
			colorChanger = gameObject2.AddComponent<ColorChanger>();
			colorChanger.colorInfo = Settings.buttonColors[0];
			colorChanger.Start();
			text = new GameObject
			{
				transform = 
				{
					parent = Main.canvasObject.transform
				}
			}.AddComponent<Text>();
			text.font = Settings.currentFont;
			text.text = "<";
			text.fontSize = 1;
			text.color = Settings.textColors[0];
			text.alignment = 4;
			text.resizeTextForBestFit = true;
			text.resizeTextMinSize = 0;
			component = text.GetComponent<RectTransform>();
			component.localPosition = Vector3.zero;
			component.sizeDelta = new Vector2(0.2f, 0.03f);
			component.localPosition = new Vector3(0.064f, 0.195f, 0f);
			component.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
			gameObject2 = GameObject.CreatePrimitive(3);
			Object.Destroy(gameObject2.GetComponent<Rigidbody>());
			gameObject2.GetComponent<BoxCollider>().isTrigger = true;
			gameObject2.transform.parent = Main.menu.transform;
			gameObject2.transform.rotation = Quaternion.identity;
			gameObject2.transform.localScale = new Vector3(0.09f, 0.2f, 0.9f);
			gameObject2.transform.localPosition = new Vector3(0.56f, -0.65f, 0f);
			gameObject2.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
			gameObject2.AddComponent<Button>().relatedText = "NextPage";
			colorChanger = gameObject2.AddComponent<ColorChanger>();
			colorChanger.colorInfo = Settings.buttonColors[0];
			colorChanger.Start();
			text = new GameObject
			{
				transform = 
				{
					parent = Main.canvasObject.transform
				}
			}.AddComponent<Text>();
			text.font = Settings.currentFont;
			text.text = ">";
			text.fontSize = 1;
			text.color = Settings.textColors[0];
			text.alignment = 4;
			text.resizeTextForBestFit = true;
			text.resizeTextMinSize = 0;
			component = text.GetComponent<RectTransform>();
			component.localPosition = Vector3.zero;
			component.sizeDelta = new Vector2(0.2f, 0.03f);
			component.localPosition = new Vector3(0.064f, -0.195f, 0f);
			component.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
			ButtonInfo[] array = Buttons.buttons[Main.buttonsType].Skip(Main.pageNumber * Settings.buttonsPerPage).Take(Settings.buttonsPerPage).ToArray<ButtonInfo>();
			for (int i = 0; i < array.Length; i++)
			{
				Main.CreateButton((float)i * 0.1f, array[i]);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000B858 File Offset: 0x00009A58
		public static void CreateButton(float offset, ButtonInfo method)
		{
			GameObject gameObject = GameObject.CreatePrimitive(3);
			Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.GetComponent<BoxCollider>().isTrigger = true;
			gameObject.transform.parent = Main.menu.transform;
			gameObject.transform.rotation = Quaternion.identity;
			gameObject.transform.localScale = new Vector3(0.09f, 0.9f, 0.08f);
			gameObject.transform.localPosition = new Vector3(0.56f, 0f, 0.28f - offset);
			gameObject.AddComponent<Button>().relatedText = method.buttonText;
			ColorChanger colorChanger = gameObject.AddComponent<ColorChanger>();
			bool enabled = method.enabled;
			if (enabled)
			{
				colorChanger.colorInfo = Settings.buttonColors[1];
			}
			else
			{
				colorChanger.colorInfo = Settings.buttonColors[0];
			}
			colorChanger.Start();
			Text text = new GameObject
			{
				transform = 
				{
					parent = Main.canvasObject.transform
				}
			}.AddComponent<Text>();
			text.font = Settings.currentFont;
			text.text = method.buttonText;
			bool flag = method.overlapText != null;
			if (flag)
			{
				text.text = method.overlapText;
			}
			text.supportRichText = true;
			text.fontSize = 1;
			bool enabled2 = method.enabled;
			if (enabled2)
			{
				text.color = Settings.textColors[1];
			}
			else
			{
				text.color = Settings.textColors[0];
			}
			text.alignment = 4;
			text.fontStyle = 2;
			text.resizeTextForBestFit = true;
			text.resizeTextMinSize = 0;
			RectTransform component = text.GetComponent<RectTransform>();
			component.localPosition = Vector3.zero;
			component.sizeDelta = new Vector2(0.2f, 0.03f);
			component.localPosition = new Vector3(0.064f, 0f, 0.111f - offset / 2.6f);
			component.rotation = Quaternion.Euler(new Vector3(180f, 90f, 90f));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000BA64 File Offset: 0x00009C64
		public static void RecreateMenu()
		{
			bool flag = Main.menu != null;
			if (flag)
			{
				Object.Destroy(Main.menu);
				Main.menu = null;
				Main.CreateMenu();
				Main.RecenterMenu(Settings.rightHanded, false);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		public static void RecenterMenu(bool isRightHanded, bool isKeyboardCondition)
		{
			bool flag = !isKeyboardCondition;
			if (flag)
			{
				bool flag2 = !isRightHanded;
				if (flag2)
				{
					Main.menu.transform.position = GorillaTagger.Instance.leftHandTransform.position;
					Main.menu.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
				}
				else
				{
					Main.menu.transform.position = GorillaTagger.Instance.rightHandTransform.position;
					Vector3 vector = GorillaTagger.Instance.rightHandTransform.rotation.eulerAngles;
					vector += new Vector3(0f, 0f, 180f);
					Main.menu.transform.rotation = Quaternion.Euler(vector);
				}
			}
			else
			{
				try
				{
					Main.TPC = GameObject.Find("Player Objects/Third Person Camera/Shoulder Camera").GetComponent<Camera>();
				}
				catch
				{
				}
				bool flag3 = Main.TPC != null;
				if (flag3)
				{
					Main.TPC.transform.position = new Vector3(-999f, -999f, -999f);
					Main.TPC.transform.rotation = Quaternion.identity;
					GameObject gameObject = GameObject.CreatePrimitive(3);
					gameObject.transform.localScale = new Vector3(10f, 10f, 0.01f);
					gameObject.transform.transform.position = Main.TPC.transform.position + Main.TPC.transform.forward;
					gameObject.GetComponent<Renderer>().material.color = new Color32((byte)(Settings.backgroundColor.colors[0].color.r * 50f), (byte)(Settings.backgroundColor.colors[0].color.g * 50f), (byte)(Settings.backgroundColor.colors[0].color.b * 50f), byte.MaxValue);
					Object.Destroy(gameObject, Time.deltaTime);
					Main.menu.transform.parent = Main.TPC.transform;
					Main.menu.transform.position = Main.TPC.transform.position + Vector3.Scale(Main.TPC.transform.forward, new Vector3(0.5f, 0.5f, 0.5f)) + Vector3.Scale(Main.TPC.transform.up, new Vector3(-0.02f, -0.02f, -0.02f));
					Vector3 eulerAngles = Main.TPC.transform.rotation.eulerAngles;
					eulerAngles..ctor(eulerAngles.x - 90f, eulerAngles.y + 90f, eulerAngles.z);
					Main.menu.transform.rotation = Quaternion.Euler(eulerAngles);
					bool flag4 = Main.reference != null;
					if (flag4)
					{
						bool isPressed = Mouse.current.leftButton.isPressed;
						if (isPressed)
						{
							Ray ray = Main.TPC.ScreenPointToRay(Mouse.current.position.ReadValue());
							RaycastHit raycastHit;
							bool flag5 = Physics.Raycast(ray, ref raycastHit, 100f);
							bool flag6 = flag5;
							if (flag6)
							{
								Button component = raycastHit.transform.gameObject.GetComponent<Button>();
								bool flag7 = component != null;
								if (flag7)
								{
									component.OnTriggerEnter(Main.buttonCollider);
								}
							}
						}
						else
						{
							Main.reference.transform.position = new Vector3(999f, -999f, -999f);
						}
					}
				}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000BE94 File Offset: 0x0000A094
		public static void CreateReference(bool isRightHanded)
		{
			Main.reference = GameObject.CreatePrimitive(0);
			if (isRightHanded)
			{
				Main.reference.transform.parent = GorillaTagger.Instance.leftHandTransform;
			}
			else
			{
				Main.reference.transform.parent = GorillaTagger.Instance.rightHandTransform;
			}
			Main.reference.GetComponent<Renderer>().material.color = Settings.backgroundColor.colors[0].color;
			Main.reference.transform.localPosition = new Vector3(0.013f, -0.025f, 0.1f);
			Main.reference.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
			Main.buttonCollider = Main.reference.GetComponent<SphereCollider>();
			ColorChanger colorChanger = Main.reference.AddComponent<ColorChanger>();
			colorChanger.colorInfo = Settings.backgroundColor;
			colorChanger.Start();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000BF8C File Offset: 0x0000A18C
		public static void Toggle(string buttonText)
		{
			int num = (Buttons.buttons[Main.buttonsType].Length + Settings.buttonsPerPage - 1) / Settings.buttonsPerPage - 1;
			bool flag = buttonText == "PreviousPage";
			if (flag)
			{
				Main.pageNumber--;
				bool flag2 = Main.pageNumber < 0;
				if (flag2)
				{
					Main.pageNumber = num;
				}
			}
			else
			{
				bool flag3 = buttonText == "NextPage";
				if (flag3)
				{
					Main.pageNumber++;
					bool flag4 = Main.pageNumber > num;
					if (flag4)
					{
						Main.pageNumber = 0;
					}
				}
				else
				{
					ButtonInfo index = Main.GetIndex(buttonText);
					bool flag5 = index != null;
					if (flag5)
					{
						bool isTogglable = index.isTogglable;
						if (isTogglable)
						{
							index.enabled = !index.enabled;
							bool enabled = index.enabled;
							if (enabled)
							{
								NotifiLib.SendNotification("<color=grey>[</color><color=green>ENABLE</color><color=grey>]</color> " + index.toolTip);
								bool flag6 = index.enableMethod != null;
								if (flag6)
								{
									try
									{
										index.enableMethod();
									}
									catch
									{
									}
								}
							}
							else
							{
								NotifiLib.SendNotification("<color=grey>[</color><color=red>DISABLE</color><color=grey>]</color> " + index.toolTip);
								bool flag7 = index.disableMethod != null;
								if (flag7)
								{
									try
									{
										index.disableMethod();
									}
									catch
									{
									}
								}
							}
						}
						else
						{
							NotifiLib.SendNotification("<color=grey>[</color><color=green>ENABLE</color><color=grey>]</color> " + index.toolTip);
							bool flag8 = index.method != null;
							if (flag8)
							{
								try
								{
									index.method();
								}
								catch
								{
								}
							}
						}
					}
					else
					{
						Debug.LogError(buttonText + " does not exist");
					}
				}
			}
			Main.RecreateMenu();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000C184 File Offset: 0x0000A384
		public static GradientColorKey[] GetSolidGradient(Color color)
		{
			return new GradientColorKey[]
			{
				new GradientColorKey(color, 0f),
				new GradientColorKey(color, 1f)
			};
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000C1C0 File Offset: 0x0000A3C0
		public static ButtonInfo GetIndex(string buttonText)
		{
			foreach (ButtonInfo[] array in Buttons.buttons)
			{
				foreach (ButtonInfo buttonInfo in array)
				{
					bool flag = buttonInfo.buttonText == buttonText;
					if (flag)
					{
						return buttonInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000C227 File Offset: 0x0000A427
		internal static void DestroyGun()
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000C22F File Offset: 0x0000A42F
		internal static bool GetGunInput(bool v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000C237 File Offset: 0x0000A437
		internal static object RenderGun()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400007B RID: 123
		public static GameObject menu;

		// Token: 0x0400007C RID: 124
		public static GameObject menuBackground;

		// Token: 0x0400007D RID: 125
		public static GameObject reference;

		// Token: 0x0400007E RID: 126
		public static GameObject canvasObject;

		// Token: 0x0400007F RID: 127
		public static SphereCollider buttonCollider;

		// Token: 0x04000080 RID: 128
		public static Camera TPC;

		// Token: 0x04000081 RID: 129
		public static Text fpsObject;

		// Token: 0x04000082 RID: 130
		public static int pageNumber;

		// Token: 0x04000083 RID: 131
		public static int buttonsType;

		// Token: 0x04000084 RID: 132
		internal static bool gunLocked;

		// Token: 0x04000085 RID: 133
		internal static VRRig lockTarget;
	}
}
