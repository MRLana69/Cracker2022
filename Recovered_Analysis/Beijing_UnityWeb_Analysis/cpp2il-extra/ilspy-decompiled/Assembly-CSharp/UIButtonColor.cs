using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonColor : UIWidgetContainer
{
	public enum State
	{
		Normal,
		Hover,
		Pressed,
		Disabled
	}

	public GameObject tweenTarget;

	public Color hover;

	public Color pressed;

	public Color disabledColor;

	public float duration;

	[NonSerialized]
	protected Color mStartingColor;

	[NonSerialized]
	protected Color mDefaultColor;

	[NonSerialized]
	protected bool mInitDone;

	[NonSerialized]
	protected UIWidget mWidget;

	[NonSerialized]
	protected State mState;

	public State state
	{
		get
		{
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+A0]");
			return State.Normal;
		}
		set
		{
			//IL_01d5: Expected I, but got Obj
			//IL_01eb: Expected Obj, but got I
			//IL_027c: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_021b: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00f0: Expected Obj, but got I
			//IL_00fe: Expected I, but got Obj
			//IL_0114: Expected Obj, but got I
			//IL_0251: Expected Obj, but got I4
			//IL_0251: Expected Obj, but got I
			//IL_013f: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)value).FindKernel(null) == 0)
			{
				return;
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+98]");
			if (((ComputeShader)0).FindKernel(null) == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+98]");
			object obj3 = 0;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v17+18C]");
			if (((ComputeShader)0).FindKernel((string)value) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+98]");
				((UI2DSprite)0).material = (Material)value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+8C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
			}
		}
	}

	public Color defaultColor
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			Color result = default;
			return result;
		}
		set
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Color)+64]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			object obj = value + 84;
			UIButtonColor uIButtonColor = (UIButtonColor)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
		}
	}

	public unsafe virtual bool isEnabled
	{
		get
		{
			return (byte)mState != 0;
		}
		set
		{
			//IL_0040: Expected Obj, but got I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected Obj, but got Unknown
			if (~(mInitDone ? 1u : 0u) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
			}
			object obj = ((bool*)(value ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
			_ = 0;
			object obj2 = this + 84;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			mState = State.Disabled;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}

	public void ResetDefaultColor()
	{
		//IL_000b: Expected VT, but got I4
		hover = (Color)1;
		CancelInvoke();
	}

	public unsafe void CacheDefaultColor()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		//IL_003b: Expected I4, but got Obj
		object obj = this + 68;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		bool flag = (byte)(obj2 + 16) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		isEnabled = flag;
	}

	private void Start()
	{
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected virtual void OnInit()
	{
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}

	protected virtual void OnEnable()
	{
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05e8: Expected Obj, but got I4
		//IL_0607: Expected I, but got Obj
		//IL_061d: Expected Obj, but got I
		//IL_0648: Expected I, but got Obj
		//IL_065e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0689: Expected I, but got Obj
		//IL_069f: Expected Obj, but got I
		//IL_00b3: Expected I, but got Obj
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected Obj, but got Unknown
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_0237: Expected I, but got Obj
		//IL_024d: Expected Obj, but got I
		//IL_0127: Expected I, but got Obj
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_0278: Expected I, but got Obj
		//IL_02d4: Expected I, but got Obj
		//IL_02ea: Expected Obj, but got I
		//IL_048a: Expected I, but got Obj
		//IL_04a0: Expected Obj, but got I
		//IL_0315: Expected I, but got Obj
		//IL_071f: Expected Obj, but got VT
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_05c1: Expected Obj, but got I4
		//IL_04cb: Expected I, but got Obj
		//IL_03b8: Expected VT, but got Obj
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected Obj, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected Obj, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_0394: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		obj = 0;
		_ = 0;
		mInitDone = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v143 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (tweenTarget != null && Application.platform == RuntimePlatform.OSXEditor)
		{
			object obj4 = this + 12;
			string text = tag;
			obj4 = text;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) != 0)
		{
			object obj6 = this + 104;
			UIWidget component = tweenTarget.GetComponent<UIWidget>();
			obj6 = component;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Material material = (Material)(obj2 + 48);
		Light light = (Light)(obj2 + 16);
		if (((ComputeShader)(object)mWidget).FindKernel((string)null) != 0)
		{
			object obj8 = mWidget + 80;
			light = (Light)obj8;
			Light light2 = light;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v105+8]");
			((UnityEngine.Object)light2).m_CachedPtr = (IntPtr)0;
			material = (Material)(object)light;
			((UnityEngine.Object)material).m_CachedPtr = ((UnityEngine.Object)light).m_CachedPtr;
			object obj9 = this + 84;
			obj9 = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			object obj10 = this + 84;
			obj2 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v119+8]");
			_ = 0;
			material = (Material)obj2;
			Material material2 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)material2).m_CachedPtr = (IntPtr)0;
			object obj11 = this + 68;
			obj11 = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			return;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) == 0)
		{
			return;
		}
		Renderer component2 = tweenTarget.GetComponent<Renderer>();
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v97 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
		{
			if (Application.platform != RuntimePlatform.OSXEditor)
			{
				Material sharedMaterial = component2.sharedMaterial;
				material.color = (Color)sharedMaterial;
			}
			else
			{
				Material[] sharedMaterials = component2.sharedMaterials;
				material.color = (Color)sharedMaterials;
			}
			obj = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			material = (Material)obj;
			Material material3 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)material3).m_CachedPtr = (IntPtr)0;
			object obj14 = this + 84;
			obj14 = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			object obj15 = this + 84;
			light = (Light)obj15;
			Light light3 = light;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v82+8]");
			((UnityEngine.Object)light3).m_CachedPtr = (IntPtr)0;
			material = (Material)(object)light;
			((UnityEngine.Object)material).m_CachedPtr = ((UnityEngine.Object)light).m_CachedPtr;
			object obj16 = this + 68;
			obj16 = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			return;
		}
		_0021_00210 componentInChildren = (_0021_00210)tweenTarget.GetComponentInChildren<T>();
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			light.color = (Color)componentInChildren;
			material = (Material)(object)light;
			((UnityEngine.Object)material).m_CachedPtr = ((UnityEngine.Object)light).m_CachedPtr;
			object obj18 = this + 84;
			obj18 = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
			object obj19 = this + 84;
			obj2 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ S1_v54+8]");
			_ = 0;
			material = (Material)obj2;
			Material material4 = material;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)material4).m_CachedPtr = (IntPtr)0;
			object obj20 = this + 68;
			obj20 = material;
			_ = ((UnityEngine.Object)material).m_CachedPtr;
		}
		else
		{
			object obj21 = this + 12;
			obj21 = 0;
			mInitDone = false;
		}
	}

	protected virtual void OnDisable()
	{
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0321: Expected I4, but got Obj
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_0373: Expected I, but got Obj
		//IL_0389: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_01c7: Expected I, but got Obj
		//IL_03f7: Expected I, but got Obj
		//IL_040d: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		//IL_02b1: Expected I, but got Obj
		if (~(mInitDone ? 1u : 0u) == 0)
		{
			string text = tag;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v60 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v65 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera = UICamera.FindCameraForLayer((int)text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v51 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouch == null)
		{
			return;
		}
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v45 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		string text2 = tag;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S2_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (currentTouch.pressed != (UnityEngine.Object)(object)text2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			return;
		}
		nint num9 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v28 (Il2CppClass<UICamera>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v38 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch2 = UICamera.currentTouch;
		string text3 = tag;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S2_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S2_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (currentTouch2.current != (UnityEngine.Object)(object)text3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		}
	}

	protected virtual void OnHover(bool isOver)
	{
		//IL_000a: Expected Obj, but got I4
		tag = (string)isOver;
	}

	protected virtual void OnPress(bool isPressed)
	{
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}

	protected unsafe virtual void OnDragOver()
	{
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected I4, but got Unknown
		//IL_003c: Expected I, but got Obj
		//IL_0052: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_00d9: Expected I, but got Obj
		//IL_00ef: Expected Obj, but got I
		//IL_020d: Expected Obj, but got VT
		//IL_011a: Expected I, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0186: Expected I4, but got Obj
		//IL_01a0: Expected Obj, but got VT
		//IL_01aa: Expected Obj, but got VT
		object obj = default;
		int num = obj + 16;
		if (~(mInitDone ? 1u : 0u) != 0 || mState == State.Normal)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		nint num2 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) == 0)
		{
			return;
		}
		_0021_00210 componentInChildren = (_0021_00210)tweenTarget.GetComponentInChildren<T>();
		nint num4 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			object obj4 = this + 84;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v17+8]");
			_ = 0;
			((int*)num)->m_value = (int)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			((TweenHeight)componentInChildren).height = num;
			((Component)componentInChildren).tag = null;
		}
	}

	protected virtual void OnDragOut()
	{
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}

	public virtual void SetState(State state, bool instant)
	{
		//IL_03b0: Expected VT, but got I4
		//IL_03b0: Expected Obj, but got I4
		//IL_03be: Expected I, but got Obj
		//IL_03d4: Expected Obj, but got I
		//IL_0403: Expected Obj, but got I
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_045f: Expected Obj, but got I
		//IL_01ed: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_00f2: Expected Obj, but got I
		//IL_02ca: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I
		//IL_0166: Expected Obj, but got I
		//IL_030b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		((UICenterOnChild)(object)this).CenterOn((Transform)state, (Vector3)instant);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v41 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+94]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			switch (state)
			{
			case State.Normal:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+9C]");
				((UIButton)this).SetSprite((Sprite)0);
				break;
			case State.Hover:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+74]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+74]");
				bool flag;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v33+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				Sprite sprite;
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+9C]");
					sprite = (Sprite)0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+74]");
					sprite = (Sprite)0;
				}
				((UIButton)this).SetSprite(sprite);
				break;
			}
			case State.Pressed:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+78]");
				((UIButton)this).SetSprite((Sprite)0);
				break;
			case State.Disabled:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+7C]");
				((UIButton)this).SetSprite((Sprite)0);
				break;
			}
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+98]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		switch (state)
		{
		case State.Normal:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+A0]");
			this.state = State.Normal;
			break;
		case State.Hover:
		{
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+80]");
			State state2;
			if ((UnityEngine.Object)0 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+A0]");
				state2 = State.Normal;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+80]");
				state2 = State.Normal;
			}
			this.state = state2;
			break;
		}
		case State.Pressed:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+84]");
			this.state = State.Normal;
			break;
		case State.Disabled:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIButtonColor)+88]");
			this.state = State.Normal;
			break;
		}
	}

	public void UpdateColor(bool instant)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
		//IL_0115: Expected I, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_04f5: Expected I, but got Obj
		//IL_050b: Expected Obj, but got I
		//IL_01cb: Expected I, but got Obj
		//IL_0274: Expected I, but got Obj
		//IL_028a: Expected Obj, but got I
		//IL_0218: Expected I, but got Obj
		//IL_0311: Expected I, but got Obj
		//IL_0327: Expected Obj, but got I
		//IL_02b5: Expected I, but got Obj
		//IL_0352: Expected I, but got Obj
		//IL_039f: Expected I, but got Obj
		//IL_03b5: Expected Obj, but got I
		//IL_05f4: Expected I, but got Obj
		//IL_060a: Expected Obj, but got I
		//IL_03e0: Expected I, but got Obj
		//IL_042d: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v84 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentTouch == null)
		{
			return;
		}
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) == 0)
		{
			return;
		}
		if (instant)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			return;
		}
		nint num5 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v76 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
		string text = tag;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S2_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(currentTouch.current != (UnityEngine.Object)(object)text))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			return;
		}
		nint num9 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v36 (Il2CppClass<UICamera>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v71 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		KeyCode currentKey = UICamera.currentKey;
		if (currentKey == (KeyCode)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			return;
		}
		nint num11 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v44 (Il2CppClass<UICamera>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num12 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v66 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UICamera.currentKey == KeyCode.None)
		{
			nint num13 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v54 (Il2CppClass<UICamera>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v62 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
			string text2 = tag;
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S2_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S2_v21 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (controllerNavigationObject != (UnityEngine.Object)(object)text2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
	}

	public UIButtonColor()
	{
		//IL_0046: Expected I, but got Obj
		//IL_005c: Expected Obj, but got I
		//IL_0087: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj = default;
		if (obj == null)
		{
			return;
		}
		if (~(mInitDone ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
		}
	}
}
