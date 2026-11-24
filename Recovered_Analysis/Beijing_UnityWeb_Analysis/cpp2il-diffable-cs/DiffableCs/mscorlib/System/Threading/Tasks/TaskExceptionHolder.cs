namespace System.Threading.Tasks;

internal class TaskExceptionHolder
{
	private static readonly bool s_failFastOnUnobservedException; //Field offset: 0x0
	private static bool s_domainUnloadStarted; //Field offset: 0x1
	private static EventHandler s_adUnloadEventHandler; //Field offset: 0x4
	private readonly Task m_task; //Field offset: 0x8
	private List<ExceptionDispatchInfo> m_faultExceptions; //Field offset: 0xC
	private ExceptionDispatchInfo m_cancellationException; //Field offset: 0x10
	private bool m_isHandled; //Field offset: 0x14

	internal bool ContainsFaultList
	{
		 get { } //Length: 3
	}

	private static TaskExceptionHolder() { }

	internal TaskExceptionHolder(Task task) { }

	internal void Add(object exceptionObject, bool representsCancellation) { }

	private void AddFaultException(object exceptionObject) { }

	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	private static void EnsureADUnloadCallbackRegistered() { }

	protected override void Finalize() { }

	internal bool get_ContainsFaultList() { }

	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	internal void MarkAsHandled(bool calledFromFinalizer) { }

	private void MarkAsUnhandled() { }

	private void SetCancellationException(object exceptionObject) { }

	private static bool ShouldFailFastOnUnobservedException() { }

}

