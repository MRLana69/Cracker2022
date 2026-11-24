namespace System.Runtime.CompilerServices;

public struct TaskAwaiter`1 : ICriticalNotifyCompletion, INotifyCompletion
{
	private readonly Task<TResult> m_task; //Field offset: 0x0

	internal TaskAwaiter`1(Task<TResult> task) { }

	public TResult GetResult() { }

	public void OnCompleted(Action continuation) { }

	public void UnsafeOnCompleted(Action continuation) { }

}

