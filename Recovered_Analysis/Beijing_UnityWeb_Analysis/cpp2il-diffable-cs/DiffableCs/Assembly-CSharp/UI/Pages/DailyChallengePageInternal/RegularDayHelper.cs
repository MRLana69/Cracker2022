namespace UI.Pages.DailyChallengePageInternal;

public class RegularDayHelper : DayHelper
{
	private UILabel _dayLabel; //Field offset: 0xC
	private UILabel _rewardLabel; //Field offset: 0x10
	private UISprite _checkMark; //Field offset: 0x14
	private UISprite _divider; //Field offset: 0x18
	private UISprite _backgroundActive; //Field offset: 0x1C
	private Color _activeDayLabelColor; //Field offset: 0x20
	private Color _inactiveDayLabelColor; //Field offset: 0x30
	private UISprite _rewardCoinIcon; //Field offset: 0x40
	private Layout _rewardLayout; //Field offset: 0x44
	private GameObject[] _rewards; //Field offset: 0x48
	private int _dayIndex; //Field offset: 0x4C

	public RegularDayHelper() { }

	private void ActivateToday() { }

	private void CompleteToday() { }

	private void DeactivateToday() { }

	public override void Init() { }

	public override void RefreshDay() { }

	public void SetIndex(int index) { }

	private void SetupDay(WordHuntPayload huntPayload) { }

	private bool ShouldActivateDivider(int dayIndex, int activeDayIndex) { }

}

