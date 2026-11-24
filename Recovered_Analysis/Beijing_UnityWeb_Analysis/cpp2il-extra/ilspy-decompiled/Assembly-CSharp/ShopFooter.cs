using Cpp2ILInjected;
using UnityEngine;

public class ShopFooter : MonoBehaviour
{
	private UILabel menuButtonLabel;

	private UILabel boostsButtonLabel;

	private UILabel boostsCoolDealLabel;

	private UILabel boostsCoolDealSingleLineLabel;

	private UILabel earnCoinsButtonLabel;

	private UILabel storeButtonLabel;

	private UILabel storeCoolDealLabel;

	private UILabel storeCoolDealSingleLineLabel;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public ShopFooter()
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0148: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00a5: Expected I4, but got Obj
		//IL_00c7: Expected I4, but got Obj
		//IL_00e9: Expected I4, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("FOOTER_MENU_BUTTON_TITLE");
		menuButtonLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("FOOTER_BOOSTS_BUTTON_TITLE");
		boostsButtonLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("COOL_DEAL_SINGLE_LINE");
		boostsCoolDealSingleLineLabel.fontSize = (int)text3;
		string text4 = Strings.GetDefault("EARN_COINS_BUTTON_LABEL");
		earnCoinsButtonLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("STORE_TITLE");
		storeButtonLabel.fontSize = (int)text5;
		string text6 = Strings.GetDefault("COOL_DEAL_SINGLE_LINE");
		storeCoolDealSingleLineLabel.fontSize = (int)text6;
	}
}
