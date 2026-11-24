namespace UI.Popups;

public class WithdrawConsentPopup : UIScreen
{
	private UILabel _header; //Field offset: 0x28
	private UILabel _bodyText; //Field offset: 0x2C
	private UILabel _requirement; //Field offset: 0x30
	private UILabel _verification; //Field offset: 0x34
	private UILabel _okLabel; //Field offset: 0x38
	private UILabel _cancelLabel; //Field offset: 0x3C

	public WithdrawConsentPopup() { }

	public override void Init() { }

	private void LogWithdraw(string result) { }

	public void OnClose() { }

	public void OnNoClicked() { }

	public void WithdrawClicked() { }

}

