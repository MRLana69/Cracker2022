using System;
using Cpp2ILInjected;
using SYBO.Common.Automation;
using SYBO.Common.Benchmarking;

namespace SYBO.Subway.Benchmarking;

public class SubwayRunningBenchmark : SubwayBenchmark
{
	private const float DefaultDurationSeconds = 600f;

	private const float DefaultSampleInterval = 0.5f;

	private float _durationSeconds;

	private float _sampleInterval;

	public override bool RequiresConfirmation => _durationSeconds > 600f;

	public unsafe override string ConfirmationMessage
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_004d: Expected F8, but got I4
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected I4, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			float num = _durationSeconds / 60f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2BE");
			double value = default;
			double num2 = Math.Abs(value);
			if (!(num2 < 2147483648.0))
			{
				value = -2147483648.0;
			}
			int num3 = obj + 12;
			string text = ((int*)num3)->ToString();
			return "This benchmark will run for " + text + " minutes. Please ensure that the device is connected to a charger during this test.";
		}
	}

	public SubwayRunningBenchmark(float durationSeconds = 600f, float sampleInterval = 0.5f)
	{
		IAutomationStep[] array = GenerateSteps(durationSeconds);
		IBenchmarkMetric[] array2 = GenerateMetrics();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private static IAutomationStep[] GenerateSteps(float runLength)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private static IBenchmarkMetric[] GenerateMetrics()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		FPSMetric fPSMetric = default;
		fPSMetric._002Ector();
		throw new ArrayTypeMismatchException();
	}
}
