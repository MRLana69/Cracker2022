namespace UnityEngine.EventSystems;

public class EventSystem : UIBehaviour
{
	private static List<EventSystem> m_EventSystems; //Field offset: 0x0
	private static readonly Comparison<RaycastResult> s_RaycastComparer; //Field offset: 0x4
	private List<BaseInputModule> m_SystemInputModules; //Field offset: 0xC
	private BaseInputModule m_CurrentInputModule; //Field offset: 0x10
	private GameObject m_FirstSelected; //Field offset: 0x14
	private bool m_sendNavigationEvents; //Field offset: 0x18
	private int m_DragThreshold; //Field offset: 0x1C
	private GameObject m_CurrentSelected; //Field offset: 0x20
	private bool m_HasFocus; //Field offset: 0x24
	private bool m_SelectionGuard; //Field offset: 0x25
	private BaseEventData m_DummyData; //Field offset: 0x28

	public bool alreadySelecting
	{
		 get { } //Length: 9
	}

	private BaseEventData baseEventDataCache
	{
		 get { } //Length: 9
	}

	public static EventSystem current
	{
		 get { } //Length: 223
		 set { } //Length: 2
	}

	public BaseInputModule currentInputModule
	{
		 get { } //Length: 6
	}

	public GameObject currentSelectedGameObject
	{
		 get { } //Length: 6
	}

	public GameObject firstSelectedGameObject
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool isFocused
	{
		 get { } //Length: 3
	}

	public GameObject lastSelectedGameObject
	{
		 get { } //Length: 6
	}

	public int pixelDragThreshold
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool sendNavigationEvents
	{
		 get { } //Length: 755
		 set { } //Length: 111
	}

	private static EventSystem() { }

	protected EventSystem() { }

	private void ChangeEventModule(BaseInputModule module) { }

	public bool get_alreadySelecting() { }

	private BaseEventData get_baseEventDataCache() { }

	public static EventSystem get_current() { }

	public BaseInputModule get_currentInputModule() { }

	public GameObject get_currentSelectedGameObject() { }

	public GameObject get_firstSelectedGameObject() { }

	public bool get_isFocused() { }

	public GameObject get_lastSelectedGameObject() { }

	public int get_pixelDragThreshold() { }

	public bool get_sendNavigationEvents() { }

	public bool IsPointerOverGameObject(int pointerId) { }

	public bool IsPointerOverGameObject() { }

	protected virtual void OnApplicationFocus(bool hasFocus) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	public static void set_current(EventSystem value) { }

	public void set_firstSelectedGameObject(GameObject value) { }

	public void set_pixelDragThreshold(int value) { }

	public void set_sendNavigationEvents(bool value) { }

	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	public void SetSelectedGameObject(GameObject selected) { }

	private void TickModules() { }

	public override string ToString() { }

	protected virtual void Update() { }

	public void UpdateModules() { }

}

