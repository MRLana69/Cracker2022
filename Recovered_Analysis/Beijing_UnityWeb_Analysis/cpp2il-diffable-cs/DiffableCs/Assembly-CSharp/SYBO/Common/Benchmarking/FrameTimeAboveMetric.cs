namespace SYBO.Common.Benchmarking;

public class FrameTimeAboveMetric
{
	private float _frameTimeThreshold; //Field offset: 0xC
	private int _numberOfOccurences; //Field offset: 0x10

	public FrameTimeAboveMetric(float frameTimeThreshold) { }

	public override void Cleanup() { }

	public override void Sample() { }

	public override void Update(float unscaledDeltaTime) { }

}

