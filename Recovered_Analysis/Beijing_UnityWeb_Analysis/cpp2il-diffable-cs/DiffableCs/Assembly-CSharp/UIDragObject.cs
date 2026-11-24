//Type is in global namespace

public class UIDragObject : MonoBehaviour
{
	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2,
	}

	public Transform target; //Field offset: 0xC
	public UIPanel panelRegion; //Field offset: 0x10
	public Vector3 scrollMomentum; //Field offset: 0x14
	public bool restrictWithinPanel; //Field offset: 0x20
	public UIRect contentRect; //Field offset: 0x24
	public DragEffect dragEffect; //Field offset: 0x28
	public float momentumAmount; //Field offset: 0x2C
	protected Vector3 scale; //Field offset: 0x30
	private float scrollWheelFactor; //Field offset: 0x3C
	private Plane mPlane; //Field offset: 0x40
	private Vector3 mTargetPos; //Field offset: 0x50
	private Vector3 mLastPos; //Field offset: 0x5C
	private Vector3 mMomentum; //Field offset: 0x68
	private Vector3 mScroll; //Field offset: 0x74
	private Bounds mBounds; //Field offset: 0x80
	private int mTouchID; //Field offset: 0x98
	private bool mStarted; //Field offset: 0x9C
	private bool mPressed; //Field offset: 0x9D

	public Vector3 dragMovement
	{
		 get { } //Length: 993
		 set { } //Length: 26
	}

	public UIDragObject() { }

	public void CancelMovement() { }

	public void CancelSpring() { }

	private void FindPanel() { }

	public Vector3 get_dragMovement() { }

	private void LateUpdate() { }

	private void Move(Vector3 worldDelta) { }

	private void OnDisable() { }

	private void OnDrag(Vector2 delta) { }

	private void OnEnable() { }

	private void OnPress(bool pressed) { }

	private void OnScroll(float delta) { }

	public void set_dragMovement(Vector3 value) { }

	private void UpdateBounds() { }

}

