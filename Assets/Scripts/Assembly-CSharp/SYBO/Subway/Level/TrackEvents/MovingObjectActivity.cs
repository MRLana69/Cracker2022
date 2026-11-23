using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Routes;
using UnityEngine;

namespace SYBO.Subway.Level.TrackEvents;

public class MovingObjectActivity : Activity
{
	private PlaceholderLifecycle _movingObject;

	private float _speed;

	private float _desiredSpeed;

	private Transform _initialParent;

	private RouteChunk _routeChunk;

	public float Speed => _speed;

	protected override void Initialize()
	{
		base.Initialize();
	}

	public unsafe override void Prepare(IActivityInitializer initializer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0018: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected VT, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_014b: Expected F4, but got I
		//IL_0146: Expected native int or pointer, but got VT
		//IL_0166: Expected F4, but got I
		//IL_0161: Expected native int or pointer, but got VT
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj + -64);
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v23 @ S1_v41 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingObjectActivity>)+DC] (should have been resolved before IL gen)");
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
		action._002Ector(this, (nint)__ldftn(MovingObjectActivity.RouteChunk_OnDeactivate));
		_routeChunk.OnDeactivate += action;
		_movingObject.Spawn();
	}

	protected unsafe override void Execute()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_00e7: Expected F4, but got I
		//IL_00e2: Expected native int or pointer, but got VT
		//IL_0143: Expected F4, but got I
		//IL_013e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		UpdateCurrentChunk();
		Vector3 localPosition = _transform.localPosition;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+4C]");
		float num3 = 0f * _speed;
		float num4 = (float)Vector3.forwardVector * _speed;
		float deltaTime = Time.deltaTime;
		float num5 = num4 * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v20 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
		float num6 = 0f * _speed;
		float num7 = num6 * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		float num8 = 0f + num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		float num9 = num3 * deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
		float num10 = 0f + num9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		float num11 = 0f + num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		_transform.localPosition = vector;
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
			action._002Ector(this, (nint)__ldftn(MovingObjectActivity.RouteChunk_OnDeactivate));
			_routeChunk.OnDeactivate -= action;
			_routeChunk = (RouteChunk)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v21 (UnityEngine.Object)+68]");
			if ((nint)0 != 0)
			{
				Transform parent = _routeChunk.transform;
				_transform.parent = parent;
				Action action2 = default;
				action2._002Ector(this, (nint)__ldftn(MovingObjectActivity.RouteChunk_OnDeactivate));
				_routeChunk.OnDeactivate += action2;
			}
			else
			{
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v131 @ S1_v15 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingObjectActivity>)+EC] (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe override void Stop()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			_running = false;
			Action action = default;
			action._002Ector(this, (nint)__ldftn(MovingObjectActivity.RouteChunk_OnDeactivate));
			_routeChunk.OnDeactivate -= action;
			_movingObject.Despawn();
			PoolManager.Despawn(_transform);
		}
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
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S1_v3 (Il2CppClass<SYBO.Subway.Level.TrackEvents.MovingObjectActivity>)+EC] (should have been resolved before IL gen)");
		}
	}
}
