namespace System.Threading.Tasks;

public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<object> <>9__276_0; //Field offset: 0x4
		public static TimerCallback <>9__276_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ContingentProperties <.cctor>b__295_0() { }

		internal bool <.cctor>b__295_1(Task t) { }

		internal bool <.cctor>b__295_2(object tc) { }

		internal void <Delay>b__276_0(object state) { }

		internal void <Delay>b__276_1(object state) { }

	}

	private sealed class <>c__DisplayClass178_0
	{
		public Task root; //Field offset: 0x8
		public bool replicasAreQuitting; //Field offset: 0xC
		public Action<object> taskReplicaDelegate; //Field offset: 0x10
		public TaskCreationOptions creationOptionsForReplicas; //Field offset: 0x14
		public InternalTaskOptions internalOptionsForReplicas; //Field offset: 0x18

		public <>c__DisplayClass178_0() { }

		internal void <ExecuteSelfReplicating>b__0(object <p0>) { }

	}

	internal class ContingentProperties
	{
		internal ExecutionContext m_capturedContext; //Field offset: 0x8
		internal ManualResetEventSlim m_completionEvent; //Field offset: 0xC
		internal TaskExceptionHolder m_exceptionsHolder; //Field offset: 0x10
		internal CancellationToken m_cancellationToken; //Field offset: 0x14
		internal Shared<CancellationTokenRegistration> m_cancellationRegistration; //Field offset: 0x18
		internal int m_internalCancellationRequested; //Field offset: 0x1C
		internal int m_completionCountdown; //Field offset: 0x20
		internal List<Task> m_exceptionalChildren; //Field offset: 0x24

		public ContingentProperties() { }

		internal void DeregisterCancellationCallback() { }

		internal void SetCompleted() { }

	}

	private sealed class DelayPromise
	{
		internal readonly CancellationToken Token; //Field offset: 0x2C
		internal CancellationTokenRegistration Registration; //Field offset: 0x30
		internal Timer Timer; //Field offset: 0x3C

		internal DelayPromise(CancellationToken token) { }

		internal void Complete() { }

	}

	private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
	{

		internal SetOnInvokeMres() { }

		public void Invoke(Task completingTask) { }

	}

	internal static Task t_currentTask; //Field offset: 0x80000000
	private static StackGuard t_stackGuard; //Field offset: 0x80000004
	private const int CANCELLATION_REQUESTED = 1; //Field offset: 0x0
	private const int TASK_STATE_COMPLETED_MASK = 23068672; //Field offset: 0x0
	internal const int TASK_STATE_TASKSCHEDULED_WAS_FIRED = 1073741824; //Field offset: 0x0
	internal const int TASK_STATE_EXECUTIONCONTEXT_IS_NULL = 536870912; //Field offset: 0x0
	internal const int TASK_STATE_WAIT_COMPLETION_NOTIFICATION = 268435456; //Field offset: 0x0
	internal const int TASK_STATE_THREAD_WAS_ABORTED = 134217728; //Field offset: 0x0
	internal const int TASK_STATE_COMPLETION_RESERVED = 67108864; //Field offset: 0x0
	internal const int TASK_STATE_WAITINGFORACTIVATION = 33554432; //Field offset: 0x0
	internal const int TASK_STATE_WAITING_ON_CHILDREN = 8388608; //Field offset: 0x0
	internal const int TASK_STATE_CANCELED = 4194304; //Field offset: 0x0
	internal const int TASK_STATE_FAULTED = 2097152; //Field offset: 0x0
	internal const int TASK_STATE_CANCELLATIONACKNOWLEDGED = 1048576; //Field offset: 0x0
	internal const int TASK_STATE_RAN_TO_COMPLETION = 16777216; //Field offset: 0x0
	internal const int TASK_STATE_DISPOSED = 262144; //Field offset: 0x0
	internal const int TASK_STATE_EXCEPTIONOBSERVEDBYPARENT = 524288; //Field offset: 0x0
	private const int OptionsMask = 65535; //Field offset: 0x0
	internal static int s_taskIdCounter; //Field offset: 0x0
	internal const int TASK_STATE_DELEGATE_INVOKED = 131072; //Field offset: 0x0
	internal const int TASK_STATE_STARTED = 65536; //Field offset: 0x0
	private static readonly TaskFactory s_factory; //Field offset: 0x4
	private static readonly object s_taskCompletionSentinel; //Field offset: 0x8
	internal static bool s_asyncDebuggingEnabled; //Field offset: 0xC
	private static readonly Dictionary<int, Task> s_currentActiveTasks; //Field offset: 0x10
	private static readonly object s_activeTasksLock; //Field offset: 0x14
	private static readonly Action<object> s_taskCancelCallback; //Field offset: 0x18
	private static readonly Func<ContingentProperties> s_createContingentProperties; //Field offset: 0x1C
	private static Task s_completedTask; //Field offset: 0x20
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; //Field offset: 0x24
	private static ContextCallback s_ecCallback; //Field offset: 0x28
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; //Field offset: 0x2C
	private int m_taskId; //Field offset: 0x8
	internal object m_action; //Field offset: 0xC
	internal object m_stateObject; //Field offset: 0x10
	internal TaskScheduler m_taskScheduler; //Field offset: 0x14
	internal readonly Task m_parent; //Field offset: 0x18
	internal int m_stateFlags; //Field offset: 0x1C
	private object m_continuationObject; //Field offset: 0x20
	internal ContingentProperties m_contingentProperties; //Field offset: 0x24

	public object AsyncState
	{
		 get { } //Length: 116
	}

	internal CancellationToken CancellationToken
	{
		 get { } //Length: 55
	}

	internal ExecutionContext CapturedContext
	{
		 get { } //Length: 15
		 set { } //Length: 122
	}

	internal ManualResetEventSlim CompletedEvent
	{
		 get { } //Length: 6
	}

	public static Task CompletedTask
	{
		 get { } //Length: 89
	}

	public TaskCreationOptions CreationOptions
	{
		 get { } //Length: 18
	}

	internal static StackGuard CurrentStackGuard
	{
		 get { } //Length: 90
	}

	public AggregateException Exception
	{
		 get { } //Length: 88
	}

	internal bool ExceptionRecorded
	{
		 get { } //Length: 16
	}

	internal TaskScheduler ExecutingTaskScheduler
	{
		 get { } //Length: 3
	}

	public static TaskFactory Factory
	{
		 get { } //Length: 176
	}

	internal virtual Task HandedOverChildReplica
	{
		 get { } //Length: 3
		 set { } //Length: 2
	}

	public int Id
	{
		 get { } //Length: 18
	}

	internal static Task InternalCurrent
	{
		 get { } //Length: 111
	}

	public bool IsCanceled
	{
		 get { } //Length: 96
	}

	internal bool IsCancellationAcknowledged
	{
		 get { } //Length: 51
	}

	internal bool IsCancellationRequested
	{
		 get { } //Length: 18
	}

	internal bool IsChildReplica
	{
		 get { } //Length: 17
	}

	public bool IsCompleted
	{
		 get { } //Length: 15
	}

	internal bool IsDelegateInvoked
	{
		 get { } //Length: 14
	}

	internal bool IsExceptionObservedByParent
	{
		 get { } //Length: 32
	}

	public bool IsFaulted
	{
		 get { } //Length: 36
	}

	internal bool IsRanToCompletion
	{
		 get { } //Length: 12
	}

	internal bool IsSelfReplicatingRoot
	{
		 get { } //Length: 158
	}

	internal bool IsWaitNotificationEnabled
	{
		 get { } //Length: 16
	}

	internal bool IsWaitNotificationEnabledOrNotRanToCompletion
	{
		 get { } //Length: 43
	}

	internal TaskCreationOptions Options
	{
		 get { } //Length: 544
	}

	internal virtual object SavedStateForNextReplica
	{
		 get { } //Length: 3
	}

	internal virtual object SavedStateFromPreviousReplica
	{
		 set { } //Length: 490
	}

	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
	{
		 get { } //Length: 19
	}

	public TaskStatus Status
	{
		 get { } //Length: 28
	}

	private WaitHandle System.IAsyncResult.AsyncWaitHandle
	{
		 get { } //Length: 14
	}

	private bool System.IAsyncResult.CompletedSynchronously
	{
		 get { } //Length: 6
	}

	private static Task() { }

	internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	internal Task() { }

	internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	internal void AddCompletionAction(ITaskCompletionAction action) { }

	internal void AddException(object exceptionObject, bool representsCancellation) { }

	internal void AddException(object exceptionObject) { }

	internal void AddExceptionsFromChildren() { }

	internal void AddNewChild() { }

	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	internal static bool AddToActiveTasks(Task task) { }

	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	internal void CancellationCleanupLogic() { }

	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	public Task ContinueWith(Action<Task> continuationAction) { }

	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	internal void DisregardChild() { }

	internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	private void Execute() { }

	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	private static void ExecuteSelfReplicating(Task root) { }

	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	private static void ExecutionContextCallback(object obj) { }

	internal void Finish(bool bUserDelegateExecuted) { }

	internal void FinishContinuations() { }

	internal void FinishStageThree() { }

	internal void FinishStageTwo() { }

	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	internal static Task<TResult> FromCancellation(CancellationToken cancellationToken) { }

	internal static Task<TResult> FromCancellation(OperationCanceledException exception) { }

	public static Task<TResult> FromException(Exception exception) { }

	public static Task FromException(Exception exception) { }

	public static Task<TResult> FromResult(TResult result) { }

	public object get_AsyncState() { }

	internal CancellationToken get_CancellationToken() { }

	internal ExecutionContext get_CapturedContext() { }

	internal ManualResetEventSlim get_CompletedEvent() { }

	public static Task get_CompletedTask() { }

	public TaskCreationOptions get_CreationOptions() { }

	internal static StackGuard get_CurrentStackGuard() { }

	public AggregateException get_Exception() { }

	internal bool get_ExceptionRecorded() { }

	internal TaskScheduler get_ExecutingTaskScheduler() { }

	public static TaskFactory get_Factory() { }

	internal virtual Task get_HandedOverChildReplica() { }

	public int get_Id() { }

	internal static Task get_InternalCurrent() { }

	public bool get_IsCanceled() { }

	internal bool get_IsCancellationAcknowledged() { }

	internal bool get_IsCancellationRequested() { }

	internal bool get_IsChildReplica() { }

	public bool get_IsCompleted() { }

	internal bool get_IsDelegateInvoked() { }

	internal bool get_IsExceptionObservedByParent() { }

	public bool get_IsFaulted() { }

	internal bool get_IsRanToCompletion() { }

	internal bool get_IsSelfReplicatingRoot() { }

	internal bool get_IsWaitNotificationEnabled() { }

	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	internal TaskCreationOptions get_Options() { }

	internal virtual object get_SavedStateForNextReplica() { }

	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	public TaskStatus get_Status() { }

	public TaskAwaiter GetAwaiter() { }

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	private void HandleException(Exception unhandledException) { }

	internal virtual void InnerInvoke() { }

	internal void InnerInvokeWithArg(Task childTask) { }

	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private static bool IsCompletedMethod(int flags) { }

	private void LogFinishCompletionNotification() { }

	internal bool MarkStarted() { }

	internal static int NewId() { }

	private void NotifyDebuggerOfWaitCompletion() { }

	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	internal static TaskCreationOptions OptionsMethod(int flags) { }

	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	internal void ProcessChildCompletion(Task childTask) { }

	internal void RecordInternalCancellationRequest() { }

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	internal void RemoveContinuation(object continuationObject) { }

	internal static void RemoveFromActiveTasks(int taskId) { }

	public static Task<TResult> Run(Func<TResult> function) { }

	public static Task Run(Action action) { }

	internal void ScheduleAndStart(bool needsProtection) { }

	internal void set_CapturedContext(ExecutionContext value) { }

	internal virtual void set_HandedOverChildReplica(Task value) { }

	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	private void SetCancellationAcknowledged() { }

	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	internal void SetNotificationForWaitCompletion(bool enabled) { }

	internal virtual bool ShouldReplicate() { }

	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	private bool SpinWait(int millisecondsTimeout) { }

	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	private static void TaskCancelCallback(object o) { }

	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	internal void UpdateExceptionObservedStatus() { }

	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	public void Wait() { }

	public static Task<Task> WhenAny(Task[] tasks) { }

	private bool WrappedTryRunInline() { }

}

