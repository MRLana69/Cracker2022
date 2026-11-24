namespace SYBO.Common.Benchmarking;

public class FPSReportEntry
{
	public float AvgFPS; //Field offset: 0x8
	public float MinFrameTime; //Field offset: 0xC
	public float MaxFrameTime; //Field offset: 0x10

	public FPSReportEntry(float avgFPS, float minFrameTime, float maxFrameTime) { }

}

