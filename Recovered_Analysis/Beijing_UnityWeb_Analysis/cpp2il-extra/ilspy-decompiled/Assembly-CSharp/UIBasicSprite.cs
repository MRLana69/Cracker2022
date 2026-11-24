using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
	public enum Type
	{
		Simple,
		Sliced,
		Tiled,
		Filled,
		Advanced,
		SlicedFilled
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

	protected FillDirection mFillDirection;

	protected float mFillAmount;

	protected bool mInvert;

	protected Flip mFlip;

	protected bool mApplyGradient;

	protected Color mGradientTop;

	protected Color mGradientBottom;

	[NonSerialized]
	private Rect mInnerUV;

	[NonSerialized]
	private Rect mOuterUV;

	public AdvancedType centerType;

	public AdvancedType leftType;

	public AdvancedType rightType;

	public AdvancedType bottomType;

	public AdvancedType topType;

	protected static Vector2[] mTempPos;

	protected static Vector2[] mTempUVs;

	public virtual Type type
	{
		get
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			//IL_00f2: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			SpringPanel component = ((GameObject)(object)this).GetComponent<SpringPanel>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = component != null;
			bool flag2 = !flag;
			SpringPanel springPanel = component;
			if (!flag2)
			{
				SpringPanel springPanel2 = ((GameObject)(object)this).AddComponent<SpringPanel>();
				springPanel = springPanel2;
			}
			springPanel.tag = null;
			return (Type)springPanel;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0027: Expected Obj, but got I4
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected Obj, but got Unknown
			//IL_003b: Expected Obj, but got I4
			object obj = this + 12;
			obj = value;
			object obj2 = this + 20;
			obj2 = 0;
			object obj3 = this + 16;
			obj3 = 0;
		}
	}

	public Flip flip
	{
		get
		{
			return (Flip)mType;
		}
		set
		{
			if (mType != (Type)value)
			{
				mType = (Type)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			return (FillDirection)mFlip;
		}
		set
		{
			if (mFlip != (Flip)value)
			{
				mFlip = (Flip)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public float fillAmount
	{
		get
		{
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected Obj, but got Unknown
			//IL_00ad: Expected Obj, but got I4
			//IL_0125: Expected F4, but got I
			//IL_0133: Expected I, but got Obj
			//IL_0149: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 36;
			obj = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			AnimatorStateInfo nextAnimatorStateInfo = ((Animator)(object)mChildren).GetNextAnimatorStateInfo(0);
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+C]");
			float num = 0f;
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v36 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num < 0f)
			{
				num = 0f;
			}
			else if (num > 1f)
			{
				num = 1f;
			}
			return num;
		}
		set
		{
			((UIProgressBar)(object)this).alpha = value;
		}
	}

	public override int minWidth => (int)mFillDirection;

	public override int minHeight
	{
		get
		{
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected Obj, but got Unknown
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected Obj, but got Unknown
			//IL_01f2: Expected Obj, but got I4
			//IL_0061: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I
			//IL_0290: Expected I, but got Obj
			//IL_02a6: Expected Obj, but got I
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected Obj, but got Unknown
			//IL_00a2: Expected I, but got Obj
			//IL_0328: Expected I, but got Obj
			//IL_033e: Expected Obj, but got I
			//IL_00ef: Expected I, but got Obj
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_01ac: Expected I4, but got Obj
			//IL_0157: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 32;
			object obj4 = obj2 + 16;
			object obj5 = obj2 + 48;
			obj5 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj6 = default;
			if ((nint)obj6 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj7 = default;
				if ((nint)obj7 != 4)
				{
					return 2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v58 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num5 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			float num6 = num5 + 0f;
			GUILayoutOption gUILayoutOption = GUILayout.Width(num6);
			object obj10 = gUILayoutOption & 1;
			bool flag = obj10 == null;
			GUILayoutOption gUILayoutOption2 = gUILayoutOption;
			if (!flag)
			{
				GUILayoutOption gUILayoutOption3 = (GUILayoutOption)(gUILayoutOption + 1);
				gUILayoutOption2 = gUILayoutOption3;
			}
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v44 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (2 > (nint)gUILayoutOption2)
			{
				return 2;
			}
			return (int)gUILayoutOption2;
		}
	}

	public bool invert
	{
		get
		{
			//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Expected Obj, but got Unknown
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected Obj, but got Unknown
			//IL_01f2: Expected Obj, but got I4
			//IL_0061: Expected I, but got Obj
			//IL_0077: Expected Obj, but got I
			//IL_0290: Expected I, but got Obj
			//IL_02a6: Expected Obj, but got I
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Expected Obj, but got Unknown
			//IL_00a2: Expected I, but got Obj
			//IL_0330: Expected I, but got Obj
			//IL_0346: Expected Obj, but got I
			//IL_00ef: Expected I, but got Obj
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected Obj, but got Unknown
			//IL_01ac: Expected I4, but got Obj
			//IL_0157: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 32;
			object obj4 = obj2 + 16;
			object obj5 = obj2 + 48;
			obj5 = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj6 = default;
			if ((nint)obj6 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj7 = default;
				if ((nint)obj7 != 4)
				{
					return true;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<UnityEngine.Vector4>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num2 = (nint)typeof(Vector4);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v58 (Il2CppClass<UnityEngine.Vector4>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			_ = 0;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S2_v9 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S2_v14 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			float num5 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
			float num6 = num5 + 0f;
			GUILayoutOption gUILayoutOption = GUILayout.Width(num6);
			object obj10 = gUILayoutOption & 1;
			bool flag = obj10 == null;
			GUILayoutOption gUILayoutOption2 = gUILayoutOption;
			if (!flag)
			{
				GUILayoutOption gUILayoutOption3 = (GUILayoutOption)(gUILayoutOption + 1);
				gUILayoutOption2 = gUILayoutOption3;
			}
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v44 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v52 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (2 > (nint)gUILayoutOption2)
			{
				return true;
			}
			return (byte)(int)gUILayoutOption2 != 0;
		}
		set
		{
			if (mFillDirection != (value ? FillDirection.Vertical : FillDirection.Horizontal))
			{
				mFillDirection = (value ? FillDirection.Vertical : FillDirection.Horizontal);
				mChanged = true;
			}
		}
	}

	public bool hasBorder => mInvert;

	public virtual bool premultipliedAlpha
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_0068: Invalid comparison between Obj and F4
			//IL_00ad: Invalid comparison between I and F4
			//IL_00f2: Invalid comparison between I and F4
			//IL_0137: Invalid comparison between I and F4
			object obj2 = default;
			object obj = obj2 + 32;
			obj = 0;
			_ = 0;
			object obj3 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			if (obj2 == (object)0f)
			{
				obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+4]");
				if (0f == 0f)
				{
					obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
					if (0f == 0f)
					{
						obj3 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+C]");
						return 0f != 0f;
					}
					return true;
				}
				return true;
			}
			return true;
		}
	}

	public virtual float pixelSize => mFillAmount;

	protected virtual Vector4 padding
	{
		get
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Expected Obj, but got Unknown
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector4)+12C]");
			bool flag = (nint)0 != 0;
			object obj = flag ^ this;
			if (obj != null)
			{
				object obj2 = this & 1;
				_ = 1;
			}
			Vector4 result = default;
			return result;
		}
	}

	private unsafe Vector4 drawingUVs
	{
		get
		{
			//IL_0009: Expected native int or pointer, but got VT
			//IL_0017: Expected native int or pointer, but got VT
			//IL_0025: Expected native int or pointer, but got VT
			//IL_0033: Expected native int or pointer, but got VT
			//IL_0041: Expected native int or pointer, but got VT
			//IL_004f: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = 0f;
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->x = 0f;
			((Vector4*)(nint)vector)->y = 0f;
			((Vector4*)(nint)vector)->z = 0f;
			((Vector4*)(nint)vector)->w = 0f;
			return vector;
		}
	}

	protected unsafe Color drawingColor
	{
		get
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected Obj, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected Obj, but got Unknown
			//IL_00d8: Expected F4, but got Obj
			//IL_00e8: Expected F4, but got I
			//IL_02a3: Expected native int or pointer, but got VT
			//IL_02b1: Expected native int or pointer, but got VT
			//IL_02be: Expected native int or pointer, but got VT
			//IL_02cb: Expected native int or pointer, but got VT
			//IL_02d8: Expected native int or pointer, but got VT
			//IL_02e5: Expected native int or pointer, but got VT
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected Obj, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected Obj, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Expected Obj, but got Unknown
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Expected Obj, but got Unknown
			//IL_0167: Expected F4, but got I
			//IL_017f: Expected F4, but got Obj
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Expected Obj, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Expected Obj, but got Unknown
			//IL_01f6: Expected F4, but got I
			//IL_01fe: Expected F4, but got Obj
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected Obj, but got Unknown
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0234: Expected Obj, but got Unknown
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Expected Obj, but got Unknown
			//IL_028d: Expected F4, but got I
			//IL_0295: Expected F4, but got Obj
			object obj = mFlip - 1;
			float a;
			float b;
			float g;
			float r;
			if (mFlip != Flip.Horizontally)
			{
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2)
					{
						object obj2 = this + 360;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v40+8]");
						float num = 0f + (float)obj2;
						object obj3 = this + 360;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v44+C]");
						float num2 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v44+4]");
						float num3 = num2 + 0f;
						object obj4 = this + 360;
						object obj5 = this + 360;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v51+4]");
						a = 0f;
						b = (float)obj4;
						g = num3;
						r = num;
					}
					else
					{
						object obj6 = this + 360;
						object obj7 = this + 360;
						object obj8 = this + 360;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v60+8]");
						float num4 = 0f + (float)obj8;
						object obj9 = this + 360;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v64+C]");
						float num5 = 0f;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v64+4]");
						a = num5 + 0f;
						b = num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v57+4]");
						g = 0f;
						r = (float)obj6;
					}
				}
				else
				{
					object obj10 = this + 360;
					object obj11 = this + 360;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v29+C]");
					float num6 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v29+4]");
					float num7 = num6 + 0f;
					object obj12 = this + 360;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v33+8]");
					float num8 = 0f + (float)obj12;
					object obj13 = this + 360;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v37+4]");
					a = 0f;
					b = num8;
					g = num7;
					r = (float)obj10;
				}
			}
			else
			{
				object obj14 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v12+8]");
				float num9 = 0f + (float)obj14;
				object obj15 = this + 360;
				object obj16 = this + 360;
				object obj17 = this + 360;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v22+C]");
				float num10 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v22+4]");
				a = num10 + 0f;
				b = (float)obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16+4]");
				g = 0f;
				r = num9;
			}
			Color color = default;
			((Color*)(nint)color)->r = 0f;
			((Color*)(nint)color)->b = 0f;
			((Color*)(nint)color)->r = r;
			((Color*)(nint)color)->g = g;
			((Color*)(nint)color)->b = b;
			((Color*)(nint)color)->a = a;
			return color;
		}
	}

	protected unsafe void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, Rect outer, Rect inner)
	{
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected Obj, but got Unknown
		//IL_05ab: Expected Obj, but got I4
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I4
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected Obj, but got Unknown
		//IL_05e5: Expected Obj, but got I4
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_060f: Expected Obj, but got I4
		//IL_060f: Expected Obj, but got VT
		//IL_060f: Expected VT, but got Obj
		//IL_0620: Expected F4, but got Obj
		//IL_061b: Expected native int or pointer, but got VT
		//IL_0632: Expected F4, but got I
		//IL_062d: Expected native int or pointer, but got VT
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0675: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00d8: Expected I, but got Obj
		//IL_00ee: Expected Obj, but got I
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected Obj, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected Obj, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected Obj, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected Obj, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected Obj, but got Unknown
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Expected Obj, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_09d7: Expected Obj, but got I
		//IL_09e0: Invalid comparison between Obj and F4
		//IL_0184: Expected I, but got Obj
		//IL_019a: Expected Obj, but got I
		//IL_0a2f: Expected Obj, but got F4
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected Obj, but got Unknown
		//IL_0a6d: Expected Obj, but got F4
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected I4, but got Unknown
		//IL_0745: Invalid comparison between I4 and F4
		//IL_021b: Invalid comparison between I4 and F4
		//IL_01c5: Expected I, but got Obj
		//IL_0250: Expected F4, but got I4
		//IL_076c: Expected Obj, but got F4
		//IL_07a8: Invalid comparison between I4 and F4
		//IL_026c: Invalid comparison between I4 and F4
		//IL_02a1: Expected F4, but got I4
		//IL_07f0: Expected I4, but got Obj
		//IL_032f: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got F4
		//IL_038e: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_080e: Expected VT, but got Obj
		//IL_0869: Invalid comparison between Obj and F4
		//IL_03cf: Expected I, but got Obj
		//IL_0890: Expected Obj, but got F4
		//IL_0416: Expected F4, but got Obj
		//IL_044d: Expected Obj, but got I
		//IL_091d: Expected VT, but got Obj
		//IL_0958: Expected VT, but got Obj
		//IL_0438: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 196;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 184;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 172;
		obj4 = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 208);
		Vector3 vector = NGUIMath.WorldToLocalPoint((Vector3)verts, (Camera)(object)uvs, (Camera)inner, (Transform)1);
		((Rect*)(nint)outer)->m_XMin = (float)transform;
		((Rect*)(nint)outer)->m_Width = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (UnityEngine.Transform)+10]");
		_ = 0;
		object obj5 = obj2 + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		obj = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23+8]");
		_ = 0;
		object obj6 = obj2 + 148;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27+8]");
		_ = 0;
		Transform transform2 = (Transform)(obj2 + 136);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		obj4 = transform2;
		_ = ((UnityEngine.Object)transform2).m_CachedPtr;
		object obj7 = obj2 + 124;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj8 = obj4 + obj7;
		obj4 = obj8;
		object obj9 = obj4 + 4;
		object obj10 = obj2 + 112;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v44+4]");
		object obj12 = obj11 - 0;
		obj9 = obj12;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v188 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj14 = obj2 + 100;
		object obj15 = obj2 + 8;
		object obj16 = obj2 + 88;
		object obj17 = obj2 + 76;
		object obj18 = obj2 - -64;
		object obj19 = obj2 + 52;
		object obj20 = obj2 + 40;
		object obj21 = obj2 + 28;
		object obj22 = obj2 + 16;
		if (((ComputeShader)(object)this).FindKernel((string)null) != 0)
		{
			obj5 = cols;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			_ = 0;
			int num3 = Screen.height;
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v111 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num5 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v184 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num6 = obj5 / num3;
			float num7;
			if ((float)num6 < 0f)
			{
				num7 = 0f;
			}
			else
			{
				num7 = ((!((float)num6 > 1f)) ? ((float)num6) : 1f);
			}
			List<Color> list = (List<Color>)num7;
			obj6 = cols;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			_ = 0;
			int sleepTimeout = Screen.sleepTimeout;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v27+4]");
			int num8 = (int)((nint)0 / (nint)sleepTimeout);
			if ((float)num8 < 0f)
			{
				float num9 = 0f;
			}
			else if ((float)num8 > 1f)
			{
				float num9 = 1f;
			}
			else
			{
				float num9 = num8;
			}
			float num10 = ((Camera)(object)this).depth;
			Transform parentInternal = ((Transform)(object)verts).parentInternal;
			transform2.hasChanged = (byte)(int)parentInternal != 0;
			float num11 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v31 (UnityEngine.Transform)+4]");
			float num12 = num11 / 0f;
			int sleepTimeout2 = Screen.sleepTimeout;
			float num13 = (float)sleepTimeout2 * 0.5f;
			float num14 = num13 / num12;
			obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			int num15 = Screen.height;
			obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			int sleepTimeout3 = Screen.sleepTimeout;
			obj2 = 0;
			float num16 = num14 * (float)obj7;
			float num17 = num16 / (float)num15;
			obj2 = num17;
			float num18 = num14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v44+4]");
			float num19 = num18 * 0f;
			float num20 = num19 / (float)sleepTimeout3;
			nint num21 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v142 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num22 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v180 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj15 = obj2;
			transform = (Transform)obj15;
			Vector3 vector2 = (Vector4)transform;
			obj3 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v53+8]");
			_ = 0;
			obj16 = cols;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			_ = 0;
			obj17 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			float num23 = 1f - (float)obj17;
			float num24 = ((System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num23)) ? num23 : ((float)obj16));
			list = (List<Color>)num24;
			obj18 = cols;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			_ = 0;
			obj19 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v61+4]");
			nint num25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v63+4]");
			if (num25 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v61+4]");
				object obj25 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v63+4]");
				object obj25 = 0;
			}
			transform = (Transform)(object)cols;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 vector3 = ((Camera)(object)this).ScreenToWorldPoint((Vector3)transform);
			transform = (Transform)obj20;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S0_v65+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform.localPosition;
			transform.localPosition = (Vector3)verts;
			list = (List<Color>)(object)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj21 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			object obj26 = default;
			list = (List<Color>)obj26;
			obj22 = cols;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		}
		else
		{
			transform = (Transform)(object)cols;
			Transform transform5 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			object obj27 = (object)transform + obj5;
			int num26 = Screen.height;
			List<Color> list;
			if ((nint)obj27 > num26)
			{
				int num27 = Screen.height;
				transform = (Transform)obj4;
				Transform transform6 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
				object obj28 = num27 - transform;
				list = (List<Color>)obj28;
			}
			transform = (Transform)(object)cols;
			Transform transform7 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (UnityEngine.Transform)+4]");
			nint num28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23+4]");
			object obj29 = num28 - 0;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
			{
				transform = (Transform)obj4;
				Transform transform8 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18 (UnityEngine.Transform)+4]");
				_ = 0;
			}
			int num29 = Screen.height;
			float num30 = (float)num29 * 0.5f;
			float num31 = (float)cols - num30;
			list = (List<Color>)num31;
			object obj30 = cols + 4;
			int sleepTimeout4 = Screen.sleepTimeout;
			float num32 = (float)sleepTimeout4 * 0.5f;
			float num33 = (float)obj30 - num32;
			obj30 = num33;
		}
		transform = (Transform)(object)cols;
		Transform transform9 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cols @ L3 (System.Collections.Generic.List`1<UnityEngine.Color>)+8]");
		((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private unsafe void SimpleFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_042e: Expected Obj, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I4
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_048b: Expected VT, but got Obj
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04c9: Expected VT, but got Obj
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected VT, but got Unknown
		//IL_04e4: Expected F4, but got Obj
		//IL_04df: Expected native int or pointer, but got VT
		//IL_04f6: Expected F4, but got I
		//IL_04f1: Expected native int or pointer, but got VT
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_004e: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_0512: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Expected VT, but got Unknown
		//IL_0524: Expected F4, but got Obj
		//IL_051f: Expected native int or pointer, but got VT
		//IL_0539: Expected F4, but got I
		//IL_0534: Expected native int or pointer, but got VT
		//IL_0546: Expected F4, but got Obj
		//IL_0541: Expected native int or pointer, but got VT
		//IL_055b: Expected F4, but got I
		//IL_0556: Expected native int or pointer, but got VT
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05b4: Expected F4, but got Obj
		//IL_05af: Expected native int or pointer, but got VT
		//IL_05c9: Expected F4, but got I
		//IL_05c4: Expected native int or pointer, but got VT
		//IL_05d6: Expected F4, but got Obj
		//IL_05d1: Expected native int or pointer, but got VT
		//IL_05eb: Expected F4, but got I
		//IL_05e6: Expected native int or pointer, but got VT
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_008f: Expected I, but got Obj
		//IL_0108: Expected I, but got Obj
		//IL_011e: Expected Obj, but got I
		//IL_0625: Expected F4, but got Obj
		//IL_0620: Expected native int or pointer, but got VT
		//IL_063a: Expected F4, but got I
		//IL_0635: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got Obj
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01e7: Expected F4, but got I
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_01f4: Invalid comparison between F4 and I4
		//IL_0149: Expected I, but got Obj
		//IL_0674: Expected F4, but got Obj
		//IL_066f: Expected native int or pointer, but got VT
		//IL_0689: Expected F4, but got I
		//IL_0684: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got Obj
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01aa: Expected F4, but got I
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_01b8: Expected Obj, but got F4
		//IL_029d: Expected F4, but got Obj
		//IL_0298: Expected native int or pointer, but got VT
		//IL_02b2: Expected F4, but got I
		//IL_02ad: Expected native int or pointer, but got VT
		//IL_02bf: Invalid comparison between F4 and I4
		//IL_0220: Expected F4, but got Obj
		//IL_021b: Expected native int or pointer, but got VT
		//IL_0235: Expected F4, but got I
		//IL_0230: Expected native int or pointer, but got VT
		//IL_0251: Expected Obj, but got F4
		//IL_06e0: Expected Obj, but got I
		//IL_06f6: Invalid comparison between Obj and F4
		//IL_0263: Expected F4, but got Obj
		//IL_025e: Expected native int or pointer, but got VT
		//IL_0278: Expected F4, but got I
		//IL_0273: Expected native int or pointer, but got VT
		//IL_0286: Expected Obj, but got F4
		//IL_02eb: Expected F4, but got Obj
		//IL_02e6: Expected native int or pointer, but got VT
		//IL_0300: Expected F4, but got I
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_032b: Expected VT, but got Obj
		//IL_0344: Expected Obj, but got I4
		//IL_0373: Expected I, but got Obj
		//IL_0389: Expected Obj, but got I
		//IL_0722: Expected F4, but got Obj
		//IL_071d: Expected native int or pointer, but got VT
		//IL_0734: Expected F4, but got I
		//IL_072f: Expected native int or pointer, but got VT
		//IL_0741: Expected F4, but got Obj
		//IL_073c: Expected native int or pointer, but got VT
		//IL_0756: Expected F4, but got I
		//IL_0751: Expected native int or pointer, but got VT
		//IL_0774: Expected F4, but got Obj
		//IL_076f: Expected native int or pointer, but got VT
		//IL_0789: Expected F4, but got I
		//IL_0784: Expected native int or pointer, but got VT
		//IL_0792: Expected Obj, but got VT
		//IL_03b4: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 152;
		obj = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj2 + 140;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 128;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 32;
		obj5 = 0;
		Transform transform = (Transform)(obj2 + 104);
		Vector3 vector = NGUIMath.WorldToLocalPoint((Vector3)verts, (Camera)(object)verts, (Camera)(object)uvs, (Transform)(object)cols);
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (UnityEngine.Transform)+10]");
		_ = 0;
		Transform transform2 = (Transform)(obj2 + 16);
		transform2.position = (Vector3)verts;
		Vector3 vector2 = (Vector3)(obj2 + 188);
		((Vector3*)(nint)vector2)->x = (float)transform2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 vector3 = ((Camera)(object)this).WorldToViewportPoint(vector2);
		object obj6 = obj2 + 88;
		obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = obj2 + 76;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v144 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector4 = (Vector3)(obj2 + 176);
		((Vector3*)(nint)vector4)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v32+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v35+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		object obj9 = obj2 - -64;
		Vector3 vector6 = vector4 - vector2;
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v47+8]");
		_ = 0;
		object obj10 = obj2 + 52;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AD");
		((Vector3*)(nint)vector4)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v32+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector2)->x = (float)obj10;
		Vector3 vector7 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v51+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		object obj11 = obj2 + 40;
		Vector3 vector8 = vector4 - vector2;
		obj4 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v57+8]");
		_ = 0;
		int num3 = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		nint num4 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v65 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num5 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v140 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 one = Vector2.one;
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector9 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		((Vector3*)(nint)vector9)->z = 0f;
		if (vector2.x < 0f)
		{
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector10 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			object obj13 = 0f - vector2.x;
			obj5 = obj13;
		}
		else
		{
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Vector3 vector11 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
			((Vector3*)(nint)vector11)->z = 0f;
			if (vector2.x > (float)num3)
			{
				((Vector3*)(nint)vector2)->x = (float)obj4;
				Vector3 vector12 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				((Vector3*)(nint)vector12)->z = 0f;
				float num6 = (float)num3 - vector2.x;
				obj5 = num6;
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector13 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
		((Vector3*)(nint)vector13)->z = 0f;
		if (vector2.y < 0f)
		{
			((Vector3*)(nint)vector2)->x = (float)obj3;
			Vector3 vector14 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			((Vector3*)(nint)vector14)->z = 0f;
			object obj14 = 0f - vector2.y;
		}
		else
		{
			((Vector3*)(nint)vector2)->x = (float)obj4;
			Vector3 vector15 = vector2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
			((Vector3*)(nint)vector15)->z = 0f;
			if (vector2.y > (float)sleepTimeout)
			{
				((Vector3*)(nint)vector2)->x = (float)obj4;
				Vector3 vector16 = vector2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				((Vector3*)(nint)vector16)->z = 0f;
				float num7 = (float)sleepTimeout - vector2.y;
			}
		}
		object obj15 = obj5 * obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+4]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v19+4]");
		object obj16 = num8 * 0;
		object obj17 = obj15 + obj16;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			return;
		}
		transform.localPosition = (Vector3)verts;
		transform2 = (Transform)obj5;
		obj2 = obj5;
		obj6 = 0;
		_ = 0;
		obj6 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		_ = 0;
		_ = 0f;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S0_v102 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v114 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector4)->x = (float)transform;
		((Vector3*)(nint)vector4)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Vector3 vector17 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v32+8]");
		((Vector3*)(nint)vector17)->z = 0f;
		Vector3 vector18 = vector4 - vector2;
		((Vector3*)(nint)vector2)->x = (float)obj7;
		Vector3 vector19 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v35+8]");
		((Vector3*)(nint)vector19)->z = 0f;
		Vector3 eulerAngles = ((Transform)vector2).eulerAngles;
	}

	private unsafe void SlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected Obj, but got Unknown
		//IL_06cf: Expected Obj, but got I4
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e3: Expected Obj, but got Unknown
		//IL_06ec: Expected Obj, but got I4
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected Obj, but got Unknown
		//IL_0709: Expected Obj, but got I4
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected Obj, but got Unknown
		//IL_077b: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected VT, but got Unknown
		//IL_009e: Expected F4, but got Obj
		//IL_0099: Expected native int or pointer, but got VT
		//IL_00b3: Expected F4, but got I
		//IL_00ae: Expected native int or pointer, but got VT
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected Obj, but got Unknown
		//IL_011d: Expected Obj, but got I4
		//IL_014b: Expected F4, but got Obj
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0160: Expected F4, but got I
		//IL_015b: Expected native int or pointer, but got VT
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01cf: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I
		//IL_0205: Expected F4, but got Obj
		//IL_0200: Expected native int or pointer, but got VT
		//IL_021a: Expected F4, but got I
		//IL_0215: Expected native int or pointer, but got VT
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected Obj, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0284: Expected Obj, but got I4
		//IL_029a: Expected Obj, but got I
		//IL_02ba: Expected F4, but got Obj
		//IL_02b5: Expected native int or pointer, but got VT
		//IL_02cf: Expected F4, but got I
		//IL_02ca: Expected native int or pointer, but got VT
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_033e: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0376: Expected F4, but got Obj
		//IL_0371: Expected native int or pointer, but got VT
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03e0: Expected Obj, but got I4
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0418: Expected F4, but got Obj
		//IL_0413: Expected native int or pointer, but got VT
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0487: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_04c7: Expected F4, but got Obj
		//IL_04c2: Expected native int or pointer, but got VT
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_0523: Expected Obj, but got I4
		//IL_0533: Expected Obj, but got I
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected Obj, but got Unknown
		//IL_0563: Expected F4, but got Obj
		//IL_055e: Expected native int or pointer, but got VT
		//IL_060a: Expected F4, but got Obj
		//IL_0605: Expected native int or pointer, but got VT
		//IL_061c: Expected F4, but got I
		//IL_0617: Expected native int or pointer, but got VT
		//IL_0636: Expected F4, but got Obj
		//IL_0631: Expected native int or pointer, but got VT
		//IL_0648: Expected F4, but got I
		//IL_0643: Expected native int or pointer, but got VT
		//IL_0667: Expected F4, but got Obj
		//IL_0662: Expected native int or pointer, but got VT
		//IL_0679: Expected F4, but got I
		//IL_0674: Expected native int or pointer, but got VT
		//IL_0693: Expected F4, but got Obj
		//IL_068e: Expected native int or pointer, but got VT
		//IL_06a5: Expected F4, but got I
		//IL_06a0: Expected native int or pointer, but got VT
		//IL_05a6: Expected I4, but got Obj
		//IL_05a6: Expected I4, but got Obj
		//IL_05be: Expected I4, but got Obj
		//IL_05be: Expected I4, but got Obj
		//IL_05db: Expected I4, but got Obj
		//IL_05db: Expected I4, but got Obj
		//IL_05f3: Expected I4, but got Obj
		//IL_05f3: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 448;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 432;
		obj3 = 0;
		_ = 0;
		UIDrawCall uIDrawCall = (UIDrawCall)(obj2 + 416);
		uIDrawCall = (UIDrawCall)0;
		((UnityEngine.Object)uIDrawCall).m_CachedPtr = (IntPtr)0;
		object obj4 = obj2 + 400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		_ = 0;
		object obj5 = obj2 + 384;
		Color color = drawingColor;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v22+8]");
		_ = 0;
		uIDrawCall.renderQueue = (int)this;
		object obj6 = obj2 + 368;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj7 = obj2 + 352;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj8 = obj2 + 336;
		obj8 = 0;
		_ = 0;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v32+4]");
		_ = 0;
		_ = 0f;
		Vector3 vector = (Vector3)(obj2 + 464);
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v37+8]");
		((Vector3*)(nint)vector)->z = 0f;
		verts.Add(vector);
		object obj9 = obj2 + 320;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj10 = obj2 + 304;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj11 = obj2 + 288;
		obj11 = 0;
		_ = 0;
		obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v54+C]");
		_ = 0;
		_ = 0f;
		((Vector3*)(nint)vector)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v59+8]");
		((Vector3*)(nint)vector)->z = 0f;
		verts.Add(vector);
		object obj12 = obj2 + 272;
		obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj13 = obj2 + 256;
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj14 = obj2 + 240;
		obj14 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v70+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v75+C]");
		_ = 0;
		_ = 0f;
		((Vector3*)(nint)vector)->x = (float)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v80+8]");
		((Vector3*)(nint)vector)->z = 0f;
		verts.Add(vector);
		object obj15 = obj2 + 224;
		obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj16 = obj2 + 208;
		obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj17 = obj2 + 192;
		obj17 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v91+8]");
		obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v96+4]");
		_ = 0;
		_ = 0f;
		((Vector3*)(nint)vector)->x = (float)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v101+8]");
		((Vector3*)(nint)vector)->z = 0f;
		verts.Add(vector);
		object obj18 = obj2 + 176;
		obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj19 = obj2 + 160;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj20 = obj2 + 32;
		obj20 = 0;
		obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v117+4]");
		_ = 0;
		object obj21 = obj2 + 56;
		obj21 = obj20;
		((Vector3*)(nint)vector)->x = (float)obj21;
		uvs.Add(vector);
		object obj22 = obj2 + 144;
		obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj23 = obj2 + 128;
		obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj24 = obj2 + 16;
		obj24 = 0;
		obj24 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S0_v137+C]");
		_ = 0;
		object obj25 = obj2 + 48;
		obj25 = obj24;
		((Vector3*)(nint)vector)->x = (float)obj25;
		uvs.Add(vector);
		object obj26 = obj2 + 112;
		obj26 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj27 = obj2 + 96;
		obj27 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj28 = obj2 + 8;
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v152+8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ S0_v157+C]");
		_ = 0;
		object obj29 = obj2 + 40;
		obj29 = obj28;
		((Vector3*)(nint)vector)->x = (float)obj29;
		uvs.Add(vector);
		object obj30 = obj2 + 80;
		obj30 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		object obj31 = obj2 - -64;
		obj31 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S0_v172+8]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S0_v177+4]");
		_ = 0;
		object obj32 = obj2 + 24;
		obj32 = obj2;
		((Vector3*)(nint)vector)->x = (float)obj32;
		uvs.Add(vector);
		if (~(mApplyGradient ? 1u : 0u) == 0)
		{
			SetScreenRect((int)cols, (int)uIDrawCall, 0, 1);
			SetScreenRect((int)cols, (int)uIDrawCall, 0, 2);
			SetScreenRect((int)cols, (int)uIDrawCall, 0, 2);
			SetScreenRect((int)cols, (int)uIDrawCall, 0, 1);
			return;
		}
		((Vector3*)(nint)vector)->x = (float)uIDrawCall;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
		cols.Add((Color)vector);
		((Vector3*)(nint)vector)->x = (float)uIDrawCall;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
		cols.Add((Color)vector);
		((Vector3*)(nint)vector)->x = (float)uIDrawCall;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
		cols.Add((Color)vector);
		((Vector3*)(nint)vector)->x = (float)uIDrawCall;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
		cols.Add((Color)vector);
	}

	private unsafe void AddVertexColours(List<Color> cols, ref Color color, int x, int y)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_0069: Expected native int or pointer, but got VT
		//IL_0077: Expected native int or pointer, but got VT
		//IL_008f: Expected Obj, but got I4
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_011a: Expected VT, but got I4
		//IL_011a: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		object obj = default;
		Rect rect = (Rect)(obj + 16);
		((Rect*)(nint)rect)->m_XMin = 0f;
		((Rect*)(nint)rect)->m_Width = 0f;
		_ = 0;
		obj = ((int*)x)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [x @ L3 (System.Int32)+8]");
		_ = 0;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Color> list = (List<Color>)(obj + 40);
		list = (List<Color>)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Fill((List<Vector3>)(object)cols, (List<Vector2>)System.Runtime.CompilerServices.Unsafe.AsPointer(ref color), list, rect, (Rect)y);
	}

	private unsafe void TiledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a05: Expected Obj, but got Unknown
		//IL_0a0e: Expected Obj, but got I4
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected Obj, but got Unknown
		//IL_0a2b: Expected Obj, but got I4
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected Obj, but got Unknown
		//IL_0a50: Expected Obj, but got I4
		//IL_0a5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected Obj, but got Unknown
		//IL_0a86: Expected I, but got Obj
		//IL_0a9c: Expected Obj, but got I
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac7: Expected Obj, but got Unknown
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected Obj, but got Unknown
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae3: Expected Obj, but got Unknown
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected Obj, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aff: Expected Obj, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0d: Expected Obj, but got Unknown
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1b: Expected Obj, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected Obj, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b45: Expected VT, but got Unknown
		//IL_0b52: Expected F4, but got Obj
		//IL_0b4d: Expected native int or pointer, but got VT
		//IL_0b67: Expected F4, but got I
		//IL_0b62: Expected native int or pointer, but got VT
		//IL_0b70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b75: Expected Obj, but got Unknown
		//IL_0ba1: Expected F4, but got Obj
		//IL_0b9c: Expected native int or pointer, but got VT
		//IL_0bb6: Expected F4, but got I
		//IL_0bb1: Expected native int or pointer, but got VT
		//IL_014b: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0167: Expected Obj, but got F4
		//IL_017f: Expected I, but got Obj
		//IL_0195: Expected Obj, but got I
		//IL_005f: Expected F4, but got Obj
		//IL_005a: Expected native int or pointer, but got VT
		//IL_0074: Expected F4, but got I
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c00: Expected Obj, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Expected Obj, but got Unknown
		//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5d: Expected Obj, but got Unknown
		//IL_0c6d: Expected Obj, but got I
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Expected Obj, but got Unknown
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_01c0: Expected I, but got Obj
		//IL_00a6: Expected F4, but got Obj
		//IL_00a1: Expected native int or pointer, but got VT
		//IL_00bb: Expected F4, but got I
		//IL_00b6: Expected native int or pointer, but got VT
		//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2f: Expected Obj, but got Unknown
		//IL_0e3c: Expected F4, but got Obj
		//IL_0e37: Expected native int or pointer, but got VT
		//IL_0e51: Expected F4, but got I
		//IL_0e4c: Expected native int or pointer, but got VT
		//IL_0e5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected Obj, but got Unknown
		//IL_0e7c: Expected Obj, but got F4
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected Obj, but got Unknown
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaf: Expected Obj, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Expected Obj, but got Unknown
		//IL_0ed9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ede: Expected Obj, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef5: Expected Obj, but got Unknown
		//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f00: Expected Obj, but got Unknown
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected Obj, but got Unknown
		//IL_0f1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f22: Expected Obj, but got Unknown
		//IL_0f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Expected Obj, but got Unknown
		//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4e: Expected Obj, but got Unknown
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected Obj, but got Unknown
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Expected Obj, but got Unknown
		//IL_02fb: Expected I, but got Obj
		//IL_00ed: Expected F4, but got Obj
		//IL_00e8: Expected native int or pointer, but got VT
		//IL_0102: Expected F4, but got I
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_0113: Invalid comparison between I and F4
		//IL_03f5: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_1117: Unknown result type (might be due to invalid IL or missing references)
		//IL_111c: Expected Obj, but got Unknown
		//IL_1129: Expected F4, but got Obj
		//IL_1124: Expected native int or pointer, but got VT
		//IL_113e: Expected F4, but got I
		//IL_1139: Expected native int or pointer, but got VT
		//IL_1148: Unknown result type (might be due to invalid IL or missing references)
		//IL_114d: Expected Obj, but got Unknown
		//IL_116a: Expected Obj, but got I
		//IL_1179: Unknown result type (might be due to invalid IL or missing references)
		//IL_117e: Expected Obj, but got Unknown
		//IL_119d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a2: Expected Obj, but got Unknown
		//IL_11bf: Expected Obj, but got I
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d3: Expected Obj, but got Unknown
		//IL_11d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11de: Expected Obj, but got Unknown
		//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fa: Expected Obj, but got Unknown
		//IL_1200: Unknown result type (might be due to invalid IL or missing references)
		//IL_1205: Expected Obj, but got Unknown
		//IL_121c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1221: Expected Obj, but got Unknown
		//IL_1227: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected Obj, but got Unknown
		//IL_1249: Expected Obj, but got I
		//IL_1258: Unknown result type (might be due to invalid IL or missing references)
		//IL_125d: Expected Obj, but got Unknown
		//IL_1263: Unknown result type (might be due to invalid IL or missing references)
		//IL_1268: Expected I, but got Unknown
		//IL_1295: Expected Obj, but got I
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccc: Expected Obj, but got Unknown
		//IL_0cd9: Expected F4, but got Obj
		//IL_0cd4: Expected native int or pointer, but got VT
		//IL_0cee: Expected F4, but got I
		//IL_0ce9: Expected native int or pointer, but got VT
		//IL_0cf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfd: Expected Obj, but got Unknown
		//IL_0d19: Expected Obj, but got F4
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected Obj, but got Unknown
		//IL_0d47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected Obj, but got Unknown
		//IL_0d5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d61: Expected Obj, but got Unknown
		//IL_0d73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d78: Expected Obj, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d83: Expected Obj, but got Unknown
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9a: Expected Obj, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da5: Expected Obj, but got Unknown
		//IL_0db7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbc: Expected Obj, but got Unknown
		//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc7: Expected Obj, but got Unknown
		//IL_0dd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected Obj, but got Unknown
		//IL_0dee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df3: Expected Obj, but got Unknown
		//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfe: Expected Obj, but got Unknown
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected Obj, but got Unknown
		//IL_0436: Expected I, but got Obj
		//IL_026d: Expected I, but got Obj
		//IL_0367: Expected I, but got Obj
		//IL_037d: Expected Obj, but got I
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8a: Expected Obj, but got Unknown
		//IL_0f97: Expected F4, but got Obj
		//IL_0f92: Expected native int or pointer, but got VT
		//IL_0fac: Expected F4, but got I
		//IL_0fa7: Expected native int or pointer, but got VT
		//IL_0fb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbb: Expected Obj, but got Unknown
		//IL_0fe6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0feb: Expected Obj, but got Unknown
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Expected Obj, but got Unknown
		//IL_102c: Expected Obj, but got I
		//IL_103b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected Obj, but got Unknown
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected Obj, but got Unknown
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Expected Obj, but got Unknown
		//IL_106d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1072: Expected Obj, but got Unknown
		//IL_1089: Unknown result type (might be due to invalid IL or missing references)
		//IL_108e: Expected Obj, but got Unknown
		//IL_1094: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Expected Obj, but got Unknown
		//IL_10b6: Expected Obj, but got I
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ca: Expected Obj, but got Unknown
		//IL_10d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d5: Expected I, but got Unknown
		//IL_1102: Expected Obj, but got I
		//IL_03a8: Expected I, but got Obj
		//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected Obj, but got Unknown
		//IL_04cd: Expected Obj, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_0510: Expected I, but got Obj
		//IL_0526: Expected Obj, but got I
		//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ca: Expected Obj, but got Unknown
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Expected Obj, but got Unknown
		//IL_130a: Unknown result type (might be due to invalid IL or missing references)
		//IL_130f: Expected Obj, but got Unknown
		//IL_1318: Expected Obj, but got I4
		//IL_1346: Expected F4, but got Obj
		//IL_1341: Expected native int or pointer, but got VT
		//IL_135b: Expected F4, but got I
		//IL_1356: Expected native int or pointer, but got VT
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_1377: Expected Obj, but got Unknown
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Expected Obj, but got Unknown
		//IL_13c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ca: Expected Obj, but got Unknown
		//IL_13d3: Expected Obj, but got I4
		//IL_1401: Expected F4, but got Obj
		//IL_13fc: Expected native int or pointer, but got VT
		//IL_1416: Expected F4, but got I
		//IL_1411: Expected native int or pointer, but got VT
		//IL_142d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1432: Expected Obj, but got Unknown
		//IL_1457: Unknown result type (might be due to invalid IL or missing references)
		//IL_145c: Expected Obj, but got Unknown
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Expected Obj, but got Unknown
		//IL_1480: Expected Obj, but got I4
		//IL_14ae: Expected F4, but got Obj
		//IL_14a9: Expected native int or pointer, but got VT
		//IL_14c3: Expected F4, but got I
		//IL_14be: Expected native int or pointer, but got VT
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected Obj, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected Obj, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected Obj, but got Unknown
		//IL_05ed: Expected Obj, but got I4
		//IL_061b: Expected F4, but got Obj
		//IL_0616: Expected native int or pointer, but got VT
		//IL_0630: Expected F4, but got I
		//IL_062b: Expected native int or pointer, but got VT
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected Obj, but got Unknown
		//IL_069a: Expected Obj, but got I4
		//IL_06c4: Expected F4, but got Obj
		//IL_06bf: Expected native int or pointer, but got VT
		//IL_0551: Expected I, but got Obj
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected Obj, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected Obj, but got Unknown
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected Obj, but got Unknown
		//IL_0733: Expected Obj, but got I4
		//IL_075d: Expected F4, but got Obj
		//IL_0758: Expected native int or pointer, but got VT
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected Obj, but got Unknown
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		//IL_07c7: Expected Obj, but got I4
		//IL_07f1: Expected F4, but got Obj
		//IL_07ec: Expected native int or pointer, but got VT
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected Obj, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected Obj, but got Unknown
		//IL_0860: Expected Obj, but got I4
		//IL_088a: Expected F4, but got Obj
		//IL_0885: Expected native int or pointer, but got VT
		//IL_0933: Expected F4, but got Obj
		//IL_092e: Expected native int or pointer, but got VT
		//IL_0945: Expected F4, but got I
		//IL_0940: Expected native int or pointer, but got VT
		//IL_095f: Expected F4, but got Obj
		//IL_095a: Expected native int or pointer, but got VT
		//IL_0971: Expected F4, but got I
		//IL_096c: Expected native int or pointer, but got VT
		//IL_0990: Expected F4, but got Obj
		//IL_098b: Expected native int or pointer, but got VT
		//IL_09a2: Expected F4, but got I
		//IL_099d: Expected native int or pointer, but got VT
		//IL_09bc: Expected F4, but got Obj
		//IL_09b7: Expected native int or pointer, but got VT
		//IL_09ce: Expected F4, but got I
		//IL_09c9: Expected native int or pointer, but got VT
		//IL_08c7: Expected I4, but got Obj
		//IL_08c7: Expected I4, but got Obj
		//IL_08de: Expected I4, but got Obj
		//IL_08de: Expected I4, but got Obj
		//IL_08fa: Expected I4, but got Obj
		//IL_08fa: Expected I4, but got Obj
		//IL_0911: Expected I4, but got Obj
		//IL_0911: Expected I4, but got Obj
		//IL_0920: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 160;
		obj = 0;
		_ = 0;
		UIDrawCall uIDrawCall = (UIDrawCall)(obj2 + 144);
		uIDrawCall = (UIDrawCall)0;
		((UnityEngine.Object)uIDrawCall).m_CachedPtr = (IntPtr)0;
		object obj3 = obj2 + 128;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v524 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 80;
		object obj7 = obj2 - -64;
		object obj8 = obj2 + 24;
		object obj9 = obj2 + 56;
		object obj10 = obj2 + 16;
		object obj11 = obj2 + 48;
		object obj12 = obj2 + 8;
		object obj13 = obj2 + 40;
		object obj14 = obj2 + 32;
		Vector3 vector = (Vector3)(obj2 + 176);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj15 = obj2 + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
		obj = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj15;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		if (vector.x == 0f)
		{
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			if (vector.y == 0f)
			{
				((Vector3*)(nint)vector)->x = (float)obj;
				Vector3 vector5 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				if (vector.z == 0f)
				{
					((Vector3*)(nint)vector)->x = (float)obj;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v45 (UnityEngine.Vector3)+C]");
					if (0f == 0f)
					{
						SlicedFill(verts, uvs, cols);
						return;
					}
				}
			}
		}
		uIDrawCall.renderQueue = (int)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj3 = vector.x;
		_ = vector.z;
		nint num3 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v64 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num4 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v502 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj17 = mTempPos + 16;
		obj17 = obj4;
		obj15 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj18 = mTempPos + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+4]");
		_ = 0;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj19 = mTempPos + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27+8]");
		obj19 = 0;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
		_ = 0;
		object obj20 = mTempPos + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29+C]");
		_ = 0;
		if (mFlip != Flip.Horizontally && mFlip != Flip.Both)
		{
			nint num5 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v463 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num6 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v496 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj22 = mTempPos + 16;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector7 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector7)->z = 0f;
			object obj23 = mTempPos + 24;
			float num7 = (float)obj22 + vector.x;
			obj23 = num7;
			object obj24 = mTempPos + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj25 = mTempPos + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
			object obj26 = obj24 - 0;
			obj25 = obj26;
			object obj27 = mTempUVs + 16;
			object obj28 = this + 360;
			obj27 = obj28;
			object obj29 = mTempUVs + 24;
			object obj30 = this + 344;
			obj29 = obj30;
			object obj31 = mTempUVs + 32;
			object obj32 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S1_v391+8]");
			object obj33 = 0 + obj32;
			obj31 = obj33;
			object obj34 = mTempUVs + 40;
			object obj35 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ S1_v396+8]");
			object obj36 = 0 + obj35;
			obj34 = obj36;
		}
		else
		{
			nint num8 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v420 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num9 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S0_v453 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj38 = mTempPos + 16;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector8 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector8)->z = 0f;
			object obj39 = mTempPos + 24;
			float num10 = (float)obj38 + vector.z;
			obj39 = num10;
			object obj40 = mTempPos + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj41 = mTempPos + 32;
			object obj42 = obj40 - obj4;
			obj41 = obj42;
			object obj43 = mTempUVs + 40;
			object obj44 = this + 360;
			obj43 = obj44;
			object obj45 = mTempUVs + 32;
			object obj46 = this + 344;
			obj45 = obj46;
			object obj47 = mTempUVs + 24;
			object obj48 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v349+8]");
			object obj49 = 0 + obj48;
			obj47 = obj49;
			object obj50 = mTempUVs + 16;
			object obj51 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S1_v354+8]");
			object obj52 = 0 + obj51;
			obj50 = obj52;
		}
		if (mFlip != Flip.Vertically && mFlip != Flip.Both)
		{
			nint num11 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S0_v379 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj53 = (nint)0 & (nint)0x200;
			if (obj53 != null)
			{
				nint num12 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ S0_v412 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj54 = mTempPos + 16;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector9 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector9)->z = 0f;
			object obj55 = mTempPos + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ S1_v279+4]");
			float num13 = 0f + vector.y;
			object obj56 = mTempPos + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj57 = mTempPos + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v705 @ S1_v290+4]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+C]");
			object obj58 = num14 - 0;
			object obj59 = mTempUVs + 16;
			object obj60 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ S1_v299+4]");
			_ = 0;
			object obj61 = mTempUVs + 24;
			object obj62 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S1_v303+4]");
			_ = 0;
			object obj63 = mTempUVs + 32;
			object obj64 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ S1_v307+C]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ S1_v307+4]");
			object obj65 = num15 + 0;
			object obj66 = mTempUVs + 40;
			nint num16 = (nint)(this + 360);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S1_v312 (Il2CppMethodInfo)+4]");
			bool flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S1_v312 (Il2CppMethodInfo)+C]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v762 @ S1_v312 (Il2CppMethodInfo)+4]");
			object obj67 = num17 + 0;
		}
		else
		{
			nint num18 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ S0_v336 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj68 = (nint)0 & (nint)0x200;
			if (obj68 != null)
			{
				nint num19 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S0_v369 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj69 = mTempPos + 16;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector10 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector10)->z = 0f;
			object obj70 = mTempPos + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S1_v237+4]");
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v45 (UnityEngine.Vector3)+C]");
			object obj71 = num20 + 0;
			object obj72 = mTempPos + 40;
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj73 = mTempPos + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S1_v248+4]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
			object obj74 = num21 - 0;
			object obj75 = mTempUVs + 40;
			object obj76 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ S1_v257+4]");
			_ = 0;
			object obj77 = mTempUVs + 32;
			object obj78 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S1_v261+4]");
			_ = 0;
			object obj79 = mTempUVs + 24;
			object obj80 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S1_v265+C]");
			nint num22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S1_v265+4]");
			object obj81 = num22 + 0;
			object obj82 = mTempUVs + 16;
			nint num23 = (nint)(this + 360);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S1_v270 (Il2CppMethodInfo)+4]");
			bool flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S1_v270 (Il2CppMethodInfo)+C]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ S1_v270 (Il2CppMethodInfo)+4]");
			object obj83 = num24 + 0;
		}
		object obj84 = default;
		object obj129 = default;
		while ((nint)obj84 <= 2)
		{
			object obj85 = obj84 + 1;
			bool flag2 = (nint)obj84 == 1;
			int num25 = 0;
			while (num25 <= 2)
			{
				bool flag3 = num25 == 1;
				bool flag = centerType == AdvancedType.Invisible;
				object obj86 = flag2 & flag;
				object obj87 = flag3 & obj86;
				if (obj87 == null)
				{
					nint num26 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v115 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj88 = (nint)0 & (nint)0x200;
					if (obj88 != null)
					{
						nint num27 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ S0_v328 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj89 = mTempPos + 16;
					object obj90 = obj84 << 3;
					object obj91 = obj89 + obj90;
					object obj92 = mTempPos + 16;
					int num28 = num25 << 3;
					object obj93 = obj92 + num28;
					obj4 = 0;
					_ = 0;
					obj4 = obj91;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ S0_v130+4]");
					_ = 0;
					_ = 0f;
					((Vector3*)(nint)vector)->x = (float)obj4;
					Vector3 vector11 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
					((Vector3*)(nint)vector11)->z = 0f;
					verts.Add(vector);
					object obj94 = mTempPos + 16;
					object obj95 = obj84 << 3;
					object obj96 = obj94 + obj95;
					object obj97 = mTempPos + 16;
					int num29 = num25 + 1;
					int num30 = num29 << 3;
					object obj98 = obj97 + num30;
					obj15 = 0;
					_ = 0;
					obj15 = obj96;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ S0_v154+4]");
					_ = 0;
					_ = 0f;
					((Vector3*)(nint)vector)->x = (float)obj15;
					Vector3 vector12 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+8]");
					((Vector3*)(nint)vector12)->z = 0f;
					verts.Add(vector);
					object obj99 = mTempPos + 16;
					object obj100 = obj85 << 3;
					object obj101 = obj99 + obj100;
					object obj102 = mTempPos + 16;
					int num31 = num29 << 3;
					object obj103 = obj102 + num31;
					obj6 = 0;
					_ = 0;
					obj6 = obj101;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v979 @ S0_v178+4]");
					_ = 0;
					_ = 0f;
					((Vector3*)(nint)vector)->x = (float)obj6;
					Vector3 vector13 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v27+8]");
					((Vector3*)(nint)vector13)->z = 0f;
					verts.Add(vector);
					object obj104 = mTempPos + 16;
					object obj105 = obj85 << 3;
					object obj106 = obj104 + obj105;
					object obj107 = mTempPos + 16;
					int num32 = num25 << 3;
					object obj108 = obj107 + num32;
					obj7 = 0;
					_ = 0;
					obj7 = obj106;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S0_v202+4]");
					_ = 0;
					_ = 0f;
					((Vector3*)(nint)vector)->x = (float)obj7;
					Vector3 vector14 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v29+8]");
					((Vector3*)(nint)vector14)->z = 0f;
					verts.Add(vector);
					object obj109 = mTempUVs + 16;
					object obj110 = obj84 << 3;
					object obj111 = obj109 + obj110;
					object obj112 = mTempUVs + 16;
					int num33 = num25 << 3;
					object obj113 = obj112 + num33;
					obj8 = 0;
					obj8 = obj111;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ S0_v226+4]");
					_ = 0;
					obj9 = obj8;
					((Vector3*)(nint)vector)->x = (float)obj9;
					uvs.Add(vector);
					object obj114 = mTempUVs + 16;
					object obj115 = obj84 << 3;
					object obj116 = obj114 + obj115;
					object obj117 = mTempUVs + 16;
					int num34 = num29 << 3;
					object obj118 = obj117 + num34;
					obj10 = 0;
					obj10 = obj116;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1113 @ S0_v248+4]");
					_ = 0;
					obj11 = obj10;
					((Vector3*)(nint)vector)->x = (float)obj11;
					uvs.Add(vector);
					object obj119 = mTempUVs + 16;
					object obj120 = obj85 << 3;
					object obj121 = obj119 + obj120;
					object obj122 = mTempUVs + 16;
					int num35 = num29 << 3;
					object obj123 = obj122 + num35;
					obj12 = 0;
					obj12 = obj121;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ S0_v270+4]");
					_ = 0;
					obj13 = obj12;
					((Vector3*)(nint)vector)->x = (float)obj13;
					uvs.Add(vector);
					object obj124 = mTempUVs + 16;
					object obj125 = obj85 << 3;
					object obj126 = obj124 + obj125;
					object obj127 = mTempUVs + 16;
					int num36 = num25 << 3;
					object obj128 = obj127 + num36;
					obj2 = 0;
					obj2 = obj126;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ S0_v292+4]");
					_ = 0;
					obj14 = obj2;
					((Vector3*)(nint)vector)->x = (float)obj14;
					uvs.Add(vector);
					if (~(mApplyGradient ? 1u : 0u) == 0)
					{
						SetScreenRect((int)cols, (int)uIDrawCall, 0, num25);
						SetScreenRect((int)cols, (int)uIDrawCall, 0, num29);
						SetScreenRect((int)cols, (int)uIDrawCall, 0, num29);
						SetScreenRect((int)cols, (int)uIDrawCall, 0, num25);
						flag = (byte)(int)uIDrawCall != 0;
					}
					else
					{
						((Vector3*)(nint)vector)->x = (float)uIDrawCall;
						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
						cols.Add((Color)vector);
						((Vector3*)(nint)vector)->x = (float)uIDrawCall;
						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
						cols.Add((Color)vector);
						((Vector3*)(nint)vector)->x = (float)uIDrawCall;
						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
						cols.Add((Color)vector);
						((Vector3*)(nint)vector)->x = (float)uIDrawCall;
						((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AF9");
						flag = false;
					}
				}
				int num37 = num25 + 1;
				num25 = num37;
			}
			obj84 = obj129 + 1;
		}
	}

	private unsafe void FilledFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected Obj, but got Unknown
		//IL_0ae3: Expected Obj, but got I4
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected Obj, but got Unknown
		//IL_0afa: Expected Obj, but got I4
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Expected Obj, but got Unknown
		//IL_0b1f: Expected Obj, but got I4
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b33: Expected Obj, but got Unknown
		//IL_0b3c: Expected Obj, but got I4
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected Obj, but got Unknown
		//IL_0b59: Expected Obj, but got I4
		//IL_0b77: Expected I, but got Obj
		//IL_0b8d: Expected Obj, but got I
		//IL_0bb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Expected VT, but got Unknown
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected Obj, but got Unknown
		//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd4: Expected Obj, but got Unknown
		//IL_0bdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected Obj, but got Unknown
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected Obj, but got Unknown
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected Obj, but got Unknown
		//IL_0c07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0c: Expected Obj, but got Unknown
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got Unknown
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected Obj, but got Unknown
		//IL_0c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c36: Expected Obj, but got Unknown
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0c4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c52: Expected Obj, but got Unknown
		//IL_0c5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c60: Expected Obj, but got Unknown
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00c5: Expected F4, but got Obj
		//IL_00c0: Expected native int or pointer, but got VT
		//IL_010a: Expected F4, but got Obj
		//IL_0105: Expected native int or pointer, but got VT
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_0cb5: Expected F4, but got Obj
		//IL_0cb0: Expected native int or pointer, but got VT
		//IL_0cd8: Expected I4, but got Obj
		//IL_01e7: Expected Obj, but got F4
		//IL_019b: Expected I, but got Obj
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_046b: Expected Obj, but got I
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected Obj, but got Unknown
		//IL_029f: Expected Obj, but got F4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0d13: Expected F4, but got Obj
		//IL_0d0e: Expected native int or pointer, but got VT
		//IL_0d6f: Expected F4, but got I
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected Obj, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03d4: Expected Obj, but got I
		//IL_0fc0: Expected F4, but got Obj
		//IL_0fbb: Expected native int or pointer, but got VT
		//IL_0fdd: Invalid comparison between F4 and I
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0500: Expected F4, but got Obj
		//IL_04fb: Expected native int or pointer, but got VT
		//IL_058f: Invalid comparison between F4 and I
		//IL_05b0: Expected F4, but got Obj
		//IL_05c0: Expected F4, but got I
		//IL_0f77: Expected F4, but got Obj
		//IL_0f72: Expected native int or pointer, but got VT
		//IL_0f94: Invalid comparison between F4 and I
		//IL_0a7f: Expected F4, but got Obj
		//IL_0a7a: Expected native int or pointer, but got VT
		//IL_05db: Expected F4, but got Obj
		//IL_05d6: Expected native int or pointer, but got VT
		//IL_0628: Expected I, but got Obj
		//IL_063e: Expected Obj, but got I
		//IL_06b5: Expected F4, but got Obj
		//IL_06b0: Expected native int or pointer, but got VT
		//IL_0727: Invalid comparison between F4 and I
		//IL_0750: Expected F4, but got I
		//IL_0dc0: Expected F4, but got I
		//IL_0df8: Expected F4, but got I
		//IL_0e01: Expected F4, but got Obj
		//IL_0e17: Expected Obj, but got I4
		//IL_0e25: Expected Obj, but got F4
		//IL_0e3d: Expected F4, but got Obj
		//IL_0e38: Expected native int or pointer, but got VT
		//IL_0e60: Expected Obj, but got I4
		//IL_0e6e: Expected Obj, but got F4
		//IL_0e86: Expected F4, but got Obj
		//IL_0e81: Expected native int or pointer, but got VT
		//IL_0ea9: Expected Obj, but got I4
		//IL_0eb7: Expected Obj, but got F4
		//IL_0ecf: Expected F4, but got Obj
		//IL_0eca: Expected native int or pointer, but got VT
		//IL_0669: Expected I, but got Obj
		//IL_0841: Expected Obj, but got I4
		//IL_084f: Expected Obj, but got F4
		//IL_0867: Expected F4, but got Obj
		//IL_0862: Expected native int or pointer, but got VT
		//IL_088a: Expected Obj, but got I4
		//IL_08b4: Expected F4, but got Obj
		//IL_08af: Expected native int or pointer, but got VT
		//IL_076b: Expected F4, but got Obj
		//IL_0766: Expected native int or pointer, but got VT
		//IL_07b8: Expected I, but got Obj
		//IL_07ce: Expected Obj, but got I
		//IL_08cf: Expected Obj, but got I4
		//IL_08f1: Expected F4, but got Obj
		//IL_08ec: Expected native int or pointer, but got VT
		//IL_0907: Expected Obj, but got I4
		//IL_090f: Expected Obj, but got F4
		//IL_0929: Expected F4, but got Obj
		//IL_0924: Expected native int or pointer, but got VT
		//IL_0f32: Expected F4, but got I
		//IL_0f5b: Expected F4, but got I
		//IL_0944: Expected Obj, but got I4
		//IL_094c: Expected Obj, but got F4
		//IL_096e: Expected F4, but got Obj
		//IL_0969: Expected native int or pointer, but got VT
		//IL_0988: Expected F4, but got Obj
		//IL_0983: Expected native int or pointer, but got VT
		//IL_07f9: Expected I, but got Obj
		//IL_09b1: Expected F4, but got Obj
		//IL_09ac: Expected native int or pointer, but got VT
		//IL_09d5: Expected F4, but got Obj
		//IL_09d0: Expected native int or pointer, but got VT
		//IL_09fe: Expected F4, but got Obj
		//IL_09f9: Expected native int or pointer, but got VT
		//IL_0a1f: Expected F4, but got Obj
		//IL_0a1a: Expected native int or pointer, but got VT
		//IL_0a65: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 104;
		obj = 0;
		UIDrawCall uIDrawCall = (UIDrawCall)(obj2 + 224);
		uIDrawCall = (UIDrawCall)0;
		((UnityEngine.Object)uIDrawCall).m_CachedPtr = (IntPtr)0;
		object obj3 = obj2 + 208;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 192;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 176;
		obj5 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v330 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj2 + 128);
		object obj7 = obj2 - -64;
		object obj8 = obj2 + 120;
		object obj9 = obj2 + 48;
		object obj10 = obj2 + 32;
		object obj11 = obj2 + 160;
		object obj12 = obj2 + 24;
		object obj13 = obj2 + 112;
		object obj14 = obj2 + 16;
		object obj15 = obj2 + 96;
		object obj16 = obj2 + 8;
		object obj17 = obj2 + 88;
		object obj18 = obj2 + 80;
		object obj19 = obj2 + 144;
		UnityEngine.Object obj20 = default;
		if (obj20 != null)
		{
			return;
		}
		object obj21 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v63+8]");
		object obj23 = default;
		object obj22 = 0 * obj23;
		object obj24 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v67+C]");
		object obj26 = default;
		object obj25 = 0 * obj26;
		obj = obj22;
		((Vector2*)(nint)vector)->x = (float)obj;
		if (vector.x < 2f)
		{
			return;
		}
		((Vector2*)(nint)vector)->x = (float)obj;
		if (vector.y < 2f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num3 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v87 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num4 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v326 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj8 = obj;
		((Vector2*)(nint)vector)->x = (float)obj8;
		float num5 = default;
		Vector2 vector2 = vector / num5;
		obj = obj7;
		uIDrawCall.renderQueue = (int)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj3 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30 (UnityEngine.Vector2)+8]");
		_ = 0;
		if (mFlip != Flip.Horizontally && mFlip != Flip.Both)
		{
			object obj28 = this + 344;
			obj4 = obj28;
			object obj29 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S1_v327+8]");
			object obj30 = 0 + obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			object obj31 = default;
			float num6 = vector.x * (float)obj31;
			obj5 = num6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+8]");
			object obj33 = default;
			object obj32 = 0 * obj33;
		}
		else
		{
			object obj34 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v308+8]");
			object obj35 = 0 + obj34;
			obj4 = obj35;
			object obj36 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30 (UnityEngine.Vector2)+8]");
			object obj38 = default;
			object obj37 = 0 * obj38;
			obj5 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			object obj40 = default;
			object obj39 = obj7 * obj40;
		}
		if (mFlip != Flip.Vertically && mFlip != Flip.Both)
		{
			object obj41 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ S1_v292+4]");
			_ = 0;
			object obj42 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S1_v295+C]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S1_v295+4]");
			object obj43 = num7 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			object obj44 = default;
			float num8 = vector.y * (float)obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+C]");
			object obj46 = default;
			object obj45 = 0 * obj46;
		}
		else
		{
			object obj47 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S1_v276+C]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S1_v276+4]");
			object obj48 = num9 + 0;
			object obj49 = this + 344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ S1_v280+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30 (UnityEngine.Vector2)+C]");
			object obj51 = default;
			object obj50 = 0 * obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+4]");
			object obj53 = default;
			object obj52 = 0 * obj53;
		}
		((Vector2*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
		_ = 0;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
		_ = 0;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
		_ = 0;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+4]");
		float num10 = 0f;
		while (true)
		{
			((Vector2*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
			_ = 0;
			float num11 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30 (UnityEngine.Vector2)+C]");
			if (!(num11 < 0f))
			{
				break;
			}
			((Vector2*)(nint)vector)->x = (float)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
			_ = 0;
			float num12 = num10 + vector.y;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
			_ = 0;
			obj9 = obj;
			float num13 = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36+4]");
			float num14 = num13 + 0f;
			obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
			_ = 0;
			obj11 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40+C]");
			bool flag = num14 > 0f;
			bool flag2 = !flag;
			float num15 = num14;
			float num16 = (float)obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38+C]");
			float num17 = 0f;
			if (!flag2)
			{
				((Vector2*)(nint)vector)->x = (float)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
				_ = 0;
				obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
				_ = 0;
				obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
				_ = 0;
				obj10 = obj;
				nint num18 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S3_v35 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj54 = (nint)0 & (nint)0x200;
				if (obj54 != null)
				{
					nint num19 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ S3_v42 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36+C]");
				float num20 = 0f - num12;
				float num21 = num20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38+4]");
				float t = num21 / 0f;
				float y = vector.y;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+C]");
				float num22 = Mathf.LerpUnclamped(y, 0f, t);
				obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
				_ = 0;
				UIBasicSprite typeFromHandle = (UIBasicSprite)(object)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40+C]");
				num15 = 0f;
				num16 = (float)obj7;
				num17 = num22;
			}
			while (true)
			{
				((Vector2*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
				_ = 0;
				float num23 = num16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v30 (UnityEngine.Vector2)+8]");
				if (!(num23 < 0f))
				{
					break;
				}
				((Vector2*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
				_ = 0;
				float num24 = num16 + vector.x;
				obj7 = obj;
				float num25 = num24 + (float)obj7;
				obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
				_ = 0;
				obj10 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38+8]");
				bool flag3 = num25 > 0f;
				bool flag4 = !flag3;
				float num26 = num25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36+8]");
				float num27 = 0f;
				if (!flag4)
				{
					((Vector2*)(nint)vector)->x = (float)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
					_ = 0;
					obj7 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v17+8]");
					_ = 0;
					obj9 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
					_ = 0;
					obj10 = obj;
					nint num28 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ S3_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj55 = (nint)0 & (nint)0x200;
					if (obj55 != null)
					{
						nint num29 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ S3_v23 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36+8]");
					float num30 = 0f - num24;
					float t2 = num30 / (float)obj10;
					float x = vector.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+8]");
					float num31 = Mathf.LerpUnclamped(x, 0f, t2);
					obj11 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40+8]");
					num26 = 0f;
					num27 = num31;
				}
				obj7 = 0;
				_ = 0;
				obj7 = num24;
				_ = 0f;
				((Vector2*)(nint)vector)->x = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+8]");
				_ = 0;
				verts.Add(vector);
				obj9 = 0;
				_ = 0;
				obj9 = num24;
				_ = 0f;
				((Vector2*)(nint)vector)->x = (float)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v36+8]");
				_ = 0;
				verts.Add(vector);
				obj10 = 0;
				_ = 0;
				obj10 = num26;
				_ = 0f;
				((Vector2*)(nint)vector)->x = (float)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38+8]");
				_ = 0;
				verts.Add(vector);
				obj11 = 0;
				_ = 0;
				obj11 = num26;
				_ = 0f;
				((Vector2*)(nint)vector)->x = (float)obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v40+8]");
				_ = 0;
				verts.Add(vector);
				obj12 = 0;
				obj12 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38+4]");
				_ = 0;
				obj13 = obj12;
				((Vector2*)(nint)vector)->x = (float)obj13;
				uvs.Add(vector);
				obj14 = 0;
				obj14 = obj9;
				obj15 = obj14;
				((Vector2*)(nint)vector)->x = (float)obj15;
				uvs.Add(vector);
				obj16 = 0;
				obj16 = num27;
				obj17 = obj16;
				((Vector2*)(nint)vector)->x = (float)obj17;
				uvs.Add(vector);
				obj2 = 0;
				obj2 = num27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38+4]");
				_ = 0;
				obj18 = obj2;
				((Vector2*)(nint)vector)->x = (float)obj18;
				uvs.Add(vector);
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				cols.Add((Color)vector);
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				cols.Add((Color)vector);
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				cols.Add((Color)vector);
				((Vector2*)(nint)vector)->x = (float)uIDrawCall;
				_ = ((UnityEngine.Object)uIDrawCall).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9AF9");
				((Vector2*)(nint)vector)->x = (float)obj;
				obj19 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
				_ = 0;
				float num32 = vector.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v56+8]");
				float num33 = num32 + 0f;
				float num34 = num24 + num33;
				UIBasicSprite typeFromHandle = (UIBasicSprite)0;
				num16 = num34;
			}
			((Vector2*)(nint)vector)->x = (float)obj;
			obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20+8]");
			_ = 0;
			float num35 = vector.y;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v32+C]");
			float num36 = num35 + 0f;
			float num37 = num12 + num36;
			num10 = num37;
		}
	}

	private unsafe void FilledSlicedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_1458: Unknown result type (might be due to invalid IL or missing references)
		//IL_145d: Expected VT, but got Unknown
		//IL_1466: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Expected Obj, but got Unknown
		//IL_1474: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Expected Obj, but got Unknown
		//IL_1482: Unknown result type (might be due to invalid IL or missing references)
		//IL_1487: Expected Obj, but got Unknown
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_1495: Expected Obj, but got Unknown
		//IL_149e: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a3: Expected Obj, but got Unknown
		//IL_14ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b1: Expected Obj, but got Unknown
		//IL_14ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bf: Expected Obj, but got Unknown
		//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cd: Expected Obj, but got Unknown
		//IL_14d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14db: Expected Obj, but got Unknown
		//IL_14e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e9: Expected Obj, but got Unknown
		//IL_14f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f7: Expected Obj, but got Unknown
		//IL_1500: Unknown result type (might be due to invalid IL or missing references)
		//IL_1505: Expected Obj, but got Unknown
		//IL_150e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1513: Expected Obj, but got Unknown
		//IL_151c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1521: Expected Obj, but got Unknown
		//IL_152a: Unknown result type (might be due to invalid IL or missing references)
		//IL_152f: Expected Obj, but got Unknown
		//IL_1538: Unknown result type (might be due to invalid IL or missing references)
		//IL_153d: Expected Obj, but got Unknown
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_154b: Expected Obj, but got Unknown
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_1559: Expected Obj, but got Unknown
		//IL_1562: Unknown result type (might be due to invalid IL or missing references)
		//IL_1567: Expected Obj, but got Unknown
		//IL_1570: Unknown result type (might be due to invalid IL or missing references)
		//IL_1575: Expected Obj, but got Unknown
		//IL_157e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1583: Expected Obj, but got Unknown
		//IL_158c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1591: Expected Obj, but got Unknown
		//IL_159a: Unknown result type (might be due to invalid IL or missing references)
		//IL_159f: Expected Obj, but got Unknown
		//IL_15a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ad: Expected Obj, but got Unknown
		//IL_15b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bb: Expected Obj, but got Unknown
		//IL_15c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c9: Expected Obj, but got Unknown
		//IL_15d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7: Expected Obj, but got Unknown
		//IL_15e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e5: Expected Obj, but got Unknown
		//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f3: Expected Obj, but got Unknown
		//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1601: Expected Obj, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected Obj, but got Unknown
		//IL_1618: Unknown result type (might be due to invalid IL or missing references)
		//IL_161d: Expected Obj, but got Unknown
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_162b: Expected Obj, but got Unknown
		//IL_1634: Unknown result type (might be due to invalid IL or missing references)
		//IL_1639: Expected Obj, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_1647: Expected Obj, but got Unknown
		//IL_1650: Unknown result type (might be due to invalid IL or missing references)
		//IL_1655: Expected Obj, but got Unknown
		//IL_165e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1663: Expected Obj, but got Unknown
		//IL_166c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1671: Expected Obj, but got Unknown
		//IL_167a: Unknown result type (might be due to invalid IL or missing references)
		//IL_167f: Expected Obj, but got Unknown
		//IL_1688: Unknown result type (might be due to invalid IL or missing references)
		//IL_168d: Expected Obj, but got Unknown
		//IL_1696: Expected Obj, but got I4
		//IL_16a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16aa: Expected Obj, but got Unknown
		//IL_16b3: Expected Obj, but got I4
		//IL_16c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected Obj, but got Unknown
		//IL_16d0: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got F4
		//IL_0054: Expected I4, but got Obj
		//IL_1721: Expected I, but got Obj
		//IL_1737: Expected Obj, but got I
		//IL_00ce: Expected F4, but got Obj
		//IL_00c9: Expected native int or pointer, but got VT
		//IL_00e3: Expected F4, but got I
		//IL_00de: Expected native int or pointer, but got VT
		//IL_2298: Expected Obj, but got I4
		//IL_22c2: Expected F4, but got Obj
		//IL_22bd: Expected native int or pointer, but got VT
		//IL_22cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_22d1: Expected Obj, but got Unknown
		//IL_22de: Expected Obj, but got F4
		//IL_2311: Expected Obj, but got I4
		//IL_233b: Expected F4, but got Obj
		//IL_2336: Expected native int or pointer, but got VT
		//IL_2345: Unknown result type (might be due to invalid IL or missing references)
		//IL_234a: Expected Obj, but got Unknown
		//IL_2357: Expected Obj, but got F4
		//IL_238a: Expected Obj, but got I4
		//IL_239a: Expected Obj, but got I
		//IL_23bc: Expected F4, but got Obj
		//IL_23b7: Expected native int or pointer, but got VT
		//IL_23c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_23cb: Expected Obj, but got Unknown
		//IL_23d8: Expected Obj, but got F4
		//IL_240b: Expected Obj, but got I4
		//IL_241b: Expected Obj, but got I
		//IL_243d: Expected F4, but got Obj
		//IL_2438: Expected native int or pointer, but got VT
		//IL_2447: Unknown result type (might be due to invalid IL or missing references)
		//IL_244c: Expected Obj, but got Unknown
		//IL_2459: Expected Obj, but got F4
		//IL_248c: Expected Obj, but got I4
		//IL_24b6: Expected F4, but got Obj
		//IL_24b1: Expected native int or pointer, but got VT
		//IL_24c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c5: Expected Obj, but got Unknown
		//IL_24d2: Expected Obj, but got F4
		//IL_2505: Expected Obj, but got I4
		//IL_252f: Expected F4, but got Obj
		//IL_252a: Expected native int or pointer, but got VT
		//IL_2539: Unknown result type (might be due to invalid IL or missing references)
		//IL_253e: Expected Obj, but got Unknown
		//IL_254b: Expected Obj, but got F4
		//IL_257e: Expected Obj, but got I4
		//IL_258e: Expected Obj, but got I
		//IL_25b0: Expected F4, but got Obj
		//IL_25ab: Expected native int or pointer, but got VT
		//IL_25ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_25bf: Expected Obj, but got Unknown
		//IL_25cc: Expected Obj, but got F4
		//IL_25ff: Expected Obj, but got I4
		//IL_260f: Expected Obj, but got I
		//IL_2631: Expected F4, but got Obj
		//IL_262c: Expected native int or pointer, but got VT
		//IL_263b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2640: Expected Obj, but got Unknown
		//IL_264d: Expected Obj, but got F4
		//IL_02ed: Expected F4, but got Obj
		//IL_02e8: Expected native int or pointer, but got VT
		//IL_0302: Expected F4, but got I
		//IL_02fd: Expected native int or pointer, but got VT
		//IL_020a: Expected F4, but got Obj
		//IL_0205: Expected native int or pointer, but got VT
		//IL_021f: Expected F4, but got I
		//IL_021a: Expected native int or pointer, but got VT
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_1c6b: Expected Obj, but got I4
		//IL_04fd: Expected I, but got Obj
		//IL_0433: Expected F4, but got Obj
		//IL_042e: Expected native int or pointer, but got VT
		//IL_0448: Expected F4, but got I
		//IL_0443: Expected native int or pointer, but got VT
		//IL_048f: Expected Obj, but got I
		//IL_0143: Expected F4, but got Obj
		//IL_013e: Expected native int or pointer, but got VT
		//IL_0158: Expected F4, but got I
		//IL_0153: Expected native int or pointer, but got VT
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01c4: Expected Obj, but got F4
		//IL_01f8: Expected Obj, but got F4
		//IL_036a: Expected F4, but got Obj
		//IL_0365: Expected native int or pointer, but got VT
		//IL_037f: Expected F4, but got I
		//IL_037a: Expected native int or pointer, but got VT
		//IL_03c6: Expected Obj, but got I
		//IL_133b: Expected I, but got Obj
		//IL_1351: Expected Obj, but got I
		//IL_0574: Expected I, but got Obj
		//IL_058a: Expected Obj, but got I
		//IL_21df: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e4: Expected Obj, but got Unknown
		//IL_2215: Expected I, but got Obj
		//IL_222b: Expected Obj, but got I
		//IL_072d: Expected Obj, but got I4
		//IL_2864: Expected F4, but got Obj
		//IL_285f: Expected native int or pointer, but got VT
		//IL_287e: Expected F4, but got Obj
		//IL_2879: Expected native int or pointer, but got VT
		//IL_2893: Expected F4, but got I
		//IL_288e: Expected native int or pointer, but got VT
		//IL_28aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_28af: Expected Obj, but got Unknown
		//IL_28e7: Expected F4, but got Obj
		//IL_28e2: Expected native int or pointer, but got VT
		//IL_137c: Expected I, but got Obj
		//IL_0d91: Expected Obj, but got I4
		//IL_05b5: Expected I, but got Obj
		//IL_1415: Expected F4, but got Obj
		//IL_1410: Expected native int or pointer, but got VT
		//IL_1427: Expected F4, but got I
		//IL_1422: Expected native int or pointer, but got VT
		//IL_143d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1442: Expected Obj, but got Unknown
		//IL_13c9: Expected I, but got Obj
		//IL_05fd: Expected Obj, but got I4
		//IL_0740: Expected I, but got Obj
		//IL_0756: Expected Obj, but got I
		//IL_0da4: Expected I, but got Obj
		//IL_0dba: Expected Obj, but got I
		//IL_1874: Expected F4, but got Obj
		//IL_186f: Expected native int or pointer, but got VT
		//IL_1889: Expected F4, but got I
		//IL_1884: Expected native int or pointer, but got VT
		//IL_18ac: Expected I, but got Obj
		//IL_18c2: Expected Obj, but got I
		//IL_1c7d: Expected F4, but got Obj
		//IL_1c78: Expected native int or pointer, but got VT
		//IL_1c92: Expected F4, but got I
		//IL_1c8d: Expected native int or pointer, but got VT
		//IL_1cb5: Expected I, but got Obj
		//IL_1ccb: Expected Obj, but got I
		//IL_0781: Expected I, but got Obj
		//IL_0610: Expected I, but got Obj
		//IL_0626: Expected Obj, but got I
		//IL_0de5: Expected I, but got Obj
		//IL_07ce: Expected I, but got Obj
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e6: Expected Obj, but got Unknown
		//IL_1817: Expected I, but got Obj
		//IL_182d: Expected Obj, but got I
		//IL_0e32: Expected I, but got Obj
		//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee: Expected Obj, but got Unknown
		//IL_26ae: Expected F4, but got Obj
		//IL_26a9: Expected native int or pointer, but got VT
		//IL_26c8: Expected F4, but got Obj
		//IL_26c3: Expected native int or pointer, but got VT
		//IL_26dd: Expected F4, but got I
		//IL_26d8: Expected native int or pointer, but got VT
		//IL_26f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f9: Expected Obj, but got Unknown
		//IL_2731: Expected F4, but got Obj
		//IL_272c: Expected native int or pointer, but got VT
		//IL_0651: Expected I, but got Obj
		//IL_06ea: Expected F4, but got Obj
		//IL_06e5: Expected native int or pointer, but got VT
		//IL_06fc: Expected F4, but got I
		//IL_06f7: Expected native int or pointer, but got VT
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Obj, but got Unknown
		//IL_069e: Expected I, but got Obj
		//IL_1925: Expected F4, but got I
		//IL_1931: Expected Obj, but got F4
		//IL_193b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1940: Expected Obj, but got Unknown
		//IL_194a: Unknown result type (might be due to invalid IL or missing references)
		//IL_194f: Expected Obj, but got Unknown
		//IL_198b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1990: Expected Obj, but got Unknown
		//IL_19a9: Expected F4, but got I
		//IL_19a9: Expected F4, but got Obj
		//IL_19b5: Expected Obj, but got F4
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Expected Obj, but got Unknown
		//IL_19ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d3: Expected Obj, but got Unknown
		//IL_1a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a14: Expected Obj, but got Unknown
		//IL_1a36: Expected F4, but got I
		//IL_1a36: Expected F4, but got I
		//IL_1d2c: Expected Obj, but got I4
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected Obj, but got Unknown
		//IL_08a5: Expected F4, but got I
		//IL_08a5: Expected F4, but got I
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected Obj, but got Unknown
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected Obj, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e8: Expected Obj, but got Unknown
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f7: Expected Obj, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Obj, but got Unknown
		//IL_0956: Expected F4, but got I
		//IL_0956: Expected F4, but got Obj
		//IL_0967: Expected Obj, but got F4
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected Obj, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected Obj, but got Unknown
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		//IL_09df: Expected F4, but got I
		//IL_09df: Expected F4, but got Obj
		//IL_09eb: Expected Obj, but got F4
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected Obj, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a09: Expected Obj, but got Unknown
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected Obj, but got Unknown
		//IL_0a6c: Expected F4, but got I
		//IL_0a6c: Expected F4, but got I
		//IL_1d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d58: Expected Obj, but got Unknown
		//IL_1d76: Expected F4, but got I
		//IL_1d82: Expected Obj, but got F4
		//IL_1d8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d91: Expected Obj, but got Unknown
		//IL_1d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da0: Expected Obj, but got Unknown
		//IL_1ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de1: Expected Obj, but got Unknown
		//IL_1dfa: Expected F4, but got I
		//IL_1dfa: Expected F4, but got Obj
		//IL_1e06: Expected Obj, but got F4
		//IL_1e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e15: Expected Obj, but got Unknown
		//IL_1e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e24: Expected Obj, but got Unknown
		//IL_1e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e65: Expected Obj, but got Unknown
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Expected Obj, but got Unknown
		//IL_0ad5: Expected F4, but got I
		//IL_0ad5: Expected F4, but got I
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected Obj, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected Obj, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected Obj, but got Unknown
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b27: Expected Obj, but got Unknown
		//IL_1ea3: Expected F4, but got I
		//IL_1ea3: Expected F4, but got I
		//IL_1ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee5: Expected Obj, but got Unknown
		//IL_1f06: Expected F4, but got I
		//IL_1f06: Expected F4, but got I
		//IL_1f19: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1e: Expected Obj, but got Unknown
		//IL_1f28: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2d: Expected Obj, but got Unknown
		//IL_1f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f49: Expected Obj, but got Unknown
		//IL_1f53: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f58: Expected Obj, but got Unknown
		//IL_1f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9e: Expected Obj, but got Unknown
		//IL_1fb7: Expected F4, but got I
		//IL_1fb7: Expected F4, but got Obj
		//IL_1a5c: Expected I, but got Obj
		//IL_1a72: Expected Obj, but got I
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_0ee9: Expected Obj, but got F4
		//IL_0ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef8: Expected Obj, but got Unknown
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f07: Expected Obj, but got Unknown
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected Obj, but got Unknown
		//IL_0f61: Expected F4, but got I
		//IL_0f61: Expected F4, but got Obj
		//IL_0f6d: Expected Obj, but got F4
		//IL_0f77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7c: Expected Obj, but got Unknown
		//IL_0f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Expected Obj, but got Unknown
		//IL_0fc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcc: Expected Obj, but got Unknown
		//IL_0fed: Expected F4, but got I
		//IL_0fed: Expected F4, but got I
		//IL_2779: Expected I, but got Obj
		//IL_278f: Expected Obj, but got I
		//IL_102f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Expected Obj, but got Unknown
		//IL_1055: Expected F4, but got I
		//IL_1055: Expected F4, but got I
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected Obj, but got Unknown
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Expected Obj, but got Unknown
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_1098: Expected Obj, but got Unknown
		//IL_10a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Expected Obj, but got Unknown
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected I4, but got Unknown
		//IL_0baf: Expected I, but got Obj
		//IL_0bfc: Expected I, but got Obj
		//IL_1fdd: Expected I, but got Obj
		//IL_1ff3: Expected Obj, but got I
		//IL_27ff: Expected I, but got Obj
		//IL_2815: Expected Obj, but got I
		//IL_1134: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Expected Obj, but got Unknown
		//IL_1aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1abf: Expected I4, but got Unknown
		//IL_1aec: Expected I4, but got Obj
		//IL_1154: Expected I, but got Obj
		//IL_1b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1b: Expected Obj, but got Unknown
		//IL_11a1: Expected I, but got Obj
		//IL_0c95: Expected Obj, but got I4
		//IL_202d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2032: Expected I4, but got Unknown
		//IL_205f: Expected I4, but got Obj
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_208e: Expected Obj, but got Unknown
		//IL_0ca8: Expected I, but got Obj
		//IL_0cbe: Expected Obj, but got I
		//IL_123a: Expected Obj, but got I4
		//IL_1b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b37: Expected Obj, but got Unknown
		//IL_1b68: Expected I, but got Obj
		//IL_1b7e: Expected Obj, but got I
		//IL_1bb0: Expected F4, but got Obj
		//IL_1bab: Expected native int or pointer, but got VT
		//IL_1bca: Expected F4, but got Obj
		//IL_1bc5: Expected native int or pointer, but got VT
		//IL_1bdf: Expected F4, but got I
		//IL_1bda: Expected native int or pointer, but got VT
		//IL_1bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfb: Expected Obj, but got Unknown
		//IL_1c33: Expected F4, but got Obj
		//IL_1c2e: Expected native int or pointer, but got VT
		//IL_0ce9: Expected I, but got Obj
		//IL_0d4e: Expected F4, but got Obj
		//IL_0d49: Expected native int or pointer, but got VT
		//IL_0d60: Expected F4, but got I
		//IL_0d5b: Expected native int or pointer, but got VT
		//IL_0d76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7b: Expected Obj, but got Unknown
		//IL_0d1c: Expected I, but got Obj
		//IL_124d: Expected I, but got Obj
		//IL_1263: Expected Obj, but got I
		//IL_20a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_20aa: Expected Obj, but got Unknown
		//IL_20db: Expected I, but got Obj
		//IL_20f1: Expected Obj, but got I
		//IL_2123: Expected F4, but got Obj
		//IL_211e: Expected native int or pointer, but got VT
		//IL_213d: Expected F4, but got Obj
		//IL_2138: Expected native int or pointer, but got VT
		//IL_2152: Expected F4, but got I
		//IL_214d: Expected native int or pointer, but got VT
		//IL_2169: Unknown result type (might be due to invalid IL or missing references)
		//IL_216e: Expected Obj, but got Unknown
		//IL_21a6: Expected F4, but got Obj
		//IL_21a1: Expected native int or pointer, but got VT
		//IL_128e: Expected I, but got Obj
		//IL_12f3: Expected F4, but got Obj
		//IL_12ee: Expected native int or pointer, but got VT
		//IL_1305: Expected F4, but got I
		//IL_1300: Expected native int or pointer, but got VT
		//IL_131b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Expected Obj, but got Unknown
		//IL_12c1: Expected I, but got Obj
		object obj = default;
		Vector4 vector = (Vector4)(obj + 536);
		object obj2 = obj + 184;
		object obj3 = obj + 472;
		object obj4 = obj + 160;
		object obj5 = obj + 240;
		object obj6 = obj + 456;
		object obj7 = obj + 440;
		object obj8 = obj + 72;
		object obj9 = obj + 232;
		object obj10 = obj + 424;
		object obj11 = obj + 408;
		object obj12 = obj + 56;
		object obj13 = obj + 224;
		object obj14 = obj + 392;
		object obj15 = obj + 376;
		object obj16 = obj + 40;
		object obj17 = obj + 216;
		object obj18 = obj + 360;
		object obj19 = obj + 344;
		object obj20 = obj + 24;
		object obj21 = obj + 208;
		object obj22 = obj + 328;
		object obj23 = obj + 312;
		object obj24 = obj + 16;
		object obj25 = obj + 200;
		object obj26 = obj + 296;
		object obj27 = obj + 280;
		object obj28 = obj + 8;
		object obj29 = obj + 176;
		object obj30 = obj + 264;
		object obj31 = obj + 248;
		object obj32 = obj + 152;
		object obj33 = obj + 144;
		object obj34 = obj + 136;
		object obj35 = obj + 128;
		object obj36 = obj + 120;
		object obj37 = obj + 112;
		object obj38 = obj + 104;
		object obj39 = obj + 96;
		object obj40 = obj + 88;
		object obj41 = obj + 520;
		obj41 = 0;
		_ = 0;
		object obj42 = obj + 504;
		obj42 = 0;
		_ = 0;
		UIDrawCall uIDrawCall = (UIDrawCall)(obj + 488);
		uIDrawCall = (UIDrawCall)0;
		((UnityEngine.Object)uIDrawCall).m_CachedPtr = (IntPtr)0;
		if (mFillAmount < 0.001f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj41 = vector.x;
		_ = vector.z;
		Color color = drawingColor;
		obj42 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		uIDrawCall.renderQueue = (int)this;
		if (mFillDirection == FillDirection.Horizontal || mFillDirection == FillDirection.Vertical)
		{
			if (mFillDirection == FillDirection.Horizontal)
			{
				((Vector4*)(nint)vector)->x = (float)obj42;
				Vector4 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
				((Vector4*)(nint)vector2)->z = 0f;
				obj2 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
				_ = 0;
				float num = vector.z - (float)obj2;
				float num2 = num * mFillAmount;
				if (~(mInvert ? 1u : 0u) == 0)
				{
					((Vector4*)(nint)vector)->x = (float)obj41;
					Vector4 vector3 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					((Vector4*)(nint)vector3)->z = 0f;
					obj2 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj3 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					object obj43 = 0 - obj3;
					float num3 = (float)obj43 * mFillAmount;
					float num4 = vector.z - num3;
					obj41 = num4;
					obj4 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					float num5 = 0f - num2;
					obj42 = num5;
				}
				else
				{
					((Vector4*)(nint)vector)->x = (float)obj41;
					Vector4 vector4 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					((Vector4*)(nint)vector4)->z = 0f;
					obj2 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj3 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					object obj44 = 0 - obj3;
					float num6 = (float)obj44 * mFillAmount;
					float num7 = vector.x + num6;
					obj4 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					float num8 = (float)obj4 + num2;
				}
			}
			else if (mFillDirection == FillDirection.Vertical)
			{
				((Vector4*)(nint)vector)->x = (float)obj42;
				Vector4 vector5 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
				((Vector4*)(nint)vector5)->z = 0f;
				obj2 = obj42;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
				_ = 0;
				float num9 = vector.w;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
				float num10 = num9 - 0f;
				float num11 = num10 * mFillAmount;
				if (~(mInvert ? 1u : 0u) == 0)
				{
					((Vector4*)(nint)vector)->x = (float)obj41;
					Vector4 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					((Vector4*)(nint)vector6)->z = 0f;
					obj2 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj3 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj45 = num12 - 0;
					float num13 = (float)obj45 * mFillAmount;
					float num14 = vector.w - num13;
					obj4 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+C]");
					float num15 = 0f - num11;
				}
				else
				{
					((Vector4*)(nint)vector)->x = (float)obj41;
					Vector4 vector7 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					((Vector4*)(nint)vector7)->z = 0f;
					obj2 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj3 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+C]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
					object obj46 = num16 - 0;
					float num17 = (float)obj46 * mFillAmount;
					float num18 = vector.y + num17;
					obj4 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+4]");
					float num19 = 0f + num11;
				}
			}
		}
		nint num20 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S0_v115 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj47 = (nint)0 & (nint)0x200;
		if (obj47 != null)
		{
			nint num21 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ S0_v642 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj2 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj3 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj4 = 0;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		_ = 0;
		obj5 = obj4;
		((Vector4*)(nint)vector)->x = (float)obj5;
		object obj48 = mTempPos + 16;
		obj48 = vector.x;
		obj6 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj7 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj8 = 0;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+C]");
		_ = 0;
		obj9 = obj8;
		((Vector4*)(nint)vector)->x = (float)obj9;
		object obj49 = mTempPos + 24;
		obj49 = vector.x;
		obj10 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj11 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v29+C]");
		_ = 0;
		obj13 = obj12;
		((Vector4*)(nint)vector)->x = (float)obj13;
		object obj50 = mTempPos + 32;
		obj50 = vector.x;
		obj14 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj15 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
		_ = 0;
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+4]");
		_ = 0;
		obj17 = obj16;
		((Vector4*)(nint)vector)->x = (float)obj17;
		object obj51 = mTempPos + 40;
		obj51 = vector.x;
		obj18 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj19 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj20 = 0;
		obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+4]");
		_ = 0;
		obj21 = obj20;
		((Vector4*)(nint)vector)->x = (float)obj21;
		object obj52 = mTempUVs + 16;
		obj52 = vector.x;
		obj22 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj23 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj24 = 0;
		obj24 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v53+C]");
		_ = 0;
		obj25 = obj24;
		((Vector4*)(nint)vector)->x = (float)obj25;
		object obj53 = mTempUVs + 24;
		obj53 = vector.x;
		obj26 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj27 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v59+8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v61+C]");
		_ = 0;
		obj29 = obj28;
		((Vector4*)(nint)vector)->x = (float)obj29;
		object obj54 = mTempUVs + 32;
		obj54 = vector.x;
		obj30 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj31 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
		_ = 0;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v67+8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v69+4]");
		_ = 0;
		obj32 = obj;
		((Vector4*)(nint)vector)->x = (float)obj32;
		object obj55 = mTempUVs + 40;
		obj55 = vector.x;
		if (mFillAmount < 1f)
		{
			if (mFillDirection == FillDirection.Radial90)
			{
				nint num22 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ S0_v581 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj56 = (nint)0 & (nint)0x200;
				if (obj56 != null)
				{
					nint num23 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v636 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool activeDuringHoverboard = mInvert;
				IEnumerator enumerator = ((CharacterFXController)(object)mTempPos).DespawnCollisionEffect((Transform)(object)mTempUVs, mFillAmount, activeDuringHoverboard, false);
				if (enumerator == null)
				{
					return;
				}
				object obj57 = 0;
				while ((nint)obj57 <= 3)
				{
					nint num24 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1135 @ S0_v595 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj58 = (nint)0 & (nint)0x200;
					if (obj58 != null)
					{
						nint num25 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1214 @ S0_v630 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj59 = mTempPos + 16;
					object obj60 = obj57 << 3;
					object obj61 = obj59 + obj60;
					obj2 = obj61;
					nint num26 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ S0_v601 (Il2CppClass<UnityEngine.Vector2>)+BA]");
					object obj62 = (nint)0 & (nint)0x200;
					if (obj62 != null)
					{
						nint num27 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ S0_v626 (Il2CppClass<UnityEngine.Vector2>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj33 = obj2;
					((Vector4*)(nint)vector)->x = (float)obj33;
					Vector3 vector8 = vector;
					((Vector4*)(nint)vector)->x = (float)obj3;
					Vector4 vector9 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
					((Vector4*)(nint)vector9)->z = 0f;
					verts.Add(vector);
					object obj63 = mTempUVs + 16;
					object obj64 = obj57 << 3;
					object obj65 = obj63 + obj64;
					obj4 = obj65;
					obj34 = obj4;
					((Vector4*)(nint)vector)->x = (float)obj34;
					uvs.Add((Vector2)vector);
					((Vector4*)(nint)vector)->x = (float)uIDrawCall;
					((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
					cols.Add(vector);
					object obj66 = obj57 + 1;
					obj57 = obj66;
				}
				return;
			}
			if (mFillDirection == FillDirection.Radial180)
			{
				object obj67 = 0;
				while ((nint)obj67 <= 1)
				{
					nint num28 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ S0_v401 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj68 = (nint)0 & (nint)0x200;
					if (obj68 != null)
					{
						nint num29 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ S0_v574 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector4*)(nint)vector)->x = (float)obj41;
					Vector4 vector10 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					((Vector4*)(nint)vector10)->z = 0f;
					obj2 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					nint num30 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ S1_v457 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj69 = (nint)0 & (nint)0x200;
					if (obj69 != null)
					{
						nint num31 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1142 @ S1_v636 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = obj67 == null;
					float t = ((!flag) ? 1f : 0.5f);
					object obj70 = mTempPos + 16;
					float t2 = ((!flag) ? 0.5f : 0f);
					float x = vector.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					float num32 = Mathf.LerpUnclamped(x, 0f, t2);
					obj70 = num32;
					object obj71 = mTempPos + 24;
					object obj72 = mTempPos + 16;
					obj71 = obj72;
					obj3 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj4 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					object obj73 = mTempPos + 32;
					object obj74 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					float num33 = Mathf.LerpUnclamped((float)obj74, 0f, t);
					obj73 = num33;
					object obj75 = mTempPos + 40;
					object obj76 = mTempPos + 32;
					obj75 = obj76;
					obj6 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj7 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					object obj77 = mTempPos + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
					nint num34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+C]");
					float num35 = Mathf.LerpUnclamped(num34, 0f, 0f);
					obj8 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj10 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					object obj78 = mTempPos + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
					nint num36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+C]");
					float num37 = Mathf.LerpUnclamped(num36, 0f, 1f);
					object obj79 = mTempPos + 32;
					object obj80 = mTempPos + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1489 @ S1_v513+4]");
					_ = 0;
					object obj81 = mTempPos + 40;
					object obj82 = mTempPos + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ S1_v520+4]");
					_ = 0;
					obj11 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj12 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj83 = mTempUVs + 16;
					object obj84 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
					float num38 = Mathf.LerpUnclamped((float)obj84, 0f, t2);
					obj83 = num38;
					object obj85 = mTempUVs + 24;
					object obj86 = mTempUVs + 16;
					obj85 = obj86;
					obj14 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj15 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj87 = mTempUVs + 32;
					object obj88 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
					float num39 = Mathf.LerpUnclamped((float)obj88, 0f, t);
					obj87 = num39;
					object obj89 = mTempUVs + 40;
					object obj90 = mTempUVs + 32;
					obj89 = obj90;
					obj16 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj18 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj91 = mTempUVs + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+4]");
					nint num40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+C]");
					float num41 = Mathf.LerpUnclamped(num40, 0f, 0f);
					obj19 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj20 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj92 = mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+4]");
					nint num42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+C]");
					float num43 = Mathf.LerpUnclamped(num42, 0f, 1f);
					object obj93 = mTempUVs + 32;
					object obj94 = mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1733 @ S1_v577+4]");
					_ = 0;
					object obj95 = mTempUVs + 40;
					object obj96 = mTempUVs + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1746 @ S1_v584+4]");
					_ = 0;
					object obj97;
					float num45;
					if (~(mInvert ? 1u : 0u) == 0)
					{
						float num44 = mFillAmount * 2f;
						obj97 = 1 - obj67;
						num45 = num44;
					}
					else
					{
						float num46 = mFillAmount * 2f;
						num45 = num46;
						obj97 = obj67;
					}
					float num47 = num45 - (float)obj97;
					nint num48 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1853 @ S0_v490 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj98 = (nint)0 & (nint)0x200;
					if (obj98 != null)
					{
						nint num49 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1899 @ S0_v559 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num50 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1918 @ S0_v502 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj99 = (nint)0 & (nint)0x200;
					if (obj99 != null)
					{
						nint num51 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ S0_v555 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float delay;
					if (num47 < 0f)
					{
						delay = 0f;
					}
					else
					{
						delay = ((!(num47 > 1f)) ? num47 : 1f);
					}
					bool flag2 = mInvert;
					bool activeDuringHoverboard2 = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
					int val = obj67 + 3;
					string text = NGUIMath.IntToBinary(val, 4);
					IEnumerator enumerator2 = ((CharacterFXController)(object)mTempPos).DespawnCollisionEffect((Transform)(object)mTempUVs, delay, activeDuringHoverboard2, (byte)(int)text != 0);
					if (enumerator2 != null)
					{
						object obj100 = 0;
						while ((nint)obj100 <= 3)
						{
							nint num52 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2157 @ S0_v516 (Il2CppClass<UIBasicSprite>)+BA]");
							object obj101 = (nint)0 & (nint)0x200;
							if (obj101 != null)
							{
								nint num53 = (nint)typeof(UIBasicSprite);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ S0_v550 (Il2CppClass<UIBasicSprite>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj102 = mTempPos + 16;
							object obj103 = obj100 << 3;
							object obj104 = obj102 + obj103;
							obj2 = obj104;
							nint num54 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2194 @ S0_v522 (Il2CppClass<UnityEngine.Vector2>)+BA]");
							object obj105 = (nint)0 & (nint)0x200;
							if (obj105 != null)
							{
								nint num55 = (nint)typeof(Vector2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2201 @ S0_v547 (Il2CppClass<UnityEngine.Vector2>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj35 = obj2;
							((Vector4*)(nint)vector)->x = (float)obj35;
							Vector3 vector11 = vector;
							((Vector4*)(nint)vector)->x = (float)obj3;
							Vector4 vector12 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
							((Vector4*)(nint)vector12)->z = 0f;
							verts.Add(vector);
							object obj106 = mTempUVs + 16;
							object obj107 = obj100 << 3;
							object obj108 = obj106 + obj107;
							obj4 = obj108;
							obj36 = obj4;
							((Vector4*)(nint)vector)->x = (float)obj36;
							uvs.Add((Vector2)vector);
							((Vector4*)(nint)vector)->x = (float)uIDrawCall;
							((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
							cols.Add(vector);
							object obj109 = obj100 + 1;
							obj100 = obj109;
						}
					}
					object obj110 = obj67 + 1;
					obj67 = obj110;
				}
				return;
			}
			if (mFillDirection == FillDirection.Radial360)
			{
				object obj111 = 0;
				while ((nint)obj111 <= 3)
				{
					nint num56 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1114 @ S0_v222 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj112 = (nint)0 & (nint)0x200;
					if (obj112 != null)
					{
						nint num57 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1153 @ S0_v390 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector4*)(nint)vector)->x = (float)obj41;
					Vector4 vector13 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					((Vector4*)(nint)vector13)->z = 0f;
					obj2 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					nint num58 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ S1_v250 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj113 = (nint)0 & (nint)0x200;
					if (obj113 != null)
					{
						nint num59 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1245 @ S1_v441 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag3 = (nint)obj111 > 1;
					float t3 = ((!flag3) ? 0.5f : 1f);
					float t4 = ((!flag3) ? 0f : 0.5f);
					bool flag4 = obj111 == null;
					bool flag5 = (nint)obj111 == 3;
					object obj114 = flag4 | flag5;
					float t5 = ((obj114 == null) ? 1f : 0.5f);
					object obj115 = mTempPos + 16;
					float x2 = vector.x;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
					float num60 = Mathf.LerpUnclamped(x2, 0f, t4);
					obj115 = num60;
					object obj116 = mTempPos + 24;
					object obj117 = mTempPos + 16;
					obj116 = obj117;
					obj3 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj4 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					object obj118 = mTempPos + 32;
					object obj119 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
					float num61 = Mathf.LerpUnclamped((float)obj119, 0f, t3);
					obj118 = num61;
					object obj120 = mTempPos + 40;
					object obj121 = mTempPos + 32;
					obj120 = obj121;
					obj6 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj7 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					object obj122 = mTempPos + 16;
					float t6 = ((obj114 == null) ? 0.5f : 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+4]");
					nint num62 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+C]");
					float num63 = Mathf.LerpUnclamped(num62, 0f, t6);
					obj8 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					obj10 = obj41;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v89+8]");
					_ = 0;
					object obj123 = mTempPos + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+4]");
					nint num64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27+C]");
					float num65 = Mathf.LerpUnclamped(num64, 0f, t5);
					object obj124 = mTempPos + 32;
					object obj125 = mTempPos + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1803 @ S1_v312+4]");
					_ = 0;
					object obj126 = mTempPos + 40;
					object obj127 = mTempPos + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1816 @ S1_v319+4]");
					_ = 0;
					obj11 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj12 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj128 = mTempUVs + 16;
					object obj129 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31+8]");
					float num66 = Mathf.LerpUnclamped((float)obj129, 0f, t4);
					obj128 = num66;
					object obj130 = mTempUVs + 24;
					object obj131 = mTempUVs + 16;
					obj130 = obj131;
					obj14 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj15 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj132 = mTempUVs + 32;
					object obj133 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v37+8]");
					float num67 = Mathf.LerpUnclamped((float)obj133, 0f, t3);
					obj132 = num67;
					object obj134 = mTempUVs + 40;
					object obj135 = mTempUVs + 32;
					obj134 = obj135;
					obj16 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj18 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj136 = mTempUVs + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v39+4]");
					nint num68 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v43+C]");
					float num69 = Mathf.LerpUnclamped(num68, 0f, t6);
					obj19 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					obj20 = obj42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v92+8]");
					_ = 0;
					object obj137 = mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v45+4]");
					nint num70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v47+C]");
					float num71 = Mathf.LerpUnclamped(num70, 0f, t5);
					object obj138 = mTempUVs + 32;
					object obj139 = mTempUVs + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2021 @ S1_v376+4]");
					_ = 0;
					object obj140 = mTempUVs + 40;
					object obj141 = mTempUVs + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2034 @ S1_v383+4]");
					_ = 0;
					bool flag6 = mInvert;
					int val2 = obj111 + 2;
					string text2 = NGUIMath.IntToBinary(val2, 4);
					float num72 = mFillAmount * 4f;
					bool flag7 = !flag6;
					bool flag8 = !flag7;
					string text3 = text2;
					if (!flag8)
					{
						string text4 = (string)(3 - text2);
						text3 = text4;
					}
					float num73 = num72 - (float)text3;
					nint num74 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2081 @ S0_v313 (Il2CppClass<UIBasicSprite>)+BA]");
					object obj142 = (nint)0 & (nint)0x200;
					if (obj142 != null)
					{
						nint num75 = (nint)typeof(UIBasicSprite);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2088 @ S0_v382 (Il2CppClass<UIBasicSprite>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					nint num76 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2107 @ S0_v325 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj143 = (nint)0 & (nint)0x200;
					if (obj143 != null)
					{
						nint num77 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2126 @ S0_v378 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float delay2;
					if (num73 < 0f)
					{
						delay2 = 0f;
					}
					else
					{
						delay2 = ((!(num73 > 1f)) ? num73 : 1f);
					}
					bool activeDuringHoverboard3 = mInvert;
					int val3 = obj111 + 2;
					string text5 = NGUIMath.IntToBinary(val3, 4);
					IEnumerator enumerator3 = ((CharacterFXController)(object)mTempPos).DespawnCollisionEffect((Transform)(object)mTempUVs, delay2, activeDuringHoverboard3, (byte)(int)text5 != 0);
					if (enumerator3 != null)
					{
						object obj144 = 0;
						while ((nint)obj144 <= 3)
						{
							nint num78 = (nint)typeof(UIBasicSprite);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2286 @ S0_v339 (Il2CppClass<UIBasicSprite>)+BA]");
							object obj145 = (nint)0 & (nint)0x200;
							if (obj145 != null)
							{
								nint num79 = (nint)typeof(UIBasicSprite);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2293 @ S0_v373 (Il2CppClass<UIBasicSprite>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj146 = mTempPos + 16;
							object obj147 = obj144 << 3;
							object obj148 = obj146 + obj147;
							obj2 = obj148;
							nint num80 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2311 @ S0_v345 (Il2CppClass<UnityEngine.Vector2>)+BA]");
							object obj149 = (nint)0 & (nint)0x200;
							if (obj149 != null)
							{
								nint num81 = (nint)typeof(Vector2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2317 @ S0_v370 (Il2CppClass<UnityEngine.Vector2>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							obj37 = obj2;
							((Vector4*)(nint)vector)->x = (float)obj37;
							Vector3 vector14 = vector;
							((Vector4*)(nint)vector)->x = (float)obj3;
							Vector4 vector15 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
							((Vector4*)(nint)vector15)->z = 0f;
							verts.Add(vector);
							object obj150 = mTempUVs + 16;
							object obj151 = obj144 << 3;
							object obj152 = obj150 + obj151;
							obj4 = obj152;
							obj38 = obj4;
							((Vector4*)(nint)vector)->x = (float)obj38;
							uvs.Add((Vector2)vector);
							((Vector4*)(nint)vector)->x = (float)uIDrawCall;
							((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
							cols.Add(vector);
							object obj153 = obj144 + 1;
							obj144 = obj153;
						}
					}
					object obj154 = obj111 + 1;
					obj111 = obj154;
				}
				return;
			}
		}
		object obj155 = 0;
		while ((nint)obj155 <= 3)
		{
			nint num82 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ S0_v167 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj156 = (nint)0 & (nint)0x200;
			if (obj156 != null)
			{
				nint num83 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v991 @ S0_v202 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj157 = mTempPos + 16;
			object obj158 = obj155 << 3;
			object obj159 = obj157 + obj158;
			obj2 = obj159;
			nint num84 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1012 @ S0_v173 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj160 = (nint)0 & (nint)0x200;
			if (obj160 != null)
			{
				nint num85 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S0_v198 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj39 = obj2;
			((Vector4*)(nint)vector)->x = (float)obj39;
			Vector3 vector16 = vector;
			((Vector4*)(nint)vector)->x = (float)obj3;
			Vector4 vector17 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector4*)(nint)vector17)->z = 0f;
			verts.Add(vector);
			object obj161 = mTempUVs + 16;
			object obj162 = obj155 << 3;
			object obj163 = obj161 + obj162;
			obj4 = obj163;
			obj40 = obj4;
			((Vector4*)(nint)vector)->x = (float)obj40;
			uvs.Add((Vector2)vector);
			((Vector4*)(nint)vector)->x = (float)uIDrawCall;
			((Vector4*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
			cols.Add(vector);
			object obj164 = obj155 + 1;
			obj155 = obj164;
		}
	}

	private unsafe void AdvancedFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected VT, but got Unknown
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c43: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected Obj, but got Unknown
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7b: Expected Obj, but got Unknown
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c89: Expected Obj, but got Unknown
		//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected Obj, but got Unknown
		//IL_0ca0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca5: Expected Obj, but got Unknown
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb3: Expected Obj, but got Unknown
		//IL_0cbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected Obj, but got Unknown
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected Obj, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cdd: Expected I4, but got Unknown
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cff: Expected Obj, but got Unknown
		//IL_0d08: Expected Obj, but got I4
		//IL_0d17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Expected Obj, but got Unknown
		//IL_0d25: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0d75: Expected F4, but got Obj
		//IL_0d70: Expected native int or pointer, but got VT
		//IL_0d8a: Expected F4, but got I
		//IL_0d85: Expected native int or pointer, but got VT
		//IL_0da1: Expected I4, but got Obj
		//IL_0dbb: Expected F4, but got Obj
		//IL_0db6: Expected native int or pointer, but got VT
		//IL_0dd0: Expected F4, but got I
		//IL_0dcb: Expected native int or pointer, but got VT
		//IL_0e14: Expected Obj, but got F4
		//IL_0e28: Expected I4, but got Obj
		//IL_0e60: Expected I, but got Obj
		//IL_006d: Expected I, but got Obj
		//IL_0eaf: Expected F4, but got I
		//IL_0eaf: Expected F4, but got Obj
		//IL_0eea: Expected Obj, but got I4
		//IL_0f28: Expected Obj, but got I4
		//IL_0f79: Expected F4, but got I
		//IL_00be: Expected F4, but got I4
		//IL_00b9: Expected native int or pointer, but got VT
		//IL_00d3: Expected F4, but got I
		//IL_00ce: Expected native int or pointer, but got VT
		//IL_01d0: Expected I, but got Obj
		//IL_0112: Expected F4, but got I4
		//IL_010d: Expected native int or pointer, but got VT
		//IL_0127: Expected F4, but got I
		//IL_0122: Expected native int or pointer, but got VT
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected Obj, but got Unknown
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected Obj, but got Unknown
		//IL_0166: Expected F4, but got I4
		//IL_0161: Expected native int or pointer, but got VT
		//IL_017b: Expected F4, but got I
		//IL_0176: Expected native int or pointer, but got VT
		//IL_018c: Invalid comparison between I and F4
		//IL_040b: Expected I, but got Obj
		//IL_0421: Expected Obj, but got I
		//IL_037d: Expected I, but got Obj
		//IL_0393: Expected Obj, but got I
		//IL_10ca: Expected F4, but got Obj
		//IL_10ca: Expected F4, but got Obj
		//IL_1008: Expected F4, but got Obj
		//IL_1023: Expected I, but got Obj
		//IL_1039: Expected Obj, but got I
		//IL_04fc: Expected I, but got Obj
		//IL_1087: Expected F4, but got Obj
		//IL_109b: Expected F4, but got Obj
		//IL_03be: Expected I, but got Obj
		//IL_16bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c4: Expected Obj, but got Unknown
		//IL_16da: Expected I, but got Obj
		//IL_16f0: Expected Obj, but got I
		//IL_048b: Expected I, but got Obj
		//IL_1750: Unknown result type (might be due to invalid IL or missing references)
		//IL_1755: Expected Obj, but got Unknown
		//IL_0549: Expected I, but got Obj
		//IL_0596: Expected I, but got Obj
		//IL_10f3: Expected Obj, but got F4
		//IL_10fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1102: Expected Obj, but got Unknown
		//IL_1131: Expected Obj, but got F4
		//IL_113b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1140: Expected Obj, but got Unknown
		//IL_116f: Expected Obj, but got F4
		//IL_117c: Expected F4, but got Obj
		//IL_1177: Expected native int or pointer, but got VT
		//IL_1191: Expected F4, but got I
		//IL_118c: Expected native int or pointer, but got VT
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Expected Obj, but got Unknown
		//IL_11cc: Expected Obj, but got I4
		//IL_11e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Expected Obj, but got Unknown
		//IL_1205: Expected Obj, but got I
		//IL_122c: Expected Obj, but got I4
		//IL_1243: Unknown result type (might be due to invalid IL or missing references)
		//IL_1248: Expected Obj, but got Unknown
		//IL_1265: Expected Obj, but got I
		//IL_1289: Unknown result type (might be due to invalid IL or missing references)
		//IL_128e: Expected Obj, but got Unknown
		//IL_12a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12aa: Expected Obj, but got Unknown
		//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c1: Expected Obj, but got Unknown
		//IL_12c9: Expected Obj, but got F4
		//IL_12d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d8: Expected Obj, but got Unknown
		//IL_12e0: Expected Obj, but got F4
		//IL_12ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ef: Expected Obj, but got Unknown
		//IL_12f7: Expected Obj, but got F4
		//IL_1301: Unknown result type (might be due to invalid IL or missing references)
		//IL_1306: Expected Obj, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1311: Expected Obj, but got Unknown
		//IL_1328: Unknown result type (might be due to invalid IL or missing references)
		//IL_132d: Expected Obj, but got Unknown
		//IL_1333: Unknown result type (might be due to invalid IL or missing references)
		//IL_1338: Expected Obj, but got Unknown
		//IL_134f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Expected Obj, but got Unknown
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_135f: Expected Obj, but got Unknown
		//IL_137c: Expected Obj, but got I
		//IL_138b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1390: Expected Obj, but got Unknown
		//IL_1396: Unknown result type (might be due to invalid IL or missing references)
		//IL_139b: Expected Obj, but got Unknown
		//IL_13b8: Expected Obj, but got I
		//IL_13c6: Expected Obj, but got I4
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected Obj, but got Unknown
		//IL_0632: Expected I, but got Obj
		//IL_0648: Expected Obj, but got I
		//IL_13d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected Obj, but got Unknown
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_1405: Expected Obj, but got Unknown
		//IL_142e: Expected I, but got Obj
		//IL_0673: Expected I, but got Obj
		//IL_06c0: Expected I, but got Obj
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected Obj, but got Unknown
		//IL_072a: Expected I, but got Obj
		//IL_0740: Expected Obj, but got I
		//IL_146b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Expected Obj, but got Unknown
		//IL_1495: Unknown result type (might be due to invalid IL or missing references)
		//IL_149a: Expected Obj, but got Unknown
		//IL_14b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b5: Expected Obj, but got Unknown
		//IL_14be: Expected Obj, but got I4
		//IL_14ec: Expected F4, but got Obj
		//IL_14e7: Expected native int or pointer, but got VT
		//IL_1501: Expected F4, but got I
		//IL_14fc: Expected native int or pointer, but got VT
		//IL_1518: Unknown result type (might be due to invalid IL or missing references)
		//IL_151d: Expected Obj, but got Unknown
		//IL_1542: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected Obj, but got Unknown
		//IL_155d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1562: Expected Obj, but got Unknown
		//IL_156b: Expected Obj, but got I4
		//IL_1599: Expected F4, but got Obj
		//IL_1594: Expected native int or pointer, but got VT
		//IL_15ae: Expected F4, but got I
		//IL_15a9: Expected native int or pointer, but got VT
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ca: Expected Obj, but got Unknown
		//IL_15ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f4: Expected Obj, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected Obj, but got Unknown
		//IL_1618: Expected Obj, but got I4
		//IL_1646: Expected F4, but got Obj
		//IL_1641: Expected native int or pointer, but got VT
		//IL_165b: Expected F4, but got I
		//IL_1656: Expected native int or pointer, but got VT
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected Obj, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected Obj, but got Unknown
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_0807: Expected Obj, but got I4
		//IL_0835: Expected F4, but got Obj
		//IL_0830: Expected native int or pointer, but got VT
		//IL_084a: Expected F4, but got I
		//IL_0845: Expected native int or pointer, but got VT
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08b4: Expected Obj, but got I4
		//IL_08de: Expected F4, but got Obj
		//IL_08d9: Expected native int or pointer, but got VT
		//IL_076b: Expected I, but got Obj
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0924: Unknown result type (might be due to invalid IL or missing references)
		//IL_0929: Expected Obj, but got Unknown
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected Obj, but got Unknown
		//IL_094d: Expected Obj, but got I4
		//IL_0977: Expected F4, but got Obj
		//IL_0972: Expected native int or pointer, but got VT
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected Obj, but got Unknown
		//IL_09e1: Expected Obj, but got I4
		//IL_0a0b: Expected F4, but got Obj
		//IL_0a06: Expected native int or pointer, but got VT
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected Obj, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected Obj, but got Unknown
		//IL_0a7a: Expected Obj, but got I4
		//IL_0aa4: Expected F4, but got Obj
		//IL_0a9f: Expected native int or pointer, but got VT
		//IL_0b44: Expected F4, but got Obj
		//IL_0b3f: Expected native int or pointer, but got VT
		//IL_0b56: Expected F4, but got I
		//IL_0b51: Expected native int or pointer, but got VT
		//IL_0b70: Expected F4, but got Obj
		//IL_0b6b: Expected native int or pointer, but got VT
		//IL_0b82: Expected F4, but got I
		//IL_0b7d: Expected native int or pointer, but got VT
		//IL_0ba1: Expected F4, but got Obj
		//IL_0b9c: Expected native int or pointer, but got VT
		//IL_0bb3: Expected F4, but got I
		//IL_0bae: Expected native int or pointer, but got VT
		//IL_0bcd: Expected F4, but got Obj
		//IL_0bc8: Expected native int or pointer, but got VT
		//IL_0bdf: Expected F4, but got I
		//IL_0bda: Expected native int or pointer, but got VT
		//IL_0ae1: Expected I4, but got Obj
		//IL_0ae1: Expected I4, but got Obj
		//IL_0af8: Expected I4, but got Obj
		//IL_0af8: Expected I4, but got Obj
		//IL_0b14: Expected I4, but got Obj
		//IL_0b14: Expected I4, but got Obj
		//IL_0b2b: Expected I4, but got Obj
		//IL_0b2b: Expected I4, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 208);
		object obj2 = obj + 144;
		object obj3 = obj + 128;
		object obj4 = obj + 112;
		object obj5 = obj + 96;
		object obj6 = obj + 48;
		object obj7 = obj + 32;
		object obj8 = obj + 16;
		object obj9 = obj + 88;
		object obj10 = obj + 80;
		object obj11 = obj + 72;
		object obj12 = obj - -64;
		int num = obj + 192;
		((int*)num)->m_value = 0;
		_ = 0;
		object obj13 = obj + 176;
		obj13 = 0;
		_ = 0;
		UIDrawCall uIDrawCall = (UIDrawCall)(obj + 160);
		uIDrawCall = (UIDrawCall)0;
		((UnityEngine.Object)uIDrawCall).m_CachedPtr = (IntPtr)0;
		if (mFillAmount < 0.001f)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76C9");
		nint num2 = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v51 (Il2CppClass<UnityEngine.Vector4>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num3 = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v532 (Il2CppClass<UnityEngine.Vector4>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector2 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F51F");
		((int*)num)->m_value = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		_ = 0;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		if (vector.x == 0f)
		{
			((Vector3*)(nint)vector)->x = ((int*)num)->m_value;
			Vector3 vector4 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
			((Vector3*)(nint)vector4)->z = 0f;
			if (vector.y == 0f)
			{
				((Vector3*)(nint)vector)->x = ((int*)num)->m_value;
				Vector3 vector5 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				if (vector.z == 0f)
				{
					((Vector3*)(nint)vector)->x = ((int*)num)->m_value;
					Vector3 vector6 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
					((Vector3*)(nint)vector6)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Vector3)+C]");
					if (0f == 0f)
					{
						FilledSlicedFill(verts, uvs, cols);
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
		obj13 = vector.x;
		_ = vector.z;
		uIDrawCall.renderQueue = (int)this;
		obj2 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		obj3 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		nint num4 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ S3_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		if ((int)((nint)0 & (nint)0x200) != 0)
		{
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S3_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		float num6 = Mathf.LerpUnclamped((float)obj15, 0f, mFillAmount);
		obj4 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		obj5 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		obj6 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
		_ = 0;
		float num7 = (float)obj5 + (float)obj6;
		obj7 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		obj8 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v21+8]");
		float num8 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v23+8]");
		float num9 = num8 - 0f;
		obj = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float num10 = 0f;
		float num11 = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float val = num11 - 0f;
		float value = Math.Max(val, 2f);
		float num12 = Mathf.GammaToLinearSpace(value);
		float val2 = num7 - (float)obj4;
		float value2 = Math.Max(val2, 2f);
		float num13 = Mathf.GammaToLinearSpace(value2);
		float num14 = num13 / num12;
		float val3 = num9 - num7;
		float value3 = Math.Max(val3, 2f);
		float num15 = Mathf.GammaToLinearSpace(value3);
		float num16 = num15 / num12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		float val4 = 0f - num9;
		float value4 = Math.Max(val4, 2f);
		float num17 = Mathf.GammaToLinearSpace(value4);
		float num18 = num17 / num12;
		object obj16 = this + 360;
		object obj17 = this + 344;
		object obj18 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S0_v117+8]");
		float num19 = 0f + (float)obj18;
		object obj19 = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v121+8]");
		float b = 0f + (float)obj19;
		float num20 = num14 + num16;
		float num26;
		float num27;
		float num28;
		if (mFillAmount > num20)
		{
			nint num21 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S0_v506 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num22 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S0_v512 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num23 = mFillAmount - num16;
			float num24 = num23 - num14;
			float t = num24 / num18;
			float num25 = Mathf.LerpUnclamped(num19, b, t);
			num26 = num25;
			num27 = (float)obj17;
			num28 = num19;
		}
		else
		{
			nint num29 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v480 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			bool flag = obj21 == null;
			if (mFillAmount > num14)
			{
				if (!flag)
				{
					nint num30 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S0_v501 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num31 = mFillAmount - num14;
				float t2 = num31 / num16;
				float num32 = Mathf.LerpUnclamped((float)obj17, num19, t2);
				num26 = num32;
				num27 = (float)obj17;
				num28 = num32;
			}
			else
			{
				if (!flag)
				{
					nint num33 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v492 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float t3 = mFillAmount / num14;
				float num34 = Mathf.LerpUnclamped((float)obj16, (float)obj17, t3);
				num26 = num34;
				num27 = num34;
				num28 = num34;
			}
		}
		nint num35 = (nint)typeof(UIBasicSprite);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v131 (Il2CppClass<UIBasicSprite>)+BA]");
		object obj22 = (nint)0 & (nint)0x200;
		if (obj22 != null)
		{
			nint num36 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ S0_v471 (Il2CppClass<UIBasicSprite>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj23 = mTempPos + 16;
		obj23 = obj4;
		nint num37 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S1_v113 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj24 = (nint)0 & (nint)0x200;
		if (obj24 != null)
		{
			nint num38 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ S1_v355 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj25 = mTempPos + 24;
		float num39 = ((!(num6 < num7)) ? num7 : num6);
		obj25 = num39;
		object obj26 = mTempPos + 32;
		float num40 = ((!(num6 < num9)) ? num9 : num6);
		obj26 = num40;
		object obj27 = mTempPos + 40;
		if (num6 < num10)
		{
			num10 = num6;
		}
		obj27 = num10;
		((Vector3*)(nint)vector)->x = (float)obj13;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		object obj28 = mTempPos + 16;
		_ = vector.y;
		obj2 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		obj3 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
		_ = 0;
		object obj29 = mTempPos + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+4]");
		nint num41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+4]");
		object obj30 = num41 + 0;
		obj4 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		obj5 = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (System.Int32)+8]");
		_ = 0;
		object obj31 = mTempPos + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+C]");
		nint num42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+C]");
		object obj32 = num42 - 0;
		obj6 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v36+8]");
		_ = 0;
		object obj33 = mTempPos + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+C]");
		_ = 0;
		object obj34 = mTempUVs + 16;
		obj34 = obj16;
		object obj35 = mTempUVs + 24;
		obj35 = num27;
		object obj36 = mTempUVs + 32;
		obj36 = num28;
		object obj37 = mTempUVs + 40;
		obj37 = num26;
		object obj38 = mTempUVs + 16;
		object obj39 = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ S1_v167+4]");
		_ = 0;
		object obj40 = mTempUVs + 24;
		object obj41 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ S1_v171+4]");
		_ = 0;
		object obj42 = mTempUVs + 32;
		object obj43 = this + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S1_v175+C]");
		nint num43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ S1_v175+4]");
		object obj44 = num43 + 0;
		object obj45 = mTempUVs + 40;
		object obj46 = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S1_v180+C]");
		nint num44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ S1_v180+4]");
		object obj47 = num44 + 0;
		object obj48 = 0;
		while ((nint)obj48 <= 2)
		{
			object obj49 = obj48 + 1;
			nint num45 = (nint)typeof(UIBasicSprite);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ S0_v221 (Il2CppClass<UIBasicSprite>)+BA]");
			object obj50 = (nint)0 & (nint)0x200;
			if (obj50 != null)
			{
				nint num46 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S0_v465 (Il2CppClass<UIBasicSprite>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj51 = mTempPos + 16;
			object obj52 = obj48 << 3;
			object obj53 = obj51 + obj52;
			object obj54 = mTempPos + 16;
			object obj55 = obj49 << 3;
			object obj56 = obj54 + obj55;
			nint num47 = (nint)typeof(Math);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S2_v72 (Il2CppClass<System.Math>)+BA]");
			if ((int)((nint)0 & (nint)0x200) != 0)
			{
				nint num48 = (nint)typeof(Math);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ S2_v110 (Il2CppClass<System.Math>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value5 = (float)obj53 - (float)obj56;
			float num49 = Math.Abs(value5);
			if (num49 < 1E-05f)
			{
				break;
			}
			int num50 = 0;
			while (num50 <= 2)
			{
				int num51 = num50 + 1;
				nint num52 = (nint)typeof(UIBasicSprite);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ S0_v243 (Il2CppClass<UIBasicSprite>)+BA]");
				object obj57 = (nint)0 & (nint)0x200;
				if (obj57 != null)
				{
					nint num53 = (nint)typeof(UIBasicSprite);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ S0_v459 (Il2CppClass<UIBasicSprite>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj58 = mTempPos + 16;
				object obj59 = obj48 << 3;
				object obj60 = obj58 + obj59;
				object obj61 = mTempPos + 16;
				int num54 = num50 << 3;
				object obj62 = obj61 + num54;
				obj2 = 0;
				_ = 0;
				obj2 = obj60;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S0_v258+4]");
				_ = 0;
				_ = 0f;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector8 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
				((Vector3*)(nint)vector8)->z = 0f;
				verts.Add(vector);
				object obj63 = mTempPos + 16;
				object obj64 = obj48 << 3;
				object obj65 = obj63 + obj64;
				object obj66 = mTempPos + 16;
				int num55 = num51 << 3;
				object obj67 = obj66 + num55;
				obj3 = 0;
				_ = 0;
				obj3 = obj65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v940 @ S0_v282+4]");
				_ = 0;
				_ = 0f;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Vector3 vector9 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
				((Vector3*)(nint)vector9)->z = 0f;
				verts.Add(vector);
				object obj68 = mTempPos + 16;
				object obj69 = obj49 << 3;
				object obj70 = obj68 + obj69;
				object obj71 = mTempPos + 16;
				int num56 = num51 << 3;
				object obj72 = obj71 + num56;
				obj4 = 0;
				_ = 0;
				obj4 = obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S0_v306+4]");
				_ = 0;
				_ = 0f;
				((Vector3*)(nint)vector)->x = (float)obj4;
				Vector3 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				verts.Add(vector);
				object obj73 = mTempPos + 16;
				object obj74 = obj49 << 3;
				object obj75 = obj73 + obj74;
				object obj76 = mTempPos + 16;
				int num57 = num50 << 3;
				object obj77 = obj76 + num57;
				obj5 = 0;
				_ = 0;
				obj5 = obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1033 @ S0_v330+4]");
				_ = 0;
				_ = 0f;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Vector3 vector11 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
				((Vector3*)(nint)vector11)->z = 0f;
				verts.Add(vector);
				object obj78 = mTempUVs + 16;
				object obj79 = obj48 << 3;
				object obj80 = obj78 + obj79;
				object obj81 = mTempUVs + 16;
				int num58 = num50 << 3;
				object obj82 = obj81 + num58;
				obj6 = 0;
				obj6 = obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1079 @ S0_v354+4]");
				_ = 0;
				obj9 = obj6;
				((Vector3*)(nint)vector)->x = (float)obj9;
				uvs.Add(vector);
				object obj83 = mTempUVs + 16;
				object obj84 = obj48 << 3;
				object obj85 = obj83 + obj84;
				object obj86 = mTempUVs + 16;
				int num59 = num51 << 3;
				object obj87 = obj86 + num59;
				obj7 = 0;
				obj7 = obj85;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ S0_v376+4]");
				_ = 0;
				obj10 = obj7;
				((Vector3*)(nint)vector)->x = (float)obj10;
				uvs.Add(vector);
				object obj88 = mTempUVs + 16;
				object obj89 = obj49 << 3;
				object obj90 = obj88 + obj89;
				object obj91 = mTempUVs + 16;
				int num60 = num51 << 3;
				object obj92 = obj91 + num60;
				obj8 = 0;
				obj8 = obj90;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ S0_v398+4]");
				_ = 0;
				obj11 = obj8;
				((Vector3*)(nint)vector)->x = (float)obj11;
				uvs.Add(vector);
				object obj93 = mTempUVs + 16;
				object obj94 = obj49 << 3;
				object obj95 = obj93 + obj94;
				object obj96 = mTempUVs + 16;
				int num61 = num50 << 3;
				object obj97 = obj96 + num61;
				obj = 0;
				obj = obj95;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1204 @ S0_v420+4]");
				_ = 0;
				obj12 = obj;
				((Vector3*)(nint)vector)->x = (float)obj12;
				uvs.Add(vector);
				if (~(mApplyGradient ? 1u : 0u) == 0)
				{
					SetScreenRect((int)cols, (int)uIDrawCall, 0, num50);
					SetScreenRect((int)cols, (int)uIDrawCall, 0, num51);
					SetScreenRect((int)cols, (int)uIDrawCall, 0, num51);
					SetScreenRect((int)cols, (int)uIDrawCall, 0, num50);
				}
				else
				{
					((Vector3*)(nint)vector)->x = (float)uIDrawCall;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
					cols.Add((Color)vector);
					((Vector3*)(nint)vector)->x = (float)uIDrawCall;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
					cols.Add((Color)vector);
					((Vector3*)(nint)vector)->x = (float)uIDrawCall;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
					cols.Add((Color)vector);
					((Vector3*)(nint)vector)->x = (float)uIDrawCall;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)uIDrawCall).m_CachedPtr;
					cols.Add((Color)vector);
				}
				int num62 = num50 + 1;
				num50 = num62;
			}
			object obj98 = obj48 + 1;
			obj48 = obj98;
		}
	}

	private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return false;
	}

	private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private static void Fill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	protected UIBasicSprite()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected Obj, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		topAnchor = (AnchorPoint)10f;
		CancelInvoke();
	}

	static UIBasicSprite()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int s_Hash = default;
		PropertyReference.s_Hash = s_Hash;
	}
}
