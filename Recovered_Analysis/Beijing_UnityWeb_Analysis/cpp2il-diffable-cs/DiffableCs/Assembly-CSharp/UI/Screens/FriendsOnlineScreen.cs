namespace UI.Screens;

public class FriendsOnlineScreen : UIScreen
{
	public class CollectCoinsListAdapter
	{
		private const int FRIEND_PREFAB = 0; //Field offset: 0x0
		private const int FACEBOOK_PREFAB = 1; //Field offset: 0x0
		private const int RECOMMEND_PREFAB = 2; //Field offset: 0x0
		private const int SPACE_PREFAB = 3; //Field offset: 0x0
		public FriendsOnlineScreen friendsScreen; //Field offset: 0x10
		public GameObject friendPrefab; //Field offset: 0x14
		public GameObject recommendPrefab; //Field offset: 0x18
		public GameObject spacePrefab; //Field offset: 0x1C

		public CollectCoinsListAdapter(List<CollectCoinsCell> contentList, GameObject newFriendPrefab, GameObject newRecommendPrefab, GameObject newSpacePrefab, FriendsOnlineScreen screenRef) { }

		public override Container GetContainer(Container container, int dataIndex, bool isMeasurePass) { }

		public override int GetModelType(int index) { }

		public void SetNewDataList(List<CollectCoinsCell> collectCoinsListT) { }

	}

	public static GameObject fbButtonReference; //Field offset: 0x0
	private GameObject friendPrefab; //Field offset: 0x28
	private FacebookLoginPromotion facebookContentObject; //Field offset: 0x2C
	private GameObject recommendPrefab; //Field offset: 0x30
	private GameObject spacePrefab; //Field offset: 0x34
	private UILabel CrewHeader; //Field offset: 0x38
	private UIWidget titleAnchor; //Field offset: 0x3C
	private UILabel NoFriends; //Field offset: 0x40
	private List<CollectCoinsCell> _contentList; //Field offset: 0x44
	private CollectCoinsListAdapter _adapter; //Field offset: 0x48
	private ScrollView _collectCoinsListView; //Field offset: 0x4C
	private UIPanel _scrollPanel; //Field offset: 0x50
	private UIWidget _overlaySizer; //Field offset: 0x54
	private GameObject _lockContent; //Field offset: 0x58
	private UISprite _scrollBarBackground; //Field offset: 0x5C
	private bool _hasSetiPhoneXOffsetsIfNecessary; //Field offset: 0x60
	private bool _facebookLoginRunning; //Field offset: 0x61

	private static FriendsOnlineScreen() { }

	public FriendsOnlineScreen() { }

	private void <Show>b__18_0(bool didLoadFriends) { }

	private void AddDummiesToList(ref int nElements, bool onlyCollectible) { }

	private void AddFriendsToList(Friend[] friends, ref int nElement, bool lockList) { }

	private void AddOverlayAndLockList(bool enable) { }

	private void AddRecommendButtonToList(ref int nElements) { }

	private void AddSpaceToList() { }

	public void FacebookClicked() { }

	private void FacebookStatusChanged(bool success) { }

	private void ForceUpdateAnchors() { }

	public override void Hide() { }

	public override void Init() { }

	public void OnFacebookLoginResult(bool loggedIn) { }

	private void OnFailSlideInFinish() { }

	private void QueueFacebookFailSlideIn(Action onFinishCallback) { }

	private void ReloadFriends() { }

	private void ResetFriendList() { }

	private void SetActiveFacebookLoginButton(bool active) { }

	public void SetFBReference(Object fbRef) { }

	private void SetListContent() { }

	private void SetOfflineContent() { }

	private void SetOnlineContent(CollectCoinsScreenState screenState) { }

	private void SetupNoFriends(bool enable) { }

	public override void Show() { }

}

