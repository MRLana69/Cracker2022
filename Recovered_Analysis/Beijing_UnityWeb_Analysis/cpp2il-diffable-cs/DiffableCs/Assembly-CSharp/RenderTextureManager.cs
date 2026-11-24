//Type is in global namespace

public class RenderTextureManager : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public RenderTexture texture; //Field offset: 0x8

		public <>c__DisplayClass10_0() { }

		internal bool <ReleaseTexture>b__0(RenderTextureCamera item) { }

	}

	private const float CAMERA_Y_OFFSET = 10000; //Field offset: 0x0
	private static RenderTextureManager _instance; //Field offset: 0x0
	private GameObject _cameraPrefab; //Field offset: 0xC
	private Transform _renderTextureCamerasRoot; //Field offset: 0x10
	private List<RenderTextureCamera> _renderTextureCameras; //Field offset: 0x14
	private RenderTexture _renderTexturePrefab; //Field offset: 0x18

	public static RenderTextureManager instance
	{
		 get { } //Length: 49
	}

	public RenderTextureManager() { }

	private void Awake() { }

	private void CopyRenderTextureSettings(ref RenderTexture dst, RenderTexture src) { }

	private RenderTextureCamera CreateNewCamera(bool copySettings) { }

	private RenderTexture CreateRenderTexture(bool copySettings) { }

	public static RenderTextureManager get_instance() { }

	private RenderTextureCamera GetAvailableCamera(bool copySettings) { }

	public RenderTexture GetRenderTextureFor(GameObject go, AnimationClip animationClip = null, CameraSettings overrideCameraSettings = null, bool copySettings = true) { }

	public void ReleaseTexture(RenderTexture texture) { }

}

