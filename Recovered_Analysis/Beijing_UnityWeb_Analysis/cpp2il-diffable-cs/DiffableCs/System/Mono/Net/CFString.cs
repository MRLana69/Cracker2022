namespace Mono.Net;

internal class CFString : CFObject
{
	private string str; //Field offset: 0xC

	public CFString(nint handle, bool own) { }

	public static string AsString(nint handle) { }

	private static nint CFStringCreateWithCharacters(nint alloc, nint chars, nint length) { }

	private static nint CFStringGetCharacters(nint handle, CFRange range, nint buffer) { }

	private static nint CFStringGetCharactersPtr(nint handle) { }

	private static nint CFStringGetLength(nint handle) { }

	public static CFString Create(string value) { }

	public override string ToString() { }

}

