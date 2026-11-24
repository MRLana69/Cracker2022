namespace SYBO.Common.Benchmarking;

public abstract class Benchmark : AutomationStepExecutor, IBenchmark, IAutomationStepExecutor
{
	private static IBenchmarkProcessor <Processor>k__BackingField; //Field offset: 0x0
	private IBenchmarkMetric[] _metrics; //Field offset: 0x18
	private IMetricSampler[] _samplers; //Field offset: 0x1C

	protected virtual int InitialSampleCount
	{
		 get { } //Length: 6
	}

	public IBenchmarkMetric[] Metrics
	{
		 get { } //Length: 6
	}

	public static IBenchmarkProcessor Processor
	{
		 get { } //Length: 558
		 set { } //Length: 230
	}

	public static char SeparatorCharacter
	{
		 get { } //Length: 49
	}

	public Benchmark(IAutomationStep[] steps, IBenchmarkMetric[] metrics, IMetricSampler[] samplers) { }

	protected abstract IBenchmarkProcessor CreateProcessor() { }

	protected virtual int get_InitialSampleCount() { }

	public IBenchmarkMetric[] get_Metrics() { }

	public static IBenchmarkProcessor get_Processor() { }

	public static char get_SeparatorCharacter() { }

	public override void Initialize() { }

	private void InitializeBenchmark(int initialSampleCount) { }

	public static void set_Processor(IBenchmarkProcessor value) { }

	public override void Terminate() { }

	public override void Update(float unscaledDeltaTime) { }

}

