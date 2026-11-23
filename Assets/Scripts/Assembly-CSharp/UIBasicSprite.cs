using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
	public enum Type
	{
		Simple,
		Sliced,
		Tiled,
		Filled,
		Advanced
	}

	public enum FillDirection
	{
		Horizontal,
		Vertical,
		Radial90,
		Radial180,
		Radial360
	}

	public enum AdvancedType
	{
		Invisible,
		Sliced,
		Tiled
	}

	public enum Flip
	{
		Nothing,
		Horizontally,
		Vertically,
		Both
	}

	protected Type mType;

	protected FillDirection mFillDirection = FillDirection.Radial360;

	protected float mFillAmount;

	protected bool mInvert;

	protected Flip mFlip;

	[NonSerialized]
	private Rect mInnerUV;

	[NonSerialized]
	private Rect mOuterUV;

	public AdvancedType centerType = AdvancedType.Sliced;

	public AdvancedType leftType;

	public AdvancedType rightType = AdvancedType.Sliced;

	public AdvancedType bottomType;

	public AdvancedType topType = AdvancedType.Sliced;

	protected static Vector2[] mTempPos;

	protected static Vector2[] mTempUVs;

	public virtual Type type
	{
		get
		{
			return mType;
		}
		set
		{
			//IL_003b: Expected I, but got Obj
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			if (value != mType)
			{
				mType = value;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v6 (Il2CppClass<UIBasicSprite>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public Flip flip
	{
		get
		{
			return mFlip;
		}
		set
		{
			//IL_003b: Expected I, but got Obj
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected Obj, but got Unknown
			if (value != mFlip)
			{
				mFlip = value;
				nint num = (nint)this;
				object obj = this + 272;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S1_v6 (Il2CppClass<UIBasicSprite>)+1CC] (should have been resolved before IL gen)");
			}
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return mFillDirection;
		}
		set
		{
			if (value != mFillDirection)
			{
				mChanged = true;
				mFillDirection = value;
			}
		}
	}

	public float fillAmount
	{
		get
		{
			return mFillAmount;
		}
		set
		{
			float num = Math.Min(value, 1f);
			bool flag = value < 0f;
			float num2 = 0f;
			if (!flag)
			{
				num2 = num;
			}
			if (num2 != mFillAmount)
			{
				mChanged = true;
				mFillAmount = num2;
			}
		}
	}

	public override int minWidth
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0092: Expected I, but got Obj
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			//IL_00ac: Expected I, but got Obj
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected Obj, but got Unknown
			//IL_0058: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0167: Expected F8, but got I4
			//IL_012f: Expected F8, but got I4
			//IL_01eb: Expected I4, but got F8
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected Obj, but got Unknown
			//IL_01c9: Invalid comparison between F8 and I4
			//IL_01d8: Expected F8, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			nint num = (nint)this;
			object obj3 = this + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v3 (Il2CppClass<UIBasicSprite>)+1F4] (should have been resolved before IL gen)");
			object obj4 = default;
			double num3;
			if ((nint)obj4 != 1)
			{
				nint num2 = (nint)this;
				object obj5 = this + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v30 (Il2CppClass<UIBasicSprite>)+1F4] (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 != 4)
				{
					num3 = 2.0;
					goto IL_01e6;
				}
			}
			nint num4 = (nint)this;
			object obj7 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S2_v7 (Il2CppClass<UIBasicSprite>)+1BC] (should have been resolved before IL gen)");
			nint num5 = (nint)this;
			object obj8 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v58 @ S2_v11 (Il2CppClass<UIBasicSprite>)+20C] (should have been resolved before IL gen)");
			object obj10 = default;
			object obj9 = obj * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj11 = 0 * obj10;
			object obj12 = obj9 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			object obj13 = num7 & 1;
			bool flag = obj13 == null;
			double num8 = num7;
			if (!flag)
			{
				double num9 = num7 + 1.0;
				num8 = num9;
			}
			bool flag2 = num8 < 2.0;
			num3 = 2.0;
			if (!flag2)
			{
				num3 = num8;
			}
			goto IL_01e6;
			IL_01e6:
			return (int)num3;
		}
	}

	public override int minHeight
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0092: Expected I, but got Obj
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected Obj, but got Unknown
			//IL_00ac: Expected I, but got Obj
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected Obj, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Expected Obj, but got Unknown
			//IL_0058: Expected I, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_016f: Expected F8, but got I4
			//IL_0137: Expected F8, but got I4
			//IL_01f3: Expected I4, but got F8
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01d1: Invalid comparison between F8 and I4
			//IL_01e0: Expected F8, but got I4
			object obj2 = default;
			object obj = obj2 - 16;
			nint num = (nint)this;
			object obj3 = this + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S1_v3 (Il2CppClass<UIBasicSprite>)+1F4] (should have been resolved before IL gen)");
			object obj4 = default;
			double num3;
			if ((nint)obj4 != 1)
			{
				nint num2 = (nint)this;
				object obj5 = this + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v31 (Il2CppClass<UIBasicSprite>)+1F4] (should have been resolved before IL gen)");
				object obj6 = default;
				if ((nint)obj6 != 4)
				{
					num3 = 2.0;
					goto IL_01ee;
				}
			}
			nint num4 = (nint)this;
			object obj7 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S2_v7 (Il2CppClass<UIBasicSprite>)+1BC] (should have been resolved before IL gen)");
			nint num5 = (nint)this;
			object obj8 = this + 336;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S2_v11 (Il2CppClass<UIBasicSprite>)+20C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj10 = default;
			object obj9 = 0 * obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj11 = 0 * obj10;
			object obj12 = obj9 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double num7 = default;
			double num6 = Math.Abs(num7);
			if (!(num6 < 2147483648.0))
			{
				num7 = -2147483648.0;
			}
			object obj13 = num7 & 1;
			bool flag = obj13 == null;
			double num8 = num7;
			if (!flag)
			{
				double num9 = num7 + 1.0;
				num8 = num9;
			}
			bool flag2 = num8 < 2.0;
			num3 = 2.0;
			if (!flag2)
			{
				num3 = num8;
			}
			goto IL_01ee;
			IL_01ee:
			return (int)num3;
		}
	}

	public bool invert
	{
		get
		{
			return mInvert;
		}
		set
		{
			if (value != mInvert)
			{
				mChanged = true;
				mInvert = value;
			}
		}
	}

	public bool hasBorder
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0031: Invalid comparison between Obj and F4
			//IL_0059: Invalid comparison between I and F4
			//IL_0081: Invalid comparison between I and F4
			//IL_009b: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 - 16;
			nint num = (nint)this;
			object obj3 = this + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v10 @ S2_v2 (Il2CppClass<UIBasicSprite>)+1BC] (should have been resolved before IL gen)");
			if (obj == (object)0f)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
				if (0f == 0f)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					bool flag = 0f != 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					bool flag2 = 0f != 0f;
					return flag | flag2;
				}
			}
			return true;
		}
	}

	public virtual bool premultipliedAlpha => false;

	public virtual float pixelSize => 1f;

	private unsafe Vector4 drawingUVs
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			//IL_00b7: Expected F4, but got Obj
			//IL_00c7: Expected F4, but got I
			//IL_021e: Expected native int or pointer, but got VT
			//IL_022b: Expected native int or pointer, but got VT
			//IL_0238: Expected native int or pointer, but got VT
			//IL_0245: Expected native int or pointer, but got VT
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected Obj, but got Unknown
			//IL_0125: Expected F4, but got I
			//IL_013d: Expected F4, but got Obj
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Expected Obj, but got Unknown
			//IL_0193: Expected F4, but got I
			//IL_019b: Expected F4, but got Obj
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_0209: Expected F4, but got I
			//IL_0211: Expected F4, but got Obj
			object obj = mFlip - 1;
			float w;
			float z;
			float y;
			float x;
			if (mFlip != Flip.Horizontally)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2)
					{
						object obj2 = this + 316;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v31+8]");
						float num = 0f + (float)obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v31+C]");
						float num2 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v31+4]");
						float num3 = num2 + 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v31+4]");
						w = 0f;
						z = (float)obj2;
						y = num3;
						x = num;
					}
					else
					{
						object obj3 = this + 316;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v42+8]");
						float num4 = 0f + (float)obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v42+C]");
						float num5 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v42+4]");
						w = num5 + 0f;
						z = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v42+4]");
						y = 0f;
						x = (float)obj3;
					}
				}
				else
				{
					object obj4 = this + 316;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v20+C]");
					float num6 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v20+4]");
					float num7 = num6 + 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v20+8]");
					float num8 = 0f + (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v20+4]");
					w = 0f;
					z = num8;
					y = num7;
					x = (float)obj4;
				}
			}
			else
			{
				object obj5 = this + 316;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v9+8]");
				float num9 = 0f + (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v9+C]");
				float num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v9+4]");
				w = num10 + 0f;
				z = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v9+4]");
				y = 0f;
				x = num9;
			}
			Vector4 vector = default;
			((Vector4*)(nint)vector)->w = w;
			((Vector4*)(nint)vector)->z = z;
			((Vector4*)(nint)vector)->y = y;
			((Vector4*)(nint)vector)->x = x;
			return vector;
		}
	}

	private unsafe Color32 drawingColor
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_01d6: Expected I, but got Obj
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected Obj, but got Unknown
			//IL_020a: Expected F4, but got I
			//IL_0214: Expected F4, but got VT
			//IL_0224: Expected F4, but got I
			//IL_003c: Expected F4, but got I
			//IL_0037: Expected native int or pointer, but got VT
			//IL_0065: Expected F4, but got I
			//IL_0060: Expected native int or pointer, but got VT
			//IL_0087: Expected F4, but got I
			//IL_0097: Expected F4, but got I
			//IL_00a7: Expected F4, but got I
			//IL_00b7: Expected F4, but got I
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Expected Obj, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected Obj, but got Unknown
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected Obj, but got Unknown
			//IL_01bf: Expected I4, but got Obj
			//IL_01c7: Expected native int or pointer, but got VT
			object obj = default;
			Color color = (Color)(obj - 48);
			nint num = (nint)this;
			object obj2 = this + 328;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S1_v4 (Il2CppClass<UIBasicSprite>)+204] (should have been resolved before IL gen)");
			object obj3 = default;
			bool flag = obj3 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIBasicSprite)+54]");
			float num2 = 0f;
			float num3 = (float)mColor;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIBasicSprite)+50]");
			float num4 = 0f;
			float num5 = finalAlpha;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIBasicSprite)+54]");
				_ = 0;
				_ = finalAlpha;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+18]");
				((Color*)(nint)color)->b = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (UIBasicSprite)+50]");
				_ = 0;
				_ = mColor;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+10]");
				((Color*)(nint)color)->r = 0f;
				Color color2 = NGUITools.ApplyPMA(color);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+28]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+20]");
				num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+24]");
				num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+2C]");
				num5 = 0f;
			}
			ColorSpace activeColorSpace = QualitySettings.activeColorSpace;
			if (activeColorSpace == ColorSpace.Linear)
			{
				float num6 = Mathf.GammaToLinearSpace(num3);
				float num7 = Mathf.GammaToLinearSpace(num4);
				float num8 = Mathf.GammaToLinearSpace(num2);
				num2 = num8;
				num3 = num6;
				num4 = num7;
			}
			float num9 = Math.Min(num3, 1f);
			bool flag2 = num3 < 0f;
			float num10 = 0f;
			if (!flag2)
			{
				num10 = num9;
			}
			float num11 = num10 * 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			float num12 = Math.Min(num4, 1f);
			bool flag3 = num4 < 0f;
			float num13 = 0f;
			if (!flag3)
			{
				num13 = num12;
			}
			float num14 = num13 * 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			float num15 = Math.Min(num2, 1f);
			bool flag4 = num2 < 0f;
			float num16 = 0f;
			if (!flag4)
			{
				num16 = num15;
			}
			float num17 = num16 * 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			float num18 = Math.Min(num5, 1f);
			bool flag5 = num5 < 0f;
			float num19 = 0f;
			if (!flag5)
			{
				num19 = num18;
			}
			float num20 = num19 * 255f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
			object obj5 = default;
			object obj4 = obj5 & 0xFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
			object obj7 = default;
			object obj6 = obj7 << 8;
			object obj8 = obj6 & 0xFF00;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
			object obj10 = default;
			object obj9 = obj10 << 16;
			object obj11 = obj9 & 0xFF0000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
			object obj13 = default;
			object obj12 = obj13 << 24;
			object obj14 = obj11 | obj12;
			object obj15 = obj8 | obj14;
			int rgba = obj4 | obj15;
			Color32 color3 = default;
			((Color32*)(nint)color3)->rgba = rgba;
			return color3;
		}
	}

	protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
	{
		//IL_000f: Expected VT, but got F4
		//IL_0028: Expected VT, but got F4
		//IL_0037: Expected I, but got Obj
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		mOuterUV = (Rect)outer.m_XMin;
		_ = outer.m_Width;
		mInnerUV = (Rect)inner.m_XMin;
		_ = inner.m_Width;
		nint num = (nint)this;
		object obj = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v10 (Il2CppClass<UIBasicSprite>)+1F4] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 != null)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 != 2)
				{
					if ((nint)obj2 != 3)
					{
						if ((nint)obj2 == 4)
						{
							AdvancedFill(verts, uvs, cols);
						}
					}
					else
					{
						FilledFill(verts, uvs, cols);
					}
				}
				else
				{
					TiledFill(verts, uvs, cols);
				}
			}
			else
			{
				SlicedFill(verts, uvs, cols);
			}
		}
		else
		{
			SimpleFill(verts, uvs, cols);
		}
	}

	private unsafe void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0300: Expected I, but got Obj
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected VT, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected VT, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected VT, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected VT, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected VT, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected VT, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected VT, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected VT, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected VT, but got Unknown
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected VT, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected VT, but got Unknown
		//IL_02da: Expected native int or pointer, but got VT
		object obj = default;
		Color32 color = (Color32)(obj - 256);
		object obj2 = color + 240;
		nint num = (nint)this;
		object obj3 = this + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S2_v2 (Il2CppClass<UIBasicSprite>)+174] (should have been resolved before IL gen)");
		Vector4 vector = drawingUVs;
		Color32 color2 = drawingColor;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+E0]");
		_ = 0;
		Vector3 item = (Vector3)(color + 96);
		verts.Add(item);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+D0]");
		_ = 0;
		Vector3 item2 = (Vector3)(color + 80);
		verts.Add(item2);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+C0]");
		_ = 0;
		Vector3 item3 = (Vector3)(color - -64);
		verts.Add(item3);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+B0]");
		_ = 0;
		Vector3 item4 = (Vector3)(color + 48);
		verts.Add(item4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A8]");
		_ = 0;
		Vector2 item5 = (Vector2)(color + 40);
		uvs.Add(item5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A0]");
		_ = 0;
		Vector2 item6 = (Vector2)(color + 32);
		uvs.Add(item6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+98]");
		_ = 0;
		Vector2 item7 = (Vector2)(color + 24);
		uvs.Add(item7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+90]");
		_ = 0;
		Vector2 item8 = (Vector2)(color + 16);
		uvs.Add(item8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Color32 item9 = (Color32)(color + 12);
		cols.Add(item9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Color32 item10 = (Color32)(color + 8);
		cols.Add(item10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Color32 item11 = (Color32)(color + 4);
		cols.Add(item11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		((Color32*)(nint)color)->rgba = 0;
		cols.Add(color);
	}

	private unsafe void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected Obj, but got Unknown
		//IL_0a13: Expected I, but got Obj
		//IL_0a22: Expected I, but got Obj
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected Obj, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Expected Obj, but got Unknown
		//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected Obj, but got Unknown
		//IL_0a89: Invalid comparison between Obj and F4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I4
		//IL_001c: Invalid comparison between Obj and F4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_021a: Expected Obj, but got I4
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected Obj, but got Unknown
		//IL_0aee: Expected Obj, but got I4
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Expected Obj, but got Unknown
		//IL_0b38: Expected Obj, but got I4
		//IL_003c: Invalid comparison between Obj and F4
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I4
		//IL_042d: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected Obj, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02bd: Expected Obj, but got I4
		//IL_0b9e: Expected Obj, but got I
		//IL_0bdc: Expected Obj, but got I
		//IL_0bea: Expected Obj, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected Obj, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0353: Expected Obj, but got I
		//IL_035c: Expected Obj, but got I4
		//IL_0375: Expected Obj, but got I4
		//IL_005c: Invalid comparison between Obj and F4
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected Obj, but got Unknown
		//IL_0449: Expected Obj, but got I4
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected Obj, but got Unknown
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected VT, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected VT, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected VT, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected VT, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0766: Expected VT, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected VT, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected VT, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08de: Expected VT, but got Unknown
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected VT, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected Obj, but got Unknown
		//IL_0948: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected VT, but got Unknown
		//IL_097d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected VT, but got Unknown
		//IL_09b1: Expected native int or pointer, but got VT
		object obj = default;
		Color32 color = (Color32)(obj - 256);
		object obj2 = color + 240;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S2_v2 (Il2CppClass<UIBasicSprite>)+1BC] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S2_v5 (Il2CppClass<UIBasicSprite>)+20C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		object obj4 = default;
		object obj3 = 0 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		object obj5 = 0 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
		object obj6 = 0 * obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
		object obj7 = 0 * obj4;
		if (obj3 == (object)0f && obj5 == (object)0f && obj6 == (object)0f && obj7 == (object)0f)
		{
			SimpleFill(verts, uvs, cols);
			return;
		}
		Color32 color2 = drawingColor;
		object obj8 = color + 240;
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S2_v10 (Il2CppClass<UIBasicSprite>)+174] (should have been resolved before IL gen)");
		Vector2[] array = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
		_ = 0;
		Vector2[] array2 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		_ = 0;
		Vector2[] array3 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
		_ = 0;
		Vector2[] array4 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
		_ = 0;
		object obj9 = mFlip - 1;
		object obj14;
		object obj15;
		object obj16;
		object obj17;
		if (mFlip == Flip.Horizontally || ((nint)obj9 != 1 && (nint)obj9 == 2))
		{
			Vector2[] array5 = mTempPos;
			Vector2[] array6 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v209 (UnityEngine.Vector2[])+10]");
			object obj10 = 0 + obj6;
			Vector2[] array7 = mTempPos;
			Vector2[] array8 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v215 (UnityEngine.Vector2[])+28]");
			object obj11 = 0 - obj3;
			Vector2[] array9 = mTempUVs;
			object obj12 = this + 316;
			object obj13 = this + 300;
			obj14 = obj13;
			obj15 = obj13;
			obj16 = obj12;
			obj17 = 1;
		}
		else
		{
			Vector2[] array10 = mTempPos;
			Vector2[] array11 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S1_v226 (UnityEngine.Vector2[])+10]");
			object obj18 = 0 + obj3;
			Vector2[] array12 = mTempPos;
			Vector2[] array13 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v232 (UnityEngine.Vector2[])+28]");
			object obj19 = 0 - obj6;
			Vector2[] array14 = mTempUVs;
			object obj20 = this + 316;
			object obj21 = this + 300;
			obj14 = obj21;
			obj15 = obj21;
			obj16 = obj20;
			obj17 = 2;
		}
		object obj22 = obj14;
		object obj23 = obj17 << 3;
		object obj24 = (object)mTempUVs + obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ L7_v2+8]");
		object obj25 = 0 + obj15;
		object obj26 = 3 << 3;
		object obj27 = (object)mTempUVs + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ L6_v2+8]");
		object obj28 = 0 + obj16;
		Vector2[] array15 = mTempPos;
		Vector2[] array16 = mTempPos;
		object obj29 = mFlip & (Flip)(-2);
		object obj36;
		object obj39;
		if ((nint)obj29 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v90 (UnityEngine.Vector2[])+14]");
			object obj30 = 0 + obj7;
			Vector2[] array17 = mTempPos;
			Vector2[] array18 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S1_v198 (UnityEngine.Vector2[])+2C]");
			object obj31 = 0 - obj5;
			Vector2[] array19 = mTempUVs;
			object obj32 = this + 316;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ S1_v202+4]");
			_ = 0;
			object obj33 = this + 300;
			object obj34 = mTempUVs + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S0_v284+4]");
			object obj35 = 0;
			obj36 = 1;
			object obj37 = obj32;
			object obj38 = obj33;
			obj39 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S0_v90 (UnityEngine.Vector2[])+14]");
			object obj40 = 0 + obj5;
			Vector2[] array20 = mTempPos;
			Vector2[] array21 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v185 (UnityEngine.Vector2[])+2C]");
			object obj41 = 0 - obj7;
			Vector2[] array22 = mTempUVs;
			object obj42 = this + 316;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S1_v189+4]");
			_ = 0;
			object obj43 = this + 300;
			object obj34 = mTempUVs + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S0_v265+4]");
			object obj35 = 0;
			obj36 = 2;
			object obj37 = obj42;
			object obj38 = obj43;
			obj39 = 3;
		}
		object obj44 = obj36 << 3;
		object obj45 = (object)mTempUVs + obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ L6_v4+C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ L6_v4+4]");
		object obj46 = num4 + 0;
		object obj47 = obj39 << 3;
		object obj48 = (object)mTempUVs + obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ L7_v7+C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ L7_v7+4]");
		object obj49 = num5 + 0;
		object obj50 = 0;
		while ((nint)obj50 < 3)
		{
			object obj51 = obj50 + 1;
			object obj52 = 0;
			while ((nint)obj52 < 3)
			{
				if ((nint)obj52 != 1 || (nint)obj50 != 1 || centerType != AdvancedType.Invisible)
				{
					object obj53 = obj50 << 3;
					object obj54 = (object)mTempPos + obj53;
					object obj55 = obj52 << 3;
					object obj56 = (object)mTempPos + obj55;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+E8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v136+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ S0_v130+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+E0]");
					_ = 0;
					Vector3 item = (Vector3)(color + 96);
					verts.Add(item);
					object obj57 = obj50 << 3;
					object obj58 = (object)mTempPos + obj57;
					object obj59 = obj52 + 1;
					object obj60 = obj59 << 3;
					object obj61 = (object)mTempPos + obj60;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+D8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S0_v154+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v148+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+D0]");
					_ = 0;
					Vector3 item2 = (Vector3)(color + 80);
					verts.Add(item2);
					object obj62 = obj51 << 3;
					object obj63 = (object)mTempPos + obj62;
					object obj64 = obj59 << 3;
					object obj65 = (object)mTempPos + obj64;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+C8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S0_v172+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v166+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+C0]");
					_ = 0;
					Vector3 item3 = (Vector3)(color - -64);
					verts.Add(item3);
					object obj66 = obj51 << 3;
					object obj67 = (object)mTempPos + obj66;
					object obj68 = obj52 << 3;
					object obj69 = (object)mTempPos + obj68;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ S0_v190+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ S0_v184+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+B0]");
					_ = 0;
					Vector3 item4 = (Vector3)(color + 48);
					verts.Add(item4);
					object obj70 = obj50 << 3;
					object obj71 = (object)mTempUVs + obj70;
					object obj72 = obj52 << 3;
					object obj73 = (object)mTempUVs + obj72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S1_v118+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ S0_v202+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A8]");
					_ = 0;
					Vector2 item5 = (Vector2)(color + 40);
					uvs.Add(item5);
					object obj74 = obj50 << 3;
					object obj75 = (object)mTempUVs + obj74;
					object obj76 = obj59 << 3;
					object obj77 = (object)mTempUVs + obj76;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S1_v131+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ S0_v212+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A0]");
					_ = 0;
					Vector2 item6 = (Vector2)(color + 32);
					uvs.Add(item6);
					object obj78 = obj51 << 3;
					object obj79 = (object)mTempUVs + obj78;
					object obj80 = obj59 << 3;
					object obj81 = (object)mTempUVs + obj80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S1_v144+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ S0_v222+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+98]");
					_ = 0;
					Vector2 item7 = (Vector2)(color + 24);
					uvs.Add(item7);
					object obj82 = obj51 << 3;
					object obj83 = (object)mTempUVs + obj82;
					object obj84 = obj52 << 3;
					object obj85 = (object)mTempUVs + obj84;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ S1_v157+14]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v778 @ S0_v232+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+90]");
					_ = 0;
					Vector2 item8 = (Vector2)(color + 16);
					uvs.Add(item8);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Color32 item9 = (Color32)(color + 12);
					cols.Add(item9);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Color32 item10 = (Color32)(color + 8);
					cols.Add(item10);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Color32 item11 = (Color32)(color + 4);
					cols.Add(item11);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
					((Color32*)(nint)color)->rgba = 0;
					cols.Add(color);
				}
				object obj86 = obj52 + 1;
				obj52 = obj86;
			}
			object obj87 = obj50 + 1;
			obj50 = obj87;
		}
	}

	private unsafe void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_067f: Expected I, but got Obj
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected I, but got Obj
		//IL_0038: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0071: Expected I, but got Obj
		//IL_00b2: Invalid comparison between Obj and F4
		//IL_00dc: Invalid comparison between Obj and F4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_010d: Expected I, but got Obj
		//IL_011d: Expected F4, but got I
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0154: Expected Obj, but got I4
		//IL_01ba: Expected F4, but got Obj
		//IL_06bb: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_06f8: Expected Obj, but got I
		//IL_0212: Expected F4, but got I
		//IL_0246: Expected Obj, but got I
		//IL_02c0: Expected F4, but got I
		//IL_070d: Expected Obj, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_0749: Expected Obj, but got I
		//IL_039c: Expected F4, but got I
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected VT, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected VT, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0803: Expected VT, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected VT, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected VT, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e4: Expected VT, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected VT, but got Unknown
		//IL_084b: Expected Obj, but got I
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected VT, but got Unknown
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected VT, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected VT, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected VT, but got Unknown
		//IL_0628: Expected native int or pointer, but got VT
		object obj = default;
		Color32 color = (Color32)(obj - 272);
		_ = 0;
		_ = 0;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v6 (Il2CppClass<UIBasicSprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (!(obj2 != null))
		{
			return;
		}
		object obj3 = this + 300;
		nint num2 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
		nint num3 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v57 @ S2_v8 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+C]");
		object obj5 = default;
		object obj4 = 0 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+8]");
		object obj7 = default;
		object obj6 = 0 * obj7;
		nint num4 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S2_v11 (Il2CppClass<UIBasicSprite>)+20C] (should have been resolved before IL gen)");
		object obj9 = default;
		object obj8 = obj6 * obj9;
		if (!(obj2 != null) || System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2f))
		{
			return;
		}
		object obj10 = obj4 * obj9;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)2f))
		{
			return;
		}
		Color32 color2 = drawingColor;
		object obj11 = color + 240;
		nint num5 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S2_v16 (Il2CppClass<UIBasicSprite>)+174]");
		float num6 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v173 @ S2_v16 (Il2CppClass<UIBasicSprite>)+174] (should have been resolved before IL gen)");
		object obj12 = color + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		object obj13 = mFlip - 1;
		if (mFlip == Flip.Horizontally || ((nint)obj13 != 1 && (nint)obj13 == 2))
		{
			num6 = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+8]");
			float num7 = 0f + (float)obj3;
			object obj14 = obj3;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+8]");
			object obj14 = 0 + obj3;
		}
		object obj15 = mFlip & (Flip)(-2);
		if ((nint)obj15 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			num6 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+C]");
			float num8 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			float num9 = num8 + 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			object obj16 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+C]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19+4]");
			object obj16 = num10 + 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F4]");
		object obj17 = 0;
		while (true)
		{
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
			if ((nint)obj18 >= 0)
			{
				break;
			}
			object obj19 = obj17 + obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
			bool flag = 0 < (nint)obj19;
			bool flag2 = !flag;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+10C]");
			float num11 = 0f;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+10C]");
				float num12 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+104]");
				float num13 = num12 - 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
				object obj21 = 0 - obj17;
				float num14 = (float)obj21 / (float)obj10;
				num6 = Math.Min(num14, 1f);
				bool flag3 = num14 < 0f;
				float num15 = 0f;
				if (!flag3)
				{
					num15 = num6;
				}
				float num16 = num13 * num15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+104]");
				float num17 = 0f + num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+FC]");
				obj20 = 0;
				num11 = num17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
			object obj22 = 0;
			while (true)
			{
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
				if ((nint)obj23 >= 0)
				{
					break;
				}
				object obj24 = obj22 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
				bool flag4 = 0 < (nint)obj24;
				bool flag5 = !flag4;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+108]");
				float num18 = 0f;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+108]");
					float num19 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+100]");
					float num20 = num19 - 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
					object obj26 = 0 - obj22;
					float num21 = (float)obj26 / (float)obj8;
					num6 = Math.Min(num21, 1f);
					bool flag3 = num21 < 0f;
					float num22 = 0f;
					if (!flag3)
					{
						num22 = num6;
					}
					float num23 = num20 * num22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+100]");
					float num24 = 0f + num23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F8]");
					obj25 = 0;
					num18 = num24;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+E0]");
				_ = 0;
				Vector3 item = (Vector3)(color + 96);
				verts.Add(item);
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+D0]");
				_ = 0;
				Vector3 item2 = (Vector3)(color + 80);
				verts.Add(item2);
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+C0]");
				_ = 0;
				Vector3 item3 = (Vector3)(color - -64);
				verts.Add(item3);
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+B0]");
				_ = 0;
				Vector3 item4 = (Vector3)(color + 48);
				verts.Add(item4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+104]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A8]");
				_ = 0;
				Vector2 item5 = (Vector2)(color + 40);
				uvs.Add(item5);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+100]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A0]");
				_ = 0;
				Vector2 item6 = (Vector2)(color + 32);
				uvs.Add(item6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+98]");
				_ = 0;
				Vector2 item7 = (Vector2)(color + 24);
				uvs.Add(item7);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+104]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+90]");
				_ = 0;
				Vector2 item8 = (Vector2)(color + 16);
				uvs.Add(item8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Color32 item9 = (Color32)(color + 12);
				cols.Add(item9);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Color32 item10 = (Color32)(color + 8);
				cols.Add(item10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Color32 item11 = (Color32)(color + 4);
				cols.Add(item11);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+F0]");
				((Color32*)(nint)color)->rgba = 0;
				cols.Add(color);
				object obj27 = obj22 + obj8;
				obj22 = obj27;
			}
			object obj28 = obj17 + obj10;
			obj17 = obj28;
		}
	}

	private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0026: Expected I, but got Obj
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0271: Expected F4, but got I
		//IL_0281: Expected F4, but got I
		//IL_0299: Expected F4, but got I
		//IL_02a9: Expected F4, but got I
		//IL_02b9: Expected F4, but got I
		//IL_02d1: Expected F4, but got I
		//IL_01d6: Expected F4, but got I
		//IL_01e6: Expected F4, but got I
		//IL_01f6: Expected F4, but got I
		//IL_020e: Expected F4, but got I
		//IL_021e: Expected F4, but got I
		//IL_022e: Expected F4, but got I
		//IL_0430: Expected F4, but got I
		//IL_0440: Expected F4, but got I
		//IL_0450: Expected F4, but got I
		//IL_0468: Expected F4, but got I
		//IL_0478: Expected F4, but got I
		//IL_0488: Expected F4, but got I
		//IL_00a2: Expected F4, but got I
		//IL_00b2: Expected F4, but got I
		//IL_00c2: Expected F4, but got I
		//IL_00d2: Expected F4, but got I
		//IL_00e2: Expected F4, but got I
		//IL_00f2: Expected F4, but got I
		//IL_0102: Expected F4, but got I
		//IL_0112: Expected F4, but got I
		//IL_04a5: Expected Obj, but got I4
		//IL_038d: Expected F4, but got I
		//IL_03a5: Expected F4, but got I
		//IL_03b5: Expected F4, but got I
		//IL_03c5: Expected F4, but got I
		//IL_03dd: Expected F4, but got I
		//IL_03ed: Expected F4, but got I
		//IL_0ab0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab5: Expected VT, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected VT, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected VT, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_051a: Expected Obj, but got I4
		//IL_050c: Expected Obj, but got I4
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected VT, but got Unknown
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected VT, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected VT, but got Unknown
		//IL_0d52: Expected Obj, but got F4
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected Obj, but got Unknown
		//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected Obj, but got Unknown
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected Obj, but got Unknown
		//IL_0691: Unknown result type (might be due to invalid IL or missing references)
		//IL_0696: Expected Obj, but got Unknown
		//IL_107f: Expected Obj, but got F4
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Expected Obj, but got Unknown
		//IL_1098: Unknown result type (might be due to invalid IL or missing references)
		//IL_109d: Expected Obj, but got Unknown
		//IL_10af: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b4: Expected Obj, but got Unknown
		//IL_10f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f6: Expected Obj, but got Unknown
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1138: Expected Obj, but got Unknown
		//IL_1142: Unknown result type (might be due to invalid IL or missing references)
		//IL_1147: Expected Obj, but got Unknown
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected Obj, but got Unknown
		//IL_116d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1172: Expected Obj, but got Unknown
		//IL_1189: Unknown result type (might be due to invalid IL or missing references)
		//IL_118e: Expected Obj, but got Unknown
		//IL_11c3: Expected Obj, but got F4
		//IL_11cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d2: Expected Obj, but got Unknown
		//IL_11dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e1: Expected Obj, but got Unknown
		//IL_11f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f8: Expected Obj, but got Unknown
		//IL_122d: Expected Obj, but got F4
		//IL_1237: Unknown result type (might be due to invalid IL or missing references)
		//IL_123c: Expected Obj, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_124b: Expected Obj, but got Unknown
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1262: Expected Obj, but got Unknown
		//IL_129f: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a4: Expected Obj, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e6: Expected Obj, but got Unknown
		//IL_12f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f5: Expected Obj, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1311: Expected Obj, but got Unknown
		//IL_131b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Expected Obj, but got Unknown
		//IL_1349: Unknown result type (might be due to invalid IL or missing references)
		//IL_134e: Expected Obj, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected Obj, but got Unknown
		//IL_0eb1: Expected Obj, but got F4
		//IL_0ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Expected Obj, but got Unknown
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected Obj, but got Unknown
		//IL_0ee1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee6: Expected Obj, but got Unknown
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Expected I4, but got Unknown
		//IL_0e52: Expected Obj, but got I4
		//IL_13a4: Expected Obj, but got F4
		//IL_13ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b3: Expected Obj, but got Unknown
		//IL_13bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c2: Expected Obj, but got Unknown
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d9: Expected Obj, but got Unknown
		//IL_1413: Expected Obj, but got I4
		//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e76: Expected Obj, but got Unknown
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Expected Obj, but got Unknown
		//IL_1457: Unknown result type (might be due to invalid IL or missing references)
		//IL_145c: Expected Obj, but got Unknown
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Expected Obj, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Expected Obj, but got Unknown
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_1496: Expected Obj, but got Unknown
		//IL_14ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b2: Expected Obj, but got Unknown
		//IL_14e7: Expected Obj, but got F4
		//IL_14f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected Obj, but got Unknown
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected Obj, but got Unknown
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_151c: Expected Obj, but got Unknown
		//IL_1551: Expected Obj, but got F4
		//IL_155b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1560: Expected Obj, but got Unknown
		//IL_156a: Unknown result type (might be due to invalid IL or missing references)
		//IL_156f: Expected Obj, but got Unknown
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_1586: Expected Obj, but got Unknown
		//IL_15c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c7: Expected Obj, but got Unknown
		//IL_1603: Unknown result type (might be due to invalid IL or missing references)
		//IL_1608: Expected Obj, but got Unknown
		//IL_1612: Unknown result type (might be due to invalid IL or missing references)
		//IL_1617: Expected Obj, but got Unknown
		//IL_162e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1633: Expected Obj, but got Unknown
		//IL_163d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected Obj, but got Unknown
		//IL_1658: Unknown result type (might be due to invalid IL or missing references)
		//IL_165d: Expected I4, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected VT, but got Unknown
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Expected I4, but got Unknown
		//IL_1000: Expected Obj, but got I4
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected VT, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected VT, but got Unknown
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024: Expected Obj, but got Unknown
		//IL_0846: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected Obj, but got Unknown
		//IL_0863: Expected Obj, but got I
		//IL_097e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected VT, but got Unknown
		//IL_09e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e6: Expected VT, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected VT, but got Unknown
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3b: Expected Obj, but got Unknown
		//IL_0a53: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 384;
		if (mFillAmount < 0.001f)
		{
			return;
		}
		object obj3 = obj + 368;
		nint num = (nint)this;
		object obj4 = this + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S2_v3 (Il2CppClass<UIBasicSprite>)+174] (should have been resolved before IL gen)");
		Vector4 vector = drawingUVs;
		Color32 color = drawingColor;
		float num2;
		float num3;
		float num4;
		float num5;
		float num6;
		float num7;
		float num8;
		float num9;
		if (mFillDirection != FillDirection.Horizontal)
		{
			if (mFillDirection != FillDirection.Vertical)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				num8 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				num9 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				float num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				float num11 = num10 - 0f;
				float num12 = num11 * mFillAmount;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				float num13 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				float num14 = num13 - 0f;
				float num15 = num14 * mFillAmount;
				if (~(mInvert ? 1u : 0u) == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
					float num16 = 0f - num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
					float num17 = 0f - num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
					num2 = 0f;
					num3 = num17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
					num4 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
					num5 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
					num6 = 0f;
					num7 = num16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
					num8 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
					num9 = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
					float num18 = 0f + num15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
					float num19 = 0f + num12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
					num2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
					num3 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
					num4 = 0f;
					num5 = num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
					num6 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
					num7 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
					num8 = 0f;
					num9 = num18;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
			float num20 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
			float num21 = num20 - 0f;
			float num22 = num21 * mFillAmount;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
			float num23 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
			float num24 = num23 - 0f;
			float num25 = num24 * mFillAmount;
			if (~(mInvert ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				float num26 = 0f - num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				float num27 = 0f - num22;
				num2 = num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				num3 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				num4 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				num5 = 0f;
				num6 = num26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				num7 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+178]");
				num8 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				num9 = 0f;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				float num28 = 0f + num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				float num29 = 0f + num22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				num2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				num3 = 0f;
				num4 = num29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				num5 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
				num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+174]");
				num7 = 0f;
				num8 = num28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+17C]");
				num9 = 0f;
			}
		}
		Vector2[] array = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+168]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A0]");
		_ = 0;
		Vector2[] array2 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+160]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+98]");
		_ = 0;
		Vector2[] array3 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+158]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+90]");
		_ = 0;
		Vector2[] array4 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+150]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+88]");
		_ = 0;
		Vector2[] array5 = mTempUVs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+80]");
		_ = 0;
		Vector2[] array6 = mTempUVs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+140]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+78]");
		_ = 0;
		Vector2[] array7 = mTempUVs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+138]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+70]");
		_ = 0;
		Vector2[] array8 = mTempUVs;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+130]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
		_ = 0;
		object obj6 = default;
		if (mFillAmount < 1f)
		{
			object obj5 = mFillDirection - 2;
			if (mFillDirection == FillDirection.Radial90)
			{
				if (RadialCut(mTempPos, mTempUVs, mFillAmount, mInvert, 0))
				{
					while ((nint)obj6 < 4)
					{
						object obj7 = obj6 << 3;
						object obj8 = (object)mTempPos + obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ S1_v104+10]");
						_ = 0;
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
						_ = 0;
						Vector3 item = (Vector3)(obj + 40);
						verts.Add(item);
						object obj9 = obj6 << 3;
						object obj10 = (object)mTempUVs + obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ S1_v117+10]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
						_ = 0;
						Vector2 item2 = (Vector2)(obj + 32);
						uvs.Add(item2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
						_ = 0;
						Color32 item3 = (Color32)(obj + 28);
						cols.Add(item3);
						object obj11 = obj6 + 1;
						obj6 = obj11;
					}
				}
				return;
			}
			object obj40 = default;
			if ((nint)obj5 == 1)
			{
				object obj12 = 0;
				while ((nint)obj12 < 2)
				{
					object obj13 = mTempPos + 16;
					float num30 = num8 - num6;
					float num31 = 0.5f;
					if (obj12 == null)
					{
						num31 = 0f;
					}
					float num32 = num30 * num31;
					float num33 = num6 + num32;
					obj13 = num33;
					object obj14 = mTempPos + 24;
					object obj15 = mTempPos + 16;
					obj14 = obj15;
					object obj16 = mTempPos + 32;
					float num34 = num8 - num6;
					float num35 = 1f;
					if (obj12 == null)
					{
						num35 = 0.5f;
					}
					float num36 = num34 * num35;
					float num37 = num6 + num36;
					obj16 = num37;
					object obj17 = mTempPos + 40;
					object obj18 = mTempPos + 32;
					obj17 = obj18;
					object obj19 = mTempPos + 16;
					float num38 = num9 - num7;
					float num39 = num38 * 0f;
					float num40 = num7 + num39;
					object obj20 = mTempPos + 24;
					float num41 = num9 - num7;
					float num42 = num41 * 1f;
					float num43 = num7 + num42;
					object obj21 = mTempPos + 32;
					object obj22 = mTempPos + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ S1_v162+4]");
					_ = 0;
					object obj23 = mTempPos + 40;
					object obj24 = mTempPos + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ S1_v169+4]");
					_ = 0;
					object obj25 = mTempUVs + 16;
					float num44 = num4 - num2;
					float num45 = num44 * num31;
					float num46 = num2 + num45;
					obj25 = num46;
					object obj26 = mTempUVs + 24;
					object obj27 = mTempUVs + 16;
					obj26 = obj27;
					object obj28 = mTempUVs + 32;
					float num47 = num4 - num2;
					float num48 = num47 * num35;
					float num49 = num2 + num48;
					obj28 = num49;
					object obj29 = mTempUVs + 40;
					object obj30 = mTempUVs + 32;
					obj29 = obj30;
					object obj31 = mTempUVs + 16;
					float num50 = num5 - num3;
					float num51 = num50 * 0f;
					float num52 = num3 + num51;
					object obj32 = mTempUVs + 24;
					float num53 = num5 - num3;
					float num54 = num53 * 1f;
					float num55 = num3 + num54;
					object obj33 = mTempUVs + 32;
					object obj34 = mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ S1_v202+4]");
					_ = 0;
					object obj35 = mTempUVs + 40;
					object obj36 = mTempUVs + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S1_v209+4]");
					_ = 0;
					float num56 = mFillAmount + mFillAmount;
					object obj37 = 1 - obj12;
					if (!mInvert)
					{
						obj37 = obj12;
					}
					float num57 = num56 - (float)obj37;
					float num58 = Math.Min(num57, 1f);
					bool flag = num57 < 0f;
					float fill = 0f;
					if (!flag)
					{
						fill = num58;
					}
					bool flag2 = (byte)(~(mInvert ? 1u : 0u)) != 0;
					int val = obj12 + 3;
					int corner = NGUIMath.RepeatIndex(val, 4);
					bool flag3 = RadialCut(mTempPos, mTempUVs, fill, flag2, corner);
					bool flag4 = !flag3;
					object obj38 = 0;
					object obj39 = obj40;
					if (!flag4)
					{
						while (true)
						{
							bool flag5 = (nint)obj38 >= 4;
							obj39 = obj40;
							if (flag5)
							{
								break;
							}
							object obj41 = obj38 << 3;
							object obj42 = (object)mTempPos + obj41;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1167 @ S1_v226+10]");
							_ = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Vector3 item4 = (Vector3)(obj - -64);
							verts.Add(item4);
							object obj43 = obj38 << 3;
							object obj44 = (object)mTempUVs + obj43;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ S1_v239+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
							_ = 0;
							Vector2 item5 = (Vector2)(obj + 56);
							uvs.Add(item5);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Color32 item6 = (Color32)(obj + 52);
							cols.Add(item6);
							object obj45 = obj38 + 1;
							obj38 = obj45;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
							obj40 = 0;
						}
					}
					object obj46 = obj12 + 1;
					obj40 = obj39;
					obj12 = obj46;
				}
				return;
			}
			if ((nint)obj5 == 2)
			{
				object obj47 = 0;
				while ((nint)obj47 < 4)
				{
					object obj48 = mTempPos + 16;
					float num59 = num8 - num6;
					bool flag6 = (nint)obj47 > 1;
					float num60 = 0.5f;
					if (!flag6)
					{
						num60 = 0f;
					}
					float num61 = num59 * num60;
					float num62 = num6 + num61;
					obj48 = num62;
					object obj49 = mTempPos + 24;
					object obj50 = mTempPos + 16;
					obj49 = obj50;
					object obj51 = mTempPos + 32;
					float num63 = num8 - num6;
					float num64 = 1f;
					if (!flag6)
					{
						num64 = 0.5f;
					}
					float num65 = num63 * num64;
					float num66 = num6 + num65;
					obj51 = num66;
					object obj52 = mTempPos + 40;
					object obj53 = mTempPos + 32;
					obj52 = obj53;
					object obj54 = mTempPos + 16;
					float num67 = num9 - num7;
					bool flag7 = obj47 == null;
					bool flag8 = (nint)obj47 == 3;
					object obj55 = flag7 | flag8;
					float num68 = 0f;
					if (obj55 == null)
					{
						num68 = 0.5f;
					}
					float num69 = num67 * num68;
					float num70 = num7 + num69;
					object obj56 = mTempPos + 24;
					float num71 = num9 - num7;
					float num72 = 0.5f;
					if (obj55 == null)
					{
						num72 = 1f;
					}
					float num73 = num71 * num72;
					float num74 = num7 + num73;
					object obj57 = mTempPos + 32;
					object obj58 = mTempPos + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v952 @ S1_v284+4]");
					_ = 0;
					object obj59 = mTempPos + 40;
					object obj60 = mTempPos + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v965 @ S1_v291+4]");
					_ = 0;
					object obj61 = mTempUVs + 16;
					float num75 = num4 - num2;
					float num76 = num75 * num60;
					float num77 = num2 + num76;
					obj61 = num77;
					object obj62 = mTempUVs + 24;
					object obj63 = mTempUVs + 16;
					obj62 = obj63;
					object obj64 = mTempUVs + 32;
					float num78 = num4 - num2;
					float num79 = num78 * num64;
					float num80 = num2 + num79;
					obj64 = num80;
					object obj65 = mTempUVs + 40;
					object obj66 = mTempUVs + 32;
					obj65 = obj66;
					object obj67 = mTempUVs + 16;
					float num81 = num5 - num3;
					float num82 = num81 * num68;
					float num83 = num3 + num82;
					object obj68 = mTempUVs + 24;
					float num84 = num5 - num3;
					float num85 = num84 * num72;
					float num86 = num3 + num85;
					object obj69 = mTempUVs + 32;
					object obj70 = mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ S1_v324+4]");
					_ = 0;
					object obj71 = mTempUVs + 40;
					object obj72 = mTempUVs + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ S1_v331+4]");
					_ = 0;
					int val2 = obj47 + 2;
					int num87 = NGUIMath.RepeatIndex(val2, 4);
					float num88 = mFillAmount * 4f;
					int num89 = 3 - num87;
					if (!mInvert)
					{
						num87 = num89;
					}
					float num90 = num88 - (float)num87;
					float num91 = Math.Min(num90, 1f);
					bool flag9 = num90 < 0f;
					float fill2 = 0f;
					if (!flag9)
					{
						fill2 = num91;
					}
					int val3 = obj47 + 2;
					int corner2 = NGUIMath.RepeatIndex(val3, 4);
					bool flag10 = RadialCut(mTempPos, mTempUVs, fill2, mInvert, corner2);
					bool flag11 = !flag10;
					object obj73 = 0;
					object obj74 = obj40;
					if (!flag11)
					{
						while (true)
						{
							bool flag12 = (nint)obj73 >= 4;
							obj74 = obj40;
							if (flag12)
							{
								break;
							}
							object obj75 = obj73 << 3;
							object obj76 = (object)mTempPos + obj75;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ S1_v350+10]");
							_ = 0;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Vector3 item7 = (Vector3)(obj + 88);
							verts.Add(item7);
							object obj77 = obj73 << 3;
							object obj78 = (object)mTempUVs + obj77;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S1_v363+10]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
							_ = 0;
							Vector2 item8 = (Vector2)(obj + 80);
							uvs.Add(item8);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
							_ = 0;
							Color32 item9 = (Color32)(obj + 76);
							cols.Add(item9);
							object obj79 = obj73 + 1;
							obj73 = obj79;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
							obj40 = 0;
						}
					}
					object obj80 = obj47 + 1;
					obj40 = obj74;
					obj47 = obj80;
				}
				return;
			}
		}
		while ((nint)obj6 < 4)
		{
			object obj81 = obj6 << 3;
			object obj82 = (object)mTempPos + obj81;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ S1_v68+10]");
			_ = 0;
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
			_ = 0;
			Vector3 item10 = (Vector3)(obj + 16);
			verts.Add(item10);
			object obj83 = obj6 << 3;
			object obj84 = (object)mTempUVs + obj83;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S1_v81+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
			_ = 0;
			Vector2 item11 = (Vector2)(obj + 8);
			uvs.Add(item11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+170]");
			_ = 0;
			Color32 item12 = (Color32)(obj + 4);
			cols.Add(item12);
			object obj85 = obj6 + 1;
			obj6 = obj85;
		}
	}

	private unsafe void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_1241: Expected I, but got Obj
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0026: Expected I, but got Obj
		//IL_0035: Expected I, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Invalid comparison between Obj and F4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_014b: Expected I, but got Obj
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0168: Expected I, but got Obj
		//IL_017a: Expected I, but got Obj
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01b3: Expected I, but got Obj
		//IL_01c3: Expected F4, but got I
		//IL_0258: Expected Obj, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected Obj, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected Obj, but got Unknown
		//IL_0333: Expected Obj, but got I4
		//IL_034c: Expected Obj, but got I4
		//IL_12bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Expected Obj, but got Unknown
		//IL_12d6: Expected Obj, but got I4
		//IL_12f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f9: Expected Obj, but got Unknown
		//IL_1320: Expected Obj, but got I4
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_0500: Expected F4, but got I
		//IL_0509: Expected Obj, but got I4
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03ce: Expected Obj, but got I4
		//IL_03e7: Expected Obj, but got I4
		//IL_1384: Expected Obj, but got I4
		//IL_13af: Expected Obj, but got I
		//IL_13c3: Expected Obj, but got I4
		//IL_13ee: Expected Obj, but got I
		//IL_142d: Expected Obj, but got I
		//IL_1453: Expected Obj, but got I
		//IL_1479: Expected Obj, but got I
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Expected Obj, but got Unknown
		//IL_14ad: Expected Obj, but got I
		//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bb: Expected Obj, but got Unknown
		//IL_14e3: Expected F4, but got I
		//IL_14ec: Expected Obj, but got I4
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_046f: Expected F4, but got I
		//IL_0478: Expected Obj, but got I4
		//IL_0100: Invalid comparison between Obj and F4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_0525: Expected Obj, but got I4
		//IL_122a: Unknown result type (might be due to invalid IL or missing references)
		//IL_122f: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected Obj, but got Unknown
		//IL_05d5: Expected Obj, but got I4
		//IL_120f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected Obj, but got Unknown
		//IL_15bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c1: Expected VT, but got Unknown
		//IL_163a: Expected F4, but got I
		//IL_163a: Expected F4, but got I
		//IL_163a: Expected F4, but got I
		//IL_163a: Expected F4, but got Ref
		//IL_163a: Expected F4, but got I
		//IL_163a: Expected F4, but got I
		//IL_163a: Expected F4, but got I
		//IL_163a: Expected F4, but got Ref
		//IL_164a: Expected F4, but got I
		//IL_165a: Expected F4, but got I
		//IL_166a: Expected F4, but got I
		//IL_167a: Expected F4, but got I
		//IL_168a: Expected F4, but got I
		//IL_169a: Expected F4, but got I
		//IL_1127: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c: Expected VT, but got Unknown
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11a1: Expected F4, but got I
		//IL_11b1: Expected F4, but got I
		//IL_11c1: Expected F4, but got I
		//IL_11d1: Expected F4, but got I
		//IL_11e1: Expected F4, but got I
		//IL_11f1: Expected F4, but got I
		//IL_1201: Expected F4, but got I
		//IL_18a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a7: Expected VT, but got Unknown
		//IL_1920: Expected F4, but got I
		//IL_1920: Expected F4, but got I
		//IL_1920: Expected F4, but got I
		//IL_1920: Expected F4, but got Ref
		//IL_1920: Expected F4, but got I
		//IL_1920: Expected F4, but got I
		//IL_1920: Expected F4, but got I
		//IL_1920: Expected F4, but got Ref
		//IL_1930: Expected F4, but got I
		//IL_1940: Expected F4, but got I
		//IL_1950: Expected F4, but got I
		//IL_1960: Expected F4, but got I
		//IL_1970: Expected F4, but got I
		//IL_1980: Expected F4, but got I
		//IL_0682: Expected F4, but got I
		//IL_1782: Invalid comparison between I and F4
		//IL_17a3: Expected F4, but got I
		//IL_1b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1d: Expected VT, but got Unknown
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1b92: Expected F4, but got I
		//IL_1ba2: Expected F4, but got I
		//IL_1bb2: Expected F4, but got I
		//IL_1bc2: Expected F4, but got I
		//IL_1bd2: Expected F4, but got I
		//IL_1be2: Expected F4, but got I
		//IL_1bf2: Expected F4, but got I
		//IL_0ae6: Expected F4, but got I
		//IL_19d8: Invalid comparison between F4 and I
		//IL_19f9: Expected F4, but got I
		//IL_1a09: Expected F4, but got I
		//IL_1a19: Expected F4, but got I
		//IL_06c3: Invalid comparison between I and F4
		//IL_06e4: Expected F4, but got I
		//IL_06ec: Expected I4, but got F4
		//IL_0e4a: Expected F4, but got I
		//IL_16a7: Expected F4, but got I4
		//IL_16b7: Expected F4, but got I
		//IL_1d1f: Invalid comparison between F4 and I
		//IL_1d40: Expected F4, but got I
		//IL_1d50: Expected F4, but got I
		//IL_1753: Invalid comparison between F4 and I
		//IL_0b5a: Invalid comparison between I and F4
		//IL_16fb: Expected F4, but got I
		//IL_0e8b: Invalid comparison between I and F4
		//IL_0eb4: Expected F4, but got I
		//IL_0c1b: Expected F4, but got I
		//IL_1c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c33: Expected VT, but got Unknown
		//IL_1c90: Expected F4, but got I
		//IL_1c90: Expected F4, but got I
		//IL_1c90: Expected F4, but got I
		//IL_1c90: Expected F4, but got I
		//IL_1c90: Expected F4, but got I
		//IL_1caf: Expected F4, but got I
		//IL_1cc7: Expected F4, but got I
		//IL_1e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e27: Expected VT, but got Unknown
		//IL_1e86: Expected F4, but got I
		//IL_1e86: Expected F4, but got I
		//IL_1e86: Expected F4, but got Ref
		//IL_1e86: Expected F4, but got I
		//IL_1e86: Expected F4, but got I
		//IL_07d4: Expected F4, but got I
		//IL_07cf: Expected native int or pointer, but got VT
		//IL_07f3: Expected F4, but got I
		//IL_07ee: Expected native int or pointer, but got VT
		//IL_0812: Invalid comparison between I and F4
		//IL_19bb: Expected F4, but got I
		//IL_08d3: Expected F4, but got I
		//IL_1d02: Expected F4, but got I
		//IL_1ded: Expected F4, but got I
		//IL_1ded: Expected F4, but got Ref
		//IL_1736: Expected F4, but got I
		object obj = default;
		Color color = (Color)(obj - 240);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<UIBasicSprite>)+18C] (should have been resolved before IL gen)");
		UnityEngine.Object obj2 = default;
		if (!(obj2 != null))
		{
			return;
		}
		object obj3 = color + 224;
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v6 (Il2CppClass<UIBasicSprite>)+1BC] (should have been resolved before IL gen)");
		nint num3 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v9 (Il2CppClass<UIBasicSprite>)+20C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		object obj5 = default;
		object obj4 = 0 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E4]");
		float num4 = 0f * (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
		float num5 = 0f * (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+EC]");
		object obj6 = 0 * obj5;
		if (obj4 == (object)0f && num4 == 0f && num5 == 0f && obj6 == (object)0f)
		{
			SimpleFill(verts, uvs, cols);
			return;
		}
		Color32 color2 = drawingColor;
		object obj7 = color + 224;
		nint num6 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ S2_v13 (Il2CppClass<UIBasicSprite>)+174] (should have been resolved before IL gen)");
		object obj8 = this + 300;
		nint num7 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v250 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+DC] (should have been resolved before IL gen)");
		nint num8 = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v261 @ S2_v18 (Il2CppClass<UnityEngine.Object>)+EC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v51+C]");
		object obj10 = default;
		object obj9 = 0 * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v51+8]");
		object obj12 = default;
		object obj11 = 0 * obj12;
		nint num9 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S2_v21 (Il2CppClass<UIBasicSprite>)+20C]");
		float num10 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ S2_v21 (Il2CppClass<UIBasicSprite>)+20C] (should have been resolved before IL gen)");
		object obj13 = default;
		float val = (float)obj11 * (float)obj13;
		float val2 = (float)obj9 * (float)obj13;
		Vector2[] array = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		_ = 0;
		Vector2[] array2 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E4]");
		_ = 0;
		Vector2[] array3 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
		_ = 0;
		Vector2[] array4 = mTempPos;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+EC]");
		_ = 0;
		object obj14 = mFlip - 1;
		object obj18;
		object obj19;
		object obj20;
		object obj21;
		object obj17;
		if (mFlip == Flip.Horizontally || ((nint)obj14 != 1 && (nint)obj14 == 2))
		{
			Vector2[] array5 = mTempPos;
			Vector2[] array6 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S1_v287 (UnityEngine.Vector2[])+10]");
			float num11 = 0f + num5;
			Vector2[] array7 = mTempPos;
			Vector2[] array8 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S1_v293 (UnityEngine.Vector2[])+28]");
			object obj15 = 0 - obj4;
			object obj16 = this + 316;
			obj17 = mTempUVs + 40;
			obj18 = 2;
			obj19 = obj16;
			obj20 = obj16;
			obj21 = 1;
		}
		else
		{
			Vector2[] array9 = mTempPos;
			Vector2[] array10 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v301 (UnityEngine.Vector2[])+10]");
			object obj22 = 0 + obj4;
			Vector2[] array11 = mTempPos;
			Vector2[] array12 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S1_v307 (UnityEngine.Vector2[])+28]");
			float num12 = 0f - num5;
			object obj23 = this + 316;
			obj17 = mTempUVs + 16;
			obj18 = 1;
			obj19 = obj23;
			obj20 = obj23;
			obj21 = 2;
		}
		obj17 = obj20;
		object obj24 = obj18 << 3;
		object obj25 = (object)mTempUVs + obj24;
		object obj26 = obj21 << 3;
		object obj27 = (object)mTempUVs + obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v51+8]");
		object obj28 = 0 + obj8;
		object obj29 = 3 << 3;
		object obj30 = (object)mTempUVs + obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ L4_v6+8]");
		object obj31 = 0 + obj19;
		Vector2[] array13 = mTempPos;
		Vector2[] array14 = mTempPos;
		object obj32 = mFlip & (Flip)(-2);
		bool flag;
		object obj37;
		if ((nint)obj32 == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S0_v112 (UnityEngine.Vector2[])+14]");
			object obj33 = 0 + obj6;
			Vector2[] array15 = mTempPos;
			Vector2[] array16 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ S1_v279 (UnityEngine.Vector2[])+2C]");
			float num13 = 0f - num4;
			object obj34 = this + 316;
			object obj35 = mTempUVs + 40;
			flag = true;
			object obj36 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S0_v668+4]");
			float num14 = 0f;
			obj37 = 2;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S0_v112 (UnityEngine.Vector2[])+14]");
			float num15 = 0f + num4;
			Vector2[] array17 = mTempPos;
			Vector2[] array18 = mTempPos;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S1_v269 (UnityEngine.Vector2[])+2C]");
			object obj38 = 0 - obj6;
			object obj39 = this + 316;
			object obj35 = mTempUVs + 16;
			flag = true;
			object obj36 = obj39;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ S0_v652+4]");
			float num14 = 0f;
			obj37 = 1;
		}
		object obj40 = obj37 << 3;
		object obj41 = (object)mTempUVs + obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v51+4]");
		_ = 0;
		object obj42 = (flag ? 1u : 0u) << 3;
		object obj43 = (object)mTempUVs + obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v51+C]");
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v51+4]");
		object obj44 = num16 + 0;
		object obj45 = 3 << 3;
		object obj46 = (object)mTempUVs + obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ L8_v3+C]");
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ L8_v3+4]");
		object obj47 = num17 + 0;
		float num18 = Math.Max(val, 1f);
		float num19 = Math.Max(val2, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		object obj48 = (nint)0 >> 24;
		float num20 = (float)obj48 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		object obj49 = (nint)0 & (nint)0xFF;
		float num21 = (float)obj49 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		object obj50 = (nint)0 >> 16;
		object obj51 = obj50 & 0xFF;
		float num22 = (float)obj51 / 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		object obj52 = (nint)0 >> 8;
		object obj53 = obj52 & 0xFF;
		float num23 = (float)obj53 / 255f;
		float num24 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+EC]");
		float num25 = 0f;
		object obj54 = 0;
		float num28 = default;
		while ((nint)obj54 < 3)
		{
			object obj55 = obj54 + 1;
			object obj139;
			for (object obj56 = 0; (nint)obj56 < 3; obj139 = obj56 + 1, obj56 = obj139)
			{
				bool flag2 = (nint)obj56 != 1;
				if (!flag2 && (nint)obj54 == 1 && centerType == AdvancedType.Invisible)
				{
					continue;
				}
				object obj57 = obj56 + 1;
				bool flag3 = (nint)obj54 != 1;
				float num14;
				float num26;
				Color color3;
				if (!flag3 && !flag2)
				{
					object obj58 = centerType - 1;
					if (centerType != AdvancedType.Sliced)
					{
						if ((nint)obj58 != 1)
						{
							continue;
						}
						Vector2[] array19 = mTempPos;
						object obj59 = obj55 << 3;
						object obj60 = (object)mTempPos + obj59;
						Vector2[] array20 = mTempPos;
						object obj61 = obj57 << 3;
						object obj62 = (object)mTempPos + obj61;
						Vector2[] array21 = mTempUVs;
						Vector2[] array22 = mTempUVs;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ S0_v579 (UnityEngine.Vector2[])+1C]");
						num26 = 0f;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S0_v585+14]");
							bool flag4 = 0f > num26;
							bool flag5 = !flag4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S0_v568 (UnityEngine.Vector2[])+18]");
							num25 = 0f;
							if (flag5)
							{
								break;
							}
							object obj63 = obj57 << 3;
							object obj64 = (object)mTempUVs + obj63;
							float num27 = num26 + num19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S0_v585+14]");
							bool flag6 = 0f < num27;
							bool flag7 = !flag6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ S0_v607+14]");
							float u1y = 0f;
							bool flag8 = (byte)(int)num28 != 0;
							num24 = num27;
							float num29 = num19;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1311 @ S0_v607+14]");
								float num30 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S0_v595 (UnityEngine.Vector2[])+1C]");
								float num31 = num30 - 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S0_v585+14]");
								float num32 = 0f - num26;
								float num33 = num32 / num19;
								num10 = Math.Min(num33, 1f);
								flag8 = num33 < 0f;
								num29 = 0f;
								if (!flag8)
								{
									num29 = num10;
								}
								float num34 = num31 * num29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S0_v595 (UnityEngine.Vector2[])+1C]");
								float num35 = 0f + num34;
								u1y = num35;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ S0_v585+14]");
								num24 = 0f;
							}
							num28 = (flag8 ? 1 : 0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S0_v568 (UnityEngine.Vector2[])+18]");
							num14 = 0f;
							while (true)
							{
								float num36 = num14;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S0_v574+10]");
								if (!(num36 < 0f))
								{
									break;
								}
								object obj65 = obj55 << 3;
								object obj66 = (object)mTempUVs + obj65;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
								((Color*)(nint)color)->b = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
								((Color*)(nint)color)->r = 0f;
								float num37 = num14 + num18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S0_v574+10]");
								float num46;
								if (0f < num37)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1605 @ S0_v624+10]");
									float num38 = 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S0_v590 (UnityEngine.Vector2[])+18]");
									float num39 = num38 - 0f;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S0_v574+10]");
									float num40 = 0f - num14;
									float num41 = num40 / num18;
									float num42 = Math.Min(num41, 1f);
									bool flag9 = num41 < 0f;
									float num43 = 0f;
									if (!flag9)
									{
										num43 = num42;
									}
									float num44 = num39 * num43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S0_v590 (UnityEngine.Vector2[])+18]");
									float num45 = 0f + num44;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ S0_v574+10]");
									num28 = 0f;
									num46 = num45;
								}
								else
								{
									num28 = num37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1605 @ S0_v624+10]");
									num46 = 0f;
								}
								float v0x = num14;
								float v1x = num28;
								float v0y = num26;
								float v1y = num24;
								ref Vector2 reference = ref array21[1];
								float u1x = num46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S0_v595 (UnityEngine.Vector2[])+1C]");
								Fill(verts, uvs, cols, v0x, v1x, v0y, v1y, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference), u1x, 0f, u1y, color);
								float num47 = num14 + num18;
								color3 = color;
								num14 = num47;
								num10 = num47;
							}
							float num48 = num26 + num19;
							num26 = num48;
						}
					}
					else
					{
						Vector2[] array23 = mTempPos;
						object obj67 = obj55 << 3;
						object obj68 = (object)mTempPos + obj67;
						Vector2[] array24 = mTempPos;
						object obj69 = obj57 << 3;
						object obj70 = (object)mTempPos + obj69;
						Vector2[] array25 = mTempUVs;
						object obj71 = obj55 << 3;
						object obj72 = (object)mTempUVs + obj71;
						Vector2[] array26 = mTempUVs;
						object obj73 = obj57 << 3;
						object obj74 = (object)mTempUVs + obj73;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+C0]");
						_ = 0;
						color3 = color + 16;
						ref Vector2 reference2 = ref array23[1];
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ S0_v521+10]");
						nint num49 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v927 @ S0_v526 (UnityEngine.Vector2[])+1C]");
						nint num50 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ S0_v532+14]");
						nint num51 = 0;
						ref Vector2 reference3 = ref array25[1];
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S0_v543+10]");
						nint num52 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ S0_v548 (UnityEngine.Vector2[])+1C]");
						nint num53 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ S0_v554+14]");
						Fill(verts, uvs, cols, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2), num49, num50, num51, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference3), num52, num53, 0f, color3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v950 @ S0_v543+10]");
						num26 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ S0_v521+10]");
						num28 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S0_v515 (UnityEngine.Vector2[])+18]");
						num14 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ S0_v532+14]");
						num24 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v941 @ S0_v537 (UnityEngine.Vector2[])+18]");
						num25 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ S0_v515 (UnityEngine.Vector2[])+18]");
						num10 = 0f;
					}
					continue;
				}
				if (!flag3)
				{
					if (obj56 != null)
					{
						if ((nint)obj56 == 1 || (nint)obj56 != 2 || topType == AdvancedType.Invisible)
						{
							continue;
						}
						if (topType != AdvancedType.Sliced && topType == AdvancedType.Tiled)
						{
							goto IL_0a38;
						}
					}
					else
					{
						if (bottomType == AdvancedType.Invisible)
						{
							continue;
						}
						if (bottomType != AdvancedType.Sliced && bottomType == AdvancedType.Tiled)
						{
							goto IL_0a38;
						}
					}
					Vector2[] array27 = mTempPos;
					object obj75 = obj55 << 3;
					object obj76 = (object)mTempPos + obj75;
					object obj77 = obj56 << 3;
					object obj78 = (object)mTempPos + obj77;
					object obj79 = obj57 << 3;
					object obj80 = (object)mTempPos + obj79;
					Vector2[] array28 = mTempUVs;
					object obj81 = obj55 << 3;
					object obj82 = (object)mTempUVs + obj81;
					object obj83 = obj56 << 3;
					object obj84 = (object)mTempUVs + obj83;
					object obj85 = obj57 << 3;
					object obj86 = (object)mTempUVs + obj85;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+A0]");
					_ = 0;
					color3 = color + 32;
					ref Vector2 reference4 = ref array27[1];
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ S0_v392+10]");
					nint num54 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1089 @ S0_v398+14]");
					nint num55 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ S0_v404+14]");
					nint num56 = 0;
					ref Vector2 reference5 = ref array28[1];
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ S0_v415+10]");
					nint num57 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S0_v421+14]");
					nint num58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ S0_v427+14]");
					Fill(verts, uvs, cols, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference4), num54, num55, num56, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference5), num57, num58, 0f, color3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ S0_v415+10]");
					num26 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1080 @ S0_v392+10]");
					num28 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v386 (UnityEngine.Vector2[])+18]");
					num14 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1098 @ S0_v404+14]");
					num24 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ S0_v409 (UnityEngine.Vector2[])+18]");
					num25 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v386 (UnityEngine.Vector2[])+18]");
					num10 = 0f;
					continue;
				}
				if (obj56 != null)
				{
					if ((nint)obj56 == 1)
					{
						if (obj54 != null)
						{
							if ((nint)obj54 == 1 || (nint)obj54 != 2 || rightType == AdvancedType.Invisible)
							{
								continue;
							}
							if (rightType != AdvancedType.Sliced && rightType == AdvancedType.Tiled)
							{
								goto IL_0d9c;
							}
						}
						else
						{
							if (leftType == AdvancedType.Invisible)
							{
								continue;
							}
							if (leftType != AdvancedType.Sliced && leftType == AdvancedType.Tiled)
							{
								goto IL_0d9c;
							}
						}
						object obj87 = obj54 << 3;
						object obj88 = (object)mTempPos + obj87;
						object obj89 = obj55 << 3;
						object obj90 = (object)mTempPos + obj89;
						Vector2[] array29 = mTempPos;
						object obj91 = obj57 << 3;
						object obj92 = (object)mTempPos + obj91;
						object obj93 = obj54 << 3;
						object obj94 = (object)mTempUVs + obj93;
						object obj95 = obj55 << 3;
						object obj96 = (object)mTempUVs + obj95;
						Vector2[] array30 = mTempUVs;
						object obj97 = obj57 << 3;
						object obj98 = (object)mTempUVs + obj97;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+88]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+80]");
						_ = 0;
						color3 = color + 80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ S0_v253+10]");
						nint num59 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ S0_v259+10]");
						nint num60 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1367 @ S0_v264 (UnityEngine.Vector2[])+1C]");
						nint num61 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ S0_v270+14]");
						nint num62 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ S0_v276+10]");
						nint num63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S0_v282+10]");
						nint num64 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1399 @ S0_v287 (UnityEngine.Vector2[])+1C]");
						nint num65 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ S0_v293+14]");
						Fill(verts, uvs, cols, num59, num60, num61, num62, num63, num64, num65, 0f, color3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1394 @ S0_v282+10]");
						num26 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1362 @ S0_v259+10]");
						num28 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ S0_v253+10]");
						num14 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ S0_v270+14]");
						num24 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1385 @ S0_v276+10]");
						num25 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1353 @ S0_v253+10]");
						num10 = 0f;
						continue;
					}
					if ((nint)obj56 != 2 || topType == AdvancedType.Invisible)
					{
						goto IL_0f80;
					}
				}
				else if (bottomType == AdvancedType.Invisible)
				{
					goto IL_0f80;
				}
				goto IL_1010;
				IL_0f80:
				if (obj54 != null)
				{
					if ((nint)obj54 == 1 || (nint)obj54 != 2 || rightType == AdvancedType.Invisible)
					{
						continue;
					}
				}
				else if (leftType == AdvancedType.Invisible)
				{
					continue;
				}
				goto IL_1010;
				IL_1010:
				object obj99 = obj54 << 3;
				object obj100 = (object)mTempPos + obj99;
				object obj101 = obj55 << 3;
				object obj102 = (object)mTempPos + obj101;
				object obj103 = obj56 << 3;
				object obj104 = (object)mTempPos + obj103;
				object obj105 = obj57 << 3;
				object obj106 = (object)mTempPos + obj105;
				object obj107 = obj54 << 3;
				object obj108 = (object)mTempUVs + obj107;
				object obj109 = obj55 << 3;
				object obj110 = (object)mTempUVs + obj109;
				object obj111 = obj56 << 3;
				object obj112 = (object)mTempUVs + obj111;
				object obj113 = obj57 << 3;
				object obj114 = (object)mTempUVs + obj113;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+70]");
				_ = 0;
				color3 = color - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S0_v184+10]");
				nint num66 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ S0_v190+10]");
				nint num67 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ S0_v196+14]");
				nint num68 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ S0_v202+14]");
				nint num69 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ S0_v208+10]");
				nint num70 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ S0_v214+10]");
				nint num71 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1210 @ S0_v220+14]");
				nint num72 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1219 @ S0_v226+14]");
				Fill(verts, uvs, cols, num66, num67, num68, num69, num70, num71, num72, 0f, color3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ S0_v214+10]");
				num26 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1165 @ S0_v190+10]");
				num28 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S0_v184+10]");
				num14 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ S0_v202+14]");
				num24 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ S0_v208+10]");
				num25 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S0_v184+10]");
				num10 = 0f;
				continue;
				IL_0a38:
				Vector2[] array31 = mTempPos;
				object obj115 = obj55 << 3;
				object obj116 = (object)mTempPos + obj115;
				object obj117 = obj56 << 3;
				object obj118 = (object)mTempPos + obj117;
				object obj119 = obj57 << 3;
				object obj120 = (object)mTempPos + obj119;
				Vector2[] array32 = mTempUVs;
				object obj121 = obj56 << 3;
				object obj122 = (object)mTempUVs + obj121;
				object obj123 = obj57 << 3;
				object obj124 = (object)mTempUVs + obj123;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1242 @ S0_v442 (UnityEngine.Vector2[])+18]");
				num14 = 0f;
				while (true)
				{
					float num73 = num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ S0_v448+10]");
					bool flag10 = num73 < 0f;
					bool flag11 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S0_v460+14]");
					num26 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ S0_v465 (UnityEngine.Vector2[])+18]");
					num24 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ S0_v454+14]");
					num25 = 0f;
					if (flag11)
					{
						break;
					}
					object obj125 = obj55 << 3;
					object obj126 = (object)mTempUVs + obj125;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+B0]");
					_ = 0;
					float num74 = num14 + num18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ S0_v448+10]");
					float num83;
					if (0f < num74)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ S0_v489+10]");
						float num75 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ S0_v465 (UnityEngine.Vector2[])+18]");
						float num76 = num75 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ S0_v448+10]");
						float num77 = 0f - num14;
						float num78 = num77 / num18;
						float num79 = Math.Min(num78, 1f);
						bool flag12 = num78 < 0f;
						float num80 = 0f;
						if (!flag12)
						{
							num80 = num79;
						}
						float num81 = num76 * num80;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1275 @ S0_v465 (UnityEngine.Vector2[])+18]");
						float num82 = 0f + num81;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ S0_v448+10]");
						num28 = 0f;
						num83 = num82;
					}
					else
					{
						num28 = num74;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ S0_v489+10]");
						num83 = 0f;
					}
					color3 = color + 48;
					float v0x2 = num14;
					float v1x2 = num28;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1261 @ S0_v454+14]");
					nint num84 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ S0_v460+14]");
					nint num85 = 0;
					ref Vector2 reference6 = ref array32[1];
					float u1x2 = num83;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1284 @ S0_v471+14]");
					nint num86 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ S0_v477+14]");
					Fill(verts, uvs, cols, v0x2, v1x2, num84, num85, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference6), u1x2, num86, 0f, color3);
					float num87 = num14 + num18;
					num14 = num87;
					num10 = num87;
				}
				continue;
				IL_0d9c:
				object obj127 = obj54 << 3;
				object obj128 = (object)mTempPos + obj127;
				object obj129 = obj55 << 3;
				object obj130 = (object)mTempPos + obj129;
				Vector2[] array33 = mTempPos;
				object obj131 = obj57 << 3;
				object obj132 = (object)mTempPos + obj131;
				object obj133 = obj54 << 3;
				object obj134 = (object)mTempUVs + obj133;
				object obj135 = obj55 << 3;
				object obj136 = (object)mTempUVs + obj135;
				Vector2[] array34 = mTempUVs;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ S0_v320 (UnityEngine.Vector2[])+1C]");
				num14 = 0f;
				while (true)
				{
					float num88 = num14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1488 @ S0_v326+14]");
					bool flag13 = num88 < 0f;
					bool flag14 = !flag13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ S0_v309+10]");
					num26 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ S0_v343 (UnityEngine.Vector2[])+1C]");
					num24 = 0f;
					if (flag14)
					{
						break;
					}
					object obj137 = obj57 << 3;
					object obj138 = (object)mTempUVs + obj137;
					float num89 = num14 + num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1488 @ S0_v326+14]");
					bool flag15 = 0f < num89;
					bool flag16 = !flag15;
					float num90 = num89;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ S0_v355+14]");
					num25 = 0f;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ S0_v355+14]");
						float num91 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ S0_v343 (UnityEngine.Vector2[])+1C]");
						float num92 = num91 - 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1488 @ S0_v326+14]");
						float num93 = 0f - num14;
						float num94 = num93 / num19;
						float num95 = Math.Min(num94, 1f);
						bool flag17 = num94 < 0f;
						float num96 = 0f;
						if (!flag17)
						{
							num96 = num95;
						}
						float num97 = num92 * num96;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ S0_v343 (UnityEngine.Vector2[])+1C]");
						float num98 = 0f + num97;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1488 @ S0_v326+14]");
						num90 = 0f;
						num25 = num98;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+98]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+90]");
					_ = 0;
					color3 = color + 96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ S0_v309+10]");
					nint num99 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ S0_v315+10]");
					nint num100 = 0;
					float v0y2 = num14;
					float v1y2 = num90;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1497 @ S0_v332+10]");
					nint num101 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1506 @ S0_v338+10]");
					nint num102 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1511 @ S0_v343 (UnityEngine.Vector2[])+1C]");
					Fill(verts, uvs, cols, num99, num100, v0y2, v1y2, num101, num102, 0f, num25, color3);
					float num103 = num14 + num19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1473 @ S0_v315+10]");
					num28 = 0f;
					num14 = num103;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ S0_v309+10]");
					num10 = 0f;
				}
			}
			object obj140 = obj54 + 1;
			obj54 = obj140;
		}
	}

	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		bool flag = fill < 0.001f;
		bool result = false;
		if (!flag)
		{
			int num = corner & 1;
			int num2 = num ^ (invert ? 1 : 0);
			bool flag2 = fill > 0.999f;
			int num3 = num2;
			if (!flag2)
			{
				num3 = 1;
			}
			bool flag3 = num3 == 0;
			result = true;
			if (!flag3)
			{
				float num4 = Math.Min(fill, 1f);
				bool flag4 = fill < 0f;
				float num5 = 0f;
				if (!flag4)
				{
					num5 = num4;
				}
				float num6 = 1f - num5;
				if (num2 == 0)
				{
					num6 = num5;
				}
				float num7 = num6 * ((float)Math.PI / 2f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
				float cos = default;
				float sin = default;
				RadialCut(xy, cos, sin, (byte)num2 != 0, corner);
				RadialCut(uv, cos, sin, (byte)num2 != 0, corner);
				result = true;
			}
		}
		return result;
	}

	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected Obj, but got Unknown
		//IL_09bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c0: Expected Obj, but got Unknown
		//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ce: Expected Obj, but got Unknown
		//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e9: Expected Obj, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f7: Expected Obj, but got Unknown
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Expected Obj, but got Unknown
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected Obj, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected Obj, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c4: Expected Obj, but got Unknown
		//IL_06e1: Expected Obj, but got I
		//IL_0bb4: Expected Obj, but got F4
		//IL_0582: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected Obj, but got Unknown
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Expected Obj, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected Obj, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_0604: Expected Obj, but got I
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected Obj, but got Unknown
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected Obj, but got Unknown
		//IL_0b60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Expected Obj, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected Obj, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected Obj, but got Unknown
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected Obj, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected Obj, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_07a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ae: Expected Obj, but got Unknown
		//IL_07cb: Expected Obj, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected Obj, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected Obj, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected Obj, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected Obj, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_08e8: Expected Obj, but got F4
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Expected Obj, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected Obj, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Obj, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected Obj, but got Unknown
		//IL_0a62: Expected Obj, but got F4
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected Obj, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected Obj, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_08c1: Expected Obj, but got F4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected Obj, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected Obj, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected Obj, but got Unknown
		int val = corner + 1;
		int num = NGUIMath.RepeatIndex(val, 4);
		int val2 = corner + 2;
		int num2 = NGUIMath.RepeatIndex(val2, 4);
		int val3 = corner + 3;
		int num3 = NGUIMath.RepeatIndex(val3, 4);
		float num5;
		if ((corner & 1) != 0)
		{
			float num15;
			if (cos < sin)
			{
				float num4 = cos / sin;
				if (!invert)
				{
					num5 = num4;
					goto IL_0222;
				}
				int num6 = num << 3;
				object obj = xy + num6;
				object obj2 = obj + 16;
				int num7 = corner << 3;
				object obj3 = xy + num7;
				object obj4 = obj3 + 16;
				int num8 = num2 << 3;
				object obj5 = xy + num8;
				object obj6 = obj5 + 16;
				object obj7 = obj6 - obj4;
				float num9 = Math.Min(num4, 1f);
				bool flag = num4 < 0f;
				float num10 = 0f;
				if (!flag)
				{
					num10 = num9;
				}
				float num11 = (float)obj7 * num10;
				float num12 = (float)obj4 + num11;
				obj2 = num12;
				int num13 = num2 << 3;
				object obj8 = xy + num13;
				object obj9 = obj8 + 16;
				int num14 = num << 3;
				object obj10 = xy + num14;
				object obj11 = obj10 + 16;
				obj9 = obj11;
				num15 = 1f;
			}
			else if (cos > sin)
			{
				num15 = sin / cos;
				if (!invert)
				{
					int num16 = num2 << 3;
					object obj12 = xy + num16;
					object obj13 = obj12 + 16;
					int num17 = corner << 3;
					object obj14 = xy + num17;
					object obj15 = obj14 + 16;
					int num18 = num2 << 3;
					object obj16 = xy + num18;
					object obj17 = obj16 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S2_v82+4]");
					nint num19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v92+4]");
					object obj18 = num19 - 0;
					float num20 = Math.Min(num15, 1f);
					bool flag2 = num15 < 0f;
					float num21 = 0f;
					if (!flag2)
					{
						num21 = num20;
					}
					float num22 = (float)obj18 * num21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S1_v92+4]");
					float num23 = 0f + num22;
					int num24 = num3 << 3;
					object obj19 = xy + num24;
					object obj20 = obj19 + 16;
					int num25 = num2 << 3;
					object obj21 = xy + num25;
					object obj22 = obj21 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S1_v100+4]");
					_ = 0;
					num5 = 1f;
					goto IL_0222;
				}
			}
			else
			{
				num5 = 1f;
				num15 = 1f;
				if (!invert)
				{
					goto IL_0222;
				}
			}
			int num26 = num << 3;
			object obj23 = xy + num26;
			object obj24 = obj23 + 16;
			int num27 = corner << 3;
			object obj25 = xy + num27;
			object obj26 = obj25 + 16;
			int num28 = num2 << 3;
			object obj27 = xy + num28;
			object obj28 = obj27 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S2_v61+4]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v71+4]");
			object obj29 = num29 - 0;
			float num30 = Math.Min(num15, 1f);
			bool flag3 = num15 < 0f;
			float num31 = 0f;
			if (!flag3)
			{
				num31 = num30;
			}
			float num32 = (float)obj29 * num31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S1_v71+4]");
			float num33 = 0f + num32;
			return;
		}
		float num35;
		float num46;
		if (cos > sin)
		{
			float num34 = sin / cos;
			if (invert)
			{
				num35 = num34;
				goto IL_056c;
			}
			int num36 = num << 3;
			object obj30 = xy + num36;
			object obj31 = obj30 + 16;
			int num37 = corner << 3;
			object obj32 = xy + num37;
			object obj33 = obj32 + 16;
			int num38 = num2 << 3;
			object obj34 = xy + num38;
			object obj35 = obj34 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v46+4]");
			nint num39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v54+4]");
			object obj36 = num39 - 0;
			float num40 = Math.Min(num34, 1f);
			bool flag4 = num34 < 0f;
			float num41 = 0f;
			if (!flag4)
			{
				num41 = num40;
			}
			float num42 = (float)obj36 * num41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v54+4]");
			float num43 = 0f + num42;
			int num44 = num2 << 3;
			object obj37 = xy + num44;
			object obj38 = obj37 + 16;
			int num45 = num << 3;
			object obj39 = xy + num45;
			object obj40 = obj39 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S1_v62+4]");
			_ = 0;
			num46 = 1f;
		}
		else if (cos < sin)
		{
			num46 = cos / sin;
			if (invert)
			{
				int num47 = num2 << 3;
				object obj41 = xy + num47;
				object obj42 = obj41 + 16;
				int num48 = corner << 3;
				object obj43 = xy + num48;
				object obj44 = obj43 + 16;
				int num49 = num2 << 3;
				object obj45 = xy + num49;
				object obj46 = obj45 + 16;
				object obj47 = obj46 - obj44;
				float num50 = Math.Min(num46, 1f);
				bool flag5 = num46 < 0f;
				float num51 = 0f;
				if (!flag5)
				{
					num51 = num50;
				}
				float num52 = (float)obj47 * num51;
				float num53 = (float)obj44 + num52;
				obj42 = num53;
				int num54 = num3 << 3;
				object obj48 = xy + num54;
				object obj49 = obj48 + 16;
				int num55 = num2 << 3;
				object obj50 = xy + num55;
				object obj51 = obj50 + 16;
				obj49 = obj51;
				num35 = 1f;
				goto IL_056c;
			}
		}
		else
		{
			bool flag6 = !invert;
			num35 = 1f;
			num46 = 1f;
			if (!flag6)
			{
				goto IL_056c;
			}
		}
		int num56 = num << 3;
		object obj52 = xy + num56;
		object obj53 = obj52 + 16;
		int num57 = corner << 3;
		object obj54 = xy + num57;
		object obj55 = obj54 + 16;
		int num58 = num2 << 3;
		object obj56 = xy + num58;
		object obj57 = obj56 + 16;
		object obj58 = obj57 - obj55;
		float num59 = Math.Min(num46, 1f);
		bool flag7 = num46 < 0f;
		float num60 = 0f;
		if (!flag7)
		{
			num60 = num59;
		}
		float num61 = (float)obj58 * num60;
		float num62 = (float)obj55 + num61;
		obj53 = num62;
		return;
		IL_056c:
		int num63 = num3 << 3;
		object obj59 = xy + num63;
		object obj60 = obj59 + 16;
		int num64 = corner << 3;
		object obj61 = xy + num64;
		object obj62 = obj61 + 16;
		int num65 = num2 << 3;
		object obj63 = xy + num65;
		object obj64 = obj63 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S2_v22+4]");
		nint num66 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v24+4]");
		object obj65 = num66 - 0;
		float num67 = Math.Min(num35, 1f);
		bool flag8 = num35 < 0f;
		float num68 = 0f;
		if (!flag8)
		{
			num68 = num67;
		}
		float num69 = (float)obj65 * num68;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v24+4]");
		float num70 = 0f + num69;
		return;
		IL_0222:
		int num71 = num3 << 3;
		object obj66 = xy + num71;
		object obj67 = obj66 + 16;
		int num72 = corner << 3;
		object obj68 = xy + num72;
		object obj69 = obj68 + 16;
		int num73 = num2 << 3;
		object obj70 = xy + num73;
		object obj71 = obj70 + 16;
		object obj72 = obj71 - obj69;
		float num74 = Math.Min(num5, 1f);
		bool flag9 = num5 < 0f;
		float num75 = 0f;
		if (!flag9)
		{
			num75 = num74;
		}
		float num76 = (float)obj72 * num75;
		float num77 = (float)obj69 + num76;
		obj67 = num77;
	}

	private unsafe static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected VT, but got Unknown
		//IL_0684: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected VT, but got Unknown
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected VT, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected VT, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected VT, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected VT, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected VT, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected VT, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected VT, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected Obj, but got Unknown
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected VT, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected VT, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected Obj, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected Obj, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected Obj, but got Unknown
		//IL_05f5: Expected I4, but got Obj
		//IL_0602: Expected native int or pointer, but got VT
		object obj = default;
		Color32 color = (Color32)(obj - 240);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+E0]");
		_ = 0;
		Vector3 item = (Vector3)(color + 96);
		verts.Add(item);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+D0]");
		_ = 0;
		Vector3 item2 = (Vector3)(color + 80);
		verts.Add(item2);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+C0]");
		_ = 0;
		Vector3 item3 = (Vector3)(color - -64);
		verts.Add(item3);
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+B0]");
		_ = 0;
		Vector3 item4 = (Vector3)(color + 48);
		verts.Add(item4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A8]");
		_ = 0;
		Vector2 item5 = (Vector2)(color + 40);
		uvs.Add(item5);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+A0]");
		_ = 0;
		Vector2 item6 = (Vector2)(color + 32);
		uvs.Add(item6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+98]");
		_ = 0;
		Vector2 item7 = (Vector2)(color + 24);
		uvs.Add(item7);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color32)+90]");
		_ = 0;
		Vector2 item8 = (Vector2)(color + 16);
		uvs.Add(item8);
		float num = Math.Min(col.r, 1f);
		bool flag = col.r < 0f;
		float num2 = 0f;
		if (!flag)
		{
			num2 = num;
		}
		float num3 = num2 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num4 = Math.Min(col.g, 1f);
		bool flag2 = col.g < 0f;
		float num5 = 0f;
		if (!flag2)
		{
			num5 = num4;
		}
		float num6 = num5 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num7 = Math.Min(col.b, 1f);
		bool flag3 = col.b < 0f;
		float num8 = 0f;
		if (!flag3)
		{
			num8 = num7;
		}
		float num9 = num8 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num10 = Math.Min(col.a, 1f);
		bool flag4 = col.a < 0f;
		float num11 = 0f;
		if (!flag4)
		{
			num11 = num10;
		}
		float num12 = num11 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj3 = default;
		object obj2 = obj3 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj5 = default;
		object obj4 = obj5 << 8;
		object obj6 = obj4 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj8 = default;
		object obj7 = obj8 << 16;
		object obj9 = obj7 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj11 = default;
		object obj10 = obj11 << 24;
		object obj12 = obj9 | obj10;
		object obj13 = obj6 | obj12;
		object obj14 = obj2 | obj13;
		Color32 item9 = (Color32)(color + 12);
		cols.Add(item9);
		float num13 = num2 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num14 = num5 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num15 = num8 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num16 = num11 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj16 = default;
		object obj15 = obj16 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj18 = default;
		object obj17 = obj18 << 8;
		object obj19 = obj17 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj21 = default;
		object obj20 = obj21 << 16;
		object obj22 = obj20 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj24 = default;
		object obj23 = obj24 << 24;
		object obj25 = obj22 | obj23;
		object obj26 = obj19 | obj25;
		object obj27 = obj15 | obj26;
		Color32 item10 = (Color32)(color + 8);
		cols.Add(item10);
		float num17 = num2 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num18 = num5 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num19 = num8 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num20 = num11 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj29 = default;
		object obj28 = obj29 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj31 = default;
		object obj30 = obj31 << 8;
		object obj32 = obj30 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj34 = default;
		object obj33 = obj34 << 16;
		object obj35 = obj33 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj37 = default;
		object obj36 = obj37 << 24;
		object obj38 = obj35 | obj36;
		object obj39 = obj32 | obj38;
		object obj40 = obj28 | obj39;
		Color32 item11 = (Color32)(color + 4);
		cols.Add(item11);
		float num21 = num2 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num22 = num5 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num23 = num8 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		float num24 = num11 * 255f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @268");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj42 = default;
		object obj41 = obj42 & 0xFF;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj44 = default;
		object obj43 = obj44 << 8;
		object obj45 = obj43 & 0xFF00;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj47 = default;
		object obj46 = obj47 << 16;
		object obj48 = obj46 & 0xFF0000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @26D");
		object obj50 = default;
		object obj49 = obj50 << 24;
		object obj51 = obj48 | obj49;
		object obj52 = obj45 | obj51;
		int rgba = obj41 | obj52;
		((Color32*)(nint)color)->rgba = rgba;
		cols.Add(color);
	}

	protected UIBasicSprite()
	{
		//IL_001a: Expected I4, but got I8
		//IL_0029: Expected I4, but got I8
		//IL_0038: Expected I4, but got I8
	}

	static UIBasicSprite()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector2[] array = default;
		mTempPos = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector2[] array2 = default;
		mTempUVs = array2;
	}
}
