namespace Mono;

internal struct RuntimeGPtrArrayHandle
{
	private GPtrArray* value; //Field offset: 0x0

	internal nint Item
	{
		 get { } //Length: 14
	}

	internal int Length
	{
		 get { } //Length: 9
	}

	internal RuntimeGPtrArrayHandle(nint ptr) { }

	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

	internal nint get_Item(int i) { }

	internal int get_Length() { }

	private static void GPtrArrayFree(GPtrArray* value) { }

	internal nint Lookup(int i) { }

}

