using System;
using Cpp2ILInjected;
using UnityEngine;

public class CelebrationCircularCloner : MonoBehaviour
{
	public enum Axis
	{
		X,
		Y,
		Z
	}

	private GameObject _targetObject;

	private int _copyCount = 4;

	private bool _destroyOriginal = true;

	private float _radius = 1f;

	private Axis _axis;

	private bool _alignToCloner = true;

	private unsafe void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a3: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected VT, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected VT, but got Unknown
		//IL_02f0: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected VT, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected VT, but got Unknown
		//IL_0266: Expected F4, but got I
		//IL_0261: Expected native int or pointer, but got VT
		//IL_0288: Expected F4, but got I
		//IL_0283: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 176);
		_ = 0;
		_ = 0;
		if (!(_targetObject != null))
		{
			return;
		}
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Transform transform2 = _targetObject.transform;
		Quaternion rotation = transform2.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		int num = 0;
		while (_copyCount > num)
		{
			Vector3 vector2 = CalcCenterOffset(num);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			object obj2 = num2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
			object obj3 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			object obj4 = num4 + 0;
			if (~(_alignToCloner ? 1u : 0u) == 0)
			{
				Transform transform3 = base.transform;
				Vector3 up = transform3.up;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
				object obj5 = 0 - obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+88]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
				object obj6 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				object obj7 = 0 - obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+80]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
				_ = 0;
				Vector3 forward = vector - -64;
				Vector3 upwards = vector + 48;
				Quaternion quaternion = Quaternion.LookRotation(forward, upwards);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 position2 = vector + 32;
			Quaternion rotation2 = (Quaternion)(vector + 16);
			GameObject gameObject = UnityEngine.Object.Instantiate(_targetObject, position2, rotation2);
			Transform transform4 = gameObject.transform;
			Transform parent = base.transform;
			transform4.parent = parent;
			Transform transform5 = gameObject.transform;
			Transform transform6 = _targetObject.transform;
			Vector3 localScale = transform6.localScale;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			((Vector3*)(nint)vector)->x = 0f;
			transform5.localScale = vector;
			int num5 = num + 1;
			num = num5;
		}
		if (~(_destroyOriginal ? 1u : 0u) == 0)
		{
			object obj8 = this + 12;
			UnityEngine.Object.Destroy((UnityEngine.Object)obj8);
			obj8 = 0;
		}
	}

	private unsafe Vector3 CalcCenterOffset(int index)
	{
		//IL_018a: Expected I, but got Obj
		//IL_01f1: Expected native int or pointer, but got VT
		//IL_01fe: Expected native int or pointer, but got VT
		//IL_020b: Expected native int or pointer, but got VT
		//IL_0053: Expected F4, but got I
		//IL_005c: Expected F4, but got VT
		//IL_006c: Expected F4, but got I
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)index * (float)Math.PI;
		float num4 = num3 + num3;
		float num5 = num4 / (float)_copyCount;
		float y;
		float x;
		float z;
		if (_axis != Axis.X)
		{
			if (_axis != Axis.Y)
			{
				if (_axis != Axis.Z)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
					y = 0f;
					x = (float)Vector3.zeroVector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
					z = 0f;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
					object obj = default;
					float num6 = (float)obj * _radius;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
					object obj2 = default;
					float num7 = (float)obj2 * _radius;
					y = num7;
					x = num6;
					z = 0f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
				object obj3 = default;
				float num8 = (float)obj3 * _radius;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
				object obj4 = default;
				float num9 = (float)obj4 * _radius;
				y = 0f;
				x = num8;
				z = num9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
			object obj5 = default;
			float num10 = (float)obj5 * _radius;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
			object obj6 = default;
			float num11 = (float)obj6 * _radius;
			y = num10;
			x = 0f;
			z = num11;
		}
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		((Vector3*)(nint)vector)->y = y;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}
}
