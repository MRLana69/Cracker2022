using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInOfferPayoutHelper : UISlideIn
{
	private UILabel _line1;

	private UILabel _price;

	private Layout _layout;

	private Layout _line2Layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0011: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I
		//IL_007d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInOfferPayoutHelper)+4C]");
		string text = ((Component)0).tag;
		((GameObject)(object)text).tag = (string)(object)slideIn;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInOfferPayoutHelper)+50]");
		string text2 = ((Component)0).tag;
		((GameObject)(object)text2).tag = (string)(object)slideIn;
		if (slideIn != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInOfferPayoutHelper)+58]");
			((RewardForVideoButton)0).Init(null);
		}
	}
}
