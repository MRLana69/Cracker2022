namespace UnityEngine.UI;

public class Text : MaskableGraphic, ILayoutElement
{
	protected static Material s_DefaultText; //Field offset: 0x0
	private FontData m_FontData; //Field offset: 0x6C
	protected string m_Text; //Field offset: 0x70
	private TextGenerator m_TextCache; //Field offset: 0x74
	private TextGenerator m_TextCacheForLayout; //Field offset: 0x78
	protected bool m_DisableFontTextureRebuiltCallback; //Field offset: 0x7C
	private readonly UIVertex[] m_TempVerts; //Field offset: 0x80

	public bool alignByGeometry
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	public TextAnchor alignment
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	public TextGenerator cachedTextGenerator
	{
		 get { } //Length: 9
	}

	public TextGenerator cachedTextGeneratorForLayout
	{
		 get { } //Length: 123
	}

	public virtual float flexibleHeight
	{
		 get { } //Length: 391
	}

	public virtual float flexibleWidth
	{
		 get { } //Length: 354
	}

	public Font font
	{
		 get { } //Length: 322
		 set { } //Length: 11
	}

	public int fontSize
	{
		 get { } //Length: 12
		 set { } //Length: 39
	}

	public FontStyle fontStyle
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	public HorizontalWrapMode horizontalOverflow
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	public virtual int layoutPriority
	{
		 get { } //Length: 9
	}

	public float lineSpacing
	{
		 get { } //Length: 35
		 set { } //Length: 107
	}

	public override Texture mainTexture
	{
		 get { } //Length: 79
	}

	public virtual float minHeight
	{
		 get { } //Length: 6
	}

	public virtual float minWidth
	{
		 get { } //Length: 251
	}

	public float pixelsPerUnit
	{
		 get { } //Length: 9
	}

	public virtual float preferredHeight
	{
		 get { } //Length: 6
	}

	public virtual float preferredWidth
	{
		 get { } //Length: 6
	}

	public bool resizeTextForBestFit
	{
		 get { } //Length: 12
		 set { } //Length: 47
	}

	public int resizeTextMaxSize
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	public int resizeTextMinSize
	{
		 get { } //Length: 12
		 set { } //Length: 47
	}

	public bool supportRichText
	{
		 get { } //Length: 6
		 set { } //Length: 143
	}

	public virtual string text
	{
		 get { } //Length: 9
		 set { } //Length: 164
	}

	public VerticalWrapMode verticalOverflow
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	private static Text() { }

	protected Text() { }

	internal void AssignDefaultFont() { }

	public virtual void CalculateLayoutInputHorizontal() { }

	public virtual void CalculateLayoutInputVertical() { }

	public void FontTextureChanged() { }

	public bool get_alignByGeometry() { }

	public TextAnchor get_alignment() { }

	public TextGenerator get_cachedTextGenerator() { }

	public TextGenerator get_cachedTextGeneratorForLayout() { }

	public virtual float get_flexibleHeight() { }

	public virtual float get_flexibleWidth() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public virtual int get_layoutPriority() { }

	public float get_lineSpacing() { }

	public override Texture get_mainTexture() { }

	public virtual float get_minHeight() { }

	public virtual float get_minWidth() { }

	public float get_pixelsPerUnit() { }

	public virtual float get_preferredHeight() { }

	public virtual float get_preferredWidth() { }

	public bool get_resizeTextForBestFit() { }

	public int get_resizeTextMaxSize() { }

	public int get_resizeTextMinSize() { }

	public bool get_supportRichText() { }

	public virtual string get_text() { }

	public VerticalWrapMode get_verticalOverflow() { }

	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	protected override void OnPopulateMesh(VertexHelper toFill) { }

	public void set_alignByGeometry(bool value) { }

	public void set_alignment(TextAnchor value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public void set_lineSpacing(float value) { }

	public void set_resizeTextForBestFit(bool value) { }

	public void set_resizeTextMaxSize(int value) { }

	public void set_resizeTextMinSize(int value) { }

	public void set_supportRichText(bool value) { }

	public virtual void set_text(string value) { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	protected override void UpdateGeometry() { }

}

