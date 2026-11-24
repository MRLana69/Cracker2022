using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;
using SYBO.Subway.Coins;
using UnityEngine;

namespace SYBO.Subway.Inputs;

public class Swipe
{
	public Vector3 start;

	public Vector3 end;

	public float startTime;

	public float endTime;

	public override string ToString()
	{
		//IL_00e7: Expected Obj, but got I
		//IL_00ef: Invalid comparison between F4 and Obj
		//IL_0099: Expected Obj, but got I4
		//IL_0040: Expected Obj, but got I4
		//IL_00a8: Expected I4, but got Obj
		//IL_004f: Expected I4, but got Obj
		//IL_0058: Expected Obj, but got I4
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		Vector3 vector = end;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Inputs.Swipe)+28]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (UnityEngine.Vector3)+C]");
		object obj = num + 0;
		bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)timeSinceLevelLoad) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Inputs.Swipe)+2C]");
		bool flag2 = (nint)0 != 0;
		string result;
		if (flag)
		{
			if (flag2)
			{
				result = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager = default;
				inputManager.OnInputEvent += (EventHandler<InputEventArgs>)6;
				((Coin)this).ToggleRenderer((byte)(int)inputManager != 0);
				result = (string)1;
			}
		}
		else
		{
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InputManager inputManager2 = default;
				inputManager2.OnInputEvent += (EventHandler<InputEventArgs>)5;
				((Coin)this).ToggleRenderer((byte)(int)inputManager2 != 0);
			}
			result = null;
		}
		_ = 0;
		float timeSinceLevelLoad2 = Time.timeSinceLevelLoad;
		return result;
	}

	public Swipe()
	{
		_ = 1;
		_ = float.MinValue;
		((Validator<>)this)._002Ector();
	}
}
