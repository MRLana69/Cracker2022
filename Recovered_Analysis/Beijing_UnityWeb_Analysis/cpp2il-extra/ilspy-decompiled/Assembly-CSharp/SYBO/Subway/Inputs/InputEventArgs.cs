using System;
using Cpp2ILInjected;
using SYBO.Subway.Pickups;
using UnityEngine;

namespace SYBO.Subway.Inputs;

public class InputEventArgs : EventArgs
{
	private InputType _inputType;

	private float _timeStamp;

	private KeyCode _keyCode;

	public InputType InputType => InputType.None;

	public float TimeStamp
	{
		get
		{
			//IL_0017: Expected F4, but got I
			KeyCode keyCode = _keyCode;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (UnityEngine.KeyCode)+1C]");
			return 0f;
		}
	}

	public KeyCode KeyCode => (KeyCode)_inputType;

	public InputEventArgs(InputType inputType)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got F4
		//IL_003d: Expected Obj, but got F4
		object obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputType @ L1 (SYBO.Subway.Inputs.InputType)+1C]");
		if ((nint)0 != 0)
		{
			obj = 0.05f;
			_ = 0f;
			_ = 0f;
			_ = 0.05f;
		}
		else
		{
			obj = 0.4f;
			_ = -0.3f;
			_ = 0.2f;
			_ = 0.81f;
		}
		InputEventArgs e = (InputEventArgs)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_inputType = InputType.None;
	}

	public InputEventArgs(InputType inputType, KeyCode keyCode)
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_006f: Expected Obj, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0089: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got F4
		//IL_0095: Expected Obj, but got I4
		//IL_002c: Expected I4, but got Obj
		object obj = this + 12;
		obj = inputType;
		object obj2 = this + 16;
		bool flag = ((PickupManager)_timeStamp).IsSpawned((Transform)keyCode);
		obj2 = flag;
		if (_keyCode == KeyCode.None)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string[] values = default;
			string message = string.ConcatArray(values, (int)".pickerData must be not-null. Fix immediately");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MissingReferenceException ex = default;
			ex._002Ector(message);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public override string ToString()
	{
		//IL_0007: Expected Obj, but got I4
		return (string)_keyCode;
	}
}
