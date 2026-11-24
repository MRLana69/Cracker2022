//Type is in global namespace

public class DoubleCoinsButton : MonoBehaviour
{
	private UILabel _doubleCoinsLabel; //Field offset: 0xC
	private Color _notOwnedLabelColor; //Field offset: 0x10
	private bool _switch; //Field offset: 0x20
	private UISprite _overlaySprite; //Field offset: 0x24
	private bool _notOwnedOverlayActive; //Field offset: 0x28
	private bool _ownedOverlayActive; //Field offset: 0x29
	private Color _notOwnedOverlayColor; //Field offset: 0x2C
	private Color _ownedOverlayColor; //Field offset: 0x3C
	private UISprite _backgroundSprite; //Field offset: 0x4C
	private Color _notOwnedBackgroundColor; //Field offset: 0x50
	private Color _ownedBackgroundColor; //Field offset: 0x60
	private Animation _animation; //Field offset: 0x70
	private GameObject _animationSprite; //Field offset: 0x74
	private bool _notOwnedAnimationActive; //Field offset: 0x78
	private bool _ownedAnimationActive; //Field offset: 0x79
	private GameObject _ownedCheck; //Field offset: 0x7C
	private Collider _collider; //Field offset: 0x80
	private bool owned; //Field offset: 0x84

	public DoubleCoinsButton() { }

	private void Awake() { }

	public void ChangeState(bool owned) { }

	private void Update() { }

}

