namespace UI.Popups.LimitedCharacterPopupInternal;

public class LimitedCharacterPopupManager
{
	private sealed class <Timer>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float timeLeft; //Field offset: 0x10
		public Action handler; //Field offset: 0x14
		private float <startPoint>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 195
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Timer>d__25(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static Action OnLimitedCharacterStartedHandler; //Field offset: 0x0
	private const CharacterId CURRENT_CHARACTER = 0; //Field offset: 0x0
	private static Action OnLimitedCharacterExpiredHandler; //Field offset: 0x4
	private static LimitedCharacterPopupManager _instance; //Field offset: 0x8
	private int <currentThemeIndex>k__BackingField; //Field offset: 0x8
	private bool _isInitialized; //Field offset: 0xC
	private IEnumerator _startTimerCoroutine; //Field offset: 0x10
	private IEnumerator _endTimerCoroutine; //Field offset: 0x14

	public static event Action OnLimitedCharacterExpiredHandler
	{
		 add { } //Length: 206
		 remove { } //Length: 209
	}

	public static event Action OnLimitedCharacterStartedHandler
	{
		 add { } //Length: 9
		 remove { } //Length: 206
	}

	public CharacterId currentCharacter
	{
		 get { } //Length: 18
	}

	public int currentThemeIndex
	{
		 get { } //Length: 149
		 set { } //Length: 14
	}

	public static LimitedCharacterPopupManager Instance
	{
		 get { } //Length: 1691
	}

	private static LimitedCharacterPopupManager() { }

	private LimitedCharacterPopupManager() { }

	public static void add_OnLimitedCharacterExpiredHandler(Action value) { }

	public static void add_OnLimitedCharacterStartedHandler(Action value) { }

	public bool CurrentlyShownCharacterMatchesEventItem() { }

	public CharacterId get_currentCharacter() { }

	public int get_currentThemeIndex() { }

	public static LimitedCharacterPopupManager get_Instance() { }

	private void Initialize() { }

	public bool IsCharacterAvailable() { }

	public static void remove_OnLimitedCharacterExpiredHandler(Action value) { }

	public static void remove_OnLimitedCharacterStartedHandler(Action value) { }

	public void set_currentThemeIndex(int value) { }

	public bool ShouldButtonBeVisible() { }

	private void StartTimer() { }

	private IEnumerator Timer(float timeLeft, Action handler) { }

}

