//Type is in global namespace

public class UIDragResize : MonoBehaviour
{
	public UIWidget target; //Field offset: 0xC
	public Pivot pivot; //Field offset: 0x10
	public int minWidth; //Field offset: 0x14
	public int minHeight; //Field offset: 0x18
	public int maxWidth; //Field offset: 0x1C
	public int maxHeight; //Field offset: 0x20
	public bool updateAnchors; //Field offset: 0x24
	private Plane mPlane; //Field offset: 0x28
	private Vector3 mRayPos; //Field offset: 0x38
	private Vector3 mLocalPos; //Field offset: 0x44
	private int mWidth; //Field offset: 0x50
	private int mHeight; //Field offset: 0x54
	private bool mDragging; //Field offset: 0x58

	public UIDragResize() { }

	private void OnDrag(Vector2 delta) { }

	private void OnDragEnd() { }

	private void OnDragStart() { }

}

