namespace UI.Popups;

public class NotEnoughCurrencyPopup : UIScreen
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<bool> <>9__44_0; //Field offset: 0x4
		public static Action <>9__44_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CreateButtonPayload>b__44_0() { }

		internal void <CreateButtonPayload>b__44_1() { }

	}

	private enum PopupClosingAction
	{
		None = 0,
		Buy = 1,
		Cancel = 2,
		Ok = 3,
		VideoCoins = 4,
	}

	private const int FIRST_PURCHASE_BONUS_BANNER_WIDTH = 305; //Field offset: 0x0
	private const string STANDARD_VIDEO_REWARD = "-1"; //Field offset: 0x0
	private const string VIDEO_AVAIL_NO_TRY = "No_caching_not_attempted"; //Field offset: 0x0
	private const string BUTTON_NAME_CLOSE = "Closed"; //Field offset: 0x0
	private const string BUTTON_NAME_IAP = "IAP"; //Field offset: 0x0
	private const string BUTTON_NAME_VIDEO = "Video"; //Field offset: 0x0
	private const string BUTTON_NO_COOLDOWN = "No Cooldown"; //Field offset: 0x0
	private const string BUTTON_COOLDOWN = "Cooldown_{0}_watched"; //Field offset: 0x0
	private static InAppManagerPopupData _popupData; //Field offset: 0x0
	private const string VIDEO_AVAIL_YES = "Yes"; //Field offset: 0x0
	private const string VIDEO_AVAIL_FAIL = "No_caching_failed"; //Field offset: 0x0
	private static RewardForVideoButton _rewardForVideoButton; //Field offset: 0x4
	private UILabel popupTitle; //Field offset: 0x28
	private UILabel popupDescription; //Field offset: 0x2C
	private GameObject uiContentCoins; //Field offset: 0x30
	private GameObject uiContentKeys; //Field offset: 0x34
	private GameObject emptySpace; //Field offset: 0x38
	private GameObject uiContentVideoForCoins; //Field offset: 0x3C
	private Transform _dynamicContentRoot; //Field offset: 0x40
	private VerticalLayout _dynamicContentVerticalLayout; //Field offset: 0x44
	private UITable _table; //Field offset: 0x48
	private GameObject _currencyButtonPrefab; //Field offset: 0x4C
	private GameObject _firstPurchaseBonusBannerPrefab; //Field offset: 0x50
	private GameObject _okButtonPrefab; //Field offset: 0x54
	private GameObject _buyMoreInStoreLabelPrefab; //Field offset: 0x58
	private GameObject _emptySpace; //Field offset: 0x5C
	private Transform _popupContent; //Field offset: 0x60
	private PopupClosingAction _closingAction; //Field offset: 0x64
	private UiElementsManager _uiElementsManager; //Field offset: 0x68
	private GameObject _coinsForAdButton; //Field offset: 0x6C
	private GameObject _buyCurrencyButton; //Field offset: 0x70
	private GameObject _okButton; //Field offset: 0x74
	private GameObject _buyMoreInStorelabel; //Field offset: 0x78
	private GameObject _firstPurchaseBanner; //Field offset: 0x7C
	private int _newCoinPrice; //Field offset: 0x80
	private string _flurryVideoAvailable; //Field offset: 0x84
	private string _flurryButtonName; //Field offset: 0x88
	private string _flurryVideoReward; //Field offset: 0x8C
	private string _flurryCooldownStep; //Field offset: 0x90
	private VideoButtonPayload _videoButtonPayload; //Field offset: 0x94

	private static NotEnoughCurrencyPopup() { }

	public NotEnoughCurrencyPopup() { }

	private void <RefreshPopupContent>b__46_0() { }

	private void <RefreshPopupContent>b__46_1() { }

	private void <RefreshPopupContent>b__46_2() { }

	private void <RefreshPopupContent>b__46_3() { }

	private void ActivateUiElement(UiElementType uiElementType, GameObject prefab, OnActivatedPrefab onActivatedPrefab = null) { }

	private void CenterSelf() { }

	private static VideoButtonPayload CreateButtonPayload() { }

	private static int GetCachedRewardAmount() { }

	protected override string GetFlurryName() { }

	private void HandleOnCoinsForVideoFinished(string adLocation) { }

	public override void Hide() { }

	private void HideDynamicUiElements() { }

	public override void Init() { }

	public void OnBuyClicked() { }

	private void OnBuyMoreInStoreLabelActivated(GameObject activatedGo, bool wasSpawned) { }

	public void OnCancelClicked() { }

	private void OnCurrencyOfferActivated(GameObject currencyButtonGo, bool wasSpawned) { }

	private void OnFirstPurchaseBonusBannerSpawned(GameObject firstPurchaseBonusBannerGo, bool wasSpawned) { }

	private void OnOkButtonActivated(GameObject okButtonGo, bool wasSpawned) { }

	public void OnOkClicked() { }

	private void OnVideoForCoinsActivated(GameObject coinVideoGo, bool wasSpawned) { }

	private void Payout(PopupClosingAction action) { }

	private void RefreshPopupContent() { }

	public override void Show() { }

	private void Update() { }

	private void UpdateFirstPurchaseBonusBannerStatus() { }

}

