using System;

namespace IIDKQuest.Classes
{
	// Token: 0x0200001B RID: 27
	public class ButtonInfo
	{
		// Token: 0x04000088 RID: 136
		public string buttonText = "-";

		// Token: 0x04000089 RID: 137
		public string overlapText = null;

		// Token: 0x0400008A RID: 138
		public Action method = null;

		// Token: 0x0400008B RID: 139
		public Action enableMethod = null;

		// Token: 0x0400008C RID: 140
		public Action disableMethod = null;

		// Token: 0x0400008D RID: 141
		public bool enabled = false;

		// Token: 0x0400008E RID: 142
		public bool isTogglable = true;

		// Token: 0x0400008F RID: 143
		public string toolTip = "This button doesn't have a tooltip/tutorial.";
	}
}
