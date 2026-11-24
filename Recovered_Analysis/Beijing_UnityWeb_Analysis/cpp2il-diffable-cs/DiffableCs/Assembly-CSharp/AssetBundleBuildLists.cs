//Type is in global namespace

public class AssetBundleBuildLists : MonoBehaviour
{
	public class BuildListEntry
	{
		public string Name; //Field offset: 0x8
		public CharacterId characterId; //Field offset: 0xC
		public CharacterAssetsBundle CharacterAssets; //Field offset: 0x10
		public CharacterIdlesBundle CharacterIdles; //Field offset: 0x14
		public CharacterCustomizationBundle[] CharacterCustomizationAssets; //Field offset: 0x18
		public Texture2D[] CharacterTextures; //Field offset: 0x1C
		public Texture2D[] CharacterTexturesHighres; //Field offset: 0x20

		public BuildListEntry() { }

		public string[] GetDefaultAssetBundleNames() { }

		public string[] GetOutfitAssetBundleNames(int outfit) { }

		private void TryAdd(Object[] objs, List<string> list) { }

		private void TryAdd(string bundleName, List<string> list) { }

	}

	public BuildListEntry[] CharacterEntries; //Field offset: 0xC
	private string characterAssetsPath; //Field offset: 0x10
	private string characterCustomizationAssetsPath; //Field offset: 0x14
	private int characterCustomizationsCount; //Field offset: 0x18
	private string characterIdlesPath; //Field offset: 0x1C
	private string characterIdlesPostfix; //Field offset: 0x20
	private string characterTexturesPath; //Field offset: 0x24
	private List<string> characterTexturePostfixs; //Field offset: 0x28
	private string characterTextureLowPostfix; //Field offset: 0x2C

	public AssetBundleBuildLists() { }

}

