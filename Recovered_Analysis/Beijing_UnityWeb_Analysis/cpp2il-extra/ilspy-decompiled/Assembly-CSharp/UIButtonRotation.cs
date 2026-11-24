using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonRotation : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Quaternion mRot;

	private bool mStarted;

	private void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I4
		//IL_0105: Expected Obj, but got F4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v34 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		Vector3 one = Vector3.one;
		object obj4 = obj3 + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		object obj5 = this + 16;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		obj3 = 0;
		_ = 0;
		obj3 = 2f;
		_ = -2f;
		_ = 0f;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = this + 28;
		obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16+8]");
		_ = 0;
		duration = 0.2f;
		CancelInvoke();
	}

	private void OnEnable()
	{
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_012a: Expected VT, but got Obj
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_005f: Expected I, but got Obj
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		Transform transform = default;
		object obj = transform + 16;
		if (~(mStarted ? 1u : 0u) == 0)
		{
			return;
		}
		mStarted = true;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (tweenTarget != null)
		{
			object obj3 = this + 12;
			GameObject gameObject = base.gameObject;
			obj3 = gameObject;
		}
		transform.localRotation = (Quaternion)tweenTarget;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		object obj4 = this + 44;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
	}

	private void OnDisable()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00c0: Expected I4, but got Obj
		//IL_00ce: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		if (~(mStarted ? 1u : 0u) != 0)
		{
			return;
		}
		string text = tag;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v11 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v16 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera uICamera = UICamera.FindCameraForLayer((int)text);
		OnSelect((byte)(int)uICamera != 0);
	}

	private void OnPress(bool isPressed)
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (isPressed)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode currentKey = UICamera.currentKey;
			if (currentKey != (KeyCode)2)
			{
				return;
			}
		}
		((UIButtonOffset)this).OnSelect(isPressed);
	}

	private unsafe void OnHover(bool isOver)
	{
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Ref, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected VT, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Ref, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0267: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_02db: Expected I4, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_00fa: Expected I, but got Obj
		//IL_029f: Expected I, but got Obj
		//IL_02b5: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got VT
		//IL_0375: Expected F4, but got Obj
		//IL_0370: Expected native int or pointer, but got VT
		//IL_038a: Expected F4, but got I
		//IL_0385: Expected native int or pointer, but got VT
		//IL_0397: Expected Ref, but got VT
		//IL_03b1: Expected VT, but got Ref
		//IL_032f: Expected VT, but got Ref
		//IL_01cb: Expected I, but got Obj
		object obj = default;
		ref Quaternion reference = ref *(Quaternion*)(obj + 96);
		Quaternion quaternion = (Quaternion)(obj + 80);
		object obj2 = obj + 48;
		object obj3 = obj + 32;
		ref Quaternion reference2 = ref *(Quaternion*)(obj + 16);
		object obj4 = obj - -64;
		obj4 = 0;
		_ = 0;
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (~(mStarted ? 1u : 0u) != 0)
		{
			OnEnable();
		}
		string go = tweenTarget.tag;
		if (isOver)
		{
			object obj5 = this + 44;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v59+8]");
			_ = 0;
			object obj6 = this + 28;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S3_v64+8]");
			_ = 0;
		}
		else
		{
			string text = tag;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S3_v30 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S3_v54 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera = UICamera.FindCameraForLayer((int)text);
			if ((object)uICamera == null)
			{
				object obj8 = this + 44;
				reference = ref *(Quaternion*)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S3_v46+8]");
				_ = 0;
				obj4 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Quaternion&)+8]");
				_ = 0;
				goto IL_0307;
			}
			object obj9 = this + 44;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S3_v36+8]");
			_ = 0;
			object obj10 = this + 16;
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S3_v41+8]");
			_ = 0;
		}
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S2_v9 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v23 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		reference = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference2, out reference);
		((Quaternion*)(nint)quaternion)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		reference = ref *(Quaternion*)reference2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 vector = quaternion * (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		goto IL_0307;
		IL_0307:
		reference = ref *(Quaternion*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		TweenScale tweenScale = TweenScale.Begin((GameObject)(object)go, duration, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		tweenScale.method = UITweener.Method.EaseInOut;
	}

	private unsafe void OnSelect(bool isSelected)
	{
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Ref, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected VT, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Ref, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got VT
		//IL_02a1: Expected VT, but got Ref
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_021f: Expected F4, but got Obj
		//IL_021a: Expected native int or pointer, but got VT
		//IL_0234: Expected F4, but got I
		//IL_022f: Expected native int or pointer, but got VT
		//IL_0241: Expected Ref, but got VT
		//IL_025b: Expected VT, but got Ref
		//IL_00eb: Expected I, but got Obj
		object obj = default;
		ref Quaternion reference = ref *(Quaternion*)(obj + 96);
		Quaternion quaternion = (Quaternion)(obj + 80);
		object obj2 = obj + 48;
		object obj3 = obj + 32;
		ref Quaternion reference2 = ref *(Quaternion*)(obj + 16);
		object obj4 = obj - -64;
		obj4 = 0;
		_ = 0;
		if (!isActiveAndEnabled)
		{
			return;
		}
		if (~(mStarted ? 1u : 0u) != 0)
		{
			OnEnable();
		}
		string go = tweenTarget.tag;
		if (isSelected)
		{
			object obj5 = this + 44;
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S3_v18+8]");
			_ = 0;
			object obj6 = this + 16;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S3_v23+8]");
			_ = 0;
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S2_v16 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S2_v30 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			reference = ref *(Quaternion*)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			_ = 0;
			Quaternion.Inverse_Injected(ref reference2, out reference);
			((Quaternion*)(nint)quaternion)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			reference = ref *(Quaternion*)reference2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (UnityEngine.Quaternion&)+8]");
			_ = 0;
			Vector3 vector = quaternion * (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		else
		{
			object obj8 = this + 44;
			reference = ref *(Quaternion*)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S3_v9+8]");
			_ = 0;
			obj4 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UnityEngine.Quaternion&)+8]");
			_ = 0;
		}
		reference = ref *(Quaternion*)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		_ = 0;
		TweenScale tweenScale = TweenScale.Begin((GameObject)(object)go, duration, (Vector3)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference));
		tweenScale.method = UITweener.Method.EaseInOut;
	}

	public UIButtonRotation()
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_01e7: Expected Obj, but got VT
		//IL_00f1: Expected I, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_0184: Expected Obj, but got VT
		object obj = default;
		TweenScale tweenScale = (TweenScale)(obj + 16);
		if (~(mStarted ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)tweenTarget).FindKernel((string)null) == 0)
		{
			return;
		}
		_0021_00210 componentInChildren = (_0021_00210)((Component)tweenTarget).GetComponentInChildren<T>();
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			object obj4 = this + 44;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v16+8]");
			_ = 0;
			tweenScale = (TweenScale)obj;
			TweenScale tweenScale2 = tweenScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)tweenScale2).m_CachedPtr = (IntPtr)0;
			Vector3 value = tweenScale.value;
			((Component)componentInChildren).tag = null;
		}
	}
}
