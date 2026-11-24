using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Google;

public class GoogleSignInPluginRequest
{
	private bool silent__BackingField;

	private int errorCode__BackingField;

	private string errorMessage__BackingField;

	public bool silent
	{
		get
		{
			return errorMessage__BackingField != null;
		}
		set
		{
			//IL_005c: Expected Obj, but got I4
			//IL_006e: Expected I4, but got Obj
			//IL_0080: Expected I, but got Obj
			//IL_0096: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			string text = string.Concat(this, value);
			string message = string.ConcatArray((string[])(object)"[GoogleSignIn] ", (int)text);
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v10 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogError(message);
		}
	}

	public int errorCode
	{
		get
		{
			return silent__BackingField ? 1 : 0;
		}
		set
		{
			int num = value & 1;
			silent__BackingField = (byte)num != 0;
		}
	}

	public string errorMessage
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (string)errorCode__BackingField;
		}
		set
		{
			//IL_000a: Expected I4, but got Obj
			errorCode__BackingField = (int)value;
		}
	}

	public IGoogleProfile profile
	{
		get
		{
			return (IGoogleProfile)(object)errorMessage__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = value;
		}
	}

	public GoogleSignInPluginRequest()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[GoogleSignIn] ", (int)this);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}
}
