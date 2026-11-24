//Type is in global namespace

public class SpringPosition : MonoBehaviour
{
	public delegate OnFinished
	{

		public OnFinished(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public static SpringPosition current; //Field offset: 0x0
	public Vector3 target; //Field offset: 0xC
	public float strength; //Field offset: 0x18
	public bool worldSpace; //Field offset: 0x1C
	public bool ignoreTimeScale; //Field offset: 0x1D
	public bool updateScrollView; //Field offset: 0x1E
	public OnFinished onFinished; //Field offset: 0x20
	private GameObject eventReceiver; //Field offset: 0x24
	public string callWhenFinished; //Field offset: 0x28
	private Transform mTrans; //Field offset: 0x2C
	private float mThreshold; //Field offset: 0x30
	private UIScrollView mSv; //Field offset: 0x34

	public SpringPosition() { }

	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength) { }

	private void NotifyListeners() { }

	private void OnEnable() { }

	private void Start() { }

	private void Update() { }

}

