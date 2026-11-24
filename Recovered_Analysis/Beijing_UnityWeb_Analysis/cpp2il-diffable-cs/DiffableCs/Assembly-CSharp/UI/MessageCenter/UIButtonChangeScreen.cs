namespace UI.MessageCenter;

public class UIButtonChangeScreen : UIBasicButton
{
	public enum ScreenChangeType
	{
		PushScreen = 0,
		SwitchScreen = 1,
		BackToPrevious = 2,
		QueuePopup = 3,
		ClosePopup = 4,
		PushPopup = 5,
	}

	public ScreenChangeType screenChangeType; //Field offset: 0x10
	private string _screenName; //Field offset: 0x14
	private string _popupName; //Field offset: 0x18
	private string[] _popups; //Field offset: 0x1C
	private string[] _screens; //Field offset: 0x20

	public string PopupName
	{
		 get { } //Length: 20
		 set { } //Length: 44
	}

	public UIButtonChangeScreen() { }

	public string get_PopupName() { }

	public string GetScreenOrPopupName() { }

	public override void Send() { }

	public void set_PopupName(string value) { }

	private bool ShowPopups() { }

	private bool ShowScreens() { }

	private void UpdateAndSortLists() { }

}

