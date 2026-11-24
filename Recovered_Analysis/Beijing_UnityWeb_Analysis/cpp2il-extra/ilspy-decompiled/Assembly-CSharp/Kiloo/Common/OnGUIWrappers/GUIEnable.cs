using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIEnable : IDisposable
{
	private bool PreviousState__BackingField;

	private bool PreviousState
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"" != 0;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool usePageScrollbars = GUI.usePageScrollbars;
			PreviousState__BackingField = usePageScrollbars;
			GUI.GrabMouseControl(value ? 1 : 0);
		}
	}

	public GUIEnable(bool newState)
	{
		PreviousState__BackingField = newState;
	}

	public void Dispose()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v8 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUI.GrabMouseControl(PreviousState__BackingField ? 1 : 0);
	}
}
