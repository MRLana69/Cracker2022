namespace UnityEngine.EventSystems;

public abstract class PointerInputModule : BaseInputModule
{
	protected class ButtonState
	{
		private InputButton m_Button; //Field offset: 0x8
		private MouseButtonEventData m_EventData; //Field offset: 0xC

		public InputButton button
		{
			 get { } //Length: 6
			 set { } //Length: 11
		}

		public MouseButtonEventData eventData
		{
			 get { } //Length: 6
			 set { } //Length: 49
		}

		public ButtonState() { }

		public InputButton get_button() { }

		public MouseButtonEventData get_eventData() { }

		public void set_button(InputButton value) { }

		public void set_eventData(MouseButtonEventData value) { }

	}

	public class MouseButtonEventData
	{
		public FramePressState buttonState; //Field offset: 0x8
		public PointerEventData buttonData; //Field offset: 0xC

		public MouseButtonEventData() { }

		public bool PressedThisFrame() { }

		public bool ReleasedThisFrame() { }

	}

	protected class MouseState
	{
		private List<ButtonState> m_TrackedButtons; //Field offset: 0x8

		public MouseState() { }

		public bool AnyPressesThisFrame() { }

		public bool AnyReleasesThisFrame() { }

		public ButtonState GetButtonState(InputButton button) { }

		public void SetButtonState(InputButton button, FramePressState stateForMouseButton, PointerEventData data) { }

	}

	public const int kMouseLeftId = -1; //Field offset: 0x0
	public const int kMouseRightId = -2; //Field offset: 0x0
	public const int kMouseMiddleId = -3; //Field offset: 0x0
	public const int kFakeTouchesId = -4; //Field offset: 0x0
	protected Dictionary<int, PointerEventData> m_PointerData; //Field offset: 0x24
	private readonly MouseState m_MouseState; //Field offset: 0x28

	protected PointerInputModule() { }

	protected void ClearSelection() { }

	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	protected PointerEventData GetLastPointerEventData(int id) { }

	protected virtual MouseState GetMousePointerEventData() { }

	protected virtual MouseState GetMousePointerEventData(int id) { }

	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	public override bool IsPointerOverGameObject(int pointerId) { }

	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	protected void RemovePointerData(PointerEventData data) { }

	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	protected FramePressState StateForMouseButton(int buttonId) { }

	public override string ToString() { }

}

