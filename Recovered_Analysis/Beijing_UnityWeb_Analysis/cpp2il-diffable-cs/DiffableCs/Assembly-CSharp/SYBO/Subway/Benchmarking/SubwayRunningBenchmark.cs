namespace SYBO.Subway.Benchmarking;

public class SubwayRunningBenchmark : SubwayBenchmark
{
	private const float DefaultDurationSeconds = 600; //Field offset: 0x0
	private const float DefaultSampleInterval = 0.5; //Field offset: 0x0
	private float _durationSeconds; //Field offset: 0x28
	private float _sampleInterval; //Field offset: 0x2C

	public override string ConfirmationMessage
	{
		 get { } //Length: 12
	}

	public override bool RequiresConfirmation
	{
		 get { } //Length: 129
	}

	public SubwayRunningBenchmark(float durationSeconds = 600, float sampleInterval = 0.5) { }

	private static IBenchmarkMetric[] GenerateMetrics() { }

	private static IAutomationStep[] GenerateSteps(float runLength) { }

	public override string get_ConfirmationMessage() { }

	public override bool get_RequiresConfirmation() { }

}

