//Type is in global namespace

public class WeeklyHuntTesterPopup : UIScreen
{
	private enum PeriodTiming
	{
		None = 0,
		Beginning = 1,
		FiveMinsToExpiry = 2,
		ThirtySecsToExpiry = 3,
	}

	private enum ProgressStates
	{
		None = 0,
		Zero = 1,
		AlmostComplete = 2,
		Complete = 3,
	}

	private SelectPopupButton _weekSelectPopupButton; //Field offset: 0x28
	private SelectPopupButton _timingSelectPopupButton; //Field offset: 0x2C
	private SelectPopupButton _progressStatesPopupButton; //Field offset: 0x30
	private PrizePeriodId _selectedPeriod; //Field offset: 0x34
	private PeriodTiming _periodTiming; //Field offset: 0x38
	private ProgressStates _progressState; //Field offset: 0x3C

	public WeeklyHuntTesterPopup() { }

	public void OnProgressSelected() { }

	public void OnTimeSelected() { }

	public void OnWeekSelected() { }

	public void ResetWeeklyHunt() { }

	public void SaveAndClose() { }

	private void Start() { }

}

