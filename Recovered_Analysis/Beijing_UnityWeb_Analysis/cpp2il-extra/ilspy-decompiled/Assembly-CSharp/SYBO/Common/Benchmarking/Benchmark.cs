using System;
using System.Text;
using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Automation.Samplers;
using SYBO.Common.Managers;
using SYBO.Common.StateSystem;
using SYBO.Common.Utilities;
using SYBO.Subway.Inputs;
using SYBO.Subway.Level;
using SYBO.Subway.Themes;

namespace SYBO.Common.Benchmarking;

public abstract class Benchmark : AutomationStepExecutor, IBenchmark, IAutomationStepExecutor
{
	private IBenchmarkMetric[] _metrics;

	private IMetricSampler[] _samplers;

	private static IBenchmarkProcessor Processor__BackingField;

	public IBenchmarkMetric[] Metrics => (IBenchmarkMetric[])_steps;

	protected virtual int InitialSampleCount
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_metrics;
		}
	}

	public static IBenchmarkProcessor Processor
	{
		get
		{
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Expected Obj, but got Unknown
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Expected Obj, but got Unknown
			//IL_02c9: Expected Obj, but got I4
			//IL_02d2: Expected Obj, but got I4
			//IL_0055: Expected Obj, but got I
			//IL_0055: Expected Obj, but got F4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			//IL_007b: Expected Obj, but got I4
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			object obj3 = obj2 + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			TimeScaleManager timeScaleManager = default;
			timeScaleManager.InputManager_OnInputEvent((object)123554, (InputEventArgs)null);
			object obj4 = 0;
			while ((nint)obj4 <= 9999)
			{
				uint seed = ((LoggingRandomGen)(object)timeScaleManager).Seed;
				object obj5 = obj4 + 1;
				obj4 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			float timeScaleInGameDefault = timeScaleManager._timeScaleInGameDefault;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v14 (SYBO.Common.Managers.TimeScaleManager)+18]");
			TimeScaleManager timeScaleManager2 = default;
			timeScaleManager2.InputManager_OnInputEvent((object)timeScaleInGameDefault, (InputEventArgs)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder sb = default;
			System.Text.StringBuilderCache.Release(sb);
			object obj6 = 0;
			object obj7 = default;
			object obj8 = default;
			while ((nint)obj7 <= 99)
			{
				uint seed2 = ((LoggingRandomGen)(object)timeScaleManager).Seed;
				uint seed3 = ((LoggingRandomGen)(object)timeScaleManager2).Seed;
				if (seed2 != seed3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					throw new ArrayTypeMismatchException();
				}
				obj7 = obj8 + 1;
			}
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				int totalLength = default;
				return (IBenchmarkProcessor)(object)string.ConcatArray((string[])(object)"MTRandomGenTest.TestIncrement: FAILED\n", totalLength);
			}
			return (IBenchmarkProcessor)(object)"MTRandomGenTest.TestIncrement: SUCCESS";
		}
		set
		{
			//IL_014e: Expected Obj, but got I
			//IL_0204: Expected Obj, but got I4
			//IL_0183: Expected Obj, but got I
			//IL_0015: Expected Obj, but got I
			//IL_00d9: Expected Obj, but got I4
			//IL_01c2: Expected Obj, but got I
			//IL_0090: Expected Obj, but got I
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected Obj, but got Unknown
			//IL_00f4: Expected Obj, but got I
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (SYBO.Common.Benchmarking.IBenchmarkProcessor)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (SYBO.Common.Benchmarking.IBenchmarkProcessor)+1C]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v26+C]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @947C");
					object obj3 = default;
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @947C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @93EC");
			object obj4 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (SYBO.Common.Benchmarking.IBenchmarkProcessor)+18]");
				object obj5 = 0;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v6+C]");
				if ((nint)obj6 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (SYBO.Common.Benchmarking.IBenchmarkProcessor)+18]");
				object obj7 = (nint)0 + (nint)16;
				object obj8 = obj4 << 2;
				object obj9 = obj7 + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj10 = obj4 + 1;
				obj4 = obj10;
			}
			object obj11 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (SYBO.Common.Benchmarking.IBenchmarkProcessor)+1C]");
				object obj12 = 0;
				object obj13 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v10+C]");
				if ((nint)obj13 >= 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (SYBO.Common.Benchmarking.IBenchmarkProcessor)+1C]");
				object obj14 = (nint)0 + (nint)16;
				object obj15 = obj11 << 2;
				object obj16 = obj14 + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj17 = obj11 + 1;
				obj11 = obj17;
			}
			((IntervalSampler)value).Initialize();
		}
	}

	public static char SeparatorCharacter
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (char)(int)Processor__BackingField;
		}
	}

	public Benchmark(IAutomationStep[] steps, IBenchmarkMetric[] metrics, IMetricSampler[] samplers)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0017: Expected I4, but got Obj
		ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
		ArrayTypeMismatchException ex2 = new ArrayTypeMismatchException();
		bool triggerId = ((Theme)(object)this).ShouldIgnoreBase((EnvironmentKind)(object)samplers);
		((StateMachine)(object)this).AddTransition((int)ex, (int)ex2, triggerId ? 1 : 0);
	}

	public override void Initialize()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0024: Expected Obj, but got I4
		object obj = this + 12;
		obj = "";
		base._currentStep = (IAutomationStep)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void InitializeBenchmark(int initialSampleCount)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = initialSampleCount;
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		object obj = this + 8;
		object obj2 = this + 8;
		object obj3 = 0;
		_ = 0;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+4]");
		_ = 0;
		object obj4 = obj3 + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 8;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16+8]");
		_ = 0;
	}

	public override void Terminate()
	{
		base.StartExecution();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int initialSampleCount = default;
		((GCCallsMetric)(object)this).Initialize(initialSampleCount);
	}

	protected abstract IBenchmarkProcessor CreateProcessor();
}
