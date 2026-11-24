namespace UnityEngine.EventSystems;

public abstract class BaseRaycaster : UIBehaviour
{
	private BaseRaycaster m_RootRaycaster; //Field offset: 0xC

	public abstract Camera eventCamera
	{
		 get { } //Length: 0
	}

	public virtual int priority
	{
		 get { } //Length: 650
	}

	public virtual int renderOrderPriority
	{
		 get { } //Length: 7
	}

	public BaseRaycaster rootRaycaster
	{
		 get { } //Length: 7
	}

	public virtual int sortOrderPriority
	{
		 get { } //Length: 3
	}

	protected BaseRaycaster() { }

	public abstract Camera get_eventCamera() { }

	public virtual int get_priority() { }

	public virtual int get_renderOrderPriority() { }

	public BaseRaycaster get_rootRaycaster() { }

	public virtual int get_sortOrderPriority() { }

	protected override void OnCanvasHierarchyChanged() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnTransformParentChanged() { }

	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	public override string ToString() { }

}

