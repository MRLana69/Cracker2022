using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class SmoothDampFloat
{
	private float _target;

	private float _smoothTime;

	private float _value;

	public float valueSpeed;

	public float Target
	{
		get
		{
			return _target;
		}
		set
		{
			_target = value;
		}
	}

	public float SmoothTime
	{
		get
		{
			return _smoothTime;
		}
		set
		{
			_smoothTime = value;
		}
	}

	public float Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public SmoothDampFloat(float value, float smoothTime)
	{
		_value = value;
		_smoothTime = smoothTime;
		_target = value;
	}

	public unsafe void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		ref float currentVelocity = ref *(float*)(this + 20);
		float deltaTime = Time.deltaTime;
		float num = Mathf.SmoothDamp(_value, _target, ref currentVelocity, _smoothTime, float.PositiveInfinity, deltaTime);
		object obj = num & 0x7FFFFFFF;
		if ((nint)obj <= 2139095040)
		{
			_value = num;
		}
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = _target;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = _value;
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = _smoothTime;
		object obj5 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		return $"[SmoothDampFloat: t={arg}, v={arg2}, time={arg3}]";
	}
}
