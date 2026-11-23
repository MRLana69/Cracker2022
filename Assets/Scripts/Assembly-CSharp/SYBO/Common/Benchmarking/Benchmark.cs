using Cpp2ILInjected;
using SYBO.Common.Automation;

namespace SYBO.Common.Benchmarking;

public abstract class Benchmark : AutomationStepExecutor, IBenchmark, IAutomationStepExecutor
{
	private IBenchmarkMetric[] _metrics;

	private IMetricSampler[] _samplers;

	private static IBenchmarkProcessor Processor__BackingField;

	public IBenchmarkMetric[] Metrics => _metrics;

	protected virtual int InitialSampleCount => 0;

	public static IBenchmarkProcessor Processor
	{
		get
		{
			return Processor__BackingField;
		}
		set
		{
			Processor__BackingField = value;
		}
	}

	public static char SeparatorCharacter
	{
		get
		{
			if (Processor__BackingField == null)
			{
				return ' ';
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			char result = default;
			return result;
		}
	}

	public Benchmark(IAutomationStep[] steps, IBenchmarkMetric[] metrics, IMetricSampler[] samplers)
	{
		_steps = steps;
		_metrics = metrics;
		_samplers = samplers;
	}

	public override void Initialize()
	{
		//IL_000b: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		base.Initialize();
		nint num = (nint)this;
		object obj = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<SYBO.Common.Benchmarking.Benchmark>)+144] (should have been resolved before IL gen)");
		int initialSampleCount = default;
		InitializeBenchmark(initialSampleCount);
	}

	private void InitializeBenchmark(int initialSampleCount)
	{
		//IL_00c1: Expected Obj, but got I4
		//IL_000a: Expected I, but got Obj
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		if (Processor__BackingField == null)
		{
			nint num = (nint)this;
			object obj = this + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S1_v15 (Il2CppClass<SYBO.Common.Benchmarking.Benchmark>)+14C] (should have been resolved before IL gen)");
			IBenchmarkProcessor benchmarkProcessor = default;
			Processor__BackingField = benchmarkProcessor;
		}
		object obj2 = 0;
		while (true)
		{
			IBenchmarkMetric[] metrics = _metrics;
			if (metrics.Length <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)metrics + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
		object obj6 = 0;
		while (true)
		{
			IMetricSampler[] samplers = _samplers;
			if (samplers.Length > (nint)obj6)
			{
				object obj7 = obj6 << 2;
				object obj8 = (object)samplers + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
				object obj9 = obj6 + 1;
				obj6 = obj9;
				continue;
			}
			break;
		}
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_0018: Expected Obj, but got I4
		//IL_0066: Expected Obj, but got I4
		//IL_006f: Expected Obj, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		if (IsDone)
		{
			return;
		}
		base.Update(unscaledDeltaTime);
		object obj = 0;
		while (true)
		{
			IBenchmarkMetric[] metrics = _metrics;
			if (metrics.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)metrics + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
			object obj4 = obj + 1;
			obj = obj4;
		}
		object obj5 = 0;
		object obj6 = 0;
		object obj10 = default;
		while (true)
		{
			IMetricSampler[] samplers = _samplers;
			if (samplers.Length <= (nint)obj6)
			{
				break;
			}
			object obj7 = obj6 << 2;
			object obj8 = (object)samplers + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @57D8");
			object obj9 = obj10 | obj5;
			object obj11 = obj6 + 1;
			obj5 = obj9;
			obj6 = obj11;
		}
		object obj12 = obj5 & 1;
		if (obj12 == null)
		{
			return;
		}
		object obj13 = 0;
		while (true)
		{
			IBenchmarkMetric[] metrics2 = _metrics;
			if ((nint)obj13 < metrics2.Length)
			{
				object obj14 = obj13 << 2;
				object obj15 = (object)metrics2 + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
				object obj16 = obj13 + 1;
				obj13 = obj16;
				continue;
			}
			break;
		}
	}

	public override void Terminate()
	{
		//IL_0137: Expected Obj, but got I4
		//IL_0086: Expected Obj, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		IBenchmarkMetric[] metrics = _metrics;
		if (metrics.Length != 0)
		{
			IMetricSampler[] samplers = _samplers;
			if (samplers.Length != 0 && Processor__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27B");
			}
		}
		Processor__BackingField = null;
		object obj = 0;
		while (true)
		{
			IBenchmarkMetric[] metrics2 = _metrics;
			if (metrics2.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)metrics2 + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			object obj4 = obj + 1;
			obj = obj4;
		}
		object obj5 = 0;
		while (true)
		{
			IMetricSampler[] samplers2 = _samplers;
			if (samplers2.Length <= (nint)obj5)
			{
				break;
			}
			object obj6 = obj5 << 2;
			object obj7 = (object)samplers2 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			object obj8 = obj5 + 1;
			obj5 = obj8;
		}
		base.Terminate();
	}

	protected abstract IBenchmarkProcessor CreateProcessor();
}
