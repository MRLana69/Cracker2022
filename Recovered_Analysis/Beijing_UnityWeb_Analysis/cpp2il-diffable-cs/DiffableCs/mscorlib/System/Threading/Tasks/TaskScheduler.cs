namespace System.Threading.Tasks;

public abstract class TaskScheduler
{
	internal sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{

	}

	private static ConditionalWeakTable<TaskScheduler, object> s_activeTaskSchedulers; //Field offset: 0x0
	private static readonly TaskScheduler s_defaultTaskScheduler; //Field offset: 0x4
	internal static int s_taskSchedulerIdCounter; //Field offset: 0x8
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; //Field offset: 0xC
	private static readonly object _unobservedTaskExceptionLockObject; //Field offset: 0x10
	private int m_taskSchedulerId; //Field offset: 0x8

	public static TaskScheduler Current
	{
		 get { } //Length: 89
	}

	public static TaskScheduler Default
	{
		 get { } //Length: 3
	}

	public int Id
	{
		 get { } //Length: 3
	}

	internal static TaskScheduler InternalCurrent
	{
		 get { } //Length: 129
	}

	internal virtual bool RequiresAtomicStartTransition
	{
		 get { } //Length: 279
	}

	private static TaskScheduler() { }

	protected TaskScheduler() { }

	private void AddToActiveTaskSchedulers() { }

	public static TaskScheduler get_Current() { }

	public static TaskScheduler get_Default() { }

	public int get_Id() { }

	internal static TaskScheduler get_InternalCurrent() { }

	internal virtual bool get_RequiresAtomicStartTransition() { }

	internal void InternalQueueTask(Task task) { }

	internal virtual void NotifyWorkItemProgress() { }

	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	protected internal abstract void QueueTask(Task task) { }

	protected internal virtual bool TryDequeue(Task task) { }

	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

}

