using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents.CarActivities;

public class LerpedTurn : MonoBehaviour, ITurnable
{
	protected MovingCarActivity _movingCarActivity;

	protected bool _turning;

	protected float _colliderPassProgress;

	private Transform _transform;

	private Collider _turnTrigger;

	private Transform _turnTarget;

	private Quaternion _turnStartRotation;

	private float _distanceStartToTarget;

	private Vector3 _vectStartToTarget;

	private Vector3 _dirToTarget;

	private Vector3 _turnStartPoint;

	private Vector3 _turnTargetDirectionForward;

	private Quaternion _turnTargetRotation;

	private Vector3 _turnHalfWayDirectionForward;

	private Vector3 _turnHalfWayDirectionUp;

	private Quaternion _turnHalfWayRotation;

	public void Init(MovingCarActivity movingCarActivity)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = (Delegate)(object)_turnTarget;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)movingCarActivity);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 32;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void Reset()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public void StartTurning(Collider trigger)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		object obj = this + 24;
		GameObject gameObject = trigger.gameObject;
		obj = gameObject;
		object obj2 = this + 12;
		obj2 = trigger;
	}

	public virtual void Turn()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0014: Expected Obj, but got I4
		object obj = this + 28;
		obj = 0;
		_turning = false;
	}

	public unsafe LerpedTurn()
	{
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected VT, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected VT, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected Obj, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0014: Expected VT, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0042: Expected I, but got Obj
		//IL_0058: Expected Obj, but got I
		//IL_028b: Expected F4, but got Obj
		//IL_0286: Expected native int or pointer, but got VT
		//IL_029d: Expected F4, but got I
		//IL_0298: Expected native int or pointer, but got VT
		//IL_02aa: Expected F4, but got Obj
		//IL_02a5: Expected native int or pointer, but got VT
		//IL_02bf: Expected F4, but got I
		//IL_02ba: Expected native int or pointer, but got VT
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected Obj, but got Unknown
		//IL_0312: Expected F4, but got Obj
		//IL_030d: Expected native int or pointer, but got VT
		//IL_0327: Expected F4, but got I
		//IL_0322: Expected native int or pointer, but got VT
		//IL_0334: Expected F4, but got Obj
		//IL_032f: Expected native int or pointer, but got VT
		//IL_0349: Expected F4, but got I
		//IL_0344: Expected native int or pointer, but got VT
		//IL_0083: Expected I, but got Obj
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_042f: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_0470: Expected F4, but got Obj
		//IL_046b: Expected native int or pointer, but got VT
		//IL_0482: Expected F4, but got I
		//IL_047d: Expected native int or pointer, but got VT
		//IL_048f: Expected F4, but got Obj
		//IL_048a: Expected native int or pointer, but got VT
		//IL_04a4: Expected F4, but got I
		//IL_049f: Expected native int or pointer, but got VT
		//IL_04c6: Expected F4, but got Obj
		//IL_04c1: Expected native int or pointer, but got VT
		//IL_04db: Expected F4, but got I
		//IL_04d6: Expected native int or pointer, but got VT
		//IL_04e4: Expected Obj, but got VT
		//IL_01ae: Expected I, but got Obj
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected Obj, but got Unknown
		//IL_020c: Expected Obj, but got I4
		object obj = default;
		Vector3 vector = (Vector3)(obj + 88);
		Vector3 vector2 = (Vector3)(obj + 72);
		Transform transform = (Transform)(obj + 56);
		object obj2 = obj + 40;
		object obj3 = obj + 24;
		object obj4 = obj + 12;
		if (~(_turning ? 1u : 0u) != 0)
		{
			return;
		}
		transform.position = (Vector3)_transform;
		object obj5 = this + 80;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v13+8]");
		_ = 0;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v97 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		_ = 0;
		object obj7 = this + 68;
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S1_v32+8]");
		_ = 0;
		((Vector3*)(nint)vector2)->x = (float)obj4;
		Vector3 vector4 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector5 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		float num3 = vector2.x * vector.x;
		float num4 = vector2.y * vector.y;
		float num5 = num3 + num4;
		float num6 = vector2.z * vector.z;
		float num7 = num5 + num6;
		float colliderPassProgress = num7 / _distanceStartToTarget;
		_colliderPassProgress = colliderPassProgress;
		if (_colliderPassProgress > 0.99f)
		{
			_colliderPassProgress = 1f;
		}
		float maxDegreesDelta;
		if (_colliderPassProgress < 0.5f)
		{
			object obj8 = this + 36;
			transform = (Transform)obj8;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v86+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			object obj9 = this + 144;
			obj2 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v91+8]");
			_ = 0;
			maxDegreesDelta = _colliderPassProgress * 2f;
		}
		else
		{
			object obj10 = this + 144;
			transform = (Transform)obj10;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v74+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			object obj11 = this + 104;
			obj2 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S1_v79+8]");
			_ = 0;
			float num8 = _colliderPassProgress - 0.5f;
			maxDegreesDelta = num8 * 2f;
		}
		nint num9 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v57 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v75 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Quaternion quaternion2 = Quaternion.RotateTowards((Quaternion)vector2, (Quaternion)vector, maxDegreesDelta);
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector7 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17+8]");
		((Vector3*)(nint)vector7)->z = 0f;
		Quaternion localRotation = ((Transform)vector).localRotation;
		if (!(_colliderPassProgress < 1f))
		{
			_turning = false;
			object obj13 = this + 28;
			obj13 = 0;
		}
	}
}
