using System;
using MelonLoader;
using UnityEngine;

namespace IIDKQuest.Classes
{
	// Token: 0x0200001F RID: 31
	[RegisterTypeInIl2Cpp]
	public class TimedBehaviour : MonoBehaviour
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000C75C File Offset: 0x0000A95C
		public TimedBehaviour(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000C792 File Offset: 0x0000A992
		public virtual void Start()
		{
			this.startTime = Time.time;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		public virtual void Update()
		{
			bool flag = !this.complete;
			if (flag)
			{
				this.progress = Mathf.Clamp((Time.time - this.startTime) / this.duration, 0f, 1f);
				bool flag2 = Time.time - this.startTime > this.duration;
				if (flag2)
				{
					bool flag3 = this.loop;
					if (flag3)
					{
						this.OnLoop();
					}
					else
					{
						this.complete = true;
					}
				}
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000C81D File Offset: 0x0000AA1D
		public virtual void OnLoop()
		{
			this.startTime = Time.time;
		}

		// Token: 0x04000095 RID: 149
		public bool complete = false;

		// Token: 0x04000096 RID: 150
		public bool loop = true;

		// Token: 0x04000097 RID: 151
		public float progress = 0f;

		// Token: 0x04000098 RID: 152
		protected bool paused = false;

		// Token: 0x04000099 RID: 153
		protected float startTime;

		// Token: 0x0400009A RID: 154
		protected float duration = 2f;
	}
}
