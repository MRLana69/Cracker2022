using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIProgressBar : UIWidgetContainer
{
	public enum FillDirection
	{
		LeftToRight,
		RightToLeft,
		BottomToTop,
		TopToBottom
	}

	public delegate void OnDragFinished();

	public static UIProgressBar current;

	public OnDragFinished onDragFinished;

	public Transform thumb;

	protected UIWidget mBG;

	protected UIWidget mFG;

	protected float mValue;

	protected FillDirection mFill;

	[NonSerialized]
	protected bool mStarted;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected bool mIsDirty;

	[NonSerialized]
	protected Camera mCam;

	[NonSerialized]
	protected float mOffset;

	public int numberOfSteps;

	public List<EventDelegate> onChange;

	public Transform cachedTransform
	{
		get
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Transform transform = default;
			((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
			object obj = transform + 16;
			obj = this;
			return transform;
		}
	}

	public Camera cachedCamera
	{
		get
		{
			//IL_0082: Expected I, but got Obj
			//IL_0098: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mTrans != null)
			{
				object obj2 = this + 40;
				GameObject gameObject = base.gameObject;
				obj2 = gameObject;
			}
			return (Camera)(object)mTrans;
		}
	}

	public unsafe UIWidget foregroundWidget
	{
		get
		{
			//IL_010a: Expected I, but got Obj
			//IL_0120: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_007c: Expected I, but got Obj
			//IL_0092: Expected Obj, but got I
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected Obj, but got Unknown
			//IL_0158: Expected Obj, but got I4
			//IL_00bd: Expected I, but got Obj
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
			if (mCam != null)
			{
				string text = tag;
				bool activeSelf = ((GameObject)(object)text).activeSelf;
				nint num3 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<NGUITools>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v21 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj3 = this + 48;
				string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
				obj3 = typeName;
			}
			return (UIWidget)(object)mCam;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Obj, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00d5: Expected Obj, but got I4
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Expected I4, but got Unknown
			//IL_011e: Expected I4, but got Obj
			//IL_0157: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 80;
			obj = 0;
			_ = 0;
			object obj3 = obj2 - -64;
			object obj4 = value + 80;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7+8]");
			_ = 0;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			object obj5 = obj2 + 48;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
			_ = 0;
			object obj6 = obj2 + 32;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			object obj7 = obj2 + 16;
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			obj2 = 0;
			_ = 0;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23+8]");
			_ = 0;
			_ = 0f;
			UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 96);
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			value.rawPivot = pivot;
			string widget = value.tag;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			TweenHeight tweenHeight = TweenHeight.Begin((UIWidget)(object)widget, 0.15f, (int)pivot);
			tweenHeight.method = UITweener.Method.EaseOut;
		}
	}

	public UIWidget backgroundWidget
	{
		get
		{
			return mFG;
		}
		set
		{
			//IL_0083: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFG).FindKernel((string)(object)value) != 0)
			{
				object obj2 = this + 24;
				obj2 = value;
				mIsDirty = true;
			}
		}
	}

	public FillDirection fillDirection
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (FillDirection)mBG;
		}
		set
		{
			//IL_0083: Expected I, but got Obj
			//IL_0099: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_0065: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mBG).FindKernel((string)value) != 0)
			{
				object obj2 = this + 20;
				obj2 = value;
				mIsDirty = true;
			}
		}
	}

	public float value
	{
		get
		{
			//IL_0129: Expected I, but got Obj
			//IL_013f: Expected Obj, but got I
			//IL_03ea: Expected Obj, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected Obj, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected Obj, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Expected Obj, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_0071: Expected I, but got Obj
			//IL_0087: Expected Obj, but got I
			//IL_016a: Expected I, but got Obj
			//IL_01ba: Expected Obj, but got I
			//IL_01cc: Expected I, but got Obj
			//IL_01e2: Expected Obj, but got I
			//IL_00b2: Expected I, but got Obj
			//IL_0415: Expected Obj, but got I4
			//IL_020d: Expected I, but got Obj
			//IL_025d: Expected Obj, but got I
			//IL_026a: Expected Obj, but got I4
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Expected Obj, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected Obj, but got Unknown
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected Obj, but got Unknown
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Expected Obj, but got Unknown
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Expected Obj, but got Unknown
			//IL_02ff: Expected Obj, but got I
			//IL_030b: Invalid comparison between Obj and F4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIProgressBar)+88]");
			if ((nint)0 != 0)
			{
				List<EventDelegate> list = onChange;
				object obj = this + 72;
				UIWidget uIWidget = mFG;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S2_v14+4]");
				object obj2 = uIWidget + 0;
				object obj3 = list._size * obj2;
				object obj4 = this + 72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v45+4]");
				object obj5 = obj3 + 0;
				nint num = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v47 (Il2CppClass<NGUITools>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num2 = (nint)typeof(NGUITools);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v58 (Il2CppClass<NGUITools>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				PropertyBinding propertyBinding = default;
				propertyBinding.Start();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (PropertyBinding)+4]");
				if ((nint)obj5 > 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (PropertyBinding)+4]");
					return 0f / (float)obj5;
				}
				return 1f;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIProgressBar)+9C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIProgressBar)+9C]");
				bool isFullyAnchored = ((UIRect)0).isFullyAnchored;
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)isFullyAnchored).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIProgressBar)+9C]");
					bool isFullyAnchored2 = ((UIRect)0).isFullyAnchored;
					if (((Camera)isFullyAnchored2).transparencySortMode != TransparencySortMode.Default)
					{
						List<EventDelegate> list2 = onChange;
						object obj9 = this + 72;
						UIWidget uIWidget2 = mFG;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S2_v9+4]");
						object obj10 = uIWidget2 + 0;
						object obj11 = list2._size * obj10;
						object obj12 = this + 72;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v26+4]");
						object obj13 = obj11 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIProgressBar)+9C]");
						float pixelSizeAdjustment = ((UIRoot)0).pixelSizeAdjustment;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)pixelSizeAdjustment))
						{
							return pixelSizeAdjustment / (float)obj13;
						}
						return 1f;
					}
					return 1f;
				}
				return 1f;
			}
			return 1f;
		}
		set
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_009b: Expected Obj, but got F4
			if ((object)mFG == null)
			{
				return;
			}
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)onDragFinished).FindKernel((string)null) != 0)
			{
				object obj2 = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				object parameter = default;
				((GameObject)(object)onDragFinished).BroadcastMessage("OnScroll", parameter, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public float alpha
	{
		get
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_00d7: Expected Obj, but got I4
			//IL_0102: Expected Obj, but got I4
			//IL_0054: Expected I, but got Obj
			bool flag = numberOfSteps > 1;
			bool flag2 = !flag;
			float result = mValue;
			if (!flag2)
			{
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v15 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v23 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj2 = numberOfSteps - 1;
				float num3 = mValue * (float)obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj3 = numberOfSteps - 1;
				object obj4 = default;
				float num4 = (float)obj4 / (float)obj3;
				result = num4;
			}
			return result;
		}
		set
		{
			((TweenAlpha)(object)this).OnUpdate(value, true);
		}
	}

	protected bool isHorizontal => (byte)mFill != 0;

	protected bool isInverted
	{
		get
		{
			if (mFill != FillDirection.LeftToRight)
			{
				return mFill == FillDirection.RightToLeft;
			}
			return true;
		}
	}

	public unsafe void Set(float val, bool notify = true)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0076: Expected Obj, but got I4
		//IL_0097: Invalid comparison between I4 and F4
		//IL_00de: Invalid comparison between Obj and F4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I4
		//IL_00c0: Expected I4, but got F4
		//IL_00cf: Expected Obj, but got F4
		object obj2 = default;
		object obj = obj2 + 24;
		obj = ((bool*)(notify ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [notify @ L2 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F43B");
		object obj3 = obj2 + 12;
		obj3 = ((bool*)(notify ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [notify @ L2 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F43B");
		obj2 = ((bool*)(notify ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [notify @ L2 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F43B");
		if ((float)(mIsDirty ? 1 : 0) > val)
		{
			mIsDirty = (byte)(int)val != 0;
		}
		if (System.Runtime.CompilerServices.Unsafe.As<Camera, UIntPtr>(ref mCam) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)val))
		{
			mCam = (Camera)val;
		}
		string text = (string)(obj2 + 36);
		text = (string)((bool*)(notify ? 1 : 0))->m_value;
		string text2 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [notify @ L2 (System.Boolean)+8]");
		text2.m_stringLength = 0;
		((FPSLog)(object)this).SetLastRunResult = text;
	}

	public unsafe void Start()
	{
		//IL_024a: Expected Obj, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0063: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got F4
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected VT, but got Unknown
		//IL_02a5: Expected F4, but got Obj
		//IL_02a0: Expected native int or pointer, but got VT
		//IL_02cc: Expected F4, but got Obj
		//IL_02c7: Expected native int or pointer, but got VT
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_02fa: Expected F4, but got Obj
		//IL_02f5: Expected native int or pointer, but got VT
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got F4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_0119: Expected F4, but got Obj
		//IL_0114: Expected native int or pointer, but got VT
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got F4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_0171: Expected Obj, but got F4
		//IL_0190: Expected F4, but got Obj
		//IL_018b: Expected native int or pointer, but got VT
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected Obj, but got Unknown
		//IL_01b5: Expected Obj, but got F4
		//IL_00cd: Expected I, but got Obj
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected Obj, but got Unknown
		mFG = (UIWidget)16;
		numberOfSteps = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		object obj = this + 60;
		obj = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<object> list2 = default;
		list2._002Ector();
		object obj2 = this - -64;
		obj2 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Action> list3 = default;
		list3._002Ector();
		object obj3 = this + 68;
		obj3 = list3;
		object obj5 = default;
		object obj4 = obj5 + 56;
		obj4 = 0;
		_ = 0;
		obj4 = 4f;
		_ = 4f;
		_ = 0f;
		nint num = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v84 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 vector = (Vector2)(obj5 + 72);
		((Vector2*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v26+8]");
		_ = 0;
		Vector3 vector2 = vector;
		((Vector2*)(nint)vector)->x = (float)obj5;
		_ = vector.x;
		object obj7 = obj5 + 40;
		Color black = Color.black;
		((Vector2*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v43+8]");
		_ = 0;
		object obj8 = this + 80;
		obj8 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (UnityEngine.Vector2)+8]");
		_ = 0;
		object obj9 = obj5 + 24;
		Color black2 = Color.black;
		((Vector2*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v50+8]");
		_ = 0;
		object obj10 = this + 96;
		obj10 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (UnityEngine.Vector2)+8]");
		_ = 0;
		object obj11 = obj5 + 8;
		obj11 = 0;
		_ = 0;
		obj11 = 225f / 255f;
		_ = 200f / 255f;
		_ = 150f / 255f;
		_ = 1f;
		((Vector2*)(nint)vector)->x = (float)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v57+8]");
		_ = 0;
		object obj12 = this + 112;
		obj12 = vector.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v37 (UnityEngine.Vector2)+8]");
		_ = 0;
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<EventDelegate> list4 = default;
		list4._002Ector();
		object obj13 = this + 148;
		obj13 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UILabel> list5 = default;
		list5._002Ector();
		object obj14 = this + 172;
		obj14 = list5;
		object obj15 = this + 196;
		obj15 = "OnSelectionChange";
		base._002Ector();
	}

	protected virtual void Upgrade()
	{
		//IL_0053: Expected I, but got Obj
		//IL_0069: Expected Obj, but got I
		//IL_0269: Expected I, but got Obj
		//IL_027f: Expected Obj, but got I
		//IL_0094: Expected I, but got Obj
		//IL_00fe: Expected I, but got Obj
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_01b1: Expected I, but got Obj
		if (~(mStarted ? 1u : 0u) == 0)
		{
			return;
		}
		mStarted = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mBG).FindKernel((string)null) != 0)
			{
				UIWidget uIWidget = mBG;
				uIWidget.autoResizeBoxCollider = true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (current != null && onChange != null)
			{
				current = this;
				nint num5 = (nint)typeof(EventDelegate);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v23 (Il2CppClass<EventDelegate>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(EventDelegate);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v29 (Il2CppClass<EventDelegate>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Localization.dictionary = (Dictionary<string, string[]>)(object)onChange;
				current = null;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	protected virtual void OnStart()
	{
	}

	protected void Update()
	{
	}

	protected void OnValidate()
	{
		if (~(mIsDirty ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected float ScreenToValue(Vector2 screenPos)
	{
		//IL_0009: Invalid comparison between VT and I4
		//IL_0060: Invalid comparison between VT and I4
		float result = ((screenPos != (Vector2)(object)1) ? 0f : 1f);
		if (screenPos == (Vector2)(object)0)
		{
			result = 0.35f;
		}
		return result;
	}

	protected unsafe virtual float LocalToValue(Vector2 localPos)
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_026e: Expected Obj, but got F4
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected Obj, but got Unknown
		//IL_02b6: Expected VT, but got Obj
		//IL_02c4: Expected I, but got Obj
		//IL_02da: Expected Obj, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		//IL_031c: Expected I, but got Obj
		//IL_0332: Expected Obj, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected VT, but got Unknown
		//IL_036a: Expected F4, but got Obj
		//IL_0365: Expected native int or pointer, but got VT
		//IL_037c: Expected F4, but got I
		//IL_0377: Expected native int or pointer, but got VT
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected VT, but got Unknown
		//IL_0397: Expected F4, but got Obj
		//IL_0392: Expected native int or pointer, but got VT
		//IL_03ac: Expected F4, but got I
		//IL_03a7: Expected native int or pointer, but got VT
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected VT, but got Unknown
		//IL_03cb: Expected Ref, but got VT
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected Obj, but got Unknown
		//IL_03e6: Expected VT, but got Obj
		//IL_03f3: Expected native int or pointer, but got VT
		//IL_0405: Expected native int or pointer, but got VT
		//IL_0417: Expected F4, but got Obj
		//IL_0412: Expected native int or pointer, but got VT
		//IL_0429: Expected F4, but got I
		//IL_0424: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected Obj, but got Unknown
		//IL_0453: Expected Obj, but got F4
		//IL_0460: Expected F4, but got Obj
		//IL_045b: Expected native int or pointer, but got VT
		//IL_047a: Expected native int or pointer, but got VT
		//IL_048c: Expected native int or pointer, but got VT
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected Obj, but got Unknown
		//IL_04b0: Expected Ref, but got VT
		//IL_04dc: Expected F4, but got Obj
		//IL_04d7: Expected native int or pointer, but got VT
		//IL_04ee: Expected F4, but got I
		//IL_04e9: Expected native int or pointer, but got VT
		//IL_00f8: Expected I, but got Obj
		//IL_016b: Expected native int or pointer, but got VT
		//IL_017d: Expected native int or pointer, but got VT
		//IL_0193: Expected Ref, but got VT
		//IL_01a6: Expected I, but got Obj
		//IL_01bc: Expected Obj, but got I
		//IL_0517: Expected F4, but got Obj
		//IL_0512: Expected native int or pointer, but got VT
		//IL_0529: Expected F4, but got I
		//IL_0524: Expected native int or pointer, but got VT
		//IL_0543: Expected F4, but got Obj
		//IL_053e: Expected native int or pointer, but got VT
		//IL_01e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 128;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 120;
		obj3 = 0f;
		object obj4 = obj2 + 96;
		obj4 = 0;
		_ = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 80);
		Camera camera = cachedCamera;
		transform.rotation = (Quaternion)camera;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v101 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 - -64;
		Vector3 up = Vector3.up;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v27 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v97 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 144);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 160);
		((Vector3*)(nint)vector2)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v25+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Quaternion quaternion = (Quaternion)(obj2 + 52);
		((Quaternion*)quaternion)->SetLookRotation(vector, vector2);
		Transform transform2 = (Transform)(obj2 + 40);
		transform2.position = (Vector3)camera;
		((Vector3*)(nint)vector)->x = quaternion.x;
		((Vector3*)(nint)vector)->z = quaternion.z;
		((Vector3*)(nint)vector2)->x = (float)transform2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D0");
		UIWidget uIWidget = foregroundWidget;
		nint num5 = (nint)typeof(Vector2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v51 (Il2CppClass<UnityEngine.Vector2>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ S0_v93 (Il2CppClass<UnityEngine.Vector2>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj2 + 8;
		obj9 = localPos.x;
		((Vector3*)(nint)vector2)->x = (float)obj9;
		Vector3 vector3 = (Vector4)vector2;
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		Camera camera2 = (Camera)(obj2 + 16);
		camera2.ScreenToViewportPoint_Injected(ref *(Vector3*)uIWidget, out *(Vector3*)vector2);
		obj4 = camera2;
		_ = ((UnityEngine.Object)camera2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v62 (UnityEngine.Camera)+10]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)camera2;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)camera2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v62 (UnityEngine.Camera)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F8D6");
		object obj10 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F969");
			((Vector3*)(nint)vector2)->x = vector.x;
			((Vector3*)(nint)vector2)->z = vector.z;
			transform.Internal_LookAt_Injected(ref *(Vector3*)camera, ref *(Vector3*)vector2);
			nint num7 = (nint)typeof(Vector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v79 (Il2CppClass<UnityEngine.Vector2>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num8 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v89 (Il2CppClass<UnityEngine.Vector2>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)transform;
			((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
			Vector3 vector4 = (Vector2)vector2;
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8C49");
			float result = default;
			return result;
		}
		return alpha;
	}

	public virtual void ForceUpdate()
	{
		//IL_02f0: Expected I, but got Obj
		//IL_0306: Expected Obj, but got I
		//IL_01b4: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_01f5: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v66 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (NGUITools.GetActive((GameObject)(object)this))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			mIsDirty = true;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v42 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v62 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num5;
			if (mValue < 0f)
			{
				num5 = 0f;
			}
			else
			{
				num5 = ((!(mValue > 1f)) ? mValue : 1f);
			}
			if (mValue != num5)
			{
				mValue = num5;
			}
			if (numberOfSteps > -1)
			{
				if (numberOfSteps >= 22)
				{
					numberOfSteps = 21;
				}
			}
			else
			{
				numberOfSteps = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			return;
		}
		nint num6 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v33 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num8;
		if (mValue < 0f)
		{
			num8 = 0f;
		}
		else
		{
			num8 = ((!(mValue > 1f)) ? mValue : 1f);
		}
		if (mValue != num8)
		{
			mValue = num8;
		}
		if (numberOfSteps <= -1)
		{
			numberOfSteps = 0;
		}
		else if (numberOfSteps > 21)
		{
			numberOfSteps = 21;
		}
	}

	protected void SetThumbPosition(Vector3 worldPos)
	{
		//IL_000a: Invalid comparison between I4 and VT
		//IL_0036: Expected I4, but got VT
		if ((object)mFill != (object)worldPos)
		{
			mFill = (FillDirection)worldPos;
			if (~(mStarted ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
		}
	}

	public unsafe virtual void OnPan(Vector2 delta)
	{
		//IL_030d: Expected I, but got Obj
		//IL_0323: Expected Obj, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected Ref, but got Unknown
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected VT, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_021c: Expected VT, but got Obj
		//IL_0229: Expected Obj, but got F4
		//IL_0244: Expected I, but got Obj
		//IL_025a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_049c: Expected F4, but got Obj
		//IL_0497: Expected native int or pointer, but got VT
		//IL_04ae: Expected F4, but got I
		//IL_04a9: Expected native int or pointer, but got VT
		//IL_04d0: Expected VT, but got Ref
		//IL_005f: Expected Ref, but got F4
		//IL_008a: Expected F4, but got Obj
		//IL_0085: Expected native int or pointer, but got VT
		//IL_00b4: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		//IL_0285: Expected I, but got Obj
		//IL_03d1: Expected native int or pointer, but got VT
		//IL_03e3: Expected Obj, but got F4
		//IL_0402: Expected native int or pointer, but got VT
		//IL_041c: Expected VT, but got Obj
		//IL_02d1: Expected Ref, but got F4
		//IL_02e7: Expected Obj, but got Ref
		//IL_0141: Expected Obj, but got F4
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_00f5: Expected I, but got Obj
		//IL_042e: Expected F4, but got Obj
		//IL_0429: Expected native int or pointer, but got VT
		//IL_0440: Expected F4, but got I
		//IL_043b: Expected native int or pointer, but got VT
		//IL_0462: Expected VT, but got Ref
		//IL_019d: Expected I, but got Obj
		//IL_01e9: Expected Ref, but got F4
		//IL_01ff: Expected Obj, but got Ref
		Transform parentInternal = thumb.parentInternal;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		ref Vector3 reference = ref *(Vector3*)(obj2 + 72);
		Quaternion quaternion = (Quaternion)(obj2 + 60);
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 36;
		object obj4 = obj2 + 24;
		Transform transform2 = (Transform)(obj2 + 12);
		if (((ComputeShader)(object)parentInternal).FindKernel((string)null) != 0)
		{
			reference = ref *(Vector3*)delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
			_ = 0;
			transform.Internal_LookAt_Injected(ref *(Vector3*)parentInternal, ref reference);
			((Vector2*)(nint)delta)->x = (float)transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			obj3 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			nint num3 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v63 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v94 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			float x = default;
			((Vector2*)(nint)delta)->x = x;
			obj4 = delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			float y = default;
			((Vector2*)(nint)delta)->y = y;
			_ = 0f;
			transform2.localPosition = (Vector3)thumb;
			obj2 = delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
			_ = 0;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S0_v76 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v90 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Quaternion*)(nint)quaternion)->x = (float)transform2;
			((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
			reference = ref *(Vector3*)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			float num7 = Quaternion.Dot(quaternion, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
			if (num7 > 0.001f)
			{
				reference = ref *(Vector3*)delta.x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
				_ = 0;
				Vector3 eulerAngles = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).eulerAngles;
			}
			return;
		}
		transform.position = (Vector3)thumb;
		obj3 = delta.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
		_ = 0;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Quaternion*)(nint)quaternion)->x = (float)transform;
		((Quaternion*)(nint)quaternion)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		reference = ref *(Vector3*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
		_ = 0;
		float num10 = Quaternion.Dot(quaternion, (Quaternion)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		if (num10 > 1E-05f)
		{
			reference = ref *(Vector3*)delta.x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [delta @ L1 (UnityEngine.Vector2)+8]");
			_ = 0;
			Vector3 localPosition = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).localPosition;
		}
	}

	public unsafe UIProgressBar()
	{
		//IL_1ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf0: Expected Obj, but got Unknown
		//IL_1cf9: Expected Obj, but got I4
		//IL_1d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0d: Expected Obj, but got Unknown
		//IL_1d16: Expected Obj, but got I4
		//IL_1d25: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2a: Expected Obj, but got Unknown
		//IL_1d33: Expected Obj, but got I4
		//IL_1d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d47: Expected Obj, but got Unknown
		//IL_1d50: Expected Obj, but got I4
		//IL_1d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d64: Expected Obj, but got Unknown
		//IL_1d6d: Expected Obj, but got I4
		//IL_1d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d81: Expected Obj, but got Unknown
		//IL_1d8a: Expected Obj, but got I4
		//IL_1d99: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9e: Expected Obj, but got Unknown
		//IL_1da7: Expected Obj, but got I4
		//IL_1db6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbb: Expected Obj, but got Unknown
		//IL_1dc4: Expected Obj, but got I4
		//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd8: Expected Obj, but got Unknown
		//IL_1de1: Expected Obj, but got I4
		//IL_1df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1df5: Expected Obj, but got Unknown
		//IL_1dfe: Expected Obj, but got I4
		//IL_1e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e12: Expected Obj, but got Unknown
		//IL_1e1b: Expected Obj, but got I4
		//IL_1e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2f: Expected Obj, but got Unknown
		//IL_1e38: Expected Obj, but got I4
		//IL_1e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4c: Expected Obj, but got Unknown
		//IL_1e55: Expected Obj, but got I4
		//IL_1e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e69: Expected Obj, but got Unknown
		//IL_1e72: Expected Obj, but got I4
		//IL_1e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e86: Expected Obj, but got Unknown
		//IL_1e8f: Expected Obj, but got I4
		//IL_1e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea3: Expected Obj, but got Unknown
		//IL_1eac: Expected Obj, but got I4
		//IL_1ebb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec0: Expected Obj, but got Unknown
		//IL_1ec9: Expected Obj, but got I4
		//IL_1ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1edd: Expected Obj, but got Unknown
		//IL_1ee6: Expected Obj, but got I4
		//IL_1f05: Expected I, but got Obj
		//IL_1f1b: Expected Obj, but got I
		//IL_2855: Unknown result type (might be due to invalid IL or missing references)
		//IL_285a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_1fc3: Expected I, but got Obj
		//IL_1fd9: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_2890: Unknown result type (might be due to invalid IL or missing references)
		//IL_2895: Expected VT, but got Unknown
		//IL_289e: Unknown result type (might be due to invalid IL or missing references)
		//IL_28a3: Expected Obj, but got Unknown
		//IL_28ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b1: Expected Obj, but got Unknown
		//IL_28ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_28bf: Expected Obj, but got Unknown
		//IL_28c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_28cd: Expected Obj, but got Unknown
		//IL_28d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_28db: Expected Obj, but got Unknown
		//IL_05e0: Expected I, but got Obj
		//IL_1f71: Expected I, but got Obj
		//IL_1f87: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_062d: Expected I, but got Obj
		//IL_0643: Expected Obj, but got I
		//IL_0749: Expected I, but got Obj
		//IL_075f: Expected Obj, but got I
		//IL_066e: Expected I, but got Obj
		//IL_06bb: Expected I, but got Obj
		//IL_06d1: Expected Obj, but got I
		//IL_078a: Expected I, but got Obj
		//IL_03b8: Expected I, but got Obj
		//IL_2337: Expected I, but got Obj
		//IL_234d: Expected Obj, but got I
		//IL_06fc: Expected I, but got Obj
		//IL_019c: Expected I, but got Obj
		//IL_07f5: Expected I, but got Obj
		//IL_0573: Expected Obj, but got I4
		//IL_058a: Expected Obj, but got F4
		//IL_059e: Expected I, but got F4
		//IL_05ab: Expected Obj, but got F4
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected Obj, but got Unknown
		//IL_08d4: Expected F4, but got Obj
		//IL_08cf: Expected native int or pointer, but got VT
		//IL_08e9: Expected F4, but got I
		//IL_08e4: Expected native int or pointer, but got VT
		//IL_0905: Expected Obj, but got F4
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected Obj, but got Unknown
		//IL_0938: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected Obj, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected Obj, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected Obj, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected Obj, but got Unknown
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected Obj, but got Unknown
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected Obj, but got Unknown
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected Obj, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a53: Expected Obj, but got Unknown
		//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7d: Expected Obj, but got Unknown
		//IL_0a93: Expected I, but got Obj
		//IL_0aa9: Expected Obj, but got I
		//IL_051d: Expected Obj, but got I4
		//IL_0534: Expected Obj, but got F4
		//IL_0557: Expected I, but got F4
		//IL_0565: Expected Obj, but got F4
		//IL_0349: Expected Obj, but got I4
		//IL_0360: Expected Obj, but got F4
		//IL_0373: Expected I, but got F4
		//IL_0381: Expected Obj, but got F4
		//IL_2925: Expected Obj, but got I4
		//IL_02f3: Expected Obj, but got I4
		//IL_0319: Expected Obj, but got F4
		//IL_032d: Expected I, but got F4
		//IL_033b: Expected Obj, but got F4
		//IL_0ad4: Expected I, but got Obj
		//IL_23da: Expected Obj, but got I4
		//IL_2219: Expected Obj, but got I4
		//IL_20da: Expected Obj, but got I4
		//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected Obj, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Expected Obj, but got Unknown
		//IL_0b67: Expected F4, but got Obj
		//IL_0b62: Expected native int or pointer, but got VT
		//IL_0b7c: Expected F4, but got I
		//IL_0b77: Expected native int or pointer, but got VT
		//IL_0b89: Expected Obj, but got F4
		//IL_0b9b: Expected I, but got F4
		//IL_0ba8: Expected VT, but got Obj
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd7: Expected Obj, but got Unknown
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be5: Expected Obj, but got Unknown
		//IL_0c0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c12: Expected Obj, but got Unknown
		//IL_143f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1444: Expected Obj, but got Unknown
		//IL_1462: Unknown result type (might be due to invalid IL or missing references)
		//IL_1467: Expected Obj, but got Unknown
		//IL_148a: Expected I, but got Obj
		//IL_14a0: Expected Obj, but got I
		//IL_2645: Expected F4, but got Obj
		//IL_2640: Expected native int or pointer, but got VT
		//IL_265a: Expected F4, but got I
		//IL_2655: Expected native int or pointer, but got VT
		//IL_2689: Expected VT, but got Obj
		//IL_26ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b0: Expected Obj, but got Unknown
		//IL_26ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d3: Expected Obj, but got Unknown
		//IL_26f5: Expected F4, but got Obj
		//IL_26f0: Expected native int or pointer, but got VT
		//IL_270a: Expected F4, but got I
		//IL_2705: Expected native int or pointer, but got VT
		//IL_2739: Expected VT, but got Obj
		//IL_2767: Expected F4, but got Obj
		//IL_2762: Expected native int or pointer, but got VT
		//IL_277c: Expected F4, but got I
		//IL_2777: Expected native int or pointer, but got VT
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected Obj, but got Unknown
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c93: Expected Obj, but got Unknown
		//IL_0cb6: Expected I, but got Obj
		//IL_0ccc: Expected Obj, but got I
		//IL_14cb: Expected I, but got Obj
		//IL_2430: Expected F4, but got Obj
		//IL_242b: Expected native int or pointer, but got VT
		//IL_2445: Expected F4, but got I
		//IL_2440: Expected native int or pointer, but got VT
		//IL_2474: Expected VT, but got Obj
		//IL_2496: Unknown result type (might be due to invalid IL or missing references)
		//IL_249b: Expected Obj, but got Unknown
		//IL_24b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24be: Expected Obj, but got Unknown
		//IL_24e0: Expected F4, but got Obj
		//IL_24db: Expected native int or pointer, but got VT
		//IL_24f5: Expected F4, but got I
		//IL_24f0: Expected native int or pointer, but got VT
		//IL_2524: Expected VT, but got Obj
		//IL_2552: Expected F4, but got Obj
		//IL_254d: Expected native int or pointer, but got VT
		//IL_2567: Expected F4, but got I
		//IL_2562: Expected native int or pointer, but got VT
		//IL_27b3: Expected Obj, but got F4
		//IL_0cf7: Expected I, but got Obj
		//IL_1573: Expected Obj, but got I4
		//IL_259e: Expected Obj, but got F4
		//IL_153b: Expected Obj, but got F4
		//IL_1560: Expected Obj, but got I4
		//IL_0d9f: Expected Obj, but got I4
		//IL_0d67: Expected Obj, but got F4
		//IL_0d8c: Expected Obj, but got I4
		//IL_1c52: Expected I, but got Obj
		//IL_1c68: Expected Obj, but got I
		//IL_2815: Expected F4, but got Obj
		//IL_2810: Expected native int or pointer, but got VT
		//IL_282a: Expected F4, but got I
		//IL_2825: Expected native int or pointer, but got VT
		//IL_13d0: Expected I, but got Obj
		//IL_13e6: Expected Obj, but got I
		//IL_2945: Expected VT, but got Obj
		//IL_2973: Expected VT, but got Obj
		//IL_1c93: Expected I, but got Obj
		//IL_2601: Expected F4, but got Obj
		//IL_25fc: Expected native int or pointer, but got VT
		//IL_2616: Expected F4, but got I
		//IL_2611: Expected native int or pointer, but got VT
		//IL_1411: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 312;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 300;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 288;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 272;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 256;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 240;
		obj7 = 0;
		_ = 0;
		object obj8 = obj2 + 228;
		obj8 = 0;
		_ = 0;
		object obj9 = obj2 + 216;
		obj9 = 0;
		_ = 0;
		object obj10 = obj2 + 204;
		obj10 = 0;
		_ = 0;
		object obj11 = obj2 + 192;
		obj11 = 0;
		_ = 0;
		object obj12 = obj2 + 180;
		obj12 = 0;
		_ = 0;
		object obj13 = obj2 + 168;
		obj13 = 0;
		_ = 0;
		object obj14 = obj2 + 156;
		obj14 = 0;
		_ = 0;
		object obj15 = obj2 + 144;
		obj15 = 0;
		_ = 0;
		object obj16 = obj2 + 132;
		obj16 = 0;
		_ = 0;
		object obj17 = obj2 + 120;
		obj17 = 0;
		_ = 0;
		object obj18 = obj2 + 108;
		obj18 = 0;
		_ = 0;
		object obj19 = obj2 + 96;
		obj19 = 0;
		_ = 0;
		mIsDirty = false;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v542 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget uIWidget = (UIWidget)(obj2 + 344);
		ComputeShader computeShader = default;
		bool flag;
		if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v384 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v538 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader.FindKernel(null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj22 = default;
				if ((nint)obj22 == 5)
				{
					float delta = alpha;
					((UIEventListener)(object)computeShader).OnScroll(delta);
					flag = false;
					goto IL_1fb5;
				}
			}
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v392 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			bool flag2 = obj23 == null;
			if (mFill == FillDirection.LeftToRight || mFill == FillDirection.RightToLeft)
			{
				if (!flag2)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v525 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (computeShader.FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj24 = default;
					if ((nint)obj24 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+124]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+124]");
							if ((nint)0 != 1)
							{
								goto IL_2064;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+124]");
						if ((nint)0 != 0)
						{
							_ = 0;
							_ = 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+12C]");
						bool flag3 = (nint)0 != 0;
						bool flag4 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
						object obj25 = flag3 ^ flag4;
						if (obj25 != null)
						{
							_ = 1;
						}
						goto IL_2064;
					}
				}
				bool flag5 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
				float num7 = alpha;
				if (flag5)
				{
					uIWidget = (UIWidget)0;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)0;
					float num8 = 1f - num7;
					uIWidget = (UIWidget)num8;
					_ = 0f;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)1f;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)1f;
				}
				else
				{
					uIWidget = (UIWidget)0;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)0f;
					_ = 0f;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)num7;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)1f;
				}
				obj5 = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				uIWidget = (UIWidget)obj5;
				UIWidget uIWidget2 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
				((UnityEngine.Object)uIWidget2).m_CachedPtr = (IntPtr)0;
			}
			else
			{
				if (!flag2)
				{
					nint num9 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ S0_v464 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (computeShader.FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object obj26 = default;
					if ((nint)obj26 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+124]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+124]");
							if ((nint)0 != 1)
							{
								goto IL_21a3;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+124]");
						if ((nint)0 != 1)
						{
							_ = 1;
							_ = 1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v382 (UnityEngine.ComputeShader)+12C]");
						bool flag6 = (nint)0 != 0;
						bool flag7 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
						object obj27 = flag6 ^ flag7;
						if (obj27 != null)
						{
							_ = 1;
						}
						goto IL_21a3;
					}
				}
				bool flag8 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
				float num10 = alpha;
				if (flag8)
				{
					uIWidget = (UIWidget)0;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)0f;
					float num11 = 1f - num10;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)1f;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)1f;
				}
				else
				{
					uIWidget = (UIWidget)0;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)0;
					uIWidget = (UIWidget)0f;
					_ = 0f;
					((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)1f;
					uIWidget.leftAnchor = (UIRect.AnchorPoint)num10;
				}
				obj6 = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				uIWidget = (UIWidget)obj6;
				UIWidget uIWidget3 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
				((UnityEngine.Object)uIWidget3).m_CachedPtr = (IntPtr)0;
			}
			Vector2 pivotOffset = uIWidget.pivotOffset;
			mFG.tag = (string)1;
			float num12 = alpha;
			flag = num12 < 0.001f;
		}
		else
		{
			flag = false;
		}
		goto IL_1fb5;
		IL_1cb8:
		if (flag)
		{
			mFG.tag = null;
		}
		return;
		IL_1fb5:
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v78 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v375 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 328);
		object obj29 = obj2 + 80;
		object obj30 = obj2 - -64;
		object obj31 = obj2 + 48;
		object obj32 = obj2 + 32;
		object obj33 = obj2 + 16;
		if (((ComputeShader)(object)thumb).FindKernel((string)null) != 0)
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj34 = (nint)0 & (nint)0x200;
			if (obj34 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S1_v412 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFG).FindKernel((string)null) == 0)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S1_v403 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num18 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ S1_v408 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mBG).FindKernel((string)null) == 0)
				{
					goto IL_1cb8;
				}
			}
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj36 = (nint)0 & (nint)0x200;
			if (obj36 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v367 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
			{
				UIWidget uIWidget4 = mFG;
			}
			else
			{
				UIWidget uIWidget4 = mBG;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num21 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ S1_v85 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj37 = (nint)0 & (nint)0x200;
			if (obj37 != null)
			{
				nint num22 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ S1_v394 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mFG).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @892A");
			}
			obj7 = uIWidget;
			_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
			obj = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
			_ = 0;
			object obj39 = default;
			object obj38 = obj39 + 16;
			uIWidget = (UIWidget)obj7;
			UIWidget uIWidget5 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v24+8]");
			((UnityEngine.Object)uIWidget5).m_CachedPtr = (IntPtr)0;
			object obj40 = obj38 + (object)uIWidget;
			obj38 = obj40;
			object obj41 = obj39 + 28;
			((Vector3*)(nint)vector)->x = (float)obj;
			Vector3 vector2 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			float num23 = (float)obj41 + vector.x;
			obj41 = num23;
			object obj42 = obj39 + 40;
			obj29 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v85+8]");
			object obj44 = obj43 - 0;
			obj42 = obj44;
			object obj45 = obj39 + 52;
			obj30 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj46 = obj45;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v87+8]");
			object obj47 = obj46 - 0;
			obj45 = obj47;
			object obj48 = obj39 + 20;
			obj31 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v89+4]");
			object obj50 = obj49 + 0;
			obj48 = obj50;
			object obj51 = obj39 + 32;
			obj32 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v91+C]");
			object obj53 = obj52 - 0;
			obj51 = obj53;
			object obj54 = obj39 + 44;
			obj33 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v93+C]");
			object obj56 = obj55 - 0;
			obj54 = obj56;
			object obj57 = obj39 + 56;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			object obj58 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj59 = obj58 + 0;
			obj57 = obj59;
			nint num24 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ S1_v156 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj60 = (nint)0 & (nint)0x200;
			if (obj60 != null)
			{
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v919 @ S1_v388 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIRect uIRect = ((((ComputeShader)(object)mFG).FindKernel((string)null) == 0) ? mBG : mFG);
			Camera anchorCamera = uIRect.anchorCamera;
			object obj61 = 0;
			while ((nint)obj61 <= 3)
			{
				object obj62 = obj39 + 16;
				object obj63 = obj61 * 12;
				object obj64 = obj62 + obj63;
				((Vector3*)(nint)vector)->x = (float)obj64;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v968 @ S1_v367+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				uIWidget = (UIWidget)vector.x;
				((UnityEngine.Object)uIWidget).m_CachedPtr = (IntPtr)vector.z;
				Vector3 vector4 = ((Transform)(object)anchorCamera).InverseTransformPoint((Vector3)uIWidget);
				uIWidget = (UIWidget)obj29;
				UIWidget uIWidget6 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v85+8]");
				((UnityEngine.Object)uIWidget6).m_CachedPtr = (IntPtr)0;
				object obj65 = obj39 + 16;
				object obj66 = obj61 * 12;
				object obj67 = obj65 + obj66;
				obj67 = uIWidget;
				_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
				object obj68 = obj61 + 1;
				obj61 = obj68;
			}
			float t;
			UIProgressBar uIProgressBar2;
			if (mFill == FillDirection.LeftToRight || mFill == FillDirection.RightToLeft)
			{
				object obj69 = obj39 + 16;
				obj29 = obj69;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ S1_v269+8]");
				_ = 0;
				object obj70 = obj39 + 28;
				obj30 = obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1025 @ S1_v274+8]");
				_ = 0;
				nint num26 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ S0_v272 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj71 = (nint)0 & (nint)0x200;
				if (obj71 != null)
				{
					nint num27 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ S0_v340 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj29;
				Vector3 vector5 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v85+8]");
				((Vector3*)(nint)vector5)->z = 0f;
				uIWidget = (UIWidget)obj30;
				UIWidget uIWidget7 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v87+8]");
				((UnityEngine.Object)uIWidget7).m_CachedPtr = (IntPtr)0;
				Vector3 vector6 = Vector3.LerpUnclamped(vector, (Vector3)uIWidget, 0.5f);
				obj3 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v89+8]");
				_ = 0;
				object obj72 = obj39 + 40;
				obj32 = obj72;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ S1_v293+8]");
				_ = 0;
				object obj73 = obj39 + 52;
				obj33 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ S1_v298+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj32;
				Vector3 vector7 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v91+8]");
				((Vector3*)(nint)vector7)->z = 0f;
				uIWidget = (UIWidget)obj33;
				UIWidget uIWidget8 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v93+8]");
				((UnityEngine.Object)uIWidget8).m_CachedPtr = (IntPtr)0;
				Vector3 vector8 = Vector3.LerpUnclamped(vector, (Vector3)uIWidget, 0.5f);
				uIWidget = (UIWidget)obj3;
				UIWidget uIWidget9 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((UnityEngine.Object)uIWidget9).m_CachedPtr = (IntPtr)0;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector9 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector9)->z = 0f;
				bool flag9 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
				obj10 = vector.x;
				_ = vector.z;
				obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				object obj74;
				UIProgressBar uIProgressBar;
				if (flag9)
				{
					obj8 = vector.x;
					_ = vector.z;
					obj9 = uIWidget;
					_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
					obj74 = 48;
					uIProgressBar = this;
				}
				else
				{
					obj74 = 0;
					uIProgressBar = null;
				}
				if (obj74 != null)
				{
					if ((nint)obj74 == 1 || (nint)obj74 == 2 || (nint)obj74 == 3 || (nint)obj74 == 4 || (nint)obj74 == 5 || (nint)obj74 == 6 || (nint)obj74 == 7 || (nint)obj74 == 8 || (nint)obj74 == 9 || (nint)obj74 == 10 || (nint)obj74 == 11 || (nint)obj74 == 12 || (nint)obj74 == 13 || (nint)obj74 == 14 || (nint)obj74 == 15 || (nint)obj74 == 16 || (nint)obj74 == 17 || (nint)obj74 == 18 || (nint)obj74 == 19 || (nint)obj74 == 20 || (nint)obj74 == 21 || (nint)obj74 == 22 || (nint)obj74 == 23 || (nint)obj74 == 24 || (nint)obj74 == 25 || (nint)obj74 == 26 || (nint)obj74 == 27 || (nint)obj74 == 28 || (nint)obj74 == 29 || (nint)obj74 == 30 || (nint)obj74 == 31 || (nint)obj74 == 32 || (nint)obj74 == 33 || (nint)obj74 == 34 || (nint)obj74 == 35 || (nint)obj74 == 36 || (nint)obj74 == 37 || (nint)obj74 == 38 || (nint)obj74 == 39 || (nint)obj74 == 40 || (nint)obj74 == 41 || (nint)obj74 == 42 || (nint)obj74 == 43 || (nint)obj74 == 44 || (nint)obj74 == 45 || (nint)obj74 == 46 || (nint)obj74 == 47 || (nint)obj74 != 48)
					{
						return;
					}
					float num28 = alpha;
					float num29 = 1f - num28;
					obj12 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27+8]");
					_ = 0;
					obj13 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v30+8]");
					_ = 0;
					t = num29;
					uIProgressBar2 = uIProgressBar;
				}
				else
				{
					float num30 = alpha;
					obj12 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33+8]");
					_ = 0;
					obj13 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36+8]");
					_ = 0;
					t = num30;
					uIProgressBar2 = this;
				}
				nint num31 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ S0_v304 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj75 = (nint)0 & (nint)0x200;
				if (obj75 != null)
				{
					nint num32 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ S0_v312 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj13;
				Vector3 vector10 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v42+8]");
				((Vector3*)(nint)vector10)->z = 0f;
				uIWidget = (UIWidget)obj12;
				UIWidget uIWidget10 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v39+8]");
				((UnityEngine.Object)uIWidget10).m_CachedPtr = (IntPtr)0;
			}
			else
			{
				object obj76 = obj39 + 16;
				obj29 = obj76;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ S1_v173+8]");
				_ = 0;
				object obj77 = obj39 + 52;
				obj30 = obj77;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ S1_v178+8]");
				_ = 0;
				nint num33 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ S0_v195 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj78 = (nint)0 & (nint)0x200;
				if (obj78 != null)
				{
					nint num34 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S0_v263 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj29;
				Vector3 vector11 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v85+8]");
				((Vector3*)(nint)vector11)->z = 0f;
				uIWidget = (UIWidget)obj30;
				UIWidget uIWidget11 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S0_v87+8]");
				((UnityEngine.Object)uIWidget11).m_CachedPtr = (IntPtr)0;
				Vector3 vector12 = Vector3.LerpUnclamped(vector, (Vector3)uIWidget, 0.5f);
				obj4 = obj31;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v89+8]");
				_ = 0;
				object obj79 = obj39 + 28;
				obj32 = obj79;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1161 @ S1_v197+8]");
				_ = 0;
				object obj80 = obj39 + 40;
				obj33 = obj80;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ S1_v202+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj32;
				Vector3 vector13 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v91+8]");
				((Vector3*)(nint)vector13)->z = 0f;
				uIWidget = (UIWidget)obj33;
				UIWidget uIWidget12 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v93+8]");
				((UnityEngine.Object)uIWidget12).m_CachedPtr = (IntPtr)0;
				Vector3 vector14 = Vector3.LerpUnclamped(vector, (Vector3)uIWidget, 0.5f);
				uIWidget = (UIWidget)obj4;
				UIWidget uIWidget13 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)uIWidget13).m_CachedPtr = (IntPtr)0;
				((Vector3*)(nint)vector)->x = (float)obj2;
				Vector3 vector15 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Vector3*)(nint)vector15)->z = 0f;
				bool flag10 = mFill == FillDirection.RightToLeft || mFill == FillDirection.TopToBottom;
				obj16 = vector.x;
				_ = vector.z;
				obj17 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				_ = 0;
				object obj81;
				UIProgressBar uIProgressBar3;
				if (flag10)
				{
					obj14 = vector.x;
					_ = vector.z;
					obj15 = uIWidget;
					_ = ((UnityEngine.Object)uIWidget).m_CachedPtr;
					obj81 = 54;
					uIProgressBar3 = this;
				}
				else
				{
					obj81 = 0;
					uIProgressBar3 = null;
				}
				if (obj81 != null)
				{
					if ((nint)obj81 == 1 || (nint)obj81 == 2 || (nint)obj81 == 3 || (nint)obj81 == 4 || (nint)obj81 == 5 || (nint)obj81 == 6 || (nint)obj81 == 7 || (nint)obj81 == 8 || (nint)obj81 == 9 || (nint)obj81 == 10 || (nint)obj81 == 11 || (nint)obj81 == 12 || (nint)obj81 == 13 || (nint)obj81 == 14 || (nint)obj81 == 15 || (nint)obj81 == 16 || (nint)obj81 == 17 || (nint)obj81 == 18 || (nint)obj81 == 19 || (nint)obj81 == 20 || (nint)obj81 == 21 || (nint)obj81 == 22 || (nint)obj81 == 23 || (nint)obj81 == 24 || (nint)obj81 == 25 || (nint)obj81 == 26 || (nint)obj81 == 27 || (nint)obj81 == 28 || (nint)obj81 == 29 || (nint)obj81 == 30 || (nint)obj81 == 31 || (nint)obj81 == 32 || (nint)obj81 == 33 || (nint)obj81 == 34 || (nint)obj81 == 35 || (nint)obj81 == 36 || (nint)obj81 == 37 || (nint)obj81 == 38 || (nint)obj81 == 39 || (nint)obj81 == 40 || (nint)obj81 == 41 || (nint)obj81 == 42 || (nint)obj81 == 43 || (nint)obj81 == 44 || (nint)obj81 == 45 || (nint)obj81 == 46 || (nint)obj81 == 47 || (nint)obj81 == 48 || (nint)obj81 == 49 || (nint)obj81 == 50 || (nint)obj81 == 51 || (nint)obj81 == 52 || (nint)obj81 == 53 || (nint)obj81 != 54)
					{
						return;
					}
					float num35 = alpha;
					float num36 = 1f - num35;
					obj18 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v45+8]");
					_ = 0;
					obj19 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48+8]");
					_ = 0;
					t = num36;
					uIProgressBar2 = uIProgressBar3;
				}
				else
				{
					float num37 = alpha;
					obj18 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v51+8]");
					_ = 0;
					obj19 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v54+8]");
					_ = 0;
					t = num37;
					uIProgressBar2 = this;
				}
				nint num38 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1469 @ S0_v227 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj82 = (nint)0 & (nint)0x200;
				if (obj82 != null)
				{
					nint num39 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1491 @ S0_v235 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj19;
				Vector3 vector16 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v60+8]");
				((Vector3*)(nint)vector16)->z = 0f;
				uIWidget = (UIWidget)obj18;
				UIWidget uIWidget14 = uIWidget;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v57+8]");
				((UnityEngine.Object)uIWidget14).m_CachedPtr = (IntPtr)0;
			}
			Vector3 vector17 = Vector3.LerpUnclamped(vector, (Vector3)uIWidget, t);
			uIWidget = (UIWidget)obj29;
			UIWidget uIWidget15 = uIWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ S0_v85+8]");
			((UnityEngine.Object)uIWidget15).m_CachedPtr = (IntPtr)0;
			uIProgressBar2.OnPan((Vector2)uIWidget);
		}
		goto IL_1cb8;
		IL_2064:
		float delta2 = alpha;
		((UIEventListener)(object)computeShader).OnScroll(delta2);
		flag = false;
		goto IL_1fb5;
		IL_21a3:
		float delta3 = alpha;
		((UIEventListener)(object)computeShader).OnScroll(delta3);
		flag = false;
		goto IL_1fb5;
	}
}
