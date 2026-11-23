using System;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class BMFont
{
	private int mSize = 16;

	private int mBase;

	private int mWidth;

	private int mHeight;

	private string mSpriteName;

	private List<BMGlyph> mSaved;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid
	{
		get
		{
			List<BMGlyph> list = mSaved;
			return list._size > 0;
		}
	}

	public int charSize
	{
		get
		{
			return mSize;
		}
		set
		{
			mSize = value;
		}
	}

	public int baseOffset
	{
		get
		{
			return mBase;
		}
		set
		{
			mBase = value;
		}
	}

	public int texWidth
	{
		get
		{
			return mWidth;
		}
		set
		{
			mWidth = value;
		}
	}

	public int texHeight
	{
		get
		{
			return mHeight;
		}
		set
		{
			mHeight = value;
		}
	}

	public int glyphCount
	{
		get
		{
			if (isValid)
			{
				List<BMGlyph> list = mSaved;
				return list._size;
			}
			return 0;
		}
	}

	public string spriteName
	{
		get
		{
			return mSpriteName;
		}
		set
		{
			mSpriteName = value;
		}
	}

	public List<BMGlyph> glyphs => mSaved;

	public unsafe BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0105: Expected Obj, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Ref, but got Unknown
		//IL_0177: Expected Obj, but got I
		//IL_0051: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Dictionary<int, BMGlyph> dictionary = mDict;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Collections.Generic.Dictionary`2<System.Int32, BMGlyph>)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (System.Collections.Generic.Dictionary`2<System.Int32, BMGlyph>)+18]");
		object obj3 = num - 0;
		if (obj3 == null)
		{
			List<BMGlyph> list = mSaved;
			int num2 = default;
			int num3 = default;
			while (num2 < list._size)
			{
				BMGlyph bMGlyph = mSaved.get_Item(num3);
				nint num4 = 0;
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S5_v11 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, BMGlyph>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ S5_v12+4] (should have been resolved before IL gen)");
				num2 = num3 + 1;
			}
		}
		if (!mDict.TryGetValue(index, out *(BMGlyph*)(obj + 12)) && createIfMissing)
		{
			BMGlyph bMGlyph2 = default;
			bMGlyph2.index = index;
			mSaved.Add(bMGlyph2);
			nint num6 = 0;
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, BMGlyph>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S5_v6+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (BMGlyph)0;
	}

	public BMGlyph GetGlyph(int index)
	{
		return GetGlyph(index, createIfMissing: false);
	}

	public void Clear()
	{
		throw new IndexOutOfRangeException();
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
		if (!isValid)
		{
			return;
		}
		List<BMGlyph> list = mSaved;
		int num = 0;
		while (num < list._size)
		{
			BMGlyph bMGlyph = mSaved.get_Item(num);
			BMGlyph bMGlyph2 = bMGlyph;
			if (bMGlyph == null)
			{
				bMGlyph2 = bMGlyph2;
			}
			if (bMGlyph != null)
			{
				bMGlyph2.Trim(xMin, yMin, xMax, yMax);
			}
			int num2 = num + 1;
			num = num2;
		}
	}

	public BMFont()
	{
		List<BMGlyph> list = default;
		list._002Ector();
		mSaved = list;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, BMGlyph>>>)+4] (should have been resolved before IL gen)");
		Dictionary<int, BMGlyph> dictionary = default;
		mDict = dictionary;
	}
}
