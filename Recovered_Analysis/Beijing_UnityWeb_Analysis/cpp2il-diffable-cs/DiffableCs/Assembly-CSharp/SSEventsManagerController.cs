//Type is in global namespace

public class SSEventsManagerController
{
	private sealed class <TimerToEventFinish>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public long timeLeft; //Field offset: 0x10
		public SSEventsManagerController <>4__this; //Field offset: 0x18
		private float <startPoint>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 279
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TimerToEventFinish>d__38(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TimerToEventStart>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public long timeLeft; //Field offset: 0x10
		public SSEventsManagerController <>4__this; //Field offset: 0x18
		private float <startPoint>5__2; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 408
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TimerToEventStart>d__37(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static bool HasLoggedRouteEventWarning; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_MEGA_JACKPOT_SMB_VALUE = "event_jackpot_supermysterybox_value"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_MEGA_JACKPOT_MB_VALUE = "event_jackpot_mysterybox_value"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_RIBBON_TEXT = "event_ribbon_text"; //Field offset: 0x0
	public const string ONLINE_SETTING_DESCRIPTION_SECOND = "event_popup_description_second"; //Field offset: 0x0
	public const string ONLINE_SETTING_DESCRIPTION_FIRST = "event_popup_description_first"; //Field offset: 0x0
	public const string ONLINE_SETTING_TITLE_SECOND = "event_popup_title_second"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_CATEGORY = "event_category"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_TYPE = "event_type"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_VALUE = "event_value"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_END = "event_end"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_START = "event_start"; //Field offset: 0x0
	public const string ONLINE_SETTING_EVENT_ID = "event_id"; //Field offset: 0x0
	public const string ONLINE_SETTING_TITLE_FIRST = "event_popup_title_first"; //Field offset: 0x0
	private static GameObject _eventTimerGameObject; //Field offset: 0x4
	private static MonoBehaviour _eventTimerMono; //Field offset: 0x8
	private static Action OnSSEventStartedHandler; //Field offset: 0xC
	private static Action OnSSEventFinishedHandler; //Field offset: 0x10
	private static Action OnSSEventChangedHandler; //Field offset: 0x14
	private static SSEventsManagerController _instance; //Field offset: 0x18
	private IEventManager _currentEventManager; //Field offset: 0x8
	private bool _isInitialized; //Field offset: 0xC

	public static event Action OnSSEventChangedHandler
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnSSEventFinishedHandler
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnSSEventStartedHandler
	{
		 add { } //Length: 8
		 remove { } //Length: 209
	}

	public static SSEventsManagerController instance
	{
		 get { } //Length: 96
	}

	private static SSEventsManagerController() { }

	private SSEventsManagerController() { }

	public static void add_OnSSEventChangedHandler(Action value) { }

	public static void add_OnSSEventFinishedHandler(Action value) { }

	public static void add_OnSSEventStartedHandler(Action value) { }

	public void CurrentEventHasBeenTriedNow() { }

	public bool DoesCharacterMatchCurrentEvent(CharacterId characterId) { }

	private long EndTimestampForCurrentEventType() { }

	public static SSEventsManagerController get_instance() { }

	public IEventManager GetActiveEventManager(SSEventType desiredEventType = 0) { }

	private long GetCurrentEventID() { }

	private SSEventType GetEnabledEventType() { }

	public T GetTypeOfActiveEventManager() { }

	private double GetUnixCurrentTimestamp() { }

	public bool HasTheCurrentEventBeenTried() { }

	public void Initialize() { }

	private bool IsAnyEventEnabled() { }

	private void OnHasRefreshed(RefreshType refreshType) { }

	public static void remove_OnSSEventChangedHandler(Action value) { }

	public static void remove_OnSSEventFinishedHandler(Action value) { }

	public static void remove_OnSSEventStartedHandler(Action value) { }

	public void RestoreBoardAfterEventIfNeeded() { }

	private void SetCurrentEventManager() { }

	private void StartEventTimer() { }

	private long StartTimestampForCurrentEventType() { }

	public long TimeLeftInSeconds() { }

	private IEnumerator TimerToEventFinish(long timeLeft) { }

	private IEnumerator TimerToEventStart(long timeLeft) { }

}

