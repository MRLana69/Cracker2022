using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class SmoothDampVector3
{
	private Vector3 _target;

	private float _smoothTime;

	private Vector3 _value;

	private Vector3 _velocity;

	public unsafe Vector3 Target
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SmoothDampVector3)+10]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_target = (Vector3)value.x;
			_ = value.z;
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

	public unsafe Vector3 Value
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SmoothDampVector3)+20]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_value = (Vector3)value.x;
			_ = value.z;
		}
	}

	public unsafe Vector3 Velocity
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_velocity;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SmoothDampVector3)+2C]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_value = (Vector3)value.x;
			_ = value.z;
		}
	}

	public SmoothDampVector3(Vector3 value, float smoothTime)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0054: Expected VT, but got F4
		//IL_006d: Expected VT, but got F4
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_velocity = Vector3.zeroVector;
		_smoothTime = smoothTime;
		_value = (Vector3)value.x;
		_ = value.z;
		_target = (Vector3)value.x;
		_ = value.z;
	}

	public unsafe void Update()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Ref, but got Unknown
		//IL_0038: Expected F4, but got VT
		//IL_0038: Expected F4, but got VT
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Ref, but got Unknown
		//IL_00e6: Expected F4, but got I
		//IL_00e6: Expected F4, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0050: Expected VT, but got F4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Ref, but got Unknown
		//IL_016c: Expected F4, but got I
		//IL_016c: Expected F4, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		ref float currentVelocity = ref *(float*)(this + 36);
		float deltaTime = Time.deltaTime;
		float num = Mathf.SmoothDamp((float)_value, (float)_target, ref currentVelocity, _smoothTime, float.PositiveInfinity, deltaTime);
		object obj = num & 0x7FFFFFFF;
		if ((nint)obj <= 2139095040)
		{
			_value = (Vector3)num;
		}
		ref float currentVelocity2 = ref *(float*)(this + 40);
		float deltaTime2 = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+1C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+C]");
		float num3 = Mathf.SmoothDamp(num2, 0f, ref currentVelocity2, _smoothTime, float.PositiveInfinity, deltaTime2);
		object obj2 = num3 & 0x7FFFFFFF;
		if ((nint)obj2 <= 2139095040)
		{
		}
		ref float currentVelocity3 = ref *(float*)(this + 44);
		float deltaTime3 = Time.deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+10]");
		float num5 = Mathf.SmoothDamp(num4, 0f, ref currentVelocity3, _smoothTime, float.PositiveInfinity, deltaTime3);
		object obj3 = num5 & 0x7FFFFFFF;
		if ((nint)obj3 > 2139095040)
		{
		}
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SmoothDampVector3)+10]");
		_ = 0;
		_ = _target;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}
}
