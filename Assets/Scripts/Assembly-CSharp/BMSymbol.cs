using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class BMSymbol
{
	public string sequence;

	public string spriteName;

	private UISpriteData mSprite;

	private bool mIsValid;

	private int mLength;

	private int mOffsetX;

	private int mOffsetY;

	private int mWidth;

	private int mHeight;

	private int mAdvance;

	private Rect mUV;

	public int length
	{
		get
		{
			bool flag = mLength == 0;
			bool flag2 = !flag;
			int stringLength = mLength;
			if (!flag2)
			{
				string text = sequence;
				mLength = text._stringLength;
				stringLength = text._stringLength;
			}
			return stringLength;
		}
	}

	public int offsetX => mOffsetX;

	public int offsetY => mOffsetY;

	public int width => mWidth;

	public int height => mHeight;

	public int advance => mAdvance;

	public unsafe Rect uvRect
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Rect rect = default;
			((Rect*)(nint)rect)->m_XMin = (float)mUV;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (BMSymbol)+38]");
			((Rect*)(nint)rect)->m_Width = 0f;
			return rect;
		}
	}

	public void MarkAsChanged()
	{
		mIsValid = false;
	}

	public unsafe bool Validate(UIAtlas atlas)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_0055: Expected Obj, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		//IL_0177: Expected VT, but got I
		//IL_0199: Expected I, but got Obj
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01b9: Expected I, but got Obj
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01e6: Expected F4, but got I
		//IL_01e1: Expected native int or pointer, but got VT
		//IL_01fb: Expected F4, but got I
		//IL_01f6: Expected native int or pointer, but got VT
		//IL_0249: Expected VT, but got I
		//IL_02a6: Expected Obj, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected I4, but got Unknown
		object obj = default;
		Rect rect = (Rect)(obj - 80);
		object obj2;
		if (atlas != null)
		{
			if (mIsValid)
			{
				goto IL_02f3;
			}
			string text = spriteName;
			if (spriteName != null)
			{
				obj2 = 0;
				if (text._stringLength != 0)
				{
					goto IL_030c;
				}
			}
			obj2 = 1;
			goto IL_030c;
		}
		goto IL_02ee;
		IL_02f3:
		return mSprite != null;
		IL_030c:
		if (obj2 != null)
		{
			goto IL_02ee;
		}
		UISpriteData uISpriteData = ((!(atlas != null)) ? null : atlas.GetSprite(spriteName));
		mSprite = uISpriteData;
		if (mSprite != null)
		{
			Texture texture = atlas.texture;
			if (texture == null)
			{
				mSprite = null;
			}
			else
			{
				UISpriteData uISpriteData2 = mSprite;
				_ = 0;
				_ = 0;
				object obj3 = rect - -64;
				_ = uISpriteData2.height;
				_ = uISpriteData2.width;
				_ = uISpriteData2.y;
				obj3 = uISpriteData2.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
				mUV = (Rect)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
				_ = 0;
				nint num = (nint)texture;
				object obj4 = texture + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v174 @ S1_v30 (Il2CppClass<UnityEngine.Texture>)+DC] (should have been resolved before IL gen)");
				nint num2 = (nint)texture;
				object obj5 = texture + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ S1_v34 (Il2CppClass<UnityEngine.Texture>)+EC] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
				((Rect*)(nint)rect)->m_Width = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
				((Rect*)(nint)rect)->m_XMin = 0f;
				int num3 = default;
				int num4 = default;
				Rect rect2 = NGUIMath.ConvertToTexCoords(rect, num3, num4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
				mUV = (Rect)0;
				UISpriteData uISpriteData3 = mSprite;
				mOffsetX = uISpriteData3.paddingLeft;
				mOffsetY = uISpriteData3.paddingTop;
				mWidth = uISpriteData3.width;
				mHeight = uISpriteData3.height;
				object obj6 = uISpriteData3.paddingRight + uISpriteData3.paddingLeft;
				int num5 = obj6 + uISpriteData3.width;
				mIsValid = true;
				mAdvance = num5;
			}
		}
		goto IL_02f3;
		IL_02ee:
		bool result = default;
		return result;
	}
}
