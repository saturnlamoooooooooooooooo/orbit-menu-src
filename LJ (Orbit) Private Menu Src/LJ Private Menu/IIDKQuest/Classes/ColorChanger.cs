using System;
using MelonLoader;
using UnityEngine;

namespace IIDKQuest.Classes
{
	// Token: 0x0200001C RID: 28
	[RegisterTypeInIl2Cpp]
	public class ColorChanger : TimedBehaviour
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000C34C File Offset: 0x0000A54C
		public ColorChanger(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000C357 File Offset: 0x0000A557
		public override void Start()
		{
			base.Start();
			this.renderer = base.GetComponent<Renderer>();
			this.Update();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000C374 File Offset: 0x0000A574
		public override void Update()
		{
			base.Update();
			bool flag = this.colorInfo != null;
			if (flag)
			{
				bool flag2 = !this.colorInfo.copyRigColors;
				if (flag2)
				{
					Color color = new Gradient
					{
						colorKeys = this.colorInfo.colors
					}.Evaluate(Time.time / 2f % 1f);
					bool isRainbow = this.colorInfo.isRainbow;
					if (isRainbow)
					{
						float num = (float)Time.frameCount / 180f % 1f;
						color = Color.HSVToRGB(num, 1f, 1f);
					}
					this.renderer.material.color = color;
				}
				else
				{
					this.renderer.material = GorillaTagger.Instance.offlineVRRig.mainSkin.material;
				}
			}
		}

		// Token: 0x04000090 RID: 144
		public Renderer renderer;

		// Token: 0x04000091 RID: 145
		public ExtGradient colorInfo;
	}
}
