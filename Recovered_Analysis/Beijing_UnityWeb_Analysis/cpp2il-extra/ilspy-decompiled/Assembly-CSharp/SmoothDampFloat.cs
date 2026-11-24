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
			return _smoothTime;
		}
		set
		{
			_smoothTime = value;
		}
	}

	public float SmoothTime
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

	public float Value
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

	public SmoothDampFloat(float value, float smoothTime)
	{
		_target = smoothTime;
		_smoothTime = value;
	}

	public void Update()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogWarning(this);
	}

	public override string ToString()
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_0016: Expected Obj, but got I4
		bool flag = _target > 15500f;
		return (string)flag;
	}
}
