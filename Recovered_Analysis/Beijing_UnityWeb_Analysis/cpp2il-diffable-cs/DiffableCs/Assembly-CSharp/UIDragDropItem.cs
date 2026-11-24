//Type is in global namespace

public class UIDragDropItem : MonoBehaviour
{
	public enum Restriction
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		PressAndHold = 3,
	}

	public static List<UIDragDropItem> draggedItems; //Field offset: 0x0
	public Restriction restriction; //Field offset: 0xC
	public bool cloneOnDrag; //Field offset: 0x10
	public float pressAndHoldDelay; //Field offset: 0x14
	public bool interactable; //Field offset: 0x18
	protected Transform mTrans; //Field offset: 0x1C
	protected Transform mParent; //Field offset: 0x20
	protected Collider mCollider; //Field offset: 0x24
	protected Collider2D mCollider2D; //Field offset: 0x28
	protected UIButton mButton; //Field offset: 0x2C
	protected UIRoot mRoot; //Field offset: 0x30
	protected UIGrid mGrid; //Field offset: 0x34
	protected UITable mTable; //Field offset: 0x38
	protected float mDragStartTime; //Field offset: 0x3C
	protected UIDragScrollView mDragScrollView; //Field offset: 0x40
	protected bool mPressed; //Field offset: 0x44
	protected bool mDragging; //Field offset: 0x45
	protected MouseOrTouch mTouch; //Field offset: 0x48

	private static UIDragDropItem() { }

	public UIDragDropItem() { }

	protected virtual void Awake() { }

	protected virtual void DestroySelf() { }

	protected void EnableDragScrollView() { }

	protected void OnApplicationFocus(bool focus) { }

	protected virtual void OnClone(GameObject original) { }

	protected virtual void OnDisable() { }

	protected virtual void OnDrag(Vector2 delta) { }

	protected virtual void OnDragDropEnd() { }

	protected virtual void OnDragDropMove(Vector2 delta) { }

	protected virtual void OnDragDropRelease(GameObject surface) { }

	protected virtual void OnDragDropStart() { }

	protected virtual void OnDragEnd() { }

	protected virtual void OnDragStart() { }

	protected virtual void OnEnable() { }

	protected virtual void OnPress(bool isPressed) { }

	protected virtual void Start() { }

	public virtual void StartDragging() { }

	public void StopDragging(GameObject go = null) { }

	protected virtual void Update() { }

}

