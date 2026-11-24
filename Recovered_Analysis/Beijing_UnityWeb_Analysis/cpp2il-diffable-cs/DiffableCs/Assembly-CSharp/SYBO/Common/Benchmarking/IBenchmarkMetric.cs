namespace SYBO.Common.Benchmarking;

public interface IBenchmarkMetric
{

	public void Cleanup() { }

	public void Initialize(int initialSampleCount) { }

	public void Sample() { }

	public List<string> Serialize() { }

	public void Update(float unscaledDeltaTime) { }

}

