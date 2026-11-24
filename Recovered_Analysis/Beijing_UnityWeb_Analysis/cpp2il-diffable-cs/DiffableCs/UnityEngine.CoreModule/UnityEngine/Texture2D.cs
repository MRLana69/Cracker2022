namespace UnityEngine;

public sealed class Texture2D : Texture
{

	public TextureFormat format
	{
		 get { } //Length: 49
	}

	public override bool isReadable
	{
		 get { } //Length: 49
	}

	public static Texture2D whiteTexture
	{
		 get { } //Length: 47
	}

	internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex) { }

	public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	public Texture2D(int width, int height) { }

	public void Apply() { }

	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	public TextureFormat get_format() { }

	public override bool get_isReadable() { }

	public static Texture2D get_whiteTexture() { }

	public Color GetPixelBilinear(float u, float v) { }

	private Color GetPixelBilinearImpl(int image, float u, float v) { }

	private void GetPixelBilinearImpl_Injected(int image, float u, float v, out Color ret) { }

	public byte[] GetRawTextureData() { }

	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, nint nativeTex) { }

	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureCreationFlags flags, nint nativeTex) { }

	public void ReadPixels(Rect source, int destX, int destY) { }

	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	public void SetPixel(int x, int y, Color color) { }

	private void SetPixelImpl(int image, int x, int y, Color color) { }

	private void SetPixelImpl_Injected(int image, int x, int y, ref Color color) { }

	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	public void SetPixels(Color[] colors) { }

	public void SetPixels32(Color32[] colors, int miplevel) { }

	public void SetPixels32(Color32[] colors) { }

	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

}

