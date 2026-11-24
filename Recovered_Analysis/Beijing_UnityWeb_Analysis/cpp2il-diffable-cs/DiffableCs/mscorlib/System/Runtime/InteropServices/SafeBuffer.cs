namespace System.Runtime.InteropServices;

public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
{
	private bool inited; //Field offset: 0x12

	public void AcquirePointer(ref byte* pointer) { }

	public void ReleasePointer() { }

}

