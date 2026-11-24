namespace System.IO;

internal class FileStreamAsyncResult : IAsyncResult
{
	private object state; //Field offset: 0x8
	private ManualResetEvent wh; //Field offset: 0xC
	private AsyncCallback cb; //Field offset: 0x10
	private bool completedSynch; //Field offset: 0x14
	public int Count; //Field offset: 0x18
	public int OriginalCount; //Field offset: 0x1C
	public int BytesRead; //Field offset: 0x20
	private AsyncCallback realcb; //Field offset: 0x24

	public object AsyncState
	{
		 get { } //Length: 268
	}

	public WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 9
	}

	public bool CompletedSynchronously
	{
		 get { } //Length: 6
	}

	public FileStreamAsyncResult(AsyncCallback cb, object state) { }

	private static void CBWrapper(IAsyncResult ares) { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

}

