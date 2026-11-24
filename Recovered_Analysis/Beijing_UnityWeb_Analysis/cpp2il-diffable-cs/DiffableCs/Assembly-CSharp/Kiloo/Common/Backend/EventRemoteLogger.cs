namespace Kiloo.Common.Backend;

public class EventRemoteLogger : IEventRemoteLogger, IEventLogger
{
	private sealed class <>c__DisplayClass34_0
	{
		public string[] files; //Field offset: 0x8
		public float maximumSendTime; //Field offset: 0xC
		public DateTime sendStartTime; //Field offset: 0x10
		public float requestTimeWindow; //Field offset: 0x18
		public EventRemoteLogger <>4__this; //Field offset: 0x1C
		public string lastSavedFilename; //Field offset: 0x20
		public byte[] lastSavedData; //Field offset: 0x24
		public string bundleVersion; //Field offset: 0x28

		public <>c__DisplayClass34_0() { }

		internal void <Send>b__0(object <p0>) { }

	}

	private sealed class <>c__DisplayClass44_0
	{
		public Guid sessionId; //Field offset: 0x8

		public <>c__DisplayClass44_0() { }

		internal bool <CleanupOldUnsentFiles>b__0(SessionFileInfo fileInfo) { }

	}

	private sealed class <SendCoroutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public EventRemoteLogger <>4__this; //Field offset: 0x10
		public Action onComplete; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 130
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SendCoroutine>d__43(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private class Event
	{
		public string Name; //Field offset: 0x8
		public JsonDict Stats; //Field offset: 0xC
		public DateTime TimeStamp; //Field offset: 0x10

		public Event() { }

	}

	private class Session
	{
		public Guid SessionId; //Field offset: 0x8
		public string DeviceId; //Field offset: 0x18
		public DateTime StopTimeStamp; //Field offset: 0x20
		public List<Event> Events; //Field offset: 0x28
		public DateTime StartTimeStamp; //Field offset: 0x30
		public int Aborted; //Field offset: 0x38

		public Session() { }

	}

	private struct SessionFileInfo
	{
		public string File; //Field offset: 0x0
		public Guid SessionId; //Field offset: 0x4

	}

	public static readonly EventRemoteLogger instance; //Field offset: 0x0
	private const string FOLDER = "event_logs"; //Field offset: 0x0
	private const string API_POST_EVENTS_ROUTE = "api/v2/log"; //Field offset: 0x0
	private const int MAX_UNSENT_FILES = 25; //Field offset: 0x0
	public bool isPartOfSample; //Field offset: 0x8
	public bool allowSending; //Field offset: 0x9
	public bool allowSaving; //Field offset: 0xA
	private readonly TimeSpan _dataExpireTime; //Field offset: 0x10
	private Session _session; //Field offset: 0x18
	private byte[] _lastSavedData; //Field offset: 0x1C
	private string _lastSavedFilename; //Field offset: 0x20
	private bool _didAddApplicationStateHandlers; //Field offset: 0x24
	private Action onPauseOrQuit; //Field offset: 0x28
	private Action onResume; //Field offset: 0x2C
	private Uri _loggingServiceUri; //Field offset: 0x30
	private string _dataFolder; //Field offset: 0x34
	private int _maximumSessionPauseInSeconds; //Field offset: 0x38
	private bool _sendOnPause; //Field offset: 0x3C
	private float _sendOnPauseMaximumSendTime; //Field offset: 0x40
	private float _sendOnPauseRequestTimeWindow; //Field offset: 0x44
	private bool <isSending>k__BackingField; //Field offset: 0x48

	public event Action onPauseOrQuit
	{
		 add { } //Length: 805
		 remove { } //Length: 111
	}

	public event Action onResume
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public bool isSending
	{
		 get { } //Length: 559
		private set { } //Length: 111
	}

	private static EventRemoteLogger() { }

	private EventRemoteLogger() { }

	public void add_onPauseOrQuit(Action value) { }

	public void add_onResume(Action value) { }

	public void CheckSessionRemoval() { }

	private void CleanAndSend() { }

	private void CleanupOldUnsentFiles() { }

	private JsonDict ConvertFromDictionary(Dictionary<string, object> dict) { }

	public bool get_isSending() { }

	private string GetSessionJSON() { }

	private void Log(string msg) { }

	private void LogError(string msg) { }

	public void LogEvent(string eventName, Dictionary<string, object> parameters = null) { }

	private void LogWarning(string msg) { }

	private void OnApplicationPause() { }

	private void OnApplicationQuit() { }

	private void OnApplicationResume() { }

	public void remove_onPauseOrQuit(Action value) { }

	public void remove_onResume(Action value) { }

	private void Save() { }

	public void Send(float maximumSendTime, float requestTimeWindow) { }

	public Coroutine SendAsync(Action onComplete = null) { }

	private IEnumerator SendCoroutine(Action onComplete) { }

	public void SendOnPause(bool enable, float maximumSendTime = 3, float requestTimeWindow = 2) { }

	private void set_isSending(bool value) { }

	public void SetServiceInfo(Uri baseUri, int maximumSessionPauseInSeconds = 600) { }

	private void StartSession() { }

}

