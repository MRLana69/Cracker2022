namespace UI.Popups;

public class RatingPopup : CharacterPopup
{
	private UILabel bigLabel; //Field offset: 0x38
	private UILabel pleaseLabel; //Field offset: 0x3C
	private UILabel rateButtonLabel; //Field offset: 0x40
	private UILabel cancelButtonLabel; //Field offset: 0x44
	private UILabel notAgainLabel; //Field offset: 0x48
	private UIToggle notAgainCheckBox; //Field offset: 0x4C
	private Layout _checkMarkLayout; //Field offset: 0x50

	public RatingPopup() { }

	public void CancelClicked() { }

	public void OkClicked() { }

	public override void Show() { }

}

