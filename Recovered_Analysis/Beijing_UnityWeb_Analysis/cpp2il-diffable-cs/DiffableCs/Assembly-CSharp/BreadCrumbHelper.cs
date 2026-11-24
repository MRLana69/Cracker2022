//Type is in global namespace

public class BreadCrumbHelper : MonoBehaviour
{
	private enum BreadCrumbLocations
	{
		meButton = 0,
		shopButton = 1,
		hoverboardsButton = 2,
		charactersButton = 3,
		upgradesFooter = 4,
		upgradesScroll = 5,
		earnCoinsFooterButton = 6,
		earnCoinsVideoButton = 7,
		mysteryBoxPrizeList = 8,
		awardsButton = 9,
		friendsButton = 10,
		topRunButton = 11,
		topRunTab = 12,
		facebookGiftButton = 13,
		characterCollectButton = 14,
	}

	private enum BreadCrumbStates
	{
		inactive = 0,
		giftCharacter = 1,
		giftBoard = 2,
		boardEventActive = 3,
		expiredLimitedCharacter = 4,
		biggerJackpot = 5,
		earnKeys = 6,
		collectAward = 7,
		expiredLimitedBoard = 8,
		topRun = 9,
		characterDay = 10,
		facebookGift = 11,
		sale = 12,
		specialSale = 13,
		collectableCharacter = 14,
	}

	private UISprite _sticker; //Field offset: 0xC
	private UISprite _stickerShadow; //Field offset: 0x10
	private UISprite _giftIcon; //Field offset: 0x14
	private UISprite _earnKeysIcon; //Field offset: 0x18
	private UISprite _eventIcon; //Field offset: 0x1C
	private UISprite _awardIcon; //Field offset: 0x20
	private UISprite _topRunIcon; //Field offset: 0x24
	private UISprite _collectableCharacterIcon; //Field offset: 0x28
	private GameObject _notification; //Field offset: 0x2C
	private GameObject _discount; //Field offset: 0x30
	private BreadCrumbStates _currentState; //Field offset: 0x34
	private BreadCrumbLocations _currentLocation; //Field offset: 0x38
	private bool _isApplicationResuming; //Field offset: 0x3C

	public bool IsAnyBreadCrumbActive
	{
		 get { } //Length: 9
	}

	private void _PauseApplication(bool paused) { }

	public BreadCrumbHelper() { }

	private void DisableBreadCrumbElements() { }

	private void DisableEventBreadcrumb() { }

	private void EnableBreadCrumbElements() { }

	public bool get_IsAnyBreadCrumbActive() { }

	private void LateUpdate() { }

	private void OnApplicationFocus(bool focus) { }

	private void OnApplicationPause(bool paused) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnVideoStateChanged(string adLocationId) { }

	private void OnVideoStateChanged(string adLocationId, bool wasAlreadyCached) { }

	private void SetAwardsBreadcrumbState() { }

	private void SetCharacterBreadcrumbState() { }

	private void SetCharacterCollectButtonState() { }

	private void SetEarnCoinsBreadcrumbState() { }

	private void SetEarnCoinsVideoBreadcrumbState() { }

	private void SetFacebookGiftBreadcrumbState() { }

	private void SetHoverboardBreadcrumbState() { }

	private void SetMeBreadcrumbState() { }

	private void SetShopBreadcrumbState() { }

	private void SetTopRunBreadcrumbState() { }

	private void SetupBreadCrumb() { }

	public void SetupBreadCrumbState() { }

	private void SetUpgradesBreadcrumbState(bool isPopup) { }

	private bool ShouldShowBoardsGiftSticker() { }

	private bool ShouldShowCharactersGiftSticker() { }

	private bool ShouldShowCollectableCharacterSticker() { }

	private bool TrySetActive(GameObject go, bool state) { }

	private bool TrySetActive(UIWidget widget, bool state) { }

	private void TrySetColor(UIWidget widget, Color color) { }

	private void Update() { }

}

