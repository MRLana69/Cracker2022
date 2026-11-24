namespace UnityEngine;

public sealed class Texture3D : Texture
{

	public override bool isReadable
	{
		 get { } //Length: 49
	}

	public Texture3D(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	public Texture3D(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	public Texture3D(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	public override bool get_isReadable() { }

	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureCreationFlags flags) { }

}

