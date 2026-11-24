using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Automation.Samplers;
using SYBO.Common.Automation.Steps;

namespace SYBO.Common.Benchmarking;

public class DeltaFrameTimeMetric : BenchmarkMetric<float>
{
	private float _minFrameTime;

	private float _maxFrameTime;

	public override void Cleanup()
	{
		Benchmark.Processor__BackingField = (IBenchmarkProcessor)this;
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_01a3: Expected Obj, but got I
		//IL_007c: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I
		//IL_0033: Expected Obj, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_010a: Expected Obj, but got I4
		//IL_0222: Expected Obj, but got I
		//IL_0125: Expected Obj, but got I
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected Obj, but got Unknown
		if (((AutomationStep)(object)this).IsDone)
		{
			return;
		}
		((IntervalSampler)(object)this)._002Ector(unscaledDeltaTime);
		object obj = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+18]");
			object obj2 = 0;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v7+C]");
			if ((nint)obj3 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+18]");
			object obj4 = (nint)0 + (nint)16;
			object obj5 = obj << 2;
			object obj6 = obj4 + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
			object obj7 = obj + 1;
			obj = obj7;
		}
		object obj8 = 0;
		object obj14 = default;
		object obj15 = default;
		object obj16 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+1C]");
			object obj9 = 0;
			object obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v11+C]");
			if ((nint)obj10 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+1C]");
			object obj11 = (nint)0 + (nint)16;
			object obj12 = obj8 << 2;
			object obj13 = obj11 + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @947E");
			obj14 = obj15 | obj16;
			object obj17 = obj8 + 1;
			obj8 = obj17;
		}
		if (obj14 == null)
		{
			return;
		}
		object obj18 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+18]");
			object obj19 = 0;
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v15+C]");
			if ((nint)obj20 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+18]");
				object obj21 = (nint)0 + (nint)16;
				object obj22 = obj18 << 2;
				object obj23 = obj21 + obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj24 = obj18 + 1;
				obj18 = obj24;
				continue;
			}
			break;
		}
	}

	public override void Sample()
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v5+8]");
		object obj3 = 0;
		object obj4 = obj3 & 0x3FFF;
		object obj5 = obj4 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v25 @ S2_v4 (should have been resolved before IL gen)");
		_minFrameTime = float.MaxValue;
		_maxFrameTime = 0f;
	}

	public override List<string> Serialize()
	{
		return null;
	}

	public DeltaFrameTimeMetric()
	{
		//IL_002d: Expected Obj, but got I
		float item = _maxFrameTime - _minFrameTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Benchmarking.DeltaFrameTimeMetric)+8]");
		((List<float>)0).Add(item);
		_minFrameTime = float.MaxValue;
		_maxFrameTime = 0f;
	}
}
