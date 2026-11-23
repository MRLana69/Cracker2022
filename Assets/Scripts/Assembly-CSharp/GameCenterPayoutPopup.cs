using Cpp2ILInjected;
using UI.Screens;

public class GameCenterPayoutPopup : UIScreen
{
	public UILabel titleLabel;

	public UILabel descLabel;

	public override void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006f: Expected I, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<GameCenterPayoutPopup>)+104] (should have been resolved before IL gen)");
		string text = Strings.Get(StringID.POPUP_PAYOUT_GAMECENTER_TITLE);
		titleLabel.text = text;
		string format = Strings.Get(StringID.POPUP_PAYOUT_GAMECENTER_DESC);
		_ = 250;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		string text2 = string.Format(format, arg);
		descLabel.text = text2;
	}

	public void OkClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		string currentPopupName = instance.GetCurrentPopupName();
		if (currentPopupName == "GameCenterPayoutPopup")
		{
			UIScreenController instance2 = UIScreenController.Instance;
			instance2.CloseActivePopups(screenName);
		}
	}
}
