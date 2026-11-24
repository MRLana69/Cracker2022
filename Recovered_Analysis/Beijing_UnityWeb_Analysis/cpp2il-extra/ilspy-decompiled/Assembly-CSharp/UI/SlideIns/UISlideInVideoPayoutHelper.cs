using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInVideoPayoutHelper : UISlideIn
{
	private UILabel _line1;

	private UILabel _prizeCount;

	private Layout _layout;

	private Layout _line2Layout;

	private UISprite _rewardSprite;

	private FitSpriteToWidget _spriteFitter;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0083: Expected Obj, but got I4
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_00e1: Expected I4, but got Obj
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		//IL_00fe: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SLIDE_IN_UNLOCKED");
		_line1.fontSize = (int)text2;
		object obj2 = this - -64;
		((UILabel)obj2).fontSize = (int)slideIn.stringValue;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
