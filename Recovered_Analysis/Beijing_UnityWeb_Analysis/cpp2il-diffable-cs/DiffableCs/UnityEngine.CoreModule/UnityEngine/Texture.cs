namespace UnityEngine;

public class Texture : Object
{
	public static readonly int GenerateAllMips; //Field offset: 0x0

	public int anisoLevel
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public virtual TextureDimension dimension
	{
		 get { } //Length: 9
		 set { } //Length: 71
	}

	public FilterMode filterMode
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public virtual int height
	{
		 get { } //Length: 9
		 set { } //Length: 71
	}

	public virtual bool isReadable
	{
		 get { } //Length: 9
	}

	public float mipMapBias
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public Vector2 texelSize
	{
		 get { } //Length: 53
	}

	public virtual int width
	{
		 get { } //Length: 49
		 set { } //Length: 45
	}

	public TextureWrapMode wrapMode
	{
		 get { } //Length: 49
		 set { } //Length: 71
	}

	private static Texture() { }

	protected Texture() { }

	internal UnityException CreateNonReadableException(Texture t) { }

	public int get_anisoLevel() { }

	public virtual TextureDimension get_dimension() { }

	public FilterMode get_filterMode() { }

	public virtual int get_height() { }

	public virtual bool get_isReadable() { }

	public float get_mipMapBias() { }

	public Vector2 get_texelSize() { }

	private void get_texelSize_Injected(out Vector2 ret) { }

	public virtual int get_width() { }

	public TextureWrapMode get_wrapMode() { }

	private int GetDataHeight() { }

	private int GetDataWidth() { }

	private TextureDimension GetDimension() { }

	public void set_anisoLevel(int value) { }

	public virtual void set_dimension(TextureDimension value) { }

	public void set_filterMode(FilterMode value) { }

	public virtual void set_height(int value) { }

	public void set_mipMapBias(float value) { }

	public virtual void set_width(int value) { }

	public void set_wrapMode(TextureWrapMode value) { }

	internal bool ValidateFormat(TextureFormat format) { }

	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

}

