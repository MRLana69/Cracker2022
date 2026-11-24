namespace Mono.Net;

internal class CFDictionary : CFObject
{
	private static readonly nint KeyCallbacks; //Field offset: 0x0
	private static readonly nint ValueCallbacks; //Field offset: 0x4

	public nint Item
	{
		 get { } //Length: 84
	}

	private static CFDictionary() { }

	public CFDictionary(nint handle, bool own) { }

	private static nint CFDictionaryGetValue(nint handle, nint key) { }

	public nint get_Item(nint key) { }

	public nint GetValue(nint key) { }

}

