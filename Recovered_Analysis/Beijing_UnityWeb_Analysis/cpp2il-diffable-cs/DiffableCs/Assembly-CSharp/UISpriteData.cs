//Type is in global namespace

public class UISpriteData
{
	public string name; //Field offset: 0x8
	public int x; //Field offset: 0xC
	public int y; //Field offset: 0x10
	public int width; //Field offset: 0x14
	public int height; //Field offset: 0x18
	public int borderLeft; //Field offset: 0x1C
	public int borderRight; //Field offset: 0x20
	public int borderTop; //Field offset: 0x24
	public int borderBottom; //Field offset: 0x28
	public int paddingLeft; //Field offset: 0x2C
	public int paddingRight; //Field offset: 0x30
	public int paddingTop; //Field offset: 0x34
	public int paddingBottom; //Field offset: 0x38

	public bool hasBorder
	{
		 get { } //Length: 9
	}

	public bool hasPadding
	{
		 get { } //Length: 27
	}

	public UISpriteData() { }

	public void CopyBorderFrom(UISpriteData sd) { }

	public void CopyFrom(UISpriteData sd) { }

	public bool get_hasBorder() { }

	public bool get_hasPadding() { }

	public void SetBorder(int left, int bottom, int right, int top) { }

	public void SetPadding(int left, int bottom, int right, int top) { }

	public void SetRect(int x, int y, int width, int height) { }

}

