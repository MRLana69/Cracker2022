namespace SYBO.Subway.Visuals;

public class BaseCameraFX : MonoBehaviour
{
	private GameObject _onGameObject; //Field offset: 0xC
	private GameObject _offGameObject; //Field offset: 0x10
	private CameraFXState _cameraFXState; //Field offset: 0x14

	public CameraFXState CameraFXState
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public BaseCameraFX() { }

	public CameraFXState get_CameraFXState() { }

	public void set_CameraFXState(CameraFXState value) { }

	protected virtual void Start() { }

}

