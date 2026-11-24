namespace System.Threading;

public struct SpinLock
{
	internal class SystemThreading_SpinLockDebugView
	{

	}

	private static int MAXIMUM_WAITERS; //Field offset: 0x0
	private int m_owner; //Field offset: 0x0

	public bool IsHeldByCurrentThread
	{
		 get { } //Length: 3
	}

	public bool IsThreadOwnerTrackingEnabled
	{
		 get { } //Length: 12
	}

	private static SpinLock() { }

	public SpinLock(bool enableThreadOwnerTracking) { }

	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	private void DecrementWaiters() { }

	public void Enter(ref bool lockTaken) { }

	public void Exit(bool useMemoryBarrier) { }

	private void ExitSlowPath(bool useMemoryBarrier) { }

	public bool get_IsHeldByCurrentThread() { }

	public bool get_IsThreadOwnerTrackingEnabled() { }

	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

}

