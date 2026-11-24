namespace TopRun;

public interface ITournament
{

	public string country
	{
		 get { } //Length: 0
	}

	public DateTime endTimeUTC
	{
		 get { } //Length: 0
	}

	public bool hasResult
	{
		 get { } //Length: 0
	}

	public string id
	{
		 get { } //Length: 0
	}

	public bool isFinished
	{
		 get { } //Length: 0
	}

	public DateTime nextTournamentTimeUTC
	{
		 get { } //Length: 0
	}

	public DateTime officialEndTimeUTC
	{
		 get { } //Length: 0
	}

	public int rankCount
	{
		 get { } //Length: 0
	}

	public int sequenceId
	{
		 get { } //Length: 0
	}

	public DateTime startTimeUTC
	{
		 get { } //Length: 0
	}

	public string get_country() { }

	public DateTime get_endTimeUTC() { }

	public bool get_hasResult() { }

	public string get_id() { }

	public bool get_isFinished() { }

	public DateTime get_nextTournamentTimeUTC() { }

	public DateTime get_officialEndTimeUTC() { }

	public int get_rankCount() { }

	public int get_sequenceId() { }

	public DateTime get_startTimeUTC() { }

	public int GetBestScoreForRank(int rank) { }

	public int GetNumberOfPlayersForRank(int rank) { }

	public int GetNumberOfPlayersForTournament() { }

	public IEnumerable<IPlayer> GetPlayers() { }

	public IEnumerable<IPlayer> GetPlayersForRank(int rank) { }

	public int GetRankForScore(int score) { }

}

