using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class UIFont : MonoBehaviour
{
	private Material mMat;

	private Rect mUVRect;

	private BMFont mFont;

	private UIAtlas mAtlas;

	private UIFont mReplacement;

	private List<BMSymbol> mSymbols;

	private Font mDynamicFont;

	private int mDynamicFontSize;

	private FontStyle mDynamicFontStyle;

	[NonSerialized]
	private UISpriteData mSprite;

	private int mPMA;

	private int mPacked;

	public BMFont bmFont
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			return uIFont.mFont;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			uIFont.mFont = value;
		}
	}

	public int texWidth
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			BMFont bMFont = uIFont.mFont;
			if (uIFont.mFont == null)
			{
				return 1;
			}
			return bMFont.mWidth;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			BMFont bMFont = uIFont.mFont;
			if (uIFont.mFont != null)
			{
				bMFont.mWidth = value;
			}
		}
	}

	public int texHeight
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			BMFont bMFont = uIFont.mFont;
			if (uIFont.mFont == null)
			{
				return 1;
			}
			return bMFont.mHeight;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			BMFont bMFont = uIFont.mFont;
			if (uIFont.mFont != null)
			{
				bMFont.mHeight = value;
			}
		}
	}

	public bool hasSymbols
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			List<BMSymbol> list = uIFont.mSymbols;
			if (uIFont.mSymbols == null)
			{
				return false;
			}
			return list._size != 0;
		}
	}

	public List<BMSymbol> symbols
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			return uIFont.mSymbols;
		}
	}

	public UIAtlas atlas
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			return uIFont.mAtlas;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0113: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 - 32;
			if (mReplacement != null)
			{
				mReplacement.atlas = value;
			}
			else
			{
				if (!(mAtlas != value))
				{
					return;
				}
				mAtlas = value;
				mPMA = -1;
				if (mAtlas != null)
				{
					Material spriteMaterial = mAtlas.spriteMaterial;
					mMat = spriteMaterial;
					UISpriteData uISpriteData = sprite;
					if (uISpriteData != null)
					{
						Rect rect = uvRect;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_ = 0;
						mUVRect = (Rect)obj;
					}
				}
				MarkAsChanged();
			}
		}
	}

	public Material material
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			if (uIFont.mAtlas != null)
			{
				return uIFont.mAtlas.spriteMaterial;
			}
			bool flag = uIFont.mMat != null;
			bool flag2 = uIFont.mDynamicFont != null;
			if (flag)
			{
				if (flag2)
				{
					Material material = uIFont.mDynamicFont.material;
					if (uIFont.mMat != material)
					{
						Material material2 = uIFont.mDynamicFont.material;
						Texture mainTexture = material2.mainTexture;
						uIFont.mMat.mainTexture = mainTexture;
					}
				}
				return uIFont.mMat;
			}
			if (flag2)
			{
				return uIFont.mDynamicFont.material;
			}
			return null;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			if (uIFont.mMat != value)
			{
				uIFont.mMat = value;
				uIFont.mPMA = -1;
				uIFont.MarkAsChanged();
			}
		}
	}

	public bool premultipliedAlpha => premultipliedAlphaShader;

	public bool premultipliedAlphaShader
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			if (uIFont.mAtlas != null)
			{
				return uIFont.mAtlas.premultipliedAlpha;
			}
			bool flag = uIFont.mPMA == -1;
			bool flag2 = !flag;
			bool flag3 = (byte)uIFont.mPMA != 0;
			if (!flag2)
			{
				Material material = uIFont.material;
				bool flag4 = material != null;
				bool flag5 = !flag4;
				bool flag6 = false;
				if (!flag5)
				{
					Shader shader = material.shader;
					bool flag7 = shader != null;
					bool flag8 = !flag7;
					flag6 = false;
					if (!flag8)
					{
						Shader shader2 = material.shader;
						string text = shader2.name;
						flag6 = text.Contains("Premultiplied");
					}
				}
				uIFont.mPMA = (flag6 ? 1 : 0);
				flag3 = flag6;
			}
			return flag3;
		}
	}

	public bool packedFontShader
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			if (uIFont.mAtlas != null)
			{
				return false;
			}
			bool flag = uIFont.mPacked == -1;
			bool flag2 = !flag;
			bool flag3 = (byte)uIFont.mPacked != 0;
			if (!flag2)
			{
				Material material = uIFont.material;
				bool flag4 = material != null;
				bool flag5 = !flag4;
				bool flag6 = false;
				if (!flag5)
				{
					Shader shader = material.shader;
					bool flag7 = shader != null;
					bool flag8 = !flag7;
					flag6 = false;
					if (!flag8)
					{
						Shader shader2 = material.shader;
						string text = shader2.name;
						flag6 = text.Contains("Packed");
					}
				}
				uIFont.mPacked = (flag6 ? 1 : 0);
				flag3 = flag6;
			}
			return flag3;
		}
	}

	public Texture2D texture
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			Material material = uIFont.material;
			if (material != null)
			{
				Texture mainTexture = material.mainTexture;
				bool flag = (object)mainTexture == null;
				Texture result = null;
				if (!flag)
				{
					bool flag2 = (object)mainTexture.GetType() == typeof(Texture2D);
					result = mainTexture;
					if (!flag2)
					{
						result = null;
					}
				}
				return (Texture2D)result;
			}
			return null;
		}
	}

	public unsafe Rect uvRect
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0037: Expected F4, but got I
			//IL_0032: Expected native int or pointer, but got VT
			//IL_0044: Expected F4, but got Obj
			//IL_003f: Expected native int or pointer, but got VT
			//IL_00d0: Expected native int or pointer, but got VT
			//IL_00de: Expected native int or pointer, but got VT
			//IL_00ec: Expected native int or pointer, but got VT
			//IL_00fa: Expected native int or pointer, but got VT
			//IL_0108: Expected native int or pointer, but got VT
			//IL_0116: Expected native int or pointer, but got VT
			//IL_00ad: Expected F4, but got VT
			//IL_00a8: Expected native int or pointer, but got VT
			//IL_00c2: Expected F4, but got I
			//IL_00bd: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			Rect rect2 = default;
			if (mReplacement != null)
			{
				Rect rect = mReplacement.uvRect;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				((Rect*)(nint)rect2)->m_Width = 0f;
				((Rect*)(nint)rect2)->m_XMin = (float)obj;
			}
			else
			{
				if (mAtlas != null)
				{
					UISpriteData uISpriteData = sprite;
					if (uISpriteData != null)
					{
						((Rect*)(nint)rect2)->m_XMin = (float)mUVRect;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIFont)+18]");
						((Rect*)(nint)rect2)->m_Width = 0f;
						goto IL_0149;
					}
				}
				((Rect*)(nint)rect2)->m_XMin = 0f;
				((Rect*)(nint)rect2)->m_Width = 0f;
				((Rect*)(nint)rect2)->m_Height = 1f;
				((Rect*)(nint)rect2)->m_Width = 1f;
				((Rect*)(nint)rect2)->m_YMin = 0f;
				((Rect*)(nint)rect2)->m_XMin = 0f;
			}
			goto IL_0149;
			IL_0149:
			return rect2;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0020: Expected native int or pointer, but got VT
			//IL_0032: Expected native int or pointer, but got VT
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Expected VT, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected VT, but got Unknown
			//IL_00e0: Expected VT, but got F4
			object obj = default;
			Rect rect = (Rect)(obj - 48);
			if (mReplacement != null)
			{
				((Rect*)(nint)rect)->m_Width = value.m_Width;
				((Rect*)(nint)rect)->m_XMin = value.m_XMin;
				mReplacement.uvRect = rect;
				return;
			}
			UISpriteData uISpriteData = sprite;
			if (uISpriteData == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIFont)+18]");
				_ = 0;
				_ = mUVRect;
				_ = value.m_Width;
				_ = value.m_XMin;
				Rect rect2 = (Rect)(rect + 32);
				Rect rect3 = (Rect)(rect + 16);
				if (rect2 != rect3)
				{
					mUVRect = (Rect)value.m_XMin;
					_ = value.m_Width;
					MarkAsChanged();
				}
			}
		}
	}

	public string spriteName
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			BMFont bMFont = uIFont.mFont;
			return bMFont.mSpriteName;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			BMFont bMFont = uIFont.mFont;
			if (bMFont.mSpriteName != value)
			{
				BMFont bMFont2 = uIFont.mFont;
				bMFont2.mSpriteName = value;
				uIFont.MarkAsChanged();
			}
		}
	}

	public bool isValid
	{
		get
		{
			if (mDynamicFont != null)
			{
				return true;
			}
			return mFont.isValid;
		}
	}

	public int size
	{
		get
		{
			return defaultSize;
		}
		set
		{
			defaultSize = value;
		}
	}

	public int defaultSize
	{
		get
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_00b4: Expected I4, but got Obj
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			object obj = ((!uIFont.isDynamic && uIFont.mFont != null) ? ((object)(uIFont.mFont + 8)) : ((object)(uIFont + 52)));
			return (int)obj;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			uIFont.mDynamicFontSize = value;
		}
	}

	public UISpriteData sprite
	{
		get
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Expected Obj, but got Unknown
			//IL_00c7: Expected Obj, but got I4
			//IL_00ab: Expected Obj, but got I4
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			object result = uIFont + 60;
			if (uIFont.mSprite != null || !(uIFont.mAtlas != null))
			{
				goto IL_0219;
			}
			BMFont bMFont = uIFont.mFont;
			string mSpriteName = bMFont.mSpriteName;
			object obj;
			if (bMFont.mSpriteName != null)
			{
				obj = 0;
				if (mSpriteName._stringLength != 0)
				{
					goto IL_021e;
				}
			}
			obj = 1;
			goto IL_021e;
			IL_021e:
			if (obj == null)
			{
				BMFont bMFont2 = uIFont.mFont;
				UISpriteData uISpriteData = uIFont.mAtlas.GetSprite(bMFont2.mSpriteName);
				uIFont.mSprite = uISpriteData;
				if (uIFont.mSprite == null)
				{
					string text = uIFont.name;
					UISpriteData uISpriteData2 = uIFont.mAtlas.GetSprite(text);
					uIFont.mSprite = uISpriteData2;
					if (uIFont.mSprite == null)
					{
						BMFont bMFont3 = uIFont.mFont;
						bMFont3.mSpriteName = null;
						goto IL_0186;
					}
				}
				uIFont.UpdateUVRect();
				goto IL_0186;
			}
			goto IL_0219;
			IL_0186:
			List<BMSymbol> list = uIFont.mSymbols;
			int num = 0;
			while (num < list._size)
			{
				List<BMSymbol> list2 = uIFont.symbols;
				BMSymbol bMSymbol = list2.get_Item(num);
				bMSymbol.mIsValid = false;
				int num2 = num + 1;
				num = num2;
			}
			goto IL_0219;
			IL_0219:
			return (UISpriteData)result;
		}
	}

	public UIFont replacement
	{
		get
		{
			return mReplacement;
		}
		set
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected Obj, but got Unknown
			//IL_006e: Expected Obj, but got I
			bool flag = value != this;
			UnityEngine.Object obj = null;
			if (flag)
			{
				obj = value;
			}
			if (!(mReplacement != obj))
			{
				return;
			}
			object obj2 = this + 40;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (UnityEngine.Object)+28]");
				if ((UnityEngine.Object)0 == this)
				{
					((UIFont)obj).replacement = null;
				}
			}
			if ((UnityEngine.Object)obj2 != null)
			{
				MarkAsChanged();
			}
			obj2 = obj;
			if (obj != null)
			{
				mMat = null;
				mPMA = -1;
				mFont = null;
				mDynamicFont = null;
			}
			MarkAsChanged();
		}
	}

	public bool isDynamic
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			return uIFont.mDynamicFont != null;
		}
	}

	public Font dynamicFont
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			return uIFont.mDynamicFont;
		}
		set
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected Obj, but got Unknown
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			if (uIFont.mDynamicFont != value)
			{
				object obj = uIFont + 48;
				if ((UnityEngine.Object)obj != null)
				{
					uIFont.material = null;
				}
				uIFont.mDynamicFont = value;
				uIFont.MarkAsChanged();
			}
		}
	}

	public FontStyle dynamicFontStyle
	{
		get
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			return uIFont.mDynamicFontStyle;
		}
		set
		{
			UIFont uIFont = default;
			while (uIFont.mReplacement != null)
			{
				uIFont = mReplacement;
			}
			if (value != uIFont.mDynamicFontStyle)
			{
				uIFont.mDynamicFontStyle = value;
				uIFont.MarkAsChanged();
			}
		}
	}

	private Texture dynamicTexture
	{
		get
		{
			UIFont uIFont = default;
			while ((bool)uIFont.mReplacement)
			{
				uIFont = mReplacement;
			}
			if (uIFont.isDynamic)
			{
				Material material = uIFont.mDynamicFont.material;
				return material.mainTexture;
			}
			return null;
		}
	}

	private unsafe void Trim()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0071: Expected I, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_00b1: Expected F4, but got I
		//IL_00ac: Expected native int or pointer, but got VT
		//IL_00c6: Expected F4, but got I
		//IL_00c1: Expected native int or pointer, but got VT
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected Obj, but got Unknown
		//IL_018e: Expected F8, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I
		//IL_01cd: Expected F8, but got I4
		//IL_02f4: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_020c: Expected F8, but got I4
		//IL_0331: Expected Obj, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_024b: Expected F8, but got I4
		//IL_0374: Expected I4, but got F8
		//IL_0374: Expected I4, but got F8
		//IL_0374: Expected I4, but got F8
		//IL_0374: Expected I4, but got F8
		object obj = default;
		Rect rect = (Rect)(obj - 80);
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Texture texture = mAtlas.texture;
		if (texture != null && mSprite != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIFont)+18]");
			_ = 0;
			_ = mUVRect;
			Texture2D texture2D = this.texture;
			nint num = (nint)texture2D;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ S1_v17 (Il2CppClass<UnityEngine.Texture2D>)+DC] (should have been resolved before IL gen)");
			Texture2D texture2D2 = this.texture;
			nint num2 = (nint)texture2D2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S1_v21 (Il2CppClass<UnityEngine.Texture2D>)+EC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			int width = default;
			int height = default;
			Rect rect2 = NGUIMath.ConvertToPixels(rect, width, height, round: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			_ = 0;
			UISpriteData uISpriteData = mSprite;
			_ = uISpriteData.height;
			_ = uISpriteData.width;
			_ = uISpriteData.y;
			_ = uISpriteData.x;
			object obj2 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj3 = 0 - obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num4 = default;
			double num3 = Math.Abs(num4);
			if (!(num3 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			object obj4 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v44+4]");
			object obj5 = num5 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			object obj6 = num8 + 0;
			object obj7 = rect - -64;
			object obj8 = obj6 - obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num10 = default;
			double num9 = Math.Abs(num10);
			if (!(num9 < 2147483648.0))
			{
				num10 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+3C]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+34]");
			object obj9 = num11 + 0;
			object obj10 = rect - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S1_v58+4]");
			object obj11 = obj9 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num13 = default;
			double num12 = Math.Abs(num13);
			if (!(num12 < 2147483648.0))
			{
				num13 = -2147483648.0;
			}
			mFont.Trim((int)num4, (int)num7, (int)num10, (int)num13);
		}
	}

	private bool References(UIFont font)
	{
		bool result;
		UIFont uIFont = default;
		while (true)
		{
			bool flag = font != null;
			result = false;
			if (flag)
			{
				if (font == mReplacement)
				{
					result = true;
					break;
				}
				bool flag2 = uIFont.mReplacement != null;
				bool flag3 = !flag2;
				result = false;
				if (flag3)
				{
					break;
				}
				uIFont = mReplacement;
				continue;
			}
			break;
		}
		return result;
	}

	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		bool flag = a != null;
		bool result = false;
		if (flag)
		{
			bool flag2 = b != null;
			result = false;
			if (flag2)
			{
				if (a.isDynamic && b.isDynamic)
				{
					Font font = a.dynamicFont;
					string[] fontNames = font.fontNames;
					Font font2 = b.dynamicFont;
					string[] fontNames2 = font2.fontNames;
					bool flag3 = fontNames[0] != fontNames2[0];
					result = true;
					if (!flag3)
					{
						goto IL_018d;
					}
				}
				bool flag4 = a != b;
				result = true;
				if (flag4)
				{
					bool flag5 = a.References(b);
					result = true;
					if (!flag5)
					{
						bool flag6 = b.References(a);
						result = flag6;
					}
				}
			}
		}
		goto IL_018d;
		IL_018d:
		return result;
	}

	public void MarkAsChanged()
	{
		//IL_0033: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I
		//IL_0074: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_00a2: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		//IL_012f: Expected Obj, but got I
		if (mReplacement != null)
		{
			mReplacement.MarkAsChanged();
		}
		mSprite = null;
		_0021_00210[] array = (_0021_00210[])(object)NGUITools.FindActive<T>();
		object obj = 0;
		while ((nint)obj < array.Length)
		{
			object obj2 = obj << 2;
			object obj3 = (object)array + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v39+10]");
			Behaviour behaviour = (Behaviour)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v39+10]");
			if (((Behaviour)0).enabled)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v39+10]");
				GameObject go = ((Component)0).gameObject;
				if (NGUITools.GetActive(go))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v40 (UnityEngine.Behaviour)+120]");
					if (CheckIfRelated(this, (UIFont)0))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v39+10]");
						((UILabel)0).bitmapFont = null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v39+10]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v40 (UnityEngine.Behaviour)+120]");
						((UILabel)num).bitmapFont = (UIFont)0;
					}
				}
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		List<BMSymbol> list = symbols;
		int num2 = 0;
		while (num2 < list._size)
		{
			List<BMSymbol> list2 = symbols;
			BMSymbol bMSymbol = list2.get_Item(num2);
			bMSymbol.mIsValid = false;
			int num3 = num2 + 1;
			num2 = num3;
		}
	}

	public unsafe void UpdateUVRect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got I4
		//IL_0128: Expected VT, but got I
		//IL_014a: Expected I, but got Obj
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		//IL_016a: Expected I, but got Obj
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0197: Expected F4, but got I
		//IL_0192: Expected native int or pointer, but got VT
		//IL_01ac: Expected F4, but got I
		//IL_01a7: Expected native int or pointer, but got VT
		//IL_01fa: Expected VT, but got I
		object obj = default;
		Rect rect = (Rect)(obj - 80);
		if (!(mAtlas != null))
		{
			return;
		}
		Texture texture = mAtlas.texture;
		if (texture != null)
		{
			UISpriteData uISpriteData = mSprite;
			_ = 0;
			_ = 0;
			object obj2 = rect - -64;
			object obj3 = uISpriteData.paddingTop + uISpriteData.height;
			object obj4 = uISpriteData.paddingBottom + obj3;
			object obj5 = uISpriteData.paddingLeft + uISpriteData.width;
			object obj6 = uISpriteData.paddingRight + obj5;
			object obj7 = uISpriteData.y - uISpriteData.paddingTop;
			object obj8 = uISpriteData.x - uISpriteData.paddingLeft;
			obj2 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
			mUVRect = (Rect)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+40]");
			_ = 0;
			nint num = (nint)texture;
			object obj9 = texture + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v152 @ S1_v28 (Il2CppClass<UnityEngine.Texture>)+DC] (should have been resolved before IL gen)");
			nint num2 = (nint)texture;
			object obj10 = texture + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ S1_v32 (Il2CppClass<UnityEngine.Texture>)+EC] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+38]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+30]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			int width = default;
			int height = default;
			Rect rect2 = NGUIMath.ConvertToTexCoords(rect, width, height);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			mUVRect = (Rect)0;
			UISpriteData uISpriteData2 = mSprite;
			int num3 = uISpriteData2.paddingRight | uISpriteData2.paddingLeft;
			int num4 = uISpriteData2.paddingTop | num3;
			if ((uISpriteData2.paddingBottom | num4) != 0)
			{
				Trim();
			}
		}
	}

	private BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		List<BMSymbol> list = mSymbols;
		int num = default;
		BMSymbol result;
		int num2 = default;
		BMSymbol bMSymbol2 = default;
		while (true)
		{
			if (num < list._size)
			{
				BMSymbol bMSymbol = mSymbols.get_Item(num);
				bool flag = bMSymbol.sequence != sequence;
				result = bMSymbol;
				if (!flag)
				{
					break;
				}
				num = num2 + 1;
				continue;
			}
			bool flag2 = !createIfMissing;
			result = null;
			if (!flag2)
			{
				bMSymbol2.sequence = sequence;
				mSymbols.Add(bMSymbol2);
				result = bMSymbol2;
			}
			break;
		}
		return result;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		//IL_0012: Expected Obj, but got I4
		List<BMSymbol> list = mSymbols;
		bool flag = list._size == 0;
		BMSymbol result = null;
		if (!flag)
		{
			object obj = textLength - offset;
			int num = default;
			int num5 = default;
			while (true)
			{
				if (num < list._size)
				{
					BMSymbol bMSymbol = mSymbols.get_Item(num);
					bool flag2 = bMSymbol.mLength == 0;
					bool flag3 = !flag2;
					int num2 = bMSymbol.mLength;
					if (!flag3)
					{
						string sequence = bMSymbol.sequence;
						bMSymbol.mLength = sequence._stringLength;
						num2 = sequence._stringLength;
					}
					if (num2 != 0 && num2 <= (nint)obj)
					{
						int num3 = 0;
						while (num3 < num2)
						{
							int index = offset + num3;
							char c = text.get_Chars(index);
							char c2 = bMSymbol.sequence.get_Chars(num3);
							if (c != c2)
							{
								goto IL_016a;
							}
							int num4 = num3 + 1;
							num3 = num4;
						}
						UIAtlas uIAtlas = atlas;
						bool flag4 = bMSymbol.Validate(uIAtlas);
						result = bMSymbol;
						if (flag4)
						{
							break;
						}
					}
					goto IL_016a;
				}
				result = null;
				break;
				IL_016a:
				num = num5 + 1;
			}
		}
		return result;
	}

	public void AddSymbol(string sequence, string spriteName)
	{
		BMSymbol symbol = GetSymbol(sequence, createIfMissing: true);
		symbol.spriteName = spriteName;
		MarkAsChanged();
	}

	public void RemoveSymbol(string sequence)
	{
		BMSymbol symbol = GetSymbol(sequence, createIfMissing: false);
		if (symbol != null)
		{
			List<BMSymbol> list = symbols;
			bool flag = list.Remove(symbol);
		}
		MarkAsChanged();
	}

	public void RenameSymbol(string before, string after)
	{
		BMSymbol symbol = GetSymbol(before, createIfMissing: false);
		if (symbol != null)
		{
			symbol.sequence = after;
		}
		MarkAsChanged();
	}

	public bool UsesSprite(string s)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		object obj;
		if (s != null)
		{
			obj = 0;
			if (s._stringLength != 0)
			{
				goto IL_0102;
			}
		}
		obj = 1;
		goto IL_0102;
		IL_0102:
		bool result = default;
		if (obj == null)
		{
			string value = spriteName;
			bool flag = s.Equals(value);
			result = true;
			if (!flag)
			{
				List<BMSymbol> list = symbols;
				int num = 0;
				while (true)
				{
					bool flag2 = num < list._size;
					bool flag3 = !flag2;
					result = flag2;
					if (flag3)
					{
						break;
					}
					List<BMSymbol> list2 = symbols;
					BMSymbol bMSymbol = list2.get_Item(num);
					bool flag4 = s.Equals(bMSymbol.spriteName);
					result = flag2;
					if (flag4)
					{
						break;
					}
					int num2 = num + 1;
					num = num2;
				}
			}
		}
		return result;
	}

	public UIFont()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0057: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got F4
		//IL_0089: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		obj = 0;
		_ = 1f;
		_ = 1f;
		_ = 0f;
		obj = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		mUVRect = (Rect)obj;
		BMFont bMFont = default;
		bMFont._002Ector();
		mFont = bMFont;
		List<BMSymbol> list = default;
		list._002Ector();
		mSymbols = list;
		mPMA = -1;
		mDynamicFontSize = 16;
		base._002Ector();
	}
}
