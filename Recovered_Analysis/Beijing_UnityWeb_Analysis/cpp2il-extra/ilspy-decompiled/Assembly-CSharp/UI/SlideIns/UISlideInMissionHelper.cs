using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInMissionHelper : UISlideIn
{
	private UILabel _line1;

	private UILabel _line2;

	private Layout _layout;

	private Layout _line2Layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0018: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		((RewardForVideoButton)(object)_line1).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
