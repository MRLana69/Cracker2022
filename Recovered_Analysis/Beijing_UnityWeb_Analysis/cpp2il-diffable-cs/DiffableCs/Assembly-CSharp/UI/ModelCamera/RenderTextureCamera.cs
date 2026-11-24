namespace UI.ModelCamera;

public class RenderTextureCamera
{
	private GameObject _cameraGo; //Field offset: 0x8
	private Camera _camera; //Field offset: 0xC
	private bool <isActive>k__BackingField; //Field offset: 0x10
	private RenderTexture <renderTexture>k__BackingField; //Field offset: 0x14

	public int cameraLayer
	{
		 get { } //Length: 6
	}

	public bool isActive
	{
		 get { } //Length: 103
		private set { } //Length: 235
	}

	public RenderTexture renderTexture
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public RenderTextureCamera(Camera camera, GameObject cameraGo, RenderTexture renderTexture) { }

	public void Activate(CameraSettings overrideCameraSettings) { }

	private void ClearRenderTexture(RenderTexture renderTextureToClear) { }

	public void Deactivate() { }

	public int get_cameraLayer() { }

	public bool get_isActive() { }

	public RenderTexture get_renderTexture() { }

	public Transform GetAnchor() { }

	private void set_isActive(bool value) { }

	private void set_renderTexture(RenderTexture value) { }

}

