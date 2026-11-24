namespace Kiloo.Plugins;

public static class PluginUtil
{
	private struct Handler
	{
		public object context; //Field offset: 0x0
		public Delegate handler; //Field offset: 0x4

	}

	private static int _nextTicket; //Field offset: 0x0
	private static readonly Dictionary<int, Handler> _sharedHandlerStore; //Field offset: 0x4

	private static PluginUtil() { }

	public static int CheckInHandler(Delegate handler, object context) { }

	public static Delegate CheckOutHandler(int ticket) { }

	public static T CreateBridgeObject(string name = null, bool dontDestroyOnLoad = true) { }

	public static int GetNextTicket() { }

	public static void RemoveAllHandlers() { }

	public static IEnumerable<int> RemoveHandlers(object context) { }

}

