namespace UI.Popups;

public class ConsumablesPopup : UIScreen
{
	private sealed class <PerformAnimation>d__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public ConsumablesPopup <>4__this; //Field offset: 0x14
		private float <startTime>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1525
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PerformAnimation>d__70(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum VideoButtonTrackingState
	{
		NotSet = 0,
		NoFill = 1,
		Fill = 2,
		Cooldown = 3,
	}

	private static readonly Vector3 HOVERBOARD_POSITION_OFFSET; //Field offset: 0x0
	private static readonly Vector3 HOVERBOARD_ROTATION; //Field offset: 0xC
	private static readonly Vector3 HOVERBOARD_SCALE; //Field offset: 0x18
	private static readonly Vector3 HEADSTART_POSITION_OFFSET; //Field offset: 0x24
	private static readonly Vector3 HEADSTART_ROTATION; //Field offset: 0x30
	private static readonly Vector3 HEADSTART_SCALE; //Field offset: 0x3C
	private static readonly Vector3 SCOREBOOSTER_POSITION_OFFSET; //Field offset: 0x48
	private static readonly Vector3 SCOREBOOSTER_ROTATION; //Field offset: 0x54
	private static readonly Vector3 SCOREBOOSTER_SCALE; //Field offset: 0x60
	private UIWidget _outline; //Field offset: 0x28
	private UILabel _consumableTitle; //Field offset: 0x2C
	private UILabel _consumableCount; //Field offset: 0x30
	private UILabel _consumablePrice; //Field offset: 0x34
	private UILabel _consumableDescription; //Field offset: 0x38
	private UISprite _glowSprite; //Field offset: 0x3C
	private GameObject _hoverboardPrefab; //Field offset: 0x40
	private GameObject _headstartPrefab; //Field offset: 0x44
	private GameObject _scoreboosterPrefab; //Field offset: 0x48
	private AnimationCurve _animCurve; //Field offset: 0x4C
	private float _animationTime; //Field offset: 0x50
	private float _modelAnimScaling; //Field offset: 0x54
	private float _glowAnimScaling; //Field offset: 0x58
	private HorizontalLayout _buttonLayout; //Field offset: 0x5C
	private GameObject _watchVideoButton; //Field offset: 0x60
	private UIButtonOverlayOff _videoButtonOverlay; //Field offset: 0x64
	private GameObject _videoButtonNormalState; //Field offset: 0x68
	private UILabel _videoButtonFreeLabel; //Field offset: 0x6C
	private UIWidget _videoTvIconContainer; //Field offset: 0x70
	private GameObject _videoTvIconPrefab; //Field offset: 0x74
	private GameObject _hoverboardUIModel; //Field offset: 0x78
	private GameObject _headstartUIModel; //Field offset: 0x7C
	private GameObject _scoreboosterUIModel; //Field offset: 0x80
	private GameObject _coinboxFundsEnabled; //Field offset: 0x84
	private GameObject _coinboxFundsDisabled; //Field offset: 0x88
	private SellConsumablesHelper _consumablesHelper; //Field offset: 0x8C
	private float _originalGlowAlpha; //Field offset: 0x90
	private Vector3 _originalGlowScale; //Field offset: 0x94
	private VideoButtonTrackingState _videoButtonTrackingState; //Field offset: 0xA0
	private bool <isVideoPlaying>k__BackingField; //Field offset: 0xA4

	private bool isInRun
	{
		 get { } //Length: 10
	}

	public bool isVideoPlaying
	{
		 get { } //Length: 66
		private set { } //Length: 23
	}

	private static ConsumablesPopup() { }

	public ConsumablesPopup() { }

	private void <OnCoinsButtonClicked>b__54_0() { }

	public void BackgroundClicked() { }

	public override void GainFocus() { }

	private bool get_isInRun() { }

	public bool get_isVideoPlaying() { }

	private string GetCooldownId() { }

	public override void Hide() { }

	private void Hide3DModels() { }

	private void HideCoinboxes() { }

	public override void Init() { }

	public override void LoseFocus() { }

	public void OnApplicationResumed() { }

	public void OnCoinsButtonClicked() { }

	private void OnFinishedWatchingVideo() { }

	private void OnPowerupAmountChanged(UpgradeType upgradeType, int amount) { }

	private void OnShowVideoFailure(string locationId) { }

	public void OnVideoButtonClicked() { }

	public void OnVideoOverlayClosed() { }

	private IEnumerator PerformAnimation(float delay = 0) { }

	private void Reset3DModelScales() { }

	private void set_isVideoPlaying(bool value) { }

	private void Setup(SellableConsumable consumable) { }

	private void Setup3DModels() { }

	private void SetupCoinboxes() { }

	private bool ShouldShowVideoButton() { }

	public override void Show() { }

	private void Show3DModel(UpgradeType type) { }

	private void SwitchVideoButtonToNormalState() { }

	private void TrackConsumablePurchase(bool playedVideo) { }

	private void UpdateVideoButtonState() { }

}

