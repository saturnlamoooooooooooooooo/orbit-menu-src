using System;
using GorillaLocomotion;

namespace IIDKQuest.Mods
{
	// Token: 0x02000016 RID: 22
	internal class VrRigMods
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x000088AD File Offset: 0x00006AAD
		public static void NoTapCooldown()
		{
			GorillaTagger.Instance.tapCoolDown = 0f;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000088C0 File Offset: 0x00006AC0
		public static void SlowTapdown()
		{
			GorillaTagger.Instance.tapCoolDown = 3.2f;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000088D3 File Offset: 0x00006AD3
		public static void LoudHandTaps()
		{
			GorillaTagger.Instance.handTapVolume = 999f;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000088E6 File Offset: 0x00006AE6
		public static void SilentHandTaps()
		{
			GorillaTagger.Instance.handTapVolume = 0f;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000088F9 File Offset: 0x00006AF9
		public static void NoHandTaps()
		{
			GorillaTagger.Instance.tapCoolDown = 1E+16f;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000890C File Offset: 0x00006B0C
		public static void FixTaps()
		{
			GorillaTagger.Instance.tapCoolDown = 2f;
			GorillaTagger.Instance.handTapVolume = 0.1f;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000892F File Offset: 0x00006B2F
		public static void TagFreeze()
		{
			Player.Instance.disableMovement = true;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000893E File Offset: 0x00006B3E
		public static void NoTagFreeze()
		{
			Player.Instance.disableMovement = false;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000894D File Offset: 0x00006B4D
		public static void SlideControl()
		{
			Player.Instance.slideControl = 100f;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00008960 File Offset: 0x00006B60
		public static void GrippyHands()
		{
			Player.Instance.leftHandSlide = false;
			Player.Instance.rightHandSlide = false;
		}
	}
}
