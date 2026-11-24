namespace System.Threading;

public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	public const int WaitTimeout = 258; //Field offset: 0x0
	private const int MAX_WAITHANDLES = 64; //Field offset: 0x0
	private const int WAIT_OBJECT_0 = 0; //Field offset: 0x0
	private const int WAIT_ABANDONED = 128; //Field offset: 0x0
	private const int WAIT_FAILED = 2147483647; //Field offset: 0x0
	private const int ERROR_TOO_MANY_POSTS = 298; //Field offset: 0x0
	protected static readonly nint InvalidHandle; //Field offset: 0x0
	internal const int MaxWaitHandles = 64; //Field offset: 0x0
	private nint waitHandle; //Field offset: 0xC
	internal SafeWaitHandle safeWaitHandle; //Field offset: 0x10
	internal bool hasThreadAffinity; //Field offset: 0x14

	public virtual nint Handle
	{
		 set { } //Length: 22
	}

	public SafeWaitHandle SafeWaitHandle
	{
		 get { } //Length: 160
		 set { } //Length: 166
	}

	private static WaitHandle() { }

	protected WaitHandle() { }

	public virtual void Close() { }

	public void Dispose() { }

	protected virtual void Dispose(bool explicitDisposing) { }

	public SafeWaitHandle get_SafeWaitHandle() { }

	private void Init() { }

	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	public virtual void set_Handle(nint value) { }

	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	internal void SetHandleInternal(SafeWaitHandle handle) { }

	private static void ThrowAbandonedMutexException() { }

	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	private static int Wait_internal(nint* handles, int numHandles, bool waitAll, int ms) { }

	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	private bool WaitOne(long timeout, bool exitContext) { }

	public virtual bool WaitOne() { }

	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	public virtual bool WaitOne(int millisecondsTimeout) { }

	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

}

