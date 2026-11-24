namespace System.Threading.Tasks;

public class TaskFactory
{
	internal sealed class CompleteOnInvokePromise : ITaskCompletionAction
	{
		private IList<Task> _tasks; //Field offset: 0x2C
		private int m_firstTaskAlreadyCompleted; //Field offset: 0x30

		public CompleteOnInvokePromise(IList<Task> tasks) { }

		public void Invoke(Task completingTask) { }

	}

	private CancellationToken m_defaultCancellationToken; //Field offset: 0x8
	private TaskScheduler m_defaultScheduler; //Field offset: 0xC
	private TaskCreationOptions m_defaultCreationOptions; //Field offset: 0x10
	private TaskContinuationOptions m_defaultContinuationOptions; //Field offset: 0x14

	public TaskFactory() { }

	public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }

	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

}

