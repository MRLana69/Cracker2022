namespace UnityEngine.EventSystems;

public abstract class BaseInputModule : UIBehaviour
{
	protected List<RaycastResult> m_RaycastResultCache; //Field offset: 0xC
	private AxisEventData m_AxisEventData; //Field offset: 0x10
	private EventSystem m_EventSystem; //Field offset: 0x14
	private BaseEventData m_BaseEventData; //Field offset: 0x18
	protected BaseInput m_InputOverride; //Field offset: 0x1C
	private BaseInput m_DefaultInput; //Field offset: 0x20

	protected EventSystem eventSystem
	{
		 get { } //Length: 6
	}

	public BaseInput input
	{
		 get { } //Length: 7
	}

	public BaseInput inputOverride
	{
		 get { } //Length: 463
		 set { } //Length: 9
	}

	protected BaseInputModule() { }

	public virtual void ActivateModule() { }

	public virtual void DeactivateModule() { }

	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	protected EventSystem get_eventSystem() { }

	public BaseInput get_input() { }

	public BaseInput get_inputOverride() { }

	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	protected virtual BaseEventData GetBaseEventData() { }

	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	public virtual bool IsModuleSupported() { }

	public virtual bool IsPointerOverGameObject(int pointerId) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public abstract void Process() { }

	public void set_inputOverride(BaseInput value) { }

	public virtual bool ShouldActivateModule() { }

	public virtual void UpdateModule() { }

}

