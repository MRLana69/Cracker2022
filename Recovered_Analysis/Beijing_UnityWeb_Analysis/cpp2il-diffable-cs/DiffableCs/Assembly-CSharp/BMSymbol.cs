//Type is in global namespace

public class BMSymbol
{
	public string sequence; //Field offset: 0x8
	public string spriteName; //Field offset: 0xC
	private UISpriteData mSprite; //Field offset: 0x10
	private bool mIsValid; //Field offset: 0x14
	private int mLength; //Field offset: 0x18
	private int mOffsetX; //Field offset: 0x1C
	private int mOffsetY; //Field offset: 0x20
	private int mWidth; //Field offset: 0x24
	private int mHeight; //Field offset: 0x28
	private int mAdvance; //Field offset: 0x2C
	private Rect mUV; //Field offset: 0x30

	public int advance
	{
		 get { } //Length: 6
	}

	public int height
	{
		 get { } //Length: 6
	}

	public int length
	{
		 get { } //Length: 6
	}

	public int offsetX
	{
		 get { } //Length: 28
	}

	public int offsetY
	{
		 get { } //Length: 6
	}

	public Rect uvRect
	{
		 get { } //Length: 11
	}

	public int width
	{
		 get { } //Length: 6
	}

	public BMSymbol() { }

	public int get_advance() { }

	public int get_height() { }

	public int get_length() { }

	public int get_offsetX() { }

	public int get_offsetY() { }

	public Rect get_uvRect() { }

	public int get_width() { }

	public void MarkAsChanged() { }

	public bool Validate(UIAtlas atlas) { }

}

