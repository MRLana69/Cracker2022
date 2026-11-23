using System;
using Cpp2ILInjected;
using SYBO.Subway.Info;
using UnityEngine;

public class TutorialFaceBookPopup : CharacterPopup
{
	private UILabel topTitle;

	private UILabel line1Big;

	private UILabel line1Small;

	private UILabel line2Big;

	private UILabel line2Small;

	private UILabel line3Big;

	private UILabel line3Small;

	private UILabel topLabel;

	private UILabel line2Label1;

	private UILabel line2Label2;

	private UISprite line2CoinSprite;

	private const float Y_LINE1_NO_REWARD = 0.5f;

	private const float Y_LINE1_WITH_REWARD = 9.5f;

	public unsafe override void Show()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected Obj, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected VT, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected VT, but got Unknown
		//IL_0178: Expected F4, but got I
		//IL_0173: Expected native int or pointer, but got VT
		//IL_01a0: Expected F4, but got I
		//IL_019b: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		base.Show();
		object obj2 = vector + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		object obj3 = vector + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Vector2? offsetFromAnchor = (Vector2?)(object)(vector + 32);
		Vector3? rotationOffset = (Vector3?)(object)(vector + 16);
		SetCharacter(Characters.CharacterType.tricky, offsetFromAnchor, rotationOffset);
		topTitle.text = "Play with Friends!";
		line1Big.text = "DISCOVER who else is playing";
		line1Small.text = "Join the Subway Surfers party!";
		line2Big.text = "Have FUN with your buddies";
		line2Small.text = "Surfing friends join your FRIEND list";
		line3Big.text = "COMPETE with friends";
		line3Small.text = "Who gets the HIGHEST SCORE?";
		Transform cachedTransform = topLabel.cachedTransform;
		Transform cachedTransform2 = topLabel.cachedTransform;
		Vector3 localPosition = cachedTransform2.localPosition;
		Transform cachedTransform3 = topLabel.cachedTransform;
		Vector3 localPosition2 = cachedTransform3.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		((Vector3*)(nint)vector)->z = 0f;
		_ = 1056964608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		((Vector3*)(nint)vector)->x = 0f;
		cachedTransform.localPosition = vector;
		line2Label1.enabled = false;
		line2Label2.enabled = false;
		line2CoinSprite.enabled = false;
	}

	private void OkClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.ignoreLastPopupClosed = true;
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.PushScreen("LeaderboardUI");
		SocialManager instance3 = SocialManager.instance;
		UIScreenController instance4 = UIScreenController.Instance;
		throw new ArgumentException();
	}

	private void CloseClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.ignoreLastPopupClosed = true;
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.PushScreen("LeaderboardUI");
		GameObject gameObject = base.gameObject;
		string goName = gameObject.name;
		string flurryPopUpWithOkAndCloseName = UIScreens.GetFlurryPopUpWithOkAndCloseName(goName);
		Flurry.LogClosePressedOnPopup(flurryPopUpWithOkAndCloseName);
		UIScreenController instance3 = UIScreenController.Instance;
		instance3.CloseActivePopups(screenName);
	}
}
