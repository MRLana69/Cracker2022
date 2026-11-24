namespace System.Threading;

public class CancellationTokenSource : IDisposable
{
	private static readonly CancellationTokenSource _staticSource_Set; //Field offset: 0x0
	private const int NOTIFYING = 2; //Field offset: 0x0
	private const int NOT_CANCELED = 1; //Field offset: 0x0
	private const int CANNOT_BE_CANCELED = 0; //Field offset: 0x0
	private const int NOTIFYINGCOMPLETE = 3; //Field offset: 0x0
	private static readonly CancellationTokenSource _staticSource_NotCancelable; //Field offset: 0x4
	private static readonly int s_nLists; //Field offset: 0x8
	private static readonly Action<object> s_LinkedTokenCancelDelegate; //Field offset: 0xC
	private static readonly TimerCallback s_timerCallback; //Field offset: 0x10
	private ManualResetEvent m_kernelEvent; //Field offset: 0x8
	private SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists; //Field offset: 0xC
	private int m_state; //Field offset: 0x10
	private int m_threadIDExecutingCallbacks; //Field offset: 0x14
	private bool m_disposed; //Field offset: 0x18
	private CancellationTokenRegistration[] m_linkingRegistrations; //Field offset: 0x1C
	private CancellationCallbackInfo m_executingCallback; //Field offset: 0x20
	private Timer m_timer; //Field offset: 0x24

	internal bool CanBeCanceled
	{
		 get { } //Length: 43
	}

	internal CancellationCallbackInfo ExecutingCallback
	{
		 get { } //Length: 9
	}

	internal bool IsCancellationCompleted
	{
		 get { } //Length: 9
	}

	public bool IsCancellationRequested
	{
		 get { } //Length: 12
	}

	internal bool IsDisposed
	{
		 get { } //Length: 9
	}

	internal int ThreadIDExecutingCallbacks
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public CancellationToken Token
	{
		 get { } //Length: 6
	}

	private static CancellationTokenSource() { }

	private CancellationTokenSource(bool set) { }

	public CancellationTokenSource() { }

	public void Cancel() { }

	public void Cancel(bool throwOnFirstException) { }

	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	internal bool get_CanBeCanceled() { }

	internal CancellationCallbackInfo get_ExecutingCallback() { }

	internal bool get_IsCancellationCompleted() { }

	public bool get_IsCancellationRequested() { }

	internal bool get_IsDisposed() { }

	internal int get_ThreadIDExecutingCallbacks() { }

	public CancellationToken get_Token() { }

	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	private static void LinkedTokenCancelDelegate(object source) { }

	private void NotifyCancellation(bool throwOnFirstException) { }

	internal void set_ThreadIDExecutingCallbacks(int value) { }

	internal void ThrowIfDisposed() { }

	private static void ThrowObjectDisposedException() { }

	private static void TimerCallbackLogic(object obj) { }

	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

}

