//Type is in global namespace

public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera; //Field offset: 0xC
	public Transform topLeft; //Field offset: 0x10
	public Transform bottomRight; //Field offset: 0x14
	public float fullSize; //Field offset: 0x18
	private Camera mCam; //Field offset: 0x1C

	public UIViewport() { }

	private void LateUpdate() { }

	private void Start() { }

}

