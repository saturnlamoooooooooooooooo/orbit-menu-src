using System;
using UnityEngine;

namespace IIDKQuest.Classes
{
	// Token: 0x0200001D RID: 29
	public class ExtGradient
	{
		// Token: 0x04000092 RID: 146
		public GradientColorKey[] colors = new GradientColorKey[]
		{
			new GradientColorKey(new Color(0.5f, 0f, 0f), 0f),
			new GradientColorKey(new Color(0.86f, 0.08f, 0.24f), 0.5f),
			new GradientColorKey(new Color(0.5f, 0f, 0f), 1f)
		};

		// Token: 0x04000093 RID: 147
		public bool isRainbow = false;

		// Token: 0x04000094 RID: 148
		public bool copyRigColors = false;
	}
}
