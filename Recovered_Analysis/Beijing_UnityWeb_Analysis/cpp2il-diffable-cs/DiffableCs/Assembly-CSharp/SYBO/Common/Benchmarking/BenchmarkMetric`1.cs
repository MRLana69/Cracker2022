namespace SYBO.Common.Benchmarking;

public abstract class BenchmarkMetric`1 : IBenchmarkMetric
{
	protected List<T> _samples; //Field offset: 0x0

	protected BenchmarkMetric`1() { }

	public virtual void Cleanup() { }

	public virtual void Initialize(int initialSampleCount) { }

	public abstract void Sample() { }

	public virtual List<string> Serialize() { }

	public abstract void Update(float unscaledDeltaTime) { }

}

