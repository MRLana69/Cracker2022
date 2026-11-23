using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Inputs;

public class InputEventArgs : EventArgs
{
	private InputType _inputType;

	private float _timeStamp;

	private KeyCode _keyCode;

	public InputType InputType => _inputType;

	public float TimeStamp => _timeStamp;

	public KeyCode KeyCode => _keyCode;

	public InputEventArgs(InputType inputType)
	{
		_keyCode = KeyCode.None;
		_inputType = inputType;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		_timeStamp = timeSinceLevelLoad;
	}

	public InputEventArgs(InputType inputType, KeyCode keyCode)
	{
		_keyCode = keyCode;
		_inputType = inputType;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		_timeStamp = timeSinceLevelLoad;
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
		_ = _inputType;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = _timeStamp;
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = _keyCode;
		object obj5 = obj + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		object arg3 = default;
		return $"[InputEventArgs: InputType={arg}, TimeStamp={arg2}, KeyCode={arg3}]";
	}
}
