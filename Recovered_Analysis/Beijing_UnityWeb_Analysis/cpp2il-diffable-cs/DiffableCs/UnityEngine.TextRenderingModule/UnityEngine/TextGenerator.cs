namespace UnityEngine;

public sealed class TextGenerator : IDisposable
{
	internal nint m_Ptr; //Field offset: 0x8
	private string m_LastString; //Field offset: 0xC
	private TextGenerationSettings m_LastSettings; //Field offset: 0x10
	private bool m_HasGenerated; //Field offset: 0x68
	private TextGenerationError m_LastValid; //Field offset: 0x6C
	private readonly List<UIVertex> m_Verts; //Field offset: 0x70
	private readonly List<UICharInfo> m_Characters; //Field offset: 0x74
	private readonly List<UILineInfo> m_Lines; //Field offset: 0x78
	private bool m_CachedVerts; //Field offset: 0x7C
	private bool m_CachedCharacters; //Field offset: 0x7D
	private bool m_CachedLines; //Field offset: 0x7E

	public int characterCount
	{
		 get { } //Length: 35
	}

	public int characterCountVisible
	{
		 get { } //Length: 6
	}

	public IList<UICharInfo> characters
	{
		 get { } //Length: 35
	}

	public int lineCount
	{
		 get { } //Length: 49
	}

	public IList<UILineInfo> lines
	{
		 get { } //Length: 35
	}

	public Rect rectExtents
	{
		 get { } //Length: 11
	}

	public IList<UIVertex> verts
	{
		 get { } //Length: 12
	}

	public TextGenerator() { }

	public TextGenerator(int initialCapacity) { }

	protected override void Finalize() { }

	public int get_characterCount() { }

	public int get_characterCountVisible() { }

	public IList<UICharInfo> get_characters() { }

	public int get_lineCount() { }

	public IList<UILineInfo> get_lines() { }

	public Rect get_rectExtents() { }

	private void get_rectExtents_Injected(out Rect ret) { }

	public IList<UIVertex> get_verts() { }

	public void GetCharacters(List<UICharInfo> characters) { }

	private void GetCharactersInternal(object characters) { }

	public void GetLines(List<UILineInfo> lines) { }

	private void GetLinesInternal(object lines) { }

	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	public void GetVertices(List<UIVertex> vertices) { }

	private void GetVerticesInternal(object vertices) { }

	private static nint Internal_Create() { }

	private static void Internal_Destroy(nint ptr) { }

	public void Invalidate() { }

	public bool Populate(string str, TextGenerationSettings settings) { }

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	private void System.IDisposable.Dispose() { }

	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

}

