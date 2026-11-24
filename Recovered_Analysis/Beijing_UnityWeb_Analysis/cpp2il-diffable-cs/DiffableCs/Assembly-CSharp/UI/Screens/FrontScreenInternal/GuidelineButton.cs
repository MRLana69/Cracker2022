namespace UI.Screens.FrontScreenInternal;

public class GuidelineButton : MonoBehaviour
{
	private enum AnimationState
	{
		None = 0,
		Scaling = 1,
		Blinking = 2,
		Waiting = 3,
	}

	public enum GuidelineButtonType
	{
		NotSet = 0,
		Hoverboard = 1,
		FacebookOrCollect = 2,
		Mission1 = 3,
		PlayerMenuIntroduction = 4,
		ShopMenuIntroduction = 5,
	}

	private const float SCALE_DURATION = 1; //Field offset: 0x0
	private const float WAIT_DURATION = 2; //Field offset: 0x0
	private const float BLINK_DURATION = 1; //Field offset: 0x0
	private UISprite _infoSprite; //Field offset: 0xC
	private UISprite _infoSpriteOverlay; //Field offset: 0x10
	private GameObject _breadcrumb; //Field offset: 0x14
	private GameObject _discount; //Field offset: 0x18
	private bool _showIcon; //Field offset: 0x1C
	public GuidelineButtonType guidelineButtonType; //Field offset: 0x20
	private bool _hasInited; //Field offset: 0x24
	private readonly Vector3 _startScale; //Field offset: 0x28
	private readonly Vector3 _endScale; //Field offset: 0x34
	private AnimationState _animationState; //Field offset: 0x40
	private float _currentAnimationTime; //Field offset: 0x44

	public GuidelineButton() { }

	private void Awake() { }

	public void DetermineVisibility() { }

	private void EnableInfoIcon() { }

	private void ForceAnimation() { }

	private void InitAnimation() { }

	private void OnClick() { }

	private void OnEnable() { }

	public bool ShouldInfoIconShow() { }

	private void Update() { }

}

