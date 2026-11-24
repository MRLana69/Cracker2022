namespace SYBO.Components.Logging;

public class ThreadedAlternatingReadWriteQueue`1
{
	public class ThreadedAlternateReadWriteQueueException : Exception
	{

		public ThreadedAlternateReadWriteQueueException(string message) { }

	}

	private object _lockObject; //Field offset: 0x0
	private Queue<T> _readQueue; //Field offset: 0x0
	private Queue<T> _writeQueue; //Field offset: 0x0
	private Thread _readThread; //Field offset: 0x0

	public int ReadQueueCount
	{
		 get { } //Length: 566
	}

	public ThreadedAlternatingReadWriteQueue`1() { }

	public T Dequeue() { }

	public void Enqueue(T item) { }

	public int get_ReadQueueCount() { }

	public void SetReadThread(Thread thread) { }

	public void SwapQueues() { }

	public bool TryDequeue(out T item) { }

}

