//Type is in global namespace

public static class NGUIText
{
	public enum Alignment
	{
		Automatic = 0,
		Left = 1,
		Center = 2,
		Right = 3,
		Justified = 4,
	}

	public class GlyphInfo
	{
		public Vector2 v0; //Field offset: 0x8
		public Vector2 v1; //Field offset: 0x10
		public Vector2 u0; //Field offset: 0x18
		public Vector2 u1; //Field offset: 0x20
		public Vector2 u2; //Field offset: 0x28
		public Vector2 u3; //Field offset: 0x30
		public float advance; //Field offset: 0x38
		public int channel; //Field offset: 0x3C

		public GlyphInfo() { }

	}

	public enum SymbolStyle
	{
		None = 0,
		Normal = 1,
		Colored = 2,
		NoOutline = 3,
	}

	public static UIFont bitmapFont; //Field offset: 0x0
	private const float sizeShrinkage = 0.75; //Field offset: 0x0
	public static Font dynamicFont; //Field offset: 0x4
	public static GlyphInfo glyph; //Field offset: 0x8
	public static int fontSize; //Field offset: 0xC
	public static float fontScale; //Field offset: 0x10
	public static float pixelDensity; //Field offset: 0x14
	public static FontStyle fontStyle; //Field offset: 0x18
	public static Alignment alignment; //Field offset: 0x1C
	public static Color tint; //Field offset: 0x20
	public static int rectWidth; //Field offset: 0x30
	public static int rectHeight; //Field offset: 0x34
	public static int regionWidth; //Field offset: 0x38
	public static int regionHeight; //Field offset: 0x3C
	public static int maxLines; //Field offset: 0x40
	public static bool gradient; //Field offset: 0x44
	public static Color gradientBottom; //Field offset: 0x48
	public static Color gradientTop; //Field offset: 0x58
	public static bool encoding; //Field offset: 0x68
	public static float spacingX; //Field offset: 0x6C
	public static float spacingY; //Field offset: 0x70
	public static bool premultiply; //Field offset: 0x74
	public static SymbolStyle symbolStyle; //Field offset: 0x78
	public static int finalSize; //Field offset: 0x7C
	public static float finalSpacingX; //Field offset: 0x80
	public static float finalLineHeight; //Field offset: 0x84
	public static float baseline; //Field offset: 0x88
	public static bool useSymbols; //Field offset: 0x8C
	private static Color mInvisible; //Field offset: 0x90
	private static BetterList<Color> mColors; //Field offset: 0xA0
	private static float mAlpha; //Field offset: 0xA4
	private static CharacterInfo mTempChar; //Field offset: 0xA8
	private static BetterList<float> mSizes; //Field offset: 0xDC
	private static Color s_c0; //Field offset: 0xE0
	private static Color s_c1; //Field offset: 0xF0
	private static float[] mBoldOffset; //Field offset: 0x100

	private static NGUIText() { }

	public static void Align(List<Vector3> verts, int indexOffset, float printedWidth, int elements = 4) { }

	public static int CalculateOffsetToFit(string text) { }

	public static Vector2 CalculatePrintedSize(string text) { }

	public static string EncodeAlpha(float a) { }

	public static string EncodeColor(Color c) { }

	public static string EncodeColor(string text, Color c) { }

	public static string EncodeColor24(Color c) { }

	public static string EncodeColor32(Color c) { }

	public static void EndLine(ref StringBuilder s) { }

	public static int GetApproximateCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos) { }

	public static string GetEndOfLineThatFits(string text) { }

	public static int GetExactCharacterIndex(List<Vector3> verts, List<int> indices, Vector2 pos) { }

	public static GlyphInfo GetGlyph(int ch, int prev, float fontScale = 1) { }

	public static float GetGlyphWidth(int ch, int prev, float fontScale) { }

	public static BMSymbol GetSymbol(string text, int index, int textLength) { }

	public static bool InsertHyperlink(ref string text, ref int index, string keyword, string link, string prefix = null, string suffix = null) { }

	public static bool IsHex(char ch) { }

	public static bool IsSpace(int ch) { }

	public static float ParseAlpha(string text, int index) { }

	public static Color ParseColor(string text, int offset = 0) { }

	public static Color ParseColor24(string text, int offset = 0) { }

	public static Color ParseColor32(string text, int offset) { }

	public static bool ParseSymbol(string text, ref int index) { }

	public static bool ParseSymbol(string text, ref int index, BetterList<Color> colors, bool premultiply, ref int sub, ref bool bold, ref bool italic, ref bool underline, ref bool strike, ref bool ignoreColor) { }

	public static void Prepare(string text) { }

	public static void Print(string text, List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	public static void PrintApproximateCharacterPositions(string text, List<Vector3> verts, List<int> indices) { }

	public static void PrintCaretAndSelection(string text, int start, int end, List<Vector3> caret, List<Vector3> highlight) { }

	public static void PrintExactCharacterPositions(string text, List<Vector3> verts, List<int> indices) { }

	public static bool ReplaceLink(ref string text, ref int index, string type, string prefix = null, string suffix = null) { }

	public static void ReplaceLinks(ref string text, string prefix = null, string suffix = null) { }

	private static void ReplaceSpaceWithNewline(ref StringBuilder s) { }

	public static string StripSymbols(string text) { }

	public static void Update(bool request) { }

	public static void Update() { }

	public static bool WrapText(string text, out string finalText, bool wrapLineColors = false) { }

	public static bool WrapText(string text, out string finalText, bool keepCharCount, bool wrapLineColors, bool useEllipsis = false) { }

}

