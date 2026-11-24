using System;
using Cpp2ILInjected;

namespace SYBO.Subway.Routes.Log;

public static class RoutesLogManagerBridge
{
	private static bool IsLogging__BackingField;

	public static bool IsLogging
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(RouteManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(RouteManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Subway.Routes.RouteManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return RouteManager.UseBenchmarkRoute__BackingField;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			((IDisposable)value).Dispose();
		}
	}

	public static int ForcedZBuildValue
	{
		get
		{
			return IsLogging__BackingField ? 1 : 0;
		}
		set
		{
			int num = value & 1;
			IsLogging__BackingField = (byte)num != 0;
		}
	}
}
