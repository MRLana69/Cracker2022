namespace UI.Popups;

public class QuitApplicationPopup : UIScreen
{
	private UILabel _title; //Field offset: 0x28
	private UILabel _description; //Field offset: 0x2C
	private UILabel _subDescription; //Field offset: 0x30
	private UILabel _yesLabel; //Field offset: 0x34
	private UILabel _noLabel; //Field offset: 0x38

	public QuitApplicationPopup() { }

	public override void Init() { }

	public void NoClicked() { }

	private void Update() { }

	public void YesClicked() { }

}

