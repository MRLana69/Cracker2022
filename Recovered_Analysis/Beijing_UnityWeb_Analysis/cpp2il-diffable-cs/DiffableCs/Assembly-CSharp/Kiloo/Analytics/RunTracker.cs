namespace Kiloo.Analytics;

internal static class RunTracker
{
	private sealed class <RunEnded>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Action<Event> onLogReady; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 265
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RunEnded>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TrackRunLengthInSeconds>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 184
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TrackRunLengthInSeconds>d__24(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static bool _initialized; //Field offset: 0x0
	private static bool _initialMenuScreenShown; //Field offset: 0x1
	private static float _runLengthInSeconds; //Field offset: 0x4
	private static IEnumerator _runLengthTracker; //Field offset: 0x8
	private static int _saveMeCountInRun; //Field offset: 0xC
	private static bool _hasUsedSaveMe; //Field offset: 0x10
	private static Nullable<float> _runLengthUntilFirstSaveMe; //Field offset: 0x14
	private static int _baseScoreMultiplierAtStartOfRun; //Field offset: 0x1C
	private static int _hoverboardCountInRun; //Field offset: 0x20
	private static bool _wasFirstMysteryBoxPicked; //Field offset: 0x24
	private static int _MBCount; //Field offset: 0x28
	private static float _firstMysteryBoxCollectedAfterSeconds; //Field offset: 0x2C
	private static bool _runDidEnd; //Field offset: 0x30
	private static bool _runWasAborted; //Field offset: 0x31
	private static bool _isReadyToLog; //Field offset: 0x32
	private static IEnumerator _runEnded; //Field offset: 0x34

	private static RunTracker() { }

	private static Event GetRunEndedData() { }

	public static void Initialize() { }

	public static void LogRunEndedData(Action<Event> onLogReady) { }

	private static void OnGameEnded() { }

	private static void OnGameStarted() { }

	private static void OnMenuScreenShown() { }

	private static void OnMysteryOrSuperMysteryBoxPickup() { }

	private static void OnPowerupTriggered(UpgradeType upgradeType) { }

	private static void OnRevive() { }

	private static void OnRunEnded(bool playerWasAutoRevived) { }

	private static IEnumerator RunEnded(Action<Event> onLogReady) { }

	private static IEnumerator TrackRunLengthInSeconds() { }

}

