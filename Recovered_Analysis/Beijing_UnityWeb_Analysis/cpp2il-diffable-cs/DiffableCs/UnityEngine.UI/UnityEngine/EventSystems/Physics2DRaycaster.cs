namespace UnityEngine.EventSystems;

public class Physics2DRaycaster : PhysicsRaycaster
{
	private RaycastHit2D[] m_Hits; //Field offset: 0x24

	protected Physics2DRaycaster() { }

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

}

