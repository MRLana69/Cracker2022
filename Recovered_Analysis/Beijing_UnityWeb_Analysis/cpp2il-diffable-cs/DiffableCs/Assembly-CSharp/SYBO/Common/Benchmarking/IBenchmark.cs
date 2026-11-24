namespace SYBO.Common.Benchmarking;

public interface IBenchmark : IAutomationStepExecutor
{

	public IBenchmarkMetric[] Metrics
	{
		 get { } //Length: 0
	}

	public IBenchmarkMetric[] get_Metrics() { }

}

