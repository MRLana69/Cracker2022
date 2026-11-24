namespace UI.Popups;

public class CloudSaveConfirmationPopup : UIScreen
{
	private UILabel _text; //Field offset: 0x28
	private UILabel _badButton; //Field offset: 0x2C
	private UILabel _goodButton; //Field offset: 0x30
	private UISprite _cornerIcon; //Field offset: 0x34
	private UISprite _cornerAccentIcon; //Field offset: 0x38
	private UISprite _splat; //Field offset: 0x3C
	private UISprite _splatShadow; //Field offset: 0x40
	private FitSpriteToWidget _fitCornerIcon; //Field offset: 0x44
	private FitSpriteToWidget _fitCornerAccentIcon; //Field offset: 0x48
	private CloudSaveConfirmationPopupPayload _payload; //Field offset: 0x4C

	public CloudSaveConfirmationPopup() { }

	public void BadButtonClicked() { }

	private void FlurryLogConfirmationPopup(string parameterValue) { }

	public void GoodButtonClicked() { }

	public override void Init() { }

	private void SetupBasic() { }

	private void SetupConfirmation(CloudSaveConfirmationPopupPayload payload) { }

	private void SetupDisconnect() { }

	private void SetupKeepLocal() { }

	private void SetupKeepOnline() { }

	private void SetupLoadProgress() { }

	public override void Show() { }

}

