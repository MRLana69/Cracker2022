//Type is in global namespace

public class UIDraggableCamera : MonoBehaviour
{
	public Transform rootForBounds; //Field offset: 0xC
	public Vector2 scale; //Field offset: 0x10
	public float scrollWheelFactor; //Field offset: 0x18
	public DragEffect dragEffect; //Field offset: 0x1C
	public bool smoothDragStart; //Field offset: 0x20
	public float momentumAmount; //Field offset: 0x24
	private Camera mCam; //Field offset: 0x28
	private Transform mTrans; //Field offset: 0x2C
	private bool mPressed; //Field offset: 0x30
	private Vector2 mMomentum; //Field offset: 0x34
	private Bounds mBounds; //Field offset: 0x3C
	private float mScroll; //Field offset: 0x54
	private UIRoot mRoot; //Field offset: 0x58
	private bool mDragStarted; //Field offset: 0x5C

	public Vector2 currentMomentum
	{
		 get { } //Length: 17
		 set { } //Length: 11
	}

	public UIDraggableCamera() { }

	private Vector3 CalculateConstrainOffset() { }

	public bool ConstrainToBounds(bool immediate) { }

	public void Drag(Vector2 delta) { }

	public Vector2 get_currentMomentum() { }

	public void Press(bool isPressed) { }

	public void Scroll(float delta) { }

	public void set_currentMomentum(Vector2 value) { }

	private void Start() { }

	private void Update() { }

}

