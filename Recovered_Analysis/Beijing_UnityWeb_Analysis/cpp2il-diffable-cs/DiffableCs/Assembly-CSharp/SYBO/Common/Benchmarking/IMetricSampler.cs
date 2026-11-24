namespace SYBO.Common.Benchmarking;

public interface IMetricSampler
{

	public void Cleanup() { }

	public void Initialize() { }

	public bool Update(float unscaledDeltaTime) { }

}

