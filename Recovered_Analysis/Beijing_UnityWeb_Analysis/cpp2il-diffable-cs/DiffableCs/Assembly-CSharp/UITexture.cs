//Type is in global namespace

public class UITexture : UIBasicSprite
{
	private Rect mRect; //Field offset: 0x18C
	private Texture mTexture; //Field offset: 0x19C
	private Shader mShader; //Field offset: 0x1A0
	private Vector4 mBorder; //Field offset: 0x1A4
	private bool mFixedAspect; //Field offset: 0x1B4
	private float mPixelSize; //Field offset: 0x1B8
	private int mPMA; //Field offset: 0x1BC

	public bool applyGradient
	{
		 get { } //Length: 10
		 set { } //Length: 157
	}

	public override Vector4 border
	{
		 get { } //Length: 288
		 set { } //Length: 27
	}

	public override Vector4 drawingDimensions
	{
		 get { } //Length: 159
	}

	public bool fixedAspect
	{
		 get { } //Length: 213
		 set { } //Length: 844
	}

	public Color gradientBottom
	{
		 get { } //Length: 168
		 set { } //Length: 27
	}

	public Color gradientTop
	{
		 get { } //Length: 35
		 set { } //Length: 27
	}

	public override Texture mainTexture
	{
		 get { } //Length: 136
		 set { } //Length: 13
	}

	public override Material material
	{
		 get { } //Length: 161
		 set { } //Length: 277
	}

	public override float pixelSize
	{
		 get { } //Length: 132
	}

	public override bool premultipliedAlpha
	{
		 get { } //Length: 181
	}

	public override Shader shader
	{
		 get { } //Length: 6
		 set { } //Length: 133
	}

	public Rect uvRect
	{
		 get { } //Length: 256
		 set { } //Length: 27
	}

	public UITexture() { }

	public bool get_applyGradient() { }

	public override Vector4 get_border() { }

	public override Vector4 get_drawingDimensions() { }

	public bool get_fixedAspect() { }

	public Color get_gradientBottom() { }

	public Color get_gradientTop() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public override float get_pixelSize() { }

	public override bool get_premultipliedAlpha() { }

	public override Shader get_shader() { }

	public Rect get_uvRect() { }

	public override void MakePixelPerfect() { }

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	protected override void OnUpdate() { }

	public void set_applyGradient(bool value) { }

	public override void set_border(Vector4 value) { }

	public void set_fixedAspect(bool value) { }

	public void set_gradientBottom(Color value) { }

	public void set_gradientTop(Color value) { }

	public override void set_mainTexture(Texture value) { }

	public override void set_material(Material value) { }

	public override void set_shader(Shader value) { }

	public void set_uvRect(Rect value) { }

	public void SetPixelSize(float f) { }

}

