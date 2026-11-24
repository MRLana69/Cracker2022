//Type is in global namespace

public class UIDragScrollView : MonoBehaviour
{
	public UIScrollView scrollView; //Field offset: 0xC
	private UIScrollView draggablePanel; //Field offset: 0x10
	private Transform mTrans; //Field offset: 0x14
	private UIScrollView mScroll; //Field offset: 0x18
	private bool mAutoFind; //Field offset: 0x1C
	private bool mStarted; //Field offset: 0x1D
	private bool mPressed; //Field offset: 0x1E

	public UIDragScrollView() { }

	private void FindScrollView() { }

	private void OnDisable() { }

	private void OnDrag(Vector2 delta) { }

	private void OnEnable() { }

	public void OnPan(Vector2 delta) { }

	private void OnPress(bool pressed) { }

	private void OnScroll(float delta) { }

	private void Start() { }

}

