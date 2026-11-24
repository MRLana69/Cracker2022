//Type is in global namespace

public class UITopRunTimer : MonoBehaviour
{
	private UILabel _currentTopRunWeek; //Field offset: 0xC
	private UILabel _timerLabel; //Field offset: 0x10
	private PauseScreen _pauseScreen; //Field offset: 0x14
	private Layout _timerLayout; //Field offset: 0x18
	private bool _lessThanAdayLeft; //Field offset: 0x1C
	private int _totalSeconds; //Field offset: 0x20
	private IManager _tournamentManager; //Field offset: 0x24
	private ITournament _currentTournament; //Field offset: 0x28

	public UITopRunTimer() { }

	public void DoTimer() { }

	private void SetTextTopRunTimerLabels() { }

	private void Update() { }

}

