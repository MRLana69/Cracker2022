using System;
using System.Collections;
using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;
using UnityEngine;

public class TopRunPopup : UIScreen
{
	[Serializable]
	private struct MedalCategory
	{
		public UILabel title;

		public UISprite background;
	}

	private UILabel _title;

	private UILabel _line1Big;

	private UILabel _line1Small;

	private UILabel _buttonText;

	private MedalCategory _diamond;

	private MedalCategory _gold;

	private MedalCategory _silver;

	private MedalCategory _bronze;

	private UISprite _topCountryFlag;

	private UILabel _topCountryName;

	private UISprite _infoTextBackground;

	private Layout _textLayout;

	public const int NEWEST_TOPRUN_POPUP_VERSION_NUMBER = 2;

	public override void Show()
	{
		//IL_000b: Expected VT, but got F4
		_silver = (MedalCategory)0.1f;
		_ = 1f;
		CancelInvoke();
	}

	public unsafe void OKClicked()
	{
		//IL_05a0: Expected I, but got Obj
		//IL_05b6: Expected Obj, but got I
		//IL_05f0: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0083: Expected I4, but got Obj
		//IL_00b1: Expected I4, but got Obj
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected Obj, but got Unknown
		//IL_061a: Expected Obj, but got VT
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected VT, but got Unknown
		//IL_064b: Expected F4, but got Obj
		//IL_0646: Expected native int or pointer, but got VT
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected Obj, but got Unknown
		//IL_0673: Expected F4, but got Obj
		//IL_066e: Expected native int or pointer, but got VT
		//IL_0688: Expected F4, but got I
		//IL_0683: Expected native int or pointer, but got VT
		//IL_0697: Expected I4, but got VT
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected Obj, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected Obj, but got Unknown
		//IL_06b9: Expected Obj, but got VT
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected Obj, but got Unknown
		//IL_06dc: Expected F4, but got Obj
		//IL_06d7: Expected native int or pointer, but got VT
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_0151: Expected F4, but got Obj
		//IL_014c: Expected native int or pointer, but got VT
		//IL_0166: Expected F4, but got I
		//IL_0161: Expected native int or pointer, but got VT
		//IL_017b: Expected I4, but got VT
		//IL_017b: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got VT
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01c0: Expected F4, but got Obj
		//IL_01bb: Expected native int or pointer, but got VT
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_01ed: Expected F4, but got Obj
		//IL_01e8: Expected native int or pointer, but got VT
		//IL_0202: Expected F4, but got I
		//IL_01fd: Expected native int or pointer, but got VT
		//IL_0217: Expected I4, but got VT
		//IL_0217: Expected Obj, but got I
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected Obj, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0239: Expected Obj, but got VT
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected Obj, but got Unknown
		//IL_025c: Expected F4, but got Obj
		//IL_0257: Expected native int or pointer, but got VT
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_0289: Expected F4, but got Obj
		//IL_0284: Expected native int or pointer, but got VT
		//IL_029e: Expected F4, but got I
		//IL_0299: Expected native int or pointer, but got VT
		//IL_02b3: Expected I4, but got VT
		//IL_02b3: Expected Obj, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected Obj, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected Obj, but got Unknown
		//IL_02d5: Expected Obj, but got VT
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected Obj, but got Unknown
		//IL_02f8: Expected F4, but got Obj
		//IL_02f3: Expected native int or pointer, but got VT
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_0325: Expected F4, but got Obj
		//IL_0320: Expected native int or pointer, but got VT
		//IL_033a: Expected F4, but got I
		//IL_0335: Expected native int or pointer, but got VT
		//IL_034f: Expected I4, but got VT
		//IL_034f: Expected Obj, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_037a: Expected I4, but got Obj
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_03a5: Expected I4, but got Obj
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected Obj, but got Unknown
		//IL_03d0: Expected I4, but got Obj
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03fb: Expected I4, but got Obj
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0412: Expected Obj, but got VT
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected Obj, but got Unknown
		//IL_0435: Expected F4, but got Obj
		//IL_0430: Expected native int or pointer, but got VT
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		//IL_0462: Expected F4, but got Obj
		//IL_045d: Expected native int or pointer, but got VT
		//IL_0477: Expected F4, but got I
		//IL_0472: Expected native int or pointer, but got VT
		//IL_0486: Expected I4, but got VT
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected Obj, but got Unknown
		//IL_049d: Expected Obj, but got VT
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04c0: Expected F4, but got Obj
		//IL_04bb: Expected native int or pointer, but got VT
		//IL_04df: Expected F4, but got Obj
		//IL_04da: Expected native int or pointer, but got VT
		//IL_04f4: Expected F4, but got I
		//IL_04ef: Expected native int or pointer, but got VT
		//IL_0503: Expected I4, but got VT
		//IL_0566: Expected Obj, but got I
		//IL_058b: Expected I4, but got Obj
		base.Hide();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v133 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("TOPRUN_TITLE");
		_title.fontSize = (int)text;
		string text2 = Strings.GetDefault("POPUP_TOPRUN_V2_LINE1");
		_line1Big.fontSize = (int)text2;
		string text3 = Strings.GetDefault("POPUP_TOPRUN_V2_LINE2");
		_line1Small.fontSize = (int)text3;
		((RewardForVideoButton)(object)_textLayout).Init((VideoButtonPayload)null);
		string text4 = Strings.GetDefault("OK");
		_buttonText.fontSize = (int)text4;
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v23 (Il2CppClass<GlobalColors>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v127 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 164;
		obj3 = GlobalColors.TOPRUN_POPUP_TEXT_BACKGROUND_PURPLE;
		object obj5 = obj4 + 180;
		obj5 = obj3;
		Matrix4x4 matrix4x = (Matrix4x4)(obj4 + 184);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
		object obj6 = obj4 + 144;
		Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v34+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_infoTextBackground.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj7 = this + 56;
		object obj8 = obj4 + 136;
		obj8 = GlobalColors.TOPRUN_POPUP_DIAMOND_BACKGROUND;
		object obj9 = obj4 + 176;
		obj9 = obj8;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj9;
		object obj10 = obj4 + 120;
		Matrix4x4 matrix4x3 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v45+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v22+4]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj11 = this - -64;
		object obj12 = obj4 + 112;
		obj12 = GlobalColors.TOPRUN_POPUP_GOLD_BACKGROUND;
		object obj13 = obj4 + 172;
		obj13 = obj12;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj13;
		object obj14 = obj4 + 96;
		Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S1_v56+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v25+4]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj15 = this + 72;
		object obj16 = obj4 + 92;
		obj16 = GlobalColors.TOPRUN_POPUP_SILVER_BACKGROUND;
		object obj17 = obj4 + 168;
		obj17 = obj16;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj17;
		object obj18 = obj4 + 72;
		Matrix4x4 matrix4x5 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S1_v67+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v28+4]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj19 = this + 80;
		object obj20 = obj4 - -64;
		obj20 = GlobalColors.TOPRUN_POPUP_BRONZE_BACKGROUND;
		object obj21 = obj4 + 160;
		obj21 = obj20;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj21;
		object obj22 = obj4 + 48;
		Matrix4x4 matrix4x6 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v78+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v31+4]");
		((UIWidget)0).rawPivot = (UIWidget.Pivot)matrix4x;
		object obj23 = this + 56;
		string text5 = Strings.GetDefault("TOPRUN_RANK_1_TITLE");
		((UILabel)obj23).fontSize = (int)text5;
		object obj24 = this - -64;
		string text6 = Strings.GetDefault("TOPRUN_RANK_2_TITLE");
		((UILabel)obj24).fontSize = (int)text6;
		object obj25 = this + 72;
		string text7 = Strings.GetDefault("TOPRUN_RANK_3_TITLE");
		((UILabel)obj25).fontSize = (int)text7;
		object obj26 = this + 80;
		string text8 = Strings.GetDefault("TOPRUN_RANK_4_TITLE");
		((UILabel)obj26).fontSize = (int)text8;
		object obj27 = obj4 + 40;
		obj27 = GlobalColors.TOPRUN_SCREEN_TITLE_COLOUR;
		object obj28 = obj4 + 116;
		obj28 = obj27;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj28;
		object obj29 = obj4 + 24;
		Matrix4x4 matrix4x7 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S1_v104+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_title.rawPivot = (UIWidget.Pivot)matrix4x;
		object obj30 = obj4 + 16;
		obj30 = GlobalColors.TOPRUN_COUNTRY_NAME_COLOUR;
		object obj31 = obj4 + 88;
		obj31 = obj30;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj31;
		Matrix4x4 matrix4x8 = Matrix4x4.Inverse(matrix4x);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
		_topCountryName.rawPivot = (UIWidget.Pivot)matrix4x;
		TopRunEventsHandler instance = TopRunEventsHandler.instance;
		IEnumerator enumerator = ((CountryPopup)(object)instance).DelayedSelect();
		UISprite topCountryFlag = _topCountryFlag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v119 (System.Collections.IEnumerator)+C]");
		topCountryFlag.fillCenter = false;
		TopRunEventsHandler instance2 = TopRunEventsHandler.instance;
		IEnumerator enumerator2 = ((CountryPopup)(object)instance2).DelayedSelect();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S1_v123 (System.Collections.IEnumerator)+8]");
		string text9 = Strings.GetDefault((string)0);
		string text10 = text9.ToUpperInvariant();
		_topCountryName.fontSize = (int)text10;
	}

	public TopRunPopup()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_00d7: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		_ = 1;
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag2).SwitchScreen("TopRunUI");
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).ClosePopup((GameObject)(object)screenName);
	}
}
