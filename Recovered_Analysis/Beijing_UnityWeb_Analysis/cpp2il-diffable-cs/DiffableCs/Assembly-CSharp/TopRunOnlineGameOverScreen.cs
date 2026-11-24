//Type is in global namespace

public class TopRunOnlineGameOverScreen : MonoBehaviour
{
	private sealed class <AnimateMedalAfterSeconds>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float seconds; //Field offset: 0x10
		public TopRunOnlineGameOverScreen <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 259
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateMedalAfterSeconds>d__36(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class TopRunListAdapter
	{
		private const int FACEBOOK_BUTTON = 7; //Field offset: 0x0
		private const int RESULT_STATE_ID = 5; //Field offset: 0x0
		private const int NORMAL_STATE_ID = 4; //Field offset: 0x0
		private const int EMPTY_CELL_ID = 3; //Field offset: 0x0
		private const int SPACE_CELL = 2; //Field offset: 0x0
		private const int RANK_PREFAB_ID = 1; //Field offset: 0x0
		private const int PLAYER_PREFAB_ID = 0; //Field offset: 0x0
		private const int OFFLINE_STATE_ID = 6; //Field offset: 0x0
		private TopRunOnlineGameOverScreen _topRunScreen; //Field offset: 0x10
		public GameObject playerPrefab; //Field offset: 0x14
		public GameObject rankHeaderPrefab; //Field offset: 0x18
		public GameObject spacePrefab; //Field offset: 0x1C
		public GameObject emptyCellPrefab; //Field offset: 0x20
		public GameObject facebookButton; //Field offset: 0x24
		public GameObject normalStatePrefab; //Field offset: 0x28
		public GameObject resultStatePrefab; //Field offset: 0x2C
		public GameObject offlineStatePrefab; //Field offset: 0x30

		public TopRunListAdapter(List<TopRunCell> topRunListT, TopRunOnlineGameOverScreen topRunScreen, GameObject playerCell, GameObject headerCell, GameObject spaceCell, GameObject emptyCell, GameObject normalState, GameObject resultState, GameObject offlineState, GameObject _facebookButton) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass) { }

		public override int GetModelType(int index) { }

		public void SetNewDataList(List<TopRunCell> topRunListT) { }

	}

	private const int POSITION_OFFSET_IN_LIST_NOFACEBOOK = 1; //Field offset: 0x0
	private const int OFFSET_FROM_TOP = -39; //Field offset: 0x0
	private const int POSITION_OFFSET_IN_LIST = 2; //Field offset: 0x0
	private ScrollView _topRunListView; //Field offset: 0xC
	private GameObject _playerPrefab; //Field offset: 0x10
	private GameObject _rankHeaderPrefab; //Field offset: 0x14
	private GameObject _spaceCell; //Field offset: 0x18
	private GameObject _emptyCell; //Field offset: 0x1C
	private GameObject _facebookLogInButton; //Field offset: 0x20
	private UISprite _loadingOverlayBackground; //Field offset: 0x24
	private GameObject _normalState; //Field offset: 0x28
	private GameObject _resultState; //Field offset: 0x2C
	private GameObject _offlineState; //Field offset: 0x30
	public GameObject loadingOverlay; //Field offset: 0x34
	private UIPanel _scrollPanel; //Field offset: 0x38
	private GameObject _maintenanceState; //Field offset: 0x3C
	private UILabel _maintenanceLabel1; //Field offset: 0x40
	private UILabel _maintenanceLabel2; //Field offset: 0x44
	private UILabel _maintenanceLabel3; //Field offset: 0x48
	private Layout _maintenanceLabelLayout; //Field offset: 0x4C
	private UISprite _maintenanceStateBackground; //Field offset: 0x50
	private TopRunListAdapter _adapter; //Field offset: 0x54
	private TopRunStates _currentState; //Field offset: 0x58
	private bool _hasBeenInitialized; //Field offset: 0x5C
	private bool _isLoading; //Field offset: 0x5D
	private List<TopRunCell> _contentList; //Field offset: 0x60

	public TopRunOnlineGameOverScreen() { }

	private void AddFBButtonAfterMe(List<TopRunCell> topRunContentList, ref bool isFacebookButtonAdded) { }

	private IEnumerator AnimateMedalAfterSeconds(float seconds) { }

	public void AnimateMedalIfNeeded() { }

	private int GetMyIndexInTheList() { }

	private Player GetMyPlayerProfile(bool hasScore = true) { }

	private TopRunPlayerCell GetPlayerScriptFromList() { }

	private void Init() { }

	private void OnApplicationResumed() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void OnPlayerChanged(object o, PlayerInfoChangedEventArgs eventArg = null) { }

	public void RefreshAdapterIfDataChanged() { }

	private void RefreshOrFetchNewTournament() { }

	private void ScrollToRightPosition() { }

	private void SetAdapter() { }

	private void SetCurrentState() { }

	private void SetListContent() { }

	private void SetMaintenanceLabels() { }

	private void SetScrollPanelTopAnchor() { }

	private void TournamentChanged(object sender, EventArgs eventArg) { }

}

