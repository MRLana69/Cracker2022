using Cpp2ILInjected;
using UnityEngine;

public class UIDragCamera : MonoBehaviour
{
	public UIDraggableCamera draggableCamera;

	private void Awake()
	{
		CancelInvoke();
	}

	private unsafe void OnPress(bool isPressed)
	{
		//IL_01ec: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected VT, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected VT, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected Obj, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected Obj, but got Unknown
		//IL_035d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0232: Expected Obj, but got I
		//IL_00b1: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_015e: Expected I, but got Obj
		//IL_0174: Expected Obj, but got I
		//IL_0260: Expected F4, but got Obj
		//IL_025b: Expected native int or pointer, but got VT
		//IL_0275: Expected F4, but got I
		//IL_0270: Expected native int or pointer, but got VT
		//IL_0282: Expected F4, but got Obj
		//IL_027d: Expected native int or pointer, but got VT
		//IL_0297: Expected F4, but got I
		//IL_0292: Expected native int or pointer, but got VT
		//IL_02b5: Expected F4, but got Obj
		//IL_02b0: Expected native int or pointer, but got VT
		//IL_02ca: Expected F4, but got I
		//IL_02c5: Expected native int or pointer, but got VT
		//IL_02e9: Expected native int or pointer, but got VT
		//IL_02fb: Expected native int or pointer, but got VT
		//IL_030e: Expected I4, but got VT
		//IL_030e: Expected Obj, but got I4
		//IL_019f: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Vector3 vector = (Vector3)(obj2 + 48);
		Vector3 vector2 = (Vector3)(obj2 + 36);
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragCamera)+1C]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragCamera)+1C]");
		object obj5 = 0;
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v55 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v14+68]");
		if (((ComputeShader)0).FindKernel(null) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDragCamera)+1C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj9 = default;
		object obj8 = obj9 + 40;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v26+8]");
		_ = 0;
		object obj10 = obj9 + 16;
		obj4 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v31+8]");
		_ = 0;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v22 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)obj3;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector4 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector5 = vector / 0.5f;
		((Vector3*)(nint)vector)->x = vector2.x;
		((Vector3*)(nint)vector)->z = vector2.z;
		((UIGrid)this).AddChild((Transform)isPressed, (byte)(int)vector != 0);
	}

	private void OnDrag(Vector2 delta)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		string fileName = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v23 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load(fileName);
		if (array == null)
		{
			return;
		}
		nint num3 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)draggableCamera).FindKernel((string)null) != 0 && draggableCamera.isActiveAndEnabled)
		{
			draggableCamera.Drag(delta);
		}
	}

	private void OnScroll(float delta)
	{
	}

	public UIDragCamera()
	{
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0144: Expected VT, but got Obj
		//IL_014c: Expected Obj, but got VT
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(draggableCamera != null))
		{
			return;
		}
		string trans = tag;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v18 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 12;
		_0021_00210 val = (_0021_00210)NGUITools.FindInParents<T>((Transform)(object)trans);
		obj3 = val;
	}
}
