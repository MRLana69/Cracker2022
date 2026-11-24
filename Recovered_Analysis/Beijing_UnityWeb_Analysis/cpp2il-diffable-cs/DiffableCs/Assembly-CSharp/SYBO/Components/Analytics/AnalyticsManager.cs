namespace SYBO.Components.Analytics;

public class AnalyticsManager
{
	private sealed class <WaitForResult>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AsyncRes res; //Field offset: 0x10
		public Action<byte[], int, string> receiver; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 169
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitForResult>d__44(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static readonly string DefaultUserID; //Field offset: 0x0
	private static long _tickOffset; //Field offset: 0x8
	private static long _lastTick; //Field offset: 0x10
	private Action<string> OnEventPosted; //Field offset: 0x8
	private Action OnSendEventsChunkToServerStarted; //Field offset: 0xC
	private Action<ProcessAnalyticsEventsResponse> OnSendEventsChunkToServerFinished; //Field offset: 0x10
	private IPostAnalytics <Endpoint>k__BackingField; //Field offset: 0x14
	private bool _validUser; //Field offset: 0x18
	private bool _inFlush; //Field offset: 0x19
	private ProcessAnalyticsEventsResponse _lastFlushServerResponse; //Field offset: 0x1C
	private bool _flushDelayed; //Field offset: 0x20
	private bool _retryOnTimeoutOr5xxError; //Field offset: 0x21
	private DateTime _deviceStartupTime; //Field offset: 0x28
	private string _userID; //Field offset: 0x30
	private string _gameVersion; //Field offset: 0x34
	private PersistentAnalyticsEventLog _eventLog; //Field offset: 0x38
	private ICoroutineHandler _coroutineHost; //Field offset: 0x3C

	public event Action<string> OnEventPosted
	{
		 add { } //Length: 150
		 remove { } //Length: 111
	}

	public event Action<ProcessAnalyticsEventsResponse> OnSendEventsChunkToServerFinished
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnSendEventsChunkToServerStarted
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public IPostAnalytics Endpoint
	{
		 get { } //Length: 81
		 set { } //Length: 111
	}

	public string GameVersion
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public bool HasValidUserID
	{
		 get { } //Length: 6
	}

	public bool InFlush
	{
		 get { } //Length: 6
	}

	public ProcessAnalyticsEventsResponse LastFlushServerResponse
	{
		 get { } //Length: 9
	}

	private static AnalyticsManager() { }

	public AnalyticsManager(IPostAnalytics endpoint, PersistentAnalyticsEventLog eventLog, ICoroutineHandler coroutineHost) { }

	public void add_OnEventPosted(Action<string> value) { }

	public void add_OnSendEventsChunkToServerFinished(Action<ProcessAnalyticsEventsResponse> value) { }

	public void add_OnSendEventsChunkToServerStarted(Action value) { }

	public void ChangeUserID(string userID) { }

	public void Flush() { }

	private void FlushInternal() { }

	public IPostAnalytics get_Endpoint() { }

	public string get_GameVersion() { }

	public bool get_HasValidUserID() { }

	public bool get_InFlush() { }

	public ProcessAnalyticsEventsResponse get_LastFlushServerResponse() { }

	private DateTime GetDeviceStartupTime() { }

	private string GetGameVersion() { }

	public static long GetMsTicksSinceDeviceStartup() { }

	private string GetUserID() { }

	private void HandleJsonChunk(byte[] eventsJson, int uncompressedChunkLength, string uncompressedMD5Hash) { }

	private void HandlePostAnalyticsReponse(ProcessAnalyticsEventsResponse response) { }

	public void PostEvent(T eventData) { }

	private void PostEvent(string eventJson) { }

	public void remove_OnEventPosted(Action<string> value) { }

	public void remove_OnSendEventsChunkToServerFinished(Action<ProcessAnalyticsEventsResponse> value) { }

	public void remove_OnSendEventsChunkToServerStarted(Action value) { }

	public void set_Endpoint(IPostAnalytics value) { }

	public void set_GameVersion(string value) { }

	public void SetUserID(string userID) { }

	public void Shutdown() { }

	private IEnumerator WaitForResult(AsyncRes res, Action<byte[], int, string> receiver) { }

}

