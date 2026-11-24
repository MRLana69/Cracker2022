//Type is in global namespace

public class CharacterCustomization : MonoBehaviour
{
	private sealed class <>c__DisplayClass12_0
	{
		public CharacterCustomization <>4__this; //Field offset: 0x8
		public bool forceLOD0; //Field offset: 0xC
		public bool asynchronous; //Field offset: 0xD
		public SkinnedMeshRenderer model; //Field offset: 0x10
		public SkinnedMeshRenderer headMesh; //Field offset: 0x14
		public CharacterRig characterRig; //Field offset: 0x18
		public bool useSpecialAsset; //Field offset: 0x1C
		public bool deleteSpecialAsset; //Field offset: 0x1D
		public Action onSuccess; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <Customize>b__0(CharacterCustomizationBundle bundledAsset) { }

	}

	private sealed class <>c__DisplayClass12_1
	{
		public OutfitInfo outfitInfo; //Field offset: 0x8
		public <>c__DisplayClass12_0 CS$<>8__locals1; //Field offset: 0xC
		public Action<Material> <>9__2; //Field offset: 0x10

		public <>c__DisplayClass12_1() { }

		internal void <Customize>b__1(Material material) { }

		internal void <Customize>b__2(Material customMaterial) { }

	}

	private sealed class <>c__DisplayClass12_2
	{
		public Material customMaterial; //Field offset: 0x8
		public <>c__DisplayClass12_1 CS$<>8__locals2; //Field offset: 0xC

		public <>c__DisplayClass12_2() { }

		internal void <Customize>b__3(Material customExtraMaterial) { }

	}

	private Texture2D gradient; //Field offset: 0xC
	private SkinnedMeshRenderer outfitRenderer; //Field offset: 0x10
	private List<GameObject> specialAssets; //Field offset: 0x14
	private List<Material> customMaterials; //Field offset: 0x18
	private List<Material> headMaterials; //Field offset: 0x1C
	private List<Material> cachedMaterials; //Field offset: 0x20
	private CharacterCustomizationBundle _characterCustomizationBundle; //Field offset: 0x24

	public OutfitInfo OutfitInfo
	{
		 get { } //Length: 6
	}

	public SkinnedMeshRenderer OutfitRenderer
	{
		 get { } //Length: 6
	}

	public CharacterCustomization() { }

	private void BuildProp(OutfitInfo outfitInfo, CharacterRig characterRig, bool useSpecialAsset, bool deleteSpecialAsset) { }

	public void Customize(string name, int customizedVersion, SkinnedMeshRenderer model, SkinnedMeshRenderer outfitMesh, SkinnedMeshRenderer headMesh, CharacterRig characterRig, bool useSpecialAsset, bool deleteSpecialAsset, bool forceLOD0, bool asynchronous, Action onSuccess) { }

	private void DeleteSpecialAssets() { }

	private void DestroyMaterials() { }

	public OutfitInfo get_OutfitInfo() { }

	public SkinnedMeshRenderer get_OutfitRenderer() { }

	private void OnDestroy() { }

}

