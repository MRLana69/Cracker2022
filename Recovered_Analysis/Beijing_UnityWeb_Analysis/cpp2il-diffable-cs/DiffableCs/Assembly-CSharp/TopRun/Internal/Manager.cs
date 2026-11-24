namespace TopRun.Internal;

internal class Manager : IManager, ITournamentPlayerManager
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ParticipantSelector <>9__91_0; //Field offset: 0x4
		public static ParticipantSetter <>9__91_1; //Field offset: 0x8
		public static TimestampSetter <>9__91_2; //Field offset: 0xC
		public static ParticipantSelector <>9__93_0; //Field offset: 0x10
		public static ParticipantSetter <>9__93_1; //Field offset: 0x14
		public static TimestampSetter <>9__93_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IList <RequestFindMatchedPlayers>b__91_0(TournamentData tour) { }

		internal void <RequestFindMatchedPlayers>b__91_1(TournamentData tour, IList list) { }

		internal void <RequestFindMatchedPlayers>b__91_2(TournamentData tour, Nullable<DateTime> timestamp) { }

		internal IList <RequestFindMatchedPlayersByCurrentScore>b__93_0(TournamentData tour) { }

		internal void <RequestFindMatchedPlayersByCurrentScore>b__93_1(TournamentData tour, IList list) { }

		internal void <RequestFindMatchedPlayersByCurrentScore>b__93_2(TournamentData tour, Nullable<DateTime> timestamp) { }

	}

	private sealed class <>c__DisplayClass104_0
	{
		public Manager <>4__this; //Field offset: 0x8
		public string currentTournamentId; //Field offset: 0xC
		public IList<string> keysToGetRanksFor; //Field offset: 0x10

		public <>c__DisplayClass104_0() { }

		internal void <RequestRanksForPlayers>b__0(IRequest request, bool isFromCache) { }

	}

	private sealed class <>c__DisplayClass109_0
	{
		public FacebookLoginResult facebookLoginResult; //Field offset: 0x8

		public <>c__DisplayClass109_0() { }

		internal void <LoginOrRegisterFacebook>b__0(FacebookLoginResult result) { }

	}

	private sealed class <>c__DisplayClass110_0
	{
		public FacebookLoginResult facebookLoginResult; //Field offset: 0x8

		public <>c__DisplayClass110_0() { }

		internal void <LoginOrCreatePlayer>b__0(FacebookLoginResult result) { }

	}

	private sealed class <>c__DisplayClass112_0
	{
		public Manager <>4__this; //Field offset: 0x8
		public string facebookId; //Field offset: 0xC
		public Action<FacebookLoginResult> onComplete; //Field offset: 0x10

		public <>c__DisplayClass112_0() { }

		internal void <RequestFacebookLogin>b__0(IRequest request, bool isFromCache) { }

	}

	private sealed class <>c__DisplayClass113_0
	{
		public Manager <>4__this; //Field offset: 0x8
		public string facebookId; //Field offset: 0xC

		public <>c__DisplayClass113_0() { }

		internal void <RequestCreatePlayer>b__0(IRequest request, bool isFromCache) { }

	}

	private sealed class <>c__DisplayClass114_0
	{
		public Manager <>4__this; //Field offset: 0x8
		public string facebookId; //Field offset: 0xC

		public <>c__DisplayClass114_0() { }

		internal void <RequestFacebookRegister>b__0(IRequest request, bool isFromCache) { }

	}

	private sealed class <>c__DisplayClass77_0
	{
		public string publicKey; //Field offset: 0x8

		public <>c__DisplayClass77_0() { }

		internal bool <FindFacebookIdFromPublicKey>b__0(KeyValuePair<string, PlayerIdData> x) { }

	}

	private sealed class <>c__DisplayClass81_0
	{
		public bool mustFetchNewTournament; //Field offset: 0x8

		public <>c__DisplayClass81_0() { }

		internal void <InProcessRefreshTournamentCoroutine>b__0(bool isTournamentNotFound) { }

	}

	private sealed class <>c__DisplayClass83_0
	{
		public Manager <>4__this; //Field offset: 0x8
		public string newTournamentCountry; //Field offset: 0xC

		public <>c__DisplayClass83_0() { }

		internal void <InProcessFetchNextTournament>b__0(IRequest request, bool isFromCache) { }

	}

	private sealed class <>c__DisplayClass95_0
	{
		public FacebookProfile profile; //Field offset: 0x8
		public Player player; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10

		public <>c__DisplayClass95_0() { }

		internal void <GetMissingFacebookInfoCoroutine>b__0(Texture2D image) { }

	}

	private sealed class <>c__DisplayClass97_0
	{
		public Action<Texture2D> onComplete; //Field offset: 0x8

		public <>c__DisplayClass97_0() { }

		internal void <DownloadFacebookImage>b__0(IRequest request, bool cache) { }

	}

	private sealed class <GetMissingFacebookInfoCoroutine>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private <>c__DisplayClass95_0 <>8__1; //Field offset: 0x14
		private Enumerator<Player> <>7__wrap1; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1252
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetMissingFacebookInfoCoroutine>d__95(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <InProcessRefreshTournamentCoroutine>d__81 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private <>c__DisplayClass81_0 <>8__1; //Field offset: 0x14
		private SocialManager <socialManager>5__2; //Field offset: 0x18
		private bool <isNewTournament>5__3; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1025
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <InProcessRefreshTournamentCoroutine>d__81(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoginOrCreatePlayer>d__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private <>c__DisplayClass110_0 <>8__1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 305
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoginOrCreatePlayer>d__110(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LoginOrRegisterFacebook>d__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private <>c__DisplayClass109_0 <>8__1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 277
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoginOrRegisterFacebook>d__109(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RefreshKeysIfNecessary>d__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 247
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RefreshKeysIfNecessary>d__108(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RefreshTournamentCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 178
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RefreshTournamentCoroutine>d__80(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestCreatePlayer>d__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 645
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestCreatePlayer>d__113(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestFacebookLogin>d__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		public Action<FacebookLoginResult> onComplete; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 655
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestFacebookLogin>d__112(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestFacebookRegister>d__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 704
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestFacebookRegister>d__114(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestFindMatchedPlayers>d__91 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private IRequest <request>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1927
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestFindMatchedPlayers>d__91(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestFindMatchedPlayersByCurrentScore>d__93 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private IRequest <request>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1261
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestFindMatchedPlayersByCurrentScore>d__93(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestNextTournamentFetchTime>d__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private IRequest <request>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 1355
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestNextTournamentFetchTime>d__102(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestPlayersByFacebookIds>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		private IRequest <request>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 3106
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestPlayersByFacebookIds>d__86(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestRanksForPlayers>d__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 743
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestRanksForPlayers>d__104(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestSubmitScoreCoroutine>d__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		public bool previouslySavedScore; //Field offset: 0x14
		public int scoreToSubmit; //Field offset: 0x18
		public bool isRetry; //Field offset: 0x1C
		private TournamentData <tour>5__2; //Field offset: 0x20
		private bool <scoreWasUpdated>5__3; //Field offset: 0x24
		private int <unsubmittedScore>5__4; //Field offset: 0x28
		private string <tournamentId>5__5; //Field offset: 0x2C
		private string <tournamentCountry>5__6; //Field offset: 0x30
		private DateTime <tournamentStart>5__7; //Field offset: 0x38
		private DateTime <tournamentEnd>5__8; //Field offset: 0x40
		private IRequest <request>5__9; //Field offset: 0x48

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 2381
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestSubmitScoreCoroutine>d__105(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RequestTournamentData>d__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Manager <>4__this; //Field offset: 0x10
		public Action<bool> onComplete; //Field offset: 0x14
		private IRequest <request>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 3366
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RequestTournamentData>d__101(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum FacebookLoginResult
	{
		Success = 0,
		Failed = 1,
		NotFound = 2,
	}

	private delegate ParticipantSelector
	{

		public ParticipantSelector(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(TournamentData tour, AsyncCallback callback, object object) { }

		public virtual IList EndInvoke(IAsyncResult result) { }

		public virtual IList Invoke(TournamentData tour) { }

	}

	private delegate ParticipantSetter
	{

		public ParticipantSetter(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(TournamentData tour, IList list, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(TournamentData tour, IList list) { }

	}

	private delegate TimestampSetter
	{

		public TimestampSetter(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(TournamentData tour, Nullable<DateTime> timestamp, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(TournamentData tour, Nullable<DateTime> timestamp) { }

	}

	private Dictionary<string, Player> _currentTournamentPlayers; //Field offset: 0x8
	private Rank[] _currentTournamentRanks; //Field offset: 0xC
	private bool _fetchingNewTournament; //Field offset: 0x10
	private bool _isRefreshingTournament; //Field offset: 0x11
	private bool _isRefreshPending; //Field offset: 0x12
	private long _lastFriendsUpdate; //Field offset: 0x18
	private long _lastTournamentUpdate; //Field offset: 0x20
	private IList<string> _lastTournamentUpdateParticipantsPublicKeys; //Field offset: 0x28
	private bool _pauseRefreshing; //Field offset: 0x2C
	private EventHandler<TournamentChangedEventArgs> tournamentChanged; //Field offset: 0x30
	private EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged; //Field offset: 0x34
	private IRank <rank>k__BackingField; //Field offset: 0x38
	private ITournament <tournament>k__BackingField; //Field offset: 0x3C

	public event EventHandler<PlayerInfoChangedEventArgs> playerInfoChanged
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event EventHandler<TournamentChangedEventArgs> tournamentChanged
	{
		 add { } //Length: 114
		 remove { } //Length: 111
	}

	public bool canSubmitScore
	{
		 get { } //Length: 7
	}

	public string country
	{
		 get { } //Length: 7
		 set { } //Length: 111
	}

	private int facebookFriendPublicKeyExpirySecondsMax
	{
		 get { } //Length: 95
	}

	private int facebookFriendPublicKeyExpirySecondsMin
	{
		 get { } //Length: 6
	}

	public bool hasFetchedTournament
	{
		 get { } //Length: 9
	}

	public int highScore
	{
		 get { } //Length: 77
	}

	public bool isRefreshing
	{
		 get { } //Length: 394
	}

	private ManagerData managerData
	{
		 get { } //Length: 153
	}

	private int maxFriendPublicKeyRequestsToSend
	{
		 get { } //Length: 95
	}

	public int multiplier
	{
		 get { } //Length: 56
	}

	public DateTime nextTournamentFetchTime
	{
		 get { } //Length: 63
	}

	public bool pauseRefreshing
	{
		 get { } //Length: 20
		 set { } //Length: 50
	}

	private PlayerIdsData playerIdData
	{
		 get { } //Length: 7
	}

	public IRank rank
	{
		 get { } //Length: 58
		private set { } //Length: 11
	}

	private RanksData rankData
	{
		 get { } //Length: 7
		 set { } //Length: 389
	}

	private float requestMaxBackOffTime
	{
		 get { } //Length: 101
	}

	private float requestMinBackOffTime
	{
		 get { } //Length: 101
	}

	private float requestTimeout
	{
		 get { } //Length: 20
	}

	public int score
	{
		 get { } //Length: 40
	}

	public ITournament tournament
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public Manager() { }

	public void add_playerInfoChanged(EventHandler<PlayerInfoChangedEventArgs> value) { }

	public void add_tournamentChanged(EventHandler<TournamentChangedEventArgs> value) { }

	private void AddCurrentTournamentParticipantsToCurrentTournamentPlayers() { }

	private void AddFacebookFriendsWithIdsToCurrentTournamentPlayers() { }

	private void AppHasRefreshed(RefreshType refreshType) { }

	private void ClearKeys() { }

	internal static void ClearSavedData() { }

	private void CompleteRefreshProcess(bool isNewTournament) { }

	private Coroutine DownloadFacebookImage(string facebookId, Action<Texture2D> onComplete) { }

	public void FetchNextTournament() { }

	private string FindFacebookIdFromPublicKey(string publicKey) { }

	private void FirePlayerInfoChangedEvent(IPlayer player) { }

	private void FireTournamentChangedEvent(bool wasUpdated, bool didChange) { }

	public bool get_canSubmitScore() { }

	public string get_country() { }

	private int get_facebookFriendPublicKeyExpirySecondsMax() { }

	private int get_facebookFriendPublicKeyExpirySecondsMin() { }

	public bool get_hasFetchedTournament() { }

	public int get_highScore() { }

	public bool get_isRefreshing() { }

	private ManagerData get_managerData() { }

	private int get_maxFriendPublicKeyRequestsToSend() { }

	public int get_multiplier() { }

	public DateTime get_nextTournamentFetchTime() { }

	public bool get_pauseRefreshing() { }

	private PlayerIdsData get_playerIdData() { }

	public IRank get_rank() { }

	private RanksData get_rankData() { }

	private float get_requestMaxBackOffTime() { }

	private float get_requestMinBackOffTime() { }

	private float get_requestTimeout() { }

	public int get_score() { }

	public ITournament get_tournament() { }

	private int GetAmountOfChallengersToRequest() { }

	private static TimeSpan GetClientTimeOffset(IRequest request) { }

	private IList<FacebookProfile> GetFacebookFriendsToRequestPublicKeysFor() { }

	private IList<Player> GetFacebookFriendsWithPublicKeysAsPlayers() { }

	private string GetFacebookIdFromSocialManager() { }

	private void GetMissingFacebookInfo() { }

	private IEnumerator GetMissingFacebookInfoCoroutine() { }

	private string GetNameFromSocialManager() { }

	public IPlayer GetPlayerByPublicKey(string publicKey) { }

	public IRank GetPlayerRank(string facebookId) { }

	private IList<string> GetPublicKeysForPlayersWeHaveNotRequestedRanksFor() { }

	private DateTime GetRandomisedPlayerIdExpiry() { }

	private List<Player> GetTournamentPlayersWithMissingFacebookInfo() { }

	private bool HandleFindMatchedPlayersResponse(IRequest request, ParticipantSelector participantSelector, ParticipantSetter participantSetter, TimestampSetter timestampSetter) { }

	private void InitializeCurrentTournamentPlayers() { }

	private void InProcessFetchNextTournament() { }

	private IEnumerator InProcessRefreshTournamentCoroutine() { }

	private bool IsFacebookIDInvalid(string facebookId) { }

	public static void Log(object msg) { }

	public static void LogError(object msg) { }

	private IEnumerator LoginOrCreatePlayer() { }

	private IEnumerator LoginOrRegisterFacebook() { }

	public static void LogWarning(object msg) { }

	private string MakeApiURL(string apiResource) { }

	private int PropagateUnsubmittedScore() { }

	private void PurgeSelfFromParticipants() { }

	private void PurgeUnneededIds() { }

	public static string QuoteString(string s) { }

	private IEnumerator RefreshKeysIfNecessary() { }

	public void RefreshTournament() { }

	private IEnumerator RefreshTournamentCoroutine() { }

	public void remove_playerInfoChanged(EventHandler<PlayerInfoChangedEventArgs> value) { }

	public void remove_tournamentChanged(EventHandler<TournamentChangedEventArgs> value) { }

	private IEnumerator RequestCreatePlayer() { }

	private IEnumerator RequestFacebookLogin(Action<FacebookLoginResult> onComplete) { }

	private IEnumerator RequestFacebookRegister() { }

	private IEnumerator RequestFindMatchedPlayers() { }

	private IEnumerator RequestFindMatchedPlayersByCurrentScore() { }

	private IEnumerator RequestNextTournamentFetchTime() { }

	private IEnumerator RequestPlayersByFacebookIds() { }

	private IEnumerator RequestRanksForPlayers() { }

	private IEnumerator RequestSubmitScoreCoroutine(int scoreToSubmit, bool isRetry, bool previouslySavedScore) { }

	private IEnumerator RequestTournamentData(Action<bool> onComplete) { }

	public void set_country(string value) { }

	public void set_pauseRefreshing(bool value) { }

	private void set_rank(IRank value) { }

	private void set_rankData(RanksData value) { }

	private void set_tournament(ITournament value) { }

	public void SubmitScore(int scoreToSubmit, DateTime gameStartedTime) { }

}

