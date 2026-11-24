namespace TopRun.Internal;

internal class Tournament : ITournament
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Participant> <>9__6_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__6_0(Participant player1, Participant player2) { }

	}

	private sealed class <GetPlayers>d__43 : IEnumerable<IPlayer>, IEnumerable, IEnumerator<IPlayer>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private IPlayer <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		public Tournament <>4__this; //Field offset: 0x14
		private Participant[] <>7__wrap1; //Field offset: 0x18
		private int <>7__wrap2; //Field offset: 0x1C

		private IPlayer System.Collections.Generic.IEnumerator<TopRun.IPlayer>.Current
		{
			 get { } //Length: 323
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetPlayers>d__43(int <>1__state) { }

		private bool MoveNext() { }

		private IEnumerator<IPlayer> System.Collections.Generic.IEnumerable<TopRun.IPlayer>.GetEnumerator() { }

		private IPlayer System.Collections.Generic.IEnumerator<TopRun.IPlayer>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <GetPlayersForRank>d__44 : IEnumerable<IPlayer>, IEnumerable, IEnumerator<IPlayer>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private IPlayer <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private int rank; //Field offset: 0x14
		public int <>3__rank; //Field offset: 0x18
		public Tournament <>4__this; //Field offset: 0x1C
		private int <lowest>5__2; //Field offset: 0x20
		private int <highest>5__3; //Field offset: 0x24
		private Participant[] <>7__wrap3; //Field offset: 0x28
		private int <>7__wrap4; //Field offset: 0x2C

		private IPlayer System.Collections.Generic.IEnumerator<TopRun.IPlayer>.Current
		{
			 get { } //Length: 460
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetPlayersForRank>d__44(int <>1__state) { }

		private bool MoveNext() { }

		private IEnumerator<IPlayer> System.Collections.Generic.IEnumerable<TopRun.IPlayer>.GetEnumerator() { }

		private IPlayer System.Collections.Generic.IEnumerator<TopRun.IPlayer>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private struct Participant
	{
		public string publicKey; //Field offset: 0x0
		public int highScore; //Field offset: 0x4

	}

	private struct Rank
	{
		public int numberOfPlayers; //Field offset: 0x0
		public int bestScore; //Field offset: 0x4

	}

	private readonly ITournamentPlayerManager _tournamentPlayerManager; //Field offset: 0x8
	private readonly int _totalNumberOfPlayers; //Field offset: 0xC
	private readonly Rank[] _ranks; //Field offset: 0x10
	private readonly Participant[] _participants; //Field offset: 0x14
	private string <id>k__BackingField; //Field offset: 0x18
	private int <sequenceId>k__BackingField; //Field offset: 0x1C
	private bool <hasResult>k__BackingField; //Field offset: 0x20
	private string <country>k__BackingField; //Field offset: 0x24
	private DateTime <startTimeUTC>k__BackingField; //Field offset: 0x28
	private DateTime <endTimeUTC>k__BackingField; //Field offset: 0x30
	private DateTime <nextTournamentTimeUTC>k__BackingField; //Field offset: 0x38

	public string country
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public DateTime endTimeUTC
	{
		 get { } //Length: 6
		private set { } //Length: 6
	}

	public bool hasResult
	{
		 get { } //Length: 200
		private set { } //Length: 8
	}

	public string id
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public bool isFinished
	{
		 get { } //Length: 6
	}

	public DateTime nextTournamentTimeUTC
	{
		 get { } //Length: 6
		private set { } //Length: 6
	}

	public DateTime officialEndTimeUTC
	{
		 get { } //Length: 6
	}

	public int rankCount
	{
		 get { } //Length: 6
	}

	public int sequenceId
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public DateTime startTimeUTC
	{
		 get { } //Length: 490
		private set { } //Length: 6
	}

	public Tournament(JsonObject json, TimeSpan clientTimeOffset, string country, ITournamentPlayerManager tournamentPlayerManager) { }

	public int FindParticipantScoreByPublicKey(string publicKey) { }

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

	private void set_country(string value) { }

	private void set_endTimeUTC(DateTime value) { }

	private void set_hasResult(bool value) { }

	private void set_id(string value) { }

	private void set_nextTournamentTimeUTC(DateTime value) { }

	private void set_sequenceId(int value) { }

	private void set_startTimeUTC(DateTime value) { }

}

