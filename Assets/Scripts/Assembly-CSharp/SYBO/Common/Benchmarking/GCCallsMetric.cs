using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public class GCCallsMetric : BenchmarkMetric<int>
{
	private int _previousGCCalls;

	public override void Initialize(int initialSampleCount)
	{
		base.Initialize(initialSampleCount);
		int previousGCCalls = GC.CollectionCount(0);
		_previousGCCalls = previousGCCalls;
	}

	public override void Update(float unscaledDeltaTime)
	{
	}

	public override void Sample()
	{
		//IL_0042: Expected Obj, but got I
		int num = GC.CollectionCount(0);
		int item = num - _previousGCCalls;
		_previousGCCalls = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.GCCallsMetric)+8]");
		((List<int>)0).Add(item);
	}
}
