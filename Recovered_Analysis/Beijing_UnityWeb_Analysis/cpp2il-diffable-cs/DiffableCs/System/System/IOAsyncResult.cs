namespace System;

internal abstract class IOAsyncResult : IAsyncResult
{
	private AsyncCallback async_callback; //Field offset: 0x8
	private object async_state; //Field offset: 0xC
	private ManualResetEvent wait_handle; //Field offset: 0x10
	private bool completed_synchronously; //Field offset: 0x14
	private bool completed; //Field offset: 0x15

	public AsyncCallback AsyncCallback
	{
		 get { } //Length: 156
	}

	public object AsyncState
	{
		 get { } //Length: 6
	}

	public WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 6
	}

	public bool CompletedSynchronously
	{
		 get { } //Length: 412
		protected set { } //Length: 10
	}

	public bool IsCompleted
	{
		 get { } //Length: 9
		protected set { } //Length: 11
	}

	protected IOAsyncResult(AsyncCallback async_callback, object async_state) { }

	internal abstract void CompleteDisposed() { }

	public AsyncCallback get_AsyncCallback() { }

	public object get_AsyncState() { }

	public WaitHandle get_AsyncWaitHandle() { }

	public bool get_CompletedSynchronously() { }

	public bool get_IsCompleted() { }

	protected void set_CompletedSynchronously(bool value) { }

	protected void set_IsCompleted(bool value) { }

}

