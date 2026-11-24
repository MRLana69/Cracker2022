//Type is in global namespace

public class ResolutionSetup : MonoBehaviour
{
	private const string PATH_TO_ATLASES = "Prefabs/Atlases/"; //Field offset: 0x0
	private const string HIGH_RES_MENU_ATLAS_NAME = "HighResAtlas"; //Field offset: 0x0
	private const string HIGH_RES_COUNTRIES_ATLAS_NAME = "HighResCountriesAtlas"; //Field offset: 0x0
	private const string LOW_RES_MENU_ATLAS_NAME = "LowResAtlas"; //Field offset: 0x0
	private UIAtlas menuAtlas; //Field offset: 0xC
	private UIAtlas countriesAtlas; //Field offset: 0x10
	private UIAtlas _lowResMenuAtlas; //Field offset: 0x14
	private UIAtlas _highResMenuAtlas; //Field offset: 0x18
	private UIAtlas _highResCountriesAtlas; //Field offset: 0x1C
	private UIAtlas _editorMenuAtlase; //Field offset: 0x20
	private UIAtlas _editorCountriesAtlase; //Field offset: 0x24

	public ResolutionSetup() { }

	private void Awake() { }

	private void LoadAtlas(string atlasName, ref UIAtlas cachedAtlas) { }

	private void OnDisable() { }

	private void SetAtlasReferenceTo(UIAtlas referenceAtlas, UIAtlas newAtlas) { }

	private void SetupCountriesAtlasReference() { }

	private void SetupMenuAtlasReference() { }

}

