//Type is in global namespace

public abstract class UIBasicSprite : UIWidget
{
	public enum AdvancedType
	{
		Invisible = 0,
		Sliced = 1,
		Tiled = 2,
	}

	public enum FillDirection
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4,
	}

	public enum Flip
	{
		Nothing = 0,
		Horizontally = 1,
		Vertically = 2,
		Both = 3,
	}

	public enum Type
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
		Advanced = 4,
		SlicedFilled = 5,
	}

	protected static Vector2[] mTempPos; //Field offset: 0x0
	protected static Vector2[] mTempUVs; //Field offset: 0x4
	protected Type mType; //Field offset: 0x120
	protected FillDirection mFillDirection; //Field offset: 0x124
	protected float mFillAmount; //Field offset: 0x128
	protected bool mInvert; //Field offset: 0x12C
	protected Flip mFlip; //Field offset: 0x130
	protected bool mApplyGradient; //Field offset: 0x134
	protected Color mGradientTop; //Field offset: 0x138
	protected Color mGradientBottom; //Field offset: 0x148
	private Rect mInnerUV; //Field offset: 0x158
	private Rect mOuterUV; //Field offset: 0x168
	public AdvancedType centerType; //Field offset: 0x178
	public AdvancedType leftType; //Field offset: 0x17C
	public AdvancedType rightType; //Field offset: 0x180
	public AdvancedType bottomType; //Field offset: 0x184
	public AdvancedType topType; //Field offset: 0x188

	protected Color drawingColor
	{
		 get { } //Length: 313
	}

	private Vector4 drawingUVs
	{
		 get { } //Length: 55
	}

	public float fillAmount
	{
		 get { } //Length: 235
		 set { } //Length: 11
	}

	public FillDirection fillDirection
	{
		 get { } //Length: 7
		 set { } //Length: 29
	}

	public Flip flip
	{
		 get { } //Length: 7
		 set { } //Length: 29
	}

	public bool hasBorder
	{
		 get { } //Length: 10
	}

	public bool invert
	{
		 get { } //Length: 396
		 set { } //Length: 28
	}

	public override int minHeight
	{
		 get { } //Length: 396
	}

	public override int minWidth
	{
		 get { } //Length: 7
	}

	protected virtual Vector4 padding
	{
		 get { } //Length: 34
	}

	public virtual float pixelSize
	{
		 get { } //Length: 7
	}

	public virtual bool premultipliedAlpha
	{
		 get { } //Length: 212
	}

	public virtual Type type
	{
		 get { } //Length: 128
		 set { } //Length: 31
	}

	private static UIBasicSprite() { }

	protected UIBasicSprite() { }

	private void AddVertexColours(List<Color> cols, ref Color color, int x, int y) { }

	private void AdvancedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	private static void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col) { }

	protected void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, Rect outer, Rect inner) { }

	private void FilledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	private void FilledSlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	protected Color get_drawingColor() { }

	private Vector4 get_drawingUVs() { }

	public float get_fillAmount() { }

	public FillDirection get_fillDirection() { }

	public Flip get_flip() { }

	public bool get_hasBorder() { }

	public bool get_invert() { }

	public override int get_minHeight() { }

	public override int get_minWidth() { }

	protected virtual Vector4 get_padding() { }

	public virtual float get_pixelSize() { }

	public virtual bool get_premultipliedAlpha() { }

	public virtual Type get_type() { }

	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner) { }

	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner) { }

	public void set_fillAmount(float value) { }

	public void set_fillDirection(FillDirection value) { }

	public void set_flip(Flip value) { }

	public void set_invert(bool value) { }

	public virtual void set_type(Type value) { }

	private void SimpleFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	private void SlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	private void TiledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

}

