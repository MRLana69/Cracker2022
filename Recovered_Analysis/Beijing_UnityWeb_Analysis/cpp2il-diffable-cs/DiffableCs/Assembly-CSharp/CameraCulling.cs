//Type is in global namespace

public class CameraCulling : MonoBehaviour
{
	private Camera _camera; //Field offset: 0xC
	private float[] _distances; //Field offset: 0x10

	public float TransparentFXCullingDistance
	{
		 set { } //Length: 120
	}

	public CameraCulling() { }

	private void Awake() { }

	public void set_TransparentFXCullingDistance(float value) { }

}

