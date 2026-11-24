namespace Mono.Net;

internal class CFUrl : CFObject
{

	public CFUrl(nint handle, bool own) { }

	private static nint CFURLCreateWithString(nint allocator, nint str, nint baseURL) { }

	public static CFUrl Create(string absolute) { }

}

