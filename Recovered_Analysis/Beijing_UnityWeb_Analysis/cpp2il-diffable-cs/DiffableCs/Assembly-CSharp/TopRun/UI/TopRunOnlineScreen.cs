namespace TopRun.UI;

public class TopRunOnlineScreen : UIScreen
{
	private sealed class <>c__DisplayClass66_0
	{
		public UIWidget tracker; //Field offset: 0x8
		public GameObject objectToPosition; //Field offset: 0xC
		public Vector3 positionOffset; //Field offset: 0x10
		public Vector3 newRotation; //Field offset: 0x1C
		public Vector3 newScale; //Field offset: 0x28

		public <>c__DisplayClass66_0() { }

		internal void <PositionModelOnSprite>b__0() { }

	}

	private sealed class <AnimateMedalAfterSeconds>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float seconds; //Field offset: 0x10
		public TopRunOnlineScreen <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 259
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AnimateMedalAfterSeconds>d__49(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RefreshAdapterListDelayed>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int frames; //Field offset: 0x10
		public TopRunOnlineScreen <>4__this; //Field offset: 0x14
		private int <frame>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 213
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RefreshAdapterListDelayed>d__48(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class TopRunListAdapter
	{
		private sealed class <>c__DisplayClass12_0
		{
			public TopRunCell topRunCell; //Field offset: 0x8

			public <>c__DisplayClass12_0() { }

			internal void <GetContainer>b__0() { }

		}

		private const int PLAYER_PREFAB = 0; //Field offset: 0x0
		private const int RANK_PREFAB = 1; //Field offset: 0x0
		private const int SPACE_CELL = 2; //Field offset: 0x0
		private const int EMPTY_CELL = 3; //Field offset: 0x0
		private const int FACEBOOK_BUTTON = 4; //Field offset: 0x0
		private GameObject _playerPrefab; //Field offset: 0x10
		private GameObject _rankHeaderPrefab; //Field offset: 0x14
		private GameObject _spacePrefab; //Field offset: 0x18
		private GameObject _emptyCell; //Field offset: 0x1C

		public TopRunListAdapter(List<TopRunCell> topRunListT, GameObject playerCell, GameObject headerCell, GameObject spaceCell, GameObject emptyCellPrefab) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

		public override int GetModelType(int index) { }

		public void SetNewDataList(List<TopRunCell> topRunListT) { }

	}

	private const int NO_MEDAL_RANK_THRESHOLD = 4; //Field offset: 0x0
	private const int NORMAL_STATE_RESULTS_OFFSET = -110; //Field offset: 0x0
	private const int SCROLL_PANEL_NORMAL_OFFSET = -5; //Field offset: 0x0
	private const int SCROLL_PANEL_RESULTS_OFFSET = -15; //Field offset: 0x0
	private const int POSITION_OFFSET_IN_LIST = 2; //Field offset: 0x0
	private const int NORMAL_STATE_NORMAL_OFFSET = -9; //Field offset: 0x0
	private ScrollView _topRunListView; //Field offset: 0x28
	private UILabel _titleLabel; //Field offset: 0x2C
	private UISprite _flagSprite; //Field offset: 0x30
	private UILabel _countryLabel; //Field offset: 0x34
	private GameObject _playerPrefab; //Field offset: 0x38
	private GameObject _rankHeaderPrefab; //Field offset: 0x3C
	private GameObject _spaceCell; //Field offset: 0x40
	private GameObject _emptyCell; //Field offset: 0x44
	private FacebookLoginPromotion _facebookLoginContent; //Field offset: 0x48
	private GameObject _normalStateContainer; //Field offset: 0x4C
	private TopRunNormalStateHelper _normalStatePrefab; //Field offset: 0x50
	private TopRunNormalStateHelper _normalStateHelper; //Field offset: 0x54
	private GameObject _resultStateContainer; //Field offset: 0x58
	private GameObject _resultStatePrefab; //Field offset: 0x5C
	private GameObject _resultStateElement; //Field offset: 0x60
	private GameObject _offlineState; //Field offset: 0x64
	public GameObject loadingOverlay; //Field offset: 0x68
	private UISprite _loadingOverlayBackground; //Field offset: 0x6C
	private UIWidget _topAnchor; //Field offset: 0x70
	private UIPanel _scrollPanel; //Field offset: 0x74
	private UISprite _scrollBarBackground; //Field offset: 0x78
	private GameObject _globalStateNormal; //Field offset: 0x7C
	private GameObject _globalStateMaintenance; //Field offset: 0x80
	private UIRect _scrollbarRect; //Field offset: 0x84
	private UILabel _maintenanceLabel1; //Field offset: 0x88
	private UILabel _maintenanceLabel2; //Field offset: 0x8C
	private UILabel _maintenanceLabel3; //Field offset: 0x90
	private Layout _maintenanceLabelLayout; //Field offset: 0x94
	private UIWidget _maintenanceCharacterGuide; //Field offset: 0x98
	private CharacterScreenController _maintenanceCharacter; //Field offset: 0x9C
	private TopRunListAdapter _adapter; //Field offset: 0xA0
	private TopRunStates _currentState; //Field offset: 0xA4
	private bool _isLoading; //Field offset: 0xA8
	private List<TopRunCell> _contentList; //Field offset: 0xAC
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0xB0

	public TopRunOnlineScreen() { }

	private void <CreateMaintenanceCharacterModel>b__64_0(CharacterScreenController csc) { }

	private void AddFacebookButtonAfterMe(List<TopRunCell> contentList, ref bool isFacebookButtonAdded) { }

	private IEnumerator AnimateMedalAfterSeconds(float seconds) { }

	private void CreateMaintenanceCharacterModel() { }

	private void DestroyMaintenanceCharacterModel() { }

	private void ForceUpdateAnchors() { }

	public override void GainFocus() { }

	private int GetMyIndexInTheList() { }

	private Player GetMyPlayerProfile(bool hasScore = true) { }

	private TopRunPlayerCell GetPlayerScriptFromList() { }

	public override void Hide() { }

	public override void Init() { }

	private void OnApplicationResumed() { }

	private void OnPlayerChanged(object o, PlayerInfoChangedEventArgs eventArg = null) { }

	private static GameObject PlaceModelUnderAnchor(GameObject model, Transform anchor, int layer) { }

	private static void PositionModelOnSprite(UIWidget tracker, GameObject objectToPosition, Vector3 positionOffset, Vector3 newRotation, Vector3 newScale) { }

	private void RefreshAdapterIfDataChanged() { }

	private IEnumerator RefreshAdapterListDelayed(int frames) { }

	private void RefreshOrFetchNewTournament() { }

	private void ScrollToMyPosition() { }

	private void SetCurrentState() { }

	private void SetListContent() { }

	private void SetMaintenanceLabels() { }

	private void SetScreenTop_UI() { }

	public override void Show() { }

	private void TournamentChanged(object sender, EventArgs eventArg) { }

}

