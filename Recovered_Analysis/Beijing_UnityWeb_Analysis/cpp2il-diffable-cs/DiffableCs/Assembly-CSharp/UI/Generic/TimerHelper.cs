namespace UI.Generic;

public class TimerHelper : MonoBehaviour
{
	private UISprite _background; //Field offset: 0xC
	private UISprite _animatedClock; //Field offset: 0x10
	private UISprite _clockFrame; //Field offset: 0x14
	private UILabel _timerTime; //Field offset: 0x18
	private HorizontalLayout _timerLayout; //Field offset: 0x1C
	private TimeSpinner _timerSpinner; //Field offset: 0x20
	private DateTime _endTime; //Field offset: 0x28
	private int _lastTimerLength; //Field offset: 0x30
	private Timer _refreshTimer; //Field offset: 0x34
	private bool _timerIsRunning; //Field offset: 0x38
	private string _timerText; //Field offset: 0x3C
	private Action onTimerEnded; //Field offset: 0x40

	public event Action onTimerEnded
	{
		 add { } //Length: 11
		 remove { } //Length: 114
	}

	public TimerHelper() { }

	public void add_onTimerEnded(Action value) { }

	private void AlignBackground() { }

	private void AnimateClock(bool animate, bool timeExpired = false) { }

	public void HideIcon() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void RefreshTimerLabels(TimeSpan expireTime) { }

	public void remove_onTimerEnded(Action value) { }

	public void SetAlignment(HorizontalAlignment alignment) { }

	public void SetTimerColors(Color contentColor, Color backgroundColor) { }

	public void SetTimerText(string text) { }

	public void ShowIcon() { }

	private void StartInternalTimer() { }

	public void StartTimer(DateTime endTime) { }

	public void StartTimer(TimeSpan timeSpan) { }

	private void StopInternalTimer() { }

	public void StopTimer() { }

	private void TimerRefreshed() { }

}

