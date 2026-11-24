//Type is in global namespace

public class UITable : UIWidgetContainer
{
	public enum Direction
	{
		Down = 0,
		Up = 1,
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

	public int columns; //Field offset: 0xC
	public Direction direction; //Field offset: 0x10
	public Sorting sorting; //Field offset: 0x14
	public Pivot pivot; //Field offset: 0x18
	public Pivot cellAlignment; //Field offset: 0x1C
	public bool hideInactive; //Field offset: 0x20
	public bool keepWithinPanel; //Field offset: 0x21
	public Vector2 padding; //Field offset: 0x24
	public OnReposition onReposition; //Field offset: 0x2C
	public Comparison<Transform> onCustomSort; //Field offset: 0x30
	protected UIPanel mPanel; //Field offset: 0x34
	protected bool mInitDone; //Field offset: 0x38
	protected bool mReposition; //Field offset: 0x39

	public bool repositionNow
	{
		 set { } //Length: 75
	}

	public UITable() { }

	public List<Transform> GetChildList() { }

	protected virtual void Init() { }

	protected virtual void LateUpdate() { }

	private void OnValidate() { }

	public virtual void Reposition() { }

	protected void RepositionVariableSize(List<Transform> children) { }

	public void set_repositionNow(bool value) { }

	protected virtual void Sort(List<Transform> list) { }

	protected virtual void Start() { }

}

