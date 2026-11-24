//Type is in global namespace

public class GameStats
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<ActivePowerup> <>9__116_0; //Field offset: 0x4
		public static Comparison<ActivePowerup> <>9__121_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <TriggerPowerup>b__116_0(ActivePowerup a, ActivePowerup b) { }

		internal int <UpdatePowerupTimes>b__121_0(ActivePowerup a, ActivePowerup b) { }

	}

	private sealed class <>c__DisplayClass120_0
	{
		public UpgradeType type; //Field offset: 0x8

		public <>c__DisplayClass120_0() { }

		internal bool <IsPowerupActive>b__0(ActivePowerup p) { }

	}

	private const int SCORE_FOR_PICKUPS = 30; //Field offset: 0x0
	private const float HOVERBOARD_COOLDOWN = 5; //Field offset: 0x0
	private static GameStats instance; //Field offset: 0x0
	private const int AMOUNT_BY_WHICH_EXTRA_SCORE_IS_CONSUMED = 4; //Field offset: 0x0
	public bool BragNotifyDone; //Field offset: 0x8
	public bool BragFacebookDone; //Field offset: 0x9
	private Action OnCoinsChanged; //Field offset: 0xC
	private Action<int> OnCoinsIncreased; //Field offset: 0x10
	private Action OnScoreChanged; //Field offset: 0x14
	private Action OnJumpsChanged; //Field offset: 0x18
	private Action OnRollsChanged; //Field offset: 0x1C
	private Action<UpgradeType> PowerupTriggered; //Field offset: 0x20
	private Action OnMysteryBoxPickup; //Field offset: 0x24
	private Action OnSuperMysteryBoxPickup; //Field offset: 0x28
	private int _coinsSpawned; //Field offset: 0x2C
	private int _coinsSpawnedRun; //Field offset: 0x30
	private int _coinsCollectedRaw; //Field offset: 0x34
	private int _coinsCollectedRawRun; //Field offset: 0x38
	private int _xoredNumberOfCoinsCollected; //Field offset: 0x3C
	private int _xoredNumberOfCoinsRun; //Field offset: 0x40
	private int _coinMultiplier; //Field offset: 0x44
	private int _coinsWithJetpack; //Field offset: 0x48
	private int _coinsWithPogoStick; //Field offset: 0x4C
	private int _coinsInAir; //Field offset: 0x50
	private int _coinCollectedOnLeftTrack; //Field offset: 0x54
	private int _coinsCollectedOnCenterTrack; //Field offset: 0x58
	private int _coinsCollectedOnRightTrack; //Field offset: 0x5C
	private int _coinsWithCoinMagnetCount; //Field offset: 0x60
	private bool _scoreBoosterActivated; //Field offset: 0x64
	private int _scoreBoosterTier; //Field offset: 0x68
	private int _scoreBoosterTierRun; //Field offset: 0x6C
	private bool _characterDayEventActivated; //Field offset: 0x70
	private int _score; //Field offset: 0x74
	private float _metersLastUsedForScore; //Field offset: 0x78
	private float _meterScore; //Field offset: 0x7C
	private int _amountLeftToConsume; //Field offset: 0x80
	private bool _isPausedPowerups; //Field offset: 0x84
	private Dictionary<int, int> _spawnedPickupsLastRun; //Field offset: 0x88
	private Dictionary<int, int> _powerupActivationCountsLastRun; //Field offset: 0x8C
	private Dictionary<int, int> _mysteryPowerupActivationCountsLastRun; //Field offset: 0x90
	private List<ActivePowerup> _listOfActivePowerups; //Field offset: 0x94
	private Dictionary<UpgradeType, bool> _missionEachPowerupPickupStatus; //Field offset: 0x98
	private float _metersInCurrentGame; //Field offset: 0x9C
	private int _stumbles; //Field offset: 0xA0
	private int _stumblesRun; //Field offset: 0xA4
	private int _jumps; //Field offset: 0xA8
	private int _jumpsOverTrainsCount; //Field offset: 0xAC
	private int _rollCount; //Field offset: 0xB0
	private int _rollsLeftTrackCount; //Field offset: 0xB4
	private int _rollsCenterTrackCount; //Field offset: 0xB8
	private int _rollsRightTrackCount; //Field offset: 0xBC
	private int _dodgeBarrierCount; //Field offset: 0xC0
	private int _jumpBarrierCount; //Field offset: 0xC4
	private int _jumpHighBarrierCount; //Field offset: 0xC8
	private int _trainHitCount; //Field offset: 0xCC
	private int _movingTrainHit; //Field offset: 0xD0
	private int _barrierHitCount; //Field offset: 0xD4
	private int _jetpackPickupsCollected; //Field offset: 0xD8
	private int _jetpackPickupsCollectedRun; //Field offset: 0xDC
	private int _superSneakerPickupsCollected; //Field offset: 0xE0
	private int _superSneakerPickupsCollectedRun; //Field offset: 0xE4
	private int _pogoStickPickupsCollected; //Field offset: 0xE8
	private int _pogoStickPickupsCollectedRun; //Field offset: 0xEC
	private int _dailyLetterPickupsCollected; //Field offset: 0xF0
	private int _dailyLetterPickupsCollectedRun; //Field offset: 0xF4
	private int _characterLetterPickupsCollected; //Field offset: 0xF8
	private int _characterLetterPickupsCollectedRun; //Field offset: 0xFC
	private int _coinMagnetPickupsCollected; //Field offset: 0x100
	private int _coinMagnetPickupsCollectedRun; //Field offset: 0x104
	private int _mysteryBoxPickupsCollected; //Field offset: 0x108
	private int _mysteryBoxPickupsCollectedRun; //Field offset: 0x10C
	private int _superMysteryBoxPickupsCollected; //Field offset: 0x110
	private int _superMysteryBoxPickupsCollectedRun; //Field offset: 0x114
	private int _doubleMultiplierPickupsCollected; //Field offset: 0x118
	private int _doubleMultiplierPickupsCollectedRun; //Field offset: 0x11C
	private int _huntTokensCollected; //Field offset: 0x120
	private int _huntTokensCollectedRun; //Field offset: 0x124
	private int _pickedUpPowerups; //Field offset: 0x128
	private int _keyPickupsCollected; //Field offset: 0x12C
	private int _keyPickupsCollectedRun; //Field offset: 0x130

	public event Action OnCoinsChanged
	{
		 add { } //Length: 9
		 remove { } //Length: 111
	}

	public event Action<int> OnCoinsIncreased
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnJumpsChanged
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnMysteryBoxPickup
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnRollsChanged
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnScoreChanged
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnSuperMysteryBoxPickup
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<UpgradeType> PowerupTriggered
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public bool CharacterDayEventActivated
	{
		 get { } //Length: 6
		 set { } //Length: 84
	}

	public int CharacterLetterPickupsCollected
	{
		 get { } //Length: 7
	}

	public int CharacterLetterPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int CoinMagnetPickupsCollected
	{
		 get { } //Length: 7
		private set { } //Length: 197
	}

	public int CoinMagnetPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int CoinMultiplier
	{
		 get { } //Length: 85
	}

	public int CoinsCollected
	{
		 get { } //Length: 6
		private set { } //Length: 111
	}

	public int CoinsCollectedRaw
	{
		 get { } //Length: 6
	}

	public int CoinsCollectedRawRun
	{
		 get { } //Length: 6
	}

	public int CoinsCollectedRun
	{
		 get { } //Length: 82
		private set { } //Length: 155
	}

	public int CoinsSpawned
	{
		 get { } //Length: 80
	}

	public int CoinsSpawnedRun
	{
		 get { } //Length: 6
	}

	public int CoinsWithJetpack
	{
		 get { } //Length: 221
	}

	public int DailyLetterPickupsCollected
	{
		 get { } //Length: 7
	}

	public int DailyLetterPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int DoubleMultiplierPickupsCollected
	{
		 get { } //Length: 7
		private set { } //Length: 197
	}

	public int DoubleMultiplierPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int HuntTokensCollected
	{
		 get { } //Length: 7
	}

	public int HuntTokensCollectedRun
	{
		 get { } //Length: 7
	}

	public static GameStats Instance
	{
		 get { } //Length: 894
	}

	public bool IsPausedPowerups
	{
		 get { } //Length: 9
		 set { } //Length: 87
	}

	public int JetpackPickupsCollected
	{
		 get { } //Length: 7
		private set { } //Length: 50
	}

	public int JetpackPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int JumpHighBarrierCount
	{
		 get { } //Length: 7
	}

	public int JumpsOverTrainsCount
	{
		 get { } //Length: 7
	}

	public int KeyPickupsCollected
	{
		 get { } //Length: 7
	}

	public int KeyPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public float MetersInCurrentGame
	{
		 get { } //Length: 12
		 set { } //Length: 1209
	}

	public Dictionary<UpgradeType, bool> MissionEachPowerupPickupStatus
	{
		 get { } //Length: 6
	}

	public int MovingTrainHitCount
	{
		 get { } //Length: 7
		 set { } //Length: 28
	}

	public int MysteryBoxPickupsCollected
	{
		 get { } //Length: 7
	}

	public int MysteryBoxPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int PogoStickPickupsCollected
	{
		 get { } //Length: 7
		private set { } //Length: 197
	}

	public int PogoStickPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int RollCount
	{
		 get { } //Length: 7
		private set { } //Length: 191
	}

	public int Score
	{
		 get { } //Length: 10
	}

	public bool ScoreBoosterActivated
	{
		 get { } //Length: 6
		 set { } //Length: 87
	}

	public int ScoreBoosterTier
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public int ScoreBoosterTierRun
	{
		 get { } //Length: 6
	}

	public int Stumbles
	{
		 get { } //Length: 7
	}

	public int StumblesRun
	{
		 get { } //Length: 7
	}

	public int SuperMysteryBoxPickupsCollected
	{
		 get { } //Length: 7
	}

	public int SuperMysteryBoxPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	public int SuperSneakerPickupsCollected
	{
		 get { } //Length: 7
		private set { } //Length: 197
	}

	public int SuperSneakerPickupsCollectedRun
	{
		 get { } //Length: 7
	}

	private GameStats() { }

	public void add_OnCoinsChanged(Action value) { }

	public void add_OnCoinsIncreased(Action<int> value) { }

	public void add_OnJumpsChanged(Action value) { }

	public void add_OnMysteryBoxPickup(Action value) { }

	public void add_OnRollsChanged(Action value) { }

	public void add_OnScoreChanged(Action value) { }

	public void add_OnSuperMysteryBoxPickup(Action value) { }

	public void add_PowerupTriggered(Action<UpgradeType> value) { }

	private void AddScoreForPickup(bool wasPowerup) { }

	public void AddScoreForPickup(UpgradeType type) { }

	public void BarrierHitCountIncrement() { }

	public void CalculateScore() { }

	public void CharacterLetterPickupsCollectedIncrement() { }

	public void ClearPowerups() { }

	public void CoinMagnetCountIncrement() { }

	public void CoinMagnetPickupsCollectedIncrement() { }

	public void CoinsCollectedIncrement(int count) { }

	public void CoinsCollectedOnCenterTrackIncrement() { }

	public void CoinsCollectedOnLeftTrackIncrement() { }

	public void CoinsCollectedOnRightTrackIncrement() { }

	public void CoinsCollectedRawIncrement() { }

	public void CoinsInAirIncrement() { }

	public void CoinsSpawnedIncrement() { }

	public void CoinsWithJetpackIncrement() { }

	public void CoinsWithPogoStickIncrement() { }

	public static int CoinToScoreConversion(int coins) { }

	private int ConsumeAmountNeededToAdjustScoreBy(int amount) { }

	public void DailyLetterPickupsCollectedIncrement() { }

	public void DodgeBarrierCountIncrement() { }

	public void DoubleMultiplierPickupsCollectedIncrement() { }

	public bool get_CharacterDayEventActivated() { }

	public int get_CharacterLetterPickupsCollected() { }

	public int get_CharacterLetterPickupsCollectedRun() { }

	public int get_CoinMagnetPickupsCollected() { }

	public int get_CoinMagnetPickupsCollectedRun() { }

	public int get_CoinMultiplier() { }

	public int get_CoinsCollected() { }

	public int get_CoinsCollectedRaw() { }

	public int get_CoinsCollectedRawRun() { }

	public int get_CoinsCollectedRun() { }

	public int get_CoinsSpawned() { }

	public int get_CoinsSpawnedRun() { }

	public int get_CoinsWithJetpack() { }

	public int get_DailyLetterPickupsCollected() { }

	public int get_DailyLetterPickupsCollectedRun() { }

	public int get_DoubleMultiplierPickupsCollected() { }

	public int get_DoubleMultiplierPickupsCollectedRun() { }

	public int get_HuntTokensCollected() { }

	public int get_HuntTokensCollectedRun() { }

	public static GameStats get_Instance() { }

	public bool get_IsPausedPowerups() { }

	public int get_JetpackPickupsCollected() { }

	public int get_JetpackPickupsCollectedRun() { }

	public int get_JumpHighBarrierCount() { }

	public int get_JumpsOverTrainsCount() { }

	public int get_KeyPickupsCollected() { }

	public int get_KeyPickupsCollectedRun() { }

	public float get_MetersInCurrentGame() { }

	public Dictionary<UpgradeType, bool> get_MissionEachPowerupPickupStatus() { }

	public int get_MovingTrainHitCount() { }

	public int get_MysteryBoxPickupsCollected() { }

	public int get_MysteryBoxPickupsCollectedRun() { }

	public int get_PogoStickPickupsCollected() { }

	public int get_PogoStickPickupsCollectedRun() { }

	public int get_RollCount() { }

	public int get_Score() { }

	public bool get_ScoreBoosterActivated() { }

	public int get_ScoreBoosterTier() { }

	public int get_ScoreBoosterTierRun() { }

	public int get_Stumbles() { }

	public int get_StumblesRun() { }

	public int get_SuperMysteryBoxPickupsCollected() { }

	public int get_SuperMysteryBoxPickupsCollectedRun() { }

	public int get_SuperSneakerPickupsCollected() { }

	public int get_SuperSneakerPickupsCollectedRun() { }

	public List<ActivePowerup> GetActivePowerups() { }

	public int GetMysteryPowerupActivationCountLastRun(UpgradeType upgrade) { }

	public int GetPickupCountSpawnedLastRun(PickupType pickup) { }

	public int GetPowerupActivationCountLastRun(UpgradeType upgrade) { }

	public void HuntTokensCollectedIncrement() { }

	public void IncreaseAmountNeededToAdjustScoreBy(int amount) { }

	public bool IsPowerupActive(UpgradeType type) { }

	public void JetpackPickupsCollectedIncrement() { }

	public void JumpBarrierCountIncrement() { }

	public void JumpCountIncrement() { }

	public void JumpHighBarrierCountIncrement() { }

	public void JumpsOverTrainsCountIncrement() { }

	public void KeyPickupsCollectedIncrement() { }

	public void MysteryBoxPickupsCollectedInrement() { }

	public void PickedUpPowerupsIncrement() { }

	private void PickupManager_OnPickupSpawned(object sender, PickupEventArgs args) { }

	public void PogoStickPickupsCollectedIncrement() { }

	public void remove_OnCoinsChanged(Action value) { }

	public void remove_OnCoinsIncreased(Action<int> value) { }

	public void remove_OnJumpsChanged(Action value) { }

	public void remove_OnMysteryBoxPickup(Action value) { }

	public void remove_OnRollsChanged(Action value) { }

	public void remove_OnScoreChanged(Action value) { }

	public void remove_OnSuperMysteryBoxPickup(Action value) { }

	public void remove_PowerupTriggered(Action<UpgradeType> value) { }

	public void RemoveHoverBoardPowerup() { }

	private void ReportOneOfEachPowerupIfApplicable(UpgradeType upgradeType) { }

	public void ResetAmountNeededToAdjustScoreBy() { }

	public void ResetGame() { }

	public void ResetRun() { }

	private void ResetScore() { }

	public void RollCountIncrement() { }

	public void RollsCenterTrackCountIncrement() { }

	public void RollsLeftTrackCountIncrement() { }

	public void RollsRightTrackCountIncrement() { }

	public void RunCompleted() { }

	public void ScoreBoosterTierIncrement() { }

	public void set_CharacterDayEventActivated(bool value) { }

	private void set_CoinMagnetPickupsCollected(int value) { }

	private void set_CoinsCollected(int value) { }

	private void set_CoinsCollectedRun(int value) { }

	private void set_DoubleMultiplierPickupsCollected(int value) { }

	public void set_IsPausedPowerups(bool value) { }

	private void set_JetpackPickupsCollected(int value) { }

	public void set_MetersInCurrentGame(float value) { }

	public void set_MovingTrainHitCount(int value) { }

	private void set_PogoStickPickupsCollected(int value) { }

	private void set_RollCount(int value) { }

	public void set_ScoreBoosterActivated(bool value) { }

	private void set_ScoreBoosterTier(int value) { }

	private void set_SuperSneakerPickupsCollected(int value) { }

	public void StumbleCountIncrement() { }

	public void SuperMysteryBoxPickupsCollectedIncrement() { }

	public void SuperSneakerPickupsCollectedIncrement() { }

	public void TrainHitCountIncrement() { }

	public ActivePowerup TriggerPowerup(UpgradeType type, bool triggeredViaMysteryPowerup = false) { }

	public void UpdatePowerupTimes(float deltaTime) { }

}

