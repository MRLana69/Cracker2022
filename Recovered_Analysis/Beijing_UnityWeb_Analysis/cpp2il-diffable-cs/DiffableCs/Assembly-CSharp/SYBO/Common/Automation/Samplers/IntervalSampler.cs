namespace SYBO.Common.Automation.Samplers;

public class IntervalSampler : IMetricSampler
{
	private float _sampleInterval; //Field offset: 0x8
	protected float _timeSinceLastSample; //Field offset: 0xC

	public IntervalSampler(float sampleInterval) { }

	public void Cleanup() { }

	public void Initialize() { }

	public virtual bool Update(float unscaledDeltaTime) { }

}

