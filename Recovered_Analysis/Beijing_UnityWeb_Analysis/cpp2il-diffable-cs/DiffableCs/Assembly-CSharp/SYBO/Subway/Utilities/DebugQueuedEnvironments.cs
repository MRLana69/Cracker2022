namespace SYBO.Subway.Utilities;

public static class DebugQueuedEnvironments
{
	private const float QueueShiftDistance = 1080; //Field offset: 0x0
	private static Queue<EnvironmentKind> _environmentQueue; //Field offset: 0x0
	private static EnvironmentKind[] _currentEnvironmentKinds; //Field offset: 0x4
	private static float _nextQueueShiftPosZ; //Field offset: 0x8
	public static readonly List<string> AvailableEnvironments; //Field offset: 0xC

	public static bool IsQueueEnabled
	{
		 get { } //Length: 74
	}

	private static DebugQueuedEnvironments() { }

	public static bool get_IsQueueEnabled() { }

	public static EnvironmentKind GetEnvironmentKindAt(float posZ) { }

	public static Dictionary<string, string> GetSelected() { }

	public static void SetQueuedEnvironments(Dictionary<string, string> multipleValues) { }

	private static void UpdateQueuedEnvironmentKinds() { }

}

