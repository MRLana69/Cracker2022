namespace UI.Popups;

public class ConsentPopup : UIScreen
{
	private UILabel _consentLongDetails; //Field offset: 0x28
	private UILabel _consentAffirmation; //Field offset: 0x2C
	private UILabel _okLabel; //Field offset: 0x30
	private UILabel _acceptLabel; //Field offset: 0x34
	private UIButtonOverlayOff _okButton; //Field offset: 0x38
	private UISprite _acceptButtonFill; //Field offset: 0x3C
	private UISprite _acceptButtonOverlay; //Field offset: 0x40
	private ButtonText _okButtonText; //Field offset: 0x44
	private UISprite _checkMarkSprite; //Field offset: 0x48
	private bool _isAcceptChecked; //Field offset: 0x4C
	private TweenAlpha _checkMarkTweenCoroutine; //Field offset: 0x50

	public ConsentPopup() { }

	public void AllowClicked() { }

	public void CheckboxClicked() { }

	public void English() { }

	public void French() { }

	public void German() { }

	public override void Init() { }

	public void Italian() { }

	public void Portuguese() { }

	public void PrivacyPolicyClicked(UILabel label) { }

	private void RefreshLabels() { }

	private void SetLanguage(string locale) { }

	public override void Show() { }

	public void Spanish() { }

}

