namespace TopRun;

public interface IManager
{

	public event EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public event EventHandler<TournamentChangedEventArgs> tournamentChanged
	{
		 add { } //Length: 0
		 remove { } //Length: 0
	}

	public bool canSubmitScore
	{
		 get { } //Length: 0
	}

	public string country
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool hasFetchedTournament
	{
		 get { } //Length: 0
	}

	public int highScore
	{
		 get { } //Length: 0
	}

	public bool isRefreshing
	{
		 get { } //Length: 0
	}

	public int multiplier
	{
		 get { } //Length: 0
	}

	public DateTime nextTournamentFetchTime
	{
		 get { } //Length: 0
	}

	public bool pauseRefreshing
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public IRank rank
	{
		 get { } //Length: 0
	}

	public int score
	{
		 get { } //Length: 0
	}

	public ITournament tournament
	{
		 get { } //Length: 0
	}

	public void add_playerInfoChanged(EventHandler<PlayerInfoChangedEventArgs> value) { }

	public void add_tournamentChanged(EventHandler<TournamentChangedEventArgs> value) { }

	public void FetchNextTournament() { }

	public bool get_canSubmitScore() { }

	public string get_country() { }

	public bool get_hasFetchedTournament() { }

	public int get_highScore() { }

	public bool get_isRefreshing() { }

	public int get_multiplier() { }

	public DateTime get_nextTournamentFetchTime() { }

	public bool get_pauseRefreshing() { }

	public IRank get_rank() { }

	public int get_score() { }

	public ITournament get_tournament() { }

	public IRank GetPlayerRank(string facebookId) { }

	public void RefreshTournament() { }

	public void remove_playerInfoChanged(EventHandler<PlayerInfoChangedEventArgs> value) { }

	public void remove_tournamentChanged(EventHandler<TournamentChangedEventArgs> value) { }

	public void set_country(string value) { }

	public void set_pauseRefreshing(bool value) { }

	public void SubmitScore(int scoreToSubmit, DateTime gameStartedTime) { }

}

