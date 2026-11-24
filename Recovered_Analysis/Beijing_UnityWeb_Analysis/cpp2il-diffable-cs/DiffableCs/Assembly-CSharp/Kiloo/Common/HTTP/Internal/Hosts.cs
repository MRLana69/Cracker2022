namespace Kiloo.Common.HTTP.Internal;

internal static class Hosts
{
	private class HostData
	{
		public DateTime backOffUntil; //Field offset: 0x8
		public double lastBackOffDuration; //Field offset: 0x10

		public HostData() { }

	}

	private static readonly Dictionary<string, HostData> _hostData; //Field offset: 0x0

	private static Hosts() { }

	public static void BackOff(string host, double minTime, double maxTime) { }

	public static void BackOff(string host, double seconds) { }

	public static void BackOff(string host, DateTime until) { }

	public static void DontBackOff(string host) { }

	public static double GetBackOffSeconds(string host) { }

	private static void Log(string msg) { }

}

