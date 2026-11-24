namespace SYBO.Common.Benchmarking;

public class GCCallsMetric
{
	private int _previousGCCalls; //Field offset: 0xC

	public GCCallsMetric() { }

	public override void Initialize(int initialSampleCount) { }

	public override void Sample() { }

	public override void Update(float unscaledDeltaTime) { }

}

