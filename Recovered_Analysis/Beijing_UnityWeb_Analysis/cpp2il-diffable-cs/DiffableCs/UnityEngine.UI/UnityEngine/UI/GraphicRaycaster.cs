namespace UnityEngine.UI;

public class GraphicRaycaster : BaseRaycaster
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Graphic> <>9__24_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <Raycast>b__24_0(Graphic g1, Graphic g2) { }

	}

	public enum BlockingObjects
	{
		None = 0,
		TwoD = 1,
		ThreeD = 2,
		All = 3,
	}

	protected const int kNoEventMaskSet = -1; //Field offset: 0x0
	private static readonly List<Graphic> s_SortedGraphics; //Field offset: 0x0
	private bool m_IgnoreReversedGraphics; //Field offset: 0x10
	private BlockingObjects m_BlockingObjects; //Field offset: 0x14
	protected LayerMask m_BlockingMask; //Field offset: 0x18
	private Canvas m_Canvas; //Field offset: 0x1C
	private List<Graphic> m_RaycastResults; //Field offset: 0x20

	public BlockingObjects blockingObjects
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	private Canvas canvas
	{
		 get { } //Length: 6
	}

	public override Camera eventCamera
	{
		 get { } //Length: 115
	}

	public bool ignoreReversedGraphics
	{
		 get { } //Length: 45
		 set { } //Length: 68
	}

	public override int renderOrderPriority
	{
		 get { } //Length: 39
	}

	public override int sortOrderPriority
	{
		 get { } //Length: 9
	}

	private static GraphicRaycaster() { }

	protected GraphicRaycaster() { }

	public BlockingObjects get_blockingObjects() { }

	private Canvas get_canvas() { }

	public override Camera get_eventCamera() { }

	public bool get_ignoreReversedGraphics() { }

	public override int get_renderOrderPriority() { }

	public override int get_sortOrderPriority() { }

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	public void set_blockingObjects(BlockingObjects value) { }

	public void set_ignoreReversedGraphics(bool value) { }

}

