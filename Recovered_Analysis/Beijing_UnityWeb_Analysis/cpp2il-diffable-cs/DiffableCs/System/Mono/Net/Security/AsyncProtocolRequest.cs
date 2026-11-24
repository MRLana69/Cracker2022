namespace Mono.Net.Security;

internal abstract class AsyncProtocolRequest
{
	private struct <InnerRead>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Nullable<int>> <>t__builder; //Field offset: 0x4
		public AsyncProtocolRequest <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private int <requestedSize>5__1; //Field offset: 0x18
		private Nullable<int> <totalRead>5__2; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<int> <>u__1; //Field offset: 0x24

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct <ProcessOperation>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public CancellationToken cancellationToken; //Field offset: 0x10
		public AsyncProtocolRequest <>4__this; //Field offset: 0x14
		private AsyncOperationStatus <status>5__1; //Field offset: 0x18
		private AsyncOperationStatus <newStatus>5__2; //Field offset: 0x1C
		private ConfiguredTaskAwaiter<Nullable<int>> <>u__1; //Field offset: 0x20
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x28

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct <StartOperation>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; //Field offset: 0x4
		public AsyncProtocolRequest <>4__this; //Field offset: 0x10
		public CancellationToken cancellationToken; //Field offset: 0x14
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x18

		private void MoveNext() { }

		private void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly MobileAuthenticatedStream <Parent>k__BackingField; //Field offset: 0x8
	private readonly bool <RunSynchronously>k__BackingField; //Field offset: 0xC
	private int <UserResult>k__BackingField; //Field offset: 0x10
	private int Started; //Field offset: 0x14
	private int RequestedSize; //Field offset: 0x18
	private int WriteRequested; //Field offset: 0x1C
	private readonly object locker; //Field offset: 0x20

	public string Name
	{
		 get { } //Length: 9
	}

	public MobileAuthenticatedStream Parent
	{
		 get { } //Length: 6
	}

	public bool RunSynchronously
	{
		 get { } //Length: 6
	}

	public int UserResult
	{
		 get { } //Length: 13
		protected set { } //Length: 11
	}

	public AsyncProtocolRequest(MobileAuthenticatedStream parent, bool sync) { }

	public string get_Name() { }

	public MobileAuthenticatedStream get_Parent() { }

	public bool get_RunSynchronously() { }

	public int get_UserResult() { }

	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	private Task ProcessOperation(CancellationToken cancellationToken) { }

	internal void RequestRead(int size) { }

	internal void RequestWrite() { }

	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status) { }

	protected void set_UserResult(int value) { }

	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	public override string ToString() { }

}

