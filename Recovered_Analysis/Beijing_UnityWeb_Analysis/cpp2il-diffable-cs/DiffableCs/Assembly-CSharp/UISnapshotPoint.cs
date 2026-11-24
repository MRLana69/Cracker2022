//Type is in global namespace

public class UISnapshotPoint : MonoBehaviour
{
	public bool isOrthographic; //Field offset: 0xC
	public float nearClip; //Field offset: 0x10
	public float farClip; //Field offset: 0x14
	public int fieldOfView; //Field offset: 0x18
	public float orthoSize; //Field offset: 0x1C
	public Texture2D thumbnail; //Field offset: 0x20

	public UISnapshotPoint() { }

	private void Start() { }

}

