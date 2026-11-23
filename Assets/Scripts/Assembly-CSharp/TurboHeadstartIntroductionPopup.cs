using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class TurboHeadstartIntroductionPopup : CharacterPopup
{
	private UILabel topTitle;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel line2Big;

	private UILabel line2Small;

	private UILabel line3Big;

	private UILabel line3Small;

	private UILabel buttonText;

	private const int NUMBER_OF_FREE_HEADSTARTS = 3;

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_004a: Expected VT, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected VT, but got Unknown
		object obj = default;
		Vector3? vector = (Vector3?)(object)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		base.Show();
		object obj2 = (Nullable)vector - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+40]");
		_ = 0;
		object obj3 = (Nullable)vector + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Nullable`1<UnityEngine.Vector3>)+30]");
		vector = (Vector3?)(object)0;
		Vector2? offsetFromAnchor = (Vector2?)(object)((Nullable)vector + 16);
		SetCharacter(Characters.CharacterType.slick, offsetFromAnchor, vector);
		string text = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_TITLE);
		topTitle.text = text;
		string text2 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_LINE1BIG);
		line1Big.text = text2;
		string text3 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_LINE1SMALL);
		line1Small.text = text3;
		string text4 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_LINE2BIG);
		line2Big.text = text4;
		string text5 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_LINE2SMALL);
		line2Small.text = text5;
		string text6 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_LINE3BIG);
		line3Big.text = text6;
		string text7 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_LINE3SMALL);
		line3Small.text = text7;
		string text8 = Strings.Get(StringID.TURBO_HEADSTART_INTRODUCTION_POPUP_BUTTON_TEXT);
		buttonText.text = text8;
	}

	private void OkClicked()
	{
		Close();
		Flurry.LogOkPressedOnPopup("POPUP Screen TurboHeadstartIntroductionPopup");
	}

	private void CloseClicked()
	{
		Close();
		Flurry.LogClosePressedOnPopup("POPUP Screen TurboHeadstartIntroductionPopup");
	}

	private void Close()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.IncreaseUpgradeAmount(PowerupType.headstart2000, 3);
		PlayerInfo instance2 = PlayerInfo.Instance;
		if (!instance2._hasShownTurboHeadstartIntroductionPopup)
		{
			instance2._dirty = true;
			instance2._hasShownTurboHeadstartIntroductionPopup = true;
		}
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.ignoreLastPopupClosed = true;
		UIScreenController instance4 = UIScreenController.Instance;
		instance4.CloseActivePopups(screenName);
		UIScreenController instance5 = UIScreenController.Instance;
		instance5.PushScreen("UpgradesUI_shop");
	}
}
