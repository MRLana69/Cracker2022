namespace UnityEngine.EventSystems;

public class PhysicsRaycaster : BaseRaycaster
{
	private class RaycastHitComparer : IComparer<RaycastHit>
	{
		public static RaycastHitComparer instance; //Field offset: 0x0

		private static RaycastHitComparer() { }

		public RaycastHitComparer() { }

		public int Compare(RaycastHit x, RaycastHit y) { }

	}

	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	protected Camera m_EventCamera; //Field offset: 0x10
	protected LayerMask m_EventMask; //Field offset: 0x14
	protected int m_MaxRayIntersections; //Field offset: 0x18
	protected int m_LastMaxRayIntersections; //Field offset: 0x1C
	private RaycastHit[] m_Hits; //Field offset: 0x20

	public virtual int depth
	{
		 get { } //Length: 130
	}

	public override Camera eventCamera
	{
		 get { } //Length: 339
	}

	public LayerMask eventMask
	{
		 get { } //Length: 159
		 set { } //Length: 14
	}

	public int finalEventMask
	{
		 get { } //Length: 164
	}

	public int maxRayIntersections
	{
		 get { } //Length: 6
		 set { } //Length: 51
	}

	protected PhysicsRaycaster() { }

	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref float distanceToClipPlane) { }

	public virtual int get_depth() { }

	public override Camera get_eventCamera() { }

	public LayerMask get_eventMask() { }

	public int get_finalEventMask() { }

	public int get_maxRayIntersections() { }

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	public void set_eventMask(LayerMask value) { }

	public void set_maxRayIntersections(int value) { }

}

