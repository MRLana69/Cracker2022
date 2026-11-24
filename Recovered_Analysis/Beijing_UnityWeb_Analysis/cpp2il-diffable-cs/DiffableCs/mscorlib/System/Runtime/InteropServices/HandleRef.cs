namespace System.Runtime.InteropServices;

public struct HandleRef
{
	internal object m_wrapper; //Field offset: 0x0
	internal nint m_handle; //Field offset: 0x4

	public nint Handle
	{
		 get { } //Length: 287
	}

	public HandleRef(object wrapper, nint handle) { }

	public nint get_Handle() { }

}

