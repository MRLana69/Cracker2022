namespace System.Runtime.Remoting.Messaging;

public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem
{
	internal static ContextCallback ccb; //Field offset: 0x0
	private object async_state; //Field offset: 0x8
	private WaitHandle handle; //Field offset: 0xC
	private object async_delegate; //Field offset: 0x10
	private nint data; //Field offset: 0x14
	private object object_data; //Field offset: 0x18
	private bool sync_completed; //Field offset: 0x1C
	private bool completed; //Field offset: 0x1D
	private bool endinvoke_called; //Field offset: 0x1E
	private object async_callback; //Field offset: 0x20
	private ExecutionContext current; //Field offset: 0x24
	private ExecutionContext original; //Field offset: 0x28
	private long add_time; //Field offset: 0x30
	private MonoMethodMessage call_message; //Field offset: 0x38
	private IMessageCtrl message_ctrl; //Field offset: 0x3C
	private IMessage reply_message; //Field offset: 0x40
	private WaitCallback orig_cb; //Field offset: 0x44

	public virtual object AsyncDelegate
	{
		 get { } //Length: 9
	}

	public virtual object AsyncState
	{
		 get { } //Length: 62
	}

	public virtual WaitHandle AsyncWaitHandle
	{
		 get { } //Length: 6
	}

	internal MonoMethodMessage CallMessage
	{
		 get { } //Length: 411
		 set { } //Length: 11
	}

	public virtual bool CompletedSynchronously
	{
		 get { } //Length: 426
	}

	public bool EndInvokeCalled
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public virtual bool IsCompleted
	{
		 get { } //Length: 9
	}

	public IMessageSink NextSink
	{
		 get { } //Length: 6
	}

	private static AsyncResult() { }

	internal AsyncResult(WaitCallback cb, object state, bool capture_context) { }

	internal AsyncResult() { }

	private void <.ctor>b__17_0(object <p0>) { }

	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	internal IMessage EndInvoke() { }

	public virtual object get_AsyncDelegate() { }

	public virtual object get_AsyncState() { }

	public virtual WaitHandle get_AsyncWaitHandle() { }

	internal MonoMethodMessage get_CallMessage() { }

	public virtual bool get_CompletedSynchronously() { }

	public bool get_EndInvokeCalled() { }

	public virtual bool get_IsCompleted() { }

	public IMessageSink get_NextSink() { }

	public virtual IMessage GetReplyMessage() { }

	internal object Invoke() { }

	internal void set_CallMessage(MonoMethodMessage value) { }

	public void set_EndInvokeCalled(bool value) { }

	internal void SetCompletedSynchronously(bool completed) { }

	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	private static void WaitCallback_Context(object state) { }

}

