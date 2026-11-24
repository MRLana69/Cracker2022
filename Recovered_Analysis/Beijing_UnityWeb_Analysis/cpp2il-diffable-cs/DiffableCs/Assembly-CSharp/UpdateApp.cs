//Type is in global namespace

public class UpdateApp : CharacterPopup
{
	private static bool _isUpdateNowOnScreen; //Field offset: 0x0
	private static bool _hasShownThisSession; //Field offset: 0x1
	private UILabel title; //Field offset: 0x38
	private UILabel buttonLabel; //Field offset: 0x3C
	private UILabel changeListLabel; //Field offset: 0x40
	private UILabel okButtonLabel; //Field offset: 0x44
	private Layout _buttonLayout; //Field offset: 0x48

	private static UpdateApp() { }

	public UpdateApp() { }

	public static void AllowAgainThisSession() { }

	public void CloseClicked() { }

	public override void GainFocus() { }

	public override void Init() { }

	public override void LoseFocus() { }

	public void OkClicked() { }

	public override void Show() { }

	public static void ShowIfNeeded() { }

}

