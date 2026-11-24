namespace Mono.Net;

internal class CFNumber : CFObject
{

	public static int AsInt32(nint handle) { }

	private static bool CFNumberGetValue(nint handle, nint type, out int value) { }

}

