namespace System.Runtime.ExceptionServices;

public sealed class ExceptionDispatchInfo
{
	private Exception m_Exception; //Field offset: 0x8
	private object m_stackTrace; //Field offset: 0xC

	internal object BinaryStackTraceArray
	{
		 get { } //Length: 6
	}

	public Exception SourceException
	{
		 get { } //Length: 124
	}

	private ExceptionDispatchInfo(Exception exception) { }

	public static ExceptionDispatchInfo Capture(Exception source) { }

	internal object get_BinaryStackTraceArray() { }

	public Exception get_SourceException() { }

	public void Throw() { }

}

