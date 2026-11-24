namespace UI.Popups.SettingsPopupInternal;

public class SettingsLogInFacebookButton : MonoBehaviour
{
	private UILabel _title; //Field offset: 0xC
	private UILabel _description; //Field offset: 0x10
	private Layout _layout; //Field offset: 0x14
	private UISprite _fbIcon; //Field offset: 0x18
	private UISprite _spinner; //Field offset: 0x1C
	private GameObject _overlay; //Field offset: 0x20
	private UISprite _fill; //Field offset: 0x24
	private SettingsPopup _settingsPopup; //Field offset: 0x28
	private bool _facebookLoginRunning; //Field offset: 0x2C

	public SettingsLogInFacebookButton() { }

	private void FacebookStatusChanged(bool success) { }

	public void InitButton(SettingsPopup settingsPopup) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFailSlideInFinish() { }

	private void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	private void SetToConnectingState() { }

	private void SetToLogInState() { }

}

