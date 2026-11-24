namespace System.Threading;

public class AbandonedMutexException : SystemException
{
	private int m_MutexIndex; //Field offset: 0x44
	private Mutex m_Mutex; //Field offset: 0x48

	public AbandonedMutexException() { }

	public AbandonedMutexException(int location, WaitHandle handle) { }

	protected AbandonedMutexException(SerializationInfo info, StreamingContext context) { }

	private void SetupException(int location, WaitHandle handle) { }

}

