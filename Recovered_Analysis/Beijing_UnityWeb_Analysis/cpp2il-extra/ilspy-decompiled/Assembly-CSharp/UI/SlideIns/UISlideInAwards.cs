using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInAwards : UISlideIn
{
	private UISprite _icon;

	private UILabel _textLine1;

	private Layout _layout;

	private GameObject _starObj;

	private const string CAN_BRONZE = "icon_bronze_can";

	private const string CAN_SILVER = "icon_silver_can";

	private const string CAN_GOLD = "icon_gold_can";

	private const string CAN_DIAMOND = "icon_diamond_can";

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0094: Expected Obj, but got I4
		//IL_00a2: Expected I, but got Obj
		//IL_00b8: Expected Obj, but got I
		//IL_00f2: Expected I4, but got Obj
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_005f: Expected I4, but got Obj
		//IL_006f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SLIDE_IN_ADS_REMOVED_FIRST_LINE");
		((UILabel)(object)_icon).fontSize = (int)text2;
		object obj2 = this - -64;
		string text3 = Strings.GetDefault("SLIDE_IN_ADS_REMOVED_SECOND_LINE");
		((UILabel)obj2).fontSize = (int)text3;
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)1);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
