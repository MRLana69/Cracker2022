namespace Missions;

public class StayInOneLaneMission
{
	private sealed class <CountMissionProgressCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public StayInOneLaneMission <>4__this; //Field offset: 0x10
		public int goal; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 213
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CountMissionProgressCoroutine>d__14(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const int PROGRESS_INCREMENTS = 1; //Field offset: 0x0
	private static StayInOneLaneMission _instance; //Field offset: 0x0
	private bool _hasInited; //Field offset: 0x8
	private Character _character; //Field offset: 0xC
	private IEnumerator _countProgressCoroutine; //Field offset: 0x10
	private bool _coroutineIsRunning; //Field offset: 0x14
	private int _currentProgress; //Field offset: 0x18

	public static StayInOneLaneMission instance
	{
		 get { } //Length: 96
	}

	public StayInOneLaneMission() { }

	private IEnumerator CountMissionProgressCoroutine(int goal) { }

	public static StayInOneLaneMission get_instance() { }

	public void Init() { }

	private bool IsMissionActive(MissionType missionType, out int goal) { }

	private void OnMenuScreenShown() { }

	private void OnMissionSetCompleted() { }

	private void OnRevived() { }

	private void OnRunEnded(bool playerWasAutoRevived) { }

	private void OnRunStarted() { }

	private void OnTrackChanged(OnChangeTrackDirection direction) { }

	private void StartCountingProgressIfNeeded() { }

}

