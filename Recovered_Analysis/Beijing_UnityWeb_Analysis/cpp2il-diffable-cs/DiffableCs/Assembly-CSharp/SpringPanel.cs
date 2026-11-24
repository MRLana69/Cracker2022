//Type is in global namespace

public class SpringPanel : MonoBehaviour
{
	public delegate OnFinished
	{

		public OnFinished(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public static SpringPanel current; //Field offset: 0x0
	public Vector3 target; //Field offset: 0xC
	public float strength; //Field offset: 0x18
	public OnFinished onFinished; //Field offset: 0x1C
	private UIPanel mPanel; //Field offset: 0x20
	private Transform mTrans; //Field offset: 0x24
	private UIScrollView mDrag; //Field offset: 0x28

	public SpringPanel() { }

	protected virtual void AdvanceTowardsPosition() { }

	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength) { }

	private void Start() { }

	public static SpringPanel Stop(GameObject go) { }

	private void Update() { }

}

