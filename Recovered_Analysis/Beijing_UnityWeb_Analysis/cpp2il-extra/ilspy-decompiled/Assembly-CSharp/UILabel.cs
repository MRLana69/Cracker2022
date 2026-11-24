using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Ionic.Zlib;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.EventSystems;

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

	public enum Modifier
	{
		None = 0,
		ToUppercase = 1,
		ToLowercase = 2,
		Custom = 255
	}

	public delegate string ModifierFunc(string s);

	public Crispness keepCrispWhenShrunk;

	private Font mTrueTypeFont;

	private UIFont mFont;

	private string mText;

	private int mFontSize;

	private FontStyle mFontStyle;

	private NGUIText.Alignment mAlignment;

	private bool mEncoding;

	private int mMaxLineCount;

	private Effect mEffectStyle;

	private Color mEffectColor;

	private NGUIText.SymbolStyle mSymbols;

	private Vector2 mEffectDistance;

	private Overflow mOverflow;

	private bool mApplyGradient;

	private Color mGradientTop;

	private Color mGradientBottom;

	private int mSpacingX;

	private int mSpacingY;

	private bool mUseFloatSpacing;

	private float mFloatSpacingX;

	private float mFloatSpacingY;

	private bool mOverflowEllipsis;

	private int mOverflowWidth;

	private int mOverflowHeight;

	private Modifier mModifier;

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

	public ModifierFunc customModifier;

	private static BetterList<UILabel> mList;

	private static Dictionary<Font, int> mFontUsage;

	[NonSerialized]
	private static BetterList<UIDrawCall> mTempDrawcalls;

	private static bool mTexRebuildAdded;

	private static List<Vector3> mTempVerts;

	private static List<int> mTempIndices;

	public unsafe int finalFontSize
	{
		get
		{
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Expected Obj, but got Unknown
			//IL_0122: Expected Obj, but got I4
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_0145: Expected Obj, but got I4
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected Obj, but got Unknown
			//IL_0162: Expected Obj, but got F4
			//IL_017a: Expected I, but got Obj
			//IL_0190: Expected Obj, but got I
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected Obj, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected Obj, but got Unknown
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected Obj, but got Unknown
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Expected Obj, but got Unknown
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected Obj, but got Unknown
			//IL_0271: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Expected Obj, but got Unknown
			//IL_0294: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Expected Obj, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected VT, but got Unknown
			//IL_02c9: Expected F4, but got Obj
			//IL_02c4: Expected native int or pointer, but got VT
			//IL_02ed: Expected F4, but got Obj
			//IL_02e8: Expected native int or pointer, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_007d: Expected I, but got Obj
			//IL_0093: Expected Obj, but got I
			//IL_032d: Expected F4, but got Obj
			//IL_0328: Expected native int or pointer, but got VT
			//IL_00be: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 88;
			obj = 0;
			_ = 0;
			_ = 0;
			object obj3 = obj2 + 72;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 - -64;
			obj4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<UICamera>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v72 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = (UICamera.genericEventHandler = (GameObject)(obj2 + 40));
			obj = gameObject;
			_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v25 (UnityEngine.GameObject)+10]");
			_ = 0;
			object obj6 = obj2 + 24;
			object obj8 = default;
			object obj7 = obj8 + 16;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v25+8]");
			_ = 0;
			object obj9 = obj2 + 12;
			object obj10 = obj8 + 28;
			obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v31+8]");
			_ = 0;
			object obj11 = obj8 + 40;
			obj2 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v36+8]");
			_ = 0;
			object obj12 = obj2 + 112;
			obj12 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v30+8]");
			_ = 0;
			object obj13 = obj2 + 124;
			obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v33+8]");
			_ = 0;
			Vector2 vector = (Vector2)(obj2 + 136);
			((Vector2*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D4");
			((Vector2*)(nint)vector)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
			object obj14 = default;
			if (obj14 != null)
			{
				nint num3 = (nint)typeof(UIInput);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v55 (Il2CppClass<UIInput>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num4 = (nint)typeof(UIInput);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v66 (Il2CppClass<UIInput>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
				((Vector2*)(nint)vector)->x = (float)obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v41+8]");
				_ = 0;
				int characterIndexAtPosition = ((UILabel)(object)leftAnchor).GetCharacterIndexAtPosition(vector, false);
				return characterIndexAtPosition + UIInput.mDrawStart;
			}
			return 0;
		}
	}

	private bool shouldBeProcessed
	{
		get
		{
			//IL_0186: Expected I, but got Obj
			//IL_019c: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_022d: Expected I4, but got Obj
			//IL_012f: Expected I, but got Obj
			//IL_01e9: Expected F4, but got I4
			//IL_01f3: Expected I4, but got F4
			//IL_00a1: Expected I, but got Obj
			UnityEngine.Object o = ambigiousFont;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num5;
			int num6;
			if (UnityEngine.Object.IsNativeObjectAlive(o))
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v24 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num5 = mFinalFontSize;
				num6 = (int)mScale;
			}
			else
			{
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				num5 = mScale;
				num6 = mFontSize;
			}
			float num9 = (float)num6 * num5;
			return (byte)(int)GUILayout.Width(num9) != 0;
		}
		set
		{
			//IL_0195: Expected I, but got Obj
			//IL_01ab: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)leftAnchor).FindKernel((string)null) == 0)
			{
				return;
			}
			nint num3 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v36 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UICamera.currentKey != KeyCode.None)
			{
				nint num5 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				KeyCode currentKey = UICamera.currentKey;
				if (currentKey != (KeyCode)1)
				{
					return;
				}
			}
			int num7 = finalFontSize;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A1D1");
		}
	}

	public override bool isAnchoredHorizontally => mShouldBeProcessed;

	public override bool isAnchoredVertically
	{
		get
		{
			if (base.isAnchoredVertically)
			{
				return true;
			}
			return mOverflow == Overflow.ResizeFreely;
		}
	}

	public override Material material
	{
		get
		{
			//IL_0082: Expected Obj, but got I4
			//IL_002c: Expected Obj, but got I4
			//IL_0064: Expected Obj, but got I4
			if (base.canBeAnchored)
			{
				return (Material)1;
			}
			if (mOverflow == Overflow.ResizeFreely)
			{
				return (Material)1;
			}
			bool flag = mOverflow == Overflow.ResizeHeight;
			return (Material)flag;
		}
		set
		{
			if ((object)value != null)
			{
				mChanged = true;
				mShouldBeProcessed = true;
			}
			else
			{
				mShouldBeProcessed = false;
			}
		}
	}

	public override Texture mainTexture
	{
		get
		{
			//IL_01cd: Expected I, but got Obj
			//IL_01e3: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_00b0: Expected I, but got Obj
			//IL_0106: Expected Obj, but got I4
			//IL_015a: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mMat).FindKernel((string)null) != 0)
			{
				return (Texture)(object)mMat;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
			{
				bool premultipliedAlpha = mFont.premultipliedAlpha;
				return (Texture)premultipliedAlpha;
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTrueTypeFont).FindKernel((string)null) != 0)
			{
				return (Texture)(object)mTrueTypeFont.fontNames;
			}
			return null;
		}
		set
		{
			base.mainTexture = value;
		}
	}

	public UIFont font
	{
		get
		{
			//IL_01d5: Expected I, but got Obj
			//IL_01eb: Expected Obj, but got I
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00bd: Expected I, but got Obj
			//IL_0119: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I
			//IL_015a: Expected I, but got Obj
			//IL_01ae: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
			{
				return (UIFont)(object)mFont.spriteName;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTrueTypeFont).FindKernel((string)null) != 0)
			{
				string[] fontNames = mTrueTypeFont.fontNames;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)fontNames).FindKernel((string)null) != 0)
				{
					int renderQueue = ((Material)(object)fontNames).renderQueue;
					return (UIFont)renderQueue;
				}
				return null;
			}
			return null;
		}
		set
		{
			base.shader = (Shader)(object)value;
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
			trueTypeFont = (Font)(object)value;
		}
	}

	public Font trueTypeFont
	{
		get
		{
			return (Font)(object)mFont;
		}
		set
		{
			//IL_009d: Expected I, but got Obj
			//IL_00b3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected Obj, but got Unknown
			//IL_007f: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFont).FindKernel((string)(object)value) != 0)
			{
				base.MarkAsChanged();
				object obj2 = this + 296;
				obj2 = value;
				object obj3 = this + 292;
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public UnityEngine.Object ambigiousFont
	{
		get
		{
			//IL_0123: Expected I, but got Obj
			//IL_0139: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			//IL_0106: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTrueTypeFont).FindKernel((string)null) != 0)
			{
				return mTrueTypeFont;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
			{
				FontStyle dynamicFontStyle = mFont.dynamicFontStyle;
				return (UnityEngine.Object)dynamicFontStyle;
			}
			return null;
		}
		set
		{
			//IL_0161: Expected I, but got Obj
			//IL_0177: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected Obj, but got Unknown
			//IL_00a5: Expected Obj, but got I4
			//IL_00af: Expected I4, but got Obj
			//IL_00c8: Expected I, but got Obj
			//IL_00de: Expected Obj, but got I
			//IL_0109: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mTrueTypeFont).FindKernel((string)(object)value) == 0)
			{
				return;
			}
			OnApplicationPause(paused: false);
			base.MarkAsChanged();
			object obj2 = this + 292;
			obj2 = value;
			mChanged = true;
			mShouldBeProcessed = true;
			object obj3 = this + 296;
			obj3 = 0;
			OnApplicationPause((byte)(int)value != 0);
			OnEnable();
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mActiveTTF).FindKernel((string)null) != 0)
			{
				CheckLayer();
			}
		}
	}

	public string text
	{
		get
		{
			bool flag = (object)mFont == null;
			bool flag2 = !flag;
			string result = (string)(object)mFont;
			if (!flag2)
			{
				result = (string)(object)mTrueTypeFont;
			}
			return result;
		}
		set
		{
			//IL_00ea: Expected I, but got Obj
			//IL_0100: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader = default;
			if (computeShader.FindKernel(null) != 0)
			{
				trueTypeFont = (Font)(object)computeShader;
				return;
			}
			UnityEngine.Object obj2;
			if (value == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = (UnityEngine.Object)(object)(((object)value.GetType() != typeof(Font)) ? null : value);
			}
			ambigiousFont = obj2;
		}
	}

	public int defaultFontSize
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)mText;
		}
	}

	public int fontSize
	{
		get
		{
			//IL_0131: Expected I, but got Obj
			//IL_0147: Expected Obj, but got I
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			//IL_0106: Expected I4, but got Obj
			UnityEngine.Object obj = ambigiousFont;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj).FindKernel((string)null) != 0)
			{
				return mFontSize;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
			{
				UISpriteData sprite = mFont.sprite;
				return (int)sprite;
			}
			return 16;
		}
		set
		{
			//IL_0117: Expected Obj, but got I4
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected Obj, but got Unknown
			//IL_00f8: Expected Obj, but got I4
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected Obj, but got Unknown
			if (mText != (string)value)
			{
				return;
			}
			string text = mText;
			bool flag;
			if (value != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				if (mText == null || text.m_stringLength == 0)
				{
					return;
				}
				object obj = this + 300;
				obj = "";
			}
			else
			{
				if (mText.get_Chars(value) == '\0')
				{
					return;
				}
				object obj2 = this + 300;
				obj2 = value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			OnEnable();
			if (~(autoResizeBoxCollider ? 1u : 0u) == 0)
			{
				SetDirty();
			}
		}
	}

	public FontStyle fontStyle
	{
		get
		{
			return (FontStyle)mFontSize;
		}
		set
		{
			//IL_00dd: Expected I, but got Obj
			//IL_00f3: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FontStyle fontStyle = ((value >= FontStyle.Normal) ? ((value <= (FontStyle)256) ? value : ((FontStyle)256)) : FontStyle.Normal);
			if (mFontSize != (int)fontStyle)
			{
				mFontSize = (int)fontStyle;
				mChanged = true;
				mShouldBeProcessed = true;
				OnEnable();
			}
		}
	}

	public NGUIText.Alignment alignment
	{
		get
		{
			return (NGUIText.Alignment)mFontStyle;
		}
		set
		{
			if (mFontStyle != (FontStyle)value)
			{
				mFontStyle = (FontStyle)value;
				mChanged = true;
				mShouldBeProcessed = true;
				OnEnable();
			}
		}
	}

	public bool applyGradient
	{
		get
		{
			return (byte)mAlignment != 0;
		}
		set
		{
			if (mAlignment != (value ? NGUIText.Alignment.Left : NGUIText.Alignment.Automatic))
			{
				mAlignment = (value ? NGUIText.Alignment.Left : NGUIText.Alignment.Automatic);
				mChanged = true;
				mShouldBeProcessed = true;
				OnEnable();
			}
		}
	}

	public Color gradientTop
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+168]");
			bool flag = (nint)0 != 0;
			object obj = flag ^ this;
			if (obj != null)
			{
				object obj2 = this & 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			Color result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 364;
			UILabel uILabel = (UILabel)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Color gradientBottom
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I, but got Unknown
			//IL_0066: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I
			Color color = default;
			object obj = color + 364;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)(nint)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				((IntPtr*)num)->m_value = (void*)(nint)this;
				_ = ((UnityEngine.Object)this).m_CachedPtr;
				object obj3 = color + 364;
				obj3 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+168]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
			return color;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 380;
			UILabel uILabel = (UILabel)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe int spacingX
	{
		get
		{
			return mApplyGradient ? 1 : 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I, but got Unknown
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected Obj, but got Unknown
			//IL_00d9: Expected Obj, but got I
			object obj = this + 380;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)((int*)value)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
			_ = 0;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				((IntPtr*)num)->m_value = (void*)((int*)value)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+8]");
				_ = 0;
				object obj3 = this + 380;
				obj3 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				if (~(mApplyGradient ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
		}
	}

	public int spacingY
	{
		get
		{
			return mSpacingX;
		}
		set
		{
			if (mSpacingX != value)
			{
				mSpacingX = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public bool useFloatSpacing
	{
		get
		{
			return (byte)mSpacingY != 0;
		}
		set
		{
			if (mSpacingY != (value ? 1 : 0))
			{
				mSpacingY = (value ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public float floatSpacingX
	{
		get
		{
			//IL_000e: Expected I, but got Obj
			//IL_0066: Expected F4, but got Obj
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			UILabel uILabel = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uILabel.topAnchor).FindKernel((string)null) != 0)
					{
						uILabel = (UILabel)(object)topAnchor;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					return (float)uILabel.bottomAnchor;
				}
				while (obj == null);
			}
		}
		set
		{
			//IL_000e: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_0165: Expected I, but got Obj
			//IL_017b: Expected Obj, but got I
			//IL_01d2: Invalid comparison between Obj and F4
			//IL_0148: Expected Obj, but got F4
			UILabel uILabel = default;
			while (true)
			{
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
				object obj;
				do
				{
					if (((ComputeShader)(object)uILabel.topAnchor).FindKernel((string)null) != 0)
					{
						uILabel = (UILabel)(object)topAnchor;
						nint num2 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
						obj = (nint)0 & (nint)0x200;
						continue;
					}
					nint num3 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num5;
					if (value < 0.25f)
					{
						num5 = 0.25f;
					}
					else
					{
						num5 = ((!(value > 4f)) ? value : 4f);
					}
					if (uILabel.bottomAnchor != (object)num5)
					{
						uILabel.bottomAnchor = (AnchorPoint)num5;
						((UIAtlas)(object)uILabel)._002Ector();
					}
					return;
				}
				while (obj == null);
			}
		}
	}

	public float floatSpacingY
	{
		get
		{
			return mFloatSpacingX;
		}
		set
		{
			//IL_007a: Expected I, but got Obj
			//IL_0090: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (BaseInputModule.DetermineMoveDirection(mFloatSpacingX, value) == MoveDirection.Left)
			{
				mFloatSpacingX = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public float effectiveSpacingY => mFloatSpacingY;

	public float effectiveSpacingX
	{
		get
		{
			//IL_0032: Expected F4, but got I4
			if (~(mUseFloatSpacing ? 1u : 0u) == 0)
			{
				return mFloatSpacingY;
			}
			return mSpacingY;
		}
	}

	public bool overflowEllipsis
	{
		get
		{
			return mUseFloatSpacing;
		}
		set
		{
			//IL_0021: Expected Obj, but got I4
			bool flag = mUseFloatSpacing;
			object obj = flag ^ value;
			if (obj != null)
			{
				mUseFloatSpacing = value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public int overflowWidth
	{
		get
		{
			return mOverflowEllipsis ? 1 : 0;
		}
		set
		{
			bool flag = mOverflowEllipsis;
			if (((flag ? 1u : 0u) ^ (uint)value) != 0)
			{
				int num = value & 1;
				mOverflowEllipsis = (byte)num != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public int overflowHeight
	{
		get
		{
			return mOverflowWidth;
		}
		set
		{
			int num = ((value > 0) ? value : 0);
			if (mOverflowWidth != num)
			{
				mOverflowWidth = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	private bool keepCrisp => (byte)mOverflowHeight != 0;

	public bool supportEncoding
	{
		get
		{
			//IL_00a5: Expected I, but got Obj
			//IL_00bb: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			UnityEngine.Object obj = ambigiousFont;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj).FindKernel((string)null) != 0 && keepCrispWhenShrunk != Crispness.Never)
			{
				return true;
			}
			return false;
		}
		set
		{
			bool flag = (value ? 1 : 0) > (false ? 1 : 0) && value;
			if (mOverflowHeight != (flag ? 1 : 0))
			{
				mOverflowHeight = (flag ? 1 : 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public NGUIText.SymbolStyle symbolStyle
	{
		get
		{
			return mEncoding ? NGUIText.SymbolStyle.Normal : NGUIText.SymbolStyle.None;
		}
		set
		{
			//IL_0021: Expected Obj, but got I4
			bool flag = mEncoding;
			object obj = (flag ? 1 : 0) ^ (int)value;
			if (obj != null)
			{
				bool flag2 = (byte)(value & NGUIText.SymbolStyle.Normal) != 0;
				mEncoding = flag2;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public Overflow overflowMethod
	{
		get
		{
			return (Overflow)mSymbols;
		}
		set
		{
			if (mSymbols != (NGUIText.SymbolStyle)value)
			{
				mSymbols = (NGUIText.SymbolStyle)value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public int lineWidth
	{
		get
		{
			return (int)mOverflow;
		}
		set
		{
			if (mOverflow != (Overflow)value)
			{
				mOverflow = (Overflow)value;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public int lineHeight
	{
		get
		{
			return mWidth;
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
			return (byte)mHeight != 0;
		}
		set
		{
			//IL_0009: Expected Obj, but got I4
			Color color = ((UIWidget)value).color;
		}
	}

	public override Vector3[] localCorners
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = mMaxLineCount != 1;
			return (Vector3[])flag;
		}
	}

	public override Vector3[] worldCorners
	{
		get
		{
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			}
			return base.worldCorners;
		}
	}

	public override Vector4 drawingDimensions
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+140]");
			bool flag = (nint)0 != 1;
			object obj = flag ^ this;
			if (obj != null)
			{
				object obj2 = this ^ 1;
				object obj3 = obj2 & 1;
				_ = 1;
				_ = 1;
			}
			Vector4 result = default;
			return result;
		}
	}

	public int maxLineCount
	{
		get
		{
			//IL_0037: Expected I4, but got Obj
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			}
			return (int)base.material;
		}
		set
		{
			//IL_0043: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Int32)+1CC]");
			if ((nint)0 != 0)
			{
				Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			}
			base.material = (Material)value;
		}
	}

	public Effect effectStyle
	{
		get
		{
			return (Effect)mMaxLineCount;
		}
		set
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			if (mMaxLineCount == (int)value)
			{
				return;
			}
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v10 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Effect effect = ((value > Effect.None) ? value : Effect.None);
			mMaxLineCount = (int)effect;
			mChanged = true;
			mShouldBeProcessed = true;
			if (mOverflow == Overflow.ShrinkContent)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public Color effectColor
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Color)+144]");
			if (0 != (nint)this)
			{
				_ = 1;
				_ = 1;
			}
			Color result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = value + 328;
			UILabel uILabel = (UILabel)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe Vector2 effectDistance
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected I, but got Unknown
			//IL_0066: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I
			Vector2 vector = default;
			object obj = vector + 328;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
			_ = 0;
			Gradient gradient = (Gradient)(obj2 + 16);
			gradient = (Gradient)obj2;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			gradient2.m_Ptr = (IntPtr)0;
			nint num = (nint)(obj2 + 32);
			((IntPtr*)num)->m_value = (void*)(nint)this;
			_ = ((UnityEngine.Object)this).m_CachedPtr;
			if (gradient.Internal_Equals((IntPtr)num))
			{
				((IntPtr*)num)->m_value = (void*)(nint)this;
				_ = ((UnityEngine.Object)this).m_CachedPtr;
				object obj3 = vector + 328;
				obj3 = (object)((IntPtr*)num)->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v10 (System.IntPtr)+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+144]");
				if ((nint)0 != 0)
				{
					_ = 1;
					_ = 1;
				}
			}
			return vector;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector2)+15C]");
			UILabel uILabel = (UILabel)0;
		}
	}

	public int quadsPerCharacter => (int)mEffectStyle;

	public unsafe bool shrinkToFit
	{
		get
		{
			if (mEffectStyle == Effect.Shadow)
			{
				return true;
			}
			if (mEffectStyle == Effect.Outline)
			{
				return true;
			}
			if (mEffectStyle == Effect.Outline8)
			{
				return true;
			}
			return true;
		}
		set
		{
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected Obj, but got Unknown
			//IL_00a4: Expected Obj, but got VT
			//IL_00b2: Expected I, but got Obj
			//IL_00c8: Expected Obj, but got I
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected Obj, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_0117: Expected Obj, but got I4
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Expected VT, but got Unknown
			//IL_0132: Expected F4, but got Obj
			//IL_012d: Expected native int or pointer, but got VT
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Expected Obj, but got Unknown
			//IL_0155: Expected Ref, but got VT
			//IL_0013: Expected I, but got Obj
			//IL_005f: Expected Obj, but got I4
			//IL_0071: Expected VT, but got Obj
			object obj2 = default;
			object obj = obj2 + 24;
			obj = mEffectDistance;
			nint num = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v34 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = obj2 + 16;
			obj4 = obj;
			object obj5 = obj2 + 8;
			obj5 = ((bool*)(value ? 1 : 0))->m_value;
			Vector4 vector = (Vector4)(obj2 + 32);
			((Vector4*)(nint)vector)->x = (float)obj4;
			object obj6 = obj2 + 40;
			obj6 = obj5;
			if (((Vector4*)vector)->Equals(obj6))
			{
				obj2 = ((bool*)(value ? 1 : 0))->m_value;
				obj6 = obj2;
				mEffectDistance = (Vector2)obj6;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
	}

	public string processedText
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			bool flag = mOverflow == Overflow.ShrinkContent;
			return (string)flag;
		}
	}

	public Vector2 printedSize
	{
		get
		{
			if ((object)this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+164]");
				if ((nint)0 != 0)
				{
					_ = 0;
					_ = 1;
					_ = 1;
				}
			}
			Vector2 result = default;
			return result;
		}
	}

	public unsafe override Vector2 localSize
	{
		get
		{
			//IL_003c: Expected F4, but got VT
			//IL_0037: Expected native int or pointer, but got VT
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			}
			Vector2 vector = default;
			((Vector2*)(nint)vector)->x = (float)mCalculatedSize;
			return vector;
		}
	}

	private bool isValid
	{
		get
		{
			//IL_008e: Expected I4, but got Obj
			if (mLastWidth != mWidth || mLastHeight != mHeight)
			{
				mLastWidth = mWidth;
				mLastHeight = mHeight;
				mShouldBeProcessed = true;
			}
			if (~(mShouldBeProcessed ? 1u : 0u) == 0)
			{
				Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			}
			return (byte)(int)mProcessedText != 0;
		}
	}

	public Modifier modifier
	{
		get
		{
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_00af: Expected I, but got Obj
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
			{
				return Modifier.ToUppercase;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Modifier)((ComputeShader)(object)mTrueTypeFont).FindKernel((string)null);
		}
		set
		{
			//IL_0042: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UILabel+Modifier)+1CC]");
			if ((nint)0 != 0)
			{
				Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			}
			Vector3 vector = ((UIWidget)value).localCenter;
		}
	}

	public string printedText
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)mModifier;
		}
	}

	protected override void OnInit()
	{
		CancelInvoke();
	}

	protected override void OnDisable()
	{
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_00a5: Expected I4, but got Obj
		//IL_00b9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		base.UpgradeFrom265();
		nint num = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UILabel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v15 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BetterList<>)(object)mList).RemoveAt((int)this);
		UnityEngine.Object obj2 = ambigiousFont;
		OnApplicationPause((byte)(int)obj2 != 0);
	}

	protected void SetActiveFont(Font fnt)
	{
		//IL_0036: Expected I4, but got Obj
		if ((nint)mModifier != (nint)fnt)
		{
			mModifier = (Modifier)fnt;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			OnEnable();
		}
	}

	private static void OnFontChanged(Font font)
	{
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((UILabel)(object)font).OnApplicationPause(false);
		nint num = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v7 (Il2CppClass<UILabel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v16 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((BetterList<>.CompareFunc)(object)mList).EndInvoke((IAsyncResult)(object)font);
		((UIWidget)(object)font).OnDestroy();
	}

	public unsafe override Vector3[] GetSides(Transform relativeTo)
	{
		//IL_1a17: Expected I, but got Obj
		//IL_1a2d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I4
		//IL_1a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a61: Expected I4, but got Unknown
		//IL_1a80: Expected Obj, but got I4
		//IL_00c8: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_107b: Expected Obj, but got I4
		//IL_0d16: Expected Obj, but got I4
		//IL_0b77: Expected Obj, but got I4
		//IL_0dbf: Expected I, but got Obj
		//IL_0dd5: Expected Obj, but got I
		//IL_11c6: Expected Obj, but got I4
		//IL_1afd: Expected Obj, but got I4
		//IL_0da3: Expected Obj, but got I4
		//IL_1b5d: Expected Obj, but got I4
		//IL_0e00: Expected I, but got Obj
		//IL_133b: Expected Obj, but got I4
		//IL_1b4f: Expected Obj, but got I4
		//IL_0fb2: Expected Obj, but got I4
		//IL_1234: Expected Obj, but got I4
		//IL_1bb7: Expected Obj, but got I4
		//IL_1c11: Expected Obj, but got I4
		//IL_0e9b: Expected I, but got Obj
		//IL_0eb1: Expected Obj, but got I
		//IL_0e70: Expected Obj, but got I4
		//IL_1e18: Expected Obj, but got I4
		//IL_1269: Expected I, but got Obj
		//IL_127f: Expected Obj, but got I
		//IL_13a9: Expected Obj, but got I4
		//IL_1029: Expected Obj, but got I4
		//IL_1b0b: Expected Obj, but got I4
		//IL_1b1e: Expected Obj, but got I4
		//IL_12f5: Expected Obj, but got I4
		//IL_1530: Expected I, but got Obj
		//IL_1546: Expected Obj, but got I
		//IL_1c95: Expected Obj, but got I4
		//IL_0edc: Expected I, but got Obj
		//IL_12aa: Expected I, but got Obj
		//IL_142b: Expected I, but got Obj
		//IL_1441: Expected Obj, but got I
		//IL_1571: Expected I, but got Obj
		//IL_1645: Expected I, but got Obj
		//IL_165b: Expected Obj, but got I
		//IL_146c: Expected I, but got Obj
		//IL_1e2c: Expected Obj, but got I4
		//IL_1e40: Expected Obj, but got I4
		//IL_1686: Expected I, but got Obj
		//IL_1d3d: Expected Obj, but got I4
		//IL_14b7: Expected Obj, but got I4
		//IL_15d6: Expected Obj, but got I4
		//IL_1e54: Expected Obj, but got I4
		//IL_1d78: Expected Obj, but got I4
		//IL_16e4: Expected Obj, but got I4
		//IL_1845: Expected Obj, but got I4
		//IL_1db3: Expected Obj, but got I4
		//IL_1e68: Expected Obj, but got I4
		//IL_1874: Expected Obj, but got I4
		//IL_1928: Expected Obj, but got I4
		//IL_1d12: Expected Obj, but got I4
		//IL_1e7c: Expected Obj, but got I4
		//IL_1dd0: Expected Obj, but got I4
		//IL_1968: Expected Obj, but got I4
		//IL_1a04: Expected Obj, but got I4
		//IL_1d2f: Expected Obj, but got I4
		//IL_1791: Expected Obj, but got I4
		//IL_0bf2: Expected Obj, but got I4
		//IL_0bad: Expected Obj, but got I4
		//IL_0c53: Expected I, but got Obj
		//IL_0c69: Expected Obj, but got I
		//IL_0c28: Expected Obj, but got I4
		//IL_1ad3: Expected Obj, but got I4
		//IL_1adc: Expected Obj, but got I4
		//IL_0c94: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v203 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)leftAnchor != null)
		{
			goto IL_1a4a;
		}
		string dataPath = Application.dataPath;
		bool flag = (nint)dataPath > 1;
		int clickCount = ((Event)(object)relativeTo).clickCount;
		int clickCount2 = ((Event)(object)relativeTo).clickCount;
		int num3 = clickCount2 & 4;
		bool flag2 = num3 == 0;
		object obj2 = ((!flag) ? ((object)8) : ((object)2));
		int num4 = obj2 & clickCount;
		bool flag3 = num4 != 0;
		object obj3 = flag2 & flag3;
		int clickCount3 = ((Event)(object)relativeTo).clickCount;
		EventType type = ((Event)(object)relativeTo).type;
		Vector3[] result;
		if (type <= (EventType)99)
		{
			object obj4 = type - 8;
			if (type != EventType.Layout)
			{
				if ((nint)obj4 == 1 || (nint)obj4 == 2 || (nint)obj4 == 3 || (nint)obj4 == 4 || (nint)obj4 == 5 || (nint)obj4 == 6 || (nint)obj4 == 7 || (nint)obj4 == 8 || (nint)obj4 == 9 || (nint)obj4 == 10 || (nint)obj4 == 11 || (nint)obj4 == 12 || (nint)obj4 == 13 || (nint)obj4 == 14 || (nint)obj4 == 15 || (nint)obj4 == 16 || (nint)obj4 == 17 || (nint)obj4 == 18 || (nint)obj4 == 19 || (nint)obj4 == 20 || (nint)obj4 == 21 || (nint)obj4 == 22 || (nint)obj4 == 23 || (nint)obj4 == 24 || (nint)obj4 == 25 || (nint)obj4 == 26 || (nint)obj4 == 27 || (nint)obj4 == 28 || (nint)obj4 == 29 || (nint)obj4 == 30 || (nint)obj4 == 31 || (nint)obj4 == 32 || (nint)obj4 == 33 || (nint)obj4 == 34 || (nint)obj4 == 35 || (nint)obj4 == 36 || (nint)obj4 == 37 || (nint)obj4 == 38 || (nint)obj4 == 39 || (nint)obj4 == 40 || (nint)obj4 == 41 || (nint)obj4 == 42 || (nint)obj4 == 43 || (nint)obj4 == 44 || (nint)obj4 == 45 || (nint)obj4 == 46 || (nint)obj4 == 47 || (nint)obj4 == 48 || (nint)obj4 == 49 || (nint)obj4 == 50 || (nint)obj4 == 51 || (nint)obj4 == 52 || (nint)obj4 == 53 || (nint)obj4 == 54 || (nint)obj4 == 55 || (nint)obj4 == 56 || (nint)obj4 == 57 || (nint)obj4 == 58 || (nint)obj4 == 59 || (nint)obj4 == 60 || (nint)obj4 == 61 || (nint)obj4 == 62 || (nint)obj4 == 63 || (nint)obj4 == 64 || (nint)obj4 == 65 || (nint)obj4 == 66 || (nint)obj4 == 67 || (nint)obj4 == 68 || (nint)obj4 == 69 || (nint)obj4 == 70 || (nint)obj4 == 71 || (nint)obj4 == 72 || (nint)obj4 == 73 || (nint)obj4 == 74 || (nint)obj4 == 75 || (nint)obj4 == 76 || (nint)obj4 == 77 || (nint)obj4 == 78 || (nint)obj4 == 79 || (nint)obj4 == 80 || (nint)obj4 == 81 || (nint)obj4 == 82 || (nint)obj4 == 83 || (nint)obj4 == 84 || (nint)obj4 == 85 || (nint)obj4 == 86 || (nint)obj4 == 87 || (nint)obj4 == 88)
				{
					goto IL_0cd3;
				}
				if ((nint)obj4 != 89)
				{
					if ((nint)obj4 == 90 || (nint)obj4 != 91)
					{
						goto IL_0cd3;
					}
					if (obj3 == null)
					{
						result = (Vector3[])1;
					}
					else
					{
						Color color = GUI.color;
						int charUnderMouse = ((UIInput)(object)this).GetCharUnderMouse();
						nint num5 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S2_v84 (Il2CppClass<NGUITools>)+BA]");
						object obj5 = (nint)0 & (nint)0x200;
						if (obj5 != null)
						{
							nint num6 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S2_v89 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NGUITools.ImmediatelyCreateDrawCalls((GameObject)charUnderMouse);
						result = (Vector3[])1;
					}
				}
				else if (obj3 == null)
				{
					result = (Vector3[])1;
				}
				else
				{
					Color color2 = GUI.color;
					geometry = null;
					int num7 = mDepth;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v780 @ S2_v76 (System.Int32)+8]");
					fillGeometry = false;
					((UIInput)(object)this).ExecuteOnChange();
					result = (Vector3[])1;
				}
			}
			else
			{
				Color color3 = GUI.color;
				((UIInput)(object)this).OnDisable();
				result = (Vector3[])1;
			}
		}
		else if (type <= (EventType)120)
		{
			object obj6 = type - 118;
			if (type != (EventType)118)
			{
				if ((nint)obj6 != 1 && (nint)obj6 == 2)
				{
					if (obj3 == null)
					{
						result = (Vector3[])1;
					}
					else
					{
						Color color4 = GUI.color;
						int charUnderMouse2 = ((UIInput)(object)this).GetCharUnderMouse();
						nint num8 = (nint)typeof(NGUITools);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S2_v58 (Il2CppClass<NGUITools>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num9 = (nint)typeof(NGUITools);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ S2_v64 (Il2CppClass<NGUITools>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NGUITools.ImmediatelyCreateDrawCalls((GameObject)charUnderMouse2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
						result = (Vector3[])1;
					}
				}
				else
				{
					result = null;
				}
			}
			else if (obj3 == null)
			{
				result = (Vector3[])1;
			}
			else
			{
				Color color5 = GUI.color;
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ S1_v195 (Il2CppClass<NGUITools>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num11 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S1_v201 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				BetterList<UIDrawCall> list = UIDrawCall.list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				result = (Vector3[])1;
			}
		}
		else if (type == (EventType)127)
		{
			Color color6 = GUI.color;
			int num12 = mDepth;
			bool flag4;
			if (mDepth != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S2_v31 (System.Int32)+8]");
				flag4 = (nint)0 == 0;
			}
			else
			{
				flag4 = true;
			}
			if (flag4)
			{
				result = (Vector3[])1;
			}
			else
			{
				if ((nint)geometry == (fillGeometry ? 1 : 0))
				{
					int num13 = mDepth;
					UIGeometry uIGeometry = geometry;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S3_v12 (System.Int32)+8]");
					if ((nint)uIGeometry >= 0)
					{
						result = (Vector3[])1;
						goto IL_1ac5;
					}
					bool flag5 = (byte)((fillGeometry ? 1u : 0u) + 1u) != 0;
					fillGeometry = flag5;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				result = (Vector3[])1;
			}
		}
		else
		{
			int num14 = clickCount3 & 1;
			bool flag6 = num14 != 0;
			object obj9 = type - 273;
			if (type != (EventType)273)
			{
				if ((nint)obj9 != 1)
				{
					if ((nint)obj9 != 2)
					{
						if ((nint)obj9 != 3)
						{
							if ((nint)obj9 == 4)
							{
								goto IL_1a4a;
							}
							if ((nint)obj9 != 5)
							{
								if ((nint)obj9 != 6)
								{
									if ((nint)obj9 != 7)
									{
										if ((nint)obj9 != 8)
										{
											goto IL_1a4a;
										}
										Color color7 = GUI.color;
										int num15 = mDepth;
										bool flag7;
										if (mDepth != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S1_v167 (System.Int32)+8]");
											flag7 = (nint)0 == 0;
										}
										else
										{
											flag7 = true;
										}
										result = (Vector3[])1;
										if (!flag7)
										{
											int num16 = mDepth;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S1_v170 (System.Int32)+8]");
											fillGeometry = false;
											if (!flag6)
											{
												geometry = (UIGeometry)fillGeometry;
											}
											((UIInput)(object)this).ExecuteOnChange();
											result = (Vector3[])1;
										}
									}
									else
									{
										Color color8 = GUI.color;
										int num17 = mDepth;
										bool flag8;
										if (mDepth != 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ S1_v154 (System.Int32)+8]");
											flag8 = (nint)0 == 0;
										}
										else
										{
											flag8 = true;
										}
										result = (Vector3[])1;
										if (!flag8)
										{
											fillGeometry = false;
											if (!flag6)
											{
												geometry = (UIGeometry)fillGeometry;
											}
											((UIInput)(object)this).ExecuteOnChange();
											result = (Vector3[])1;
										}
									}
								}
								else
								{
									Color color9 = GUI.color;
									int num18 = mDepth;
									bool flag9;
									if (mDepth != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S1_v134 (System.Int32)+8]");
										flag9 = (nint)0 == 0;
									}
									else
									{
										flag9 = true;
									}
									result = (Vector3[])1;
									if (!flag9)
									{
										AnchorPoint anchorPoint = leftAnchor;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S0_v159 (UIRect+AnchorPoint)+140]");
										if ((nint)0 != 1)
										{
											bool flag10 = ((UILabel)(object)leftAnchor).TryGetPositionOfWord((string)fillGeometry, out *(Vector3*)279);
											fillGeometry = flag10;
										}
										else
										{
											int num19 = mDepth;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S1_v143 (System.Int32)+8]");
											fillGeometry = false;
										}
										if (!flag6)
										{
											geometry = (UIGeometry)fillGeometry;
										}
										((UIInput)(object)this).ExecuteOnChange();
										result = (Vector3[])1;
									}
								}
							}
							else
							{
								Color color10 = GUI.color;
								int num20 = mDepth;
								bool flag11;
								if (mDepth != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S1_v116 (System.Int32)+8]");
									flag11 = (nint)0 == 0;
								}
								else
								{
									flag11 = true;
								}
								result = (Vector3[])1;
								if (!flag11)
								{
									AnchorPoint anchorPoint2 = leftAnchor;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v144 (UIRect+AnchorPoint)+140]");
									if ((nint)0 != 1)
									{
										bool flag12 = ((UILabel)(object)leftAnchor).TryGetPositionOfWord((string)fillGeometry, out *(Vector3*)278);
										fillGeometry = flag12;
									}
									else
									{
										fillGeometry = false;
									}
									if (!flag6)
									{
										geometry = (UIGeometry)fillGeometry;
									}
									((UIInput)(object)this).ExecuteOnChange();
									result = (Vector3[])1;
								}
							}
						}
						else
						{
							Color color11 = GUI.color;
							int num21 = mDepth;
							bool flag13;
							if (mDepth != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ S1_v97 (System.Int32)+8]");
								flag13 = (nint)0 == 0;
							}
							else
							{
								flag13 = true;
							}
							result = (Vector3[])1;
							if (!flag13)
							{
								nint num22 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ S0_v126 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj10 = (nint)0 & (nint)0x200;
								if (obj10 != null)
								{
									nint num23 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v137 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag14 = (byte)((fillGeometry ? 1u : 0u) - 1u) != 0;
								if ((flag14 ? 1 : 0) <= (false ? 1 : 0))
								{
									flag14 = false;
								}
								fillGeometry = flag14;
								if (!flag6)
								{
									geometry = (UIGeometry)fillGeometry;
								}
								((UIInput)(object)this).ExecuteOnChange();
								result = (Vector3[])1;
							}
						}
					}
					else
					{
						Color color12 = GUI.color;
						int num24 = mDepth;
						bool flag15;
						if (mDepth != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S1_v78 (System.Int32)+8]");
							flag15 = (nint)0 == 0;
						}
						else
						{
							flag15 = true;
						}
						result = (Vector3[])1;
						if (!flag15)
						{
							int num25 = mDepth;
							nint num26 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ S0_v106 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj11 = (nint)0 & (nint)0x200;
							if (obj11 != null)
							{
								nint num27 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ S0_v117 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag16 = (byte)((fillGeometry ? 1u : 0u) + 1u) != 0;
							bool flag17 = flag16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v103 (System.Int32)+8]");
							if ((nint)(flag17 ? 1 : 0) >= (nint)0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v103 (System.Int32)+8]");
								flag16 = false;
							}
							fillGeometry = flag16;
							if (!flag6)
							{
								geometry = (UIGeometry)fillGeometry;
							}
							((UIInput)(object)this).ExecuteOnChange();
							result = (Vector3[])1;
						}
					}
				}
				else
				{
					Color color13 = GUI.color;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+D0]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
						result = (Vector3[])1;
					}
					else
					{
						int num28 = mDepth;
						bool flag18;
						if (mDepth != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S1_v49 (System.Int32)+8]");
							flag18 = (nint)0 == 0;
						}
						else
						{
							flag18 = true;
						}
						result = (Vector3[])1;
						if (!flag18)
						{
							bool flag19 = ((UILabel)(object)leftAnchor).TryGetPositionOfWord((string)fillGeometry, out *(Vector3*)274);
							fillGeometry = flag19;
							bool flag20 = ((UILabel)(object)leftAnchor).isValid;
							bool flag21 = fillGeometry;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S1_v56 (System.Boolean)+8]");
							if ((nint)(flag21 ? 1 : 0) == 0)
							{
								int num29 = mDepth;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ S1_v69 (System.Int32)+8]");
								fillGeometry = false;
							}
							else
							{
								nint num30 = (nint)typeof(UIInput);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S0_v83 (Il2CppClass<UIInput>)+BA]");
								object obj12 = (nint)0 & (nint)0x200;
								if (obj12 != null)
								{
									nint num31 = (nint)typeof(UIInput);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ S0_v88 (Il2CppClass<UIInput>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag22 = (byte)((uint)UIInput.mDrawStart + (fillGeometry ? 1u : 0u)) != 0;
								fillGeometry = flag22;
							}
							if (!flag6)
							{
								geometry = (UIGeometry)fillGeometry;
							}
							((UIInput)(object)this).ExecuteOnChange();
							result = (Vector3[])1;
						}
					}
				}
			}
			else
			{
				Color color14 = GUI.color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+CC]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
					result = (Vector3[])1;
				}
				else
				{
					int num32 = mDepth;
					bool flag23;
					if (mDepth != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S1_v27 (System.Int32)+8]");
						flag23 = (nint)0 == 0;
					}
					else
					{
						flag23 = true;
					}
					result = (Vector3[])1;
					if (!flag23)
					{
						bool flag24 = ((UILabel)(object)leftAnchor).TryGetPositionOfWord((string)fillGeometry, out *(Vector3*)273);
						fillGeometry = flag24;
						if (~(fillGeometry ? 1u : 0u) == 0)
						{
							nint num33 = (nint)typeof(UIInput);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ S0_v51 (Il2CppClass<UIInput>)+BA]");
							object obj13 = (nint)0 & (nint)0x200;
							if (obj13 != null)
							{
								nint num34 = (nint)typeof(UIInput);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v56 (Il2CppClass<UIInput>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag25 = (byte)((uint)UIInput.mDrawStart + (fillGeometry ? 1u : 0u)) != 0;
							fillGeometry = flag25;
						}
						if (!flag6)
						{
							geometry = (UIGeometry)fillGeometry;
						}
						((UIInput)(object)this).ExecuteOnChange();
						result = (Vector3[])1;
					}
				}
			}
		}
		goto IL_1ac5;
		IL_1ac5:
		return result;
		IL_0cd3:
		result = null;
		goto IL_1ac5;
		IL_1a4a:
		result = null;
		goto IL_1ac5;
	}

	protected override void UpgradeFrom265()
	{
		//IL_0ac3: Expected I, but got Obj
		//IL_0ad9: Expected Obj, but got I
		//IL_0a49: Expected I, but got Obj
		//IL_0a5f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0542: Expected I, but got Obj
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected Obj, but got Unknown
		//IL_07ab: Expected I, but got Obj
		//IL_07c1: Expected Obj, but got I
		//IL_058f: Expected I, but got Obj
		//IL_05a5: Expected Obj, but got I
		//IL_0079: Expected I, but got Obj
		//IL_0924: Expected Obj, but got I4
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ec: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_09b7: Expected I, but got Obj
		//IL_09cd: Expected Obj, but got I
		//IL_05d0: Expected I, but got Obj
		//IL_0120: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I
		//IL_0161: Expected I, but got Obj
		//IL_071f: Expected I, but got Obj
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected Obj, but got Unknown
		//IL_0976: Expected I, but got Obj
		//IL_098c: Expected Obj, but got I
		//IL_01cd: Expected Obj, but got I
		//IL_0b47: Expected Obj, but got I4
		//IL_0636: Expected I, but got Obj
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_0683: Expected I, but got Obj
		//IL_082b: Expected Obj, but got I
		//IL_06d4: Expected Obj, but got I4
		//IL_028a: Expected I, but got Obj
		//IL_02a0: Expected Obj, but got I
		//IL_022b: Expected I, but got Obj
		//IL_0b04: Expected I, but got Obj
		//IL_0b1a: Expected Obj, but got I
		//IL_02cb: Expected I, but got Obj
		//IL_0b7a: Expected Obj, but got I
		//IL_0322: Expected I, but got Obj
		//IL_0338: Expected Obj, but got I
		//IL_0355: Expected I, but got Obj
		//IL_03da: Expected I, but got Obj
		//IL_0888: Expected Obj, but got I
		//IL_0890: Expected Obj, but got I
		//IL_0427: Expected I, but got Obj
		//IL_043d: Expected Obj, but got I
		//IL_0371: Expected I, but got Obj
		//IL_03a1: Expected I, but got Obj
		//IL_08ab: Expected VT, but got I
		//IL_0468: Expected I, but got Obj
		//IL_03c7: Expected I, but got Obj
		//IL_04b5: Expected I, but got Obj
		//IL_04cb: Expected Obj, but got I
		//IL_08ee: Expected Obj, but got I
		//IL_04f6: Expected I, but got Obj
		object obj2 = default;
		bool flag2;
		IntPtr intPtr = default;
		object obj17 = default;
		while (true)
		{
			nint num = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v6 (Il2CppClass<UILabel>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v206 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UILabel> betterList = mList;
			bool flag = (nint)obj2 < betterList.size;
			nint num3 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v8 (Il2CppClass<UILabel>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			flag2 = obj3 != null;
			if (!flag)
			{
				break;
			}
			if (flag2)
			{
				nint num4 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v200 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UILabel> betterList2 = mList;
			object obj4 = betterList2.buffer + 16;
			object obj5 = obj2 << 2;
			object obj6 = obj4 + obj5;
			ComputeShader computeShader = (ComputeShader)obj6;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v99 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v196 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj6).FindKernel((string)null) != 0)
			{
				UnityEngine.Object obj8 = ((UILabel)obj6).ambigiousFont;
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v192 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (obj8 != this)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+12C]");
					nint num9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+1E4]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+134]");
					((UnityEngine.Bindings.NativeMethodAttribute)(object)obj8)._002Ector((string)num9, (byte)num10 != 0, false);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num12 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ S1_v77 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+90]");
					if ((UnityEngine.Object)0 != null)
					{
						int num13 = ((UIWidget)obj6).minWidth;
					}
					nint num14 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v124 (Il2CppClass<UILabel>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num15 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S0_v184 (Il2CppClass<UILabel>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mTempDrawcalls == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num16 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v171 (Il2CppClass<UILabel>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						bool flag3 = obj12 == null;
						nint num17 = (nint)typeof(UILabel);
						if (!flag3)
						{
							nint num18 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v178 (Il2CppClass<UILabel>)+74]");
							bool flag4 = (nint)0 == 0;
							bool flag5 = !flag4;
							num17 = (nint)typeof(UILabel);
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								num17 = (nint)typeof(UILabel);
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ L1_v27 (Il2CppClass<UILabel>)+5C]");
						object obj13 = (nint)0 + (nint)8;
						obj13 = (nint)intPtr;
					}
					nint num19 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num20 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+F8]");
					if (((ComputeShader)0).FindKernel(null) != 0)
					{
						nint num21 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S0_v137 (Il2CppClass<UILabel>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num22 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v159 (Il2CppClass<UILabel>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						BetterList<UIDrawCall> betterList3 = mTempDrawcalls;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+F8]");
						if (((BetterList<>)(object)betterList3).IndexOf((T)0) == 0)
						{
							nint num23 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v147 (Il2CppClass<UILabel>)+BA]");
							object obj16 = (nint)0 & (nint)0x200;
							if (obj16 != null)
							{
								nint num24 = (nint)typeof(UILabel);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ S0_v154 (Il2CppClass<UILabel>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							BetterList<UIDrawCall> betterList4 = mTempDrawcalls;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (UnityEngine.ComputeShader)+F8]");
							betterList4.Add((UIDrawCall)0);
						}
					}
				}
			}
			obj2 = obj17 + 1;
		}
		if (flag2)
		{
			nint num25 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v81 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTempDrawcalls == null)
		{
			return;
		}
		nint num26 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v20 (Il2CppClass<UILabel>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num27 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v75 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<UIDrawCall> betterList5 = mTempDrawcalls;
		object obj19 = 0;
		bool flag6;
		while (true)
		{
			nint num28 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v31 (Il2CppClass<UILabel>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			flag6 = obj20 != null;
			if ((nint)obj19 >= betterList5.size)
			{
				break;
			}
			if (flag6)
			{
				nint num29 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v69 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			BetterList<UIDrawCall> betterList6 = mTempDrawcalls;
			object obj21 = betterList6.buffer + 16;
			object obj22 = obj19 << 2;
			object obj23 = obj21 + obj22;
			UIWidget uIWidget = (UIWidget)obj23;
			nint num30 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num31 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)uIWidget.updateAnchors).FindKernel(null) != 0)
			{
				UIDrawCall uIDrawCall = ((UIPanel)uIWidget.updateAnchors).FindDrawCall(uIWidget);
			}
			object obj25 = obj19 + 1;
			obj19 = obj25;
		}
		if (flag6)
		{
			nint num32 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v44 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BetterList<UIDrawCall> betterList7 = mTempDrawcalls;
		betterList7.size = 0;
	}

	protected override void OnAnchor()
	{
		//IL_02d7: Expected Obj, but got I4
		//IL_0136: Expected I, but got Obj
		//IL_014c: Expected Obj, but got I
		//IL_011f: Expected Obj, but got I4
		//IL_0248: Expected I, but got Obj
		//IL_025e: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0289: Expected I, but got Obj
		//IL_020a: Expected I4, but got Obj
		Vector3 positionOfCharacter = ((UILabel)1).GetPositionOfCharacter(1);
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
		if (mMaxLineWidth != 0)
		{
			height = mMaxLineWidth;
			Overflow overflow = ((mMaxLineCount > 0) ? Overflow.ResizeHeight : Overflow.ShrinkContent);
			if (mOverflow != overflow)
			{
				mOverflow = overflow;
				mChanged = true;
				mShouldBeProcessed = true;
			}
		}
		else if (mOverflow != Overflow.ResizeFreely)
		{
			mOverflow = Overflow.ResizeFreely;
			mChanged = true;
			mShouldBeProcessed = true;
		}
		if (mMaxLineHeight != 0)
		{
			Color color = ((UIWidget)mMaxLineHeight).color;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
		{
			UISpriteData sprite = mFont.sprite;
			if (mHeight < (nint)sprite)
			{
				Color color2 = ((UIWidget)(object)sprite).color;
			}
			fontStyle = (FontStyle)sprite;
		}
		mMaxLineWidth = 0;
		mMaxLineHeight = 0;
		mShrinkToFit = false;
		string box = tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v18 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v23 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.UpdateWidgetCollider((BoxCollider)(object)box, considerInactive: true);
	}

	private void ProcessAndRequest()
	{
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00bb: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0153: Expected I, but got Obj
		if (mOverflow == Overflow.ResizeFreely)
		{
			if (base.isAnchoredHorizontally)
			{
				mOverflow = Overflow.ShrinkContent;
			}
		}
		else if (mOverflow == Overflow.ResizeHeight)
		{
			AnchorPoint anchorPoint = topAnchor;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)anchorPoint.target).FindKernel((string)null) != 0)
			{
				AnchorPoint anchorPoint2 = bottomAnchor;
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)anchorPoint2.target).FindKernel((string)null) != 0)
				{
					mOverflow = Overflow.ShrinkContent;
				}
			}
		}
		base.OnUpdate();
	}

	protected override void OnEnable()
	{
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0022: Expected I, but got Obj
		bool flag = (object)mFont == null;
		bool flag2 = !flag;
		ComputeShader computeShader = (ComputeShader)(object)mFont;
		if (!flag2)
		{
			computeShader = (ComputeShader)(object)mTrueTypeFont;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) != 0)
		{
			Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
		}
	}

	protected override void OnStart()
	{
		//IL_00f5: Expected I, but got Obj
		//IL_010b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		((UIRect)this).OnInit();
		nint num = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<UILabel>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v39 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(mTexRebuildAdded ? 1u : 0u) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<UILabel>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v33 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mTexRebuildAdded = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num5 = 0;
		_ = 0;
		Action<Font> action = default;
		object obj3 = action + 16;
		obj3 = 0;
		Font.textureRebuilt -= action;
	}

	public override void MarkAsChanged()
	{
		//IL_02f6: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0273: Expected I4, but got Obj
		//IL_00bc: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_0125: Expected I, but got Obj
		//IL_013b: Expected Obj, but got I
		//IL_0166: Expected I, but got Obj
		base.OnAnchor();
		if (mLineWidth > 0f)
		{
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v32 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v38 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption = GUILayout.Width(mLineWidth);
			mMaxLineWidth = (int)gUILayoutOption;
			mLineWidth = 0f;
		}
		if (~(mMultiline ? 1u : 0u) != 0)
		{
			mMaxLineCount = 1;
			mMultiline = true;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		bool flag;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Material material = default;
			Texture texture = material.mainTexture;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)texture).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Material material2 = default;
				Texture original = material2.mainTexture;
				UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)original);
				flag = ((string)(object)obj4).EndsWith("Premultiplied");
			}
			else
			{
				flag = false;
			}
		}
		else
		{
			flag = false;
		}
		mPremultiply = flag;
		OnEnable();
	}

	public void ProcessText(bool legacyMode = false, bool full = true)
	{
		//IL_01ea: Invalid comparison between F4 and I4
		//IL_0027: Expected Obj, but got I4
		//IL_0027: Expected Obj, but got I4
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I4
		//IL_0226: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_00f5: Expected Obj, but got I4
		//IL_018f: Expected Obj, but got I
		//IL_019b: Expected I4, but got Obj
		if (aspectRatio != 0f)
		{
			((UIInput)(object)this).OnSelectEvent();
		}
		bool selected = ((UIInput)(object)this).selected;
		if ((string)legacyMode != (string)selected)
		{
			return;
		}
		nint num = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UIInput>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIInput);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v47 (Il2CppClass<UIInput>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIInput.mDrawStart = 0;
		bool flag = ((UIInput)(object)this).ProcessEvent((Event)legacyMode);
		if (((string)mDepth).get_Chars(flag ? 1 : 0) == '\0')
		{
			return;
		}
		object obj2 = this + 108;
		obj2 = flag;
		panel = null;
		if (((UIInput)(object)this).cursorPosition != 0)
		{
			bool flag2;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				geometry = null;
				fillGeometry = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v20 (System.Boolean)+8]");
				geometry = (UIGeometry)0;
				fillGeometry = (byte)(int)geometry != 0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UILabel)+BC]");
			if ((nint)0 != 0)
			{
				((UIInput)(object)this).OnSelect(flag);
			}
		}
		((UIInput)(object)this).ExecuteOnChange();
		if (full)
		{
			((UIInput)(object)this).RemoveFocus();
		}
	}

	public override void MakePixelPerfect()
	{
		mChanged = true;
		mShouldBeProcessed = true;
		CheckLayer();
	}

	public void AssumeNaturalSize()
	{
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected Obj, but got Unknown
		//IL_0393: Expected Obj, but got I4
		//IL_06cd: Expected I, but got Obj
		//IL_06e3: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_0022: Expected I, but got Obj
		//IL_0078: Expected VT, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0447: Expected F4, but got Obj
		//IL_0479: Expected F4, but got I
		//IL_04a8: Expected F4, but got I
		//IL_00f0: Expected I, but got Obj
		//IL_0185: Expected I, but got Obj
		//IL_019b: Expected Obj, but got I
		//IL_01c6: Expected I, but got Obj
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected Obj, but got Unknown
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_0595: Expected F4, but got Obj
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected Obj, but got Unknown
		//IL_05b5: Expected F4, but got I
		//IL_025b: Expected I, but got Obj
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected Obj, but got Unknown
		//IL_02a3: Expected Obj, but got I4
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_02b1: Expected Obj, but got I4
		//IL_0739: Expected I, but got Obj
		//IL_074f: Expected Obj, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_02fa: Expected I, but got Obj
		//IL_067d: Expected I4, but got Obj
		//IL_0343: Expected Obj, but got I4
		//IL_06b0: Expected I4, but got Obj
		//IL_035f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		bool flag = (object)mFont == null;
		bool flag2 = !flag;
		ComputeShader computeShader = (ComputeShader)(object)mFont;
		if (!flag2)
		{
			computeShader = (ComputeShader)(object)mTrueTypeFont;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v117 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 72);
		Transform transform2 = (Transform)(obj2 + 48);
		object obj4 = obj2 + 36;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 12;
		if (computeShader.FindKernel(null) != 0)
		{
			Camera camera = anchorCamera;
			transform2.localPosition = (Vector3)camera;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			obj4 = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v43 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v113 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj4);
			obj = gUILayoutOption;
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v27+4]");
			GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v29+8]");
			GUILayoutOption gUILayoutOption3 = GUILayout.Width(0f);
			Camera camera2 = anchorCamera;
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			Camera camera3 = anchorCamera;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S1_v48 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v98 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)(object)camera3).parent = transform;
			if (mOverflow == Overflow.ResizeFreely)
			{
				SetCurrentProgress();
				return;
			}
			if (mOverflow != Overflow.ResizeHeight)
			{
				mWidth = 100000;
			}
			mHeight = 100000;
			mOverflow = Overflow.ShrinkContent;
			Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
			mOverflow = mOverflow;
			object obj9 = this + 472;
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v65 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v92 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption4 = GUILayout.Width((float)obj9);
			object obj11 = this + 472;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v78+4]");
			GUILayoutOption gUILayoutOption5 = GUILayout.Width(0f);
			bool flag3 = (nint)gUILayoutOption4 <= 2;
			bool flag4 = !flag3;
			GUILayoutOption gUILayoutOption6 = gUILayoutOption4;
			if (!flag4)
			{
				gUILayoutOption6 = (GUILayoutOption)2;
			}
			bool flag5 = (nint)gUILayoutOption5 <= 2;
			bool flag6 = !flag5;
			GUILayoutOption gUILayoutOption7 = gUILayoutOption5;
			if (!flag6)
			{
				gUILayoutOption7 = (GUILayoutOption)2;
			}
			object obj12 = gUILayoutOption6 & 1;
			if (obj12 != null)
			{
				GUILayoutOption gUILayoutOption8 = (GUILayoutOption)(gUILayoutOption6 + 1);
				gUILayoutOption6 = gUILayoutOption8;
			}
			object obj13 = gUILayoutOption7 & 1;
			if (obj13 != null)
			{
				GUILayoutOption gUILayoutOption9 = (GUILayoutOption)(gUILayoutOption7 + 1);
				gUILayoutOption7 = gUILayoutOption9;
			}
			nint num9 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v94 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num10 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v101 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GUILayoutOption gUILayoutOption10 = ((mWidth <= (nint)gUILayoutOption6) ? gUILayoutOption6 : ((GUILayoutOption)mWidth));
			mWidth = (int)gUILayoutOption10;
			GUILayoutOption gUILayoutOption11 = ((mHeight <= (nint)gUILayoutOption7) ? gUILayoutOption7 : ((GUILayoutOption)mHeight));
			mHeight = (int)gUILayoutOption11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		else
		{
			AdaptScale();
		}
	}

	public int GetCharacterIndex(Vector3 worldPos)
	{
		//IL_0037: Expected Obj, but got VT
		if (~(mShouldBeProcessed ? 1u : 0u) == 0)
		{
			Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
		}
		return UIWidget.FullCompareFunc(this, (UIWidget)worldPos);
	}

	public unsafe int GetCharacterIndex(Vector2 localPos)
	{
		//IL_000d: Expected native int or pointer, but got VT
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = localPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localPos @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		return GetCharacterIndexAtPosition(vector, precise: false);
	}

	public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
	{
		//IL_0014: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got VT
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got VT
		//IL_0103: Expected I4, but got Obj
		bool flag = mChanged;
		int num2 = default;
		int num3 = default;
		BMSymbol bMSymbol2;
		BMSymbol bMSymbol3 = default;
		while (true)
		{
			int num = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (System.Boolean)+C]");
			if ((nint)num < (nint)0)
			{
				BMSymbol bMSymbol = ((List<BMSymbol>)mChanged).get_Item(num2);
				if (!(bMSymbol.sequence != (string)worldPos))
				{
					num2 = num3 + 1;
					continue;
				}
				bMSymbol2 = bMSymbol;
				break;
			}
			if (precise)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj = bMSymbol3 + 8;
				obj = worldPos;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			}
			else
			{
				bMSymbol3 = null;
			}
			bMSymbol2 = bMSymbol3;
			break;
		}
		return (int)bMSymbol2;
	}

	public unsafe int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Ref, but got Unknown
		//IL_0077: Expected Ref, but got F4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_00b1: Expected I, but got Obj
		//IL_00c7: Expected Obj, but got I
		//IL_00ff: Expected VT, but got Ref
		//IL_0013: Expected I, but got Obj
		Camera camera = anchorCamera;
		object obj = default;
		ref Vector3 reference = ref *(Vector3*)(obj + 20);
		reference = ref *(Vector3*)localPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localPos @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		Transform transform = (Transform)(obj + 8);
		transform.Internal_LookAt_Injected(ref *(Vector3*)camera, ref reference);
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v16 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v26 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		reference = ref *(Vector3*)transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector = (Vector2)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		return GetCharacterIndex((int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref *(byte*)obj), precise ? ((KeyCode)1) : KeyCode.None);
	}

	public unsafe string GetWordAtPosition(Vector3 worldPos)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_0028: Expected I4, but got Obj
		//IL_003b: Expected Obj, but got I4
		object obj = worldPos.x;
		int num = obj + 8;
		((int*)num)->m_value = (int)obj;
		return (string)GetCharacterIndex(num, KeyCode.None);
	}

	public unsafe string GetWordAtPosition(Vector2 localPos)
	{
		//IL_000d: Expected native int or pointer, but got VT
		//IL_003c: Expected VT, but got I4
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = localPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localPos @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		int characterIndexAtPosition = GetCharacterIndexAtPosition(vector, precise: true);
		return GetUrlAtPosition((Vector3)characterIndexAtPosition);
	}

	public unsafe string GetWordAtCharacterIndex(int characterIndex)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_0028: Expected I4, but got Obj
		//IL_0045: Expected VT, but got I4
		object obj = ((int*)characterIndex)->m_value;
		int num = obj + 8;
		((int*)num)->m_value = (int)obj;
		int characterIndex2 = GetCharacterIndex(num, (KeyCode)1);
		return GetUrlAtPosition((Vector3)characterIndex2);
	}

	public unsafe string GetUrlAtPosition(Vector3 worldPos)
	{
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected I4, but got Unknown
		//IL_0238: Invalid comparison between VT and I4
		//IL_001c: Invalid comparison between I4 and VT
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0084: Expected I4, but got VT
		//IL_00ab: Expected Obj, but got I
		//IL_00b8: Expected I4, but got Obj
		//IL_00db: Expected I4, but got VT
		//IL_0183: Expected I, but got Obj
		//IL_0199: Expected Obj, but got I
		//IL_0291: Expected I4, but got Obj
		//IL_029d: Expected Obj, but got I4
		//IL_01c4: Expected I, but got Obj
		object obj = default;
		CallingConvention callingConvention = (CallingConvention)(obj + 4);
		string sortingLayerName = ((UIPanel)(object)this).sortingLayerName;
		if (worldPos == (Vector3)(object)(-1))
		{
			return null;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)sortingLayerName.m_stringLength) > System.Runtime.CompilerServices.Unsafe.As<Vector3, UIntPtr>(ref worldPos))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			string text = default;
			object obj2 = text + 16;
			obj2 = 32;
			object obj3 = text + 18;
			obj3 = 10;
			int num = sortingLayerName.LastIndexOf(text, (int)worldPos);
			int num2 = num + 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			obj = 0;
			((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
			UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
			unmanagedFunctionPointerAttribute._002Ector(callingConvention);
			int num3 = sortingLayerName.IndexOf((string)(object)unmanagedFunctionPointerAttribute, (int)worldPos);
			bool flag = num3 == -1;
			bool flag2 = !flag;
			int num4 = num3;
			if (!flag2)
			{
				num4 = sortingLayerName.m_stringLength;
			}
			if (num2 == num4)
			{
				return null;
			}
			int num5 = num4 - num2;
			if (num5 > 0)
			{
				string text2 = sortingLayerName.InternalSubString(num2, num5);
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v30 (Il2CppClass<NGUIText>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v35 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag3 = NGUIText.IsSpace((int)text2);
				return (string)flag3;
			}
			return null;
		}
		return null;
	}

	public unsafe string GetUrlAtPosition(Vector2 localPos)
	{
		//IL_000d: Expected native int or pointer, but got VT
		//IL_003c: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		Vector2 vector = default;
		((Vector2*)(nint)vector)->x = localPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [localPos @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		int characterIndexAtPosition = GetCharacterIndexAtPosition(vector, precise: true);
		return (string)CalculateOffsetToFit((string)characterIndexAtPosition);
	}

	public unsafe string GetUrlAtCharacterIndex(int characterIndex)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		//IL_0028: Expected I4, but got Obj
		//IL_0045: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		object obj = ((int*)characterIndex)->m_value;
		int num = obj + 8;
		((int*)num)->m_value = (int)obj;
		int characterIndex2 = GetCharacterIndex(num, (KeyCode)1);
		return (string)CalculateOffsetToFit((string)characterIndex2);
	}

	public unsafe int GetCharacterIndex(int currentIndex, KeyCode key)
	{
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected VT, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_06f1: Expected I, but got Obj
		//IL_0707: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I4
		//IL_01a6: Expected I, but got Obj
		//IL_06b0: Expected I, but got Obj
		//IL_06c6: Expected Obj, but got I
		//IL_0240: Expected I, but got Obj
		//IL_0256: Expected Obj, but got I
		//IL_01f3: Expected I, but got Obj
		//IL_00e8: Expected I, but got Obj
		//IL_0135: Expected I, but got Obj
		//IL_035c: Expected I, but got Obj
		//IL_0372: Expected Obj, but got I
		//IL_0281: Expected I, but got Obj
		//IL_07ae: Expected VT, but got I4
		//IL_07ae: Expected VT, but got Obj
		//IL_07c0: Expected I, but got Obj
		//IL_07d6: Expected Obj, but got I
		//IL_02ce: Expected I, but got Obj
		//IL_02e4: Expected Obj, but got I
		//IL_039d: Expected I, but got Obj
		//IL_0771: Expected I, but got Obj
		//IL_0787: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I4
		//IL_0851: Expected I, but got Obj
		//IL_0867: Expected Obj, but got I
		//IL_030f: Expected I, but got Obj
		//IL_0991: Expected Obj, but got I4
		//IL_099e: Expected F4, but got Obj
		//IL_0999: Expected native int or pointer, but got VT
		//IL_09b1: Expected I4, but got VT
		//IL_04cc: Expected I, but got Obj
		//IL_0810: Expected I, but got Obj
		//IL_0826: Expected Obj, but got I
		//IL_0566: Expected I, but got Obj
		//IL_057c: Expected Obj, but got I
		//IL_0519: Expected I, but got Obj
		//IL_0953: Expected Obj, but got I4
		//IL_0960: Expected F4, but got Obj
		//IL_095b: Expected native int or pointer, but got VT
		//IL_040e: Expected I, but got Obj
		//IL_045b: Expected I, but got Obj
		//IL_05a7: Expected I, but got Obj
		object obj = default;
		Vector2 vector = (Vector2)(obj + 16);
		object obj2 = obj + 8;
		if (modifier != Modifier.None)
		{
			bool flag = isValid;
			bool flag2;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v19 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				return 0;
			}
			this._002Ector();
			nint num = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v24 (Il2CppClass<UILabel>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag3 = obj3 == null;
			if (key != KeyCode.None)
			{
				if (!flag3)
				{
					nint num2 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v192 (Il2CppClass<UILabel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num3 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v183 (Il2CppClass<NGUIText>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v188 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.ReplaceLinks(ref *(flag ? ((string*)1) : ((string*)null)), (string)(object)mTempVerts, (string)(object)mTempIndices);
			}
			else
			{
				if (!flag3)
				{
					nint num5 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v166 (Il2CppClass<UILabel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v157 (Il2CppClass<NGUIText>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v162 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.PrintExactCharacterPositions((string)flag, mTempVerts, mTempIndices);
			}
			nint num8 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v31 (Il2CppClass<UILabel>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v140 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<Vector3> list = mTempVerts;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v39 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
			if ((nint)0 < (nint)1)
			{
				nint num10 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v123 (Il2CppClass<NGUIText>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num11 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v134 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.bitmapFont = null;
				nint num12 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v130 (Il2CppClass<NGUIText>)+5C]");
				object obj8 = (nint)0 + (nint)4;
				obj8 = 0;
				return 0;
			}
			nint num13 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ S0_v43 (Il2CppClass<UILabel>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num14 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v116 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 vector2 = ((UIPanel)(object)this).CalculateConstrainOffset((Vector2)mTempVerts, (Vector2)0);
			nint num15 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v49 (Il2CppClass<UILabel>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag4 = obj10 == null;
			if (key != KeyCode.None)
			{
				if (!flag4)
				{
					nint num16 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v110 (Il2CppClass<UILabel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num17 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S2_v25 (Il2CppClass<NGUIText>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num18 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S2_v32 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = ((int*)currentIndex)->m_value;
				((Vector2*)(nint)vector)->x = (float)obj;
				int approximateCharacterIndex = NGUIText.GetApproximateCharacterIndex(mTempVerts, mTempIndices, vector);
				bool flag5 = (byte)approximateCharacterIndex != 0;
			}
			else
			{
				if (!flag4)
				{
					nint num19 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ S0_v97 (Il2CppClass<UILabel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num20 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S2_v11 (Il2CppClass<NGUIText>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num21 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S2_v18 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj2 = ((int*)currentIndex)->m_value;
				((Vector2*)(nint)vector)->x = (float)obj2;
				bool flag5 = NGUIText.WrapText((string)(object)mTempVerts, out *(string*)mTempIndices, (byte)(int)vector != 0);
			}
			nint num22 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v56 (Il2CppClass<UILabel>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num23 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S0_v84 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			throw new IndexOutOfRangeException();
		}
		return 0;
	}

	public unsafe Vector3 GetPositionOfCharacter(int characterIndex)
	{
		//IL_167d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected Obj, but got Unknown
		//IL_168b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Expected Obj, but got Unknown
		//IL_1699: Unknown result type (might be due to invalid IL or missing references)
		//IL_169e: Expected Obj, but got Unknown
		//IL_16a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ac: Expected Obj, but got Unknown
		//IL_16d0: Expected VT, but got Obj
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_21eb: Expected I, but got Obj
		//IL_2201: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_222c: Expected I, but got Obj
		//IL_2242: Expected Obj, but got I
		//IL_1722: Expected I, but got Obj
		//IL_1738: Expected Obj, but got I
		//IL_1750: Invalid comparison between Obj and F4
		//IL_01a8: Expected I, but got Obj
		//IL_178b: Expected I, but got Obj
		//IL_17a1: Expected Obj, but got I
		//IL_028a: Expected I, but got Obj
		//IL_1778: Expected Obj, but got I4
		//IL_0324: Expected I, but got Obj
		//IL_033a: Expected Obj, but got I
		//IL_02d7: Expected I, but got Obj
		//IL_0219: Expected I, but got Obj
		//IL_17c7: Expected I4, but got Obj
		//IL_17d5: Expected I, but got Obj
		//IL_17eb: Expected Obj, but got I
		//IL_1803: Invalid comparison between Obj and F4
		//IL_0365: Expected I, but got Obj
		//IL_183e: Expected I, but got Obj
		//IL_1854: Expected Obj, but got I
		//IL_0447: Expected I, but got Obj
		//IL_182b: Expected Obj, but got I4
		//IL_04e1: Expected I, but got Obj
		//IL_04f7: Expected Obj, but got I
		//IL_0494: Expected I, but got Obj
		//IL_03d6: Expected I, but got Obj
		//IL_187a: Expected I4, but got Obj
		//IL_0522: Expected I, but got Obj
		//IL_062e: Expected I, but got Obj
		//IL_0644: Expected Obj, but got I
		//IL_057b: Expected VT, but got Obj
		//IL_18b7: Expected Obj, but got I4
		//IL_18e4: Expected I, but got Obj
		//IL_18fa: Expected Obj, but got I
		//IL_058e: Expected I, but got Obj
		//IL_05a4: Expected Obj, but got I
		//IL_066f: Expected VT, but got Obj
		//IL_189d: Expected F4, but got Obj
		//IL_18a9: Expected I4, but got Obj
		//IL_22ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_22b1: Expected Obj, but got Unknown
		//IL_22c8: Expected VT, but got Obj
		//IL_06bc: Expected I, but got Obj
		//IL_05cf: Expected I, but got Obj
		//IL_0709: Expected I, but got Obj
		//IL_071f: Expected Obj, but got I
		//IL_074a: Expected I, but got Obj
		//IL_07a4: Expected I, but got Obj
		//IL_07ba: Expected Obj, but got I
		//IL_07e5: Expected I, but got Obj
		//IL_084b: Expected I, but got Obj
		//IL_0861: Expected Obj, but got I
		//IL_0cd4: Expected I, but got Obj
		//IL_0cea: Expected Obj, but got I
		//IL_19a1: Expected Obj, but got I4
		//IL_0b23: Expected I, but got Obj
		//IL_0b39: Expected Obj, but got I
		//IL_088c: Expected I, but got Obj
		//IL_0d15: Expected I, but got Obj
		//IL_1b47: Expected Obj, but got I4
		//IL_09d6: Expected I, but got Obj
		//IL_09ec: Expected Obj, but got I
		//IL_08bf: Expected I, but got Obj
		//IL_08d5: Expected Obj, but got I
		//IL_0dd5: Expected VT, but got I4
		//IL_0b64: Expected I, but got Obj
		//IL_19f7: Expected Obj, but got I4
		//IL_1e4d: Invalid comparison between VT and I4
		//IL_0d55: Expected I, but got Obj
		//IL_0d6b: Expected Obj, but got I
		//IL_0a17: Expected I, but got Obj
		//IL_1c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c24: Expected Obj, but got Unknown
		//IL_1c43: Expected VT, but got Obj
		//IL_0c0b: Expected I, but got Obj
		//IL_0c21: Expected Obj, but got I
		//IL_0a4a: Expected I, but got Obj
		//IL_0a60: Expected Obj, but got I
		//IL_092e: Expected Obj, but got I4
		//IL_0d96: Expected I, but got Obj
		//IL_1b9b: Expected Obj, but got I4
		//IL_0b97: Expected I, but got Obj
		//IL_0bad: Expected Obj, but got I
		//IL_1a7c: Expected I, but got Obj
		//IL_1a92: Expected Obj, but got I
		//IL_15e4: Expected I, but got Obj
		//IL_15fa: Expected Obj, but got I
		//IL_1617: Expected VT, but got Obj
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e86: Expected I4, but got Unknown
		//IL_0e93: Expected F4, but got I4
		//IL_0c4c: Expected I, but got Obj
		//IL_0a8b: Expected I, but got Obj
		//IL_21a2: Expected Obj, but got I
		//IL_21ab: Expected Obj, but got I4
		//IL_21b9: Expected I, but got Obj
		//IL_21cf: Expected Obj, but got I
		//IL_21d8: Expected Obj, but got I4
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Expected I4, but got Unknown
		//IL_0e00: Expected I4, but got VT
		//IL_0e0e: Expected I, but got Obj
		//IL_0e24: Expected Obj, but got I
		//IL_0bd8: Expected I, but got Obj
		//IL_0abe: Expected I, but got Obj
		//IL_1633: Expected I, but got Obj
		//IL_1641: Expected VT, but got Obj
		//IL_1c86: Expected I, but got Obj
		//IL_1c9c: Expected Obj, but got I
		//IL_1b10: Expected Obj, but got I4
		//IL_232c: Expected I, but got Obj
		//IL_2342: Expected Obj, but got I
		//IL_0e4f: Expected I, but got Obj
		//IL_2307: Expected Obj, but got I4
		//IL_230f: Expected I4, but got Obj
		//IL_166f: Expected VT, but got Obj
		//IL_0f0d: Expected I, but got Obj
		//IL_1ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce8: Expected Ref, but got Unknown
		//IL_0b10: Expected Obj, but got I4
		//IL_0f40: Expected I, but got Obj
		//IL_1d23: Expected I, but got Obj
		//IL_1d39: Expected Obj, but got I
		//IL_1d7b: Expected Obj, but got I4
		//IL_1d91: Expected Obj, but got I4
		//IL_1086: Invalid comparison between VT and I4
		//IL_0f9d: Expected I, but got Obj
		//IL_10a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a8: Expected VT, but got Unknown
		//IL_1297: Expected I, but got Obj
		//IL_12ad: Expected Obj, but got I
		//IL_0ff5: Expected I, but got Obj
		//IL_100b: Expected Obj, but got I
		//IL_1fd4: Expected I4, but got Obj
		//IL_1fe9: Expected VT, but got Obj
		//IL_1ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2001: Expected Obj, but got Unknown
		//IL_200f: Expected I, but got Obj
		//IL_2025: Expected Obj, but got I
		//IL_1dc0: Expected I4, but got Obj
		//IL_1ddd: Expected VT, but got Obj
		//IL_2053: Expected F4, but got I
		//IL_1375: Expected I, but got Obj
		//IL_1f9b: Expected I4, but got Obj
		//IL_1fb0: Expected VT, but got Obj
		//IL_1fbd: Expected VT, but got Obj
		//IL_1dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e03: Expected Obj, but got Unknown
		//IL_1e11: Expected I, but got Obj
		//IL_1e27: Expected Obj, but got I
		//IL_1036: Expected I, but got Obj
		//IL_20a7: Expected VT, but got Obj
		//IL_13a8: Expected I, but got Obj
		//IL_131e: Expected I, but got Obj
		//IL_1e6a: Expected F4, but got Obj
		//IL_23ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f2: Expected Obj, but got Unknown
		//IL_10c3: Expected I, but got Obj
		//IL_13e8: Expected I, but got Obj
		//IL_13fe: Expected Obj, but got I
		//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cf: Expected Obj, but got Unknown
		//IL_14dd: Expected I, but got Obj
		//IL_14f3: Expected Obj, but got I
		//IL_2372: Unknown result type (might be due to invalid IL or missing references)
		//IL_2377: Expected Obj, but got Unknown
		//IL_2385: Expected I, but got Obj
		//IL_239b: Expected Obj, but got I
		//IL_1457: Unknown result type (might be due to invalid IL or missing references)
		//IL_145c: Expected Obj, but got Unknown
		//IL_20df: Expected VT, but got Obj
		//IL_2116: Expected F4, but got Obj
		//IL_2127: Expected I4, but got Obj
		//IL_2130: Unknown result type (might be due to invalid IL or missing references)
		//IL_2135: Expected Obj, but got Unknown
		//IL_2146: Expected F4, but got I
		//IL_1efe: Expected F4, but got I
		//IL_1103: Expected I, but got Obj
		//IL_1119: Expected Obj, but got I
		//IL_1476: Expected I4, but got Obj
		//IL_1429: Expected I, but got Obj
		//IL_151e: Expected I, but got Obj
		//IL_1f52: Expected VT, but got Obj
		//IL_1177: Expected I, but got Obj
		//IL_1570: Expected I, but got Obj
		//IL_1586: Expected Obj, but got I
		//IL_1144: Expected I, but got Obj
		//IL_218d: Expected VT, but got Obj
		//IL_124b: Expected I4, but got Obj
		//IL_1258: Expected I4, but got VT
		//IL_11b7: Expected I, but got Obj
		//IL_11cd: Expected Obj, but got I
		//IL_15b1: Expected VT, but got Obj
		//IL_122a: Invalid comparison between I4 and VT
		//IL_1f84: Expected VT, but got Obj
		//IL_11f8: Expected I, but got Obj
		GameObject gameObject = default;
		Transform transform = (Transform)(gameObject + 40);
		object obj = gameObject + 32;
		GameObject gameObject2 = (GameObject)(gameObject + 24);
		GameObject gameObject3 = (GameObject)(gameObject + 16);
		UILabel uILabel = default;
		Modifier modifier = uILabel.modifier;
		bool flag = modifier == Modifier.None;
		Vector3 vector = (Vector3)uILabel;
		object obj4;
		object obj7;
		bool flag3;
		bool flag5;
		int num33;
		UnityEngine.Object obj23;
		if (!flag)
		{
			uILabel.mChanged = true;
			uILabel.mShouldBeProcessed = false;
			object obj2 = uILabel + 156;
			object obj3 = uILabel + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v23+8]");
			obj4 = 0 - obj3;
			object obj5 = uILabel + 156;
			object obj6 = uILabel + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+C]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v17+4]");
			obj7 = num - 0;
			int rectWidth;
			if ((object)this == null)
			{
				rectWidth = uILabel.mWidth;
			}
			else
			{
				rectWidth = ((uILabel.mMaxLineWidth == 0) ? 1000000 : uILabel.mMaxLineWidth);
			}
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v33 (Il2CppClass<NGUIText>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num3 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v632 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.rectWidth = rectWidth;
			int rectHeight;
			if ((object)this == null)
			{
				rectHeight = uILabel.mHeight;
			}
			else
			{
				rectHeight = ((uILabel.mMaxLineHeight == 0) ? 1000000 : uILabel.mMaxLineHeight);
			}
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v42 (Il2CppClass<NGUIText>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num5 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v618 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.rectHeight = rectHeight;
			nint num6 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v49 (Il2CppClass<NGUIText>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			bool flag2 = obj10 == null;
			flag3 = obj4 == (object)1f;
			GUILayoutOption gUILayoutOption;
			if (flag3)
			{
				if (!flag2)
				{
					nint num7 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v612 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				gUILayoutOption = (GUILayoutOption)NGUIText.rectWidth;
			}
			else
			{
				if (!flag2)
				{
					nint num8 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v600 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S1_v287 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S1_v293 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num11 = (float)NGUIText.rectWidth * (float)obj4;
				gUILayoutOption = GUILayout.Width(num11);
			}
			nint num12 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v57 (Il2CppClass<NGUIText>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num13 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v586 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.regionWidth = (int)gUILayoutOption;
			nint num14 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v64 (Il2CppClass<NGUIText>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			bool flag4 = obj13 == null;
			flag5 = obj7 == (object)1f;
			GUILayoutOption gUILayoutOption2;
			if (flag5)
			{
				if (!flag4)
				{
					nint num15 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ S0_v580 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				gUILayoutOption2 = (GUILayoutOption)NGUIText.rectHeight;
			}
			else
			{
				if (!flag4)
				{
					nint num16 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v568 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num17 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v276 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj14 = (nint)0 & (nint)0x200;
				if (obj14 != null)
				{
					nint num18 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S1_v282 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num19 = (float)NGUIText.rectHeight * (float)obj7;
				gUILayoutOption2 = GUILayout.Width(num19);
			}
			nint num20 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ S0_v72 (Il2CppClass<NGUIText>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num21 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v554 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.regionHeight = (int)gUILayoutOption2;
			int num24;
			if ((object)this != null)
			{
				Camera camera = uILabel.anchorCamera;
				transform.localScale = (Vector3)camera;
				nint num22 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v266 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num23 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S1_v271 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GUILayoutOption gUILayoutOption3 = GUILayout.Width((float)transform);
				num24 = (int)gUILayoutOption3;
			}
			else
			{
				num24 = uILabel.fontSize;
			}
			nint num25 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S0_v81 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				Vector3 vector2 = (Vector3)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v544 (UnityEngine.Vector3)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num26 = Mathf.Min((int[])num24);
			uILabel.mFinalFontSize = num26;
			uILabel.mScale = 1f;
			nint num27 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v88 (Il2CppClass<NGUIText>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num28 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v538 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (NGUIText.regionWidth >= 1)
			{
				nint num29 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ S0_v100 (Il2CppClass<NGUIText>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num30 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v532 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (NGUIText.regionHeight > -1)
				{
					UnityEngine.Object obj20 = uILabel.ambigiousFont;
					nint num31 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num32 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ S0_v529 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num33 = ((ComputeShader)obj20).FindKernel((string)null);
					if (num33 != 0 && uILabel.supportEncoding)
					{
						bool flag6 = uILabel.isAnchored;
						nint num34 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ S0_v510 (Il2CppClass<UnityEngine.Object>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num35 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S0_v526 (Il2CppClass<UnityEngine.Object>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num36 = ((ComputeShader)flag6).FindKernel(null);
						bool flag7 = num36 == 0;
						obj23 = (UnityEngine.Object)(object)typeof(UnityEngine.Object);
						if (!flag7)
						{
							nint num37 = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ S0_v518 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj24 = (nint)0 & (nint)0x200;
							if (obj24 != null)
							{
								UnityEngine.Object typeFromHandle = (UnityEngine.Object)(object)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ S0_v523 (UnityEngine.Object)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num38 = ((((ComputeShader)flag6).FindKernel(null) == 0) ? 1f : UIRoot.GetPixelSizeAdjustment((GameObject)flag6));
							uILabel.mDensity = num38;
							obj23 = (UnityEngine.Object)(object)typeof(UnityEngine.Object);
						}
					}
					else
					{
						uILabel.mDensity = 1f;
						obj23 = obj20;
					}
					if (characterIndex != 0)
					{
						uILabel._002Ector();
					}
					if (uILabel.mOverflow == Overflow.ResizeFreely)
					{
						int regionWidth;
						if (uILabel.mOverflowWidth < 1)
						{
							nint num39 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S0_v451 (Il2CppClass<NGUIText>)+BA]");
							object obj25 = (nint)0 & (nint)0x200;
							if (obj25 != null)
							{
								nint num40 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S0_v496 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							NGUIText.rectWidth = 1000000;
							NGUIText.regionWidth = 1000000;
							if (uILabel.mOverflowWidth < 1)
							{
								goto IL_22cd;
							}
							nint num41 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S0_v464 (Il2CppClass<NGUIText>)+BA]");
							object obj26 = (nint)0 & (nint)0x200;
							if (obj26 != null)
							{
								nint num42 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ S0_v491 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							nint num43 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ S0_v474 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj27 = (nint)0 & (nint)0x200;
							if (obj27 != null)
							{
								nint num44 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S0_v488 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int rectWidth2 = ((NGUIText.rectWidth >= uILabel.mOverflowWidth) ? uILabel.mOverflowWidth : NGUIText.rectWidth);
							NGUIText.rectWidth = rectWidth2;
							bool flag8 = NGUIText.regionWidth >= uILabel.mOverflowWidth;
							bool flag9 = !flag8;
							UnityEngine.Object obj28 = (UnityEngine.Object)NGUIText.regionWidth;
							if (!flag9)
							{
								obj28 = (UnityEngine.Object)uILabel.mOverflowWidth;
							}
							obj23 = (UnityEngine.Object)uILabel.mOverflowWidth;
							regionWidth = (int)obj28;
						}
						else
						{
							nint num45 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ S0_v437 (Il2CppClass<NGUIText>)+BA]");
							object obj29 = (nint)0 & (nint)0x200;
							if (obj29 != null)
							{
								nint num46 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S0_v445 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							NGUIText.rectWidth = uILabel.mOverflowWidth;
							obj23 = (UnityEngine.Object)uILabel.mOverflowWidth;
							regionWidth = uILabel.mOverflowWidth;
						}
						NGUIText.regionWidth = regionWidth;
						goto IL_22cd;
					}
					if (uILabel.mOverflow == Overflow.ResizeFreely || uILabel.mOverflow == Overflow.ResizeHeight)
					{
						nint num47 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S0_v373 (Il2CppClass<NGUIText>)+BA]");
						object obj30 = (nint)0 & (nint)0x200;
						if (obj30 != null)
						{
							nint num48 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ S0_v382 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NGUIText.rectHeight = 1000000;
						NGUIText.regionHeight = 1000000;
					}
					goto IL_1ba0;
				}
			}
			object obj31 = uILabel + 464;
			obj31 = "";
			vector = (Vector3)typeof(Mathf);
		}
		goto IL_2319;
		IL_2319:
		return vector;
		IL_22cd:
		if (uILabel.mOverflowHeight < 1)
		{
			nint num49 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ S0_v416 (Il2CppClass<NGUIText>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num50 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S0_v425 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.rectHeight = 1000000;
			NGUIText.regionHeight = 1000000;
		}
		else
		{
			nint num51 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ S0_v401 (Il2CppClass<NGUIText>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num52 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v798 @ S0_v410 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.rectHeight = uILabel.mOverflowHeight;
			NGUIText.regionHeight = uILabel.mOverflowHeight;
			obj23 = (UnityEngine.Object)uILabel.mOverflowHeight;
		}
		goto IL_1ba0;
		IL_1ba0:
		if (uILabel.mFinalFontSize < 1)
		{
			Camera camera2 = uILabel.anchorCamera;
			nint num53 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S1_v199 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num54 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ S1_v211 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 forward = Vector3.forward;
			transform = (Transform)(object)gameObject;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)gameObject).m_CachedPtr;
			((Transform)(object)camera2).parent = transform;
			object obj35 = uILabel + 464;
			obj35 = "";
			uILabel.mScale = 1f;
			vector = (Vector3)obj23;
		}
		else
		{
			bool flag10 = uILabel.supportEncoding;
			vector = (Vector3)uILabel.mFinalFontSize;
			GUILayoutOption gUILayoutOption5 = default;
			GUILayoutOption gUILayoutOption9 = default;
			GUILayoutOption gUILayoutOption13 = default;
			while (vector >= (object)1)
			{
				if (flag10)
				{
					uILabel.mFinalFontSize = (int)vector;
					nint num55 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ S0_v352 (Il2CppClass<NGUIText>)+BA]");
					object obj36 = (nint)0 & (nint)0x200;
					if (obj36 != null)
					{
						nint num56 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ S0_v358 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUIText.fontSize = uILabel.mFinalFontSize;
				}
				else
				{
					int num57 = (int)(vector / uILabel.mFinalFontSize);
					uILabel.mScale = num57;
					float fontScale;
					if (num33 != 0)
					{
						fontScale = uILabel.mScale;
					}
					else
					{
						UISpriteData sprite = uILabel.mFont.sprite;
						int num58 = uILabel.mFontSize / sprite;
						fontScale = (float)num58 * uILabel.mScale;
					}
					nint num59 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ S0_v331 (Il2CppClass<NGUIText>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num60 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S0_v337 (Il2CppClass<NGUIText>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					NGUIText.fontScale = fontScale;
				}
				nint num61 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ S0_v157 (Il2CppClass<NGUIText>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num62 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ S0_v324 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.Prepare(null);
				string sortingLayerName = ((UIPanel)(object)uILabel).sortingLayerName;
				ref int index = ref *(int*)(uILabel + 464);
				bool flag11 = uILabel.mOverflow == Overflow.ClampContent && uILabel.mOverflowEllipsis;
				nint num63 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ S2_v20 (Il2CppClass<NGUIText>)+BA]");
				object obj39 = (nint)0 & (nint)0x200;
				if (obj39 != null)
				{
					nint num64 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1035 @ S2_v51 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag12 = flag11;
				bool flag13 = NGUIText.ReplaceLink(ref *(string*)sortingLayerName, ref index, null, null, (string)flag12);
				object obj40 = (flag13 ? 1 : 0) | (int)uILabel.mOverflow;
				if (obj40 != null)
				{
					if (uILabel.mOverflow == Overflow.ResizeFreely)
					{
						nint num65 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ S0_v256 (Il2CppClass<NGUIText>)+BA]");
						object obj41 = (nint)0 & (nint)0x200;
						if (obj41 != null)
						{
							nint num66 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ S0_v321 (Il2CppClass<NGUIText>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						NGUITools.AddWidgetCollider(gameObject, (byte)(int)uILabel.mProcessedText != 0);
						obj = gameObject;
						transform = (Transform)obj;
						uILabel.mCalculatedSize = (Vector2)transform;
						if (!flag13 && uILabel.mOverflowWidth >= 1)
						{
							goto IL_107d;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj42 = uILabel + 472;
						nint num67 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1148 @ S1_v146 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj43 = (nint)0 & (nint)0x200;
						if (obj43 != null)
						{
							nint num68 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1190 @ S1_v180 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						GUILayoutOption gUILayoutOption4 = GUILayout.Width((float)obj42);
						bool flag14 = System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption5) <= System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption4);
						bool flag15 = !flag14;
						GUILayoutOption gUILayoutOption6 = gUILayoutOption5;
						if (!flag15)
						{
							gUILayoutOption6 = gUILayoutOption4;
						}
						if (!flag3)
						{
							nint num69 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ S0_v307 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj44 = (nint)0 & (nint)0x200;
							if (obj44 != null)
							{
								nint num70 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S0_v314 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num71 = (float)gUILayoutOption6 / (float)obj4;
							GUILayoutOption gUILayoutOption7 = GUILayout.Width(num71);
							gUILayoutOption6 = gUILayoutOption7;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						object obj45 = uILabel + 472;
						nint num72 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ S1_v158 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj46 = (nint)0 & (nint)0x200;
						if (obj46 != null)
						{
							nint num73 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ S1_v174 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1294 @ S1_v155+4]");
						GUILayoutOption gUILayoutOption8 = GUILayout.Width(0f);
						bool flag16 = System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption9) <= System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption8);
						bool flag17 = !flag16;
						GUILayoutOption gUILayoutOption10 = gUILayoutOption9;
						if (!flag17)
						{
							gUILayoutOption10 = gUILayoutOption8;
						}
						bool flag18 = !flag5;
						bool flag19 = !flag18;
						vector = (Vector3)gUILayoutOption10;
						if (!flag19)
						{
							nint num74 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ S0_v295 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj47 = (nint)0 & (nint)0x200;
							if (obj47 != null)
							{
								nint num75 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1377 @ S0_v302 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							float num76 = (float)gUILayoutOption10 / (float)obj7;
							GUILayoutOption gUILayoutOption11 = GUILayout.Width(num76);
							vector = (Vector3)gUILayoutOption11;
						}
						if (uILabel.mWidth != (nint)gUILayoutOption6 || (object)uILabel.mHeight != (object)vector)
						{
							uILabel.mWidth = (int)gUILayoutOption6;
							uILabel.mHeight = (int)vector;
							if (uILabel.onChange != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
							}
						}
					}
					else
					{
						nint num77 = (nint)typeof(NGUIText);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v195 (Il2CppClass<NGUIText>)+BA]");
						object obj48 = (nint)0 & (nint)0x200;
						bool flag20 = obj48 == null;
						if (uILabel.mOverflow != Overflow.ResizeHeight)
						{
							if (!flag20)
							{
								nint num78 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ S0_v250 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							NGUITools.AddWidgetCollider(gameObject3, (byte)(int)uILabel.mProcessedText != 0);
							transform = (Transform)(object)gameObject3;
							uILabel.mCalculatedSize = (Vector2)transform;
							vector = (Vector3)uILabel.mProcessedText;
						}
						else
						{
							if (!flag20)
							{
								nint num79 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ S0_v241 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							NGUITools.AddWidgetCollider(gameObject2, (byte)(int)uILabel.mProcessedText != 0);
							transform = (Transform)(object)gameObject2;
							uILabel.mCalculatedSize = (Vector2)transform;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
							object obj49 = uILabel + 472;
							nint num80 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S1_v108 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj50 = (nint)0 & (nint)0x200;
							if (obj50 != null)
							{
								nint num81 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ S1_v124 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ S1_v105+4]");
							GUILayoutOption gUILayoutOption12 = GUILayout.Width(0f);
							bool flag21 = System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption13) <= System.Runtime.CompilerServices.Unsafe.As<GUILayoutOption, UIntPtr>(ref gUILayoutOption12);
							bool flag22 = !flag21;
							GUILayoutOption gUILayoutOption14 = gUILayoutOption13;
							if (!flag22)
							{
								gUILayoutOption14 = gUILayoutOption12;
							}
							bool flag23 = !flag5;
							bool flag24 = !flag23;
							vector = (Vector3)gUILayoutOption12;
							if (!flag24)
							{
								nint num82 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S0_v230 (Il2CppClass<UnityEngine.Mathf>)+BA]");
								object obj51 = (nint)0 & (nint)0x200;
								if (obj51 != null)
								{
									nint num83 = (nint)typeof(Mathf);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ S0_v237 (Il2CppClass<UnityEngine.Mathf>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								float num84 = (float)gUILayoutOption14 / (float)obj7;
								GUILayoutOption gUILayoutOption15 = GUILayout.Width(num84);
								vector = (Vector3)typeof(Mathf);
								gUILayoutOption14 = gUILayoutOption15;
							}
							object obj52 = gUILayoutOption14 & 1;
							if (obj52 != null)
							{
								GUILayoutOption gUILayoutOption16 = (GUILayoutOption)(gUILayoutOption14 + 1);
								gUILayoutOption14 = gUILayoutOption16;
							}
							if (uILabel.mHeight != (nint)gUILayoutOption14)
							{
								uILabel.mHeight = (int)gUILayoutOption14;
								if (uILabel.onChange != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
								}
							}
						}
					}
					if ((object)this == null)
					{
						break;
					}
					object obj53 = uILabel + 472;
					nint num85 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ S0_v181 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj54 = (nint)0 & (nint)0x200;
					if (obj54 != null)
					{
						nint num86 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1218 @ S0_v189 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GUILayoutOption gUILayoutOption17 = GUILayout.Width((float)obj53);
					uILabel.height = (int)gUILayoutOption17;
					object obj55 = uILabel + 472;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ S1_v80+4]");
					GUILayoutOption gUILayoutOption18 = GUILayout.Width(0f);
					Color color = ((UIWidget)(object)gUILayoutOption18).color;
					Camera camera3 = uILabel.anchorCamera;
					nint num87 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1336 @ S1_v85 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						Vector3 vector3 = (Vector3)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ S1_v93 (UnityEngine.Vector3)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 forward2 = Vector3.forward;
					transform = (Transform)(object)gameObject;
					((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)gameObject).m_CachedPtr;
					((Transform)(object)camera3).parent = transform;
					vector = (Vector3)typeof(Vector3);
					break;
				}
				goto IL_107d;
				IL_107d:
				if (vector < (object)2)
				{
					break;
				}
				Vector3 vector4 = vector - 1;
				vector = vector4;
			}
		}
		if (characterIndex != 0)
		{
			nint num88 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ S0_v132 (Il2CppClass<NGUIText>)+BA]");
			object obj57 = (nint)0 & (nint)0x200;
			bool flag25 = obj57 == null;
			vector = (Vector3)typeof(NGUIText);
			if (!flag25)
			{
				nint num89 = (nint)typeof(NGUIText);
				vector = (Vector3)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ S0_v142 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					vector = (Vector3)typeof(NGUIText);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.Vector3)+5C]");
			object obj58 = 0;
			obj58 = 0;
			nint num90 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S0_v139 (Il2CppClass<NGUIText>)+5C]");
			object obj59 = (nint)0 + (nint)4;
			obj59 = 0;
		}
		goto IL_2319;
	}

	public unsafe bool TryGetPositionOfWord(string word, out Vector3 wordPosition)
	{
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected VT, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_07e2: Expected Obj, but got I4
		//IL_0a76: Expected I4, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0830: Expected I, but got Obj
		//IL_0846: Expected Obj, but got I
		//IL_0ae7: Expected Obj, but got I4
		//IL_00c0: Expected I, but got Obj
		//IL_065d: Expected I, but got Obj
		//IL_0673: Expected Obj, but got I
		//IL_010d: Expected I, but got Obj
		//IL_0a8a: Expected I, but got Obj
		//IL_0aa0: Expected Obj, but got I
		//IL_0aa9: Expected Obj, but got I4
		//IL_0ab7: Expected Obj, but got Ref
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_069e: Expected I, but got Obj
		//IL_0873: Expected VT, but got I4
		//IL_0873: Expected VT, but got Obj
		//IL_019b: Expected I, but got Obj
		//IL_07aa: Expected Obj, but got I
		//IL_08f9: Expected I, but got Obj
		//IL_090f: Expected Obj, but got I
		//IL_01e8: Expected I, but got Obj
		//IL_01fe: Expected Obj, but got I
		//IL_0610: Expected I, but got Obj
		//IL_0296: Expected I, but got Obj
		//IL_02ac: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_0944: Expected I, but got Obj
		//IL_095a: Expected Obj, but got I
		//IL_0984: Expected F4, but got Obj
		//IL_097f: Expected native int or pointer, but got VT
		//IL_09ac: Expected Obj, but got Ref
		//IL_02d7: Expected I, but got Obj
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_0324: Expected I, but got Obj
		//IL_0a17: Expected Obj, but got I4
		//IL_0447: Expected I4, but got F4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected Obj, but got Unknown
		//IL_09d7: Expected I, but got Obj
		//IL_09ed: Expected Obj, but got I
		//IL_0b42: Expected I, but got Obj
		//IL_0b58: Expected Obj, but got I
		//IL_0a3e: Expected Obj, but got I4
		//IL_048c: Expected I4, but got F4
		//IL_0b8a: Expected F4, but got Obj
		//IL_0b85: Expected native int or pointer, but got VT
		//IL_0b9d: Expected I4, but got VT
		//IL_04e8: Expected I, but got Obj
		//IL_0535: Expected I, but got Obj
		//IL_0582: Expected I, but got Obj
		//IL_0598: Expected Obj, but got I
		//IL_05c3: Expected I, but got Obj
		//IL_04b8: Expected Obj, but got F4
		//IL_04d5: Expected Obj, but got F4
		object obj = default;
		Vector2 vector = (Vector2)(obj + 28);
		object obj2 = obj + 16;
		object obj3 = obj + 8;
		obj3 = 0;
		string text = default;
		if (modifier != Modifier.None)
		{
			bool flag = isValid;
			bool flag2;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (System.Boolean)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				text = null;
			}
			else
			{
				int num = fontSize;
				this._002Ector();
				nint num2 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v26 (Il2CppClass<UILabel>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num3 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v210 (Il2CppClass<UILabel>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num4 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v38 (Il2CppClass<NGUIText>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num5 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v206 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.PrintExactCharacterPositions((string)flag, mTempVerts, mTempIndices);
				List<Vector3> list = mTempVerts;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v48 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
				if ((nint)0 >= (nint)1)
				{
					nint num6 = (nint)typeof(UILabel);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v75 (Il2CppClass<UILabel>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num7 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v200 (Il2CppClass<UILabel>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Vector3 vector2 = ((UIPanel)(object)this).CalculateConstrainOffset((Vector2)mTempVerts, (Vector2)0);
					List<int> list2 = mTempIndices;
					int num8 = 0;
					while (true)
					{
						int num9 = num8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S0_v85 (System.Collections.Generic.List`1<System.Int32>)+C]");
						if ((nint)num9 < (nint)0)
						{
							nint num10 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v111 (Il2CppClass<UILabel>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num11 = (nint)typeof(UILabel);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v194 (Il2CppClass<UILabel>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num12 = mTempIndices.get_Item(num8);
							if (num12 != (nint)text)
							{
								int num13 = num8 + 1;
								num8 = num13;
								continue;
							}
							nint num14 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v121 (Il2CppClass<UILabel>)+BA]");
							object obj8 = (nint)0 & (nint)0x200;
							if (obj8 != null)
							{
								nint num15 = (nint)typeof(UILabel);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v186 (Il2CppClass<UILabel>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
							nint num16 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v127 (Il2CppClass<UnityEngine.Vector2>)+BA]");
							object obj9 = (nint)0 & (nint)0x200;
							if (obj9 != null)
							{
								nint num17 = (nint)typeof(Vector2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v182 (Il2CppClass<UnityEngine.Vector2>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((Vector2*)(nint)vector)->x = (float)obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
							_ = 0;
							Vector3 vector3 = vector;
							object obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref wordPosition, 273));
							if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref wordPosition) != (void*)273)
							{
								if ((nint)obj10 != 1)
								{
									if ((nint)obj10 != 2 && (nint)obj10 != 3 && (nint)obj10 != 4)
									{
										if ((nint)obj10 != 5)
										{
											if ((nint)obj10 == 6)
											{
												float num18 = (float)obj3 + 1000f;
												obj3 = num18;
											}
										}
										else
										{
											float num19 = (float)obj3 - 1000f;
											obj3 = num19;
										}
									}
								}
								else
								{
									object obj11 = obj3 + 4;
									int num20 = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingY : ((int)mFloatSpacingY));
									object obj12 = num + num20;
									object obj13 = obj11 - obj12;
									obj11 = obj13;
								}
							}
							else
							{
								object obj14 = obj3 + 4;
								int num21 = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingY : ((int)mFloatSpacingY));
								object obj15 = num + num21;
								object obj16 = obj14 + obj15;
								obj14 = obj16;
							}
							nint num22 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v138 (Il2CppClass<UILabel>)+BA]");
							object obj17 = (nint)0 & (nint)0x200;
							if (obj17 != null)
							{
								nint num23 = (nint)typeof(UILabel);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v166 (Il2CppClass<UILabel>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							nint num24 = (nint)typeof(NGUIText);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S2_v17 (Il2CppClass<NGUIText>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num25 = (nint)typeof(NGUIText);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S2_v24 (Il2CppClass<NGUIText>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj = obj3;
							((Vector2*)(nint)vector)->x = (float)obj;
							bool flag3 = NGUIText.WrapText((string)(object)mTempVerts, out *(string*)mTempIndices, (byte)(int)vector != 0);
							if ((flag3 ? 1 : 0) != (nint)text)
							{
								nint num26 = (nint)typeof(UILabel);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v148 (Il2CppClass<UILabel>)+BA]");
								object obj19 = (nint)0 & (nint)0x200;
								if (obj19 != null)
								{
									nint num27 = (nint)typeof(UILabel);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ S0_v160 (Il2CppClass<UILabel>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								break;
							}
						}
						nint num28 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v93 (Il2CppClass<UILabel>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num29 = (nint)typeof(UILabel);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v104 (Il2CppClass<UILabel>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						throw new IndexOutOfRangeException();
					}
					throw new IndexOutOfRangeException();
				}
				nint num30 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v53 (Il2CppClass<NGUIText>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num31 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v68 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.bitmapFont = null;
				nint num32 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v60 (Il2CppClass<NGUIText>)+5C]");
				object obj22 = (nint)0 + (nint)4;
				obj22 = 0;
				object obj23 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref wordPosition, 273));
				if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref wordPosition) == (void*)273)
				{
					goto IL_0790;
				}
				if ((nint)obj23 == 1)
				{
					goto IL_079a;
				}
				if ((nint)obj23 != 2 && (nint)obj23 != 3 && (nint)obj23 != 4)
				{
					if ((nint)obj23 == 5)
					{
						goto IL_0790;
					}
					if ((nint)obj23 == 6)
					{
						goto IL_079a;
					}
				}
			}
		}
		goto IL_0a71;
		IL_0a71:
		return (byte)(int)text != 0;
		IL_0790:
		text = null;
		goto IL_0a71;
		IL_079a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (System.Boolean)+8]");
		text = (string)0;
		goto IL_0a71;
	}

	public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
	{
		//IL_0023: Expected Obj, but got VT
		//IL_0023: Expected Obj, but got VT
		//IL_0023: Expected Obj, but got I4
		//IL_0023: Expected Obj, but got I4
		((UIWidget)(object)geometry).WriteToBuffers((List<Vector3>)start, (List<Vector2>)end, (List<Color>)(object)caret, (List<Vector3>)(object)highlight, (List<Vector4>)caretColor, (List<Vector4>)highlightColor);
	}

	public unsafe override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0423: Expected Obj, but got I4
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected Obj, but got Unknown
		//IL_0440: Expected Obj, but got I4
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected Obj, but got Unknown
		//IL_045d: Expected Obj, but got I4
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_047a: Expected Obj, but got I4
		//IL_0498: Expected I, but got Obj
		//IL_04ae: Expected Obj, but got I
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d9: Expected I4, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected I4, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected Obj, but got Unknown
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected Obj, but got Unknown
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_055e: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_012f: Expected I4, but got F4
		//IL_00eb: Expected Obj, but got I4
		//IL_058c: Expected Obj, but got I4
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_0665: Expected Obj, but got I
		//IL_0682: Expected Obj, but got I
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected Obj, but got Unknown
		//IL_070f: Expected Obj, but got I
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected Obj, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0180: Expected Obj, but got F4
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01e7: Expected Obj, but got I
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_023a: Expected Obj, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got F4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I
		//IL_0383: Expected I4, but got Obj
		//IL_039d: Expected I4, but got Obj
		//IL_03c4: Expected I4, but got Obj
		//IL_03c4: Expected I4, but got Obj
		//IL_0407: Expected I4, but got Obj
		//IL_0407: Expected I4, but got Obj
		//IL_0407: Expected I4, but got Obj
		//IL_0407: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 128;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 112;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 96;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 80;
		obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v139 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = obj2 + 160;
		int num4 = obj2 + 144;
		object obj7 = obj2 - -64;
		object obj8 = obj2 + 48;
		object obj9 = obj2 + 32;
		object obj10 = obj2 + 16;
		UnityEngine.Object obj11 = default;
		if (obj11 != null)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v159 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)mSpacingX).FindKernel(null) != 0)
		{
			Vector2 textureRectOffset = ((Sprite)mSpacingX).textureRectOffset;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			((int*)num3)->m_value = 0;
			_ = 0;
			((int*)num3)->m_value = 0;
			_ = 0f;
		}
		obj5 = ((int*)num3)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28 (System.Int32)+8]");
		_ = 0;
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj4 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v32+8]");
		_ = 0;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		object obj13 = 0 + obj3;
		object obj14 = obj3 + obj8;
		obj3 = obj14;
		object obj15 = obj13 - obj3;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj16 = num7 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+4]");
		object obj17 = num8 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj18 = obj16 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		object obj19 = 0 + obj3;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v38+8]");
		object obj20 = obj19 - 0;
		object obj21 = obj20 - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+C]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj22 = num9 + 0;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
		object obj23 = obj22 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj24 = obj23 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj25 = default;
		float num10 = 1f / (float)obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj26 = default;
		float num11 = 1f / (float)obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		object obj27 = 0 + obj;
		float num12 = (float)obj * num10;
		obj = num12;
		object obj28 = obj27 - obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		object obj29 = 0 + obj;
		float num13 = (float)obj29 * num10;
		float num14 = num13 - (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		nint num15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj30 = num15 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		float num16 = 0f * num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj31 = obj30 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		object obj32 = num17 + 0;
		float num18 = (float)obj32 * num11;
		float num19 = num18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
		float num20 = num19 - 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		object obj33 = 0 + obj3;
		float num21 = (float)obj3 * num10;
		obj3 = num21;
		object obj34 = obj33 - obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		object obj35 = 0 + obj3;
		float num22 = (float)obj35 * num10;
		float num23 = num22 - (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+C]");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj36 = num24 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		float num25 = 0f * num11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj37 = obj36 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+C]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		object obj38 = num26 + 0;
		float num27 = (float)obj38 * num11;
		float num28 = num27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+4]");
		float num29 = num28 - 0f;
		((int*)num4)->m_value = (int)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		((int*)num3)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		SetAnchor((GameObject)(object)verts, (int)uvs, (int)cols, num4, num3);
		if (onPostFill != null)
		{
			OnPostFillCallback onPostFillCallback = onPostFill;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [verts @ L1 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+C]");
			((DeflateManager.Config)(object)onPostFillCallback)._002Ector((int)this, 0, (int)verts, (int)uvs, (DeflateFlavor)cols);
		}
	}

	public unsafe Vector2 ApplyOffset(List<Vector3> verts, int start)
	{
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected VT, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected Obj, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05cf: Expected Obj, but got I4
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected Obj, but got Unknown
		//IL_05ec: Expected Obj, but got I4
		//IL_05f5: Expected Obj, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0020: Expected F4, but got Obj
		//IL_001b: Expected native int or pointer, but got VT
		//IL_0035: Expected F4, but got I
		//IL_0030: Expected native int or pointer, but got VT
		//IL_0042: Expected Obj, but got F4
		//IL_0067: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I
		//IL_0628: Expected Obj, but got I
		//IL_0652: Expected Obj, but got VT
		//IL_065f: Expected Obj, but got VT
		//IL_0682: Expected I, but got Obj
		//IL_0698: Expected Obj, but got I
		//IL_06b5: Expected I, but got Obj
		//IL_00a8: Expected I, but got Obj
		//IL_0719: Expected F4, but got Obj
		//IL_0714: Expected native int or pointer, but got VT
		//IL_072e: Expected F4, but got I
		//IL_0729: Expected native int or pointer, but got VT
		//IL_0744: Expected Obj, but got I
		//IL_0751: Expected Obj, but got F4
		//IL_076d: Expected I4, but got Obj
		//IL_076d: Expected Obj, but got I4
		//IL_0781: Expected I, but got Obj
		//IL_0797: Expected Obj, but got I
		//IL_07a0: Expected Obj, but got I4
		//IL_07b0: Expected VT, but got Obj
		//IL_07b0: Expected VT, but got Obj
		//IL_07b0: Expected Obj, but got VT
		//IL_07c2: Expected I, but got Obj
		//IL_07d8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0807: Expected Obj, but got I
		//IL_01c6: Expected I, but got Obj
		//IL_01f6: Expected I, but got Obj
		//IL_022f: Expected I, but got Obj
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_0455: Expected I4, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_021c: Expected I, but got Obj
		//IL_06d0: Expected F4, but got Obj
		//IL_06cb: Expected native int or pointer, but got VT
		//IL_06e5: Expected F4, but got I
		//IL_06e0: Expected native int or pointer, but got VT
		//IL_08bb: Expected I, but got Obj
		//IL_08d1: Expected Obj, but got I
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected Obj, but got Unknown
		//IL_02f4: Expected F4, but got Obj
		//IL_02ef: Expected native int or pointer, but got VT
		//IL_030d: Expected Obj, but got I
		//IL_0179: Expected I, but got Obj
		//IL_083a: Expected F4, but got Obj
		//IL_0835: Expected native int or pointer, but got VT
		//IL_0850: Expected Obj, but got F4
		//IL_0888: Unsupported input type for neg.
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected Obj, but got Unknown
		//IL_089e: Expected Obj, but got I
		//IL_0468: Expected I, but got Obj
		//IL_03b8: Expected I4, but got Obj
		//IL_056d: Expected I4, but got Obj
		//IL_056d: Expected I4, but got Obj
		//IL_056d: Expected I4, but got VT
		//IL_056d: Expected Obj, but got I
		//IL_03d3: Expected F4, but got Obj
		//IL_03ce: Expected native int or pointer, but got VT
		//IL_03e1: Expected Obj, but got F4
		//IL_0387: Expected I4, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0441: Expected I4, but got Obj
		//IL_0504: Expected F4, but got Obj
		//IL_04ff: Expected native int or pointer, but got VT
		//IL_0519: Expected F4, but got I
		//IL_0514: Expected native int or pointer, but got VT
		//IL_052a: Expected Obj, but got I4
		object obj = default;
		Color color = (Color)(obj - -64);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 16;
		object obj5 = obj + 8;
		object obj6 = obj + 80;
		obj6 = 0;
		_ = 0;
		object obj7 = obj + 56;
		obj7 = 0;
		Vector2 vector = default;
		if (((UILabel)vector).modifier == Modifier.None)
		{
			goto IL_0828;
		}
		object obj8 = vector + 80;
		((Color*)(nint)color)->r = (float)obj8;
		Color color2 = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v16+8]");
		((Color*)(nint)color2)->b = 0f;
		obj6 = color.r;
		_ = color.b;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+4C]");
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v148 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+128]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+128]");
			if (((UIFont)0).packedFontShader)
			{
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
				_ = 0;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v182 (Il2CppClass<NGUITools>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v191 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Color*)(nint)color)->r = (float)obj2;
				Color color3 = color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((Color*)(nint)color3)->b = 0f;
				Color color4 = NGUITools.GammaToLinearSpace(color);
				obj6 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				_ = 0;
			}
		}
		bool flag = ((UILabel)vector).isValid;
		((UILabel)vector)._002Ector();
		obj2 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		nint num5 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v42 (Il2CppClass<NGUIText>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		bool flag2 = obj11 == null;
		nint num6 = (nint)typeof(NGUIText);
		if (!flag2)
		{
			nint num7 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S1_v127 (Il2CppClass<NGUIText>)+74]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num6 = (nint)typeof(NGUIText);
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num6 = (nint)typeof(NGUIText);
			}
		}
		((Color*)(nint)color)->r = (float)obj2;
		Color color5 = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Color*)(nint)color5)->b = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ L4_v5 (Il2CppClass<NGUIText>)+5C]");
		object obj12 = (nint)0 + (nint)32;
		obj12 = color.r;
		_ = color.b;
		NGUITools.FitOnScreen((Camera)flag, (Transform)(object)this, (byte)(int)verts != 0, (byte)start != 0);
		NGUIText.bitmapFont = null;
		nint num8 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v46 (Il2CppClass<NGUIText>)+5C]");
		object obj13 = (nint)0 + (nint)4;
		obj13 = 0;
		Vector3 vector2 = ((UIPanel)vector).CalculateConstrainOffset((Vector2)this, (Vector2)leftAnchor);
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v56 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v123 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+128]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+128]");
			Texture2D texture = ((UIFont)0).texture;
			if ((object)texture != null)
			{
				goto IL_0828;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+144]");
		int maxLazy;
		if ((nint)0 != 0)
		{
			object obj15 = vector + 348;
			obj7 = obj15;
			object obj16 = vector + 348;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v83+4]");
			_ = 0;
			((Color*)(nint)color)->r = (float)obj7;
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
			object obj17 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+144]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+144]");
				if ((nint)0 != 3)
				{
					maxLazy = (int)leftAnchor;
					goto IL_08ad;
				}
			}
			((Color*)(nint)color)->r = (float)obj7;
			obj2 = obj7;
			object obj18 = 0f - color.r;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
			obj3 = obj7;
			obj4 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
			obj5 = obj7;
			obj = obj7;
			object obj19 = 0 - obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj20 = -0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+144]");
			bool flag5 = (nint)0 == 3;
			bool flag6 = !flag5;
			maxLazy = (int)leftAnchor;
			if (!flag6)
			{
				((Color*)(nint)color)->r = (float)obj7;
				object obj21 = 0f - color.r;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
				obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
				obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
				object obj22 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C6E");
				maxLazy = (int)leftAnchor;
			}
		}
		else
		{
			maxLazy = (int)leftAnchor;
		}
		goto IL_08ad;
		IL_08ad:
		nint num11 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v58 (Il2CppClass<NGUIText>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num12 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ S0_v92 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUIText.symbolStyle == NGUIText.SymbolStyle.NoOutline)
		{
			int num13 = 0;
			while (true)
			{
				int num14 = num13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [start @ L3 (System.Int32)+C]");
				if ((nint)num14 >= (nint)0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8875");
				if (color.r == -1f)
				{
					Color black = Color.black;
					((Color*)(nint)color)->r = (float)obj2;
					Color color6 = color;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					((Color*)(nint)color6)->b = 0f;
					((List<Color>)start).set_Item(num13, color);
				}
				int num15 = num13 + 1;
				num13 = num15;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+78]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+78]");
			((DeflateManager.Config)0)._002Ector((int)vector, maxLazy, (int)this, (int)verts, (DeflateFlavor)start);
		}
		goto IL_0828;
		IL_0828:
		return vector;
	}

	public void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, int start, int end, float x, float y)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public int CalculateOffsetToFit(string text)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_01df: Expected I4, but got Obj
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0303: Expected I4, but got Obj
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01c8: Expected I4, but got Obj
		string sortingLayerName = ((UIPanel)(object)this).sortingLayerName;
		int result;
		int num;
		if ((nint)text == -1)
		{
			result = 0;
		}
		else
		{
			object obj = sortingLayerName.m_stringLength - 6;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text))
			{
				string[] array = sortingLayerName.Split((char[])(object)text);
				object obj2 = array & 0xFFFF;
				if ((nint)obj2 == 91)
				{
					char[] separator = (char[])(object)(text + 1);
					string[] array2 = sortingLayerName.Split(separator);
					object obj3 = array2 & 0xFFFF;
					if ((nint)obj3 == 117)
					{
						char[] separator2 = (char[])(object)(text + 2);
						string[] array3 = sortingLayerName.Split(separator2);
						object obj4 = array3 & 0xFFFF;
						if ((nint)obj4 == 114)
						{
							char[] separator3 = (char[])(object)(text + 3);
							string[] array4 = sortingLayerName.Split(separator3);
							object obj5 = array4 & 0xFFFF;
							if ((nint)obj5 == 108)
							{
								char[] separator4 = (char[])(object)(text + 4);
								string[] array5 = sortingLayerName.Split(separator4);
								object obj6 = array5 & 0xFFFF;
								if ((nint)obj6 == 61)
								{
									num = (int)text;
									goto IL_0211;
								}
							}
						}
					}
				}
				int num2 = sortingLayerName.LastIndexOf("[url=", (StringComparison)text);
				bool flag = num2 == -1;
				num = num2;
				result = 0;
				if (!flag)
				{
					goto IL_0211;
				}
			}
			else
			{
				result = 0;
			}
		}
		goto IL_0348;
		IL_0348:
		return result;
		IL_0211:
		StringComparison stringComparison = (StringComparison)(num + 5);
		int num3 = sortingLayerName.IndexOf("]", stringComparison);
		if (num3 == -1)
		{
			result = 0;
		}
		else
		{
			int num4 = sortingLayerName.IndexOf("[/url]", (StringComparison)num3);
			bool flag2 = num4 != -1;
			bool flag3 = num4 < (nint)text;
			object obj7 = flag2 & flag3;
			if (obj7 != null)
			{
				result = 0;
			}
			else
			{
				int length = (int)(num3 - stringComparison);
				string text2 = sortingLayerName.InternalSubString((int)stringComparison, length);
				result = (int)text2;
			}
		}
		goto IL_0348;
	}

	public void SetCurrentProgress()
	{
		//IL_0266: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_0022: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009f: Expected I, but got Obj
		//IL_00b5: Expected Obj, but got I
		//IL_01c6: Expected F4, but got Obj
		//IL_01d4: Expected I4, but got Obj
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_01f0: Expected F4, but got I
		//IL_01fe: Expected I4, but got Obj
		//IL_00e0: Expected I, but got Obj
		bool flag = (object)mFont == null;
		bool flag2 = !flag;
		ComputeShader computeShader = (ComputeShader)(object)mFont;
		if (!flag2)
		{
			computeShader = (ComputeShader)(object)mTrueTypeFont;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (computeShader.FindKernel(null) == 0)
		{
			return;
		}
		mWidth = 100000;
		mHeight = 100000;
		Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(1);
		object obj2 = this + 472;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj2);
		mWidth = (int)gUILayoutOption;
		object obj4 = this + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v17+4]");
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
		mHeight = (int)gUILayoutOption2;
		if ((mWidth & 1) != 0)
		{
			int num5 = mWidth + 1;
			mWidth = num5;
		}
		if ((mHeight & 1) != 0)
		{
			int num6 = mHeight + 1;
			mHeight = num6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public void SetCurrentPercent()
	{
		//IL_008f: Expected Obj, but got F4
		//IL_009d: Expected I, but got Obj
		//IL_00b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got F4
		//IL_0080: Expected I4, but got Obj
		object obj = 0f;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)UIProgressBar.current).FindKernel((string)null) != 0)
		{
			float num3 = UIProgressBar.current.alpha;
			obj = num3;
			OverflowException ex = new OverflowException();
			fontSize = (int)ex;
		}
	}

	public void SetCurrentSelection()
	{
		//IL_010c: Expected I, but got Obj
		//IL_0122: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00f8: Expected I4, but got Obj
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)UIProgressBar.current).FindKernel((string)null) == 0)
		{
			return;
		}
		float num3 = UIProgressBar.current.alpha;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v27 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num6 = num3 * 100f;
		GUILayoutOption gUILayoutOption = GUILayout.Width(num6);
		object obj3 = gUILayoutOption;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = text2 + "%";
		fontSize = (int)text;
	}

	public unsafe bool Wrap(string text, out string final)
	{
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_034b: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0368: Expected Obj, but got I4
		//IL_037c: Expected I, but got Obj
		//IL_0392: Expected Obj, but got I
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected VT, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected VT, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected Obj, but got Unknown
		//IL_0551: Expected I4, but got Obj
		//IL_0560: Expected I4, but got Obj
		//IL_0577: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I4
		//IL_0577: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_03f0: Expected I, but got Obj
		//IL_0406: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_05a3: Expected VT, but got I4
		//IL_05a3: Expected VT, but got Obj
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_015d: Expected I, but got Obj
		//IL_03c5: Expected Ref, but got F4
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_01aa: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_0280: Expected I, but got Obj
		//IL_0296: Expected Obj, but got I
		//IL_0430: Expected F4, but got Obj
		//IL_042b: Expected native int or pointer, but got VT
		//IL_0445: Expected F4, but got I
		//IL_0440: Expected native int or pointer, but got VT
		//IL_0452: Expected F4, but got Obj
		//IL_044d: Expected native int or pointer, but got VT
		//IL_0467: Expected F4, but got I
		//IL_0462: Expected native int or pointer, but got VT
		//IL_0485: Expected F4, but got Obj
		//IL_0480: Expected native int or pointer, but got VT
		//IL_049a: Expected F4, but got I
		//IL_0495: Expected native int or pointer, but got VT
		//IL_04ac: Expected I4, but got VT
		//IL_04ac: Expected Ref, but got VT
		//IL_04b9: Expected native int or pointer, but got VT
		//IL_04cb: Expected native int or pointer, but got VT
		//IL_02c1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 84;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 72;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15 (Il2CppClass<NGUIText>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v131 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 108);
		Vector3 vector2 = (Vector3)(obj2 + 96);
		object obj5 = obj2 + 60;
		object obj6 = obj2 + 48;
		object obj7 = obj2 + 36;
		object obj8 = obj2 + 24;
		object obj9 = obj2 + 12;
		bool flag = NGUIText.IsSpace((int)text);
		bool flag2 = NGUIText.IsSpace((int)mProcessedText);
		string text2 = string.Format((string)flag2, flag, null, 2);
		ref string reference;
		if ((nint)text2 == -1)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v119 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v127 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			reference = ref *(string*)vector.x;
			_ = vector.z;
			return false;
		}
		this._002Ector();
		nint num5 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<UILabel>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v112 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v55 (Il2CppClass<NGUIText>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num8 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v108 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.ReplaceLinks(ref *(flag2 ? ((string*)1) : ((string*)null)), (string)(object)mTempVerts, (string)(object)mTempIndices);
		Vector3 vector3 = ((UIPanel)(object)this).CalculateConstrainOffset((Vector2)mTempVerts, (Vector2)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v34 (System.Boolean)+8]");
		object obj13 = 0 + text2;
		object obj14 = obj13 - 1;
		object obj15 = (object)text2 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v24+8]");
		_ = 0;
		object obj16 = obj14 << 1;
		object obj17 = obj16 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8873");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26+8]");
		_ = 0;
		Camera camera = anchorCamera;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v78 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v104 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v28+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		Vector3 vector6 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v32+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		((Vector2*)vector2)->set_Item((int)vector, 2f);
		((Vector3*)(nint)vector)->x = vector2.x;
		((Vector3*)(nint)vector)->z = vector2.z;
		Vector3 vector8 = ((Transform)(object)camera).InverseTransformPoint(vector);
		reference = ref *(string*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		throw new IndexOutOfRangeException();
	}

	public unsafe bool Wrap(string text, out string final, int height)
	{
		//IL_00f4: Expected Obj, but got I4
		//IL_0221: Expected Obj, but got I4
		//IL_044f: Expected Obj, but got I4
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_05ef: Expected Obj, but got I4
		//IL_0336: Expected Obj, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected Obj, but got Unknown
		//IL_04c0: Expected Obj, but got I4
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected I4, but got Unknown
		//IL_03c6: Expected Obj, but got I4
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected Obj, but got Unknown
		//IL_14a8: Expected Obj, but got I4
		//IL_051f: Expected Obj, but got I4
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_13dc: Expected I, but got Obj
		//IL_13f2: Expected Obj, but got I
		//IL_1587: Expected Obj, but got I4
		//IL_1d04: Expected Obj, but got I4
		//IL_1e06: Expected Obj, but got I4
		//IL_1e2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e30: Expected Obj, but got Unknown
		//IL_14bb: Expected I, but got Obj
		//IL_14d1: Expected Obj, but got I
		//IL_146e: Invalid comparison between Ref and Obj
		//IL_141d: Expected I, but got Obj
		//IL_15e3: Expected Obj, but got I4
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160d: Expected Obj, but got Unknown
		//IL_1d90: Expected Obj, but got I4
		//IL_1d9e: Expected Obj, but got Ref
		//IL_149a: Expected Obj, but got Ref
		//IL_17b5: Expected Obj, but got I4
		//IL_14fc: Expected I, but got Obj
		//IL_1d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d4b: Expected Obj, but got Unknown
		//IL_18b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b5: Expected Obj, but got Unknown
		//IL_18da: Unknown result type (might be due to invalid IL or missing references)
		//IL_18df: Expected Obj, but got Unknown
		//IL_1641: Unknown result type (might be due to invalid IL or missing references)
		//IL_1646: Expected Obj, but got Unknown
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected Obj, but got Unknown
		//IL_15ba: Expected Obj, but got I4
		//IL_15c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c8: Expected I4, but got Unknown
		//IL_1de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de5: Expected Obj, but got Unknown
		//IL_19da: Unknown result type (might be due to invalid IL or missing references)
		//IL_19df: Expected Obj, but got Unknown
		//IL_1a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a09: Expected Obj, but got Unknown
		//IL_1770: Expected Obj, but got I4
		//IL_1779: Unknown result type (might be due to invalid IL or missing references)
		//IL_177e: Expected I4, but got Unknown
		//IL_1b17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1c: Expected Obj, but got Unknown
		//IL_1b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b46: Expected Obj, but got Unknown
		int num2 = default;
		if ((object)mGo != null && isActiveAndEnabled)
		{
			if ((nint)mGo == 1)
			{
				int num = num2 & 0xFFFF;
				if (num >= 48)
				{
					int num3 = num2 & 0xFFFF;
					if (num3 <= 57)
					{
						goto IL_1cd4;
					}
				}
				else
				{
					bool flag = System.Runtime.CompilerServices.Unsafe.AsPointer(ref final) == null;
					int num4 = num2 & 0xFFFF;
					bool flag2 = num4 == 45;
					object obj = flag & flag2;
					if (obj != null && !text.EndsWith("-"))
					{
						return true;
					}
				}
			}
			else
			{
				if ((nint)mGo != 2)
				{
					if ((nint)mGo == 3)
					{
						int num5 = num2 & 0xFFFF;
						if (num5 < 65)
						{
							object obj2 = num2 + -48;
							object obj3 = obj2 << 16;
							object obj4 = obj3 >> 16;
							object obj5 = obj4 & 0xFFFF;
							if ((nint)obj5 > 9)
							{
								goto IL_1cc6;
							}
						}
						else
						{
							int num6 = num2 & 0xFFFF;
							bool flag3;
							if (num6 > 90)
							{
								object obj6 = num2 + -97;
								object obj7 = obj6 << 16;
								object obj8 = obj7 >> 16;
								object obj9 = obj8 & 0xFFFF;
								flag3 = (nint)obj9 > 25;
							}
							else
							{
								flag3 = false;
							}
							if (flag3)
							{
								goto IL_1cc6;
							}
						}
					}
					else if ((nint)mGo == 4)
					{
						object obj10 = num2 + -65;
						object obj11 = obj10 << 16;
						object obj12 = obj11 >> 16;
						object obj13 = obj12 & 0xFFFF;
						if ((nint)obj13 <= 25)
						{
							int num7 = num2 & 0xFFFF;
							object obj14 = num7 + 32;
							return (byte)(obj14 & 0xFFFF) != 0;
						}
						int num8 = num2 & 0xFFFF;
						if (num8 < 97)
						{
							object obj15 = num2 + -48;
							object obj16 = obj15 << 16;
							object obj17 = obj16 >> 16;
							object obj18 = obj17 & 0xFFFF;
							if ((nint)obj18 > 9)
							{
								goto IL_1cc6;
							}
						}
						else
						{
							int num9 = num2 & 0xFFFF;
							if (num9 > 122)
							{
								goto IL_1cc6;
							}
						}
					}
					else
					{
						if ((nint)mGo == 6)
						{
							int num10 = num2 << 16;
							int num11 = num10 >> 16;
							object obj19 = num11 - 9;
							if (num11 == 9 || ((nint)obj19 != 1 && (nint)obj19 != 2 && (nint)obj19 != 3 && (nint)obj19 != 4 && (nint)obj19 != 5 && (nint)obj19 != 6 && (nint)obj19 != 7 && (nint)obj19 != 8 && (nint)obj19 != 9 && (nint)obj19 != 10 && (nint)obj19 != 11 && (nint)obj19 != 12 && (nint)obj19 != 13 && (nint)obj19 != 14 && (nint)obj19 != 15 && (nint)obj19 != 16 && (nint)obj19 != 17 && (nint)obj19 != 18 && (nint)obj19 != 19 && (nint)obj19 != 20 && (nint)obj19 != 21 && (nint)obj19 != 22 && (nint)obj19 != 23 && (nint)obj19 != 24 && ((nint)obj19 == 25 || ((nint)obj19 != 26 && (nint)obj19 != 27 && (nint)obj19 != 28 && (nint)obj19 != 29 && (nint)obj19 != 30 && (nint)obj19 != 31 && (nint)obj19 != 32 && ((nint)obj19 == 33 || ((nint)obj19 != 34 && (nint)obj19 != 35 && (nint)obj19 != 36 && (nint)obj19 != 37 && ((nint)obj19 == 38 || ((nint)obj19 != 39 && (nint)obj19 != 40 && (nint)obj19 != 41 && (nint)obj19 != 42 && (nint)obj19 != 43 && (nint)obj19 != 44 && (nint)obj19 != 45 && (nint)obj19 != 46 && (nint)obj19 != 47 && (nint)obj19 != 48 && ((nint)obj19 == 49 || (nint)obj19 == 50 || (nint)obj19 == 51 || ((nint)obj19 != 52 && ((nint)obj19 == 53 || ((nint)obj19 != 54 && (nint)obj19 != 55 && (nint)obj19 != 56 && (nint)obj19 != 57 && (nint)obj19 != 58 && (nint)obj19 != 59 && (nint)obj19 != 60 && (nint)obj19 != 61 && (nint)obj19 != 62 && (nint)obj19 != 63 && (nint)obj19 != 64 && (nint)obj19 != 65 && (nint)obj19 != 66 && (nint)obj19 != 67 && (nint)obj19 != 68 && (nint)obj19 != 69 && (nint)obj19 != 70 && (nint)obj19 != 71 && (nint)obj19 != 72 && (nint)obj19 != 73 && (nint)obj19 != 74 && (nint)obj19 != 75 && (nint)obj19 != 76 && (nint)obj19 != 77 && (nint)obj19 != 78 && (nint)obj19 != 79 && (nint)obj19 != 80 && (nint)obj19 != 81 && (nint)obj19 != 82 && ((nint)obj19 == 83 || ((nint)obj19 != 84 && ((nint)obj19 == 85 || ((nint)obj19 != 86 && ((nint)obj19 == 87 || ((nint)obj19 != 88 && (nint)obj19 != 89 && (nint)obj19 != 90 && (nint)obj19 != 91 && (nint)obj19 != 92 && (nint)obj19 != 93 && (nint)obj19 != 94 && (nint)obj19 != 95 && (nint)obj19 != 96 && (nint)obj19 != 97 && (nint)obj19 != 98 && (nint)obj19 != 99 && (nint)obj19 != 100 && (nint)obj19 != 101 && (nint)obj19 != 102 && (nint)obj19 != 103 && (nint)obj19 != 104 && (nint)obj19 != 105 && (nint)obj19 != 106 && (nint)obj19 != 107 && (nint)obj19 != 108 && (nint)obj19 != 109 && (nint)obj19 != 110 && (nint)obj19 != 111 && (nint)obj19 != 112 && (nint)obj19 != 113 && (nint)obj19 != 114 && (nint)obj19 == 115))))))))))))))))))
							{
								return false;
							}
							int num12 = num2 & 0xFFFF;
							if (num12 == 10)
							{
								return false;
							}
							return (byte)num2 != 0;
						}
						if ((nint)mGo != 5)
						{
							goto IL_1cc6;
						}
						object obj21;
						if (text.m_stringLength > 0)
						{
							nint num13 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v111 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj20 = (nint)0 & (nint)0x200;
							if (obj20 != null)
							{
								nint num14 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v118 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							char[] array = (char[])(text.m_stringLength - 1);
							if ((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref final) < unchecked((nint)null))
							{
								array = null;
							}
							else if (!System.Runtime.CompilerServices.Unsafe.IsAddressGreaterThan(ref System.Runtime.CompilerServices.Unsafe.As<string, byte>(ref final), ref *(byte*)array))
							{
								array = (char[])System.Runtime.CompilerServices.Unsafe.AsPointer(ref final);
							}
							string[] array2 = text.Split(array);
							obj21 = array2 & 0xFFFF;
						}
						else
						{
							obj21 = 32;
						}
						object obj23;
						if (text.m_stringLength > 0)
						{
							nint num15 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v96 (Il2CppClass<UnityEngine.Mathf>)+BA]");
							object obj22 = (nint)0 & (nint)0x200;
							if (obj22 != null)
							{
								nint num16 = (nint)typeof(Mathf);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v103 (Il2CppClass<UnityEngine.Mathf>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							char[] array3 = (char[])(text.m_stringLength - 1);
							char[] array4 = (char[])System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref final, 1));
							if ((nint)array4 < 0)
							{
								array3 = null;
							}
							else if (System.Runtime.CompilerServices.Unsafe.As<char[], UIntPtr>(ref array4) <= System.Runtime.CompilerServices.Unsafe.As<char[], UIntPtr>(ref array3))
							{
								array3 = array4;
							}
							string[] array5 = text.Split(array3);
							obj23 = array5 & 0xFFFF;
						}
						else
						{
							obj23 = 10;
						}
						int num17 = num2 & 0xFFFF;
						object obj24 = num2 + -97;
						object obj25 = obj24 << 16;
						object obj26 = obj25 >> 16;
						object obj27 = obj26 & 0xFFFF;
						if ((nint)obj27 <= 25)
						{
							if ((nint)obj21 == 32)
							{
								object obj28 = num17 + -32;
								return (byte)(obj28 & 0xFFFF) != 0;
							}
						}
						else
						{
							object obj29 = num2 + -65;
							object obj30 = obj29 << 16;
							object obj31 = obj30 >> 16;
							object obj32 = obj31 & 0xFFFF;
							if ((nint)obj32 > 25)
							{
								int num18 = num2 << 16;
								int num19 = num18 >> 16;
								object obj33 = num19 - 32;
								if (num19 != 32)
								{
									if ((nint)obj33 != 1 && (nint)obj33 != 2 && (nint)obj33 != 3 && (nint)obj33 != 4 && (nint)obj33 != 5 && (nint)obj33 != 6 && (nint)obj33 == 7)
									{
										object obj34 = obj21 & 0xFFFF;
										object obj35 = obj34 << 16;
										object obj36 = obj35 >> 16;
										object obj37 = obj36 - 32;
										if ((nint)obj36 != 32 && ((nint)obj37 == 1 || (nint)obj37 == 2 || (nint)obj37 == 3 || (nint)obj37 == 4 || (nint)obj37 == 5 || (nint)obj37 == 6 || (nint)obj37 != 7) && (nint)obj23 != 39 && !text.EndsWith("'"))
										{
											return true;
										}
									}
								}
								else
								{
									object obj38 = obj21 & 0xFFFF;
									object obj39 = obj38 << 16;
									object obj40 = obj39 >> 16;
									object obj41 = obj40 - 32;
									if ((nint)obj40 != 32 && ((nint)obj41 == 1 || (nint)obj41 == 2 || (nint)obj41 == 3 || (nint)obj41 == 4 || (nint)obj41 == 5 || (nint)obj41 == 6 || (nint)obj41 != 7))
									{
										object obj42 = obj23 & 0xFFFF;
										object obj43 = obj42 << 16;
										object obj44 = obj43 >> 16;
										object obj45 = obj44 - 32;
										if ((nint)obj44 != 32 && ((nint)obj45 == 1 || (nint)obj45 == 2 || (nint)obj45 == 3 || (nint)obj45 == 4 || (nint)obj45 == 5 || (nint)obj45 == 6 || (nint)obj45 != 7))
										{
											return true;
										}
									}
								}
								goto IL_1cc6;
							}
							object obj46 = obj21 & 0xFFFF;
							object obj47 = obj46 << 16;
							object obj48 = obj47 >> 16;
							object obj49 = obj48 - 32;
							if ((nint)obj48 != 32 && ((nint)obj49 == 1 || (nint)obj49 == 2 || (nint)obj49 == 3 || (nint)obj49 == 4 || (nint)obj49 == 5 || (nint)obj49 == 6 || (nint)obj49 != 7))
							{
								object obj50 = num17 + 32;
								return (byte)(obj50 & 0xFFFF) != 0;
							}
						}
					}
					goto IL_1cd4;
				}
				int num20 = num2 & 0xFFFF;
				if (num20 >= 48)
				{
					int num21 = num2 & 0xFFFF;
					if (num21 <= 57)
					{
						goto IL_1cd4;
					}
				}
				else
				{
					bool flag4 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref final) == null;
					int num22 = num2 & 0xFFFF;
					bool flag5 = num22 == 45;
					object obj51 = flag4 & flag5;
					if (obj51 != null)
					{
						if (!text.EndsWith("-"))
						{
							return true;
						}
					}
					else
					{
						int num23 = num2 & 0xFFFF;
						if (num23 == 46 && !text.EndsWith("."))
						{
							return true;
						}
					}
				}
			}
			goto IL_1cc6;
		}
		goto IL_1cd4;
		IL_1cc6:
		return false;
		IL_1cd4:
		return (byte)num2 != 0;
	}

	public void UpdateNGUIText()
	{
		//IL_027a: Expected I, but got Obj
		//IL_0290: Expected Obj, but got I
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_02db: Expected I, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_021d: Expected I, but got Obj
		//IL_0331: Expected I, but got Obj
		//IL_0347: Expected Obj, but got I
		//IL_0372: Expected Obj, but got I4
		//IL_037e: Expected I4, but got Obj
		//IL_015f: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)UIPopupList.current).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<UIPopupList>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v31 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPopupList current = UIPopupList.current;
		bool isLocalized = current.isLocalized;
		nint num7 = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v26 (Il2CppClass<UIPopupList>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		bool flag = obj4 == null;
		int num11 = default;
		if (isLocalized)
		{
			if (!flag)
			{
				nint num8 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v32 (Il2CppClass<UIPopupList>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num9 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v13 (Il2CppClass<Localization>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v18 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string key = default;
			string text = Localization.Format(key, (object[])1);
			num11 = (int)text;
		}
		else
		{
			if (!flag)
			{
				nint num12 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v20 (Il2CppClass<UIPopupList>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		fontSize = num11;
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_03e6: Expected Obj, but got I4
		//IL_03f4: Expected I, but got Obj
		//IL_040a: Expected Obj, but got I
		//IL_063a: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I4
		//IL_0476: Expected I, but got Obj
		//IL_048c: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0665: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0310: Expected I, but got Obj
		//IL_035d: Expected I, but got Obj
		//IL_0373: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_05e0: Expected Obj, but got I
		//IL_05f0: Expected Obj, but got I
		//IL_0600: Expected Obj, but got I
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_039e: Expected I, but got Obj
		//IL_050e: Expected I, but got Obj
		//IL_0524: Expected Obj, but got I
		//IL_01d3: Expected I, but got Obj
		//IL_021b: Expected Obj, but got I4
		//IL_02c3: Expected I, but got Obj
		//IL_0566: Expected Obj, but got I
		//IL_0576: Expected Obj, but got I
		//IL_0586: Expected Obj, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected Obj, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_0252: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mActiveTTF).FindKernel((string)paused) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mActiveTTF).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53 (Il2CppClass<UILabel>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v104 (Il2CppClass<UILabel>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
			object obj5 = default;
			if (obj5 != null)
			{
				object obj6 = obj - 1;
				obj = obj6;
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v63 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v100 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (0 > (nint)obj6)
				{
					obj6 = 0;
				}
				obj = obj6;
				nint num9 = (nint)typeof(UILabel);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v69 (Il2CppClass<UILabel>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				bool flag = obj8 == null;
				if (obj6 != null)
				{
					if (!flag)
					{
						nint num10 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S0_v94 (Il2CppClass<UILabel>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S4_v9 (Il2CppMethodInfo)+C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S4_v10+60]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S4_v11+48]");
					object obj11 = 0;
					object obj12 = obj11 & 0x7FF;
					object obj13 = obj12 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S5_v10 (should have been resolved before IL gen)");
				}
				else
				{
					if (!flag)
					{
						nint num12 = (nint)typeof(UILabel);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v81 (Il2CppClass<UILabel>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag2 = mFontUsage.Remove(mActiveTTF);
				}
			}
		}
		object obj14 = this + 452;
		obj14 = paused;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)paused).FindKernel(null) == 0)
		{
			return;
		}
		nint num15 = (nint)typeof(UILabel);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v34 (Il2CppClass<UILabel>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num16 = (nint)typeof(UILabel);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S0_v42 (Il2CppClass<UILabel>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S4_v4 (Il2CppMethodInfo)+C]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S4_v5+60]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S4_v6+48]");
		object obj19 = 0;
		object obj20 = obj19 & 0x7FF;
		object obj21 = obj20 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v57 @ S5_v6 (should have been resolved before IL gen)");
	}

	public UILabel()
	{
		//IL_0e2e: Expected I, but got Obj
		//IL_0e44: Expected Obj, but got I
		//IL_0e7d: Expected I, but got Obj
		//IL_0e93: Expected Obj, but got I
		//IL_0ee2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee7: Expected Obj, but got Unknown
		//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Expected Obj, but got Unknown
		//IL_0f00: Expected I, but got Obj
		//IL_0f16: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_1406: Unknown result type (might be due to invalid IL or missing references)
		//IL_140b: Expected Obj, but got Unknown
		//IL_1432: Expected I4, but got Obj
		//IL_1438: Unknown result type (might be due to invalid IL or missing references)
		//IL_143d: Expected Obj, but got Unknown
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected Obj, but got Unknown
		//IL_1465: Expected Obj, but got I
		//IL_148c: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_14b3: Expected I, but got Obj
		//IL_14c9: Expected Obj, but got I
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f95: Expected Obj, but got Unknown
		//IL_0fb8: Expected I, but got Obj
		//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc6: Expected Obj, but got Unknown
		//IL_0ff1: Expected Obj, but got I
		//IL_100c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1011: Expected Obj, but got Unknown
		//IL_1034: Expected I, but got Obj
		//IL_105f: Expected Obj, but got I
		//IL_10c7: Expected I, but got Obj
		//IL_10dd: Expected Obj, but got I
		//IL_10e7: Expected Obj, but got I4
		//IL_01d4: Expected I, but got Obj
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_013b: Expected I, but got Obj
		//IL_1109: Expected F4, but got I4
		//IL_021d: Expected I4, but got F4
		//IL_0183: Expected Obj, but got I4
		//IL_112b: Expected F4, but got I4
		//IL_023b: Expected I4, but got F4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected I4, but got Unknown
		//IL_1156: Expected I, but got Obj
		//IL_116c: Expected Obj, but got I
		//IL_14fd: Expected I, but got Obj
		//IL_1513: Expected Obj, but got I
		//IL_02a0: Expected I, but got Obj
		//IL_0650: Expected I, but got Obj
		//IL_0666: Expected Obj, but got I
		//IL_0683: Expected I, but got Obj
		//IL_02ed: Expected I, but got Obj
		//IL_128e: Expected Obj, but got I
		//IL_033a: Expected I, but got Obj
		//IL_0350: Expected Obj, but got I
		//IL_069f: Expected I, but got Obj
		//IL_06cf: Expected I, but got Obj
		//IL_08be: Expected I, but got Obj
		//IL_08d4: Expected Obj, but got I
		//IL_1588: Expected I, but got Obj
		//IL_159e: Expected Obj, but got I
		//IL_037b: Expected I, but got Obj
		//IL_06f5: Expected I, but got Obj
		//IL_1547: Expected I, but got Obj
		//IL_155d: Expected Obj, but got I
		//IL_15e6: Expected I, but got Obj
		//IL_15fc: Expected Obj, but got I
		//IL_08ff: Expected I, but got Obj
		//IL_1770: Expected I, but got Obj
		//IL_1786: Expected Obj, but got I
		//IL_03c8: Expected I, but got Obj
		//IL_0735: Expected I, but got Obj
		//IL_074b: Expected Obj, but got I
		//IL_0415: Expected I, but got Obj
		//IL_094c: Expected I, but got Obj
		//IL_12ab: Expected Obj, but got I4
		//IL_11c8: Expected I, but got Obj
		//IL_11de: Expected Obj, but got I
		//IL_09a8: Expected I, but got Obj
		//IL_09be: Expected Obj, but got I
		//IL_0776: Expected I, but got Obj
		//IL_05cb: Expected I, but got Obj
		//IL_04f7: Expected I, but got Obj
		//IL_0c2d: Expected I, but got Obj
		//IL_0c43: Expected Obj, but got I
		//IL_0a83: Expected I, but got Obj
		//IL_0a99: Expected Obj, but got I
		//IL_1368: Unknown result type (might be due to invalid IL or missing references)
		//IL_136d: Expected Obj, but got Unknown
		//IL_1373: Unknown result type (might be due to invalid IL or missing references)
		//IL_1378: Expected Obj, but got Unknown
		//IL_1386: Expected I, but got Obj
		//IL_139c: Expected Obj, but got I
		//IL_07c3: Expected I, but got Obj
		//IL_07d9: Expected Obj, but got I
		//IL_126a: Expected Obj, but got I
		//IL_1273: Expected Obj, but got I4
		//IL_0486: Expected I, but got Obj
		//IL_1656: Unknown result type (might be due to invalid IL or missing references)
		//IL_165b: Expected Obj, but got Unknown
		//IL_1682: Expected I4, but got Obj
		//IL_1688: Unknown result type (might be due to invalid IL or missing references)
		//IL_168d: Expected Obj, but got Unknown
		//IL_1693: Unknown result type (might be due to invalid IL or missing references)
		//IL_1698: Expected Obj, but got Unknown
		//IL_16b5: Expected Obj, but got I
		//IL_16dc: Expected I4, but got Obj
		//IL_09e9: Expected I, but got Obj
		//IL_12db: Expected Obj, but got I4
		//IL_05e7: Expected I, but got Obj
		//IL_0617: Expected I, but got Obj
		//IL_1226: Expected I, but got Obj
		//IL_123c: Expected Obj, but got I
		//IL_1244: Expected Obj, but got I4
		//IL_16ef: Expected I, but got Obj
		//IL_1705: Expected Obj, but got I
		//IL_0c6e: Expected I, but got Obj
		//IL_0d49: Expected I, but got Obj
		//IL_0d5f: Expected Obj, but got I
		//IL_0ac4: Expected I, but got Obj
		//IL_0a36: Expected I, but got Obj
		//IL_0804: Expected I, but got Obj
		//IL_0568: Expected I, but got Obj
		//IL_130a: Expected I, but got Obj
		//IL_1320: Expected Obj, but got I
		//IL_084c: Expected Obj, but got I4
		//IL_063d: Expected I, but got Obj
		//IL_0dd7: Expected I, but got Obj
		//IL_0d8a: Expected I, but got Obj
		//IL_0cbb: Expected I, but got Obj
		//IL_0cd1: Expected Obj, but got I
		//IL_0871: Expected I, but got Obj
		//IL_0cfc: Expected I, but got Obj
		UnityEngine.Object obj = ambigiousFont;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v426 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((ComputeShader)obj).FindKernel((string)null);
		nint num4 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v420 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.fontSize = mFinalFontSize;
		NGUIText.fontStyle = mFontStyle;
		NGUIText.rectWidth = mWidth;
		NGUIText.rectHeight = mHeight;
		object obj2 = this + 156;
		object obj3 = this + 156;
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v222 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v15+8]");
		NGUIText.regionWidth = (int)GUILayout.Width((float)mWidth * (float)(object)(0 - obj3));
		object obj4 = this + 156;
		object obj5 = this + 156;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v30+C]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S2_v8+4]");
		NGUIText.regionHeight = (int)GUILayout.Width((float)mHeight * (float)(object)(num8 - 0));
		object obj6;
		if (~(mApplyGradient ? 1u : 0u) == 0)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v209 (Il2CppClass<UnityEngine.Object>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S1_v218 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj6 = ((!(mFont != null)) ? ((object)((object)(mFont.texture ^ 1) & 1)) : ((object)1));
		}
		else
		{
			obj6 = 0;
		}
		nint num11 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v53 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num12 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v403 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.gradient = obj6 != null;
		object obj8 = default;
		object obj7 = obj8 + 16;
		obj7 = this + 364;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S1_v41+8]");
		_ = 0;
		nint num13 = (nint)typeof(NGUIText);
		object obj9 = obj8 + 32;
		obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v60+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v63 (Il2CppClass<NGUIText>)+5C]");
		object obj10 = (nint)0 + (nint)88;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v46+8]");
		_ = 0;
		obj8 = this + 380;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S1_v54+8]");
		_ = 0;
		nint num14 = (nint)typeof(NGUIText);
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v70 (Il2CppClass<NGUIText>)+5C]");
		object obj11 = (nint)0 + (nint)72;
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v46+8]");
		_ = 0;
		NGUIText.encoding = mEncoding;
		NGUIText.premultiply = mPremultiply;
		NGUIText.symbolStyle = mSymbols;
		nint num15 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S0_v84 (Il2CppClass<NGUIText>)+5C]");
		object obj12 = -(-64);
		obj12 = mMaxLineCount;
		NGUIText.spacingX = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingX : ((int)mFloatSpacingX));
		NGUIText.spacingY = ((~(mUseFloatSpacing ? 1u : 0u) != 0) ? mSpacingY : ((int)mFloatSpacingY));
		float fontScale;
		if (num3 != 0)
		{
			fontScale = mScale;
		}
		else
		{
			UISpriteData sprite = mFont.sprite;
			fontScale = (float)(mFontSize / sprite) * mScale;
		}
		nint num16 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ S0_v96 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num17 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v391 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.fontScale = fontScale;
		nint num18 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v86 (Il2CppClass<UnityEngine.Object>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S1_v191 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mFont).FindKernel((string)null) != 0)
		{
			nint num20 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v295 (Il2CppClass<NGUIText>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num21 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v385 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.bitmapFont = mFont;
			bool flag2;
			while (true)
			{
				nint num22 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v303 (Il2CppClass<NGUIText>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num23 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v379 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UIFont uIFont = NGUIText.bitmapFont;
				nint num24 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v312 (Il2CppClass<UnityEngine.Object>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num25 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S0_v375 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = uIFont.mReplacement != null;
				nint num26 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v173 (Il2CppClass<NGUIText>)+BA]");
				flag2 = (object)((nint)0 & (nint)0x200) == null;
				if (flag)
				{
					break;
				}
				if (!flag2)
				{
					nint num27 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ S0_v369 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.bitmapFont = uIFont.mReplacement;
			}
			if (!flag2)
			{
				nint num28 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v358 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Font dynamicFont = NGUIText.bitmapFont.dynamicFont;
			nint num29 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ S1_v179 (Il2CppClass<NGUIText>)+BA]");
			bool flag3 = (object)((nint)0 & (nint)0x200) == null;
			if ((object)dynamicFont != null)
			{
				if (!flag3)
				{
					nint num30 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ S0_v352 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				FontStyle dynamicFontStyle = NGUIText.bitmapFont.dynamicFontStyle;
				nint num31 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v346 (Il2CppClass<NGUIText>)+5C]");
				object obj13 = (nint)0 + (nint)4;
				obj13 = dynamicFontStyle;
				NGUIText.bitmapFont = null;
			}
			else
			{
				bool flag4 = flag3;
				nint num32 = (nint)typeof(NGUIText);
				if (!flag4)
				{
					nint num33 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ S0_v332 (Il2CppClass<NGUIText>)+74]");
					bool flag5 = (nint)0 != 0;
					num32 = (nint)typeof(NGUIText);
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num32 = (nint)typeof(NGUIText);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ L1_v50 (Il2CppClass<NGUIText>)+5C]");
				object obj14 = (nint)0 + (nint)4;
				obj14 = 0;
			}
		}
		else
		{
			nint num34 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v276 (Il2CppClass<NGUIText>)+BA]");
			bool flag6 = (object)((nint)0 & (nint)0x200) == null;
			nint num35 = (nint)typeof(NGUIText);
			if (!flag6)
			{
				nint num36 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S0_v286 (Il2CppClass<NGUIText>)+74]");
				bool flag7 = (nint)0 != 0;
				num35 = (nint)typeof(NGUIText);
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num35 = (nint)typeof(NGUIText);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ L1_v38 (Il2CppClass<NGUIText>)+5C]");
			object obj15 = (nint)0 + (nint)4;
			obj15 = obj;
			NGUIText.bitmapFont = null;
		}
		if (num3 != 0 && supportEncoding)
		{
			bool flag8 = isAnchored;
			nint num37 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ S0_v236 (Il2CppClass<UnityEngine.Object>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num38 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ S0_v271 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag8).FindKernel(null) != 0)
			{
				nint num39 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v677 @ S0_v244 (Il2CppClass<UnityEngine.Object>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num40 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S0_v267 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float pixelDensity = ((((ComputeShader)flag8).FindKernel(null) == 0) ? 1f : UIRoot.GetPixelSizeAdjustment((GameObject)flag8));
				nint num41 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ S0_v252 (Il2CppClass<NGUIText>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num42 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S0_v258 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				NGUIText.pixelDensity = pixelDensity;
			}
		}
		else
		{
			nint num43 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v218 (Il2CppClass<NGUIText>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num44 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v224 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.pixelDensity = 1f;
		}
		nint num45 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S1_v94 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num46 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S1_v142 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mDensity != NGUIText.pixelDensity)
		{
			Vector3 positionOfCharacter = ((UILabel)null).GetPositionOfCharacter(0);
			nint num47 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v649 @ S0_v187 (Il2CppClass<NGUIText>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num48 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S0_v210 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.rectWidth = mWidth;
			NGUIText.rectHeight = mHeight;
			object obj16 = this + 156;
			object obj17 = this + 156;
			nint num49 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S1_v124 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num50 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ S1_v138 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S1_v118+8]");
			NGUIText.regionWidth = (int)GUILayout.Width((float)mWidth * (float)(object)(0 - obj17));
			object obj18 = this + 156;
			object obj19 = this + 156;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ S1_v133+C]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ S2_v39+4]");
			NGUIText.regionHeight = (int)GUILayout.Width((float)mHeight * (float)(object)(num51 - 0));
		}
		if (mAlignment != NGUIText.Alignment.Automatic)
		{
			nint num52 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v171 (Il2CppClass<NGUIText>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num53 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v177 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.alignment = mAlignment;
		}
		else
		{
			if (mPivot == Pivot.TopLeft)
			{
				goto IL_0c1f;
			}
			if (mPivot == Pivot.Top)
			{
				goto IL_0d3b;
			}
			if (mPivot != Pivot.TopRight)
			{
				if (mPivot == Pivot.Left)
				{
					goto IL_0c1f;
				}
				if (mPivot == Pivot.Center)
				{
					goto IL_0d3b;
				}
				if (mPivot != Pivot.Right)
				{
					if (mPivot == Pivot.BottomLeft)
					{
						goto IL_0c1f;
					}
					if (mPivot == Pivot.Bottom || mPivot != Pivot.BottomRight)
					{
						goto IL_0d3b;
					}
				}
			}
			nint num54 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ S0_v156 (Il2CppClass<NGUIText>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num55 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S0_v162 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			NGUIText.alignment = NGUIText.Alignment.Right;
		}
		goto IL_16e1;
		IL_16e1:
		nint num56 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ S0_v117 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num57 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ S0_v123 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText._002Ecctor();
		return;
		IL_0d3b:
		nint num58 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ S0_v143 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num59 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ S0_v149 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.alignment = NGUIText.Alignment.Center;
		goto IL_16e1;
		IL_0c1f:
		nint num60 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ S0_v130 (Il2CppClass<NGUIText>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num61 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ S0_v136 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUIText.alignment = NGUIText.Alignment.Left;
		goto IL_16e1;
	}

	static UILabel()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		UIInput.mDrawStart = 0;
		nint num = (nint)typeof(UIInput);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UIInput>)+5C]");
		object obj = (nint)0 + (nint)12;
		obj = "";
		UIInput.mIgnoreKey = 0;
	}
}
