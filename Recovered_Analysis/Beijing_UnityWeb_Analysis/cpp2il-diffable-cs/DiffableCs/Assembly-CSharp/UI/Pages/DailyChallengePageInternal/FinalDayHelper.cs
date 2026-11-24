namespace UI.Pages.DailyChallengePageInternal;

public class FinalDayHelper : DayHelper
{
	private class DailyWordPayload
	{
		public bool mostRecentlyCompletedIsToday; //Field offset: 0x8
		public int activeDayIndex; //Field offset: 0xC

		public DailyWordPayload() { }

	}

	private UILabel _dayLabel; //Field offset: 0xC
	private UILabel _rewardLabel; //Field offset: 0x10
	private UISprite _checkMark; //Field offset: 0x14
	private UISprite _background; //Field offset: 0x18
	private Color _activeLabelColor; //Field offset: 0x1C
	private Color _activeLabelShadowColor; //Field offset: 0x2C
	private Color _inactiveLabelColor; //Field offset: 0x3C
	private Color _inactiveLabelShadowColor; //Field offset: 0x4C
	private UISprite[] _beams; //Field offset: 0x5C
	private UISprite _glow; //Field offset: 0x60

	public FinalDayHelper() { }

	private void ActivateToday() { }

	private void CompleteToday() { }

	private void DeactivateToday() { }

	private DailyWordPayload GetData() { }

	public override void Init() { }

	public override void RefreshDay() { }

	private void SetupDay(DailyWordPayload payload) { }

}

