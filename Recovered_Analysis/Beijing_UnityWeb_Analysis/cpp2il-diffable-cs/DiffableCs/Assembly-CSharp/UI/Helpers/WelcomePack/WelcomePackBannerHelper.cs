namespace UI.Helpers.WelcomePack;

public class WelcomePackBannerHelper : MonoBehaviour
{
	private UILabel _title; //Field offset: 0xC
	private UILabel _boardName; //Field offset: 0x10
	private DefaultRenderTextureSetup _mainCellRenderTextureSetup; //Field offset: 0x14
	private UILabel _cell1Label; //Field offset: 0x18
	private DefaultRenderTextureSetup _cell1RenderTextureSetup; //Field offset: 0x1C
	private UILabel _cell2Label; //Field offset: 0x20
	private DefaultRenderTextureSetup _cell2RenderTextureSetup; //Field offset: 0x24
	private UILabel _cell3Label; //Field offset: 0x28
	private DefaultRenderTextureSetup _cell3RenderTextureSetup; //Field offset: 0x2C
	private UILabel _buyButtonLabel; //Field offset: 0x30
	private TimerHelper _timerPrefab; //Field offset: 0x34
	private UIWidget _timerContainer; //Field offset: 0x38
	private string _lastScreenNameWhenPressingBuy; //Field offset: 0x3C
	private TimerHelper _timer; //Field offset: 0x40
	private InAppItemModel _inAppPack; //Field offset: 0x44
	private bool _isSetup; //Field offset: 0x48

	public WelcomePackBannerHelper() { }

	private void DeactivateCells() { }

	private void LoadInAppPackIfNotLoaded() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnItemRestoreFinished(RestoreFinishedResult result) { }

	public void OnPurchaseClick() { }

	private void OnPurchaseClickInPopup(UIScreenController uiScreenController) { }

	private void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	private void Setup() { }

	private void SetupLabels(List<BundleItem> content) { }

	private void SetupModels() { }

	private void SetupTimer() { }

}

