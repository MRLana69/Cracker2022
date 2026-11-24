//Type is in global namespace

public class FriendGhostHelper : MonoBehaviour
{
	public enum AnimatingState
	{
		_notset = 0,
		OnScreen = 1,
		OffScreen = 2,
		AnimatingIn = 3,
		AnimatingOut = 4,
	}

	public UISprite background; //Field offset: 0xC
	public UISprite frame; //Field offset: 0x10
	public UILabel points; //Field offset: 0x14
	public UILabel scoreType; //Field offset: 0x18
	public UITexture picture; //Field offset: 0x1C
	public UISprite competitorIcon; //Field offset: 0x20
	private Transform _cachedTransform; //Field offset: 0x24
	private Vector3 _resetPosition; //Field offset: 0x28
	private Vector3 _activePosition; //Field offset: 0x34
	private Vector3 _moveOutPosition; //Field offset: 0x40
	private float _backgroundAlphaDefault; //Field offset: 0x4C
	private float _frameAlphaDefault; //Field offset: 0x50
	private float _pointsAlphaDefault; //Field offset: 0x54
	private float _scoreTypeAlphaDefault; //Field offset: 0x58
	private float _pictureAlphaDefault; //Field offset: 0x5C
	public int defaultBackgroundWidth; //Field offset: 0x60
	private bool inited; //Field offset: 0x64
	private bool _gameRunning; //Field offset: 0x65
	public bool noFriendsLeftToGhost; //Field offset: 0x66
	private FriendGhostHandler handler; //Field offset: 0x68
	private float _animationDuration; //Field offset: 0x6C
	private float _currentAnimationDuration; //Field offset: 0x70
	public AnimatingState currentAnimationState; //Field offset: 0x74

	public FriendGhostHelper() { }

	public void AnimateIn() { }

	public void AnimateOut() { }

	public void GameOver() { }

	private void Init() { }

	public void NewGame() { }

	public void NoFriendsLeft() { }

	public void Reset() { }

	private void Update() { }

}

