//Type is in global namespace

public class UIGrid : UIWidgetContainer
{
	public enum Arrangement
	{
		Horizontal = 0,
		Vertical = 1,
		CellSnap = 2,
	}

	public delegate OnReposition
	{

		public OnReposition(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public enum Sorting
	{
		None = 0,
		Alphabetic = 1,
		Horizontal = 2,
		Vertical = 3,
		Custom = 4,
	}

	public Arrangement arrangement; //Field offset: 0xC
	public Sorting sorting; //Field offset: 0x10
	public Pivot pivot; //Field offset: 0x14
	public int maxPerLine; //Field offset: 0x18
	public float cellWidth; //Field offset: 0x1C
	public float cellHeight; //Field offset: 0x20
	public bool animateSmoothly; //Field offset: 0x24
	public bool hideInactive; //Field offset: 0x25
	public bool keepWithinPanel; //Field offset: 0x26
	public OnReposition onReposition; //Field offset: 0x28
	public Comparison<Transform> onCustomSort; //Field offset: 0x2C
	private bool sorted; //Field offset: 0x30
	protected bool mReposition; //Field offset: 0x31
	protected UIPanel mPanel; //Field offset: 0x34
	protected bool mInitDone; //Field offset: 0x38

	public bool repositionNow
	{
		 set { } //Length: 118
	}

	public UIGrid() { }

	public void AddChild(Transform trans) { }

	public void AddChild(Transform trans, bool sort) { }

	public void ConstrainWithinPanel() { }

	public Transform GetChild(int index) { }

	public List<Transform> GetChildList() { }

	public int GetIndex(Transform trans) { }

	protected virtual void Init() { }

	private void OnValidate() { }

	public bool RemoveChild(Transform t) { }

	public virtual void Reposition() { }

	protected virtual void ResetPosition(List<Transform> list) { }

	public void set_repositionNow(bool value) { }

	protected virtual void Sort(List<Transform> list) { }

	public static int SortByName(Transform a, Transform b) { }

	public static int SortHorizontal(Transform a, Transform b) { }

	public static int SortVertical(Transform a, Transform b) { }

	protected virtual void Start() { }

	protected virtual void Update() { }

}

