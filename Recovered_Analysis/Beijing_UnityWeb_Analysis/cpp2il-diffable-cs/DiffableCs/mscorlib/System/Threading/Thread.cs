namespace System.Threading;

public sealed class Thread : CriticalFinalizerObject, _Thread
{
	private static LocalDataStoreHolder s_LocalDataStore; //Field offset: 0x80000000
	internal static CultureInfo m_CurrentCulture; //Field offset: 0x80000004
	internal static CultureInfo m_CurrentUICulture; //Field offset: 0x80000008
	private static Thread current_thread; //Field offset: 0x8000000C
	private static LocalDataStoreMgr s_LocalDataStoreMgr; //Field offset: 0x0
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; //Field offset: 0x4
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; //Field offset: 0x8
	private InternalThread internal_thread; //Field offset: 0x8
	private object m_ThreadStartArg; //Field offset: 0xC
	private object pending_exception; //Field offset: 0x10
	private IPrincipal principal; //Field offset: 0x14
	private int principal_version; //Field offset: 0x18
	private MulticastDelegate m_Delegate; //Field offset: 0x1C
	private ExecutionContext m_ExecutionContext; //Field offset: 0x20
	private bool m_ExecutionContextBelongsToOuterScope; //Field offset: 0x24

	public static Context CurrentContext
	{
		 get { } //Length: 3
	}

	public CultureInfo CurrentCulture
	{
		 get { } //Length: 165
	}

	public static Thread CurrentThread
	{
		 get { } //Length: 41
	}

	public CultureInfo CurrentUICulture
	{
		 get { } //Length: 110
	}

	internal bool ExecutionContextBelongsToCurrentScope
	{
		 get { } //Length: 42
		 set { } //Length: 131
	}

	private InternalThread Internal
	{
		 get { } //Length: 165
	}

	public bool IsBackground
	{
		 set { } //Length: 14
	}

	public bool IsThreadPoolThread
	{
		 get { } //Length: 21
	}

	internal bool IsThreadPoolThreadInternal
	{
		 get { } //Length: 9
	}

	public int ManagedThreadId
	{
		 get { } //Length: 135
	}

	public string Name
	{
		 set { } //Length: 9
	}

	public ThreadState ThreadState
	{
		 get { } //Length: 15
	}

	public Thread(ThreadStart start) { }

	public Thread(ParameterizedThreadStart start) { }

	public static void BeginCriticalRegion() { }

	private static void ClrState(InternalThread thread, ThreadState clr) { }

	private void ConstructInternalThread() { }

	public static void EndCriticalRegion() { }

	protected override void Finalize() { }

	public static Context get_CurrentContext() { }

	public CultureInfo get_CurrentCulture() { }

	public static Thread get_CurrentThread() { }

	public CultureInfo get_CurrentUICulture() { }

	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	private InternalThread get_Internal() { }

	public bool get_IsThreadPoolThread() { }

	internal bool get_IsThreadPoolThreadInternal() { }

	public int get_ManagedThreadId() { }

	public ThreadState get_ThreadState() { }

	private CultureInfo GetCurrentCultureNoAppX() { }

	private static Thread GetCurrentThread() { }

	internal CultureInfo GetCurrentUICultureNoAppX() { }

	public static int GetDomainID() { }

	internal Reader GetExecutionContextReader() { }

	public override int GetHashCode() { }

	internal ExecutionContext GetMutableExecutionContext() { }

	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	private static ThreadState GetState(InternalThread thread) { }

	public static void MemoryBarrier() { }

	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	public void set_IsBackground(bool value) { }

	public void set_Name(string value) { }

	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	internal void SetExecutionContext(Reader value, bool belongsToCurrentScope) { }

	private static void SetName_internal(InternalThread thread, string name) { }

	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	private void SetStartHelper(Delegate start, int maxStackSize) { }

	private static void SetState(InternalThread thread, ThreadState set) { }

	public static void Sleep(int millisecondsTimeout) { }

	public static void Sleep(TimeSpan timeout) { }

	private static void SleepInternal(int millisecondsTimeout) { }

	public static void SpinWait(int iterations) { }

	private static void SpinWait_nop() { }

	private void Start(ref StackCrawlMark stackMark) { }

	public void Start() { }

	public void Start(object parameter) { }

	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	private static int SystemMaxStackStize() { }

	private nint Thread_internal(MulticastDelegate start) { }

	private ThreadState ValidateThreadState() { }

	public static bool Yield() { }

	private static bool YieldInternal() { }

}

