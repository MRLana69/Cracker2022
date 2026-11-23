using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class TutorialMissionPopup : CharacterPopup
{
	private UILabel topTitle;

	private UILabel middleTitle;

	private UILabel bottomTitle;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel line2Big;

	private UILabel line2Small;

	private UILabel line3Big;

	private UILabel line3Small;

	private UILabel buttonText;

	public override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
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
		SetCharacter(Characters.CharacterType.king, offsetFromAnchor, vector);
		topTitle.text = "Get";
		middleTitle.text = "Higher";
		bottomTitle.text = "Scores!";
		line1Big.text = "Complete a MISSION SET";
		line1Small.text = "Finish 3 MISSIONS to boost Multiplier";
		line2Big.text = "Get higher SCORE Multiplier!";
		line2Small.text = "All the way to SCORE x30!";
		line3Big.text = "Dominate the LEADERBOARD";
		line3Small.text = "Score x Multiplier = HIGHSCORE";
		buttonText.text = "Show Missions";
	}

	private void OkClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.QueuePopup("Mission_popup");
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogOkPressedOnPopup(flurryPopUpWithOkAndCloseName);
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.CloseActivePopups(screenName);
	}

	private void CloseClicked()
	{
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogClosePressedOnPopup(flurryPopUpWithOkAndCloseName);
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}
}
