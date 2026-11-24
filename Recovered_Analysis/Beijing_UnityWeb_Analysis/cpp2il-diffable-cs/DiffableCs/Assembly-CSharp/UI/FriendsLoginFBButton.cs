namespace UI;

public class FriendsLoginFBButton : MonoBehaviour
{
	private GameObject _connectingContent; //Field offset: 0xC
	private GameObject _normalContentLeaderboard; //Field offset: 0x10
	private GameObject _overlay; //Field offset: 0x14
	private UILabel _leaderboardLabel1; //Field offset: 0x18
	private Collider _leaderboardCollider; //Field offset: 0x1C
	private UISprite _connectingFill; //Field offset: 0x20
	private UILabel _connectingLabel; //Field offset: 0x24
	private Layout _connectingLayout; //Field offset: 0x28
	private Layout _loginLayout; //Field offset: 0x2C
	private Action _clickedAction; //Field offset: 0x30
	private Action _activateReconnect; //Field offset: 0x34
	private bool _leaderboardScreen; //Field offset: 0x38
	private bool _noFriends; //Field offset: 0x39
	private bool _isGameOverScreen; //Field offset: 0x3A

	public FriendsLoginFBButton() { }

	public void ConnectClicked() { }

	private void FBStateChangedHandler() { }

	public void Init(Action clickedAction, bool leaderboardScreen = false, bool noFriends = false, bool isGameOverScreen = false, Action activateReconnect = null) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void SetToConnectingState() { }

	private void SetToLogInState(bool isLeaderboardScreen, bool noFriends, bool isGameOverScreen) { }

}

