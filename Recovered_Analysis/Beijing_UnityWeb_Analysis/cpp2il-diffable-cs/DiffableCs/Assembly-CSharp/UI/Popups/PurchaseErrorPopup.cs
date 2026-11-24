namespace UI.Popups;

public class PurchaseErrorPopup : UIScreen
{
	private UILabel _title; //Field offset: 0x28
	private UILabel _description; //Field offset: 0x2C
	private UILabel _okButtonLabel; //Field offset: 0x30

	public PurchaseErrorPopup() { }

	public override void Hide() { }

	public void OnOkButtonClicked() { }

	public override void Show() { }

}

