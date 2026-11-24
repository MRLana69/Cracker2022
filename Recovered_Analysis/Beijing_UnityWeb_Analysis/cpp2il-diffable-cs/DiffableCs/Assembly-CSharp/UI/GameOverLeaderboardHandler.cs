namespace UI;

public class GameOverLeaderboardHandler : MonoBehaviour
{
	public class LeaderboardListAdapter
	{
		private const int FRIEND_PREFAB = 0; //Field offset: 0x0
		private const int FACEBOOK_PREFAB = 1; //Field offset: 0x0
		private const int PLAYER_PREFAB = 2; //Field offset: 0x0
		private const int SPACE_PREFAB = 3; //Field offset: 0x0
		public GameOverLeaderboardHandler leaderboardScreen; //Field offset: 0x10
		public GameObject friendPrefab; //Field offset: 0x14
		public GameObject facebookPrefab; //Field offset: 0x18
		public GameObject playerPrefab; //Field offset: 0x1C
		public GameObject spacePrefab; //Field offset: 0x20

		public LeaderboardListAdapter(List<LeaderboardGameoverCell> contentList, GameObject newFriendPrefab, GameObject newFacebookPrefab, GameObject newPlayerPrefab, GameObject newSpacePrefab, GameOverLeaderboardHandler screenReference) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass) { }

		public override int GetModelType(int index) { }

		public void SetNewDataList(List<LeaderboardGameoverCell> leaderboardListT) { }

	}

	private const int GC_FRIENDS_THRESHOLD = 4; //Field offset: 0x0
	private const int POSITION_OFFSET_IN_LIST = 1; //Field offset: 0x0
	public GameObject FriendPrefab; //Field offset: 0xC
	public GameObject FacebookLoginPrefab; //Field offset: 0x10
	public GameObject SpacePrefab; //Field offset: 0x14
	private ScrollView _scrollView; //Field offset: 0x18
	private UIPanel _scrollPanel; //Field offset: 0x1C
	private List<LeaderboardGameoverCell> _contentList; //Field offset: 0x20
	private LeaderboardListAdapter _adapter; //Field offset: 0x24
	private bool _facebookLoginRunning; //Field offset: 0x28

	public GameOverLeaderboardHandler() { }

	private void <Start>b__10_0(bool didLoadFriends) { }

	private void AddDummy(int rank, bool below = false) { }

	private void AddFacebookButtonToList(ref int nElements, bool noFriends = false, bool lockList = false) { }

	private void AddSpaceToList() { }

	public void FacebookClicked() { }

	private void FacebookStatusChanged(bool success) { }

	private int GetDummyPlayerScore() { }

	private int GetMyIndexInTheList() { }

	private void InsertFacebookLoginButton(ref int nElements) { }

	private void InsertFriendScoreToLeaderboard(Friend newFriend, ref int rankCount, ref int nElements, bool listLocked) { }

	private void InsertPlayerScoreToLeaderboard(ref int rankCount, ref int nElements, bool isRanked, bool listLocked) { }

	private void OnDisable() { }

	public void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFailSlideInFinish() { }

	private void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	public void ReloadFriends() { }

	private void ResetFriendList() { }

	private void ScrollToMyPosition() { }

	private void SetAgeRestrictedContent() { }

	private void SetListContent() { }

	private void SetOfflineContent() { }

	private void SetOnlineContent(LeaderboardScreenState screenState) { }

	private void SetOnlineContentListForLeaderboard(bool fbConnected, Friend[] friends, bool lockList) { }

	private void Start() { }

}

