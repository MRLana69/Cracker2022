using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class UISpriteData
{
	public string name;

	public int x;

	public int y = 30;

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

	public bool hasBorder => borderTop != 0;

	public bool hasPadding
	{
		get
		{
			int num = borderRight | borderLeft;
			int num2 = num | borderTop;
			int num3 = num2 | borderBottom;
			return num3 != 0;
		}
	}

	public void SetRect(int x, int y, int width, int height)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_0028: Expected Obj, but got I4
		object obj = -y;
		object obj2 = obj - height;
		object obj3 = width + x;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8C6E");
	}

	public void SetPadding(int left, int bottom, int right, int top)
	{
		x = left;
		y = bottom;
		width = right;
		height = top;
	}

	public void SetBorder(int left, int bottom, int right, int top)
	{
		paddingLeft = left;
		paddingBottom = bottom;
		paddingRight = right;
		paddingTop = top;
	}

	public void CopyFrom(UISpriteData sd)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		int num = sd & 1;
		height = num;
	}

	public void CopyBorderFrom(UISpriteData sd)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = sd.name;
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

	public UISpriteData()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		object obj = this + 20;
		obj = "";
		height = 1;
		_ = 1;
		borderTop = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj2 = this + 40;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
