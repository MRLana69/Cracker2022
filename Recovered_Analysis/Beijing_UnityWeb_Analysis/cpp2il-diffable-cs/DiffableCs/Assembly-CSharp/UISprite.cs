//Type is in global namespace

public class UISprite : UIBasicSprite
{
	private UIAtlas mAtlas; //Field offset: 0x18C
	private string mSpriteName; //Field offset: 0x190
	private bool mFillCenter; //Field offset: 0x194
	protected UISpriteData mSprite; //Field offset: 0x198
	private bool mSpriteSet; //Field offset: 0x19C

	public bool applyGradient
	{
		 get { } //Length: 10
		 set { } //Length: 35
	}

	public UIAtlas atlas
	{
		 get { } //Length: 164
		 set { } //Length: 11
	}

	public override Vector4 border
	{
		 get { } //Length: 168
	}

	public override Vector4 drawingDimensions
	{
		 get { } //Length: 149
	}

	public bool fillCenter
	{
		 get { } //Length: 12
		 set { } //Length: 172
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

	public bool isValid
	{
		 get { } //Length: 7
	}

	public override Texture mainTexture
	{
		 get { } //Length: 796
		 set { } //Length: 315
	}

	public override Material material
	{
		 get { } //Length: 165
		 set { } //Length: 11
	}

	public override int minHeight
	{
		 get { } //Length: 503
	}

	public override int minWidth
	{
		 get { } //Length: 10
	}

	protected override Vector4 padding
	{
		 get { } //Length: 99
	}

	public override float pixelSize
	{
		 get { } //Length: 150
	}

	public override bool premultipliedAlpha
	{
		 get { } //Length: 503
	}

	public string spriteName
	{
		 get { } //Length: 7
		 set { } //Length: 351
	}

	public UISprite() { }

	private void CreateUITexture() { }

	public bool get_applyGradient() { }

	public UIAtlas get_atlas() { }

	public override Vector4 get_border() { }

	public override Vector4 get_drawingDimensions() { }

	public bool get_fillCenter() { }

	public Color get_gradientBottom() { }

	public Color get_gradientTop() { }

	public bool get_isValid() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public override int get_minHeight() { }

	public override int get_minWidth() { }

	protected override Vector4 get_padding() { }

	public override float get_pixelSize() { }

	public override bool get_premultipliedAlpha() { }

	public string get_spriteName() { }

	public UISpriteData GetAtlasSprite() { }

	public override void MakePixelPerfect() { }

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	protected override void OnInit() { }

	protected override void OnUpdate() { }

	public void set_applyGradient(bool value) { }

	public void set_atlas(UIAtlas value) { }

	public void set_fillCenter(bool value) { }

	public void set_gradientBottom(Color value) { }

	public void set_gradientTop(Color value) { }

	public override void set_mainTexture(Texture value) { }

	public override void set_material(Material value) { }

	public void set_spriteName(string value) { }

	protected void SetAtlasSprite(UISpriteData sp) { }

}

