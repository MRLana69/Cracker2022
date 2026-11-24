namespace System.Net;

internal class LazyAsyncResult
{
	private class ThreadContext
	{
		internal int m_NestedIOCount; //Field offset: 0x8

		public ThreadContext() { }

	}

	private static ThreadContext t_ThreadContext; //Field offset: 0x80000000
	private object m_AsyncObject; //Field offset: 0x8
	private AsyncCallback m_AsyncCallback; //Field offset: 0xC
	private object m_Result; //Field offset: 0x10
	private int m_IntCompleted; //Field offset: 0x14
	private object m_Event; //Field offset: 0x18

	internal object AsyncObject
	{
		 get { } //Length: 307
	}

	private static ThreadContext CurrentThreadContext
	{
		 get { } //Length: 77
	}

	protected virtual void Cleanup() { }

	protected virtual void Complete(nint userToken) { }

	internal object get_AsyncObject() { }

	private static ThreadContext get_CurrentThreadContext() { }

	internal void InvokeCallback(object result) { }

	protected void ProtectedInvokeCallback(object result, nint userToken) { }

	private void WorkerThreadComplete(object state) { }

}

