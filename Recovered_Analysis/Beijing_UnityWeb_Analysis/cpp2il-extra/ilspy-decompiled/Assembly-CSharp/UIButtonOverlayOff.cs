using System;
using Cpp2ILInjected;
using Info;
using UnityEngine;

public class UIButtonOverlayOff : MonoBehaviour
{
	public enum ButtonType
	{
		Custom = 0,
		Primary = 1,
		Secondary = 2,
		Tertiary = 3,
		Facebook = 4,
		Footer_back = 8,
		Footer_me = 9,
		Footer_friends = 10,
		Footer_shop = 11,
		Seasonal = 12,
		SocialGrey = 13,
		Exit = 17
	}

	public GameObject fillWithPrimeColor;

	private Color _originalFillColor;

	private UIWidget _fillSprite;

	private UISprite _overlay;

	private bool _initDone;

	private bool _buttonStateLocked;

	public ButtonType buttonType;

	private ButtonColorScheme _buttonColorScheme;

	private void Awake()
	{
		CancelInvoke();
	}

	private void OnDisable()
	{
		if (~(_initDone ? 1u : 0u) != 0)
		{
			ApplyDefaultColors();
		}
	}

	public unsafe void SetButtonType(ButtonType type)
	{
		//IL_0017: Expected Obj, but got I4
		GameObject gameObject = base.gameObject;
		Transform transform = (Transform)((ButtonType*)(int)type)->value__;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L1 (UIButtonOverlayOff+ButtonType)+8]");
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private unsafe void Init()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected I, but got Unknown
		//IL_0099: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = _fillSprite + 80;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v5+8]");
		_ = 0;
		object obj4 = this + 16;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v10+8]");
		_ = 0;
		Gradient gradient = (Gradient)(obj2 + 32);
		gradient = (Gradient)obj;
		Gradient gradient2 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		gradient2.m_Ptr = (IntPtr)0;
		nint num = (nint)(obj2 + 48);
		((IntPtr*)num)->m_value = (void*)(nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		if (gradient.Internal_Equals((IntPtr)num))
		{
			GoToNotAvailableState();
		}
	}

	private void ApplyDefaultColors()
	{
		_initDone = true;
		GoToNormalState();
	}

	public unsafe void GoToNormalState()
	{
		//IL_032b: Expected I, but got Obj
		//IL_0341: Expected Obj, but got I
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected Obj, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected Obj, but got Unknown
		//IL_03d8: Expected Obj, but got I4
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e6: Expected VT, but got Unknown
		//IL_03f3: Expected F4, but got Obj
		//IL_03ee: Expected native int or pointer, but got VT
		//IL_0405: Expected F4, but got I
		//IL_0400: Expected native int or pointer, but got VT
		//IL_0417: Expected F4, but got Obj
		//IL_0412: Expected native int or pointer, but got VT
		//IL_0429: Expected F4, but got Obj
		//IL_0424: Expected native int or pointer, but got VT
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected Obj, but got Unknown
		//IL_0441: Expected Obj, but got F4
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected Obj, but got Unknown
		//IL_0172: Expected F4, but got Obj
		//IL_016d: Expected native int or pointer, but got VT
		//IL_0184: Expected F4, but got I
		//IL_017f: Expected native int or pointer, but got VT
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_019c: Expected Obj, but got F4
		//IL_01b4: Expected I, but got Obj
		//IL_01ca: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00f0: Expected F4, but got Obj
		//IL_00eb: Expected native int or pointer, but got VT
		//IL_01f5: Expected I, but got Obj
		//IL_010f: Expected F4, but got Obj
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0124: Expected F4, but got I
		//IL_011f: Expected native int or pointer, but got VT
		//IL_0133: Expected I4, but got VT
		//IL_0244: Expected Obj, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0317: Expected Obj, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_029e: Expected F4, but got Obj
		//IL_0299: Expected native int or pointer, but got VT
		//IL_02bd: Expected F4, but got Obj
		//IL_02b8: Expected native int or pointer, but got VT
		//IL_02d2: Expected F4, but got I
		//IL_02cd: Expected native int or pointer, but got VT
		//IL_02e1: Expected I4, but got VT
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v88 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_fillSprite != null)
		{
			object obj2 = this + 32;
			UIWidget component = fillWithPrimeColor.GetComponent<UIWidget>();
			obj2 = component;
		}
		string userTips = tag;
		nint num3 = (nint)typeof(GlobalColors);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v17 (Il2CppClass<GlobalColors>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(GlobalColors);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v72 (Il2CppClass<GlobalColors>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 52;
		LoadLevelCtrl loadLevelCtrl = (LoadLevelCtrl)(obj5 + 16);
		loadLevelCtrl.SetUserTip((string)buttonType, (UserTip[])(object)userTips);
		Matrix4x4 matrix4x = (Matrix4x4)(obj5 + 56);
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)loadLevelCtrl;
		((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)loadLevelCtrl).m_CachedPtr;
		((Matrix4x4*)(nint)matrix4x)->m01 = (float)loadLevelCtrl.titleTipLabel;
		((Matrix4x4*)(nint)matrix4x)->m21 = (float)loadLevelCtrl.userNameLabel;
		object obj6 = this + 48;
		obj6 = matrix4x.m00;
		_ = matrix4x.m20;
		_ = matrix4x.m01;
		_ = matrix4x.m21;
		object obj7 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v38+4]");
		if ((nint)0 != 0)
		{
			object obj8 = this + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
			obj4 = loadLevelCtrl;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj4;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
			Matrix4x4 matrix4x3 = matrix4x;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x3)->m20 = 0f;
			_fillSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		}
		object obj9 = _fillSprite + 80;
		loadLevelCtrl = (LoadLevelCtrl)obj9;
		LoadLevelCtrl loadLevelCtrl2 = loadLevelCtrl;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v37+8]");
		((UnityEngine.Object)loadLevelCtrl2).m_CachedPtr = (IntPtr)0;
		((Matrix4x4*)(nint)matrix4x)->m00 = (float)loadLevelCtrl;
		((Matrix4x4*)(nint)matrix4x)->m20 = (nint)((UnityEngine.Object)loadLevelCtrl).m_CachedPtr;
		object obj10 = this + 16;
		obj10 = matrix4x.m00;
		_ = matrix4x.m20;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v73 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj12 = obj5 + 48;
		if (((ComputeShader)(object)_overlay).FindKernel((string)null) != 0)
		{
			_overlay.tag = (string)1;
			object obj13 = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v66+4]");
			if ((nint)0 != 0)
			{
				object obj14 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
				obj12 = loadLevelCtrl;
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj12;
				Matrix4x4 matrix4x4 = Matrix4x4.Inverse(matrix4x);
				((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj5;
				Matrix4x4 matrix4x5 = matrix4x;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((Matrix4x4*)(nint)matrix4x5)->m20 = 0f;
				_overlay.rawPivot = (UIWidget.Pivot)matrix4x;
			}
		}
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
	}

	public unsafe void GoToNotAvailableState()
	{
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected I4, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00e7: Expected I4, but got Obj
		//IL_0111: Expected I, but got Obj
		//IL_0127: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_0152: Expected I, but got Obj
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_023b: Expected Obj, but got I4
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected Obj, but got Unknown
		//IL_01eb: Expected I4, but got Obj
		//IL_01f4: Expected VT, but got I4
		//IL_020a: Expected I4, but got Obj
		object obj = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj + 40);
		object obj2 = obj + 16;
		object obj3 = obj + 32;
		if (~(_buttonStateLocked ? 1u : 0u) == 0)
		{
			return;
		}
		BoxCollider component = GetComponent<BoxCollider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v44 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
		{
			BoxCollider component2 = GetComponent<BoxCollider>();
			component2.isTrigger = true;
		}
		object obj5 = this + 16;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v5+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		_ = 0;
		_fillSprite.rawPivot = pivot;
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v37 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_overlay).FindKernel((string)null) != 0)
		{
			object obj7 = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v31+4]");
			if ((nint)0 != 0)
			{
				object obj8 = this + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
				obj3 = obj2;
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
				Matrix4x4 matrix4x = Matrix4x4.Inverse((Matrix4x4)pivot);
				((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				_overlay.rawPivot = pivot;
			}
			_overlay.tag = (string)1;
		}
	}

	public unsafe void GoToSelectedState()
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected VT, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01b3: Expected F4, but got Obj
		//IL_01ae: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got Obj
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01e7: Expected F4, but got I
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_01f6: Expected I4, but got VT
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 20;
		object obj3 = obj + 16;
		if (~(_buttonStateLocked ? 1u : 0u) == 0)
		{
			return;
		}
		BoxCollider component = GetComponent<BoxCollider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
		{
			BoxCollider component2 = GetComponent<BoxCollider>();
			component2.isTrigger = false;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_overlay).FindKernel((string)null) != 0)
		{
			_overlay.tag = null;
		}
		object obj6 = this - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v30+4]");
		if ((nint)0 != 0)
		{
			object obj7 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_fillSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		}
	}

	public void LockState(bool locked)
	{
		buttonType = (locked ? ButtonType.Primary : ButtonType.Custom);
		ApplyDefaultColors();
		((UIButtonSender)this).OnHover(false);
	}

	public virtual void OnPress(bool isPressed)
	{
		_buttonStateLocked = isPressed;
	}

	public void ButtonPressed(bool isPressed)
	{
		((UIButtonSender)this).OnHover(isPressed);
	}

	public unsafe UIButtonOverlayOff()
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected VT, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0109: Expected I, but got Obj
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_01b3: Expected F4, but got Obj
		//IL_01ae: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got Obj
		//IL_01cd: Expected native int or pointer, but got VT
		//IL_01e7: Expected F4, but got I
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_01f6: Expected I4, but got VT
		object obj = default;
		Matrix4x4 matrix4x = (Matrix4x4)(obj + 24);
		object obj2 = obj + 20;
		object obj3 = obj + 16;
		if (~(_buttonStateLocked ? 1u : 0u) == 0)
		{
			return;
		}
		BoxCollider component = GetComponent<BoxCollider>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v39 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)component))
		{
			BoxCollider component2 = GetComponent<BoxCollider>();
			component2.isTrigger = false;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_overlay).FindKernel((string)null) != 0)
		{
			_overlay.tag = null;
		}
		object obj6 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v30+4]");
		if ((nint)0 != 0)
		{
			object obj7 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8453");
			obj3 = obj2;
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj3;
			Matrix4x4 matrix4x2 = Matrix4x4.Inverse(matrix4x);
			((Matrix4x4*)(nint)matrix4x)->m00 = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Matrix4x4*)(nint)matrix4x)->m20 = 0f;
			_fillSprite.rawPivot = (UIWidget.Pivot)matrix4x;
		}
	}
}
