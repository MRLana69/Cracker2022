namespace UnityEngine;

public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 47
		 set { } //Length: 51
	}

	public int antiAliasing
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public bool autoGenerateMips
	{
		 get { } //Length: 15
		 set { } //Length: 53
	}

	public int depth
	{
		 get { } //Length: 49
		 set { } //Length: 128
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 53
		 set { } //Length: 128
	}

	public override TextureDimension dimension
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public RenderTextureFormat format
	{
		 get { } //Length: 49
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public override int height
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public bool isPowerOfTwo
	{
		 set { } //Length: 53
	}

	public int volumeDepth
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public override int width
	{
		 get { } //Length: 49
		 set { } //Length: 370
	}

	protected internal RenderTexture() { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	public RenderTexture(int width, int height, int depth) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public static RenderTexture get_active() { }

	public int get_antiAliasing() { }

	public bool get_autoGenerateMips() { }

	public int get_depth() { }

	public RenderTextureDescriptor get_descriptor() { }

	public override TextureDimension get_dimension() { }

	public RenderTextureFormat get_format() { }

	public GraphicsFormat get_graphicsFormat() { }

	public override int get_height() { }

	public int get_volumeDepth() { }

	public override int get_width() { }

	private static RenderTexture GetActive() { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	private RenderTextureDescriptor GetDescriptor() { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	private static void Internal_Create(RenderTexture rt) { }

	public static void set_active(RenderTexture value) { }

	public void set_antiAliasing(int value) { }

	public void set_autoGenerateMips(bool value) { }

	public void set_depth(int value) { }

	public void set_descriptor(RenderTextureDescriptor value) { }

	public override void set_dimension(TextureDimension value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public override void set_height(int value) { }

	public void set_isPowerOfTwo(bool value) { }

	public void set_volumeDepth(int value) { }

	public override void set_width(int value) { }

	private static void SetActive(RenderTexture rt) { }

	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

}

