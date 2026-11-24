namespace UI.Popups;

public class CharacterPromotionPopup : UIScreen
{
	private const int CharacterSelectButtonWidth = 135; //Field offset: 0x0
	private const int CharacterSelectButtonHeight = 50; //Field offset: 0x0
	private GameObject _topAnchor; //Field offset: 0x28
	private UILabel _popupCharacterTitle; //Field offset: 0x2C
	private UILabel _popupCharacterSubTitle; //Field offset: 0x30
	private UITexture _popupStickerTexture; //Field offset: 0x34
	private TimerHelper _timerPrefab; //Field offset: 0x38
	private Transform _timerContainer; //Field offset: 0x3C
	private Layout _timerLayout; //Field offset: 0x40
	private TimerHelper _timer; //Field offset: 0x44
	private CharacterSelectButton _characterSelectButtonPrefab; //Field offset: 0x48
	private Transform _characterSelectButtonParent; //Field offset: 0x4C
	private CharacterSelectButton _characterSelectButton; //Field offset: 0x50
	private UISprite backgroundSprite; //Field offset: 0x54
	private UISprite flashSprite; //Field offset: 0x58
	private CharacterPromotion characterPromotion; //Field offset: 0x5C

	public CharacterPromotionPopup() { }

	public override void GainFocus() { }

	public override void Hide() { }

	public override void Init() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	public override void LoseFocus() { }

	private void OnCharacterPurchaseSuccess(CharacterId characterId, int themeId) { }

	public void OnCloseClicked() { }

	private void SetupTop() { }

	public override void Show() { }

}

