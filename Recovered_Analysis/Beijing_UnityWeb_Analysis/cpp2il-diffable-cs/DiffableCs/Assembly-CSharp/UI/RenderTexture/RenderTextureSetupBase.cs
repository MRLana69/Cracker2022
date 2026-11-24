namespace UI.RenderTexture;

public abstract class RenderTextureSetupBase
{
	private UITexture _texture; //Field offset: 0x8
	private Vector3 _position; //Field offset: 0xC
	private Vector3 _rotation; //Field offset: 0x18
	private float _scale; //Field offset: 0x24
	private GameObject _prefab; //Field offset: 0x28
	private AnimationClip _animationClip; //Field offset: 0x2C
	protected GameObject _objectInstance; //Field offset: 0x30
	protected RenderTextureManager _renderTextureManager; //Field offset: 0x34

	protected RenderTextureSetupBase() { }

	protected virtual void OnReleaseRenderTexture() { }

	protected virtual void OnSetup() { }

	public void ReleaseRenderTexture() { }

	public void Setup(CameraSettings overrideCameraSettings = null, bool copySettings = true) { }

}

