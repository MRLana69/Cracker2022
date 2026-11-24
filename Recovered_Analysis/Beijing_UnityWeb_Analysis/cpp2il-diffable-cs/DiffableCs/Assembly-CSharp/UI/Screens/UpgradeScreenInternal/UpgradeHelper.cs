namespace UI.Screens.UpgradeScreenInternal;

public class UpgradeHelper : MonoBehaviour
{
	private enum AnimState
	{
		Closed = 0,
		Opening = 1,
		Open = 2,
		Closing = 3,
	}

	private UISprite _powerupIcon; //Field offset: 0xC
	private UILabel _titleLabel; //Field offset: 0x10
	private UILabel _descriptionLabel; //Field offset: 0x14
	private UILabel _amountLabel; //Field offset: 0x18
	private UILabel _priceLabel; //Field offset: 0x1C
	private Layout _priceLayout; //Field offset: 0x20
	private BuyButtonIngame _buyButton; //Field offset: 0x24
	private UILabel _buttonPriceLabel; //Field offset: 0x28
	private Layout _buttonPriceLayout; //Field offset: 0x2C
	private GameObject _expandedContent; //Field offset: 0x30
	private UISprite _openButtonSprite; //Field offset: 0x34
	private UISprite _fullBgCollapsed; //Field offset: 0x38
	private UISprite _fullBgExpanded; //Field offset: 0x3C
	private UITierHelper _tierHelper; //Field offset: 0x40
	private GameObject _descriptionButton; //Field offset: 0x44
	private UILabel _descButtonLabel; //Field offset: 0x48
	private TableElementAlwaysVisible _tableElement; //Field offset: 0x4C
	private UpgradeType _type; //Field offset: 0x50
	private UpgradeScreen _upgradeScreen; //Field offset: 0x54
	private bool _hasInited; //Field offset: 0x58
	private UIPanel _parentPanel; //Field offset: 0x5C
	private bool _foldedOut; //Field offset: 0x60
	private UIPlayTween[] _tweens; //Field offset: 0x64
	private bool _wasForceOpened; //Field offset: 0x68
	private AnimState _animState; //Field offset: 0x6C

	private AnimState animState
	{
		 get { } //Length: 137
		 set { } //Length: 674
	}

	public UpgradeHelper() { }

	public void AnimationEnded() { }

	private void AnimationStarted() { }

	private void ContentActivation(bool foldedOut) { }

	private void FoldClicked() { }

	private void ForceExpandContent(bool expand) { }

	private AnimState get_animState() { }

	public void InitPermanent(UpgradeType type, UIPanel panel) { }

	public void InitSingle(UpgradeType type, UIPanel panel) { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RefreshEvent(UpgradeType type, int amount) { }

	private void RefreshUpgrade() { }

	private void set_animState(AnimState value) { }

	private void SetFoldout() { }

	private void TriggerContent() { }

	public void UpgradePurchased(UpgradeType type) { }

}

