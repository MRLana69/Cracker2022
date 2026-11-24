namespace UnityEngine;

public class Material : Object
{

	public Color color
	{
		 get { } //Length: 53
		 set { } //Length: 102
	}

	public Texture mainTexture
	{
		 get { } //Length: 49
		 set { } //Length: 92
	}

	public Vector2 mainTextureOffset
	{
		 get { } //Length: 53
		 set { } //Length: 78
	}

	public Vector2 mainTextureScale
	{
		 set { } //Length: 97
	}

	public int renderQueue
	{
		 get { } //Length: 51
		 set { } //Length: 97
	}

	public Shader shader
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public string[] shaderKeywords
	{
		 get { } //Length: 49
	}

	public Material(Shader shader) { }

	public Material(Material source) { }

	public Material(string contents) { }

	public void CopyPropertiesFromMaterial(Material mat) { }

	private static void CreateWithMaterial(Material self, Material source) { }

	private static void CreateWithShader(Material self, Shader shader) { }

	private static void CreateWithString(Material self) { }

	public void DisableKeyword(string keyword) { }

	public void EnableKeyword(string keyword) { }

	public Color get_color() { }

	public Texture get_mainTexture() { }

	public Vector2 get_mainTextureOffset() { }

	public int get_renderQueue() { }

	public Shader get_shader() { }

	public string[] get_shaderKeywords() { }

	public Color GetColor(string name) { }

	private Color GetColorImpl(int name) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	private string[] GetShaderKeywords() { }

	public Texture GetTexture(string name) { }

	private Texture GetTextureImpl(int name) { }

	public Vector2 GetTextureOffset(string name) { }

	public Vector2 GetTextureOffset(int nameID) { }

	private Vector4 GetTextureScaleAndOffsetImpl(int name) { }

	private void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret) { }

	public bool HasProperty(string name) { }

	public bool HasProperty(int nameID) { }

	public void set_color(Color value) { }

	public void set_mainTexture(Texture value) { }

	public void set_mainTextureOffset(Vector2 value) { }

	public void set_mainTextureScale(Vector2 value) { }

	public void set_renderQueue(int value) { }

	public void set_shader(Shader value) { }

	public void SetColor(string name, Color value) { }

	private void SetColorImpl(int name, Color value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	public void SetFloat(string name, float value) { }

	private void SetFloatImpl(int name, float value) { }

	public void SetInt(string name, int value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	public bool SetPass(int pass) { }

	public void SetTexture(string name, Texture value) { }

	private void SetTextureImpl(int name, Texture value) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	public void SetTextureScale(string name, Vector2 value) { }

	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetVector(string name, Vector4 value) { }

}

