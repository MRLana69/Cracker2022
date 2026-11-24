//Type is in global namespace

public class UIWrapContent : MonoBehaviour
{
	public delegate OnInitializeItem
	{

		public OnInitializeItem(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject go, int wrapIndex, int realIndex, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject go, int wrapIndex, int realIndex) { }

	}

	public int itemSize; //Field offset: 0xC
	public bool cullContent; //Field offset: 0x10
	public int minIndex; //Field offset: 0x14
	public int maxIndex; //Field offset: 0x18
	public bool hideInactive; //Field offset: 0x1C
	public OnInitializeItem onInitializeItem; //Field offset: 0x20
	protected Transform mTrans; //Field offset: 0x24
	protected UIPanel mPanel; //Field offset: 0x28
	protected UIScrollView mScroll; //Field offset: 0x2C
	protected bool mHorizontal; //Field offset: 0x30
	protected bool mFirstTime; //Field offset: 0x31
	protected List<Transform> mChildren; //Field offset: 0x34

	public UIWrapContent() { }

	protected bool CacheScrollView() { }

	protected virtual void OnMove(UIPanel panel) { }

	private void OnValidate() { }

	protected virtual void ResetChildPositions() { }

	public virtual void SortAlphabetically() { }

	public virtual void SortBasedOnScrollMovement() { }

	protected virtual void Start() { }

	protected virtual void UpdateItem(Transform item, int index) { }

	public virtual void WrapContent() { }

}

