namespace WordHunt;

public class WordHuntManager
{
	private sealed class <DownloadDailyCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public WordHuntManager <>4__this; //Field offset: 0x10
		private string <key>5__2; //Field offset: 0x14
		private WWW <www>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 583
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DownloadDailyCoroutine>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class WordHuntPayload
	{
		public bool todayCompleted; //Field offset: 0x8
		public int activeDayIndex; //Field offset: 0xC

		public WordHuntPayload() { }

	}

	public struct WordHuntReward
	{
		public WordHuntRewardType type; //Field offset: 0x0
		public int coins; //Field offset: 0x4
		public Type mysteryBoxType; //Field offset: 0x8

	}

	public enum WordHuntRewardType
	{
		Coins = 0,
		MysteryBox = 1,
	}

	private enum WordHuntServerData
	{
		wordIndex = 0,
		dailyWord = 1,
		year = 2,
		checksum = 3,
		month = 4,
		day = 5,
		hour = 6,
		minute = 7,
		second = 8,
		expireSeconds = 9,
	}

	private static readonly WordHuntReward[] REWARDS; //Field offset: 0x0
	private static WordHuntManager _instance; //Field offset: 0x4
	private static Action OnPickedUpLetter; //Field offset: 0x8
	private static Action OnDailyWordInRowChanged; //Field offset: 0xC
	private static Action<int> OnDailyLetterCoinsRewarded; //Field offset: 0x10
	private string[] _lastRawData; //Field offset: 0x8
	private DateTime _lastRequestTime; //Field offset: 0x10
	private List<string> _wordHuntWords; //Field offset: 0x18

	public static event Action<int> OnDailyLetterCoinsRewarded
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnDailyWordInRowChanged
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnPickedUpLetter
	{
		 add { } //Length: 9
		 remove { } //Length: 209
	}

	public static WordHuntManager instance
	{
		 get { } //Length: 213
	}

	private static WordHuntManager() { }

	private WordHuntManager() { }

	public static void add_OnDailyLetterCoinsRewarded(Action<int> value) { }

	public static void add_OnDailyWordInRowChanged(Action value) { }

	public static void add_OnPickedUpLetter(Action value) { }

	private void AppHasRefreshed(RefreshType obj) { }

	private void AutoSyncer(string screenName) { }

	private void CalculateAndSaveLastKnownServerTime(string year, string month, string day, string hour, string minute, string second) { }

	public static void CheckIfWeShouldRemoveProgressForDailyQuestInRow() { }

	public void DownloadDaily() { }

	private IEnumerator DownloadDailyCoroutine() { }

	public void DownloadDailyIfExpired() { }

	private static string GenerateKey() { }

	public static WordHuntManager get_instance() { }

	private string GetDailyWordOffline() { }

	public static char GetNewDailyLetter() { }

	private int GetRemainingSeconds() { }

	public static WordHuntReward GetRewardForDay(int dayIndex) { }

	public static int GetWordHuntDaysInARow(out bool todayCompleted) { }

	public static WordHuntPayload GetWordHuntPayload() { }

	public static bool HasTimeLeft() { }

	private static void InitWordHunt(string word, int secondsLeft) { }

	public static bool IsActiveDailyLetterEvent() { }

	private bool IsAllowedToMakeRequest(DateTime time) { }

	public static bool IsDailyWordComplete() { }

	private void LoadDailyData() { }

	private void LoadFromOfflineData() { }

	private void LoadFromRawData(string[] rawData) { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public static void PickedupLetter(char letter) { }

	private static int RandomNumber(int min, int max) { }

	private static string RandomString(int size) { }

	public static void remove_OnDailyLetterCoinsRewarded(Action<int> value) { }

	public static void remove_OnDailyWordInRowChanged(Action value) { }

	public static void remove_OnPickedUpLetter(Action value) { }

	private bool SHA1HashCheck(string[] rawData, string key) { }

}

