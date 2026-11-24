namespace System.Threading;

public class ManualResetEventSlim : IDisposable
{
	private const int DEFAULT_SPIN_SP = 1; //Field offset: 0x0
	private const int DEFAULT_SPIN_MP = 10; //Field offset: 0x0
	private const int SignalledState_BitMask = -2147483648; //Field offset: 0x0
	private const int SignalledState_ShiftCount = 31; //Field offset: 0x0
	private const int Dispose_BitMask = 1073741824; //Field offset: 0x0
	private const int SpinCountState_BitMask = 1073217536; //Field offset: 0x0
	private const int SpinCountState_ShiftCount = 19; //Field offset: 0x0
	private const int SpinCountState_MaxValue = 2047; //Field offset: 0x0
	private const int NumWaitersState_BitMask = 524287; //Field offset: 0x0
	private const int NumWaitersState_ShiftCount = 0; //Field offset: 0x0
	private const int NumWaitersState_MaxValue = 524287; //Field offset: 0x0
	private static Action<object> s_cancellationTokenCallback; //Field offset: 0x0
	private object m_lock; //Field offset: 0x8
	private ManualResetEvent m_eventObj; //Field offset: 0xC
	private int m_combinedState; //Field offset: 0x10

	public bool IsSet
	{
		 get { } //Length: 32
		private set { } //Length: 54
	}

	public int SpinCount
	{
		 get { } //Length: 86
		private set { } //Length: 29
	}

	private int Waiters
	{
		 get { } //Length: 86
		 set { } //Length: 24
	}

	public WaitHandle WaitHandle
	{
		 get { } //Length: 140
	}

	private static ManualResetEventSlim() { }

	public ManualResetEventSlim(bool initialState) { }

	public ManualResetEventSlim(bool initialState, int spinCount) { }

	private static void CancellationTokenCallback(object obj) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	private void EnsureLockObjectCreated() { }

	private static int ExtractStatePortion(int state, int mask) { }

	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	public bool get_IsSet() { }

	public int get_SpinCount() { }

	private int get_Waiters() { }

	public WaitHandle get_WaitHandle() { }

	private void Initialize(bool initialState, int spinCount) { }

	private bool LazyInitializeEvent() { }

	private void Set(bool duringCancellation) { }

	public void Set() { }

	private void set_IsSet(bool value) { }

	private void set_SpinCount(int value) { }

	private void set_Waiters(int value) { }

	private void ThrowIfDisposed() { }

	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

}

