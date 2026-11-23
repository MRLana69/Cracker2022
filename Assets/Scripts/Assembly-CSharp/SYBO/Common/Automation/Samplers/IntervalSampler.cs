using SYBO.Common.Benchmarking;

namespace SYBO.Common.Automation.Samplers;

public class IntervalSampler(float sampleInterval) : IMetricSampler
{
	private float _sampleInterval = sampleInterval;

	protected float _timeSinceLastSample;

	public void Initialize()
	{
	}

	public void Cleanup()
	{
		_timeSinceLastSample = 0f;
	}

	public virtual bool Update(float unscaledDeltaTime)
	{
		float num = (_timeSinceLastSample += unscaledDeltaTime);
		bool flag = !(num < _sampleInterval);
		if (flag)
		{
			float timeSinceLastSample = num - _sampleInterval;
			_timeSinceLastSample = timeSinceLastSample;
		}
		return flag;
	}
}
