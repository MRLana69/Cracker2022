namespace TopRun.UI;

public class TopRunNormalStateHelper : MonoBehaviour
{
	private enum NormalStateType
	{
		Ongoing = 0,
		WaitingForResults = 1,
		Over = 2,
	}

	private const string ZERO_CLOCK = "00:00:00"; //Field offset: 0x0
	private const int HOURS_THRESHOLD = 100; //Field offset: 0x0
	private const string DAYS_LEFT_FORMAT = "[B6CCE0]{0}[-] {1}"; //Field offset: 0x0
	private NormalStateType <currentState>k__BackingField; //Field offset: 0xC
	private UISprite _background; //Field offset: 0x10
	private UILabel _leftLabel; //Field offset: 0x14
	private UILabel _rightLabel; //Field offset: 0x18
	private ITournament _currentTournament; //Field offset: 0x1C

	private NormalStateType currentState
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public TopRunNormalStateHelper() { }

	private NormalStateType get_currentState() { }

	private string GetDaysLeft(DateTime tournamentEnd) { }

	private static string GetDaysPostfix(DateTime tournamentEnd) { }

	private string GetTimeLeftFormatted(TimeSpan timeSpan) { }

	private string GetTimeToNextTournament(DateTime nextTournamentStartTime) { }

	private bool HasNextTournamentStarted(DateTime nextTournamentStartTime) { }

	public void InitNormalState() { }

	private void set_currentState(NormalStateType value) { }

	private void SetOngoingState(ITournament tournament) { }

	private void SetOverState(ITournament tournament) { }

	private void SetWaitingForResultsState(ITournament tournament) { }

	private void Update() { }

}

