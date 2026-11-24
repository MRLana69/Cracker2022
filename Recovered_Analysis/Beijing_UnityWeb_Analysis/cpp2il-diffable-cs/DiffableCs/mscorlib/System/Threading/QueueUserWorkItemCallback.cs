namespace System.Threading;

internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
{
	internal static ContextCallback ccb; //Field offset: 0x0
	private WaitCallback callback; //Field offset: 0x8
	private ExecutionContext context; //Field offset: 0xC
	private object state; //Field offset: 0x10

	private static QueueUserWorkItemCallback() { }

	internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	private static void WaitCallback_Context(object state) { }

}

