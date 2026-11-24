using System.Collections.Generic;
using Cpp2ILInjected;

namespace SYBO.Common.Benchmarking;

public abstract class BenchmarkMetric<T> : IBenchmarkMetric
{
	protected List<T> _samples;

	public virtual void Initialize(int initialSampleCount)
	{
		//IL_000a: Expected Obj, but got I4
		_samples = (List<T>)initialSampleCount;
	}

	public virtual void Cleanup()
	{
	}

	public abstract void Update(float unscaledDeltaTime);

	public abstract void Sample();

	public virtual List<string> Serialize()
	{
		//IL_001d: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.BenchmarkMetric`1<T>)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.BenchmarkMetric`1<T>)+1C]");
		return (List<string>)(num - 0);
	}

	protected BenchmarkMetric()
	{
		//IL_0010: Expected Obj, but got I
		//IL_0020: Expected Obj, but got I
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S2_v4 (should have been resolved before IL gen)");
	}
}
