namespace System.Threading.Tasks;

internal static class TaskToApm
{
	private sealed class <>c__DisplayClass3_0
	{
		public AsyncCallback callback; //Field offset: 0x8
		public IAsyncResult asyncResult; //Field offset: 0xC

		public <>c__DisplayClass3_0() { }

		internal void <InvokeCallbackWhenTaskCompletes>b__0() { }

	}

	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		internal readonly Task Task; //Field offset: 0x8
		private readonly object m_state; //Field offset: 0xC
		private readonly bool m_completedSynchronously; //Field offset: 0x10

		private object System.IAsyncResult.AsyncState
		{
			 get { } //Length: 154
		}

		private WaitHandle System.IAsyncResult.AsyncWaitHandle
		{
			 get { } //Length: 9
		}

		private bool System.IAsyncResult.CompletedSynchronously
		{
			 get { } //Length: 6
		}

		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously) { }

		private object System.IAsyncResult.get_AsyncState() { }

		private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

		private bool System.IAsyncResult.get_CompletedSynchronously() { }

	}


	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	public static void End(IAsyncResult asyncResult) { }

	public static TResult End(IAsyncResult asyncResult) { }

	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }

}

