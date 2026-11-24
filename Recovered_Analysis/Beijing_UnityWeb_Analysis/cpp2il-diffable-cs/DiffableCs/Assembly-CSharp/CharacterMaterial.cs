//Type is in global namespace

public class CharacterMaterial : MonoBehaviour
{
	private sealed class <>c__DisplayClass4_0
	{
		public CharacterMaterialShaderType shaderType; //Field offset: 0x8
		public PerformanceLevel performanceLevel; //Field offset: 0xC

		public <>c__DisplayClass4_0() { }

		internal bool <GetMaterialPath>b__0(CharacterMaterialPathInfo mp) { }

	}

	private sealed class <>c__DisplayClass6_0
	{
		public string textureName; //Field offset: 0x8
		public Material material; //Field offset: 0xC
		public Action<Material> onSucces; //Field offset: 0x10
		public bool asynchronous; //Field offset: 0x14
		public Action<Texture2D> <>9__1; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <SetTexture>b__0(Texture2D tex) { }

		internal void <SetTexture>b__1(Texture2D texLow) { }

	}

	private class CharacterMaterialPathInfo
	{
		public CharacterMaterialShaderType ShaderType; //Field offset: 0x8
		public PerformanceLevel PerformanceLevel; //Field offset: 0xC
		public string MaterialPath; //Field offset: 0x10

		public CharacterMaterialPathInfo(CharacterMaterialShaderType shaderType, PerformanceLevel performanceLevel, string materialPath) { }

	}

	public enum CharacterMaterialShaderType
	{
		Default = 0,
		Additive = 1,
		Shine = 2,
	}

	private static List<CharacterMaterialPathInfo> _materialPaths; //Field offset: 0x0

	private static CharacterMaterial() { }

	public CharacterMaterial() { }

	private static string GetMaterialPath(CharacterMaterialShaderType shaderType, PerformanceLevel performanceLevel) { }

	public static void Request(string textureName, CharacterMaterialShaderType shaderType, bool forcePerformanceLevel, PerformanceLevel forcedLevel, bool asynchronous, Action<Material> onSucces) { }

	private static void RequestMaterial(string textureName, string materialPath, bool asynchronous, Action<Material> onSucces) { }

	private static void SetTexture(Material mat, string textureName, bool asynchronous, Action<Material> onSucces) { }

}

