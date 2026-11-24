//Type is in global namespace

public class UI2DSprite : UIBasicSprite
{
	private Sprite mSprite; //Field offset: 0x18C
	private Shader mShader; //Field offset: 0x190
	private Vector4 mBorder; //Field offset: 0x194
	private bool mFixedAspect; //Field offset: 0x1A4
	private float mPixelSize; //Field offset: 0x1A8
	public Sprite nextSprite; //Field offset: 0x1AC
	private int mPMA; //Field offset: 0x1B0

	public override Vector4 border
	{
		 get { } //Length: 1383
		 set { } //Length: 27
	}

	public override Vector4 drawingDimensions
	{
		 get { } //Length: 157
	}

	public bool fixedAspect
	{
		 get { } //Length: 167
		 set { } //Length: 175
	}

	public override Texture mainTexture
	{
		 get { } //Length: 181
	}

	public override Material material
	{
		 get { } //Length: 7
		 set { } //Length: 127
	}

	public override float pixelSize
	{
		 get { } //Length: 6
	}

	public override bool premultipliedAlpha
	{
		 get { } //Length: 10
	}

	public override Shader shader
	{
		 get { } //Length: 6
		 set { } //Length: 122
	}

	public Sprite sprite2D
	{
		 get { } //Length: 23
		 set { } //Length: 146
	}

	public UI2DSprite() { }

	public override Vector4 get_border() { }

	public override Vector4 get_drawingDimensions() { }

	public bool get_fixedAspect() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public override float get_pixelSize() { }

	public override bool get_premultipliedAlpha() { }

	public override Shader get_shader() { }

	public Sprite get_sprite2D() { }

	public override void MakePixelPerfect() { }

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	protected override void OnUpdate() { }

	public override void set_border(Vector4 value) { }

	public void set_fixedAspect(bool value) { }

	public override void set_material(Material value) { }

	public override void set_shader(Shader value) { }

	public void set_sprite2D(Sprite value) { }

}

