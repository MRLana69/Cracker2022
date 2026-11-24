namespace Mono.Net;

internal class CFRunLoop : CFObject
{

	public static CFRunLoop CurrentRunLoop
	{
		 get { } //Length: 91
	}

	public CFRunLoop(nint handle, bool own) { }

	public void AddSource(nint source, CFString mode) { }

	private static void CFRunLoopAddSource(nint rl, nint source, nint mode) { }

	private static nint CFRunLoopGetCurrent() { }

	private static void CFRunLoopRemoveSource(nint rl, nint source, nint mode) { }

	private static int CFRunLoopRunInMode(nint mode, double seconds, bool returnAfterSourceHandled) { }

	private static void CFRunLoopStop(nint rl) { }

	public static CFRunLoop get_CurrentRunLoop() { }

	public void RemoveSource(nint source, CFString mode) { }

	public int RunInMode(CFString mode, double seconds, bool returnAfterSourceHandled) { }

	public void Stop() { }

}

