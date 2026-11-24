namespace UI.Pages;

public class WeeklyHuntPage : Page
{
	private sealed class <>c__DisplayClass39_0
	{
		public Nullable<TransformValues> posData; //Field offset: 0x8
		public WeeklyHuntPage <>4__this; //Field offset: 0x30
		public bool showPresentIcon; //Field offset: 0x34

		public <>c__DisplayClass39_0() { }

		internal void <SetupRewardObject>b__0() { }

	}

	private List<WeekCell> _weekCellTabs; //Field offset: 0x10
	private PageTop _topPrefab; //Field offset: 0x14
	private GameObject _weeklyHuntIconPrefab; //Field offset: 0x18
	private TimerHelper _timerPrefab; //Field offset: 0x1C
	private GameObject _questionmarkReward; //Field offset: 0x20
	private UILabel _activeWeekGoalLabel; //Field offset: 0x24
	private UILabel _rewardHeader; //Field offset: 0x28
	private UILabel _prizeLabel; //Field offset: 0x2C
	private UISprite _activeWeekBgElement; //Field offset: 0x30
	private UISprite _rewardBgElement; //Field offset: 0x34
	private UISprite _completedSprite; //Field offset: 0x38
	private UISprite _missedUiSprite; //Field offset: 0x3C
	private GameObject _activeProgressSlider; //Field offset: 0x40
	private UISprite _activeProgressBg; //Field offset: 0x44
	private UISprite _activeProgressFg; //Field offset: 0x48
	private UILabel _activeProgressText; //Field offset: 0x4C
	private UIWidget _rewardSectionWidget; //Field offset: 0x50
	private UIWidget _rewardObjectGuide; //Field offset: 0x54
	private UISprite[] _beams; //Field offset: 0x58
	private UISprite _glow; //Field offset: 0x5C
	private GameObject _presentPrefabBlue; //Field offset: 0x60
	private GameObject _presentPrefabGreen; //Field offset: 0x64
	private GameObject _presentPrefabRed; //Field offset: 0x68
	private PageTop _top; //Field offset: 0x6C
	private TimerHelper _timer; //Field offset: 0x70
	private PrizePeriodId _currentPeriod; //Field offset: 0x74
	private GameObject _weeklyHuntRewardPrefab; //Field offset: 0x78
	private GameObject _weeklyHuntRewardGameObject; //Field offset: 0x7C
	private Vector3 _rewardBaseRoationEuler; //Field offset: 0x80
	private Vector3 _animatedRewardRotationEuler; //Field offset: 0x8C
	private float _currentRewardRotationDuration; //Field offset: 0x98
	private int _rewardRotationDirection; //Field offset: 0x9C

	public WeeklyHuntPage() { }

	private void <Init>b__32_0() { }

	private void <Init>b__32_1(string s) { }

	private GameObject <Init>b__32_2(UIWidget w) { }

	public override FooterPayload GetButtonPayload() { }

	public override void Hide() { }

	public override void Init(UIWidget pageGuideWidget) { }

	private void RefreshPage() { }

	public void RefreshProgressBar(int currentItemAmount, int totalItemAmount) { }

	private void RefreshTimerState() { }

	private void RotateReward(Transform transformToRotate) { }

	private void SetObjectVisibility(bool visible) { }

	private void SetupDynamicColors() { }

	private void SetupDynamicSprites() { }

	private void SetupDynamicTexts() { }

	private void SetupRewardObject() { }

	public override void Show() { }

	private void TabClicked(PrizePeriodId tabId) { }

	private void Update() { }

	private void UpdateTabs() { }

}

