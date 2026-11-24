namespace UnityEngine.EventSystems;

public class StandaloneInputModule : PointerInputModule
{
	public enum InputMode
	{
		Mouse = 0,
		Buttons = 1,
	}

	private float m_PrevActionTime; //Field offset: 0x2C
	private Vector2 m_LastMoveVector; //Field offset: 0x30
	private int m_ConsecutiveMoveCount; //Field offset: 0x38
	private Vector2 m_LastMousePosition; //Field offset: 0x3C
	private Vector2 m_MousePosition; //Field offset: 0x44
	private GameObject m_CurrentFocusedGameObject; //Field offset: 0x4C
	private PointerEventData m_InputPointerEvent; //Field offset: 0x50
	private string m_HorizontalAxis; //Field offset: 0x54
	private string m_VerticalAxis; //Field offset: 0x58
	private string m_SubmitButton; //Field offset: 0x5C
	private string m_CancelButton; //Field offset: 0x60
	private float m_InputActionsPerSecond; //Field offset: 0x64
	private float m_RepeatDelay; //Field offset: 0x68
	private bool m_ForceModuleActive; //Field offset: 0x6C

	public bool allowActivationOnMobileDevice
	{
		 get { } //Length: 3
		 set { } //Length: 558
	}

	public string cancelButton
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public bool forceModuleActive
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public string horizontalAxis
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float inputActionsPerSecond
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public InputMode inputMode
	{
		 get { } //Length: 840
	}

	public float repeatDelay
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public string submitButton
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public string verticalAxis
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	protected StandaloneInputModule() { }

	public override void ActivateModule() { }

	public override void DeactivateModule() { }

	protected virtual bool ForceAutoSelect() { }

	public bool get_allowActivationOnMobileDevice() { }

	public string get_cancelButton() { }

	public bool get_forceModuleActive() { }

	public string get_horizontalAxis() { }

	public float get_inputActionsPerSecond() { }

	public InputMode get_inputMode() { }

	public float get_repeatDelay() { }

	public string get_submitButton() { }

	public string get_verticalAxis() { }

	protected GameObject GetCurrentFocusedGameObject() { }

	private Vector2 GetRawMoveVector() { }

	public override bool IsModuleSupported() { }

	public override void Process() { }

	protected void ProcessMouseEvent(int id) { }

	protected void ProcessMouseEvent() { }

	protected void ProcessMousePress(MouseButtonEventData data) { }

	private bool ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	protected bool SendMoveEventToSelectedObject() { }

	protected bool SendSubmitEventToSelectedObject() { }

	protected bool SendUpdateEventToSelectedObject() { }

	public void set_allowActivationOnMobileDevice(bool value) { }

	public void set_cancelButton(string value) { }

	public void set_forceModuleActive(bool value) { }

	public void set_horizontalAxis(string value) { }

	public void set_inputActionsPerSecond(float value) { }

	public void set_repeatDelay(float value) { }

	public void set_submitButton(string value) { }

	public void set_verticalAxis(string value) { }

	public override bool ShouldActivateModule() { }

	private bool ShouldIgnoreEventsOnNoFocus() { }

	public override void UpdateModule() { }

}

