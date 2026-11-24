namespace System.Threading.Tasks;

internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; //Field offset: 0x0

	internal override bool RequiresAtomicStartTransition
	{
		 get { } //Length: 54
	}

	private static ThreadPoolTaskScheduler() { }

	internal ThreadPoolTaskScheduler() { }

	internal override bool get_RequiresAtomicStartTransition() { }

	private static void LongRunningThreadWork(object obj) { }

	internal override void NotifyWorkItemProgress() { }

	protected internal override void QueueTask(Task task) { }

	protected internal override bool TryDequeue(Task task) { }

	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

