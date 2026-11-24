namespace UI.Popups;

public class BoardBundlePopup : UIScreen
{
	private GameObject _topAnchor; //Field offset: 0x28
	private UILabel _popupBoardTitle; //Field offset: 0x2C
	private UILabel _popupBoardName; //Field offset: 0x30
	private TimerHelper _timerPrefab; //Field offset: 0x34
	private UIWidget _timerContainer; //Field offset: 0x38
	private Layout _timerLayout; //Field offset: 0x3C
	private BoardBundleItem _board; //Field offset: 0x40
	private BoardBundleItem _bundle1; //Field offset: 0x44
	private BoardBundleItem _bundle2; //Field offset: 0x48
	private UILabel _bestStickerLabel; //Field offset: 0x4C
	private TimerHelper _timer; //Field offset: 0x50

	public BoardBundlePopup() { }

	public override void GainFocus() { }

	public override void Init() { }

	private void InitializeTimer() { }

	public override void LoseFocus() { }

	public void OnBoardPurchaseClicked() { }

	public void OnBundle1PurchaseClicked() { }

	public void OnBundle2PurchaseClicked() { }

	public void OnCloseClicked() { }

	private void SetupBundle(BoardBundleItem boardBundleItem, BoardId boardId, InAppItemModel inAppItemModel) { }

	private void SetupTop(BoardId boardId) { }

	public override void Show() { }

}

