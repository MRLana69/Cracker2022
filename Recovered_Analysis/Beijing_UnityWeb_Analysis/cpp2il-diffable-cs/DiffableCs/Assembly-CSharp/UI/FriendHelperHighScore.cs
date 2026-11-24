namespace UI;

public class FriendHelperHighScore : MonoBehaviour
{
	private const int SCORE_SPACING = 10; //Field offset: 0x0
	private readonly Color _localPlayerColor; //Field offset: 0xC
	private readonly Color _friendColor; //Field offset: 0x1C
	private UILabel _friendRank; //Field offset: 0x2C
	private UISprite _unrankedBulletPoint; //Field offset: 0x30
	private UILabel _friendName; //Field offset: 0x34
	private UILabel _friendScore; //Field offset: 0x38
	private UITexture _friendPicture; //Field offset: 0x3C
	private UISprite _friendBackground; //Field offset: 0x40
	private UISprite _medal; //Field offset: 0x44
	private UISprite _shadow; //Field offset: 0x48
	private UISprite _flag; //Field offset: 0x4C
	private Color32 _cellBackgroundColorLocalUser; //Field offset: 0x50
	private Color32 _cellBackgroundColorClear; //Field offset: 0x54
	private Color32 _cellBackgroundColorDark; //Field offset: 0x58
	private Texture2D _dummyImage; //Field offset: 0x5C
	private bool _isLocalUser; //Field offset: 0x60
	private bool _isDummy; //Field offset: 0x61
	private Friend _friend; //Field offset: 0x64
	private bool _initialized; //Field offset: 0x68
	private CharacterAvatars _avatars; //Field offset: 0x6C

	public FriendHelperHighScore() { }

	private void HideMedal() { }

	public void InitDummy(LeaderboardDummy dummy, int ranking, bool backgroundActive) { }

	public void InitFriend(Friend friend, int ranking, bool backgroundActive = false) { }

	private void InitializeMedal() { }

	public void InitLocalUser(int ranking, bool backgroundActive = false, bool isPlayerRanked = true) { }

	private void OnDestroy() { }

	private void OnFriendUpdatedHandler() { }

	private void OnLocalUserUpdated() { }

	public void Refresh() { }

	private void ResizeNameIfNeeded() { }

	private void SetMedalForRank(IRank rankData, IManager manager) { }

	private void SetTemporaryMedal(int rank) { }

}

