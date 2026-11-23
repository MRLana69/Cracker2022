using Cpp2ILInjected;
using UI.Screens;

public class UIPreBragPopupHelper : UIScreen
{
	public UILabel description;

	private FriendHandlerBrag _bragHandler;

	public override void Init()
	{
		//IL_0005: Expected I, but got Obj
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<UIPreBragPopupHelper>)+104] (should have been resolved before IL gen)");
		FriendHandlerBrag instance = FriendHandlerBrag.instance;
		_bragHandler = instance;
	}

	public override void Show()
	{
		base.Show();
		FriendHandlerBrag bragHandler = _bragHandler;
		description.text = bragHandler.preBragPopupString;
	}

	private void BragClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.QueuePopup("BragPopup");
		UIScreenController instance2 = UIScreenController.Instance;
		instance2.CloseActivePopups(screenName);
	}

	private void CloseClicked()
	{
		UIScreenController instance = UIScreenController.Instance;
		instance.CloseActivePopups(screenName);
	}
}
