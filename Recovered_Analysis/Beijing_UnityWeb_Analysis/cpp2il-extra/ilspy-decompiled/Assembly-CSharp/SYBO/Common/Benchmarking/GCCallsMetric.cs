using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public class GCCallsMetric : BenchmarkMetric<int>
{
	private int _previousGCCalls;

	public override void Initialize(int initialSampleCount)
	{
		//IL_0027: Expected Obj, but got I4
		//IL_0129: Expected Obj, but got I
		//IL_008b: Expected Obj, but got I4
		//IL_0168: Expected Obj, but got I
		//IL_0042: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @947C");
		object obj = default;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93EC");
		}
		object obj2 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+18]");
			object obj3 = 0;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v5+C]");
			if ((nint)obj4 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+18]");
			object obj5 = (nint)0 + (nint)16;
			object obj6 = obj2 << 2;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			object obj8 = obj2 + 1;
			obj2 = obj8;
		}
		object obj9 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+1C]");
			object obj10 = 0;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v9+C]");
			if ((nint)obj11 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+1C]");
				object obj12 = (nint)0 + (nint)16;
				object obj13 = obj9 << 2;
				object obj14 = obj12 + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj15 = obj9 + 1;
				obj9 = obj15;
				continue;
			}
			break;
		}
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_000a: Invalid comparison between I4 and F4
		//IL_003f: Expected Obj, but got I
		if ((float)_previousGCCalls < unscaledDeltaTime)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+10]");
			object obj = (nint)0 + (nint)1;
		}
	}

	public override void Sample()
	{
		//IL_0022: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+10]");
		((List<int>)num).Add(0);
		_ = 0;
	}

	public unsafe GCCallsMetric()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GC);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.GC>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GC);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<System.GC>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool timeZoneName = System.DateTimeParse.GetTimeZoneName(ref *(System.__DTString*)null);
		int item = (timeZoneName ? 1 : 0) - _previousGCCalls;
		_previousGCCalls = (timeZoneName ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+8]");
		((List<int>)0).Add(item);
	}
}
