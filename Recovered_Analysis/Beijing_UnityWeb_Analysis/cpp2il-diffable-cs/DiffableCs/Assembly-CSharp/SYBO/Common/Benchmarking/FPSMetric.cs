namespace SYBO.Common.Benchmarking;

public class FPSMetric
{
	private int _currentFrames; //Field offset: 0xC
	private float _totalFrameTime; //Field offset: 0x10
	private float _minFrameTime; //Field offset: 0x14
	private float _maxFrameTime; //Field offset: 0x18

	public FPSMetric() { }

	public override void Cleanup() { }

	public override void Sample() { }

	public override List<string> Serialize() { }

	public override void Update(float unscaledDeltaTime) { }

}

