namespace UI.Popups;

public class BoardPromotionPopup : UIScreen
{
	private const int SCREEN_REFERENCE_HEIGHT = 480; //Field offset: 0x0
	private const int BoardSelectButtonHeight = 50; //Field offset: 0x0
	private const int BoardSelectButtonWidth = 135; //Field offset: 0x0
	private readonly Vector3 MODEL_POSITION; //Field offset: 0x28
	private GameObject _topAnchor; //Field offset: 0x34
	private UILabel _popupBoardTitle; //Field offset: 0x38
	private UILabel _popupBoardSubTitle; //Field offset: 0x3C
	private UITexture _popupStickerTexture; //Field offset: 0x40
	private TimerHelper _timerPrefab; //Field offset: 0x44
	private Transform _timerContainer; //Field offset: 0x48
	private Layout _timerLayout; //Field offset: 0x4C
	private TimerHelper _timer; //Field offset: 0x50
	private Transform _boardAnchor; //Field offset: 0x54
	private BoardSelectButton _boardSelectButtonPrefab; //Field offset: 0x58
	private Transform _boardSelectButtonParent; //Field offset: 0x5C
	private BoardSelectButton _boardSelectButton; //Field offset: 0x60
	private BoardPromotion boardPromotion; //Field offset: 0x64
	private UISprite backgroundSprite; //Field offset: 0x68
	private UISprite flashSprite; //Field offset: 0x6C

	public BoardPromotionPopup() { }

	public override void GainFocus() { }

	public override void Hide() { }

	public override void Init() { }

	private void InitBoardAnchor() { }

	private void InitializeSelectButton() { }

	private void InitializeTimer() { }

	public override void LoseFocus() { }

	public void OnCloseClicked() { }

	private void OnDestroy() { }

	private void SetupTop(BoardId boardId) { }

	public override void Show() { }

}

