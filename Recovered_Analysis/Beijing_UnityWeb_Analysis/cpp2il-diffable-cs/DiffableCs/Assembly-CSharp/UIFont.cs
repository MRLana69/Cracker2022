//Type is in global namespace

public class UIFont : MonoBehaviour
{
	private Material mMat; //Field offset: 0xC
	private Rect mUVRect; //Field offset: 0x10
	private BMFont mFont; //Field offset: 0x20
	private UIAtlas mAtlas; //Field offset: 0x24
	private UIFont mReplacement; //Field offset: 0x28
	private List<BMSymbol> mSymbols; //Field offset: 0x2C
	private Font mDynamicFont; //Field offset: 0x30
	private int mDynamicFontSize; //Field offset: 0x34
	private FontStyle mDynamicFontStyle; //Field offset: 0x38
	private UISpriteData mSprite; //Field offset: 0x3C
	private int mPMA; //Field offset: 0x40
	private int mPacked; //Field offset: 0x44

	public UIAtlas atlas
	{
		 get { } //Length: 108
		 set { } //Length: 121
	}

	public BMFont bmFont
	{
		 get { } //Length: 861
		 set { } //Length: 835
	}

	public int defaultSize
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Font dynamicFont
	{
		 get { } //Length: 152
		 set { } //Length: 423
	}

	public FontStyle dynamicFontStyle
	{
		 get { } //Length: 108
		 set { } //Length: 235
	}

	private Texture dynamicTexture
	{
		 get { } //Length: 108
	}

	public bool hasSymbols
	{
		 get { } //Length: 122
	}

	public bool isDynamic
	{
		 get { } //Length: 6
	}

	public bool isValid
	{
		 get { } //Length: 111
	}

	public Material material
	{
		 get { } //Length: 108
		 set { } //Length: 340
	}

	public bool packedFontShader
	{
		 get { } //Length: 351
	}

	public bool premultipliedAlpha
	{
		 get { } //Length: 433
	}

	public bool premultipliedAlphaShader
	{
		 get { } //Length: 9
	}

	public UIFont replacement
	{
		 get { } //Length: 361
		 set { } //Length: 110
	}

	public int size
	{
		 get { } //Length: 101
		 set { } //Length: 143
	}

	public UISpriteData sprite
	{
		 get { } //Length: 142
	}

	public string spriteName
	{
		 get { } //Length: 209
		 set { } //Length: 293
	}

	public List<BMSymbol> symbols
	{
		 get { } //Length: 134
	}

	public int texHeight
	{
		 get { } //Length: 122
		 set { } //Length: 121
	}

	public Texture2D texture
	{
		 get { } //Length: 333
	}

	public int texWidth
	{
		 get { } //Length: 108
		 set { } //Length: 113
	}

	public Rect uvRect
	{
		 get { } //Length: 183
		 set { } //Length: 257
	}

	public UIFont() { }

	public void AddSymbol(string sequence, string spriteName) { }

	public static bool CheckIfRelated(UIFont a, UIFont b) { }

	public UIAtlas get_atlas() { }

	public BMFont get_bmFont() { }

	public int get_defaultSize() { }

	public Font get_dynamicFont() { }

	public FontStyle get_dynamicFontStyle() { }

	private Texture get_dynamicTexture() { }

	public bool get_hasSymbols() { }

	public bool get_isDynamic() { }

	public bool get_isValid() { }

	public Material get_material() { }

	public bool get_packedFontShader() { }

	public bool get_premultipliedAlpha() { }

	public bool get_premultipliedAlphaShader() { }

	public UIFont get_replacement() { }

	public int get_size() { }

	public UISpriteData get_sprite() { }

	public string get_spriteName() { }

	public List<BMSymbol> get_symbols() { }

	public int get_texHeight() { }

	public Texture2D get_texture() { }

	public int get_texWidth() { }

	public Rect get_uvRect() { }

	private BMSymbol GetSymbol(string sequence, bool createIfMissing) { }

	public void MarkAsChanged() { }

	public BMSymbol MatchSymbol(string text, int offset, int textLength) { }

	private bool References(UIFont font) { }

	public void RemoveSymbol(string sequence) { }

	public void RenameSymbol(string before, string after) { }

	public void set_atlas(UIAtlas value) { }

	public void set_bmFont(BMFont value) { }

	public void set_defaultSize(int value) { }

	public void set_dynamicFont(Font value) { }

	public void set_dynamicFontStyle(FontStyle value) { }

	public void set_material(Material value) { }

	public void set_replacement(UIFont value) { }

	public void set_size(int value) { }

	public void set_spriteName(string value) { }

	public void set_texHeight(int value) { }

	public void set_texWidth(int value) { }

	public void set_uvRect(Rect value) { }

	private void Trim() { }

	public void UpdateUVRect() { }

	public bool UsesSprite(string s) { }

}

