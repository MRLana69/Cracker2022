using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Data;

[Serializable]
public class SmoothDampVector3B
{
	private Vector3 _target;

	private Vector3 _smoothTime;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Common.Data.SmoothDampVector3B)+10]");
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

	public float TargetX
	{
		get
		{
			//IL_0007: Expected F4, but got VT
			return (float)_target;
		}
		set
		{
			//IL_000a: Expected VT, but got F4
			_target = (Vector3)value;
		}
	}

	public float TargetY
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+C]");
			return 0f;
		}
		set
		{
		}
	}

	public float TargetZ
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+10]");
			return 0f;
		}
		set
		{
		}
	}

	public unsafe Vector3 SmoothTime
	{
		get
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector3 vector = default;
			((Vector3*)(nint)vector)->x = (float)_smoothTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Common.Data.SmoothDampVector3B)+1C]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
		set
		{
			//IL_000f: Expected VT, but got F4
			_smoothTime = (Vector3)value.x;
			_ = value.z;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Common.Data.SmoothDampVector3B)+28]");
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
			((Vector3*)(nint)vector)->x = (float)_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Common.Data.SmoothDampVector3B)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			return vector;
		}
	}

	public SmoothDampVector3B(Vector3 value, Vector3 smoothTime)
	{
		//IL_0019: Expected VT, but got F4
		//IL_0032: Expected VT, but got F4
		//IL_004b: Expected VT, but got F4
		//IL_005e: Expected I, but got Obj
		_ = smoothTime.z;
		_smoothTime = (Vector3)smoothTime.x;
		_ = value.z;
		_value = (Vector3)value.x;
		_ = value.z;
		_target = (Vector3)value.x;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_velocity = Vector3.zeroVector;
	}

	public unsafe void Update()
	{
		//IL_000b: Invalid comparison between VT and F4
		//IL_01b3: Invalid comparison between I and F4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Ref, but got Unknown
		//IL_0065: Expected F4, but got VT
		//IL_0065: Expected F4, but got VT
		//IL_0065: Expected F4, but got VT
		//IL_0211: Invalid comparison between I and F4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Ref, but got Unknown
		//IL_00dd: Expected F4, but got I
		//IL_00dd: Expected F4, but got I
		//IL_00dd: Expected F4, but got I
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Ref, but got Unknown
		//IL_0151: Expected F4, but got I
		//IL_0151: Expected F4, but got I
		//IL_0151: Expected F4, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_007d: Expected VT, but got F4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		if (_smoothTime != (Vector3)(object)0f)
		{
			ref float currentVelocity = ref *(float*)(this + 44);
			float deltaTime = Time.deltaTime;
			float num = Mathf.SmoothDamp((float)_value, (float)_target, ref currentVelocity, (float)_smoothTime, float.PositiveInfinity, deltaTime);
			object obj = num & 0x7FFFFFFF;
			if ((nint)obj <= 2139095040)
			{
				_value = (Vector3)num;
			}
		}
		else
		{
			_value = _target;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+18]");
		if (0f != 0f)
		{
			ref float currentVelocity2 = ref *(float*)(this + 48);
			float deltaTime2 = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+24]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+C]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+18]");
			float num4 = Mathf.SmoothDamp(num2, num3, ref currentVelocity2, 0f, float.PositiveInfinity, deltaTime2);
			object obj2 = num4 & 0x7FFFFFFF;
			if ((nint)obj2 > 2139095040)
			{
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+C]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+1C]");
		if (0f != 0f)
		{
			ref float currentVelocity3 = ref *(float*)(this + 52);
			float deltaTime3 = Time.deltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+28]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+10]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+1C]");
			float num7 = Mathf.SmoothDamp(num5, num6, ref currentVelocity3, 0f, float.PositiveInfinity, deltaTime3);
			object obj3 = num7 & 0x7FFFFFFF;
			if ((nint)obj3 > 2139095040)
			{
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+10]");
			_ = 0;
		}
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Data.SmoothDampVector3B)+10]");
		_ = 0;
		_ = _target;
		object obj3 = obj + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}
}
