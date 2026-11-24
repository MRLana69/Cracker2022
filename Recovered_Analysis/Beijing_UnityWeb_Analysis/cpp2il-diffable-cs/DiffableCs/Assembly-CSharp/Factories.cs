//Type is in global namespace

public class Factories
{
	private class AssetBundleMapping
	{
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Predicate<string> <>9__5_0; //Field offset: 0x4

			private static <>c() { }

			public <>c() { }

			internal bool <GetAssetBundleNamesForOutfit>b__5_0(string s) { }

		}

		public class StringArray
		{
			public string[] Strings; //Field offset: 0x8

			public StringArray() { }

		}

		public string CharacterTypeName; //Field offset: 0x8
		public CharacterId characterId; //Field offset: 0xC
		public string[] DefaultAssetBundleNames; //Field offset: 0x10
		public StringArray[] OutfitAssetBundleNames; //Field offset: 0x14

		public AssetBundleMapping() { }

		public string[] GetAllAssetBundleNames() { }

		public string[] GetAssetBundleNamesForOutfit(int outfit, bool includeIdles) { }

	}

	private AssetBundleMapping[] _assetBundleMappings; //Field offset: 0x10
	private AssetBundleFactory<CharacterCustomizationBundle> <CharacterCustomizationBundle>k__BackingField; //Field offset: 0x14
	private AssetBundleFactory<CharacterIdlesBundle> <CharacterIdlesBundle>k__BackingField; //Field offset: 0x18
	private AssetBundleFactory<CharacterAssetsBundle> <CharacterAssetsBundle>k__BackingField; //Field offset: 0x1C
	private AssetBundleFactory<Material> <MaterialFactory>k__BackingField; //Field offset: 0x20
	private AssetBundleFactory<Texture2D> <TextureFactory>k__BackingField; //Field offset: 0x24
	public Action OnLateUpdate; //Field offset: 0x28

	public AssetBundleFactory<CharacterAssetsBundle> CharacterAssetsBundle
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public AssetBundleFactory<CharacterCustomizationBundle> CharacterCustomizationBundle
	{
		 get { } //Length: 6
		private set { } //Length: 63
	}

	public AssetBundleFactory<CharacterIdlesBundle> CharacterIdlesBundle
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public AssetBundleFactory<Material> MaterialFactory
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public AssetBundleFactory<Texture2D> TextureFactory
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public Factories() { }

	public AssetBundleFactory<CharacterAssetsBundle> get_CharacterAssetsBundle() { }

	public AssetBundleFactory<CharacterCustomizationBundle> get_CharacterCustomizationBundle() { }

	public AssetBundleFactory<CharacterIdlesBundle> get_CharacterIdlesBundle() { }

	public AssetBundleFactory<Material> get_MaterialFactory() { }

	public AssetBundleFactory<Texture2D> get_TextureFactory() { }

	public string[] GetReferencedAssetBundleNames(CharacterId characterId) { }

	public string[] GetReferencedAssetBundleNames(CharacterId characterId, int theme, bool includeIdles) { }

	public bool IsAssetBundleInUse(string assetBundleName) { }

	private void LateUpdate() { }

	private void set_CharacterAssetsBundle(AssetBundleFactory<CharacterAssetsBundle> value) { }

	private void set_CharacterCustomizationBundle(AssetBundleFactory<CharacterCustomizationBundle> value) { }

	private void set_CharacterIdlesBundle(AssetBundleFactory<CharacterIdlesBundle> value) { }

	private void set_MaterialFactory(AssetBundleFactory<Material> value) { }

	private void set_TextureFactory(AssetBundleFactory<Texture2D> value) { }

	protected override void SubclassInitialize() { }

}

