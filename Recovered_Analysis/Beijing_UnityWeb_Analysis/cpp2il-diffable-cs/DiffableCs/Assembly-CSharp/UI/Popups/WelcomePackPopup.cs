namespace UI.Popups;

public class WelcomePackPopup : UIScreen
{
	private UILabel _title; //Field offset: 0x28
	private UILabel _subtitle; //Field offset: 0x2C
	private GameObject _hoverBoardRenderObject; //Field offset: 0x30
	private DefaultRenderTextureSetup _particleSystemSetup; //Field offset: 0x34

	public WelcomePackPopup() { }

	private void ClosePopup() { }

	public override void GainFocus() { }

	public override void Init() { }

	public override void LoseFocus() { }

	public void OnCloseButtonClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	public override void Show() { }

}

