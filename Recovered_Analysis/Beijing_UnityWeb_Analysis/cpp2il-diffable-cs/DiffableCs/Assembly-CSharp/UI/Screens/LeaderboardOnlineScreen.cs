namespace UI.Screens;

public class LeaderboardOnlineScreen : UIScreen
{
	private class LeaderboardListAdapter
	{
		private const int FRIEND_PREFAB = 0; //Field offset: 0x0
		private const int PLAYER_PREFAB = 1; //Field offset: 0x0
		private const int SPACE_PREFAB = 2; //Field offset: 0x0
		private const int HEADER_PREFAB = 3; //Field offset: 0x0
		private GameObject _friendPrefab; //Field offset: 0x10
		private GameObject _playerPrefab; //Field offset: 0x14
		private GameObject _spacePrefab; //Field offset: 0x18
		private GameObject _headerPrefab; //Field offset: 0x1C
		private Action<Transform> _adjustOverlay; //Field offset: 0x20

		public LeaderboardListAdapter(List<LeaderboardCell> contentList, GameObject newFriendPrefab, GameObject newPlayerPrefab, GameObject newSpacePrefab, GameObject headerPrefab, Action<Transform> adjustOverlay) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass = false) { }

		public override int GetModelType(int index) { }

	}

	private const int POSITION_OFFSET_IN_LIST = 2; //Field offset: 0x0
	private const int GC_FRIENDS_THRESHOLD = 4; //Field offset: 0x0
	private GameObject _friendPrefab; //Field offset: 0x28
	private FacebookLoginPromotion _facebookContent; //Field offset: 0x2C
	private GameObject _spacePrefab; //Field offset: 0x30
	private GameObject _headerPrefab; //Field offset: 0x34
	private UIWidget _titleAnchor; //Field offset: 0x38
	private UILabel _titleLabel; //Field offset: 0x3C
	private ScrollView _scrollView; //Field offset: 0x40
	private UIPanel _scrollPanel; //Field offset: 0x44
	private UIWidget _overlaySizer; //Field offset: 0x48
	private GameObject _lockContent; //Field offset: 0x4C
	private UILabel _noFriendsLabel; //Field offset: 0x50
	private UIWidget _topAnchor; //Field offset: 0x54
	private UISprite _scrollBarBackground; //Field offset: 0x58
	private List<LeaderboardCell> _contentList; //Field offset: 0x5C
	private LeaderboardListAdapter _adapter; //Field offset: 0x60
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0x64
	private bool _facebookLoginRunning; //Field offset: 0x65
	private readonly Color32 _facebookHeaderColor; //Field offset: 0x68
	private readonly Color32 _gamecenterHeaderColor; //Field offset: 0x6C

	public LeaderboardOnlineScreen() { }

	private void <Show>b__22_0(bool didLoadFriends) { }

	private void AddDummiesToList(ref int rankCount, ref int nElements) { }

	private void AddDummy(int rank, bool below = false) { }

	private void AddFacebookHeaderToList(bool lockList) { }

	private void AddGameCenterHeaderToList(bool lockList) { }

	private void AddOverlayAndLockList(bool enable) { }

	private void AddSpaceToList(bool listLocked) { }

	private void AdjustLockOverlay(Transform obj) { }

	private void FacebookClicked() { }

	private void FacebookStatusChanged(bool success) { }

	private void ForceUpdateAnchors() { }

	private int GetDummyPlayerScore() { }

	private int GetMyIndexInTheList() { }

	public override void Hide() { }

	public override void Init() { }

	private void InsertFriendScoreToLeaderboard(Friend newFriend, ref int rankCount, ref int nElements, bool listLocked) { }

	private void InsertPlayerScoreToLeaderboard(ref int rankCount, ref int nElements, bool isRanked, bool listLocked, bool adjustOverlay) { }

	private void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFailSlideInFinish() { }

	private void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	private void ReloadFriends() { }

	private void ResetFriendList() { }

	private void ScrollToMyPosition() { }

	private void SetActiveFacebookLoginButton(bool active) { }

	private void SetAgeRestrictedContent() { }

	private void SetListContent() { }

	private void SetOfflineContent() { }

	private void SetOnlineContent(LeaderboardScreenState screenState) { }

	private void SetOnlineContentListForLeaderboard(bool fbConnected, Friend[] friends, bool lockList, ref bool facebookButtonActive) { }

	private void SetupNoFriends(bool enable) { }

	public override void Show() { }

}

