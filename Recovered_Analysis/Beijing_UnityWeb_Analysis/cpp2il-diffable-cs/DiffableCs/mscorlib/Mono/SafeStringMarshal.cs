namespace Mono;

internal struct SafeStringMarshal : IDisposable
{
	private readonly string str; //Field offset: 0x0
	private nint marshaled_string; //Field offset: 0x4

	public nint Value
	{
		 get { } //Length: 7
	}

	public SafeStringMarshal(string str) { }

	public void Dispose() { }

	public nint get_Value() { }

	public static void GFree(nint ptr) { }

	public static nint StringToUtf8(string str) { }

}

