//Type is in global namespace

public class QuickVideoButtonHelper : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__15_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <StartVideoWithDelay>b__15_0() { }

	}

	private sealed class <StartVideoWithDelay>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public QuickVideoButtonHelper <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 378
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartVideoWithDelay>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const string EVENT_QUICKVIDEO_BUTTON_SHOWN = "Quick Video Ads Button Shown"; //Field offset: 0x0
	private const string EVENT_ARG_QUICKVIDEO_VALUE_FORMAT = "step{0}|sinceDailyKeys{1}|{2}"; //Field offset: 0x0
	private const string EVENT_ARG_QUICKVIDEO_SINCE_DAILY_KEYS = "SinceDailyKeys"; //Field offset: 0x0
	private GameObject[] _hideWhenPopupsActive; //Field offset: 0xC
	private UISprite _defaultIconSprite; //Field offset: 0x10
	private UIPanel _defaultMaskPanel; //Field offset: 0x14
	private Transform _defaultRotateGlint; //Field offset: 0x18
	private List<QuickVideoButtonPrizeIconSetup> _prizeIconSetups; //Field offset: 0x1C
	private VideoAdPrize _curentVideoAdPrize; //Field offset: 0x20
	private Action onVideoStarted; //Field offset: 0x24

	public event Action onVideoStarted
	{
		 add { } //Length: 3693
		 remove { } //Length: 111
	}

	public QuickVideoButtonHelper() { }

	public void add_onVideoStarted(Action value) { }

	private void LogShownButtonToFlurry() { }

	private void OnClick() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnLastPopupClosed() { }

	private void OnPopupShown(string popupName) { }

	private void OnVideoFinished(bool withReward) { }

	public void remove_onVideoStarted(Action value) { }

	private void SetDefaultPrizeIconProperties() { }

	public void SetPrize(VideoAdPrize prize) { }

	private IEnumerator StartVideoWithDelay() { }

}

