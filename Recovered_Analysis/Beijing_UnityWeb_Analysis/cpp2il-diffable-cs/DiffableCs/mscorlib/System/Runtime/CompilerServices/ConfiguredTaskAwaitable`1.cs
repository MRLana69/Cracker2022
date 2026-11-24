namespace System.Runtime.CompilerServices;

public struct ConfiguredTaskAwaitable`1
{
	public struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task<TResult> m_task; //Field offset: 0x0
		private readonly bool m_continueOnCapturedContext; //Field offset: 0x0

		public bool IsCompleted
		{
			 get { } //Length: 12
		}

		internal ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext) { }

		public bool get_IsCompleted() { }

		public TResult GetResult() { }

		public void OnCompleted(Action continuation) { }

		public void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; //Field offset: 0x0

	internal ConfiguredTaskAwaitable`1(Task<TResult> task, bool continueOnCapturedContext) { }

	public ConfiguredTaskAwaiter<TResult> GetAwaiter() { }

}

