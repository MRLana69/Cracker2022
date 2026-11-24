namespace System.Threading;

public struct CancellationToken
{
	private static readonly Action<object> s_ActionToActionObjShunt; //Field offset: 0x0
	private CancellationTokenSource m_source; //Field offset: 0x0

	public bool CanBeCanceled
	{
		 get { } //Length: 28
	}

	public bool IsCancellationRequested
	{
		 get { } //Length: 3
	}

	public static CancellationToken None
	{
		 get { } //Length: 250
	}

	private static CancellationToken() { }

	internal CancellationToken(CancellationTokenSource source) { }

	private static void ActionToActionObjShunt(object obj) { }

	public bool Equals(CancellationToken other) { }

	public override bool Equals(object other) { }

	public bool get_CanBeCanceled() { }

	public bool get_IsCancellationRequested() { }

	public static CancellationToken get_None() { }

	public override int GetHashCode() { }

	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	public void ThrowIfCancellationRequested() { }

	internal void ThrowIfSourceDisposed() { }

	private static void ThrowObjectDisposedException() { }

	private void ThrowOperationCanceledException() { }

}

