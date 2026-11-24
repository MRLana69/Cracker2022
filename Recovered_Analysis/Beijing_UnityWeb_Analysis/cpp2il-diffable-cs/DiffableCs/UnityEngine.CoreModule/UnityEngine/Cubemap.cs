namespace UnityEngine;

public sealed class Cubemap : Texture
{

	public override bool isReadable
	{
		 get { } //Length: 49
	}

	public Cubemap(int width, DefaultFormat format, TextureCreationFlags flags) { }

	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	public Cubemap(int width, TextureFormat format, int mipCount) { }

	public Cubemap(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	internal Cubemap(int width, TextureFormat textureFormat, int mipCount, nint nativeTex) { }

	internal Cubemap(int width, TextureFormat textureFormat, bool mipChain, nint nativeTex) { }

	public Cubemap(int width, TextureFormat textureFormat, bool mipChain) { }

	public override bool get_isReadable() { }

	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, nint nativeTex) { }

	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureCreationFlags flags, nint nativeTex) { }

}

