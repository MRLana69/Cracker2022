using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInItemHunt : UISlideIn
{
	private UILabel _textLabel;

	private Layout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00f0: Expected I4, but got Obj
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_010d: Expected I4, but got Obj
		//IL_006a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SLIDE_IN_GIFT_TITLE");
		_textLabel.fontSize = (int)text;
		object obj2 = this - -64;
		((UILabel)obj2).fontSize = (int)slideIn.stringValue;
		string text2 = tag;
		((GameObject)(object)text2).tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.SlideIns.UISlideInItemHunt)+44]");
		((RewardForVideoButton)0).Init((VideoButtonPayload)1);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
