using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonScale : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Vector3 mScale;

	private bool mStarted;

	private void Start()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
		Vector3 one2 = Vector3.one;
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
		object obj = transform + 12;
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
		transform.localScale = (Vector3)tweenTarget;
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
		((UIButtonRotation)this).OnSelect(isPressed);
	}

	private unsafe void OnHover(bool isOver)
	{
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected VT, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected VT, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_00b9: Expected I, but got Obj
		//IL_00cf: Expected Obj, but got I
		//IL_02d7: Expected I4, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_00fa: Expected I, but got Obj
		//IL_029b: Expected I, but got Obj
		//IL_02b1: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0151: Expected F4, but got Obj
		//IL_014c: Expected native int or pointer, but got VT
		//IL_0166: Expected F4, but got I
		//IL_0161: Expected native int or pointer, but got VT
		//IL_0173: Expected Obj, but got F4
		//IL_035c: Expected F4, but got Obj
		//IL_0357: Expected native int or pointer, but got VT
		//IL_0371: Expected F4, but got I
		//IL_036c: Expected native int or pointer, but got VT
		//IL_037e: Expected F4, but got Obj
		//IL_0379: Expected native int or pointer, but got VT
		//IL_0393: Expected F4, but got I
		//IL_038e: Expected native int or pointer, but got VT
		//IL_0310: Expected F4, but got Obj
		//IL_030b: Expected native int or pointer, but got VT
		//IL_0325: Expected F4, but got I
		//IL_0320: Expected native int or pointer, but got VT
		//IL_0338: Expected Obj, but got VT
		//IL_01d5: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		Vector3 vector2 = (Vector3)(obj + 48);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v54+8]");
			_ = 0;
			object obj6 = this + 28;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S3_v59+8]");
			_ = 0;
		}
		else
		{
			string text = tag;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S3_v25 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S3_v49 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UICamera uICamera = UICamera.FindCameraForLayer((int)text);
			if ((object)uICamera == null)
			{
				object obj8 = this + 44;
				((Vector3*)(nint)vector)->x = (float)obj8;
				Vector3 vector3 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S3_v41+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				obj4 = vector.x;
				_ = vector.z;
				goto IL_0303;
			}
			object obj9 = this + 44;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S3_v31+8]");
			_ = 0;
			object obj10 = this + 16;
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S3_v36+8]");
			_ = 0;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S2_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v20 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		Vector3 vector5 = Vector3.Cross(vector2, vector);
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		goto IL_0303;
		IL_0303:
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		TweenTransform tweenTransform = TweenTransform.Begin((GameObject)(object)go, duration, (Transform)vector);
		tweenTransform.method = UITweener.Method.EaseInOut;
	}

	private unsafe void OnSelect(bool isSelected)
	{
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected VT, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected VT, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		//IL_01c2: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_0142: Expected F4, but got Obj
		//IL_013d: Expected native int or pointer, but got VT
		//IL_0157: Expected F4, but got I
		//IL_0152: Expected native int or pointer, but got VT
		//IL_0164: Expected Obj, but got F4
		//IL_0268: Expected F4, but got Obj
		//IL_0263: Expected native int or pointer, but got VT
		//IL_027d: Expected F4, but got I
		//IL_0278: Expected native int or pointer, but got VT
		//IL_0290: Expected Obj, but got VT
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_01f9: Expected F4, but got Obj
		//IL_01f4: Expected native int or pointer, but got VT
		//IL_020e: Expected F4, but got I
		//IL_0209: Expected native int or pointer, but got VT
		//IL_021b: Expected F4, but got Obj
		//IL_0216: Expected native int or pointer, but got VT
		//IL_0230: Expected F4, but got I
		//IL_022b: Expected native int or pointer, but got VT
		//IL_00eb: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		Vector3 vector2 = (Vector3)(obj + 48);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S3_v18+8]");
			_ = 0;
			object obj6 = this + 16;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S3_v23+8]");
			_ = 0;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S2_v27 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Vector3*)(nint)vector2)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
			((Vector3*)(nint)vector2)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj3;
			Vector3 vector3 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
			((Vector3*)(nint)vector3)->z = 0f;
			Vector3 vector4 = Vector3.Cross(vector2, vector);
			obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
		}
		else
		{
			object obj8 = this + 44;
			((Vector3*)(nint)vector)->x = (float)obj8;
			Vector3 vector5 = vector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S3_v9+8]");
			((Vector3*)(nint)vector5)->z = 0f;
			obj4 = vector.x;
			_ = vector.z;
		}
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		TweenTransform tweenTransform = TweenTransform.Begin((GameObject)(object)go, duration, (Transform)vector);
		tweenTransform.method = UITweener.Method.EaseInOut;
	}

	public UIButtonScale()
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
		TweenScale tweenScale = (TweenScale)(obj + 12);
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
			Vector3 scale = tweenScale.scale;
			((Component)componentInChildren).tag = null;
		}
	}
}
