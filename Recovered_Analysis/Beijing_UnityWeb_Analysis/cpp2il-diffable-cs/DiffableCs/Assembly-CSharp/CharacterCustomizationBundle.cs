//Type is in global namespace

public class CharacterCustomizationBundle : MonoBehaviour
{
	public class AnimationEnumString
	{
		public const string ValueFieldName = "Value"; //Field offset: 0x0
		public string Value; //Field offset: 0x8

		public AnimationEnumString() { }

	}

	public struct CharacterMaterialInfo
	{
		public string TextureName; //Field offset: 0x0
		public CharacterMaterialShaderType ShaderType; //Field offset: 0x4

		public CharacterMaterialInfo(string textureName, CharacterMaterialShaderType shaderType) { }

	}

	public class OutfitInfo
	{
		public CharacterMaterialInfo MainMaterialInfo; //Field offset: 0x8
		public CharacterMaterialInfo[] ExtraMaterialInfo; //Field offset: 0x10
		public Mesh MainMesh; //Field offset: 0x14
		public Mesh ExtraMesh; //Field offset: 0x18
		public GameObject SpecialAsset; //Field offset: 0x1C
		public string SpecialAssetsName; //Field offset: 0x20
		public List<string> ExcludedAnimationsNames; //Field offset: 0x24
		public AnimationEnumString HighscoreAnimationName; //Field offset: 0x28

		public OutfitInfo() { }

	}

	private OutfitInfo _outfit; //Field offset: 0xC

	public OutfitInfo Outfit
	{
		 get { } //Length: 6
	}

	public CharacterCustomizationBundle() { }

	public OutfitInfo get_Outfit() { }

}

