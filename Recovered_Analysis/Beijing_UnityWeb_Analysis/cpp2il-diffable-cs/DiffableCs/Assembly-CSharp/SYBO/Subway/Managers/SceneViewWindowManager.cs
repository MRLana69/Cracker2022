namespace SYBO.Subway.Managers;

public class SceneViewWindowManager
{
	private Character _character; //Field offset: 0x10
	private bool _isEnabled; //Field offset: 0x14
	private SceneViewCameraTargetType __sceneViewCameraTargetType; //Field offset: 0x18
	private SceneViewCameraZoomType __sceneViewCameraZoomType; //Field offset: 0x1C
	protected List<SceneViewCameraTargetType> _sceneViewCameraTargetTypes; //Field offset: 0x20
	protected int _sceneViewCameraTargetTypesIndex; //Field offset: 0x24
	protected List<SceneViewCameraZoomType> _sceneViewCameraZoomTypes; //Field offset: 0x28
	protected int _sceneViewCameraZoomTypesIndex; //Field offset: 0x2C

	public Character Character
	{
		 get { } //Length: 189
		 set { } //Length: 64
	}

	public bool IsEnabled
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public SceneViewCameraTargetType SceneViewCameraTargetType
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public SceneViewCameraZoomType SceneViewCameraZoomType
	{
		 get { } //Length: 6
		 set { } //Length: 14
	}

	public SceneViewWindowManager() { }

	public Character get_Character() { }

	public bool get_IsEnabled() { }

	public SceneViewCameraTargetType get_SceneViewCameraTargetType() { }

	public SceneViewCameraZoomType get_SceneViewCameraZoomType() { }

	public object GetSceneView() { }

	public Vector3 GetSceneViewPivot() { }

	public Quaternion GetSceneViewRotation() { }

	public bool HasSceneView() { }

	private void RepaintSceneView() { }

	public void set_Character(Character value) { }

	public void set_IsEnabled(bool value) { }

	public void set_SceneViewCameraTargetType(SceneViewCameraTargetType value) { }

	public void set_SceneViewCameraZoomType(SceneViewCameraZoomType value) { }

	public void ShowNextSceneViewCameraTargetType() { }

	public void ShowNextSceneViewZoomType() { }

	protected override void SubclassInitialize() { }

	public void UpdatePropertiesOnSceneView() { }

}

