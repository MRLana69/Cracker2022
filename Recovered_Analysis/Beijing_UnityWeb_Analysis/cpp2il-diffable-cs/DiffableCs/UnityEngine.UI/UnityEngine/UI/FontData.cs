namespace UnityEngine.UI;

public class FontData : ISerializationCallbackReceiver
{
	private Font m_Font; //Field offset: 0x8
	private int m_FontSize; //Field offset: 0xC
	private FontStyle m_FontStyle; //Field offset: 0x10
	private bool m_BestFit; //Field offset: 0x14
	private int m_MinSize; //Field offset: 0x18
	private int m_MaxSize; //Field offset: 0x1C
	private TextAnchor m_Alignment; //Field offset: 0x20
	private bool m_AlignByGeometry; //Field offset: 0x24
	private bool m_RichText; //Field offset: 0x25
	private HorizontalWrapMode m_HorizontalOverflow; //Field offset: 0x28
	private VerticalWrapMode m_VerticalOverflow; //Field offset: 0x2C
	private float m_LineSpacing; //Field offset: 0x30

	public bool alignByGeometry
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public TextAnchor alignment
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public bool bestFit
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public static FontData defaultFontData
	{
		 get { } //Length: 89
	}

	public Font font
	{
		 get { } //Length: 7
		 set { } //Length: 198
	}

	public int fontSize
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public FontStyle fontStyle
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public HorizontalWrapMode horizontalOverflow
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float lineSpacing
	{
		 get { } //Length: 7
		 set { } //Length: 112
	}

	public int maxSize
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public int minSize
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool richText
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public VerticalWrapMode verticalOverflow
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public FontData() { }

	public bool get_alignByGeometry() { }

	public TextAnchor get_alignment() { }

	public bool get_bestFit() { }

	public static FontData get_defaultFontData() { }

	public Font get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public HorizontalWrapMode get_horizontalOverflow() { }

	public float get_lineSpacing() { }

	public int get_maxSize() { }

	public int get_minSize() { }

	public bool get_richText() { }

	public VerticalWrapMode get_verticalOverflow() { }

	public void set_alignByGeometry(bool value) { }

	public void set_alignment(TextAnchor value) { }

	public void set_bestFit(bool value) { }

	public void set_font(Font value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	public void set_lineSpacing(float value) { }

	public void set_maxSize(int value) { }

	public void set_minSize(int value) { }

	public void set_richText(bool value) { }

	public void set_verticalOverflow(VerticalWrapMode value) { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

