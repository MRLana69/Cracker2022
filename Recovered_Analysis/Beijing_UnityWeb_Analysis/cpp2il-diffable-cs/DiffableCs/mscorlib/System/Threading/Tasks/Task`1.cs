namespace System.Threading.Tasks;

public class Task`1 : Task
{
	private sealed class <>c
	{
		public static readonly <>c<TResult> <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Task<TResult> <.cctor>b__64_0(Task<Task> completed) { }

	}

	private static readonly TaskFactory<TResult> s_Factory; //Field offset: 0x0
	internal static readonly Func<Task<Task>, Task<TResult>> TaskWhenAnyCast; //Field offset: 0x0
	internal TResult m_result; //Field offset: 0x0

	public TResult Result
	{
		 get { } //Length: 15
	}

	internal TResult ResultOnSuccess
	{
		 get { } //Length: 65
	}

	private static Task`1() { }

	internal Task`1(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal Task`1(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal Task`1(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }

	internal Task`1() { }

	internal Task`1(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }

	internal Task`1(TResult result) { }

	public Task`1(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }

	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }

	internal void DangerousSetResult(TResult result) { }

	public TResult get_Result() { }

	internal TResult get_ResultOnSuccess() { }

	public TaskAwaiter<TResult> GetAwaiter() { }

	internal TResult GetResultCore(bool waitCompletionNotification) { }

	internal override void InnerInvoke() { }

	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark) { }

	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	internal bool TrySetException(object exceptionObject) { }

	internal bool TrySetResult(TResult result) { }

}

