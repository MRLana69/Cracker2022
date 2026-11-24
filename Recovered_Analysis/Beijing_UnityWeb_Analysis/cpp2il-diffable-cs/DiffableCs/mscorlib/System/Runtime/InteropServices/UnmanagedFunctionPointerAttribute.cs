namespace System.Runtime.InteropServices;

public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	private CallingConvention m_callingConvention; //Field offset: 0x8
	public CharSet CharSet; //Field offset: 0xC
	public bool BestFitMapping; //Field offset: 0x10
	public bool ThrowOnUnmappableChar; //Field offset: 0x11
	public bool SetLastError; //Field offset: 0x12

	public UnmanagedFunctionPointerAttribute(CallingConvention callingConvention) { }

}

