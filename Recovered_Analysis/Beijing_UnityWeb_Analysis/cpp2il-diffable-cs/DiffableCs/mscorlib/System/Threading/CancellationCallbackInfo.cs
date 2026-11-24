namespace System.Threading;

internal class CancellationCallbackInfo
{
	private static ContextCallback s_executionContextCallback; //Field offset: 0x0
	internal readonly Action<object> Callback; //Field offset: 0x8
	internal readonly object StateForCallback; //Field offset: 0xC
	internal readonly SynchronizationContext TargetSyncContext; //Field offset: 0x10
	internal readonly ExecutionContext TargetExecutionContext; //Field offset: 0x14
	internal readonly CancellationTokenSource CancellationTokenSource; //Field offset: 0x18

	internal CancellationCallbackInfo(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	internal void ExecuteCallback() { }

	private static void ExecutionContextCallback(object obj) { }

}

