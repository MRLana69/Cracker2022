//Type is in global namespace

public class UICenterOnChild : MonoBehaviour
{
	public delegate OnCenterCallback
	{

		public OnCenterCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(GameObject centeredObject, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(GameObject centeredObject) { }

	}

	public float springStrength; //Field offset: 0xC
	public float nextPageThreshold; //Field offset: 0x10
	public OnFinished onFinished; //Field offset: 0x14
	public OnCenterCallback onCenter; //Field offset: 0x18
	private UIScrollView mScrollView; //Field offset: 0x1C
	private GameObject mCenteredObject; //Field offset: 0x20

	public GameObject centeredObject
	{
		 get { } //Length: 9
	}

	public UICenterOnChild() { }

	private void CenterOn(Transform target, Vector3 panelCenter) { }

	public void CenterOn(Transform target) { }

	public GameObject get_centeredObject() { }

	private void OnDisable() { }

	private void OnDragFinished() { }

	private void OnEnable() { }

	private void OnValidate() { }

	public void Recenter() { }

	private void Start() { }

}

