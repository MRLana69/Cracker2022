namespace System.Threading;

public struct NativeOverlapped
{
	public nint InternalLow; //Field offset: 0x0
	public nint InternalHigh; //Field offset: 0x4
	public int OffsetLow; //Field offset: 0x8
	public int OffsetHigh; //Field offset: 0xC
	public nint EventHandle; //Field offset: 0x10

}

