namespace Mono;

internal struct SafeGPtrArrayHandle : IDisposable
{
	private RuntimeGPtrArrayHandle handle; //Field offset: 0x0

	internal nint Item
	{
		 get { } //Length: 151
	}

	internal int Length
	{
		 get { } //Length: 42
	}

	internal SafeGPtrArrayHandle(nint ptr) { }

	public void Dispose() { }

	internal nint get_Item(int i) { }

	internal int get_Length() { }

}

