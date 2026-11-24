//Type is in global namespace

public class UIAtlas : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<UISpriteData> <>9__29_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <SortAlphabetically>b__29_0(UISpriteData s1, UISpriteData s2) { }

	}

	private enum Coordinates
	{
		Pixels = 0,
		TexCoords = 1,
	}

	private class Sprite
	{
		public string name; //Field offset: 0x8
		public Rect outer; //Field offset: 0xC
		public Rect inner; //Field offset: 0x1C
		public bool rotated; //Field offset: 0x2C
		public float paddingLeft; //Field offset: 0x30
		public float paddingRight; //Field offset: 0x34
		public float paddingTop; //Field offset: 0x38
		public float paddingBottom; //Field offset: 0x3C

		public bool hasPadding
		{
			 get { } //Length: 213
		}

		public Sprite() { }

		public bool get_hasPadding() { }

	}

	private Material material; //Field offset: 0xC
	private List<UISpriteData> mSprites; //Field offset: 0x10
	private float mPixelSize; //Field offset: 0x14
	private UIAtlas mReplacement; //Field offset: 0x18
	private Coordinates mCoordinates; //Field offset: 0x1C
	private List<Sprite> sprites; //Field offset: 0x20
	private int mPMA; //Field offset: 0x24
	private Dictionary<string, int> mSpriteIndices; //Field offset: 0x28

	public float pixelSize
	{
		 get { } //Length: 7
		 set { } //Length: 112
	}

	public bool premultipliedAlpha
	{
		 get { } //Length: 108
	}

	public UIAtlas replacement
	{
		 get { } //Length: 169
		 set { } //Length: 113
	}

	public List<UISpriteData> spriteList
	{
		 get { } //Length: 278
		 set { } //Length: 206
	}

	public Material spriteMaterial
	{
		 get { } //Length: 6
		 set { } //Length: 8
	}

	public Texture texture
	{
		 get { } //Length: 138
	}

	public UIAtlas() { }

	public static bool CheckIfRelated(UIAtlas a, UIAtlas b) { }

	public float get_pixelSize() { }

	public bool get_premultipliedAlpha() { }

	public UIAtlas get_replacement() { }

	public List<UISpriteData> get_spriteList() { }

	public Material get_spriteMaterial() { }

	public Texture get_texture() { }

	public BetterList<string> GetListOfSprites() { }

	public BetterList<string> GetListOfSprites(string match) { }

	public string GetRandomSprite(string startsWith) { }

	public UISpriteData GetSprite(string name) { }

	public void MarkAsChanged() { }

	public void MarkSpriteListAsChanged() { }

	private bool References(UIAtlas atlas) { }

	public void set_pixelSize(float value) { }

	public void set_replacement(UIAtlas value) { }

	public void set_spriteList(List<UISpriteData> value) { }

	public void set_spriteMaterial(Material value) { }

	public void SortAlphabetically() { }

	private bool Upgrade() { }

}

