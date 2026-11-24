namespace SYBO.Subway.Inputs;

public class InputManager
{
	private EventHandler<InputEventArgs> OnInputEvent; //Field offset: 0x10
	private SwipeInfo _swipeInfo; //Field offset: 0x14
	private bool _isEnabled; //Field offset: 0x18
	private InputEventArgs _previousInputEventArgs; //Field offset: 0x1C
	private InputEventArgs _currentInputEventArgs; //Field offset: 0x20
	private Swipe _currentSwipe; //Field offset: 0x24
	private float _lastTapTime; //Field offset: 0x28
	private bool <WasButtonClicked>k__BackingField; //Field offset: 0x2C
	private Camera __gameCamera; //Field offset: 0x30
	private Camera __menuCamera; //Field offset: 0x34
	private int _lastInputFrame; //Field offset: 0x38

	public event EventHandler<InputEventArgs> OnInputEvent
	{
		 add { } //Length: 96
		 remove { } //Length: 111
	}

	private Camera _gameCamera
	{
		 get { } //Length: 9
	}

	private Camera _menuCamera
	{
		 get { } //Length: 126
	}

	public InputEventArgs CurrentInputEventArgs
	{
		 get { } //Length: 6
	}

	public bool IsEnabled
	{
		 get { } //Length: 158
		 set { } //Length: 111
	}

	public InputEventArgs PreviousInputEventArgs
	{
		 get { } //Length: 9
	}

	public bool WasButtonClicked
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public InputManager() { }

	public void add_OnInputEvent(EventHandler<InputEventArgs> value) { }

	private SwipeDir AnalyzeSwipe(Swipe nextSwipe) { }

	private void ConvertSwipeToInputEventAndRaise(Swipe swipe, SwipeDir swipeDir) { }

	private void FixedUpdate() { }

	private Camera get__gameCamera() { }

	private Camera get__menuCamera() { }

	public InputEventArgs get_CurrentInputEventArgs() { }

	public bool get_IsEnabled() { }

	public InputEventArgs get_PreviousInputEventArgs() { }

	public bool get_WasButtonClicked() { }

	private void HandleControls() { }

	private bool HandleTap() { }

	private void ProcessKeyCode(KeyCode keyCode) { }

	private void RaiseOnInputEvent(InputEventArgs inputEventArgs) { }

	public void remove_OnInputEvent(EventHandler<InputEventArgs> value) { }

	public void SendInputEvent(InputEventArgs inputEventArgs) { }

	public void set_IsEnabled(bool value) { }

	public void set_WasButtonClicked(bool value) { }

	protected void Start() { }

	protected override void SubclassInitialize() { }

	protected void Update() { }

}

