//Type is in global namespace

public class SaveMePopup : UIScreen
{
	private sealed class <StartClockAnimation>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SaveMePopup <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 352
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartClockAnimation>d__33(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum ClickAction
	{
		WatchAd = 0,
		SpendKeys = 1,
	}

	public const float TIMEOUT_ANIMATION_DURATION = 4; //Field offset: 0x0
	private const float TIMEOUT_VIDEO_LOAD = 5; //Field offset: 0x0
	private static bool _revivedWithAds; //Field offset: 0x0
	private static bool _adsFailed; //Field offset: 0x1
	private static bool _adsNotAvailable; //Field offset: 0x2
	private UIWidget _outline; //Field offset: 0x28
	private SaveMeAnimateClock _saveMeAnimateClock; //Field offset: 0x2C
	private float <AnimTimeLeft>k__BackingField; //Field offset: 0x30
	private UILabel _saveMeButtonLabel; //Field offset: 0x34
	private UILabel _keyCostLabel; //Field offset: 0x38
	private UILabel _freeLabel; //Field offset: 0x3C
	private HorizontalLayout _buttonLayout; //Field offset: 0x40
	private GameObject _spendKeysButton; //Field offset: 0x44
	private GameObject _watchAdButton; //Field offset: 0x48
	private UIWidget _animatedTVIconContainer; //Field offset: 0x4C
	private GameObject _animatedTVIconPrefab; //Field offset: 0x50
	private Coroutine countdownCoroutine; //Field offset: 0x54
	private bool _isWatchingVideoForRevive; //Field offset: 0x58

	public float AnimTimeLeft
	{
		 get { } //Length: 6
		private set { } //Length: 71
	}

	public bool VideoIsPlaying
	{
		 get { } //Length: 270
		 set { } //Length: 466
	}

	public SaveMePopup() { }

	private void CreateTVIcon() { }

	public float get_AnimTimeLeft() { }

	public bool get_VideoIsPlaying() { }

	public override void Hide() { }

	public override void Init() { }

	private void LogAttemptToShowButton() { }

	private void OnApplicationResumed() { }

	private void OnFinishedWatchingVideo() { }

	private void OnShowVideoFailure(string id) { }

	public void OnSpendKeysClicked() { }

	private void OnVideoOverlayClosed() { }

	public void OnWatchAdClicked() { }

	private void PostSaveMeClickEvent(ClickAction action) { }

	private static void RevivePlayer() { }

	private void ReviveWithKeys() { }

	public void rewardedBreakComplete(bool withReward) { }

	private void set_AnimTimeLeft(float value) { }

	public void set_VideoIsPlaying(bool value) { }

	public override void Show() { }

	private IEnumerator StartClockAnimation() { }

	public void StartCountdown() { }

	private void UpdateButtonStates() { }

}

