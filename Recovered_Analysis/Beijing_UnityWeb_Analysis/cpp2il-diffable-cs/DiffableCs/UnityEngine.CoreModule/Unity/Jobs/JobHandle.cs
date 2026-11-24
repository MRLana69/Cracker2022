namespace Unity.Jobs;

public struct JobHandle
{
	internal nint jobGroup; //Field offset: 0x0
	internal int version; //Field offset: 0x4

	public static void ScheduleBatchedJobs() { }

}

