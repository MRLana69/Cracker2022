using System;

namespace TopRun;

public interface IManager
{
	string country { get; set; }

	int multiplier { get; }

	int highScore { get; }

	bool canSubmitScore { get; }

	bool isRefreshing { get; }

	bool pauseRefreshing { get; set; }

	bool hasFetchedTournament { get; }

	int score { get; }

	IRank rank { get; }

	DateTime nextTournamentFetchTime { get; }

	ITournament tournament { get; }

	event EventHandler<TournamentChangedEventArgs> tournamentChanged;

	event EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged;

	IRank GetPlayerRank(string facebookId);

	void FetchNextTournament();

	void RefreshTournament();

	void SubmitScore(int scoreToSubmit, DateTime gameStartedTime);
}
