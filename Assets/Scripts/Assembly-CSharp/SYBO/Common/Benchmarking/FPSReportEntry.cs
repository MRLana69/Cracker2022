namespace SYBO.Common.Benchmarking;

public class FPSReportEntry(float avgFPS, float minFrameTime, float maxFrameTime)
{
	public float AvgFPS = avgFPS;

	public float MinFrameTime = minFrameTime;

	public float MaxFrameTime = maxFrameTime;
}
