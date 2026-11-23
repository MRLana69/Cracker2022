using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UILabel : UIWidget
{
	public enum Effect
	{
		None,
		Shadow,
		Outline,
		Outline8
	}

	public enum Overflow
	{
		ShrinkContent,
		ClampContent,
		ResizeFreely,
		ResizeHeight
	}

	public enum Crispness
	{
		Never,
		OnDesktop,
		Always
	}

	public Crispness keepCrispWhenShrunk = Crispness.OnDesktop;

	private Font mTrueTypeFont;

	private UIFont mFont;

	private string mText = string.Empty;

	private int mFontSize;

	private FontStyle mFontStyle;

	private NGUIText.Alignment mAlignment;

	private bool mEncoding;

	private int mMaxLineCount;

	private Effect mEffectStyle;

	private Color mEffectColor;

	private NGUIText.SymbolStyle mSymbols = NGUIText.SymbolStyle.Normal;

	private Vector2 mEffectDistance;

	private Overflow mOverflow;

	private Material mMaterial;

	private bool mApplyGradient;

	private Color mGradientTop;

	private Color mGradientBottom;

	private int mSpacingX;

	private int mSpacingY;

	private bool mUseFloatSpacing;

	private float mFloatSpacingX;

	private float mFloatSpacingY;

	private bool mShrinkToFit;

	private int mMaxLineWidth;

	private int mMaxLineHeight;

	private float mLineWidth;

	private bool mMultiline;

	[NonSerialized]
	private Font mActiveTTF;

	[NonSerialized]
	private float mDensity;

	[NonSerialized]
	private bool mShouldBeProcessed;

	[NonSerialized]
	private string mProcessedText;

	[NonSerialized]
	private bool mPremultiply;

	[NonSerialized]
	private Vector2 mCalculatedSize;

	[NonSerialized]
	private float mScale;

	[NonSerialized]
	private int mFinalFontSize;

	[NonSerialized]
	private int mLastWidth;

	[NonSerialized]
	private int mLastHeight;

	private static BetterList<UILabel> mList;

	private static Dictionary<Font, int> mFontUsage;

	private static bool mTexRebuildAdded;

	private static BetterList<Vector3> mTempVerts;

	private static BetterList<int> mTempIndices;

	private static Action<Font> _003C_003Ef__mg_0024cache0;

	public int finalFontSize
	{
		get
		{
			//IL_00f5: Expected I4, but got F8
			Font font = trueTypeFont;
			float num2;
			float num3;
			if ((bool)font)
			{
				float num = mScale * (float)mFinalFontSize;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53458A]");
				bool flag = (nint)0 == 0;
				num2 = num;
				if (flag)
				{
					goto IL_00a4;
				}
				num3 = num;
			}
			else
			{
				float num4 = (float)mFinalFontSize * mScale;
				num2 = num4;
				num3 = num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [53458A]");
				if ((nint)0 == 0)
				{
					goto IL_00a4;
				}
			}
			goto IL_0124;
			IL_0124:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num6 = default;
			double num5 = Math.Abs(num6);
			if (num5 < 2147483648.0)
			{
				return (int)num6;
			}
			return int.MinValue;
			IL_00a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_codegen_initialize_runtime_metadata\"");
			_ = 1;
			num3 = num2;
			goto IL_0124;
		}
	}

	private bool shouldBeProcessed
	{
		get
		{
			return mShouldBeProcessed;
		}
		set
		{
			bool flag;
			if (value)
			{
				mChanged = true;
				flag = true;
			}
			else
			{
				flag = false;
			}
			mShouldBeProcessed = flag;
		}
	}

	public override bool isAnchoredHorizontally
	{
		get
		{
			if (base.isAnchoredHorizontally)
			{
				return true;
			}
			return mOverflow == Overflow.ResizeFreely;
		}
	}

	public override bool isAnchoredVertically
	{
		get
		{
			//IL_003e: Expected Obj, but got I4
			if (!base.isAnchoredVertically)
			{
				object obj = mOverflow & (Overflow)(-2);
				return (nint)obj == 2;
			}
			return true;
		}
	}

	public override Material material
	{
		get
		{
			if (mMaterial != null)
			{
				return mMaterial;
			}
			if (mFont != null)
			{
				return mFont.material;
			}
			if (mTrueTypeFont != null)
			{
				return mTrueTypeFont.material;
			}
			return null;
		}
		set
		{
			//IL_001a: Expected I, but got Obj
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			if (mMaterial != value)
			{
				RemoveFromPanel();
				mMaterial = value;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ S1_v7 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public UIFont font
	{
		get
		{
			return mFont;
		}
		set
		{
			bitmapFont = value;
		}
	}

	public UIFont bitmapFont
	{
		get
		{
			return mFont;
		}
		set
		{
			//IL_0021: Expected I, but got Obj
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected Obj, but got Unknown
			if (mFont != value)
			{
				RemoveFromPanel();
				mFont = value;
				mTrueTypeFont = null;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S1_v8 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public Font trueTypeFont
	{
		get
		{
			if (mTrueTypeFont != null)
			{
				return mTrueTypeFont;
			}
			if (mFont != null)
			{
				return mFont.dynamicFont;
			}
			return null;
		}
		set
		{
			if (mTrueTypeFont != value)
			{
				SetActiveFont(null);
				RemoveFromPanel();
				mTrueTypeFont = value;
				mChanged = true;
				mShouldBeProcessed = true;
				mFont = null;
				SetActiveFont(value);
				ProcessAndRequest();
				if (mActiveTTF != null)
				{
					base.MarkAsChanged();
				}
			}
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			if ((object)mFont != null)
			{
				Font font = (Font)(object)mFont;
			}
			else
			{
				Font font = mTrueTypeFont;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			UnityEngine.Object result = default;
			return result;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			UnityEngine.Object obj = default;
			if (obj != null)
			{
				bitmapFont = (UIFont)obj;
				return;
			}
			bool flag = (object)value == null;
			Font font = null;
			if (!flag)
			{
				bool flag2 = (object)value.GetType() == typeof(Font);
				font = (Font)value;
				if (!flag2)
				{
					font = null;
				}
			}
			trueTypeFont = font;
		}
	}

	public string text
	{
		get
		{
			return mText;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_005a: Expected Obj, but got I4
			//IL_003e: Expected Obj, but got I4
			//IL_00e5: Expected I, but got Obj
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_00a1: Expected Obj, but got I4
			//IL_0085: Expected Obj, but got I4
			string text = default;
			if (!(mText != text))
			{
				return;
			}
			object obj = this + 292;
			string text2 = (string)obj;
			object obj2;
			if (text != null)
			{
				obj2 = 0;
				if (text._stringLength != 0)
				{
					goto IL_014b;
				}
			}
			obj2 = 1;
			goto IL_014b;
			IL_0168:
			object obj3;
			if (obj3 == null)
			{
				goto IL_00d5;
			}
			goto IL_0105;
			IL_0105:
			if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
			{
				ResizeCollider();
			}
			return;
			IL_00d5:
			mText = string.Empty;
			nint num = (nint)this;
			object obj4 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S1_v11 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			ProcessAndRequest();
			goto IL_0105;
			IL_014b:
			if (obj2 != null)
			{
				if (obj != null)
				{
					obj3 = 0;
					if (text2._stringLength != 0)
					{
						goto IL_0168;
					}
				}
				obj3 = 1;
				goto IL_0168;
			}
			if ((string)obj != text)
			{
				goto IL_00d5;
			}
			goto IL_0105;
		}
	}

	public int defaultFontSize
	{
		get
		{
			Font font = trueTypeFont;
			int result;
			if (!(font != null))
			{
				bool flag = mFont != null;
				bool flag2 = !flag;
				result = 16;
				if (!flag2)
				{
					return mFont.defaultSize;
				}
			}
			else
			{
				result = mFontSize;
			}
			return result;
		}
	}

	public int fontSize
	{
		get
		{
			return mFontSize;
		}
		set
		{
			bool flag = value < 256;
			int num = value;
			if (!flag)
			{
				num = 256;
			}
			if (num <= 0)
			{
				num = 0;
			}
			if (num != mFontSize)
			{
				mFontSize = num;
				mChanged = true;
				mShouldBeProcessed = true;
				ProcessAndRequest();
			}
		}
	}

	public FontStyle fontStyle
	{
		get
		{
			return mFontStyle;
		}
		set
		{
			if (value != mFontStyle)
			{
				mFontStyle = value;
				mChanged = true;
				mShouldBeProcessed = true;
				ProcessAndRequest();
			}
		}
	}

	public NGUIText.Alignment alignment
	{
		get
		{
			return mAlignment;
		}
		set
		{
			if (value != mAlignment)
			{
				mAlignment = value;
				mChanged = true;
				mShouldBeProcessed = true;
				ProcessAndRequest();
			}
		}
	}

	public bool applyGradient
	{
		get
		{
			return mApplyGradient;
		}
		set
		{
			//IL_003b: Expected I, but got Obj
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			if (value != mApplyGradient)
			{
				mApplyGradient = value;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v6 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe Color gradientTop
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)mGradientTop;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UILabel)+170]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_00ff: Expected VT, but got F4
			//IL_0127: Expected I, but got Obj
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected Obj, but got Unknown
			float num = (float)mGradientTop - value.r;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+16C]");
			float num3 = 0f - value.g;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+170]");
			float num6 = 0f - value.b;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+174]");
			float num9 = 0f - value.a;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mGradientTop = (Color)value.r;
				_ = value.b;
				if (~(mApplyGradient ? 1u : 0u) == 0)
				{
					nint num12 = (nint)this;
					object obj = this + 272;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S1_v23 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public unsafe Color gradientBottom
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)mGradientBottom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UILabel)+180]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_00ff: Expected VT, but got F4
			//IL_0127: Expected I, but got Obj
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected Obj, but got Unknown
			float num = (float)mGradientBottom - value.r;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+17C]");
			float num3 = 0f - value.g;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+180]");
			float num6 = 0f - value.b;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+184]");
			float num9 = 0f - value.a;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mGradientBottom = (Color)value.r;
				_ = value.b;
				if (~(mApplyGradient ? 1u : 0u) == 0)
				{
					nint num12 = (nint)this;
					object obj = this + 272;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S1_v23 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public int spacingX
	{
		get
		{
			return mSpacingX;
		}
		set
		{
			//IL_003b: Expected I, but got Obj
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			if (value != mSpacingX)
			{
				mSpacingX = value;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v6 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public int spacingY
	{
		get
		{
			return mSpacingY;
		}
		set
		{
			//IL_003b: Expected I, but got Obj
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			if (value != mSpacingY)
			{
				mSpacingY = value;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v6 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public bool useFloatSpacing
	{
		get
		{
			return mUseFloatSpacing;
		}
		set
		{
			if (value != mUseFloatSpacing)
			{
				mUseFloatSpacing = value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public float floatSpacingX
	{
		get
		{
			return mFloatSpacingX;
		}
		set
		{
			//IL_004a: Expected I, but got Obj
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected Obj, but got Unknown
			float value2 = value - mFloatSpacingX;
			float num = Math.Abs(value2);
			float num2 = Math.Abs(mFloatSpacingX);
			float num3 = Math.Abs(value);
			if (!(num2 > num3))
			{
				num2 = num3;
			}
			float num4 = num2 * 1E-06f;
			float num5 = Mathf.Epsilon * 8f;
			if (!(num4 > num5))
			{
				num4 = num5;
			}
			if (!(num < num4))
			{
				mFloatSpacingX = value;
				nint num6 = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v11 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public float floatSpacingY
	{
		get
		{
			return mFloatSpacingY;
		}
		set
		{
			//IL_004a: Expected I, but got Obj
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected Obj, but got Unknown
			float value2 = value - mFloatSpacingY;
			float num = Math.Abs(value2);
			float num2 = Math.Abs(mFloatSpacingY);
			float num3 = Math.Abs(value);
			if (!(num2 > num3))
			{
				num2 = num3;
			}
			float num4 = num2 * 1E-06f;
			float num5 = Mathf.Epsilon * 8f;
			if (!(num4 > num5))
			{
				num4 = num5;
			}
			if (!(num < num4))
			{
				mFloatSpacingY = value;
				nint num6 = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v11 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public float effectiveSpacingY
	{
		get
		{
			//IL_0027: Expected F4, but got I4
			if (~(mUseFloatSpacing ? 1u : 0u) == 0)
			{
				return mFloatSpacingY;
			}
			return mSpacingY;
		}
	}

	public float effectiveSpacingX
	{
		get
		{
			//IL_0027: Expected F4, but got I4
			if (~(mUseFloatSpacing ? 1u : 0u) == 0)
			{
				return mFloatSpacingX;
			}
			return mSpacingX;
		}
	}

	private bool keepCrisp
	{
		get
		{
			Font font = trueTypeFont;
			if (font != null)
			{
				return keepCrispWhenShrunk == Crispness.Always;
			}
			return false;
		}
	}

	public bool supportEncoding
	{
		get
		{
			return mEncoding;
		}
		set
		{
			if (value != mEncoding)
			{
				mEncoding = value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public NGUIText.SymbolStyle symbolStyle
	{
		get
		{
			return mSymbols;
		}
		set
		{
			if (value != mSymbols)
			{
				mSymbols = value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public Overflow overflowMethod
	{
		get
		{
			return mOverflow;
		}
		set
		{
			if (value != mOverflow)
			{
				mOverflow = value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public int lineWidth
	{
		get
		{
			return mWidth;
		}
		set
		{
			width = value;
		}
	}

	public int lineHeight
	{
		get
		{
			return mHeight;
		}
		set
		{
			height = value;
		}
	}

	public bool multiLine
	{
		get
		{
			return mMaxLineCount != 1;
		}
		set
		{
			bool flag = mMaxLineCount != 1;
			if (value != flag)
			{
				int num = (value ? 1 : 0) ^ 1;
				mMaxLineCount = num;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public override Vector3[] localCorners
	{
		get
		{
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				ProcessText();
			}
			return base.localCorners;
		}
	}

	public override Vector3[] worldCorners
	{
		get
		{
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				ProcessText();
			}
			return base.worldCorners;
		}
	}

	public unsafe override Vector4 drawingDimensions
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0051: Expected F4, but got I
			//IL_004c: Expected native int or pointer, but got VT
			//IL_005e: Expected F4, but got Obj
			//IL_0059: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				ProcessText();
			}
			Vector4 vector = base.drawingDimensions;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector4 vector2 = default;
			((Vector4*)(nint)vector2)->z = 0f;
			((Vector4*)(nint)vector2)->x = (float)obj;
			return vector2;
		}
	}

	public int maxLineCount
	{
		get
		{
			return mMaxLineCount;
		}
		set
		{
			//IL_0056: Expected I, but got Obj
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			if (mMaxLineCount != value)
			{
				bool flag = value > 0;
				int num = value;
				if (!flag)
				{
					num = 0;
				}
				mMaxLineCount = num;
				mChanged = true;
				mShouldBeProcessed = true;
				if (mOverflow == Overflow.ShrinkContent)
				{
					nint num2 = (nint)this;
					object obj = this + 296;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S1_v8 (Il2CppClass<UILabel>)+1E4] (should have been resolved before IL gen)");
				}
			}
		}
	}

	public Effect effectStyle
	{
		get
		{
			return mEffectStyle;
		}
		set
		{
			if (value != mEffectStyle)
			{
				mEffectStyle = value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public unsafe Color effectColor
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Color color = default;
			((Color*)(nint)color)->r = (float)mEffectColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UILabel)+148]");
			((Color*)(nint)color)->b = 0f;
			return color;
		}
		set
		{
			//IL_00ff: Expected VT, but got F4
			float num = (float)mEffectColor - value.r;
			float num2 = num * num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+144]");
			float num3 = 0f - value.g;
			float num4 = num3 * num3;
			float num5 = num2 + num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+148]");
			float num6 = 0f - value.b;
			float num7 = num6 * num6;
			float num8 = num5 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+14C]");
			float num9 = 0f - value.a;
			float num10 = num9 * num9;
			float num11 = num8 + num10;
			if (!(num11 < 9.9999994E-11f))
			{
				mEffectColor = (Color)value.r;
				_ = value.b;
				if (mEffectStyle != Effect.None)
				{
					mChanged = true;
					mShouldBeProcessed = true;
				}
			}
		}
	}

	public unsafe Vector2 effectDistance
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mEffectDistance;
			return vector;
		}
		set
		{
			//IL_0038: Expected Obj, but got F4
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			//IL_00ab: Expected VT, but got F4
			float num = (float)mEffectDistance - value.x;
			float num2 = num * num;
			object obj = value.x >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
			object obj2 = 0 - obj;
			object obj3 = obj2 * obj2;
			float num3 = num2 + (float)obj3;
			if (!(num3 < 9.9999994E-11f))
			{
				mEffectDistance = (Vector2)value.x;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public bool shrinkToFit
	{
		get
		{
			return mOverflow == Overflow.ShrinkContent;
		}
		set
		{
			if (value && mOverflow != Overflow.ShrinkContent)
			{
				mOverflow = Overflow.ShrinkContent;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public string processedText
	{
		get
		{
			int num;
			if (mWidth != mLastWidth)
			{
				num = mHeight;
			}
			else
			{
				bool flag = mHeight == mLastHeight;
				num = mHeight;
				if (flag)
				{
					if (~(mShouldBeProcessed ? 1u : 0u) == 0)
					{
						goto IL_00a6;
					}
					goto IL_00b1;
				}
			}
			mLastHeight = num;
			mLastWidth = mWidth;
			mShouldBeProcessed = true;
			goto IL_00a6;
			IL_00a6:
			ProcessText();
			goto IL_00b1;
			IL_00b1:
			return mProcessedText;
		}
	}

	public unsafe Vector2 printedSize
	{
		get
		{
			//IL_0033: Expected F4, but got VT
			//IL_002e: Expected native int or pointer, but got VT
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				ProcessText();
			}
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mCalculatedSize;
			return vector;
		}
	}

	public unsafe override Vector2 localSize
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0051: Expected F4, but got I
			//IL_004c: Expected native int or pointer, but got VT
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				ProcessText();
			}
			Vector2 vector = base.localSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			Vector2 vector2 = default;
			((Vector2*)(nint)vector2)->x = 0f;
			return vector2;
		}
	}

	private bool isValid
	{
		get
		{
			if (mFont != null)
			{
				return true;
			}
			return mTrueTypeFont != null;
		}
	}

	protected override void OnInit()
	{
		base.OnInit();
		mList.Add(this);
		Font activeFont = trueTypeFont;
		SetActiveFont(activeFont);
	}

	protected override void OnDisable()
	{
		SetActiveFont(null);
		bool flag = mList.Remove(this);
		base.OnDisable();
	}

	protected unsafe void SetActiveFont(Font fnt)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected Ref, but got Unknown
		//IL_0126: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I
		//IL_00c1: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (!(mActiveTTF != fnt))
		{
			return;
		}
		if (mActiveTTF != null && mFontUsage.TryGetValue(mActiveTTF, out *(int*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = -1;
			bool flag = (nint)obj3 > 0;
			if (!flag)
			{
				obj3 = 0;
			}
			if (!flag)
			{
				bool flag2 = mFontUsage.Remove(mActiveTTF);
			}
			else
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S5_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Font, System.Int32>>)+5C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S5_v11+4] (should have been resolved before IL gen)");
			}
		}
		mActiveTTF = fnt;
		if (mActiveTTF != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Font, System.Int32>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S5_v6+4] (should have been resolved before IL gen)");
		}
	}

	private static void OnFontChanged(Font font)
	{
		//IL_0214: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0055: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I
		//IL_016a: Expected Obj, but got I
		//IL_00e3: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01bf: Expected Obj, but got I
		object obj = default;
		object obj2;
		object obj6 = default;
		while (true)
		{
			BetterList<UILabel> betterList = mList;
			bool flag = betterList.size > (nint)obj;
			bool flag2 = !flag;
			obj2 = 0;
			if (flag2)
			{
				break;
			}
			BetterList<UILabel> betterList2 = mList;
			object obj3 = obj << 2;
			object obj4 = (object)betterList2.buffer + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v61+10]");
			UnityEngine.Object obj5 = (UnityEngine.Object)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v61+10]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v61+10]");
				Font font2 = ((UILabel)0).trueTypeFont;
				if (font2 == font)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v62 (UnityEngine.Object)+124]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v62 (UnityEngine.Object)+1D0]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v62 (UnityEngine.Object)+12C]");
					font2.RequestCharactersInTexture((string)num, (int)num2, FontStyle.Normal);
				}
			}
			obj = obj6 + 1;
		}
		while (true)
		{
			BetterList<UILabel> betterList3 = mList;
			if (betterList3.size <= (nint)obj2)
			{
				break;
			}
			BetterList<UILabel> betterList4 = mList;
			object obj7 = obj2 << 2;
			object obj8 = (object)betterList4.buffer + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v32+10]");
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v32+10]");
				Font font3 = ((UILabel)0).trueTypeFont;
				if (font3 == font)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v32+10]");
					((UIWidget)0).RemoveFromPanel();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v32+10]");
					UIPanel uIPanel = ((UIWidget)0).CreatePanel();
				}
			}
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
	}

	public override Vector3[] GetSides(Transform relativeTo)
	{
		if (~(mShouldBeProcessed ? 1u : 0u) == 0)
		{
			ProcessText();
		}
		return base.GetSides(relativeTo);
	}

	protected override void UpgradeFrom265()
	{
		ProcessText(legacyMode: true, full: true);
		if (~(mShrinkToFit ? 1u : 0u) == 0)
		{
			if (mOverflow != Overflow.ShrinkContent)
			{
				mOverflow = Overflow.ShrinkContent;
				mChanged = true;
				mShouldBeProcessed = true;
			}
			mMaxLineCount = 0;
		}
		Overflow overflow;
		if (mMaxLineWidth != 0)
		{
			width = mMaxLineWidth;
			bool flag = mMaxLineCount > 0;
			overflow = Overflow.ResizeHeight;
			if (!flag)
			{
				overflow = Overflow.ShrinkContent;
			}
		}
		else
		{
			overflow = Overflow.ResizeFreely;
		}
		if (overflow != mOverflow)
		{
			mOverflow = overflow;
			mChanged = true;
			mShouldBeProcessed = true;
		}
		if (mMaxLineHeight != 0)
		{
			height = mMaxLineHeight;
		}
		if (mFont != null)
		{
			int defaultSize = mFont.defaultSize;
			if (defaultSize > mHeight)
			{
				height = defaultSize;
			}
			fontSize = defaultSize;
		}
		mMaxLineWidth = 0;
		mShrinkToFit = false;
		GameObject go = gameObject;
		NGUITools.UpdateWidgetCollider(go, considerInactive: true);
	}

	protected override void OnAnchor()
	{
		//IL_00da: Expected Obj, but got I4
		object obj = mOverflow - 2;
		if (mOverflow != Overflow.ResizeFreely)
		{
			if ((nint)obj == 1)
			{
				AnchorPoint anchorPoint = topAnchor;
				if (anchorPoint.target != null)
				{
					AnchorPoint anchorPoint2 = bottomAnchor;
					if (anchorPoint2.target != null)
					{
						goto IL_00ba;
					}
				}
			}
		}
		else if (isFullyAnchored)
		{
			goto IL_00ba;
		}
		goto IL_00f9;
		IL_00f9:
		base.OnAnchor();
		return;
		IL_00ba:
		mOverflow = Overflow.ShrinkContent;
		goto IL_00f9;
	}

	private void ProcessAndRequest()
	{
		UnityEngine.Object obj = ambigiousFont;
		if (obj != null)
		{
			ProcessText();
		}
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		if (~(mTexRebuildAdded ? 1u : 0u) != 0)
		{
			mTexRebuildAdded = true;
			throw new ArgumentException();
		}
	}

	protected override void OnStart()
	{
		//IL_01b0: Expected I, but got Obj
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected Obj, but got Unknown
		//IL_0069: Expected I, but got Obj
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_0044: Expected F8, but got I4
		//IL_01a6: Expected I4, but got F8
		//IL_00c5: Expected I, but got Obj
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		base.OnStart();
		if (mLineWidth > 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num2 = default;
			double num = Math.Abs(num2);
			if (!(num < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			mLineWidth = 0f;
			mMaxLineWidth = (int)num2;
		}
		if (~(mMultiline ? 1u : 0u) != 0)
		{
			mMultiline = true;
			mMaxLineCount = 1;
		}
		nint num3 = (nint)this;
		object obj = this + 192;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S1_v7 (Il2CppClass<UILabel>)+17C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		bool flag = obj2 != null;
		bool flag2 = !flag;
		bool flag3 = false;
		if (!flag2)
		{
			nint num4 = (nint)this;
			object obj3 = this + 192;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S2_v9 (Il2CppClass<UILabel>)+17C] (should have been resolved before IL gen)");
			Material material = default;
			Shader shader = material.shader;
			bool flag4 = shader != null;
			bool flag5 = !flag4;
			flag3 = false;
			if (!flag5)
			{
				nint num5 = (nint)this;
				object obj4 = this + 192;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S2_v17 (Il2CppClass<UILabel>)+17C] (should have been resolved before IL gen)");
				Material material2 = default;
				Shader shader2 = material2.shader;
				string text = shader2.name;
				flag3 = text.Contains("Premultiplied");
			}
		}
		mPremultiply = flag3;
		ProcessAndRequest();
	}

	public override void MarkAsChanged()
	{
		mChanged = true;
		mShouldBeProcessed = true;
		base.MarkAsChanged();
	}

	public void ProcessText()
	{
		ProcessText(legacyMode: false, full: true);
	}

	private unsafe void ProcessText(bool legacyMode, bool full)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005d: Expected Obj, but got I
		//IL_0e5b: Invalid comparison between Obj and F4
		//IL_0e78: Expected F8, but got I4
		//IL_0921: Expected I4, but got F8
		//IL_092a: Invalid comparison between Obj and F4
		//IL_0947: Expected F8, but got I4
		//IL_0987: Expected I4, but got F8
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0a10: Expected Obj, but got I4
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected I4, but got Unknown
		//IL_0131: Expected F8, but got I4
		//IL_0183: Expected F8, but got I4
		//IL_01dd: Expected I4, but got F8
		//IL_0dcc: Expected I, but got Obj
		//IL_0df1: Expected F4, but got I
		//IL_0dec: Expected native int or pointer, but got VT
		//IL_0dff: Expected F4, but got VT
		//IL_0dfa: Expected native int or pointer, but got VT
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Ref, but got Unknown
		//IL_044e: Expected F4, but got I4
		//IL_046c: Expected F4, but got I4
		//IL_052a: Expected Obj, but got I4
		//IL_0591: Expected VT, but got I
		//IL_0596: Expected I, but got Obj
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_04e2: Expected Obj, but got I4
		//IL_073e: Expected VT, but got I
		//IL_0743: Expected I, but got Obj
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_05ea: Expected F8, but got I4
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected I4, but got Unknown
		//IL_0832: Expected VT, but got I
		//IL_0e90: Expected I4, but got F8
		//IL_0e99: Invalid comparison between Obj and F4
		//IL_0797: Expected F8, but got I4
		//IL_0b60: Expected I, but got Obj
		//IL_0b66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6b: Expected Obj, but got Unknown
		//IL_0f49: Expected I4, but got F8
		//IL_0f52: Invalid comparison between Obj and F4
		//IL_0ca9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Expected Obj, but got Unknown
		//IL_067a: Expected F8, but got I4
		//IL_063b: Expected F8, but got I4
		//IL_0807: Expected I4, but got F8
		//IL_0ee1: Expected I4, but got F8
		//IL_0eea: Invalid comparison between Obj and F4
		//IL_0baf: Expected I4, but got F8
		//IL_0870: Expected I4, but got F8
		//IL_07e8: Expected F8, but got I4
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0d00: Expected I4, but got F8
		//IL_06f4: Expected F8, but got I4
		//IL_0713: Expected I4, but got F8
		//IL_08b7: Expected I4, but got F8
		//IL_06cb: Expected F8, but got I4
		//IL_0d7b: Expected I, but got Obj
		//IL_0da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected VT, but got Unknown
		//IL_0c3a: Expected I4, but got F8
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (!isValid)
		{
			return;
		}
		mChanged = true;
		mShouldBeProcessed = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+9C]");
		object obj2 = 0 - mDrawRegion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+A0]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+98]");
		object obj3 = num - 0;
		int rectWidth;
		if (legacyMode)
		{
			rectWidth = mMaxLineWidth;
			if (mMaxLineWidth == 0)
			{
				rectWidth = 1000000;
			}
		}
		else
		{
			rectWidth = mWidth;
		}
		NGUIText.rectWidth = rectWidth;
		int rectHeight;
		if (legacyMode)
		{
			rectHeight = mMaxLineHeight;
			if (mMaxLineHeight == 0)
			{
				rectHeight = 1000000;
			}
		}
		else
		{
			rectHeight = mHeight;
		}
		NGUIText.rectHeight = rectHeight;
		bool flag = obj2 != (object)1f;
		bool flag2 = !flag;
		double num2 = NGUIText.rectWidth;
		if (!flag2)
		{
			object obj4 = NGUIText.rectWidth * obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num4 = default;
			double num3 = Math.Abs(num4);
			if (!(num3 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			num2 = num4;
		}
		NGUIText.regionWidth = (int)num2;
		bool flag3 = obj3 != (object)1f;
		bool flag4 = !flag3;
		double num5 = NGUIText.rectHeight;
		if (!flag4)
		{
			object obj5 = NGUIText.rectHeight * obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			num5 = num7;
		}
		NGUIText.regionHeight = (int)num5;
		int num10;
		if (legacyMode)
		{
			Transform transform = cachedTransform;
			Vector3 localScale = transform.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num9 = default;
			double num8 = Math.Abs(num9);
			num10 = ((!(num8 < 2147483648.0)) ? int.MinValue : ((int)num9));
		}
		else
		{
			num10 = defaultFontSize;
		}
		mScale = 1f;
		int num11 = num10 >> 31;
		object obj6 = num10 + num11;
		int num12 = obj6 ^ num11;
		mFinalFontSize = num12;
		if (NGUIText.regionWidth < 1 || NGUIText.regionHeight <= -1)
		{
			mProcessedText = string.Empty;
			return;
		}
		Font font = trueTypeFont;
		bool flag5 = font != null;
		bool flag6 = !flag5;
		float num13 = 1f;
		if (!flag6)
		{
			bool flag7 = keepCrisp;
			bool flag8 = !flag7;
			num13 = 1f;
			if (!flag8)
			{
				UIRoot uIRoot = root;
				bool flag9 = uIRoot != null;
				bool flag10 = !flag9;
				num13 = 1f;
				if (flag10)
				{
					goto IL_0a62;
				}
				bool flag11 = uIRoot != null;
				bool flag12 = !flag11;
				num13 = 1f;
				if (!flag12)
				{
					float pixelSizeAdjustment = uIRoot.pixelSizeAdjustment;
					num13 = pixelSizeAdjustment;
				}
			}
		}
		mDensity = num13;
		goto IL_0a62;
		IL_0a62:
		if (full)
		{
			UpdateNGUIText();
		}
		bool flag13 = mOverflow == Overflow.ResizeFreely;
		bool flag14 = !flag13;
		Overflow overflow = mOverflow;
		if (!flag14)
		{
			NGUIText.rectWidth = 1000000;
			NGUIText.regionWidth = 1000000;
			bool flag15 = mOverflow == Overflow.ResizeFreely;
			overflow = mOverflow;
			if (flag15)
			{
				goto IL_03c7;
			}
		}
		if (overflow == Overflow.ResizeHeight)
		{
			goto IL_03c7;
		}
		goto IL_0a7b;
		IL_0a7b:
		if (mFinalFontSize >= 1)
		{
			ref string finalText = ref *(string*)(this + 444);
			bool flag16 = keepCrisp;
			int num14 = mFinalFontSize;
			double num21 = default;
			double num22 = default;
			double num27 = default;
			double num31 = default;
			double num32 = default;
			double num36 = default;
			double num39 = default;
			double num40 = default;
			double num45 = default;
			double num49 = default;
			double num52 = default;
			while (num14 > 0)
			{
				if (flag16)
				{
					mFinalFontSize = num14;
					NGUIText.fontSize = num14;
				}
				else
				{
					int num15 = num14 / mFinalFontSize;
					mScale = num15;
					bool flag17 = !flag5;
					bool flag18 = !flag17;
					num13 = num15;
					if (!flag18)
					{
						int defaultSize = mFont.defaultSize;
						int num16 = mFontSize / defaultSize;
						float num17 = (float)num16 * mScale;
						num13 = num17;
					}
					NGUIText.fontScale = num13;
				}
				NGUIText.Update(request: false);
				bool flag19 = NGUIText.WrapText(mText, out finalText, keepCharCount: true, wrapLineColors: false);
				if (mOverflow == Overflow.ShrinkContent && !flag19)
				{
					object obj7 = num14 - 1;
					if ((nint)obj7 < 2)
					{
						break;
					}
					int num18 = obj7 - 1;
					num14 = num18;
					continue;
				}
				object obj8 = mOverflow - 2;
				if (mOverflow != Overflow.ResizeFreely)
				{
					if ((nint)obj8 == 1)
					{
						Vector2 vector2 = NGUIText.CalculatePrintedSize(mProcessedText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
						mCalculatedSize = (Vector2)0;
						nint num19 = (nint)this;
						object obj9 = this + 248;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v663 @ S1_v156 (Il2CppClass<UILabel>)+1B4] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num20 = Math.Abs(num21);
						if (!(num20 < 2147483648.0))
						{
							num21 = -2147483648.0;
						}
						bool flag20 = num22 > num21;
						double num23 = num22;
						if (!flag20)
						{
							num23 = num21;
						}
						mHeight = (int)num23;
						bool flag21 = obj3 != (object)1f;
						bool flag22 = !flag21;
						double num24 = num23;
						if (!flag22)
						{
							double num25 = num23 / (double)obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
							double num26 = Math.Abs(num27);
							if (!(num26 < 2147483648.0))
							{
								num27 = -2147483648.0;
							}
							mHeight = (int)num27;
							num24 = num27;
						}
						object obj10 = num24 & 1;
						if (obj10 != null)
						{
							double num28 = num24 + 1.0;
							mHeight = (int)num28;
						}
					}
					else
					{
						Vector2 vector3 = NGUIText.CalculatePrintedSize(mProcessedText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
						mCalculatedSize = (Vector2)0;
					}
				}
				else
				{
					Vector2 vector4 = NGUIText.CalculatePrintedSize(mProcessedText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					mCalculatedSize = (Vector2)0;
					nint num29 = (nint)this;
					object obj11 = this + 240;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v636 @ S1_v103 (Il2CppClass<UILabel>)+1AC] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num30 = Math.Abs(num31);
					if (!(num30 < 2147483648.0))
					{
						num31 = -2147483648.0;
					}
					bool flag23 = num32 > num31;
					double num33 = num32;
					if (!flag23)
					{
						num33 = num31;
					}
					mWidth = (int)num33;
					if (obj2 != (object)1f)
					{
						double num34 = num33 / (double)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num35 = Math.Abs(num36);
						if (!(num35 < 2147483648.0))
						{
							num36 = -2147483648.0;
						}
						mWidth = (int)num36;
					}
					nint num37 = (nint)this;
					object obj12 = this + 248;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v804 @ S1_v112 (Il2CppClass<UILabel>)+1B4] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num38 = Math.Abs(num39);
					if (!(num38 < 2147483648.0))
					{
						num39 = -2147483648.0;
					}
					bool flag24 = num40 > num39;
					double num41 = num40;
					if (!flag24)
					{
						num41 = num39;
					}
					mHeight = (int)num41;
					bool flag25 = obj3 != (object)1f;
					bool flag26 = !flag25;
					double num42 = num41;
					if (!flag26)
					{
						double num43 = num41 / (double)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
						double num44 = Math.Abs(num45);
						if (!(num44 < 2147483648.0))
						{
							num45 = -2147483648.0;
						}
						mHeight = (int)num45;
						num42 = num45;
					}
					if ((mWidth & 1) != 0)
					{
						int num46 = mWidth + 1;
						mWidth = num46;
						num42 = mHeight;
					}
					object obj13 = num42 & 1;
					if (obj13 != null)
					{
						double num47 = num42 + 1.0;
						mHeight = (int)num47;
					}
				}
				if (legacyMode)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num48 = Math.Abs(num49);
					int num50 = ((!(num48 < 2147483648.0)) ? int.MinValue : ((int)num49));
					width = num50;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
					double num51 = Math.Abs(num52);
					int num53 = ((!(num51 < 2147483648.0)) ? int.MinValue : ((int)num52));
					height = num53;
					Transform transform2 = cachedTransform;
					nint num54 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ S1_v84 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v977 @ S1_v85 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
					_ = 0;
					_ = Vector3.oneVector;
					Vector3 localScale2 = vector + 16;
					transform2.localScale = localScale2;
				}
				break;
			}
		}
		else
		{
			Transform transform3 = cachedTransform;
			nint num56 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num57 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S1_v49 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform3.localScale = vector;
			mProcessedText = string.Empty;
			mScale = 1f;
		}
		if (full)
		{
			NGUIText.bitmapFont = null;
			NGUIText.dynamicFont = null;
		}
		return;
		IL_03c7:
		NGUIText.rectHeight = 1000000;
		NGUIText.regionHeight = 1000000;
		goto IL_0a7b;
	}

	public unsafe override void MakePixelPerfect()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0087: Expected F8, but got I4
		//IL_00c6: Expected F8, but got I4
		//IL_0105: Expected F8, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected VT, but got Unknown
		//IL_02ef: Expected I, but got Obj
		//IL_0314: Expected F4, but got I
		//IL_030f: Expected native int or pointer, but got VT
		//IL_0322: Expected F4, but got VT
		//IL_031d: Expected native int or pointer, but got VT
		//IL_0191: Expected F8, but got I4
		//IL_01d0: Expected F8, but got I4
		//IL_03ba: Invalid comparison between F8 and I4
		//IL_04af: Invalid comparison between F8 and I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected Obj, but got Unknown
		//IL_01de: Expected F8, but got I4
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_01ec: Expected F8, but got I4
		//IL_040b: Invalid comparison between F8 and I4
		//IL_041b: Expected F8, but got I4
		//IL_04f9: Expected I4, but got F8
		//IL_0503: Invalid comparison between F8 and I4
		//IL_0513: Expected F8, but got I4
		//IL_0433: Expected I4, but got F8
		//IL_0438: Expected I, but got Obj
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		UnityEngine.Object obj2 = ambigiousFont;
		if (obj2 != null)
		{
			Transform transform = cachedTransform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value = default;
			double num = Math.Abs(value);
			if (!(num < 2147483648.0))
			{
				value = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value2 = default;
			double num2 = Math.Abs(value2);
			if (!(num2 < 2147483648.0))
			{
				value2 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value3 = default;
			double num3 = Math.Abs(value3);
			if (!(num3 < 2147483648.0))
			{
				value3 = -2147483648.0;
			}
			Transform transform2 = cachedTransform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Vector3 localPosition2 = vector + 16;
			transform2.localPosition = localPosition2;
			Transform transform3 = cachedTransform;
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S1_v31 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform3.localScale = vector;
			if (mOverflow == Overflow.ResizeFreely)
			{
				AssumeNaturalSize();
				return;
			}
			if (mOverflow != Overflow.ResizeHeight)
			{
				mWidth = 100000;
			}
			mOverflow = Overflow.ShrinkContent;
			mHeight = 100000;
			ProcessText(legacyMode: false, full: true);
			mOverflow = mOverflow;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num9 = default;
			double num8 = Math.Abs(num9);
			if (!(num8 < 2147483648.0))
			{
				num9 = -2147483648.0;
			}
			if (!(num9 > 2.0))
			{
				num9 = 2.0;
			}
			if (!(num7 > 2.0))
			{
				num7 = 2.0;
			}
			object obj3 = num7 & 1;
			bool flag = obj3 == null;
			double num10 = num7;
			if (!flag)
			{
				double num11 = num7 + 1.0;
				num10 = num11;
			}
			double num12 = num9 + 1.0;
			object obj4 = num9 & 1;
			if (obj4 == null)
			{
				num12 = num9;
			}
			bool flag2 = num12 < (double)mHeight;
			double num13 = mHeight;
			if (!flag2)
			{
				num13 = num12;
			}
			mHeight = (int)num13;
			bool flag3 = num10 < (double)mWidth;
			double num14 = mWidth;
			if (!flag3)
			{
				num14 = num10;
			}
			mWidth = (int)num14;
			nint num15 = (nint)this;
			object obj5 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v328 @ S1_v56 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
		}
		else
		{
			base.MakePixelPerfect();
		}
	}

	public void AssumeNaturalSize()
	{
		//IL_002d: Expected I4, but got I8
		//IL_007c: Expected F8, but got I4
		//IL_014c: Expected I4, but got F8
		//IL_00bb: Expected F8, but got I4
		//IL_015b: Expected I4, but got F8
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_00e4: Expected F8, but got I4
		//IL_0103: Expected I4, but got F8
		UnityEngine.Object obj = ambigiousFont;
		if (obj != null)
		{
			mWidth = 100000;
			ProcessText(legacyMode: false, full: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num2 = default;
			double num = Math.Abs(num2);
			if (!(num < 2147483648.0))
			{
				num2 = -2147483648.0;
			}
			mWidth = (int)num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num4 = default;
			double num3 = Math.Abs(num4);
			if (!(num3 < 2147483648.0))
			{
				num4 = -2147483648.0;
			}
			mHeight = (int)num4;
			int num5 = mWidth & 1;
			bool flag = num5 == 0;
			double num6 = num4;
			if (!flag)
			{
				int num7 = mWidth + 1;
				mWidth = num7;
				num6 = mHeight;
			}
			object obj2 = num6 & 1;
			if (obj2 != null)
			{
				double num8 = num6 + 1.0;
				mHeight = (int)num8;
			}
			nint num9 = (nint)this;
			object obj3 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v24 (Il2CppClass<UILabel>)+1CC] (should have been resolved before IL gen)");
		}
	}

	public unsafe int GetCharacterIndex(Vector3 worldPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		((Vector3*)(nint)vector)->z = worldPos.z;
		((Vector3*)(nint)vector)->x = worldPos.x;
		return GetCharacterIndexAtPosition(vector, precise: false);
	}

	public unsafe int GetCharacterIndex(Vector2 localPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		((Vector2*)(nint)vector)->x = localPos.x;
		_ = localPos.x;
		return GetCharacterIndexAtPosition(vector, precise: false);
	}

	public unsafe int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected VT, but got Unknown
		//IL_0072: Expected F4, but got I
		//IL_006d: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 48);
		Transform transform = cachedTransform;
		_ = worldPos.z;
		_ = worldPos.x;
		Vector3 position = (Vector3)(vector + 8);
		Vector3 vector2 = transform.InverseTransformPoint(position);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		((Vector2*)(nint)vector)->x = 0f;
		return GetCharacterIndexAtPosition(vector, precise);
	}

	public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected VT, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		if (!isValid)
		{
			goto IL_01f9;
		}
		string text = processedText;
		object obj3;
		if (text != null)
		{
			obj3 = 0;
			if (text._stringLength != 0)
			{
				goto IL_01fe;
			}
		}
		obj3 = 1;
		goto IL_01fe;
		IL_01fe:
		int result = default;
		if (obj3 == null)
		{
			UpdateNGUIText();
			if (precise)
			{
				NGUIText.PrintExactCharacterPositions(text, mTempVerts, mTempIndices);
			}
			else
			{
				NGUIText.PrintApproximateCharacterPositions(text, mTempVerts, mTempIndices);
			}
			BetterList<Vector3> betterList = mTempVerts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v38 (BetterList`1<UnityEngine.Vector3>)+C]");
			bool flag = (nint)0 >= (nint)1;
			bool flag2 = !flag;
			result = 0;
			if (!flag2)
			{
				Vector2 vector = ApplyOffset(mTempVerts, 0);
				int num;
				if (precise)
				{
					_ = localPos.x;
					_ = localPos.x;
					Vector2 pos = (Vector2)(obj + 8);
					num = NGUIText.GetExactCharacterIndex(mTempVerts, mTempIndices, pos);
				}
				else
				{
					_ = localPos.x;
					_ = localPos.x;
					Vector2 pos2 = (Vector2)(obj + 16);
					num = NGUIText.GetApproximateCharacterIndex(mTempVerts, mTempIndices, pos2);
				}
				BetterList<Vector3> betterList2 = mTempVerts;
				_ = 0;
				BetterList<int> betterList3 = mTempIndices;
				_ = 0;
				result = num;
			}
			NGUIText.bitmapFont = null;
			NGUIText.dynamicFont = null;
		}
		goto IL_01f9;
		IL_01f9:
		return result;
	}

	public unsafe string GetWordAtPosition(Vector3 worldPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		((Vector3*)(nint)vector)->z = worldPos.z;
		((Vector3*)(nint)vector)->x = worldPos.x;
		int characterIndexAtPosition = GetCharacterIndexAtPosition(vector, precise: true);
		return GetWordAtCharacterIndex(characterIndexAtPosition);
	}

	public unsafe string GetWordAtPosition(Vector2 localPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		((Vector2*)(nint)vector)->x = localPos.x;
		_ = localPos.x;
		int characterIndexAtPosition = GetCharacterIndexAtPosition(vector, precise: true);
		return GetWordAtCharacterIndex(characterIndexAtPosition);
	}

	public string GetWordAtCharacterIndex(int characterIndex)
	{
		bool flag = characterIndex == -1;
		string result = null;
		if (!flag)
		{
			string text = mText;
			bool flag2 = text._stringLength <= characterIndex;
			result = null;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				char[] array = default;
				array[0] = ' ';
				array[1] = '\n';
				int num = text.LastIndexOfAny(array, characterIndex);
				int num2 = num + 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				Array array2 = default;
				RuntimeHelpers.InitializeArray(array2, __ldtoken(_003CPrivateImplementationDetails_003E.A553BADB17A168A36B44DA9D26F99CB2EEC465BFD5E69C5D695D0F2F66629EF5));
				int num3 = mText.IndexOfAny((char[])array2, characterIndex);
				bool flag3 = num3 == -1;
				bool flag4 = !flag3;
				int num4 = num3;
				if (!flag4)
				{
					string text2 = mText;
					num4 = text2._stringLength;
				}
				bool flag5 = num4 == num2;
				result = null;
				if (!flag5)
				{
					int num5 = num4 - num2;
					bool flag6 = num5 < 1;
					result = null;
					if (!flag6)
					{
						string text3 = mText.Substring(num2, num5);
						string text4 = NGUIText.StripSymbols(text3);
						result = text4;
					}
				}
			}
		}
		return result;
	}

	public unsafe string GetUrlAtPosition(Vector3 worldPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		((Vector3*)(nint)vector)->z = worldPos.z;
		((Vector3*)(nint)vector)->x = worldPos.x;
		int characterIndexAtPosition = GetCharacterIndexAtPosition(vector, precise: true);
		return GetUrlAtCharacterIndex(characterIndexAtPosition);
	}

	public unsafe string GetUrlAtPosition(Vector2 localPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj - 16);
		((Vector2*)(nint)vector)->x = localPos.x;
		_ = localPos.x;
		int characterIndexAtPosition = GetCharacterIndexAtPosition(vector, precise: true);
		return GetUrlAtCharacterIndex(characterIndexAtPosition);
	}

	public string GetUrlAtCharacterIndex(int characterIndex)
	{
		//IL_0022: Expected Obj, but got I4
		int num;
		if (characterIndex != -1)
		{
			string text = mText;
			object obj = text._stringLength - 6;
			if (characterIndex < (nint)obj)
			{
				char c = mText.get_Chars(characterIndex);
				if (c == '[')
				{
					int index = characterIndex + 1;
					char c2 = mText.get_Chars(index);
					if (c2 == 'u')
					{
						int index2 = characterIndex + 2;
						char c3 = mText.get_Chars(index2);
						if (c3 == 'r')
						{
							int index3 = characterIndex + 3;
							char c4 = mText.get_Chars(index3);
							if (c4 == 'l')
							{
								int index4 = characterIndex + 4;
								char c5 = mText.get_Chars(index4);
								bool flag = c5 == '=';
								num = characterIndex;
								if (flag)
								{
									goto IL_01ba;
								}
							}
						}
					}
				}
				int num2 = mText.LastIndexOf("[url=", characterIndex);
				bool flag2 = num2 == -1;
				num = num2;
				if (!flag2)
				{
					goto IL_01ba;
				}
			}
		}
		goto IL_0297;
		IL_0297:
		string result = default;
		return result;
		IL_01ba:
		int num3 = num + 5;
		int num4 = mText.IndexOf("]", num3);
		if (num4 != -1)
		{
			int num5 = mText.IndexOf("[/url]", num4);
			bool flag3 = num5 != -1;
			if (characterIndex <= num5)
			{
				flag3 = false;
			}
			if (!flag3)
			{
				int length = num4 - num3;
				return mText.Substring(num3, length);
			}
		}
		goto IL_0297;
	}

	public unsafe int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005f: Expected Obj, but got I4
		//IL_0043: Expected Obj, but got I4
		//IL_0557: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I4
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected Obj, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I4
		//IL_05e8: Expected Obj, but got I4
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_060d: Expected F4, but got I
		//IL_0311: Expected I4, but got F4
		//IL_05bf: Expected F4, but got I
		//IL_05ba: Expected native int or pointer, but got VT
		//IL_01f7: Expected F4, but got I
		//IL_0207: Expected Obj, but got I
		//IL_0627: Expected Obj, but got I4
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected Obj, but got Unknown
		//IL_064c: Expected F4, but got I
		//IL_0348: Expected I4, but got F4
		//IL_0234: Expected F4, but got I
		//IL_0244: Expected Obj, but got I
		//IL_0271: Expected F4, but got I
		//IL_0281: Expected Obj, but got I
		//IL_038c: Expected Obj, but got I
		//IL_03c1: Expected Obj, but got I
		//IL_02d9: Expected F4, but got I
		//IL_02e9: Expected Obj, but got I
		object obj = default;
		Vector2 vector = (Vector2)(obj - 32);
		if (!isValid)
		{
			goto IL_04e4;
		}
		string text = processedText;
		object obj2;
		if (text != null)
		{
			obj2 = 0;
			if (text._stringLength != 0)
			{
				goto IL_0526;
			}
		}
		obj2 = 1;
		goto IL_0526;
		IL_0659:
		int result;
		return result;
		IL_014a:
		BetterList<Vector3> betterList = mTempVerts;
		object obj4;
		object obj3 = obj4 * 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v39 (BetterList`1<UnityEngine.Vector3>)+8]");
		object obj5 = 0 + obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v41+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S1_v41+10]");
		_ = 0;
		object obj6 = key - 273;
		int num5;
		if (key != KeyCode.UpArrow)
		{
			if ((nint)obj6 != 1)
			{
				bool flag = (nint)obj6 == 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
				float num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
				object obj7 = 0;
				if (!flag)
				{
					bool flag2 = (nint)obj6 == 3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
					num = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
					obj7 = 0;
					if (!flag2)
					{
						bool flag3 = (nint)obj6 == 4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
						num = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
						obj7 = 0;
						if (!flag3)
						{
							if ((nint)obj6 != 5)
							{
								if ((nint)obj6 != 6)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
									num = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
									obj7 = 0;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
									float num2 = 0f + 1000f;
									num = num2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
									obj7 = 0;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
								float num3 = 0f - 1000f;
								num = num3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
								obj7 = 0;
							}
						}
					}
				}
			}
			else
			{
				int num4 = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingY : ((int)mFloatSpacingY));
				object obj8 = num5 + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
				object obj9 = 0 - obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
				float num = 0f;
				object obj7 = obj9;
			}
		}
		else
		{
			int num6 = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingY : ((int)mFloatSpacingY));
			object obj10 = num5 + num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+14]");
			object obj11 = 0 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+10]");
			float num = 0f;
			object obj7 = obj11;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+8]");
		((Vector2*)(nint)vector)->x = 0f;
		int approximateCharacterIndex = NGUIText.GetApproximateCharacterIndex(mTempVerts, mTempIndices, vector);
		if (approximateCharacterIndex == currentIndex)
		{
			goto IL_057d;
		}
		BetterList<Vector3> betterList2 = mTempVerts;
		_ = 0;
		BetterList<int> betterList3 = mTempIndices;
		_ = 0;
		result = approximateCharacterIndex;
		goto IL_0659;
		IL_04e4:
		result = currentIndex;
		goto IL_0659;
		IL_0526:
		result = 0;
		if (obj2 == null)
		{
			num5 = defaultFontSize;
			UpdateNGUIText();
			NGUIText.PrintApproximateCharacterPositions(text, mTempVerts, mTempIndices);
			BetterList<Vector3> betterList4 = mTempVerts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v39 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 < (nint)1)
			{
				goto IL_053d;
			}
			Vector2 vector2 = ApplyOffset(mTempVerts, 0);
			obj4 = 0;
			while (true)
			{
				BetterList<int> betterList5 = mTempIndices;
				object obj12 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v23 (BetterList`1<System.Int32>)+C]");
				if ((nint)obj12 >= 0)
				{
					break;
				}
				BetterList<int> betterList6 = mTempIndices;
				object obj13 = obj4 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v31 (BetterList`1<System.Int32>)+8]");
				object obj14 = 0 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v33+10]");
				if ((nint)currentIndex == 0)
				{
					goto IL_014a;
				}
				object obj15 = obj4 + 1;
				obj4 = obj15;
			}
			goto IL_057d;
		}
		goto IL_0659;
		IL_057d:
		BetterList<Vector3> betterList7 = mTempVerts;
		_ = 0;
		BetterList<int> betterList8 = mTempIndices;
		_ = 0;
		goto IL_053d;
		IL_04f1:
		result = text._stringLength;
		goto IL_0659;
		IL_053d:
		NGUIText.bitmapFont = null;
		NGUIText.dynamicFont = null;
		object obj16 = key - 273;
		bool flag4 = key == KeyCode.UpArrow;
		result = 0;
		if (!flag4)
		{
			if ((nint)obj16 != 1)
			{
				if ((nint)obj16 != 2 && (nint)obj16 != 3 && (nint)obj16 != 4)
				{
					bool flag5 = (nint)obj16 == 5;
					result = 0;
					if (flag5)
					{
						goto IL_0659;
					}
					if ((nint)obj16 == 6)
					{
						goto IL_04f1;
					}
				}
				goto IL_04e4;
			}
			goto IL_04f1;
		}
		goto IL_0659;
	}

	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected Obj, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected VT, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected VT, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected VT, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 80;
		caret?.Clear();
		highlight?.Clear();
		if (!isValid)
		{
			return;
		}
		string text = processedText;
		UpdateNGUIText();
		BetterList<Vector3> verts = caret.verts;
		if (start != end && highlight != null)
		{
			BetterList<Vector3> verts2 = highlight.verts;
			NGUIText.PrintCaretAndSelection(text, start, end, caret.verts, highlight.verts);
			BetterList<Vector3> verts3 = highlight.verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v104 (BetterList`1<UnityEngine.Vector3>)+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v98 (BetterList`1<UnityEngine.Vector3>)+C]");
			if (num > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v98 (BetterList`1<UnityEngine.Vector3>)+C]");
				Vector2 vector = ApplyOffset(verts3, 0);
				float num2 = highlightColor.a * finalAlpha;
				float num3 = Math.Min(highlightColor.r, 1f);
				bool flag = highlightColor.r < 0f;
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				float num5 = num4 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num6 = Math.Min(highlightColor.g, 1f);
				bool flag2 = highlightColor.g < 0f;
				float num7 = 0f;
				if (!flag2)
				{
					num7 = num6;
				}
				float num8 = num7 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num9 = Math.Min(highlightColor.b, 1f);
				bool flag3 = highlightColor.b < 0f;
				float num10 = 0f;
				if (!flag3)
				{
					num10 = num9;
				}
				float num11 = num10 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num12 = Math.Min(num2, 1f);
				bool flag4 = num2 < 0f;
				float num13 = 0f;
				if (!flag4)
				{
					num13 = num12;
				}
				float num14 = num13 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj4 = default;
				object obj3 = obj4 & 0xFF;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj6 = default;
				object obj5 = obj6 << 8;
				object obj7 = obj5 & 0xFF00;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj9 = default;
				object obj8 = obj9 << 16;
				object obj10 = obj8 & 0xFF0000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj12 = default;
				object obj11 = obj12 << 24;
				object obj13 = obj10 | obj11;
				object obj14 = obj7 | obj13;
				object obj15 = obj3 | obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v98 (BetterList`1<UnityEngine.Vector3>)+C]");
				int num15 = 0;
				while (true)
				{
					BetterList<Vector3> verts4 = highlight.verts;
					int num16 = num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S1_v74 (BetterList`1<UnityEngine.Vector3>)+C]");
					if ((nint)num16 >= (nint)0)
					{
						break;
					}
					_ = 4539628425446424576L;
					_ = 4539628425446424576L;
					Vector2 item = (Vector2)(obj + 32);
					highlight.uvs.Add(item);
					Color32 item2 = (Color32)(obj + 28);
					highlight.cols.Add(item2);
					int num17 = num15 + 1;
					num15 = num17;
				}
			}
		}
		else
		{
			NGUIText.PrintCaretAndSelection(text, start, end, caret.verts, null);
		}
		BetterList<Vector3> verts5 = caret.verts;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v22 (BetterList`1<UnityEngine.Vector3>)+C]");
		Vector2 vector2 = ApplyOffset(verts5, 0);
		float num18 = caretColor.a * finalAlpha;
		float num19 = Math.Min(caretColor.r, 1f);
		bool flag5 = caretColor.r < 0f;
		float num20 = 0f;
		if (!flag5)
		{
			num20 = num19;
		}
		float num21 = num20 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num22 = Math.Min(caretColor.g, 1f);
		bool flag6 = caretColor.g < 0f;
		float num23 = 0f;
		if (!flag6)
		{
			num23 = num22;
		}
		float num24 = num23 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num25 = Math.Min(caretColor.b, 1f);
		bool flag7 = caretColor.b < 0f;
		float num26 = 0f;
		if (!flag7)
		{
			num26 = num25;
		}
		float num27 = num26 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num28 = Math.Min(num18, 1f);
		bool flag8 = num18 < 0f;
		float num29 = 0f;
		if (!flag8)
		{
			num29 = num28;
		}
		float num30 = num29 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj17 = default;
		object obj16 = obj17 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj19 = default;
		object obj18 = obj19 << 8;
		object obj20 = obj18 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj22 = default;
		object obj21 = obj22 << 16;
		object obj23 = obj21 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj25 = default;
		object obj24 = obj25 << 24;
		object obj26 = obj23 | obj24;
		object obj27 = obj20 | obj26;
		object obj28 = obj16 | obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v22 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num31 = 0;
		while (true)
		{
			BetterList<Vector3> verts6 = caret.verts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v62 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 <= (nint)num31)
			{
				break;
			}
			_ = 4539628425446424576L;
			_ = 4539628425446424576L;
			Vector2 item3 = (Vector2)(obj + 16);
			caret.uvs.Add(item3);
			Color32 item4 = (Color32)(obj + 12);
			caret.cols.Add(item4);
			int num32 = num31 + 1;
			num31 = num32;
		}
		NGUIText.bitmapFont = null;
		NGUIText.dynamicFont = null;
	}

	public unsafe override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003d: Expected F4, but got VT
		//IL_0057: Expected F4, but got I
		//IL_0067: Expected F4, but got I
		//IL_0099: Expected F4, but got VT
		//IL_00b3: Expected F4, but got I
		//IL_00c3: Expected F4, but got I
		//IL_01d1: Expected I, but got Obj
		//IL_01f9: Expected VT, but got F4
		//IL_00fa: Expected F4, but got I
		//IL_00f5: Expected native int or pointer, but got VT
		//IL_0123: Expected F4, but got I
		//IL_011e: Expected native int or pointer, but got VT
		//IL_0145: Expected F4, but got I
		//IL_0155: Expected F4, but got I
		//IL_0165: Expected F4, but got I
		//IL_0175: Expected F4, but got I
		//IL_02ff: Expected F4, but got VT
		//IL_030f: Expected Obj, but got I4
		//IL_038b: Expected F4, but got I
		//IL_03c7: Expected F4, but got I
		//IL_03c7: Expected F4, but got VT
		//IL_04d4: Expected F4, but got VT
		//IL_0514: Expected F4, but got I
		object obj = default;
		Color color = (Color)(obj - 48);
		if (!isValid)
		{
			return;
		}
		bool flag = mFont != null;
		bool flag2 = !flag;
		float num = (float)mColor;
		float num2 = finalAlpha;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+50]");
		float value = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+54]");
		float value2 = 0f;
		if (!flag2)
		{
			bool premultipliedAlphaShader = mFont.premultipliedAlphaShader;
			bool flag3 = !premultipliedAlphaShader;
			num = (float)mColor;
			num2 = finalAlpha;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+50]");
			value = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+54]");
			value2 = 0f;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+54]");
				_ = 0;
				_ = finalAlpha;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+50]");
				_ = 0;
				_ = mColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
				((Color*)(nint)color)->r = 0f;
				Color color2 = NGUITools.ApplyPMA(color);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
				num = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2C]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+24]");
				value = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
				value2 = 0f;
			}
		}
		ColorSpace activeColorSpace = QualitySettings.activeColorSpace;
		if (activeColorSpace == ColorSpace.Linear)
		{
			float num3 = Mathf.GammaToLinearSpace(num);
			float num4 = Mathf.GammaToLinearSpace(value);
			float num5 = Mathf.GammaToLinearSpace(value2);
			num = num3;
			value = num4;
			value2 = num5;
		}
		string text = processedText;
		UpdateNGUIText();
		nint num6 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v43 (Il2CppClass<NGUIText>)+5C]");
		nint num7 = 0;
		NGUIText.tint = (Color)num;
		NGUIText.Print(text, verts, uvs, cols);
		NGUIText.bitmapFont = null;
		NGUIText.dynamicFont = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
		Vector2 vector = ApplyOffset(verts, 0);
		if (mFont != null && mFont.packedFontShader)
		{
			return;
		}
		bool flag4 = mEffectStyle == Effect.None;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
		int num8 = 0;
		if (!flag4)
		{
			float num9 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
			float y = num9 - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
			ApplyShadow(verts, uvs, cols, (int)num10, 0, (float)mEffectDistance, y);
			object obj2 = mEffectStyle & (Effect)(-2);
			bool flag5 = (nint)obj2 != 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
			num8 = 0;
			if (!flag5)
			{
				float x = 0f - (float)mEffectDistance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
				ApplyShadow(verts, uvs, cols, (int)num11, (int)num12, x, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				nint num13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				nint num14 = 0;
				Vector2 vector2 = mEffectDistance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
				ApplyShadow(verts, uvs, cols, (int)num13, (int)num14, (float)vector2, 0f);
				float x2 = 0f - (float)mEffectDistance;
				float num15 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
				float y2 = num15 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				ApplyShadow(verts, uvs, cols, (int)num16, 0, x2, y2);
				bool flag6 = mEffectStyle != Effect.Outline8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
				num8 = 0;
				if (!flag6)
				{
					float x3 = 0f - (float)mEffectDistance;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					ApplyShadow(verts, uvs, cols, (int)num17, 0, x3, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					ApplyShadow(verts, uvs, cols, (int)num18, 0, (float)mEffectDistance, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
					ApplyShadow(verts, uvs, cols, (int)num19, (int)num20, 0f, 0f);
					float num21 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+158]");
					float y3 = num21 - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					ApplyShadow(verts, uvs, cols, (int)num22, 0, 0f, y3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+C]");
					num8 = 0;
				}
			}
		}
		OnPostFillCallback onPostFillCallback = onPostFill;
		if (onPostFill != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v291.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public unsafe Vector2 ApplyOffset(BetterList<Vector3> verts, int start)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0040: Expected F4, but got I
		//IL_005a: Invalid comparison between I and F4
		//IL_018f: Expected Obj, but got I
		//IL_01dc: Expected Obj, but got I4
		//IL_0202: Expected F4, but got I
		//IL_0217: Invalid comparison between I and F4
		//IL_0141: Expected native int or pointer, but got VT
		//IL_014e: Expected native int or pointer, but got VT
		//IL_009f: Expected Obj, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00d9: Expected Obj, but got F4
		//IL_00e7: Expected Obj, but got I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Vector2 vector = pivotOffset;
		float num = 0f - (float)mHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		float num2 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		bool flag = 0f < 0f;
		float num3 = 0f;
		if (!flag)
		{
			num3 = num2;
		}
		float num4 = num * num3;
		float num5 = (float)mHeight + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UILabel)+1C8]");
		object obj3 = -mHeight;
		float num6 = 0f - (float)obj3;
		float num7 = num6 * num3;
		float num8 = (float)obj3 + num7;
		float num9 = num5 + num8;
		object obj4 = -mWidth;
		float num10 = (float)obj4 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num11 = Math.Min(0f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		bool flag2 = 0f < 0f;
		float num12 = 0f;
		if (!flag2)
		{
			num12 = num11;
		}
		float num13 = num10 * num12;
		float num14 = num13 + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		int num15 = default;
		int num16 = default;
		float num18 = default;
		float num20 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L2 (BetterList`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 <= (nint)num15)
			{
				break;
			}
			object obj5 = num16 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L2 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj6 = 0 + obj5;
			object obj7 = obj6 + 16;
			float num17 = (float)obj7 + num18;
			obj7 = num17;
			object obj8 = num16 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L2 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj9 = 0 + obj8;
			object obj10 = obj9 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v32+4]");
			float num19 = 0f + num20;
			num15 = num16 + 1;
		}
		Vector2 vector2 = default;
		((Vector2*)(nint)vector2)->y = num20;
		((Vector2*)(nint)vector2)->x = num18;
		return vector2;
	}

	public void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_072b: Expected F4, but got VT
		//IL_073b: Expected F4, but got I
		//IL_074b: Expected F4, but got I
		//IL_0037: Expected F4, but got VT
		//IL_0047: Expected F4, but got I
		//IL_0057: Expected F4, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected VT, but got Unknown
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_00dd: Expected F4, but got I
		//IL_00ed: Expected F4, but got I
		//IL_00fd: Expected F4, but got I
		//IL_010d: Expected F4, but got I
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I4
		//IL_01e8: Expected Obj, but got I4
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected VT, but got Unknown
		//IL_0280: Expected Obj, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected VT, but got Unknown
		//IL_02ea: Expected Obj, but got I
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected VT, but got Unknown
		//IL_033a: Expected Obj, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_03d6: Expected Obj, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected Obj, but got Unknown
		//IL_0428: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_0526: Expected F4, but got I
		//IL_0536: Expected F4, but got I
		//IL_0548: Expected F4, but got VT
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected VT, but got Unknown
		//IL_05bd: Expected F4, but got I
		//IL_05cd: Expected F4, but got I
		//IL_05dd: Expected F4, but got I
		//IL_05ed: Expected F4, but got I
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a43: Expected Obj, but got Unknown
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected Obj, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected Obj, but got Unknown
		//IL_06d9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 224;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+14C]");
		float num = 0f * finalAlpha;
		bool flag = mFont != null;
		bool flag2 = !flag;
		float num2 = (float)mEffectColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+144]");
		float num3 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+148]");
		float num4 = 0f;
		float num5 = num;
		if (!flag2)
		{
			bool premultipliedAlphaShader = mFont.premultipliedAlphaShader;
			bool flag3 = !premultipliedAlphaShader;
			num2 = (float)mEffectColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+144]");
			num3 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+148]");
			num4 = 0f;
			num5 = num;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+148]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+144]");
				_ = 0;
				_ = mEffectColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
				_ = 0;
				Color c = (Color)(obj + 72);
				Color color = NGUITools.ApplyPMA(c);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
				num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
				num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
				num4 = 0f;
			}
		}
		float num6 = Math.Min(num2, 1f);
		bool flag4 = num2 < 0f;
		float num7 = 0f;
		if (!flag4)
		{
			num7 = num6;
		}
		float num8 = num7 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num9 = Math.Min(num3, 1f);
		bool flag5 = num3 < 0f;
		float num10 = 0f;
		if (!flag5)
		{
			num10 = num9;
		}
		float num11 = num10 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num12 = Math.Min(num4, 1f);
		bool flag6 = num4 < 0f;
		float num13 = 0f;
		if (!flag6)
		{
			num13 = num12;
		}
		float num14 = num13 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num15 = Math.Min(num5, 1f);
		bool flag7 = num5 < 0f;
		float num16 = 0f;
		if (!flag7)
		{
			num16 = num15;
		}
		float num17 = num16 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj4 = default;
		object obj3 = obj4 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj6 = default;
		object obj5 = obj6 << 8;
		object obj7 = obj5 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj9 = default;
		object obj8 = obj9 << 16;
		object obj10 = obj8 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj12 = default;
		object obj11 = obj12 << 24;
		object obj13 = obj10 | obj11;
		object obj14 = obj7 | obj13;
		object obj15 = obj3 | obj14;
		object obj16 = 24;
		int num18 = default;
		object obj29 = default;
		object obj31 = default;
		object obj34 = default;
		object obj36 = default;
		int num44 = default;
		while (num18 < end)
		{
			object obj17 = num18 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj18 = 0 + obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v32+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v32+10]");
			_ = 0;
			object obj19 = obj - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
			_ = 0;
			Vector3 item = (Vector3)(obj + 56);
			verts.Add(item);
			int num19 = num18 << 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [uvs @ L2 (BetterList`1<UnityEngine.Vector2>)+8]");
			object obj20 = (nint)0 + (nint)num19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S1_v45+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
			_ = 0;
			Vector2 item2 = (Vector2)(obj + 48);
			uvs.Add(item2);
			int num20 = num18 << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (BetterList`1<UnityEngine.Color32>)+8]");
			object obj21 = (nint)0 + (nint)num20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S1_v54+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A8]");
			_ = 0;
			Color32 item3 = (Color32)(obj + 44);
			cols.Add(item3);
			object obj22 = num18 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj23 = 0 + obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v63+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S1_v63+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
			float num21 = 0f + x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+94]");
			float num22 = 0f + y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
			_ = 0;
			object obj24 = num18 * 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (BetterList`1<UnityEngine.Vector3>)+8]");
			object obj25 = 0 + obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
			_ = 0;
			int num23 = num18 << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (BetterList`1<UnityEngine.Color32>)+8]");
			object obj26 = (nint)0 + (nint)num23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S1_v85+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7B]");
			if ((nint)0 == 255)
			{
				int num24 = num18 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (BetterList`1<UnityEngine.Color32>)+8]");
				object obj27 = (nint)0 + (nint)num24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
				_ = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+7B]");
				float num25 = 0f / 255f;
				float num26 = num25 * num;
				float num27;
				float num28;
				float num29;
				float num30;
				if (!(mFont != null) || !mFont.premultipliedAlphaShader)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+144]");
					num27 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+148]");
					num28 = 0f;
					num29 = num26;
					num30 = (float)mEffectColor;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+148]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+144]");
					_ = 0;
					_ = mEffectColor;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
					_ = 0;
					Color c2 = (Color)(obj + 16);
					Color color = NGUITools.ApplyPMA(c2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D0]");
					num30 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D4]");
					num27 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+D8]");
					num28 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+DC]");
					num29 = 0f;
				}
				float num31 = Math.Min(num30, 1f);
				bool flag8 = num30 < 0f;
				float num32 = 0f;
				if (!flag8)
				{
					num32 = num31;
				}
				float num33 = num32 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num34 = Math.Min(num27, 1f);
				bool flag9 = num27 < 0f;
				float num35 = 0f;
				if (!flag9)
				{
					num35 = num34;
				}
				float num36 = num35 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num37 = Math.Min(num28, 1f);
				bool flag10 = num28 < 0f;
				float num38 = 0f;
				if (!flag10)
				{
					num38 = num37;
				}
				float num39 = num38 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				float num40 = Math.Min(num29, 1f);
				bool flag11 = num29 < 0f;
				float num41 = 0f;
				if (!flag11)
				{
					num41 = num40;
				}
				float num42 = num41 * 255f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj28 = obj29 & 0xFF;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj30 = obj31 << 8;
				object obj32 = obj30 & 0xFF00;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				object obj33 = obj34 << 16;
				object obj35 = obj33 & 0xFF0000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
				obj16 = obj36 << 24;
				object obj37 = obj35 | obj16;
				object obj38 = obj32 | obj37;
				object obj39 = obj28 | obj38;
				int num43 = num18 << 2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (BetterList`1<UnityEngine.Color32>)+8]");
				object obj40 = (nint)0 + (nint)num43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
				_ = 0;
			}
			num18 = num44 + 1;
		}
	}

	public int CalculateOffsetToFit(string text)
	{
		UpdateNGUIText();
		NGUIText.encoding = false;
		NGUIText.symbolStyle = NGUIText.SymbolStyle.None;
		int result = NGUIText.CalculateOffsetToFit(text);
		NGUIText.bitmapFont = null;
		NGUIText.dynamicFont = null;
		return result;
	}

	public unsafe void SetCurrentProgress()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected Ref, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		if (UIProgressBar.current != null)
		{
			float value = UIProgressBar.current.value;
			float num = (float)obj + 12f;
			string text = ((float*)num)->ToString("F");
			this.text = text;
		}
	}

	public unsafe void SetCurrentPercent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0070: Expected F8, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (UIProgressBar.current != null)
		{
			float value = UIProgressBar.current.value;
			float num = value * 100f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value2 = default;
			double num2 = Math.Abs(value2);
			if (!(num2 < 2147483648.0))
			{
				value2 = -2147483648.0;
			}
			int num3 = obj + 12;
			string text = ((int*)num3)->ToString();
			string text2 = text + "%";
			this.text = text2;
		}
	}

	public void SetCurrentSelection()
	{
		if (UIPopupList.current != null)
		{
			UIPopupList current = UIPopupList.current;
			UIPopupList current2 = UIPopupList.current;
			bool flag = (byte)(~(current2.isLocalized ? 1u : 0u)) != 0;
			string text = current.mSelectedItem;
			if (!flag)
			{
				string text2 = Localization.Get(current.mSelectedItem);
				text = text2;
			}
			this.text = text;
		}
	}

	public bool Wrap(string text, out string final)
	{
		return Wrap(text, out final, 1000000);
	}

	public bool Wrap(string text, out string final, int height)
	{
		UpdateNGUIText();
		NGUIText.rectHeight = height;
		NGUIText.regionHeight = height;
		bool result = NGUIText.WrapText(text, out final);
		NGUIText.bitmapFont = null;
		NGUIText.dynamicFont = null;
		return result;
	}

	public void UpdateNGUIText()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_00a4: Expected F8, but got I4
		//IL_04b0: Expected I4, but got F8
		//IL_04cd: Expected Obj, but got I
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected Obj, but got Unknown
		//IL_00e3: Expected F8, but got I4
		//IL_04ea: Expected I4, but got F8
		//IL_0537: Expected I, but got Obj
		//IL_0565: Expected VT, but got I
		//IL_057c: Expected Obj, but got VT
		//IL_058a: Expected I, but got Obj
		//IL_05b0: Expected VT, but got Obj
		//IL_05fe: Expected F4, but got I4
		//IL_0148: Expected I4, but got F4
		//IL_0620: Expected F4, but got I4
		//IL_0166: Expected I4, but got F4
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected Obj, but got Unknown
		//IL_0452: Expected Obj, but got I4
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0468: Expected I4, but got Obj
		//IL_03d6: Expected F8, but got I4
		//IL_070a: Expected I4, but got F8
		//IL_0727: Expected Obj, but got I
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected Obj, but got Unknown
		//IL_0415: Expected F8, but got I4
		//IL_0744: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 32;
		Font font = trueTypeFont;
		bool flag = font != null;
		NGUIText.fontSize = mFinalFontSize;
		NGUIText.fontStyle = mFontStyle;
		NGUIText.rectWidth = mWidth;
		NGUIText.rectHeight = mHeight;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+9C]");
		object obj3 = 0 - mDrawRegion;
		object obj4 = mWidth * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		if (!(num < 2147483648.0))
		{
			num2 = -2147483648.0;
		}
		NGUIText.regionWidth = (int)num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+A0]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+98]");
		object obj5 = num3 - 0;
		object obj6 = mHeight * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num5 = default;
		double num4 = Math.Abs(num5);
		if (!(num4 < 2147483648.0))
		{
			num5 = -2147483648.0;
		}
		NGUIText.regionHeight = (int)num5;
		bool flag2 = (byte)(~(mApplyGradient ? 1u : 0u)) != 0;
		bool gradient = false;
		if (!flag2)
		{
			bool flag3 = mFont != null;
			gradient = true;
			if (flag3)
			{
				bool packedFontShader = mFont.packedFontShader;
				bool flag4 = (byte)((packedFontShader ? 1u : 0u) ^ 1u) != 0;
				gradient = flag4;
			}
		}
		NGUIText.gradient = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+170]");
		_ = 0;
		_ = mGradientTop;
		nint num6 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v76 (Il2CppClass<NGUIText>)+5C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		NGUIText.gradientTop = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+180]");
		_ = 0;
		obj = mGradientBottom;
		nint num8 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v82 (Il2CppClass<NGUIText>)+5C]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		NGUIText.gradientBottom = (Color)obj;
		NGUIText.encoding = mEncoding;
		NGUIText.premultiply = mPremultiply;
		NGUIText.symbolStyle = mSymbols;
		NGUIText.maxLines = mMaxLineCount;
		int num10 = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingX : ((int)mFloatSpacingX));
		NGUIText.spacingX = num10;
		int num11 = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingY : ((int)mFloatSpacingY));
		NGUIText.spacingY = num11;
		float fontScale;
		if (flag)
		{
			fontScale = mScale;
		}
		else
		{
			int defaultSize = mFont.defaultSize;
			int num12 = mFontSize / defaultSize;
			fontScale = (float)num12 * mScale;
		}
		NGUIText.fontScale = fontScale;
		if (mFont != null)
		{
			UIFont mReplacement = mFont;
			bool flag6;
			do
			{
				NGUIText.bitmapFont = mReplacement;
				UIFont uIFont = NGUIText.bitmapFont;
				bool flag5 = uIFont.mReplacement == null;
				flag6 = !flag5;
				mReplacement = uIFont.mReplacement;
			}
			while (flag6);
			if (NGUIText.bitmapFont.isDynamic)
			{
				Font dynamicFont = NGUIText.bitmapFont.dynamicFont;
				NGUIText.dynamicFont = dynamicFont;
				NGUIText.bitmapFont = null;
			}
			else
			{
				NGUIText.dynamicFont = null;
			}
		}
		else
		{
			NGUIText.dynamicFont = font;
			NGUIText.bitmapFont = null;
		}
		bool flag7 = !flag;
		float pixelDensity = 1f;
		if (!flag7)
		{
			bool flag8 = keepCrisp;
			bool flag9 = !flag8;
			pixelDensity = 1f;
			if (!flag9)
			{
				UIRoot uIRoot = root;
				if (!(uIRoot != null))
				{
					goto IL_069e;
				}
				bool flag10 = uIRoot != null;
				bool flag11 = !flag10;
				pixelDensity = 1f;
				if (!flag11)
				{
					float pixelSizeAdjustment = uIRoot.pixelSizeAdjustment;
					pixelDensity = pixelSizeAdjustment;
				}
			}
		}
		NGUIText.pixelDensity = pixelDensity;
		goto IL_069e;
		IL_069e:
		if (NGUIText.pixelDensity != mDensity)
		{
			ProcessText(legacyMode: false, full: false);
			NGUIText.rectWidth = mWidth;
			NGUIText.rectHeight = mHeight;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+9C]");
			object obj7 = 0 - mDrawRegion;
			object obj8 = mWidth * obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num14 = default;
			double num13 = Math.Abs(num14);
			if (!(num13 < 2147483648.0))
			{
				num14 = -2147483648.0;
			}
			NGUIText.regionWidth = (int)num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+A0]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+98]");
			object obj9 = num15 - 0;
			object obj10 = mHeight * obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num17 = default;
			double num16 = Math.Abs(num17);
			if (!(num16 < 2147483648.0))
			{
				num17 = -2147483648.0;
			}
			NGUIText.regionHeight = (int)num17;
		}
		NGUIText.Alignment alignment = mAlignment;
		if (mAlignment == NGUIText.Alignment.Automatic)
		{
			bool flag12 = mPivot > Pivot.BottomRight;
			alignment = NGUIText.Alignment.Center;
			if (!flag12)
			{
				object obj11 = (int)mPivot << 2;
				object obj12 = obj11 + 2289504;
				alignment = (NGUIText.Alignment)obj12;
			}
		}
		NGUIText.alignment = alignment;
		NGUIText.Update();
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_0038: Expected I, but got Obj
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Obj, but got Unknown
		if (!paused && mTrueTypeFont != null)
		{
			nint num = (nint)this;
			object obj = this + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S2_v4 (Il2CppClass<UILabel>)+11C] (should have been resolved before IL gen)");
		}
	}

	public UILabel()
	{
		//IL_003b: Expected VT, but got I4
		//IL_00ad: Expected VT, but got I8
		//IL_00c6: Expected VT, but got I8
		_ = 4575657221408423936L;
		mEffectColor = (Color)0;
		mEncoding = true;
		mFontSize = 16;
		mShouldBeProcessed = true;
		mDensity = 1f;
		mMultiline = true;
		_ = 4575657222468743987L;
		mGradientBottom = (Color)4554039943398372147L;
		_ = 4575657222473777152L;
		mGradientTop = (Color)4575657222473777152L;
		mEffectDistance = Vector2.oneVector;
		mScale = 1f;
		mCalculatedSize = Vector2.zeroVector;
		base._002Ector();
	}

	static UILabel()
	{
		BetterList<UILabel> betterList = default;
		mList = betterList;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.Font, System.Int32>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Font, int> dictionary = default;
		mFontUsage = dictionary;
		mTexRebuildAdded = false;
		BetterList<Vector3> betterList2 = default;
		mTempVerts = betterList2;
		BetterList<int> betterList3 = default;
		mTempIndices = betterList3;
	}
}
