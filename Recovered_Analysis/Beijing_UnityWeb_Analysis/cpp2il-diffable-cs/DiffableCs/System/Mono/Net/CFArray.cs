namespace Mono.Net;

internal class CFArray : CFObject
{
	private static readonly nint kCFTypeArrayCallbacks; //Field offset: 0x0

	public int Count
	{
		 get { } //Length: 93
	}

	public nint Item
	{
		 get { } //Length: 96
	}

	private static CFArray() { }

	public CFArray(nint handle, bool own) { }

	private static nint CFArrayGetCount(nint handle) { }

	private static nint CFArrayGetValueAtIndex(nint handle, nint index) { }

	public int get_Count() { }

	public nint get_Item(int index) { }

}

