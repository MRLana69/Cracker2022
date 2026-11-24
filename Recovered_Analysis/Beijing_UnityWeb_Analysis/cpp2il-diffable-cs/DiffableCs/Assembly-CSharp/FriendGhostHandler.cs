//Type is in global namespace

public class FriendGhostHandler : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Challenger> <>9__31_0; //Field offset: 0x4
		public static Comparison<Challenger> <>9__32_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetCombinedAndSortedChallengers>b__31_0(Challenger x, Challenger y) { }

		internal int <GetSortedFriends>b__32_0(Challenger x, Challenger y) { }

	}

	private IManager _tournamentManager; //Field offset: 0xC
	public CharacterAvatars dummies; //Field offset: 0x10
	public FriendGhostHelper helper; //Field offset: 0x14
	public Texture dummyImage; //Field offset: 0x18
	private Challenger[] challengersDescending; //Field offset: 0x1C
	private Challenger currentChallenger; //Field offset: 0x20
	private List<IPlayer> topRunPlayers; //Field offset: 0x24
	private bool _localUserHighscoreInserted; //Field offset: 0x28
	private bool _localUserTopRunInserted; //Field offset: 0x29
	private bool _insertedAnyUser; //Field offset: 0x2A
	private bool _passedLocalHighScore; //Field offset: 0x2B
	private bool _passedLocalTopRunScore; //Field offset: 0x2C
	private bool _gameRunning; //Field offset: 0x2D
	private int _currentThreshold; //Field offset: 0x30
	private int _currentChallengerIndex; //Field offset: 0x34
	private int _localHighestScore; //Field offset: 0x38
	private int _localTopRunScore; //Field offset: 0x3C
	private int _numberOfCharactersInScore; //Field offset: 0x40
	private Color localPlayerColor; //Field offset: 0x44
	private Color friendColor; //Field offset: 0x54
	private Color topRunHighscoreTitleColor; //Field offset: 0x64
	private Color normalHighScoreTitleColor; //Field offset: 0x74

	public FriendGhostHandler() { }

	private bool <GetTopRunPlayers>b__30_0(Challenger element) { }

	private void Awake() { }

	private int CalculateGapToFriendsScore(int scoreTo, int currentScore) { }

	public void FinishedAnimatingOut() { }

	private Challenger[] GetCombinedAndSortedChallengers(Challenger[] friends, Challenger[] topRuns) { }

	private int GetDummyPlayerScore() { }

	private Challenger[] GetFriends() { }

	private int getNextChallengerWithHigherScoreIndex(Challenger[] sortedChallengerList, int thisPlayerScore) { }

	private Challenger[] GetSortedFriends() { }

	private Challenger[] GetTopRunPlayers() { }

	private void Init() { }

	private bool InsertChallenger() { }

	private bool InsertLocalUserHighScore() { }

	private bool InsertLocalUserTopRun() { }

	private bool IsTopRunTournamentRunning() { }

	public void NewGame() { }

	private void OnDestroy() { }

	private void PassThreshold() { }

	private void RefreshListOnSettingsChanged(bool settingValue) { }

	private void ScaleHelperBackground() { }

	public void SetNewChallenger() { }

	private void Update() { }

}

