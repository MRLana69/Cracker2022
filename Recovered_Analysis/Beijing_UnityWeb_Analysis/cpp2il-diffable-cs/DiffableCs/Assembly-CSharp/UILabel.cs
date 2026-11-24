//Type is in global namespace

public class UILabel : UIWidget
{
	public enum Crispness
	{
		Never = 0,
		OnDesktop = 1,
		Always = 2,
	}

	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2,
		Outline8 = 3,
	}

	public enum Modifier
	{
		None = 0,
		ToUppercase = 1,
		ToLowercase = 2,
		Custom = 255,
	}

	public delegate ModifierFunc
	{

		public ModifierFunc(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string s, AsyncCallback callback, object object) { }

		public virtual string EndInvoke(IAsyncResult result) { }

		public virtual string Invoke(string s) { }

	}

	public enum Overflow
	{
		ShrinkContent = 0,
		ClampContent = 1,
		ResizeFreely = 2,
		ResizeHeight = 3,
	}

	private static BetterList<UILabel> mList; //Field offset: 0x0
	private static Dictionary<Font, int> mFontUsage; //Field offset: 0x4
	private static BetterList<UIDrawCall> mTempDrawcalls; //Field offset: 0x8
	private static bool mTexRebuildAdded; //Field offset: 0xC
	private static List<Vector3> mTempVerts; //Field offset: 0x10
	private static List<int> mTempIndices; //Field offset: 0x14
	public Crispness keepCrispWhenShrunk; //Field offset: 0x120
	private Font mTrueTypeFont; //Field offset: 0x124
	private UIFont mFont; //Field offset: 0x128
	private string mText; //Field offset: 0x12C
	private int mFontSize; //Field offset: 0x130
	private FontStyle mFontStyle; //Field offset: 0x134
	private Alignment mAlignment; //Field offset: 0x138
	private bool mEncoding; //Field offset: 0x13C
	private int mMaxLineCount; //Field offset: 0x140
	private Effect mEffectStyle; //Field offset: 0x144
	private Color mEffectColor; //Field offset: 0x148
	private SymbolStyle mSymbols; //Field offset: 0x158
	private Vector2 mEffectDistance; //Field offset: 0x15C
	private Overflow mOverflow; //Field offset: 0x164
	private bool mApplyGradient; //Field offset: 0x168
	private Color mGradientTop; //Field offset: 0x16C
	private Color mGradientBottom; //Field offset: 0x17C
	private int mSpacingX; //Field offset: 0x18C
	private int mSpacingY; //Field offset: 0x190
	private bool mUseFloatSpacing; //Field offset: 0x194
	private float mFloatSpacingX; //Field offset: 0x198
	private float mFloatSpacingY; //Field offset: 0x19C
	private bool mOverflowEllipsis; //Field offset: 0x1A0
	private int mOverflowWidth; //Field offset: 0x1A4
	private int mOverflowHeight; //Field offset: 0x1A8
	private Modifier mModifier; //Field offset: 0x1AC
	private bool mShrinkToFit; //Field offset: 0x1B0
	private int mMaxLineWidth; //Field offset: 0x1B4
	private int mMaxLineHeight; //Field offset: 0x1B8
	private float mLineWidth; //Field offset: 0x1BC
	private bool mMultiline; //Field offset: 0x1C0
	private Font mActiveTTF; //Field offset: 0x1C4
	private float mDensity; //Field offset: 0x1C8
	private bool mShouldBeProcessed; //Field offset: 0x1CC
	private string mProcessedText; //Field offset: 0x1D0
	private bool mPremultiply; //Field offset: 0x1D4
	private Vector2 mCalculatedSize; //Field offset: 0x1D8
	private float mScale; //Field offset: 0x1E0
	private int mFinalFontSize; //Field offset: 0x1E4
	private int mLastWidth; //Field offset: 0x1E8
	private int mLastHeight; //Field offset: 0x1EC
	public ModifierFunc customModifier; //Field offset: 0x1F0

	public Alignment alignment
	{
		 get { } //Length: 7
		 set { } //Length: 44
	}

	public Object ambigiousFont
	{
		 get { } //Length: 163
		 set { } //Length: 222
	}

	public bool applyGradient
	{
		 get { } //Length: 7
		 set { } //Length: 44
	}

	public UIFont bitmapFont
	{
		 get { } //Length: 7
		 set { } //Length: 11
	}

	public int defaultFontSize
	{
		 get { } //Length: 7
	}

	public override Vector4 drawingDimensions
	{
		 get { } //Length: 45
	}

	public Color effectColor
	{
		 get { } //Length: 36
		 set { } //Length: 27
	}

	public Vector2 effectDistance
	{
		 get { } //Length: 175
		 set { } //Length: 12
	}

	public float effectiveSpacingX
	{
		 get { } //Length: 24
	}

	public float effectiveSpacingY
	{
		 get { } //Length: 7
	}

	public Effect effectStyle
	{
		 get { } //Length: 7
		 set { } //Length: 137
	}

	public int finalFontSize
	{
		 get { } //Length: 543
	}

	public float floatSpacingX
	{
		 get { } //Length: 108
		 set { } //Length: 201
	}

	public float floatSpacingY
	{
		 get { } //Length: 7
		 set { } //Length: 105
	}

	public UIFont font
	{
		 get { } //Length: 231
		 set { } //Length: 11
	}

	public int fontSize
	{
		 get { } //Length: 165
		 set { } //Length: 172
	}

	public FontStyle fontStyle
	{
		 get { } //Length: 7
		 set { } //Length: 140
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

	public override bool isAnchoredHorizontally
	{
		 get { } //Length: 10
	}

	public override bool isAnchoredVertically
	{
		 get { } //Length: 24
	}

	private bool isValid
	{
		 get { } //Length: 94
	}

	private bool keepCrisp
	{
		 get { } //Length: 7
	}

	public int lineHeight
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public int lineWidth
	{
		 get { } //Length: 7
		 set { } //Length: 36
	}

	public override Vector3[] localCorners
	{
		 get { } //Length: 10
	}

	public override Vector2 localSize
	{
		 get { } //Length: 33
	}

	public override Texture mainTexture
	{
		 get { } //Length: 235
		 set { } //Length: 11
	}

	public override Material material
	{
		 get { } //Length: 39
		 set { } //Length: 30
	}

	public int maxLineCount
	{
		 get { } //Length: 30
		 set { } //Length: 32
	}

	public Modifier modifier
	{
		 get { } //Length: 141
		 set { } //Length: 32
	}

	public bool multiLine
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool overflowEllipsis
	{
		 get { } //Length: 10
		 set { } //Length: 42
	}

	public int overflowHeight
	{
		 get { } //Length: 7
		 set { } //Length: 42
	}

	public Overflow overflowMethod
	{
		 get { } //Length: 7
		 set { } //Length: 36
	}

	public int overflowWidth
	{
		 get { } //Length: 10
		 set { } //Length: 35
	}

	public Vector2 printedSize
	{
		 get { } //Length: 40
	}

	public string printedText
	{
		 get { } //Length: 7
	}

	public string processedText
	{
		 get { } //Length: 8
	}

	public int quadsPerCharacter
	{
		 get { } //Length: 7
	}

	private bool shouldBeProcessed
	{
		 get { } //Length: 206
		 set { } //Length: 202
	}

	public bool shrinkToFit
	{
		 get { } //Length: 48
		 set { } //Length: 222
	}

	public int spacingX
	{
		 get { } //Length: 10
		 set { } //Length: 168
	}

	public int spacingY
	{
		 get { } //Length: 7
		 set { } //Length: 29
	}

	public bool supportEncoding
	{
		 get { } //Length: 115
		 set { } //Length: 42
	}

	public SymbolStyle symbolStyle
	{
		 get { } //Length: 10
		 set { } //Length: 42
	}

	public string text
	{
		 get { } //Length: 23
		 set { } //Length: 153
	}

	public Font trueTypeFont
	{
		 get { } //Length: 7
		 set { } //Length: 126
	}

	public bool useFloatSpacing
	{
		 get { } //Length: 7
		 set { } //Length: 29
	}

	public override Vector3[] worldCorners
	{
		 get { } //Length: 30
	}

	private static UILabel() { }

	public UILabel() { }

	public Vector2 ApplyOffset(List<Vector3> verts, int start) { }

	public void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, int start, int end, float x, float y) { }

	public void AssumeNaturalSize() { }

	public int CalculateOffsetToFit(string text) { }

	public Alignment get_alignment() { }

	public Object get_ambigiousFont() { }

	public bool get_applyGradient() { }

	public UIFont get_bitmapFont() { }

	public int get_defaultFontSize() { }

	public override Vector4 get_drawingDimensions() { }

	public Color get_effectColor() { }

	public Vector2 get_effectDistance() { }

	public float get_effectiveSpacingX() { }

	public float get_effectiveSpacingY() { }

	public Effect get_effectStyle() { }

	public int get_finalFontSize() { }

	public float get_floatSpacingX() { }

	public float get_floatSpacingY() { }

	public UIFont get_font() { }

	public int get_fontSize() { }

	public FontStyle get_fontStyle() { }

	public Color get_gradientBottom() { }

	public Color get_gradientTop() { }

	public override bool get_isAnchoredHorizontally() { }

	public override bool get_isAnchoredVertically() { }

	private bool get_isValid() { }

	private bool get_keepCrisp() { }

	public int get_lineHeight() { }

	public int get_lineWidth() { }

	public override Vector3[] get_localCorners() { }

	public override Vector2 get_localSize() { }

	public override Texture get_mainTexture() { }

	public override Material get_material() { }

	public int get_maxLineCount() { }

	public Modifier get_modifier() { }

	public bool get_multiLine() { }

	public bool get_overflowEllipsis() { }

	public int get_overflowHeight() { }

	public Overflow get_overflowMethod() { }

	public int get_overflowWidth() { }

	public Vector2 get_printedSize() { }

	public string get_printedText() { }

	public string get_processedText() { }

	public int get_quadsPerCharacter() { }

	private bool get_shouldBeProcessed() { }

	public bool get_shrinkToFit() { }

	public int get_spacingX() { }

	public int get_spacingY() { }

	public bool get_supportEncoding() { }

	public SymbolStyle get_symbolStyle() { }

	public string get_text() { }

	public Font get_trueTypeFont() { }

	public bool get_useFloatSpacing() { }

	public override Vector3[] get_worldCorners() { }

	public int GetCharacterIndex(int currentIndex, KeyCode key) { }

	public int GetCharacterIndex(Vector3 worldPos) { }

	public int GetCharacterIndex(Vector2 localPos) { }

	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise) { }

	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise) { }

	public Vector3 GetPositionOfCharacter(int characterIndex) { }

	public override Vector3[] GetSides(Transform relativeTo) { }

	public string GetUrlAtCharacterIndex(int characterIndex) { }

	public string GetUrlAtPosition(Vector3 worldPos) { }

	public string GetUrlAtPosition(Vector2 localPos) { }

	public string GetWordAtCharacterIndex(int characterIndex) { }

	public string GetWordAtPosition(Vector2 localPos) { }

	public string GetWordAtPosition(Vector3 worldPos) { }

	public override void MakePixelPerfect() { }

	public override void MarkAsChanged() { }

	protected override void OnAnchor() { }

	private void OnApplicationPause(bool paused) { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols) { }

	private static void OnFontChanged(Font font) { }

	protected override void OnInit() { }

	protected override void OnStart() { }

	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor) { }

	private void ProcessAndRequest() { }

	public void ProcessText(bool legacyMode = false, bool full = true) { }

	public void set_alignment(Alignment value) { }

	public void set_ambigiousFont(Object value) { }

	public void set_applyGradient(bool value) { }

	public void set_bitmapFont(UIFont value) { }

	public void set_effectColor(Color value) { }

	public void set_effectDistance(Vector2 value) { }

	public void set_effectStyle(Effect value) { }

	public void set_floatSpacingX(float value) { }

	public void set_floatSpacingY(float value) { }

	public void set_font(UIFont value) { }

	public void set_fontSize(int value) { }

	public void set_fontStyle(FontStyle value) { }

	public void set_gradientBottom(Color value) { }

	public void set_gradientTop(Color value) { }

	public void set_lineHeight(int value) { }

	public void set_lineWidth(int value) { }

	public override void set_mainTexture(Texture value) { }

	public override void set_material(Material value) { }

	public void set_maxLineCount(int value) { }

	public void set_modifier(Modifier value) { }

	public void set_multiLine(bool value) { }

	public void set_overflowEllipsis(bool value) { }

	public void set_overflowHeight(int value) { }

	public void set_overflowMethod(Overflow value) { }

	public void set_overflowWidth(int value) { }

	private void set_shouldBeProcessed(bool value) { }

	public void set_shrinkToFit(bool value) { }

	public void set_spacingX(int value) { }

	public void set_spacingY(int value) { }

	public void set_supportEncoding(bool value) { }

	public void set_symbolStyle(SymbolStyle value) { }

	public void set_text(string value) { }

	public void set_trueTypeFont(Font value) { }

	public void set_useFloatSpacing(bool value) { }

	protected void SetActiveFont(Font fnt) { }

	public void SetCurrentPercent() { }

	public void SetCurrentProgress() { }

	public void SetCurrentSelection() { }

	public bool TryGetPositionOfWord(string word, out Vector3 wordPosition) { }

	public void UpdateNGUIText() { }

	protected override void UpgradeFrom265() { }

	public bool Wrap(string text, out string final) { }

	public bool Wrap(string text, out string final, int height) { }

}

