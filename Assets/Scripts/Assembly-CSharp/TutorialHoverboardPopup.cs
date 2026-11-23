using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class TutorialHoverboardPopup : CharacterPopup
{
	private UILabel topTitle;

	private UILabel bottomTitle;

	private UILabel subTitle;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel line2Big;

	private UILabel line2Small;

	private UILabel line3Big;

	private UILabel line3Small;

	private UILabel buttonText;

	private string hoverboardScreenType = string.Empty;

	private const int NUMBER_OF_FREE_HOVERBOARDS = 3;

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected Obj, but got Unknown
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
		Achievements instance = Achievements.Instance;
		if (instance.GetNumberOfHoverboardsUsed() == 0)
		{
			topTitle.text = "Need";
			bottomTitle.text = "Help?";
			subTitle.text = "Use the\nHOVERBOARDS!";
			line1Big.text = "SURF AWAY from trouble!";
			line1Small.text = "Boards save you from crashing";
			line2Big.text = "How to ACTIVATE?";
			line2Small.text = "DOUBLE TAP while running";
			line3Big.text = "Where can I get MORE?";
			line3Small.text = "Get Hoverboards in the Shop";
			buttonText.text = "Get 3 Free!";
			hoverboardScreenType = "GuidelineHoverboardNeverUsed";
		}
		else
		{
			topTitle.text = "Out of";
			bottomTitle.text = "Boards?";
			subTitle.text = "Here's 3 to\nget you going!";
			line1Big.text = "SURF AWAY from trouble!";
			line1Small.text = "Boards save you from crashing";
			line2Big.text = "Have another GO!";
			line2Small.text = "Get a flying start with 3 FREE Boards";
			line3Big.text = "Where can I get MORE?";
			line3Small.text = "Get Hoverboards in the Shop";
			buttonText.text = "Get 3 Free!";
			hoverboardScreenType = "GuidelineHoverboardNeverBought";
		}
	}

	private void OkClicked()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.IncreaseUpgradeAmount(PowerupType.hoverboard, 3);
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.QueuePopup("HoverboardPopup");
		string eventName = "POPUP Screen " + hoverboardScreenType;
		Flurry.LogOkPressedOnPopup(eventName);
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.CloseActivePopups(screenName);
	}

	private void CloseClicked()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		instance.IncreaseUpgradeAmount(PowerupType.hoverboard, 3);
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.QueuePopup("HoverboardPopup");
		string eventName = "POPUP Screen " + hoverboardScreenType;
		Flurry.LogClosePressedOnPopup(eventName);
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.CloseActivePopups(screenName);
	}
}
