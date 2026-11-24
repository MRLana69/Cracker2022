namespace System.Threading;

public sealed class ExecutionContext : IDisposable, ISerializable
{
	internal enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2,
	}

	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4,
	}

	internal struct Reader
	{
		private ExecutionContext m_ec; //Field offset: 0x0

		public bool IsFlowSuppressed
		{
			 get { } //Length: 10
		}

		public bool IsNull
		{
			 get { } //Length: 9
		}

		public Reader LogicalCallContext
		{
			 get { } //Length: 25
		}

		public SynchronizationContext SynchronizationContext
		{
			 get { } //Length: 31
		}

		public SynchronizationContext SynchronizationContextNoFlow
		{
			 get { } //Length: 25
		}

		public Reader(ExecutionContext ec) { }

		public ExecutionContext DangerousGetRawExecutionContext() { }

		public bool get_IsFlowSuppressed() { }

		public bool get_IsNull() { }

		public Reader get_LogicalCallContext() { }

		public SynchronizationContext get_SynchronizationContext() { }

		public SynchronizationContext get_SynchronizationContextNoFlow() { }

		public bool HasSameLocalValues(ExecutionContext other) { }

		public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	}

	private static readonly ExecutionContext s_dummyDefaultEC; //Field offset: 0x0
	private SynchronizationContext _syncContext; //Field offset: 0x8
	private SynchronizationContext _syncContextNoFlow; //Field offset: 0xC
	private LogicalCallContext _logicalCallContext; //Field offset: 0x10
	private IllogicalCallContext _illogicalCallContext; //Field offset: 0x14
	private Flags _flags; //Field offset: 0x18
	private Dictionary<IAsyncLocal, object> _localValues; //Field offset: 0x1C
	private List<IAsyncLocal> _localChangeNotifications; //Field offset: 0x20

	internal IllogicalCallContext IllogicalCallContext
	{
		 get { } //Length: 69
		 set { } //Length: 11
	}

	internal bool isFlowSuppressed
	{
		 get { } //Length: 12
		 set { } //Length: 34
	}

	internal bool isNewCapture
	{
		 get { } //Length: 12
		 set { } //Length: 10
	}

	internal bool IsPreAllocatedDefault
	{
		 get { } //Length: 12
	}

	internal LogicalCallContext LogicalCallContext
	{
		 get { } //Length: 12
		 set { } //Length: 1521
	}

	internal static ExecutionContext PreAllocatedDefault
	{
		 get { } //Length: 5
	}

	internal SynchronizationContext SynchronizationContext
	{
		 get { } //Length: 69
		 set { } //Length: 11
	}

	internal SynchronizationContext SynchronizationContextNoFlow
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	private static ExecutionContext() { }

	private ExecutionContext(SerializationInfo info, StreamingContext context) { }

	internal ExecutionContext() { }

	internal ExecutionContext(bool isPreAllocatedDefault) { }

	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options) { }

	public static ExecutionContext Capture() { }

	public ExecutionContext CreateCopy() { }

	internal ExecutionContext CreateMutableCopy() { }

	public void Dispose() { }

	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	internal static ExecutionContext FastCapture() { }

	internal IllogicalCallContext get_IllogicalCallContext() { }

	internal bool get_isFlowSuppressed() { }

	internal bool get_isNewCapture() { }

	internal bool get_IsPreAllocatedDefault() { }

	internal LogicalCallContext get_LogicalCallContext() { }

	internal static ExecutionContext get_PreAllocatedDefault() { }

	internal SynchronizationContext get_SynchronizationContext() { }

	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	public static bool IsFlowSuppressed() { }

	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	internal void set_isFlowSuppressed(bool value) { }

	internal void set_isNewCapture(bool value) { }

	internal void set_LogicalCallContext(LogicalCallContext value) { }

	internal void set_SynchronizationContext(SynchronizationContext value) { }

	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

}

