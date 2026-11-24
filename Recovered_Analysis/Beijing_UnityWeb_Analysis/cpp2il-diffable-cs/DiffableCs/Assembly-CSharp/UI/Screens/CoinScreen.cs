namespace UI.Screens;

public class CoinScreen : UIScreen
{
	private const float SPECIAL_SALE_NOTIFICATION_OFFSET = -59.5; //Field offset: 0x0
	private const string WINTER_SALE_OFFER_COLOR_CODE = "[E6E5A2]"; //Field offset: 0x0
	private const string WINTER_SALE_IGNORE_COLOR_CODE = "[c]"; //Field offset: 0x0
	private const string WINTER_SALE_IGNORE_COLOR_CLOSING_CODE = "[/c]"; //Field offset: 0x0
	private const string WINTER_SALE_END_COLOR_CODE = "[-]"; //Field offset: 0x0
	private const string ONLINESETTINGS_MOST_POPULAR_STICKER_PRODUCT_ID_WITHOUT_PREFIX = "most_popular_sticker_product_id_without_prefix"; //Field offset: 0x0
	private const int FIRST_PURCHASE_BONUS_BANNER_WIDTH = 330; //Field offset: 0x0
	private const int FIRST_PURCHASE_BONUS_BANNER_COINSCREEN_HEIGHT = 60; //Field offset: 0x0
	private const int FIRST_PURCHASE_BONUS_BANNER_HEIGHT = 82; //Field offset: 0x0
	private const int MOST_POPULAR_STICKER_PADDING = 3; //Field offset: 0x0
	private static readonly Vector2 MOST_POPULAR_STICKER_POSITION; //Field offset: 0x0
	private static readonly string[] MOST_POPULAR_STICKER_DEFAULT_PRODUCT_ID_WITHOUT_PREFIX; //Field offset: 0x8
	private static bool _facebookLoginRunning; //Field offset: 0xC
	private static bool _shouldRefreshScreen; //Field offset: 0xD
	public static bool openedFromWelcomePackGetNowClick; //Field offset: 0xE
	public GameObject coinPrefab; //Field offset: 0x28
	public GameObject coinEarnerPrefab; //Field offset: 0x2C
	public GameObject restorePrefab; //Field offset: 0x30
	public GameObject watchVideoPrefab; //Field offset: 0x34
	public GameObject facebookGiftPrefab; //Field offset: 0x38
	public GameObject specialSaleWinterHolidayNotificationPrefab; //Field offset: 0x3C
	public GameObject specialSaleNewYearNotificationPrefab; //Field offset: 0x40
	public Font headerFont; //Field offset: 0x44
	private GameObject _facebookRewardsButtonPrefab; //Field offset: 0x48
	private GameObject _doubleCoinsPrefab; //Field offset: 0x4C
	private GameObject _starterPackPrefab; //Field offset: 0x50
	private GameObject _firstPurchaseBonusBannerPrefab; //Field offset: 0x54
	private GameObject _welcomePackBannerPrefab; //Field offset: 0x58
	private GameObject _mostPopularStickerPrefab; //Field offset: 0x5C
	private UIScrollView _parentDragPanel; //Field offset: 0x60
	private UIWidget _outline; //Field offset: 0x64
	private GameObject listTitleComponent; //Field offset: 0x68
	private UIPanel _coinScreenPanel; //Field offset: 0x6C
	private UIPanel _scrollPanel; //Field offset: 0x70
	private CoinContainer _coinContainer; //Field offset: 0x74
	private GameObject _dynamicContentRoot; //Field offset: 0x78
	private VerticalLayout _dynamicContentVerticalLayout; //Field offset: 0x7C
	private ScrollViewHeightResizer _scrollViewHeightResizer; //Field offset: 0x80
	private bool shouldShowEarners; //Field offset: 0x84
	private GameObject _facebookRewardsButton; //Field offset: 0x88
	private GameObject _firstPurchaseBonusBannerGo; //Field offset: 0x8C
	private bool _wasWelcomePackActive; //Field offset: 0x90
	private bool _subscribedToEvents; //Field offset: 0x91
	private string[] _mostPopularStickerProductIds; //Field offset: 0x94
	private Action coinScreenHasAppeared; //Field offset: 0x98
	private GameObject _go; //Field offset: 0x9C
	private bool _hasUpdatedGeometryOnce; //Field offset: 0xA0

	public event Action coinScreenHasAppeared
	{
		 add { } //Length: 235
		 remove { } //Length: 113
	}

	private bool isVideoAddsSupported
	{
		 get { } //Length: 201
	}

	private static CoinScreen() { }

	public CoinScreen() { }

	private void <OnPanelGeometryUpdated>b__56_0() { }

	public void add_coinScreenHasAppeared(Action value) { }

	public static void FacebookLoginClicked() { }

	private static void FacebookStatusChanged(bool success) { }

	private void FillTable() { }

	private bool get_isVideoAddsSupported() { }

	private string[] GetMostPopularStickerProductIdsWithoutPrefix() { }

	public override void Hide() { }

	public override void Init() { }

	private void InsertEarner(int index, ref int numberOfObjects) { }

	private bool IsCoinScreenUnderPopup() { }

	private bool IsPopupOnTopOfCoinScreen(string popupName) { }

	private void OnApplicationResumed() { }

	public static void OnFacebookLoginResult(bool loggedIn) { }

	private static void OnFailSlideInFinish() { }

	private void OnOnlineSettingsFinishedDownloading() { }

	private void OnPanelGeometryUpdated() { }

	private void OnPopupClosed(string popupName) { }

	private void OnPopupShown(string popupName) { }

	private void OnProductRequestDone() { }

	private void OnPurchaseSuccess(string productId, bool wasRestored, IPurchaseValidationResult validationResult) { }

	private static void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	public void RefreshCurrencyEarners() { }

	private void RefreshMostPopularStickerProductIds() { }

	public void remove_coinScreenHasAppeared(Action value) { }

	private bool ShouldShowMostPopularSticker(InAppItemModel activeOffer) { }

	public override void Show() { }

	private void Update() { }

}

