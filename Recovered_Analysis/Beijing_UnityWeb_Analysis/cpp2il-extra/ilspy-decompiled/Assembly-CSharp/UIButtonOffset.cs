using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIButtonOffset : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	[NonSerialized]
	private Vector3 mPos;

	[NonSerialized]
	private bool mStarted;

	[NonSerialized]
	private bool mPressed;

	private void Start()
	{
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
		transform.localPosition = (Vector3)tweenTarget;
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
		((UIButtonMessage)this).OnPress(isPressed);
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
		//IL_02e1: Expected I4, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_00fa: Expected I, but got Obj
		//IL_02a5: Expected I, but got Obj
		//IL_02bb: Expected Obj, but got I
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0151: Expected F4, but got Obj
		//IL_014c: Expected native int or pointer, but got VT
		//IL_0166: Expected F4, but got I
		//IL_0161: Expected native int or pointer, but got VT
		//IL_0173: Expected Obj, but got F4
		//IL_0366: Expected F4, but got Obj
		//IL_0361: Expected native int or pointer, but got VT
		//IL_037b: Expected F4, but got I
		//IL_0376: Expected native int or pointer, but got VT
		//IL_0388: Expected F4, but got Obj
		//IL_0383: Expected native int or pointer, but got VT
		//IL_039d: Expected F4, but got I
		//IL_0398: Expected native int or pointer, but got VT
		//IL_031a: Expected F4, but got Obj
		//IL_0315: Expected native int or pointer, but got VT
		//IL_032f: Expected F4, but got I
		//IL_032a: Expected native int or pointer, but got VT
		//IL_01d5: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		Vector3 vector2 = (Vector3)(obj + 48);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
		obj4 = 0;
		_ = 0;
		mPressed = isOver;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S3_v54+8]");
			_ = 0;
			object obj6 = this + 28;
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S3_v59+8]");
			_ = 0;
		}
		else
		{
			string text = tag;
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S3_v25 (Il2CppClass<UICamera>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S3_v49 (Il2CppClass<UICamera>)+74]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S3_v41+8]");
				((Vector3*)(nint)vector3)->z = 0f;
				obj4 = vector.x;
				_ = vector.z;
				goto IL_030d;
			}
			object obj9 = this + 44;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S3_v31+8]");
			_ = 0;
			object obj10 = this + 16;
			obj3 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S3_v36+8]");
			_ = 0;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v10 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v21 (Il2CppClass<UnityEngine.Vector3>)+74]");
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
		Vector3 vector5 = vector2 - vector;
		obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		goto IL_030d;
		IL_030d:
		((Vector3*)(nint)vector)->x = (float)obj4;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go, duration, (Quaternion)vector);
		tweenRotation.method = UITweener.Method.EaseInOut;
	}

	private void OnDragOver()
	{
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		object obj = default;
		TweenRotation tweenRotation = (TweenRotation)(obj + 12);
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
		TweenPosition component = tweenTarget.GetComponent<TweenPosition>();
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
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			object obj4 = this + 44;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v16+8]");
			_ = 0;
			tweenRotation = (TweenRotation)obj;
			TweenRotation tweenRotation2 = tweenRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)tweenRotation2).m_CachedPtr = (IntPtr)0;
			Quaternion rotation = tweenRotation.rotation;
			component.tag = null;
		}
	}

	private unsafe void OnDragOut()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected VT, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected VT, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0062: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I
		//IL_0140: Expected F4, but got Obj
		//IL_013b: Expected native int or pointer, but got VT
		//IL_0155: Expected F4, but got I
		//IL_0150: Expected native int or pointer, but got VT
		//IL_0162: Expected F4, but got Obj
		//IL_015d: Expected native int or pointer, but got VT
		//IL_0177: Expected F4, but got I
		//IL_0172: Expected native int or pointer, but got VT
		//IL_0195: Expected F4, but got Obj
		//IL_0190: Expected native int or pointer, but got VT
		//IL_01aa: Expected F4, but got I
		//IL_01a5: Expected native int or pointer, but got VT
		//IL_00a3: Expected I, but got Obj
		object obj = default;
		Vector3 vector = (Vector3)(obj + 48);
		Vector3 vector2 = (Vector3)(obj + 36);
		object obj2 = obj + 24;
		object obj3 = obj + 12;
		if (~(mPressed ? 1u : 0u) != 0)
		{
			return;
		}
		string go = tweenTarget.tag;
		object obj4 = this + 44;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S3_v3+8]");
		_ = 0;
		object obj5 = this + 16;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S3_v8+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S2_v7 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v19 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector3 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go, duration, (Quaternion)vector);
		tweenRotation.method = UITweener.Method.EaseInOut;
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
			Vector3 vector4 = vector2 - vector;
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
		TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go, duration, (Quaternion)vector);
		tweenRotation.method = UITweener.Method.EaseInOut;
	}

	public unsafe UIButtonOffset()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0063: Expected F4, but got Obj
		//IL_005e: Expected native int or pointer, but got VT
		//IL_0078: Expected F4, but got I
		//IL_0073: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + 12);
		if (~(mPressed ? 1u : 0u) == 0)
		{
			string go = tweenTarget.tag;
			object obj2 = this + 44;
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v3+8]");
			_ = 0;
			((Quaternion*)(nint)quaternion)->x = (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			TweenRotation tweenRotation = TweenRotation.Begin((GameObject)(object)go, duration, quaternion);
			tweenRotation.method = UITweener.Method.EaseInOut;
		}
	}
}
