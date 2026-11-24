using System;
using Cpp2ILInjected;
using SYBO.Common.Managers;
using SYBO.Subway.Inputs;

namespace SYBO.Common.Utilities;

public static class MTRandomGenTest
{
	public static string TestIncrement()
	{
		//IL_0060: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got VT
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.DateTime>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v23 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime utcNow = DateTime.UtcNow;
		obj = utcNow;
		object obj3 = obj & 0x3FFFFFFFFFFFFFFFL;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj3 / 4294967295L;
		object obj5 = obj4 * 4294967295L;
		object sender = obj3 - obj5;
		TimeScaleManager timeScaleManager = default;
		timeScaleManager.InputManager_OnInputEvent(sender, (InputEventArgs)null);
		return (string)(object)timeScaleManager;
	}
}
