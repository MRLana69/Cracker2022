namespace UnityEngine;

public struct RenderTextureDescriptor
{
	private static int[] depthFormatBits; //Field offset: 0x0
	private int <width>k__BackingField; //Field offset: 0x0
	private int <height>k__BackingField; //Field offset: 0x4
	private int <msaaSamples>k__BackingField; //Field offset: 0x8
	private int <volumeDepth>k__BackingField; //Field offset: 0xC
	private int <mipCount>k__BackingField; //Field offset: 0x10
	private GraphicsFormat _graphicsFormat; //Field offset: 0x14
	private int _depthBufferBits; //Field offset: 0x18
	private TextureDimension <dimension>k__BackingField; //Field offset: 0x1C
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; //Field offset: 0x20
	private VRTextureUsage <vrUsage>k__BackingField; //Field offset: 0x24
	private RenderTextureCreationFlags _flags; //Field offset: 0x28
	private RenderTextureMemoryless <memoryless>k__BackingField; //Field offset: 0x2C

	public int depthBufferBits
	{
		 get { } //Length: 9
		 set { } //Length: 14
	}

	public TextureDimension dimension
	{
		 set { } //Length: 47
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public int height
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public RenderTextureMemoryless memoryless
	{
		 set { } //Length: 11
	}

	public int mipCount
	{
		 set { } //Length: 11
	}

	public int msaaSamples
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public ShadowSamplingMode shadowSamplingMode
	{
		 set { } //Length: 11
	}

	public int volumeDepth
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public VRTextureUsage vrUsage
	{
		 set { } //Length: 11
	}

	public int width
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	private static RenderTextureDescriptor() { }

	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	public int get_depthBufferBits() { }

	public GraphicsFormat get_graphicsFormat() { }

	public int get_height() { }

	public int get_msaaSamples() { }

	public int get_volumeDepth() { }

	public int get_width() { }

	public void set_depthBufferBits(int value) { }

	public void set_dimension(TextureDimension value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public void set_height(int value) { }

	public void set_memoryless(RenderTextureMemoryless value) { }

	public void set_mipCount(int value) { }

	public void set_msaaSamples(int value) { }

	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	public void set_volumeDepth(int value) { }

	public void set_vrUsage(VRTextureUsage value) { }

	public void set_width(int value) { }

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

}

