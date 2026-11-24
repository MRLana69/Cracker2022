using Cpp2ILInjected;
using SYBO.Subway.Info;
using UI.Generic.Layout;
using UI.Popups;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInGift : UISlideIn
{
	private UILabel _title;

	private UILabel _gift;

	private HorizontalLayout _layout;

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_0099: Expected Obj, but got I4
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_00f7: Expected I4, but got Obj
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_005f: Expected I4, but got Obj
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
		string text2 = Strings.GetDefault("FIRST_PURCHASE_SLIDE_IN_TITLE");
		_title.fontSize = (int)text2;
		object obj2 = this - -64;
		string text3 = Strings.GetDefault("FIRST_PURCHASE_SLIDE_IN_SUB_TITLE");
		((UILabel)obj2).fontSize = (int)text3;
		((CharacterPromotionPopup)(object)_layout).OnCharacterPurchaseSuccess(Characters.CharacterId.slick, 1);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}
}
