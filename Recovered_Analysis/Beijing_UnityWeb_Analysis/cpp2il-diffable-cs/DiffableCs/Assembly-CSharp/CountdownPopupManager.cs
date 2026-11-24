//Type is in global namespace

public class CountdownPopupManager
{
	private sealed class <Update>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CountdownPopupManager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 250
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Update>d__28(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static CountdownPopupManager _instance; //Field offset: 0x0
	private const int DefaultCountdown = 3; //Field offset: 0x0
	private float <CountdownInSeconds>k__BackingField; //Field offset: 0x8
	private bool <IsCountdownActive>k__BackingField; //Field offset: 0xC
	private float _timeStart; //Field offset: 0x10
	private float _timeDelta; //Field offset: 0x14
	private float _actual; //Field offset: 0x18
	private bool _timeStarted; //Field offset: 0x1C
	private Coroutine _countdownCoroutine; //Field offset: 0x20
	private Action _customEndLogic; //Field offset: 0x24
	private Action <OnCountdownEnded>k__BackingField; //Field offset: 0x28

	public float CountdownInSeconds
	{
		 get { } //Length: 30
		private set { } //Length: 182
	}

	public static CountdownPopupManager Instance
	{
		 get { } //Length: 171
	}

	public bool IsCountdownActive
	{
		 get { } //Length: 56
		private set { } //Length: 944
	}

	public Action OnCountdownEnded
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public CountdownPopupManager() { }

	private void CountdownEnded() { }

	private void DefaultEndLogic() { }

	public float get_CountdownInSeconds() { }

	public static CountdownPopupManager get_Instance() { }

	public bool get_IsCountdownActive() { }

	public Action get_OnCountdownEnded() { }

	private void set_CountdownInSeconds(float value) { }

	private void set_IsCountdownActive(bool value) { }

	public void set_OnCountdownEnded(Action value) { }

	public void StartCountdown() { }

	public void StartCountdown(Action customEndLogic) { }

	public void StartCountdown(float countdown, Action customEndLogic) { }

	public void StopCountdown() { }

	private IEnumerator Update() { }

	private float UpdateRealTimeDelta() { }

}

