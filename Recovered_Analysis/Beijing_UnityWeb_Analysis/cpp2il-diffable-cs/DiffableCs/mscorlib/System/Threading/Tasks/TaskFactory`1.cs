namespace System.Threading.Tasks;

public class TaskFactory`1
{
	private sealed class FromAsyncTrimPromise`1
	{
		internal static readonly AsyncCallback s_completeFromAsyncResult; //Field offset: 0x0
		private TInstance m_thisRef; //Field offset: 0x0
		private Func<TInstance, IAsyncResult, TResult> m_endMethod; //Field offset: 0x0

		private static FromAsyncTrimPromise`1() { }

		internal FromAsyncTrimPromise`1(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }

		internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }

		internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }

	}

	private CancellationToken m_defaultCancellationToken; //Field offset: 0x0
	private TaskScheduler m_defaultScheduler; //Field offset: 0x0
	private TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x0

	public TaskFactory`1() { }

	public TaskFactory`1(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal static Task<TResult> FromAsyncTrim(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }

}

