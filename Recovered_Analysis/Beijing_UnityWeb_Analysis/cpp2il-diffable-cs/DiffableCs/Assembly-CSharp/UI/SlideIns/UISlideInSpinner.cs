namespace UI.SlideIns;

public class UISlideInSpinner : UISlideIn
{
	private const float SINGLE_STEP_THRESHOLD = 0.1; //Field offset: 0x0
	private const int STEP_COUNT = 8; //Field offset: 0x0
	private UILabel _messageLabel; //Field offset: 0x3C
	private UISprite _spinner; //Field offset: 0x40
	private Transform _cachedSpinnerTransform; //Field offset: 0x44
	private readonly Vector3 _singleStepRotation; //Field offset: 0x48
	private int _currentStep; //Field offset: 0x54
	private float _currentDuration; //Field offset: 0x58

	public UISlideInSpinner() { }

	private void SetupSlidein(string message) { }

	private void Update() { }

}

