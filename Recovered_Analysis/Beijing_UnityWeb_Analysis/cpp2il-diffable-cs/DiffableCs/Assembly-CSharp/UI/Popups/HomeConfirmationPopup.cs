namespace UI.Popups;

public class HomeConfirmationPopup : UIScreen
{
	private UILabel _title; //Field offset: 0x28
	private UILabel _description; //Field offset: 0x2C
	private UILabel _subDescription; //Field offset: 0x30
	private UILabel _noLabel; //Field offset: 0x34
	private UILabel _yesLabel; //Field offset: 0x38

	public HomeConfirmationPopup() { }

	public override void Init() { }

	public void NoClicked() { }

	private void Update() { }

	public void YesClicked() { }

}

