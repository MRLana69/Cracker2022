using System;
using Cpp2ILInjected;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
	public Vector3 spacing = (Vector3)4692750812812673024L;

	public Vector3 offset;

	protected void Awake()
	{
	}

	protected virtual void Reset()
	{
		//IL_000f: Expected VT, but got I8
		//IL_0028: Expected I, but got Obj
		spacing = (Vector3)4692750812812673024L;
		_ = 1092616192;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		offset = Vector3.zeroVector;
	}

	public unsafe void Snap()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_008f: Expected F8, but got I4
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_00ce: Expected F8, but got I4
		//IL_01c9: Expected Obj, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_010d: Expected F8, but got I4
		//IL_012c: Expected F4, but got I
		//IL_0127: Expected native int or pointer, but got VT
		//IL_014b: Expected F4, but got I
		//IL_0146: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = base.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		object obj2 = 0 - offset;
		object obj3 = obj2 / spacing;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num2 = default;
		double num = Math.Abs(num2);
		if (!(num < 2147483648.0))
		{
			num2 = -2147483648.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+1C]");
		object obj4 = num3 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+10]");
		object obj5 = obj4 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num5 = default;
		double num4 = Math.Abs(num5);
		if (!(num4 < 2147483648.0))
		{
			num5 = -2147483648.0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+20]");
		object obj6 = num6 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+14]");
		object obj7 = obj6 / 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
		double num8 = default;
		double num7 = Math.Abs(num8);
		if (!(num7 < 2147483648.0))
		{
			num8 = -2147483648.0;
		}
		double num9 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+14]");
		double num10 = num9 * 0.0;
		double num11 = num10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+20]");
		double num12 = num11 + 0.0;
		Transform transform2 = base.transform;
		Vector3 localPosition2 = transform2.localPosition;
		double num13 = num2 * (double)spacing;
		double num14 = num13 + (double)offset;
		double num15 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+10]");
		double num16 = num15 * 0.0;
		double num17 = num16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SnapObject)+1C]");
		double num18 = num17 + 0.0;
		Transform transform3 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform3.localPosition = vector;
	}

	public SnapObject()
	{
		//IL_000f: Expected VT, but got I8
		//IL_0028: Expected I, but got Obj
		_ = 1092616192;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		offset = Vector3.zeroVector;
		base._002Ector();
	}
}
