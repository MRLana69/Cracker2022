namespace System.Runtime.CompilerServices;

public struct ConfiguredTaskAwaitable
{
	public struct ConfiguredTaskAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task m_task; //Field offset: 0x0
		private readonly bool m_continueOnCapturedContext; //Field offset: 0x4

		public bool IsCompleted
		{
			 get { } //Length: 73
		}

		internal ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext) { }

		public bool get_IsCompleted() { }

		public void GetResult() { }

		public void OnCompleted(Action continuation) { }

		public void UnsafeOnCompleted(Action continuation) { }

	}

	private readonly ConfiguredTaskAwaiter m_configuredTaskAwaiter; //Field offset: 0x0

	internal ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext) { }

	public ConfiguredTaskAwaiter GetAwaiter() { }

}

