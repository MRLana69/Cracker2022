using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class RotateAroundTransform : MonoBehaviour
{
	private Transform _target;

	private Vector3 _offset;

	private Vector3 _eulerAngles;

	private float _distance;

	private Vector3 _lastMousePosition;

	private unsafe void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_03cc: Expected I, but got Obj
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_030c: Expected Obj, but got I
		//IL_0329: Expected Obj, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected VT, but got Unknown
		//IL_01ad: Expected I, but got Obj
		//IL_01cd: Expected Obj, but got VT
		//IL_01f7: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_0251: Invalid comparison between Obj and F4
		//IL_05ee: Expected Obj, but got I
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Expected Obj, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_0405: Expected I, but got Obj
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected VT, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected VT, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected VT, but got Unknown
		//IL_027a: Expected VT, but got F4
		//IL_02ba: Expected VT, but got I
		//IL_00da: Expected VT, but got I
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_0170: Expected Obj, but got I
		//IL_0548: Expected I, but got Obj
		//IL_0596: Expected F4, but got I
		//IL_0591: Expected native int or pointer, but got VT
		//IL_05a4: Expected F4, but got VT
		//IL_059f: Expected native int or pointer, but got VT
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected VT, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		if (!(_target != null))
		{
			return;
		}
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		float deltaTime = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		float num = 0f * deltaTime;
		float num2 = num * 10f;
		float distance = _distance - num2;
		_distance = distance;
		Vector3 lastMousePosition;
		if (Input.GetMouseButton(0))
		{
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			object obj2 = _lastMousePosition - Vector3.zeroVector;
			object obj3 = obj2 * obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+30]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v132 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			object obj4 = num5 - 0;
			object obj5 = obj4 * obj4;
			object obj6 = obj3 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+34]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v132 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			object obj7 = num6 - 0;
			object obj8 = obj7 * obj7;
			object obj9 = obj6 + obj8;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)9.9999994E-11f))
			{
				Vector3 mousePosition = Input.mousePosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_lastMousePosition = (Vector3)0;
			}
			Vector3 mousePosition2 = Input.mousePosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+30]");
			object obj10 = num7 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			object obj11 = 0 - _lastMousePosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+20]");
			object obj12 = 0 + obj11;
			float num8 = (float)_eulerAngles - (float)obj10;
			float num9 = Math.Min(num8, 89f);
			bool flag = num8 < -89f;
			float num10 = -89f;
			if (!flag)
			{
				num10 = num9;
			}
			_eulerAngles = (Vector3)num10;
			Vector3 mousePosition3 = Input.mousePosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
			lastMousePosition = (Vector3)0;
		}
		else
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v114 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v115 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			lastMousePosition = Vector3.zeroVector;
		}
		_lastMousePosition = lastMousePosition;
		Vector3 position = _target.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		object obj13 = 0 + _offset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+14]");
		object obj14 = num13 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+18]");
		object obj15 = num14 + 0;
		Transform transform = base.transform;
		float num15 = (float)_eulerAngles * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+20]");
		float num16 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+24]");
		float num17 = 0f * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Vector3 euler = vector + 80;
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(euler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		nint num18 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ S0_v58 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v59 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		_ = 0;
		_ = Vector3.forwardVector;
		Quaternion quaternion2 = (Quaternion)(vector - -64);
		Vector3 vector2 = vector + 48;
		Vector3 vector3 = quaternion2 * vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		float num20 = 0f * _distance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		float num21 = 0f * _distance;
		float num22 = (float)obj14 - num21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		float num23 = 0f * _distance;
		float num24 = (float)obj15 - num23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
		_ = 0;
		float num25 = (float)obj13 - num20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
		_ = 0;
		Vector3 position2 = vector + 32;
		transform.position = position2;
		Transform transform2 = base.transform;
		Vector3 position3 = _target.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		object obj16 = 0 + _offset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A4]");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+14]");
		object obj17 = num26 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (RotateAroundTransform)+18]");
		object obj18 = num27 + 0;
		nint num28 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v95 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ S0_v96 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.upVector;
		Vector3 worldPosition = vector + 16;
		transform2.LookAt(worldPosition, vector);
	}

	public RotateAroundTransform()
	{
		//IL_0013: Expected I, but got Obj
		//IL_008b: Expected I, but got Obj
		//IL_004e: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_offset = Vector3.zeroVector;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_eulerAngles = Vector3.zeroVector;
		_distance = 1f;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v27 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v28 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_lastMousePosition = Vector3.zeroVector;
		base._002Ector();
	}
}
