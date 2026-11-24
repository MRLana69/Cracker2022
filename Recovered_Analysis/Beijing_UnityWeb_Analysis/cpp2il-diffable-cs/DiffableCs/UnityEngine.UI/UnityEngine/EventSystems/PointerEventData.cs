namespace UnityEngine.EventSystems;

public class PointerEventData : BaseEventData
{
	public enum FramePressState
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3,
	}

	public enum InputButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
	}

	private GameObject <pointerEnter>k__BackingField; //Field offset: 0x10
	private GameObject m_PointerPress; //Field offset: 0x14
	private GameObject <lastPress>k__BackingField; //Field offset: 0x18
	private GameObject <rawPointerPress>k__BackingField; //Field offset: 0x1C
	private GameObject <pointerDrag>k__BackingField; //Field offset: 0x20
	private RaycastResult <pointerCurrentRaycast>k__BackingField; //Field offset: 0x24
	private RaycastResult <pointerPressRaycast>k__BackingField; //Field offset: 0x60
	public List<GameObject> hovered; //Field offset: 0x9C
	private bool <eligibleForClick>k__BackingField; //Field offset: 0xA0
	private int <pointerId>k__BackingField; //Field offset: 0xA4
	private Vector2 <position>k__BackingField; //Field offset: 0xA8
	private Vector2 <delta>k__BackingField; //Field offset: 0xB0
	private Vector2 <pressPosition>k__BackingField; //Field offset: 0xB8
	private Vector3 <worldPosition>k__BackingField; //Field offset: 0xC0
	private Vector3 <worldNormal>k__BackingField; //Field offset: 0xCC
	private float <clickTime>k__BackingField; //Field offset: 0xD8
	private int <clickCount>k__BackingField; //Field offset: 0xDC
	private Vector2 <scrollDelta>k__BackingField; //Field offset: 0xE0
	private bool <useDragThreshold>k__BackingField; //Field offset: 0xE8
	private bool <dragging>k__BackingField; //Field offset: 0xE9
	private InputButton <button>k__BackingField; //Field offset: 0xEC

	public InputButton button
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public int clickCount
	{
		 get { } //Length: 7
		 set { } //Length: 62
	}

	public float clickTime
	{
		 get { } //Length: 9
		 set { } //Length: 14
	}

	public Vector2 delta
	{
		 get { } //Length: 52
		 set { } //Length: 12
	}

	public bool dragging
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public bool eligibleForClick
	{
		 get { } //Length: 6
		 set { } //Length: 104
	}

	public Camera enterEventCamera
	{
		 get { } //Length: 63
	}

	public GameObject lastPress
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public RaycastResult pointerCurrentRaycast
	{
		 get { } //Length: 11
		 set { } //Length: 9
	}

	public GameObject pointerDrag
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public GameObject pointerEnter
	{
		 get { } //Length: 9
		 set { } //Length: 16
	}

	public int pointerId
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public GameObject pointerPress
	{
		 get { } //Length: 136
		 set { } //Length: 324
	}

	public RaycastResult pointerPressRaycast
	{
		 get { } //Length: 104
		 set { } //Length: 9
	}

	public Vector2 position
	{
		 get { } //Length: 9
		 set { } //Length: 12
	}

	public Camera pressEventCamera
	{
		 get { } //Length: 136
	}

	public Vector2 pressPosition
	{
		 get { } //Length: 52
		 set { } //Length: 12
	}

	public GameObject rawPointerPress
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Vector2 scrollDelta
	{
		 get { } //Length: 9
		 set { } //Length: 12
	}

	public bool useDragThreshold
	{
		 get { } //Length: 7
		 set { } //Length: 52
	}

	public Vector3 worldNormal
	{
		 get { } //Length: 62
		 set { } //Length: 27
	}

	public Vector3 worldPosition
	{
		 get { } //Length: 52
		 set { } //Length: 27
	}

	public PointerEventData(EventSystem eventSystem) { }

	public InputButton get_button() { }

	public int get_clickCount() { }

	public float get_clickTime() { }

	public Vector2 get_delta() { }

	public bool get_dragging() { }

	public bool get_eligibleForClick() { }

	public Camera get_enterEventCamera() { }

	public GameObject get_lastPress() { }

	public RaycastResult get_pointerCurrentRaycast() { }

	public GameObject get_pointerDrag() { }

	public GameObject get_pointerEnter() { }

	public int get_pointerId() { }

	public GameObject get_pointerPress() { }

	public RaycastResult get_pointerPressRaycast() { }

	public Vector2 get_position() { }

	public Camera get_pressEventCamera() { }

	public Vector2 get_pressPosition() { }

	public GameObject get_rawPointerPress() { }

	public Vector2 get_scrollDelta() { }

	public bool get_useDragThreshold() { }

	public Vector3 get_worldNormal() { }

	public Vector3 get_worldPosition() { }

	public bool IsPointerMoving() { }

	public bool IsScrolling() { }

	public void set_button(InputButton value) { }

	public void set_clickCount(int value) { }

	public void set_clickTime(float value) { }

	public void set_delta(Vector2 value) { }

	public void set_dragging(bool value) { }

	public void set_eligibleForClick(bool value) { }

	private void set_lastPress(GameObject value) { }

	public void set_pointerCurrentRaycast(RaycastResult value) { }

	public void set_pointerDrag(GameObject value) { }

	public void set_pointerEnter(GameObject value) { }

	public void set_pointerId(int value) { }

	public void set_pointerPress(GameObject value) { }

	public void set_pointerPressRaycast(RaycastResult value) { }

	public void set_position(Vector2 value) { }

	public void set_pressPosition(Vector2 value) { }

	public void set_rawPointerPress(GameObject value) { }

	public void set_scrollDelta(Vector2 value) { }

	public void set_useDragThreshold(bool value) { }

	public void set_worldNormal(Vector3 value) { }

	public void set_worldPosition(Vector3 value) { }

	public override string ToString() { }

}

