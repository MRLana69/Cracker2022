using System;

[Serializable]
public class UISpriteData
{
	public string name = "Sprite";

	public int x;

	public int y;

	public int width;

	public int height;

	public int borderLeft;

	public int borderRight;

	public int borderTop;

	public int borderBottom;

	public int paddingLeft;

	public int paddingRight;

	public int paddingTop;

	public int paddingBottom;

	public bool hasBorder
	{
		get
		{
			int num = borderRight | borderLeft;
			int num2 = borderTop | num;
			int num3 = borderBottom | num2;
			return num3 != 0;
		}
	}

	public bool hasPadding
	{
		get
		{
			int num = paddingRight | paddingLeft;
			int num2 = paddingTop | num;
			int num3 = paddingBottom | num2;
			return num3 != 0;
		}
	}

	public void SetRect(int x, int y, int width, int height)
	{
		this.height = height;
		this.width = width;
		this.y = y;
		this.x = x;
	}

	public void SetPadding(int left, int bottom, int right, int top)
	{
		paddingBottom = bottom;
		paddingLeft = left;
		paddingTop = top;
		paddingRight = right;
	}

	public void SetBorder(int left, int bottom, int right, int top)
	{
		borderBottom = bottom;
		borderLeft = left;
		borderTop = top;
		borderRight = right;
	}

	public void CopyFrom(UISpriteData sd)
	{
		name = sd.name;
		x = sd.x;
		y = sd.y;
		width = sd.width;
		height = sd.height;
		borderLeft = sd.borderLeft;
		borderRight = sd.borderRight;
		borderTop = sd.borderTop;
		borderBottom = sd.borderBottom;
		paddingLeft = sd.paddingLeft;
		paddingRight = sd.paddingRight;
		paddingTop = sd.paddingTop;
		paddingBottom = sd.paddingBottom;
	}

	public void CopyBorderFrom(UISpriteData sd)
	{
		borderLeft = sd.borderLeft;
		borderRight = sd.borderRight;
		borderTop = sd.borderTop;
		borderBottom = sd.borderBottom;
	}
}
