namespace SYBO.Common.Benchmarking;

public class DeltaFrameTimeMetric
{
	private float _minFrameTime; //Field offset: 0xC
	private float _maxFrameTime; //Field offset: 0x10

	public DeltaFrameTimeMetric() { }

	public override void Cleanup() { }

	public override void Sample() { }

	public override List<string> Serialize() { }

	public override void Update(float unscaledDeltaTime) { }

}

