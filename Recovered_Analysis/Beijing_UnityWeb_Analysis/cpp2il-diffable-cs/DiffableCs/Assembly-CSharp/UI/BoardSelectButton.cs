namespace UI;

public class BoardSelectButton : MonoBehaviour
{
	private enum ButtonStates
	{
		Buy = 0,
		Select = 1,
		Trial = 2,
		BuyWithInapp = 3,
		Unselect = 4,
		LockedTheme = 5,
		WatchVideo = 6,
		GetNow = 7,
		NoAvailableVideo = 8,
	}

	private enum StickerType
	{
		None = 0,
		Event = 1,
		Limited = 2,
		Gift = 3,
	}

	private enum VideoState
	{
		Ready = 0,
		Failed = 1,
		Loading = 2,
	}

	private GameObject _buy; //Field offset: 0xC
	private UILabel _priceLabel; //Field offset: 0x10
	private UISprite _keySprite; //Field offset: 0x14
	private UISprite _coinSprite; //Field offset: 0x18
	private HorizontalLayout _buyLayout; //Field offset: 0x1C
	private GameObject _select; //Field offset: 0x20
	private UILabel _labelSelected; //Field offset: 0x24
	private GameObject _watchVideo; //Field offset: 0x28
	private UISprite _videoSprite; //Field offset: 0x2C
	private UISprite _loadingSprite; //Field offset: 0x30
	private UISprite _spacingSprite; //Field offset: 0x34
	private UILabel _watchVideoLabel; //Field offset: 0x38
	private UILabel _watchVideoSubLabel; //Field offset: 0x3C
	private HorizontalLayout _watchVideoLayout; //Field offset: 0x40
	private VerticalLayout _watchVideoLabelLayout; //Field offset: 0x44
	private GameObject _lockedBoardContent; //Field offset: 0x48
	private UILabel _progressLabel; //Field offset: 0x4C
	private UISprite _tokenSprite; //Field offset: 0x50
	private HorizontalLayout _lockedBoardLayout; //Field offset: 0x54
	private GameObject _trial; //Field offset: 0x58
	private UILabel _labelTry; //Field offset: 0x5C
	private GameObject _buyWithInapp; //Field offset: 0x60
	private UILabel _labelBuyWithInapp; //Field offset: 0x64
	private GameObject _unselect; //Field offset: 0x68
	private UILabel _labelUnselect; //Field offset: 0x6C
	private GameObject _lockedThemeContent; //Field offset: 0x70
	private UISprite _lockedKeySprite; //Field offset: 0x74
	private UISprite _lockedCoinSprite; //Field offset: 0x78
	private UILabel _notAvailableThemeAmount; //Field offset: 0x7C
	private UILabel _notAvailableThemeFeedback; //Field offset: 0x80
	private HorizontalLayout _themeToplayout; //Field offset: 0x84
	private HorizontalLayout _themeBottomLayout; //Field offset: 0x88
	private GameObject _getNowContent; //Field offset: 0x8C
	private UISprite _backgroundSticker; //Field offset: 0x90
	private UISprite _eventIcon; //Field offset: 0x94
	private UISprite _giftIcon; //Field offset: 0x98
	private UISprite _limitedIcon; //Field offset: 0x9C
	public Action onPurchaseSuccessful; //Field offset: 0xA0
	public Action onPurchaseFailed; //Field offset: 0xA4
	private BoardId _boardId; //Field offset: 0xA8
	private int _currentThemeIndex; //Field offset: 0xAC
	private UIButtonOverlayOff _uiButtonOverlayOff; //Field offset: 0xB0
	private bool _purchaseInProgress; //Field offset: 0xB4
	private bool _hasInited; //Field offset: 0xB5
	private bool _shouldShowEventIndicatorsForTryBoardsEvent; //Field offset: 0xB6
	private bool _shouldShowEventIndicatorsForBuyLimitedBoardsEvent; //Field offset: 0xB7
	private bool _shouldShowExpirationTimeForBoardBundleSale; //Field offset: 0xB8
	private int _videoCacheRetry; //Field offset: 0xBC
	private bool _didWatchVideo; //Field offset: 0xC0
	private bool _shouldLogWatchVideoData; //Field offset: 0xC1
	private VideoState _currentVideoState; //Field offset: 0xC4
	private ScreenContext _screenContext; //Field offset: 0xC8
	private ButtonStates _activeState; //Field offset: 0xCC

	public BoardSelectButton() { }

	private void <OnFinishedWatchingVideo>b__88_0() { }

	private void ActivateTheme(BoardId boardId, int themeIndex, bool allowSignatureAnimation) { }

	private void BoardPurchaseSuccessful() { }

	private void BoardThemePurchaseSuccessful(int themeIndex) { }

	private void BuyHoverboardWithInapp() { }

	private bool CurrentlyShownBoardMatchesBoardBundleEvent() { }

	private bool CurrentlyShownBoardMatchesLimitedExpiredBoardEvent() { }

	private bool CurrentlyShownBoardMatchesTrySpecialPowerBoard() { }

	private void DeactivateTheme(BoardId boardId, int themeIndex) { }

	public void InitButton(ScreenContext newContext) { }

	private bool IsBoardOrThemeFree(BoardId boardId, int themeIndex = -1) { }

	private void OnCachedVideo(string adLocationId, bool wasAlreadyCached) { }

	public void OnChangedCurrentlyShownBoardModel() { }

	public void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnFailedToCacheVideo(string adLocationId) { }

	private void OnFinishedWatchingVideo() { }

	public void PurchaseFailure() { }

	public void PurchaseSuccessful(bool isBoardTheme = false, int themeIndex = 0) { }

	public void rewardedBreakComplete(bool withReward) { }

	public void SendFlurryLogForBirthdayBoard() { }

	private void SetButtonState(ButtonStates state) { }

	public void SetBuyBoardThemeUI() { }

	private void SetBuyHoverboardUI() { }

	private void SetSelectBoardThemeUI() { }

	public void SetSelectHoverboardUI() { }

	private void SetSelectLockedTheme() { }

	private void SetSticker(StickerType type) { }

	private void SetToLockedBoard() { }

	private void SetToSelectedBlueState() { }

	private void SetToSelectGreenState() { }

	private void SetToUnselectBlueState() { }

	private void SetTryHoverboardUI() { }

	private void SetUnselectBoardThemeUI() { }

	private void SetWatchVideo() { }

	public void UpdateCurrentThemeIndex() { }

	public void UpdateSticker(BoardId boardId, int themeIndex) { }

}

