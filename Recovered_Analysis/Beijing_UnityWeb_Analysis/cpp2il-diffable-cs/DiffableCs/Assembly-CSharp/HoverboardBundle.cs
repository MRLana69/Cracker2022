//Type is in global namespace

public class HoverboardBundle : MonoBehaviour
{
	public class CustomSet
	{
		public BoardAbility ability; //Field offset: 0x8
		public GameObject baseModelPrefab; //Field offset: 0xC
		public GameObject modelPrefab; //Field offset: 0x10
		public GameObject VanityFxPrefab; //Field offset: 0x14
		public GameObject VanityMenuFxPrefab; //Field offset: 0x18
		public bool useDefaultmodel; //Field offset: 0x1C
		public bool useSuperSneakers; //Field offset: 0x1D
		public GameObject ExtraFXPrefab; //Field offset: 0x20
		public GameObject ExtraMenuFXPrefab; //Field offset: 0x24

		public CustomSet() { }

	}

	private CustomSet[] customSets; //Field offset: 0xC
	private bool converted; //Field offset: 0x10
	private BoardId _boardId; //Field offset: 0x14
	private string _serializedBoardId; //Field offset: 0x18
	private GameObject modelPrefab; //Field offset: 0x1C
	private GameObject previewModelPrefab; //Field offset: 0x20
	private CharacterModel _charactermodel; //Field offset: 0x24

	public BoardId boardId
	{
		 get { } //Length: 6
	}

	public CharacterModel Charactermodel
	{
		 get { } //Length: 224
		 set { } //Length: 86
	}

	public CustomSet[] CustomSets
	{
		 get { } //Length: 6
	}

	public HoverboardBundle() { }

	public void AddCustomBaseModel(int customSet, bool isMenu) { }

	public void AddCustomPreviewModel() { }

	public void AddCustomSetModelAndEffect(int customSet, bool isMenu, bool addEffect) { }

	public void AddModel(bool isMenu) { }

	public BoardId get_boardId() { }

	public CharacterModel get_Charactermodel() { }

	public CustomSet[] get_CustomSets() { }

	private GameObject InstatiateAndParentModelPrefab(GameObject prefab) { }

	public void set_Charactermodel(CharacterModel value) { }

}

