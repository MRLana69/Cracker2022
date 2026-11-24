using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class BMSymbol
{
	public string sequence;

	public string spriteName;

	private UISpriteData mSprite;

	private bool mIsValid = false;

	private int mLength;

	private int mOffsetX;

	private int mOffsetY;

	private int mWidth;

	private int mHeight;

	private int mAdvance;

	private Rect mUV;

	public int length => mOffsetX;

	public int offsetX
	{
		get
		{
			if (mLength == 0)
			{
				string text = sequence;
				mLength = text.m_stringLength;
			}
			return mLength;
		}
	}

	public int offsetY => mOffsetX;

	public int width => mOffsetY;

	public int height => mWidth;

	public int advance => mHeight;

	public Rect uvRect
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			Rect rect = default;
			object obj = rect + 24;
			obj = this;
			return rect;
		}
	}

	public void MarkAsChanged()
	{
	}

	public bool Validate(UIAtlas atlas)
	{
		//IL_00de: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I4
		bool flag = (object)atlas == null;
		bool flag2 = mAdvance == 0;
		object obj = flag | flag2;
		bool result;
		if (obj != null)
		{
			result = false;
		}
		else
		{
			int num = mAdvance;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (System.Int32)+C]");
				bool flag3 = (nint)num3 >= (nint)0;
				result = false;
				if (flag3)
				{
					break;
				}
				int num4 = ((List<int>)mAdvance).get_Item(num2);
				if (num4 != (nint)atlas)
				{
					int num5 = num2 + 2;
					num2 = num5;
					continue;
				}
				int index = num2 + 1;
				int num6 = ((List<int>)mAdvance).get_Item(index);
				result = (byte)num6 != 0;
				break;
			}
		}
		return result;
	}
}
