using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.ScrollListSelectPopup;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInCharacterEventRewardHelper : UISlideIn
{
	private UILabel _label;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		((UI.ScrollListSelectPopup.ScrollListSelectPopup)(object)this).InsertToggle((string)slideIn.value, slideIn.stringValue);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInCharacterEventRewardHelper)+44]");
		((RewardForVideoButton)0).Init(null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}

	private void SetLabel(string payload)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		((UISlideInCloudSave)this).SetupSlideIn((SlideIn)payload.m_firstChar);
		object obj = this - -64;
		((RewardForVideoButton)obj).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
