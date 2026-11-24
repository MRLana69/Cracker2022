namespace UI;

public class CharacterSelectButton : MonoBehaviour
{
	public enum ButtonContext
	{
		CharacterScreen = 0,
		CharacterNameEventPopup = 1,
		LimitedCharacterPopup = 2,
		CharacterPromotion = 3,
	}

	public enum ButtonStates
	{
		Buy = 0,
		Select = 1,
		BuyWithInapp = 2,
		Facebook = 3,
		Collect = 4,
	}

	public enum StickerType
	{
		None = 0,
		Event = 1,
		Limited = 2,
		Gift = 3,
	}

	private const string TEXT_PROGRESS = "{0} / {1}"; //Field offset: 0x0
	private UIButtonOverlayOff _uiButtonOverlayOff; //Field offset: 0xC
	private GameObject _buyContent; //Field offset: 0x10
	private UILabel _priceLabel; //Field offset: 0x14
	private UISprite _keySprite; //Field offset: 0x18
	private UISprite _coinSprite; //Field offset: 0x1C
	private Layout _buyLayout; //Field offset: 0x20
	private GameObject _selectContent; //Field offset: 0x24
	private UILabel _labelSelected; //Field offset: 0x28
	private GameObject _lockedThemeContent; //Field offset: 0x2C
	private Layout _themeTopLayout; //Field offset: 0x30
	private Layout _themeBottomLayout; //Field offset: 0x34
	private UISprite _notAvailableThemeCoin; //Field offset: 0x38
	private UISprite _notAvailableThemeKey; //Field offset: 0x3C
	private UILabel _notAvailableThemeAmount; //Field offset: 0x40
	private UILabel _notAvailableThemeFeedback; //Field offset: 0x44
	private GameObject _lockedTokenContent; //Field offset: 0x48
	private UILabel _progressLabel; //Field offset: 0x4C
	private UISprite _tokenSprite; //Field offset: 0x50
	private GameObject _buyWithInappContent; //Field offset: 0x54
	private UILabel _labelBuyWithInapp; //Field offset: 0x58
	private GameObject _facebookContent; //Field offset: 0x5C
	private GameObject _facebookOfflineContent; //Field offset: 0x60
	private UILabel _facebookOfflineLabel; //Field offset: 0x64
	private Layout _facebookOfflineLayout; //Field offset: 0x68
	private GameObject _facebookLoadingContent; //Field offset: 0x6C
	private UILabel _facebookLoadingLabel; //Field offset: 0x70
	private Layout _facebookLoadingLayout; //Field offset: 0x74
	private GameObject _stickerContent; //Field offset: 0x78
	private UISprite _backgroundSticker; //Field offset: 0x7C
	private UISprite _eventIcon; //Field offset: 0x80
	private UISprite _giftIcon; //Field offset: 0x84
	private UISprite _clockIcon; //Field offset: 0x88
	private GameObject _collectContent; //Field offset: 0x8C
	private UILabel _labelCollect; //Field offset: 0x90
	private GameObject _smallFirstPurchaseBonusBannerGo; //Field offset: 0x94
	private CharacterId _currentlyShownModelId; //Field offset: 0x98
	private Model _modelData; //Field offset: 0x9C
	private int _currentlyShownThemeIndex; //Field offset: 0xA0
	private Outfit _modelOutfit; //Field offset: 0xA4
	private UnlockType _unlockType; //Field offset: 0xA8
	private bool _isCharacterOwned; //Field offset: 0xAC
	private bool _isThemeOwned; //Field offset: 0xAD
	private int _unlockPrice; //Field offset: 0xB0
	private bool _hasInited; //Field offset: 0xB4
	private bool _buyCharacterWithIapEventIsRunning; //Field offset: 0xB5
	private ButtonStates _activeState; //Field offset: 0xB8
	private ButtonContext _buttonContext; //Field offset: 0xBC
	private CharacterScreenManager _managerInstance; //Field offset: 0xC0

	public CharacterSelectButton() { }

	public bool CurrentlyShownCharacterMatchesEventItem() { }

	public void InitButton(ButtonContext newContext) { }

	public void OnClick() { }

	private void PurchaseCharacter(bool withInAppPurchase) { }

	public void ReloadButton(bool overrideCharacter = false, CharacterId newCharacter = 0) { }

	public void SetButtonState(ButtonStates state) { }

	public void SetSticker(StickerType type) { }

	private void SetToFacebookLoadingState() { }

	private void SetToFacebookOfflineState() { }

	private void SetUIToNotTappable() { }

	private void SetUIToSelectedBlueState() { }

	private void SetUIToSelectGreenState() { }

	private void ShowLockedTokenContent(bool show) { }

	private void UpdateUIForBuyState() { }

	private void UpdateUIForBuyWithInappState() { }

	private void UpdateUIForCollectState() { }

	private void UpdateUIForFacebookState() { }

	private void UpdateUIForSelectState() { }

}

