using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common;
using SYBO.Components.Utilities;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarActivity : Activity
{
	private PlaceholderLifecycle _carPlaceholderLifecycle;

	private CollisionNotifier _brakingTrigger;

	private float _speed;

	private float _desiredSpeed;

	private float _acceleration;

	private float _brakeStartSpeed;

	private float _brakeEndSpeed;

	private float _brakeStartDistance;

	private bool _braking;

	private bool _carAheadMoveOpposite;

	private MovingCarActivity _carAhead;

	private Transform _carAheadTransforn;

	private Transform _initialParent;

	private BoxCollider _collider;

	private RouteChunk _routeChunk;

	private Collider _turnTrigger;

	private bool _turning;

	private Transform _turnTarget;

	private Vector3 _turnStartPos;

	private Quaternion _turnStartRotation;

	private Vector3 _vectStartToTarget;

	private Vector3 _turnStartPoint;

	private Vector3 _turnTargetPoint;

	private Vector3 _turnTargetDirectionForward;

	private Vector3 _turnTargetDirectionUp;

	private Quaternion _turnTargetRotation;

	private Vector3 _turnHalfWayPoint;

	private Vector3 _turnHalfWayDirectionForward;

	private Vector3 _turnHalfWayDirectionUp;

	private Quaternion _turnHalfWayRotation;

	public float Speed => _speed;

	protected override void Initialize()
	{
		base.Initialize();
		Collider component = GetComponent<Collider>();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		BoxCollider collider = default;
		_collider = collider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		throw new ArgumentException();
	}

	private unsafe void OnTriggerEnter(Collider trigger)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00ee: Expected VT, but got I
		//IL_013b: Expected VT, but got I
		//IL_0183: Expected VT, but got I
		//IL_01d0: Expected VT, but got I
		//IL_0218: Expected VT, but got I
		//IL_0265: Expected VT, but got I
		//IL_02a5: Expected VT, but got I
		//IL_02c2: Expected Obj, but got I
		//IL_02df: Expected Obj, but got I
		//IL_07d5: Expected Obj, but got VT
		//IL_081c: Invalid comparison between Obj and F4
		//IL_08c3: Expected I, but got Obj
		//IL_08e3: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected VT, but got Unknown
		//IL_0876: Expected Obj, but got I
		//IL_0893: Expected Obj, but got I
		//IL_08b0: Expected Obj, but got I
		//IL_0955: Invalid comparison between Obj and F4
		//IL_0a63: Expected I, but got Obj
		//IL_0a8c: Expected Obj, but got I
		//IL_0a9c: Expected Obj, but got I
		//IL_0360: Expected VT, but got Obj
		//IL_09c3: Expected Obj, but got I
		//IL_09e0: Expected Obj, but got I
		//IL_0a0a: Expected Obj, but got I
		//IL_0a34: Expected Obj, but got I
		//IL_0aee: Expected Obj, but got VT
		//IL_0b0b: Expected Obj, but got I
		//IL_0b35: Expected Obj, but got I
		//IL_0b55: Invalid comparison between Obj and F4
		//IL_0c03: Expected I, but got Obj
		//IL_0c2c: Expected Obj, but got I
		//IL_0c3c: Expected Obj, but got I
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected VT, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b89: Expected Obj, but got Unknown
		//IL_0b99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected Obj, but got Unknown
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected Obj, but got Unknown
		//IL_0c52: Expected Obj, but got VT
		//IL_0c6f: Expected Obj, but got I
		//IL_0c99: Expected Obj, but got I
		//IL_0435: Invalid comparison between Obj and F4
		//IL_0491: Expected F4, but got I
		//IL_048c: Expected native int or pointer, but got VT
		//IL_04a0: Expected F4, but got VT
		//IL_049b: Expected native int or pointer, but got VT
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected VT, but got Unknown
		//IL_04f8: Expected VT, but got I
		//IL_05a7: Expected VT, but got F4
		//IL_0e9e: Expected I, but got Obj
		//IL_0ebe: Expected F4, but got I
		//IL_0ec7: Expected F4, but got VT
		//IL_0ed7: Expected F4, but got I
		//IL_0daf: Expected VT, but got F4
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0def: Expected VT, but got Unknown
		//IL_0df8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfd: Expected VT, but got Unknown
		//IL_0e47: Expected VT, but got I
		//IL_0e6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6f: Expected VT, but got Unknown
		//IL_0797: Expected VT, but got F4
		object obj = default;
		Vector3 vector = (Vector3)(obj - 192);
		if (!trigger.CompareTag("TrackEvent"))
		{
			return;
		}
		MovingCarDirectionChange component = trigger.GetComponent<MovingCarDirectionChange>();
		if (!(component != null) || !(_turnTrigger != trigger) || _turning)
		{
			return;
		}
		_turnTrigger = trigger;
		_turning = true;
		_turnTarget = component._targetDirection;
		Vector3 position = _transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_turnStartPoint = (Vector3)0;
		Quaternion rotation = _transform.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_turnStartRotation = (Quaternion)0;
		Vector3 position2 = _turnTarget.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_turnTargetPoint = (Vector3)0;
		Vector3 forward = _turnTarget.forward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_turnTargetDirectionForward = (Vector3)0;
		Vector3 up = _turnTarget.up;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_turnTargetDirectionUp = (Vector3)0;
		Quaternion rotation2 = _turnTarget.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		_turnTargetRotation = (Quaternion)0;
		Vector3 position3 = _turnTarget.position;
		Vector3 position4 = _transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		Vector3 vector2 = (Vector3)(num - 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		object obj2 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		object obj3 = num3 - 0;
		_vectStartToTarget = vector2;
		object obj4 = vector2 * vector2;
		object obj5 = obj2 * obj2;
		object obj6 = obj4 + obj5;
		object obj7 = obj3 * obj3;
		object obj8 = obj6 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		object obj10;
		Vector3 vector4;
		object obj11;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
		{
			object obj9 = obj3 / obj8;
			Vector3 vector3 = vector2 / obj8;
			obj10 = obj2 / obj8;
			vector4 = vector3;
			obj11 = obj9;
		}
		else
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v310 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v311 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj10 = 0;
			vector4 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v311 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj11 = 0;
		}
		Vector3 up2 = _transform.up;
		Vector3 up3 = _turnTarget.up;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		object obj12 = num6 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		object obj13 = num7 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		object obj14 = num8 + 0;
		object obj15 = obj12 * obj12;
		object obj16 = obj13 * obj13;
		object obj17 = obj15 + obj16;
		object obj18 = obj14 * obj14;
		object obj19 = obj17 + obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		Vector3 turnHalfWayDirectionUp;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj19) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
		{
			object obj20 = obj14 / obj19;
			object obj21 = obj13 / obj19;
			turnHalfWayDirectionUp = (Vector3)(obj12 / obj19);
			object obj22 = obj20;
			object obj23 = obj21;
		}
		else
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S1_v291 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num10 = 0;
			turnHalfWayDirectionUp = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S1_v292 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S1_v292 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			object obj23 = 0;
		}
		_turnHalfWayDirectionUp = turnHalfWayDirectionUp;
		Quaternion rotation3 = _transform.rotation;
		Quaternion rotation4 = _turnTarget.rotation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		object obj24 = num11 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		object obj25 = num12 * 0;
		object obj26 = obj24 + obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		object obj27 = num13 * 0;
		object obj28 = obj26 + obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+5C]");
		object obj29 = num14 * 0;
		float value = (float)obj28 + (float)obj29;
		float num15 = Math.Abs(value);
		if (!(num15 < 1f))
		{
			num15 = 1f;
		}
		bool flag = num15 > 0.999999f;
		bool flag2 = !flag;
		bool flag3 = !flag2;
		float num16 = 0f;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EAD");
			object obj31 = default;
			object obj30 = obj31 + obj31;
			float num17 = (float)obj30 * 57.29578f;
			num16 = num17;
		}
		Vector3 forward2 = _transform.forward;
		object obj32 = _vectStartToTarget * _vectStartToTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		object obj33 = num18 * 0;
		object obj34 = obj32 + obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		object obj35 = num19 * 0;
		object obj36 = obj34 + obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		Vector3 vector5;
		object obj39;
		object obj40;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj36) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
			object obj37 = 0 / obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
			object obj38 = 0 / obj36;
			vector5 = _vectStartToTarget / obj36;
			obj39 = obj37;
			obj40 = obj38;
		}
		else
		{
			nint num20 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S1_v268 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num21 = 0;
			vector5 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S1_v269 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S1_v269 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj40 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+50]");
		object obj41 = 0 * vector5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+54]");
		object obj42 = 0 * obj40;
		object obj43 = obj41 + obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+58]");
		object obj44 = 0 * obj39;
		object obj45 = obj43 + obj44;
		if (num16 > 90f && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj45) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f))
		{
			_turnHalfWayDirectionForward = vector4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+D8]");
			_ = 0;
			_ = _turnHalfWayDirectionForward;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+E4]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)_turnHalfWayDirectionUp;
			Vector3 forward3 = vector + 16;
			Quaternion quaternion = Quaternion.LookRotation(forward3, vector);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			_turnHalfWayRotation = (Quaternion)0;
			Vector3 position5 = _transform.position;
			float num22 = (float)_vectStartToTarget * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
			float num23 = 0f + num22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
			float num24 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
			float num25 = 0f + num24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
			float num26 = 0f * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
			float num27 = 0f + num26;
			_turnHalfWayPoint = (Vector3)num23;
			return;
		}
		object obj46 = _vectStartToTarget * _vectStartToTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		object obj47 = num28 * 0;
		object obj48 = obj46 + obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		nint num29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		object obj49 = num29 * 0;
		object obj50 = obj48 + obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num30 = (float)obj50 * 0.5f;
		float num31 = num16 * 0.5f;
		float num32 = num31 * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @331");
		object obj51 = default;
		float num33 = num30 / (float)obj51;
		float num34 = num16 * 0.5f;
		float num35 = num34 * ((float)Math.PI / 180f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @332");
		object obj52 = default;
		float num36 = num33 * (float)obj52;
		float num37 = num33 - num36;
		float num38 = (float)_turnTargetDirectionForward * 0.2f;
		float num39 = (float)vector4 - num38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+A0]");
		float num40 = 0f * 0.2f;
		float num41 = (float)obj10 - num40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+A4]");
		float num42 = 0f * 0.2f;
		float num43 = (float)obj11 - num42;
		float num44 = num39 * num39;
		float num45 = num41 * num41;
		float num46 = num44 + num45;
		float num47 = num43 * num43;
		float num48 = num46 + num47;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num52;
		if (num48 > 1E-05f)
		{
			float num49 = num43 / num48;
			float num50 = num39 / num48;
			float num51 = num41 / num48;
			num52 = num50;
			float num53 = num49;
		}
		else
		{
			nint num54 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ S0_v250 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ S0_v251 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			float num51 = 0f;
			num52 = (float)Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ S0_v251 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			float num53 = 0f;
		}
		_turnHalfWayDirectionForward = (Vector3)num52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+D8]");
		_ = 0;
		_ = _turnHalfWayDirectionForward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+E4]");
		_ = 0;
		_ = _turnHalfWayDirectionUp;
		Vector3 forward4 = vector - -64;
		Vector3 upwards = vector + 48;
		Quaternion quaternion2 = Quaternion.LookRotation(forward4, upwards);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		_turnHalfWayRotation = (Quaternion)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+A0]");
		_ = 0;
		Quaternion q = (Quaternion)(vector + 32);
		Vector3 rightVector = Math3D.GetRightVector(q);
		Vector3 position6 = _transform.position;
		float num56 = (float)_vectStartToTarget * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		float num57 = 0f + num56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+90]");
		float num58 = 0f * num37;
		float num59 = num57 + num58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		float num60 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
		float num61 = 0f + num60;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+94]");
		float num62 = 0f * num37;
		float num63 = num61 + num62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		float num64 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		float num65 = 0f + num64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+98]");
		float num66 = 0f * num37;
		float num67 = num65 + num66;
		_turnHalfWayPoint = (Vector3)num59;
	}

	protected void OnDrawGizmosSelected()
	{
	}

	public unsafe override void Prepare(IActivityInitializer initializer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0018: Expected I, but got Obj
		//IL_00d4: Expected I, but got Obj
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected VT, but got Unknown
		//IL_0141: Expected I, but got Obj
		//IL_0173: Expected F4, but got I
		//IL_016e: Expected native int or pointer, but got VT
		//IL_018e: Expected F4, but got I
		//IL_0189: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v45 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingCarActivity>)+DC] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Transform initialParent = default;
		_initialParent = initialParent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		Transform parent = default;
		_transform.parent = parent;
		nint num2 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v23 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v24 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		_ = 0;
		Vector3 localPosition = (Vector3)(quaternion + 16);
		_transform.localPosition = localPosition;
		nint num4 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v38 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v39 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+28]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+20]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		_transform.localRotation = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2CB");
		float num6 = default;
		_speed = num6;
		_desiredSpeed = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		RouteChunk routeChunk = default;
		_routeChunk = routeChunk;
		Action action = default;
		action._002Ector(this, (nint)__ldftn(MovingCarActivity.RouteChunk_OnDeactivate));
		_routeChunk.OnDeactivate += action;
		_turning = false;
		_running = false;
		_turnTrigger = null;
		_braking = false;
		_carPlaceholderLifecycle.Spawn();
	}

	protected unsafe override void Execute()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0122: Expected F4, but got I
		//IL_011d: Expected native int or pointer, but got VT
		//IL_017e: Expected F4, but got I
		//IL_0179: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		UpdateCurrentChunk();
		if (~(_turning ? 1u : 0u) == 0)
		{
			Turn();
		}
		if (~(_braking ? 1u : 0u) == 0)
		{
			Brake();
		}
		Vector3 position = _transform.position;
		Vector3 forward = _transform.forward;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num = 0f * _speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num2 = 0f * _speed;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num3 = 0f * _speed;
		float deltaTime = Time.deltaTime;
		float num4 = num3 * deltaTime;
		float num5 = num2 * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num6 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		float num7 = num * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num8 = 0f + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num9 = 0f + num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		_transform.position = vector;
	}

	private unsafe void UpdateCurrentChunk()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0178: Invalid comparison between I and F4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_013b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 position = _transform.position;
		float posStartZ = _routeChunk.PosStartZ;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3;
		if (0f < posStartZ)
		{
			obj3 = _routeChunk + 68;
		}
		else
		{
			Vector3 posEnd = _routeChunk.PosEnd;
			Vector3 position2 = _transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			if (num >= 0)
			{
				return;
			}
			obj3 = _routeChunk + 72;
		}
		UnityEngine.Object obj4 = (UnityEngine.Object)obj3;
		if ((UnityEngine.Object)obj3 != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(MovingCarActivity.RouteChunk_OnDeactivate));
			_routeChunk.OnDeactivate -= action;
			_routeChunk = (RouteChunk)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21 (UnityEngine.Object)+68]");
			if ((nint)0 != 0)
			{
				Transform parent = _routeChunk.transform;
				_transform.parent = parent;
				Action action2 = default;
				action2._002Ector(this, (nint)__ldftn(MovingCarActivity.RouteChunk_OnDeactivate));
				_routeChunk.OnDeactivate += action2;
			}
			else
			{
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S1_v15 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingCarActivity>)+EC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe override void Stop()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			_running = false;
			_turnTrigger = null;
			_braking = false;
			_turning = false;
			_carAhead = null;
			_brakingTrigger.ClearFrame();
			Action action = default;
			action._002Ector(this, (nint)__ldftn(MovingCarActivity.RouteChunk_OnDeactivate));
			_routeChunk.OnDeactivate -= action;
			_carPlaceholderLifecycle.Despawn();
			PoolManager.Despawn(_transform);
		}
	}

	private unsafe void Turn()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I
		//IL_006e: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got VT
		//IL_02d6: Expected Obj, but got I
		//IL_0300: Expected Obj, but got I
		//IL_0320: Invalid comparison between Obj and F4
		//IL_0393: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_03cc: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected VT, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got VT
		//IL_0428: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected VT, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected VT, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected VT, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected VT, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected VT, but got Unknown
		//IL_015d: Expected F4, but got I
		//IL_0158: Expected native int or pointer, but got VT
		//IL_017f: Expected F4, but got I
		//IL_017a: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 144);
		Vector3 position = _transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
		object obj2 = 0 - _turnStartPoint;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+84]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+88]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+8C]");
		object obj4 = num2 - 0;
		object obj5 = _vectStartToTarget * _vectStartToTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		object obj6 = num3 * 0;
		object obj7 = obj5 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		object obj8 = num4 * 0;
		object obj9 = obj7 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		object obj11;
		Vector3 vector2;
		object obj12;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1E-05f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
			object obj10 = 0 / obj9;
			Vector3 vector = _vectStartToTarget / obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
			obj11 = 0 / obj9;
			vector2 = vector;
			obj12 = obj10;
		}
		else
		{
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v94 (Il2CppStaticFields<UnityEngine.Vector3>)+4]");
			obj11 = 0;
			vector2 = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v94 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			obj12 = 0;
		}
		object obj13 = obj2 * vector2;
		object obj14 = obj3 * obj11;
		object obj15 = obj13 + obj14;
		object obj16 = obj4 * obj12;
		object obj17 = obj15 + obj16;
		object obj18 = _vectStartToTarget * _vectStartToTarget;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+7C]");
		object obj19 = num7 * 0;
		object obj20 = obj18 + obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+80]");
		object obj21 = num8 * 0;
		object obj22 = obj20 + obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num9 = (float)obj17 / (float)obj22;
		bool flag = num9 > 0.99f;
		float num10 = 1f;
		if (!flag)
		{
			num10 = num9;
		}
		if (num10 < 0.5f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+70]");
			_ = 0;
			_ = _turnStartRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+F0]");
			_ = 0;
			_ = _turnHalfWayRotation;
			Quaternion a = (Quaternion)(quaternion + 32);
			Quaternion b = (Quaternion)(quaternion + 16);
			float t = num10 + num10;
			Quaternion quaternion2 = Quaternion.Lerp(a, b, t);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
			((Quaternion*)(nint)quaternion)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
			((Quaternion*)(nint)quaternion)->x = 0f;
			_transform.rotation = quaternion;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+F0]");
			_ = 0;
			_ = _turnHalfWayRotation;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.TrackEvents.MovingCarActivity)+BC]");
			_ = 0;
			_ = _turnTargetRotation;
			Quaternion a2 = (Quaternion)(quaternion + 80);
			Quaternion b2 = (Quaternion)(quaternion - -64);
			float num11 = num10 - 0.5f;
			float t2 = num11 + num11;
			Quaternion quaternion3 = Quaternion.Lerp(a2, b2, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+88]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+80]");
			_ = 0;
			Quaternion rotation = (Quaternion)(quaternion + 48);
			_transform.rotation = rotation;
		}
		if (!(num10 < 1f))
		{
			_turnTrigger = null;
			_turning = false;
		}
	}

	private void Brake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_013b: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_0092: Invalid comparison between Obj and F4
		object obj2 = default;
		object obj = obj2 - 16;
		MovingCarActivity carAhead = _carAhead;
		if (~(carAhead._running ? 1u : 0u) != 0)
		{
			_braking = false;
		}
		Vector3 vector = GapStartPoint();
		Vector3 vector2 = GapEndPoint();
		MovingCarActivity carAhead2 = _carAhead;
		float num = _brakeStartSpeed - carAhead2._speed;
		object obj3 = obj - obj;
		object obj4 = obj3 * obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		object obj5 = num2 - 0;
		object obj6 = obj5 * obj5;
		object obj7 = obj4 + obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj8 = num3 - 0;
		object obj9 = obj8 * obj8;
		object obj10 = obj7 + obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		float num4 = (float)obj10 / _brakeStartDistance;
		float num5 = Math.Min(num4, 1f);
		bool flag = num4 < 0f;
		float val = 0f;
		if (!flag)
		{
			val = num5;
		}
		float num6 = Math.Max(val, 0f);
		float num7 = num * num6;
		float num8 = (_speed = carAhead2._speed + num7);
		MovingCarActivity carAhead4 = default;
		if (!(num8 < 1f))
		{
			MovingCarActivity carAhead3 = _carAhead;
			float num9 = num8 - carAhead3._speed;
			bool flag2 = num9 < 1f;
			bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)1f);
			bool flag4 = true;
			if (!flag3)
			{
				flag4 = flag2;
			}
			if (!flag4)
			{
				return;
			}
			carAhead4 = _carAhead;
		}
		_braking = false;
		_speed = carAhead4._speed;
	}

	private unsafe Vector3 GapStartPoint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected Obj, but got Unknown
		//IL_010a: Expected native int or pointer, but got VT
		//IL_014d: Expected native int or pointer, but got VT
		//IL_0179: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		Vector3 position = _transform.position;
		Vector3 center = _collider.center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj3 = num + 0;
		Vector3 forward = _transform.forward;
		float num2 = (float)obj * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num3 = 0f * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num4 = 0f * 0.5f;
		Vector3 size = _collider.size;
		Vector3 size2 = _collider.size;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		object obj4 = 0 + obj;
		float num5 = num2 * (float)obj4;
		float num6 = num4 * (float)obj4;
		float z = (float)obj3 + num6;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num7 = 0f + 0f;
		float num8 = num3 * (float)obj4;
		float y = num7 + num8;
		((Vector3*)(nint)vector)->y = y;
		float num9 = (float)obj + 0f;
		float x = num9 + num5;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}

	private unsafe Vector3 GapEndPoint()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_011b: Expected native int or pointer, but got VT
		//IL_0166: Expected native int or pointer, but got VT
		//IL_0192: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		MovingCarActivity carAhead = _carAhead;
		Vector3 position = carAhead._transform.position;
		MovingCarActivity carAhead2 = _carAhead;
		Vector3 forward = carAhead2._transform.forward;
		float num = 1f;
		if (!_carAheadMoveOpposite)
		{
			num = -1f;
		}
		float num2 = (float)obj * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float num3 = 0f * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num4 = 0f * num;
		Vector3 size = _collider.size;
		float num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num6 = num5 * 0f;
		float num7 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num8 = num7 * 0f;
		float num9 = num8 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float z = 0f + num9;
		Vector3 vector = default;
		((Vector3*)(nint)vector)->z = z;
		float num10 = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		float num11 = num10 * 0f;
		float num12 = num11 * 0.5f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
		float y = 0f + num12;
		((Vector3*)(nint)vector)->y = y;
		float num13 = num6 * 0.5f;
		float x = (float)obj + num13;
		((Vector3*)(nint)vector)->x = x;
		return vector;
	}

	private void RouteChunk_OnDeactivate()
	{
		//IL_001e: Expected I, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		if (~(_running ? 1u : 0u) == 0)
		{
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingCarActivity>)+EC] (should have been resolved before IL gen)");
		}
	}

	private void BrakingTrigger_OnEnter(Collider otherCollider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0106: Invalid comparison between Obj and F4
		//IL_01b6: Expected Obj, but got I
		//IL_01ed: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		MovingCarActivity component = otherCollider.GetComponent<MovingCarActivity>();
		if (component != null && component != this)
		{
			_carAhead = component;
			Transform carAheadTransforn = component.transform;
			_carAheadTransforn = carAheadTransforn;
			Vector3 forward = _transform.forward;
			Vector3 forward2 = _carAheadTransforn.forward;
			object obj3 = obj * obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj4 = num * 0;
			object obj5 = obj3 + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj6 = num2 * 0;
			object obj7 = obj5 + obj6;
			_braking = true;
			bool carAheadMoveOpposite = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)0f);
			_carAheadMoveOpposite = carAheadMoveOpposite;
			Vector3 vector = GapStartPoint();
			Vector3 vector2 = GapEndPoint();
			object obj8 = obj - obj;
			object obj9 = obj8 * obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
			object obj10 = num3 - 0;
			object obj11 = obj10 * obj10;
			object obj12 = obj9 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj13 = num4 - 0;
			object obj14 = obj13 * obj13;
			float brakeStartDistance = (float)obj12 + (float)obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
			_brakeStartDistance = brakeStartDistance;
			_brakeStartSpeed = _speed;
			float brakeEndSpeed;
			if (~(_carAheadMoveOpposite ? 1u : 0u) == 0)
			{
				brakeEndSpeed = 0f;
			}
			else
			{
				MovingCarActivity carAhead = _carAhead;
				brakeEndSpeed = carAhead._speed;
			}
			_brakeEndSpeed = brakeEndSpeed;
		}
	}

	private void BrakingTrigger_OnExit(Collider otherCollider)
	{
		MovingCarDirectionChange component = otherCollider.GetComponent<MovingCarDirectionChange>();
		MovingCarActivity component2 = otherCollider.GetComponent<MovingCarActivity>();
		if (component == null && component2 != this && component2 != null)
		{
			_braking = false;
		}
	}
}
