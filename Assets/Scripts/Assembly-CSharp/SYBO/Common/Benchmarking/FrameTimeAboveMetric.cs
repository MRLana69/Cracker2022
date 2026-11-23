using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public class FrameTimeAboveMetric(float frameTimeThreshold) : BenchmarkMetric<int>
{
	private float _frameTimeThreshold = frameTimeThreshold;

	private int _numberOfOccurences;

	public override void Cleanup()
	{
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S2_v3 (Il2CppRgctx<SYBO.Common.Benchmarking.BenchmarkMetric`1<System.Int32>>)+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S2_v4+4] (should have been resolved before IL gen)");
		_numberOfOccurences = 0;
	}

	public override void Update(float unscaledDeltaTime)
	{
		if (unscaledDeltaTime > _frameTimeThreshold)
		{
			int numberOfOccurences = _numberOfOccurences + 1;
			_numberOfOccurences = numberOfOccurences;
		}
	}

	public override void Sample()
	{
		//IL_001c: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.FrameTimeAboveMetric)+8]");
		((List<int>)0).Add(_numberOfOccurences);
		_numberOfOccurences = 0;
	}
}
