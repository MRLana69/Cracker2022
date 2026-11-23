using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Pickups;

public class PickupRotate : MonoBehaviour
{
	private Transform _target;

	private float _speed = 180f;

	private float _rotatePhase;

	private float _worldPosZ;

	private Vector3 _localEuler;

	private bool _willRotate;

	public bool WillRotate => _willRotate;

	public unsafe void Awake()
	{
		GameObject gameObject = base.gameObject;
		TrackObject component = gameObject.GetComponent<TrackObject>();
		if (component != null)
		{
			Action action = default;
			action._002Ector(this, (nint)__ldftn(PickupRotate.TrackObject_OnActivate));
			component.OnActivate += action;
			Action action2 = default;
			action2._002Ector(this, (nint)__ldftn(PickupRotate.TrackObject_OnDeactivate));
			component.OnDeactivate += action2;
		}
		_willRotate = false;
	}

	protected void OnDestroy()
	{
		_willRotate = false;
	}

	public unsafe void PhasedRotate(float time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005b: Expected F4, but got I
		//IL_0056: Expected native int or pointer, but got VT
		//IL_006a: Expected F4, but got VT
		//IL_0065: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		float num = time * _speed;
		float num2 = _worldPosZ * _rotatePhase;
		float num3 = num + num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.PickupRotate)+24]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)_localEuler;
		_target.localEulerAngles = vector;
	}

	private void Activate()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0047: Expected F4, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Transform transform = base.transform;
		Vector3 position = transform.position;
		_willRotate = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_worldPosZ = 0f;
	}

	private void StopRotating()
	{
		_willRotate = false;
	}

	private void PickupController_OnActivate()
	{
		Activate();
	}

	private void TrackObject_OnActivate()
	{
		Activate();
	}

	private void TrackObject_OnDeactivate()
	{
		_willRotate = false;
	}

	public PickupRotate()
	{
		//IL_001e: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8 (Il2CppStaticFields<UnityEngine.Vector3>)+20]");
		_ = 0;
		_localEuler = Vector3.upVector;
		_willRotate = true;
		base._002Ector();
	}
}
