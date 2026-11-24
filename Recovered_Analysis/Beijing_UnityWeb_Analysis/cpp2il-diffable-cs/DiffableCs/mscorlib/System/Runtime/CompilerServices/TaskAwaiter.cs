namespace System.Runtime.CompilerServices;

public struct TaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task m_task; //Field offset: 0x0

	internal TaskAwaiter(Task task) { }

	public void GetResult() { }

	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	public void OnCompleted(Action continuation) { }

	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	private static void ThrowForNonSuccess(Task task) { }

	public void UnsafeOnCompleted(Action continuation) { }

	internal static void ValidateEnd(Task task) { }

}

