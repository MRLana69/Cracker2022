using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class TopRunPopup : UIScreen
{
	private UILabel _title;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel buttonText;

	private UISprite diamondBackground;

	private UISprite goldBackground;

	private UISprite silverBackground;

	private UISprite bronzeBackground;

	private UISprite _topCountryFlag;

	private UILabel _topCountryName;

	private UISprite _infoTextBackground;

	public const int NEWEST_TOPRUN_POPUP_VERSION_NUMBER = 2;

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_009c: Expected Obj, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got VT
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected VT, but got Unknown
		//IL_017f: Expected Obj, but got VT
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01b1: Expected Obj, but got VT
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_0206: Expected Obj, but got VT
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected VT, but got Unknown
		//IL_0267: Expected Obj, but got VT
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected Obj, but got Unknown
		//IL_0299: Expected Obj, but got VT
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got VT
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected VT, but got Unknown
		//IL_034a: Expected Obj, but got VT
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got VT
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03d1: Expected Obj, but got VT
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected VT, but got Unknown
		//IL_0432: Expected Obj, but got VT
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0464: Expected Obj, but got VT
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected Obj, but got Unknown
		//IL_04b9: Expected Obj, but got VT
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected VT, but got Unknown
		//IL_0515: Expected Obj, but got VT
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected Obj, but got Unknown
		//IL_0547: Expected Obj, but got VT
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected Obj, but got Unknown
		//IL_059c: Expected Obj, but got VT
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected VT, but got Unknown
		//IL_05fd: Expected Obj, but got VT
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected Obj, but got Unknown
		//IL_062f: Expected Obj, but got VT
		//IL_0659: Expected F4, but got I
		//IL_0654: Expected native int or pointer, but got VT
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_068c: Expected Obj, but got VT
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected Obj, but got Unknown
		//IL_06c4: Expected F4, but got I
		//IL_06bf: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 224);
		base.Show();
		string text = Strings.Get(StringID.POPUP_TOPRUN_TITLE);
		_title.text = text;
		string text2 = Strings.Get(StringID.POPUP_TOPRUN_V2_LINE1);
		line1Big.text = text2;
		string text3 = Strings.Get(StringID.POPUP_TOPRUN_V2_LINE2);
		line1Small.text = text3;
		string text4 = Strings.Get(StringID.OK);
		buttonText.text = text4;
		object obj2 = GlobalColors.TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE >> 16;
		object obj3 = obj2 & 0xFF;
		float num = (float)obj3 / 255f;
		object obj4 = GlobalColors.TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE >> 24;
		float num2 = (float)obj4 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
		_ = 0;
		object obj5 = GlobalColors.TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE & 0xFF;
		float num3 = (float)obj5 / 255f;
		object obj6 = GlobalColors.TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE >> 8;
		object obj7 = obj6 & 0xFF;
		float num4 = (float)obj7 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
		_ = 0;
		Color color2 = color + 96;
		_infoTextBackground.color = color2;
		object obj8 = GlobalColors.TOPRUN_POPUP_DIAMOND_BACKGROUND >> 16;
		object obj9 = obj8 & 0xFF;
		float num5 = (float)obj9 / 255f;
		object obj10 = GlobalColors.TOPRUN_POPUP_DIAMOND_BACKGROUND >> 24;
		float num6 = (float)obj10 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
		_ = 0;
		object obj11 = GlobalColors.TOPRUN_POPUP_DIAMOND_BACKGROUND & 0xFF;
		float num7 = (float)obj11 / 255f;
		object obj12 = GlobalColors.TOPRUN_POPUP_DIAMOND_BACKGROUND >> 8;
		object obj13 = obj12 & 0xFF;
		float num8 = (float)obj13 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
		_ = 0;
		Color color3 = color + 80;
		diamondBackground.color = color3;
		object obj14 = GlobalColors.TOPRUN_POPUP_GOLD_BACKGROUND >> 16;
		object obj15 = obj14 & 0xFF;
		float num9 = (float)obj15 / 255f;
		object obj16 = GlobalColors.TOPRUN_POPUP_GOLD_BACKGROUND >> 24;
		float num10 = (float)obj16 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
		_ = 0;
		object obj17 = GlobalColors.TOPRUN_POPUP_GOLD_BACKGROUND & 0xFF;
		float num11 = (float)obj17 / 255f;
		object obj18 = GlobalColors.TOPRUN_POPUP_GOLD_BACKGROUND >> 8;
		object obj19 = obj18 & 0xFF;
		float num12 = (float)obj19 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
		_ = 0;
		Color color4 = color - -64;
		goldBackground.color = color4;
		object obj20 = GlobalColors.TOPRUN_POPUP_SILVER_BACKGROUND >> 16;
		object obj21 = obj20 & 0xFF;
		float num13 = (float)obj21 / 255f;
		object obj22 = GlobalColors.TOPRUN_POPUP_SILVER_BACKGROUND >> 24;
		float num14 = (float)obj22 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
		_ = 0;
		object obj23 = GlobalColors.TOPRUN_POPUP_SILVER_BACKGROUND & 0xFF;
		float num15 = (float)obj23 / 255f;
		object obj24 = GlobalColors.TOPRUN_POPUP_SILVER_BACKGROUND >> 8;
		object obj25 = obj24 & 0xFF;
		float num16 = (float)obj25 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
		_ = 0;
		Color color5 = color + 48;
		silverBackground.color = color5;
		object obj26 = GlobalColors.TOPRUN_POPUP_BRONZE_BACKGROUND >> 16;
		object obj27 = obj26 & 0xFF;
		float num17 = (float)obj27 / 255f;
		object obj28 = GlobalColors.TOPRUN_POPUP_BRONZE_BACKGROUND >> 24;
		float num18 = (float)obj28 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
		_ = 0;
		object obj29 = GlobalColors.TOPRUN_POPUP_BRONZE_BACKGROUND & 0xFF;
		float num19 = (float)obj29 / 255f;
		object obj30 = GlobalColors.TOPRUN_POPUP_BRONZE_BACKGROUND >> 8;
		object obj31 = obj30 & 0xFF;
		float num20 = (float)obj31 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
		_ = 0;
		Color color6 = color + 32;
		bronzeBackground.color = color6;
		object obj32 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR >> 16;
		object obj33 = obj32 & 0xFF;
		float num21 = (float)obj33 / 255f;
		object obj34 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR >> 24;
		float num22 = (float)obj34 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
		_ = 0;
		object obj35 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR & 0xFF;
		float num23 = (float)obj35 / 255f;
		object obj36 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR >> 8;
		object obj37 = obj36 & 0xFF;
		float num24 = (float)obj37 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
		_ = 0;
		Color color7 = color + 16;
		_title.color = color7;
		object obj38 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR >> 16;
		object obj39 = obj38 & 0xFF;
		float num25 = (float)obj39 / 255f;
		object obj40 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR >> 24;
		float num26 = (float)obj40 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
		((Color*)(nint)color)->b = 0f;
		object obj41 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR & 0xFF;
		float num27 = (float)obj41 / 255f;
		object obj42 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR >> 8;
		object obj43 = obj42 & 0xFF;
		float num28 = (float)obj43 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
		((Color*)(nint)color)->r = 0f;
		_topCountryName.color = color;
		CountryManager instance = CountryManager.instance;
		Country currentTournamentCountry = instance.GetCurrentTournamentCountry();
		_topCountryFlag.spriteName = currentTournamentCountry.flag__BackingField;
		CountryManager instance2 = CountryManager.instance;
		Country currentTournamentCountry2 = instance2.GetCurrentTournamentCountry();
		string text5 = currentTournamentCountry2.name__BackingField.ToUpper();
		_topCountryName.text = text5;
		PlayerInfo instance3 = PlayerInfo.Instance;
		if (!instance3._hasShownTopRunIntroductionPopup)
		{
			instance3._dirty = true;
			instance3._hasShownTopRunIntroductionPopup = true;
		}
	}

	public void OKClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.ignoreLastPopupClosed = true;
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.PushScreen("TopRunUI");
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.CloseActivePopups(screenName);
	}
}
