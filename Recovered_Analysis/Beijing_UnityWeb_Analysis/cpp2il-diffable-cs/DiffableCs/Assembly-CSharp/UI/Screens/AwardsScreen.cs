namespace UI.Screens;

public class AwardsScreen : UIScreen
{
	public class AwardListAdapter
	{
		private const int AWARD_TITLE_PREFAB = 0; //Field offset: 0x0
		private const int AWARD_CELL_PREFAB = 1; //Field offset: 0x0
		private const int AWARD_FINISHED_CELL_PREFAB = 2; //Field offset: 0x0
		public GameObject finishedAwardPrefab; //Field offset: 0x10
		public GameObject awardPrefab; //Field offset: 0x14
		public GameObject titlePrefab; //Field offset: 0x18
		public AwardsScreen screenReference; //Field offset: 0x1C

		public AwardListAdapter(List<AwardCell> awardList, GameObject awardCell, GameObject finishedAwardCell, GameObject titleCell, AwardsScreen screenReference) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass) { }

		public override int GetModelType(int index) { }

	}

	private GameObject _awardPrefab; //Field offset: 0x28
	private GameObject _finishedAwardPrefab; //Field offset: 0x2C
	private GameObject _titlePrefab; //Field offset: 0x30
	private ScrollView _awardListView; //Field offset: 0x34
	private UIPanel _scrollPanel; //Field offset: 0x38
	public UIPanel _scrollBarPanel; //Field offset: 0x3C
	private int _indexOnHide; //Field offset: 0x40
	private AwardListAdapter _adapter; //Field offset: 0x44
	private List<AwardCell> _contentList; //Field offset: 0x48
	private bool _isSubscribedToChangedScreen; //Field offset: 0x4C
	private bool _isReturningFromCelebration; //Field offset: 0x4D
	private bool _containsCollectableAward; //Field offset: 0x4E
	private bool _facebookLoginRunning; //Field offset: 0x4F
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0x50

	public AwardsScreen() { }

	public void FacebookLoginClicked() { }

	private void FacebookStatusChanged(bool success) { }

	private void ForceUpdateAnchors() { }

	public override void GainFocus() { }

	public override void Hide() { }

	public override void Init() { }

	public override void LoseFocus() { }

	public void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFailSlideInFinish() { }

	private void OnScreenChanged(string screen) { }

	private void PopupClosed(string popupName) { }

	private void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	private void RefreshAwards() { }

	private bool SetListContent() { }

	public override void Show() { }

}

