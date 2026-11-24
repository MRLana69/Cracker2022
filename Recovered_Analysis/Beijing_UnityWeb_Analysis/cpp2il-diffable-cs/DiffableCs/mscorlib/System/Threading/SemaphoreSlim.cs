namespace System.Threading;

public class SemaphoreSlim : IDisposable
{
	private struct <WaitUntilCountOrTimeoutAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<bool> <>t__builder; //Field offset: 0x4
		public CancellationToken cancellationToken; //Field offset: 0x10
		public TaskNode asyncWaiter; //Field offset: 0x14
		public int millisecondsTimeout; //Field offset: 0x18
		private CancellationTokenSource <cts>5__1; //Field offset: 0x1C
		public SemaphoreSlim <>4__this; //Field offset: 0x20
		private object <>7__wrap1; //Field offset: 0x24
		private ConfiguredTaskAwaiter<Task> <>u__1; //Field offset: 0x28
		private ConfiguredTaskAwaiter<bool> <>u__2; //Field offset: 0x30

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class TaskNode : IThreadPoolWorkItem
	{
		internal TaskNode Prev; //Field offset: 0x2C
		internal TaskNode Next; //Field offset: 0x30

		internal TaskNode() { }

		private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

		private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	}

	private static readonly Task<bool> s_trueTask; //Field offset: 0x0
	private const int NO_MAXIMUM = 2147483647; //Field offset: 0x0
	private static Action<object> s_cancellationTokenCanceledEventHandler; //Field offset: 0x4
	private int m_currentCount; //Field offset: 0x8
	private readonly int m_maxCount; //Field offset: 0xC
	private int m_waitCount; //Field offset: 0x10
	private object m_lockObj; //Field offset: 0x14
	private ManualResetEvent m_waitHandle; //Field offset: 0x18
	private TaskNode m_asyncHead; //Field offset: 0x1C
	private TaskNode m_asyncTail; //Field offset: 0x20

	private static SemaphoreSlim() { }

	public SemaphoreSlim(int initialCount, int maxCount) { }

	private static void CancellationTokenCanceledEventHandler(object obj) { }

	private void CheckDispose() { }

	private TaskNode CreateAndAddAsyncWaiter() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	private static string GetResourceString(string str) { }

	private static void QueueWaiterTask(TaskNode waiterTask) { }

	public int Release() { }

	public int Release(int releaseCount) { }

	private bool RemoveAsyncWaiter(TaskNode task) { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	public void Wait() { }

	public Task WaitAsync() { }

	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	private Task<bool> WaitUntilCountOrTimeoutAsync(TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

}

