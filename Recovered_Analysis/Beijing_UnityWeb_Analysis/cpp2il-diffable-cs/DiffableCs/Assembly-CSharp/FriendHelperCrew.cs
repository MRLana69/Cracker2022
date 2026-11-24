//Type is in global namespace

public class FriendHelperCrew : MonoBehaviour
{
	private static Action<int> OnFriendCoinsReceived; //Field offset: 0x0
	private const int REWARD_MAX = 350; //Field offset: 0x0
	private const int REWARD_MIN = 250; //Field offset: 0x0
	private const int RUNS_TO_COLLECT = 25; //Field offset: 0x0
	private GameObject _collectButton; //Field offset: 0xC
	private UILabel _collectButtonLabel; //Field offset: 0x10
	private GameObject _progress; //Field offset: 0x14
	private UILabel _friendName; //Field offset: 0x18
	private UITexture _friendPicture; //Field offset: 0x1C
	private UISprite _friendBackground; //Field offset: 0x20
	private FriendCrewPokeHelper _pokeHelper; //Field offset: 0x24
	private Texture2D _dummyImage; //Field offset: 0x28
	private Texture2D _dummyFriendImage; //Field offset: 0x2C
	private UISprite _coinpouchSprite; //Field offset: 0x30
	private Friend _friend; //Field offset: 0x34
	private CollectCoinsDummy _dummyFriend; //Field offset: 0x38
	private readonly Color32 CELL_BACKGROUND_COLOR_CLEAR; //Field offset: 0x3C
	private readonly Color32 CELL_BACKGROUND_COLOR_DARK; //Field offset: 0x40
	private readonly Vector3 COLLECT_POSITION; //Field offset: 0x44
	private bool _isDummyFriend; //Field offset: 0x50
	private bool _hasAddedFriendUpdateHandler; //Field offset: 0x51

	public static event Action<int> OnFriendCoinsReceived
	{
		 add { } //Length: 316
		 remove { } //Length: 126
	}

	public FriendHelperCrew() { }

	public static void add_OnFriendCoinsReceived(Action<int> value) { }

	public void CollectReward() { }

	public void InitDummyFriend(CollectCoinsDummy dummyFriend, bool backgroundActive = false) { }

	public void InitFriend(Friend friend, bool backgroundActive = false) { }

	private void OnDestroy() { }

	private void OnFriendUpdatedHandler() { }

	private int PayoutAndReturnReward() { }

	public void Refresh() { }

	public static void remove_OnFriendCoinsReceived(Action<int> value) { }

}

