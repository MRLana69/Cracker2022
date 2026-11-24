namespace UnityEngine.EventSystems;

public class TouchInputModule : PointerInputModule
{
	private Vector2 m_LastMousePosition; //Field offset: 0x2C
	private Vector2 m_MousePosition; //Field offset: 0x34
	private PointerEventData m_InputPointerEvent; //Field offset: 0x3C
	private bool m_ForceModuleActive; //Field offset: 0x40

	public bool allowActivationOnStandalone
	{
		 get { } //Length: 6
		 set { } //Length: 1054
	}

	public bool forceModuleActive
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	protected TouchInputModule() { }

	public override void DeactivateModule() { }

	private void FakeTouches() { }

	public bool get_allowActivationOnStandalone() { }

	public bool get_forceModuleActive() { }

	public override bool IsModuleSupported() { }

	public override void Process() { }

	private void ProcessTouchEvents() { }

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	public void set_allowActivationOnStandalone(bool value) { }

	public void set_forceModuleActive(bool value) { }

	public override bool ShouldActivateModule() { }

	public override string ToString() { }

	public override void UpdateModule() { }

	private bool UseFakeInput() { }

}

