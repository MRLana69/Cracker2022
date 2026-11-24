using System;
using Cpp2ILInjected;
using JetBrains.Annotations;
using UnityEngine;

public class FixedRotation : MonoBehaviour
{
	private Vector3 _eulerAngles;

	private Transform _transform;

	private unsafe void Awake()
	{
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0021: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004c: Expected Obj, but got I
		//IL_005c: Expected Obj, but got I4
		//IL_005c: Expected Obj, but got I
		//IL_0071: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0081: Expected Obj, but got VT
		//IL_0096: Expected Obj, but got VT
		//IL_00ac: Expected Obj, but got I4
		//IL_00ac: Expected Obj, but got I
		//IL_00c7: Expected Obj, but got I
		//IL_00d5: Expected Obj, but got F4
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected VT, but got Unknown
		//IL_0254: Expected F4, but got Obj
		//IL_024f: Expected native int or pointer, but got VT
		//IL_0269: Expected F4, but got I
		//IL_0264: Expected native int or pointer, but got VT
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0295: Expected F4, but got Obj
		//IL_0290: Expected native int or pointer, but got VT
		//IL_02aa: Expected F4, but got I
		//IL_02a5: Expected native int or pointer, but got VT
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_018c: Expected F4, but got Obj
		//IL_0187: Expected native int or pointer, but got VT
		//IL_01a1: Expected F4, but got I
		//IL_019c: Expected native int or pointer, but got VT
		//IL_0129: Expected I, but got Obj
		//IL_01cd: Expected F4, but got Obj
		//IL_01c8: Expected native int or pointer, but got VT
		//IL_01e2: Expected F4, but got I
		//IL_01dd: Expected native int or pointer, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IntPtr intPtr = default;
		AnimationCurve.Internal_Destroy(intPtr);
		object obj = this + 8;
		obj = (nint)intPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IntPtr intPtr2 = default;
		AnimationCurve.Internal_Destroy(intPtr2);
		object obj2 = this + 12;
		obj2 = (nint)intPtr2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IntPtr intPtr3 = default;
		AnimationCurve.Internal_Destroy(intPtr3);
		object obj3 = this + 16;
		obj3 = (nint)intPtr3;
		((StringFormatMethodAttribute)(nint)((UnityEngine.Object)this).m_CachedPtr)._002Ector((string)8);
		((AnimationCurve)(nint)((UnityEngine.Object)this).m_CachedPtr).postWrapMode = WrapMode.ClampForever;
		((StringFormatMethodAttribute)_eulerAngles)._002Ector((string)8);
		((AnimationCurve)_eulerAngles).postWrapMode = WrapMode.ClampForever;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FixedRotation)+10]");
		((StringFormatMethodAttribute)0)._002Ector((string)8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FixedRotation)+10]");
		((AnimationCurve)0).postWrapMode = WrapMode.ClampForever;
		float num = default;
		object obj4 = 0f - num;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v38 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = default;
		object obj6 = obj7 + 36;
		Vector3 forward = Vector3.forward;
		Vector3 vector = (Vector3)(obj7 + 48);
		((Vector3*)(nint)vector)->x = (float)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v43+8]");
		((Vector3*)(nint)vector)->z = 0f;
		object obj8 = obj7 + 24;
		Vector3 vector2 = vector / num;
		((Vector3*)(nint)vector)->x = (float)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v48+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7516");
		object obj9 = obj7 + 12;
		Vector3 forward2 = Vector3.forward;
		((Vector3*)(nint)vector)->x = (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v53+8]");
		((Vector3*)(nint)vector)->z = 0f;
		float num4 = 0f - num;
		Vector3 vector3 = vector / num4;
		((Vector3*)(nint)vector)->x = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
	}

	private void LateUpdate()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 24;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
	}

	public FixedRotation()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		object obj = this + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S2_v2+8]");
		_ = 0;
		Transform transform = (Transform)(obj2 + 12);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 localEulerAngles = transform.localEulerAngles;
	}
}
