namespace UI.ModelCamera;

public class ModelScreenData
{
	private Transform _modelTranform; //Field offset: 0x8
	private GameObject _modelGo; //Field offset: 0xC
	private CharacterModel <characterModel>k__BackingField; //Field offset: 0x10
	private Camera <camera>k__BackingField; //Field offset: 0x14
	private CharacterId <characterId>k__BackingField; //Field offset: 0x18
	private int <themeVersion>k__BackingField; //Field offset: 0x1C

	public Camera camera
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public int cameraLayer
	{
		 get { } //Length: 107
	}

	public Transform cameraTransform
	{
		 get { } //Length: 6
	}

	public CharacterId characterId
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public CharacterModel characterModel
	{
		 get { } //Length: 214
		private set { } //Length: 829
	}

	public bool isCameraActive
	{
		 get { } //Length: 18
	}

	public bool isModelActive
	{
		 get { } //Length: 12
	}

	public GameObject modelGo
	{
		 get { } //Length: 6
	}

	public Transform modelTranform
	{
		 get { } //Length: 6
	}

	public int themeVersion
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public ModelScreenData(GameObject modelGo, Camera camera, CharacterId characterId, int themeVersion) { }

	public void Activate() { }

	public void Deactivate() { }

	public Camera get_camera() { }

	public int get_cameraLayer() { }

	public Transform get_cameraTransform() { }

	public CharacterId get_characterId() { }

	public CharacterModel get_characterModel() { }

	public bool get_isCameraActive() { }

	public bool get_isModelActive() { }

	public GameObject get_modelGo() { }

	public Transform get_modelTranform() { }

	public int get_themeVersion() { }

	private void set_camera(Camera value) { }

	public void set_characterId(CharacterId value) { }

	private void set_characterModel(CharacterModel value) { }

	public void set_themeVersion(int value) { }

	public void UpdateCharacterDataIfNeeded(CharacterId charId, int currentlySelectedThemeVersion) { }

}

