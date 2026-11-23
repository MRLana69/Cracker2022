using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

namespace UI.Popups;

public class WelcomePopup : CharacterPopup
{
	private UILabel _titleLine;

	private UILabel _line1Big;

	private UILabel _line1Small;

	private UILabel _line2Big;

	private UILabel _line2Small;

	private UILabel _line3Big;

	private UILabel _line3Small;

	private UILabel _buttonText;

	private UISprite _calloutBackgroundSprite;

	private UISprite _calloutBackgroundTriangleSprite;

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected VT, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected VT, but got Unknown
		//IL_04a2: Expected native int or pointer, but got VT
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected VT, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected VT, but got Unknown
		//IL_01a5: Expected Obj, but got VT
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01d7: Expected Obj, but got VT
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_022c: Expected Obj, but got VT
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected VT, but got Unknown
		//IL_028d: Expected Obj, but got VT
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02bf: Expected Obj, but got VT
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_0314: Expected Obj, but got VT
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected VT, but got Unknown
		//IL_0370: Expected Obj, but got VT
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_03a2: Expected Obj, but got VT
		//IL_03cc: Expected F4, but got I
		//IL_03c7: Expected native int or pointer, but got VT
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03ff: Expected Obj, but got VT
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0437: Expected F4, but got I
		//IL_0432: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 176);
		_ = 0;
		_ = 0;
		base.Show();
		_ = 0;
		_ = 4656722015811272704L;
		_ = 4656722015811272704L;
		_ = 0;
		Vector2? vector = (Vector2?)(object)(color + 144);
		Vector2 value = (Vector2)(color + 80);
		*(Vector2?*)(nint)vector = value;
		object obj2 = color + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
		_ = 0;
		Vector2? offsetFromAnchor = (Vector2?)(object)(color - -64);
		Vector3? rotationOffset = (Vector3?)(object)(color + 48);
		SetCharacter(Characters.CharacterType.nick, offsetFromAnchor, rotationOffset);
		string text = Strings.Get(StringID.POPUP_WELCOME_TITLE_LINE_1);
		_titleLine.text = text;
		string text2 = Strings.Get(StringID.OK);
		_buttonText.text = text2;
		string text3 = Strings.Get(StringID.POPUP_WELCOME_LINE1BIG);
		_line1Big.text = text3;
		string text4 = Strings.Get(StringID.POPUP_WELCOME_LINE1SMALL);
		_line1Small.text = text4;
		string text5 = Strings.Get(StringID.POPUP_WELCOME_LINE2BIG);
		_line2Big.text = text5;
		string text6 = Strings.Get(StringID.POPUP_WELCOME_LINE2SMALL);
		_line2Small.text = text6;
		string text7 = Strings.Get(StringID.POPUP_WELCOME_LINE3BIG);
		_line3Big.text = text7;
		string text8 = Strings.Get(StringID.POPUP_WELCOME_LINE3SMALL);
		_line3Small.text = text8;
		object obj3 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR >> 16;
		object obj4 = obj3 & 0xFF;
		float num = (float)obj4 / 255f;
		object obj5 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR >> 24;
		float num2 = (float)obj5 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
		_ = 0;
		object obj6 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR & 0xFF;
		float num3 = (float)obj6 / 255f;
		object obj7 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR >> 8;
		object obj8 = obj7 & 0xFF;
		float num4 = (float)obj8 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
		_ = 0;
		Color color2 = color + 32;
		_calloutBackgroundSprite.color = color2;
		object obj9 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR >> 16;
		object obj10 = obj9 & 0xFF;
		float num5 = (float)obj10 / 255f;
		object obj11 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR >> 24;
		float num6 = (float)obj11 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
		_ = 0;
		object obj12 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR & 0xFF;
		float num7 = (float)obj12 / 255f;
		object obj13 = GlobalColors.WELCOMEPOPUP_BUBBLE_COLOR >> 8;
		object obj14 = obj13 & 0xFF;
		float num8 = (float)obj14 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+68]");
		_ = 0;
		Color color3 = color + 16;
		_calloutBackgroundTriangleSprite.color = color3;
		object obj15 = GlobalColors.WELCOMEPOPUP_BUBBLE_TEXT_COLOR >> 16;
		object obj16 = obj15 & 0xFF;
		float num9 = (float)obj16 / 255f;
		object obj17 = GlobalColors.WELCOMEPOPUP_BUBBLE_TEXT_COLOR >> 24;
		float num10 = (float)obj17 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+60]");
		((Color*)(nint)color)->b = 0f;
		object obj18 = GlobalColors.WELCOMEPOPUP_BUBBLE_TEXT_COLOR & 0xFF;
		float num11 = (float)obj18 / 255f;
		object obj19 = GlobalColors.WELCOMEPOPUP_BUBBLE_TEXT_COLOR >> 8;
		object obj20 = obj19 & 0xFF;
		float num12 = (float)obj20 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+58]");
		((Color*)(nint)color)->r = 0f;
		_titleLine.color = color;
	}

	public void OkClicked()
	{
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogOkPressedOnPopup(flurryPopUpWithOkAndCloseName);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}
}
