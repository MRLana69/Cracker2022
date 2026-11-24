using System;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public class FPSReportEntry
{
	public float AvgFPS;

	public float MinFrameTime;

	public float MaxFrameTime;

	public FPSReportEntry(float avgFPS, float minFrameTime, float maxFrameTime)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(EventArgs);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.EventArgs>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventArgs);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.EventArgs>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AvgFPS = avgFPS;
		MinFrameTime = minFrameTime;
		MaxFrameTime = maxFrameTime;
	}
}
