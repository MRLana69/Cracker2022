namespace UnityEngine.Experimental.Rendering;

public class GraphicsFormatUtility
{

	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	internal static bool IsCompressedTextureFormat(TextureFormat format) { }

	public static bool IsCrunchFormat(TextureFormat format) { }

	public static bool IsSRGBFormat(GraphicsFormat format) { }

}

