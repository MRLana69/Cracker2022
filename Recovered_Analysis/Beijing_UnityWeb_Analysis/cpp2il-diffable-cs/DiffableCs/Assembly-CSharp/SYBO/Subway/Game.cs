namespace SYBO.Subway;

public class Game : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<RefreshType> <>9__154_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__154_0(RefreshType type) { }

	}

	private sealed class <>c__DisplayClass171_0
	{
		public Game <>4__this; //Field offset: 0x8
		public float fov_start; //Field offset: 0xC
		public float fov_end; //Field offset: 0x10

		public <>c__DisplayClass171_0() { }

		internal void <ActivateHighSpeed>b__0(float t) { }

	}

	private sealed class <>c__DisplayClass172_0
	{
		public Game <>4__this; //Field offset: 0x8
		public float fov_start; //Field offset: 0xC
		public float fov_end; //Field offset: 0x10

		public <>c__DisplayClass172_0() { }

		internal void <DeactivateHighSpeed>b__0(float t) { }

	}

	private sealed class <DebugRepeatedlySwipeLeftRightCoroutine>d__196 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 277
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <DebugRepeatedlySwipeLeftRightCoroutine>d__196(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <EnableCharacterDayEventAnimation>d__195 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 122
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <EnableCharacterDayEventAnimation>d__195(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <SkipRevive>d__191 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Game <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 240
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SkipRevive>d__191(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StumbleDeathSequence>d__203 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Game <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 290
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StumbleDeathSequence>d__203(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum SpeedBoostType
	{
		Normal = 0,
		High = 1,
	}

	public class SpeedInfo
	{
		public float min; //Field offset: 0x8
		public float max; //Field offset: 0xC
		public float rampUpDuration; //Field offset: 0x10

		public SpeedInfo() { }

	}

	public class SwipeInfo
	{
		public float distanceMin; //Field offset: 0x8
		public float doubleTapDuration; //Field offset: 0xC

		public SwipeInfo() { }

	}

	public const float Z_OFFSET_BACKGROUND_TO_CHARACTER_CAMERA = 900; //Field offset: 0x0
	private static CharacterController _characterController; //Field offset: 0x0
	public const float DISTANCE_PER_METER = 8; //Field offset: 0x0
	public static float GAME_DEFAULT_GAME_SPEED; //Field offset: 0x4
	public static bool HasLoaded; //Field offset: 0x8
	private static Action OnGameAwake; //Field offset: 0xC
	private static Action OnGameStarted; //Field offset: 0x10
	private static Action<bool, bool, bool, bool> OnRunStarted; //Field offset: 0x14
	private static Action OnGameRevived; //Field offset: 0x18
	private static Action<bool> OnPlayerDied; //Field offset: 0x1C
	private static Action<bool> OnRunEnded; //Field offset: 0x20
	private static Action OnGameReviveOffer; //Field offset: 0x24
	private static Action OnGameEnded; //Field offset: 0x28
	private static Action OnMenuScreenShown; //Field offset: 0x2C
	private static Action OnGameDestroyed; //Field offset: 0x30
	private static Game instance; //Field offset: 0x34
	private Action<int> OnTurboHeadstartInput; //Field offset: 0xC
	private Action OnEndStumbleDeathSequence; //Field offset: 0x10
	private Action<bool> OnPauseChange; //Field offset: 0x14
	private Action OnStageMenuSequence; //Field offset: 0x18
	private Action OnIntroRun; //Field offset: 0x1C
	private Action OnCharacterModelRecreated; //Field offset: 0x20
	private float highSpeedFOVIncrease; //Field offset: 0x24
	private SpeedInfo hotrodSpeedInfo; //Field offset: 0x28
	private GameObject characterModelPreviewFactoryPrefab; //Field offset: 0x2C
	private GameObject hoverboardFactoryPrefab; //Field offset: 0x30
	private SpeedInfo highSpeedInfo; //Field offset: 0x34
	private float _speedChangeTransitionTime; //Field offset: 0x38
	private float speedFOVIncrease; //Field offset: 0x3C
	public bool isDead; //Field offset: 0x40
	public bool ingameTouchDetection; //Field offset: 0x41
	public bool canRevive; //Field offset: 0x42
	private bool <IsRunningOnTutorialTrack>k__BackingField; //Field offset: 0x43
	private float __currentSpeed; //Field offset: 0x44
	private float __currentLevelSpeed; //Field offset: 0x48
	private bool _isLockedGameSpeed; //Field offset: 0x4C
	public float SpeedAtLastObstacleHit; //Field offset: 0x50
	public SwipeInfo swipe; //Field offset: 0x54
	public SpeedInfo speed; //Field offset: 0x58
	private float _elapsedGameDuration; //Field offset: 0x5C
	public Variable<bool> IsInGame; //Field offset: 0x60
	public Variable<bool> IsInTopMenu; //Field offset: 0x64
	public AudioClipInfo DieSound; //Field offset: 0x68
	public bool awakeDone; //Field offset: 0x6C
	private bool <isReadyForSlideinPowerups>k__BackingField; //Field offset: 0x6D
	public DateTime gameStartTime; //Field offset: 0x70
	public string startCharacterName; //Field offset: 0x78
	public int startCharacterTheme; //Field offset: 0x7C
	public int pogoLevel; //Field offset: 0x80
	public int pogoJumpsLeft; //Field offset: 0x84
	private Character _character; //Field offset: 0x88
	private CharacterModifierCollection _modifiers; //Field offset: 0x8C
	private SpeedInfo _selectedBoardSpeedInfo; //Field offset: 0x90
	private SpeedInfo _currentSpeedInfo; //Field offset: 0x94
	private SpeedInfo _originalSpeed; //Field offset: 0x98
	private IEnumerator _stumbleDeathSequenceRoutine; //Field offset: 0x9C
	private Swipe _currentSwipe; //Field offset: 0xA0
	private CharacterRendering _characterRendering; //Field offset: 0xA4
	private CharacterCamera _characterCamera; //Field offset: 0xA8
	private FollowingGuard _followingGuard; //Field offset: 0xAC
	private GameObject[] _menuFactories; //Field offset: 0xB0
	private GameStats _gameStats; //Field offset: 0xB4
	private float _elapsedRunDuration; //Field offset: 0xB8
	private float _offsetGameStartTime; //Field offset: 0xBC
	private List<Action<float>> _speedChangeHandlers; //Field offset: 0xC0
	private bool _isPaused; //Field offset: 0xC4
	private PickupManagerController _pickupManagerController; //Field offset: 0xC8
	private SyboRandom _randomGenerator; //Field offset: 0xCC
	private bool _isPausedPowerups; //Field offset: 0xD0
	private IEnumerator _debugRepeatedlySwipeLeftRightCoroutine; //Field offset: 0xD4
	private bool _isInStumbleDeathSequence; //Field offset: 0xD8

	public event Action OnCharacterModelRecreated
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action OnEndStumbleDeathSequence
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static event Action OnGameAwake
	{
		 add { } //Length: 8
		 remove { } //Length: 209
	}

	public static event Action OnGameDestroyed
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnGameEnded
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnGameRevived
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnGameReviveOffer
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action OnGameStarted
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public event Action OnIntroRun
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static event Action OnMenuScreenShown
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public event Action<bool> OnPauseChange
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static event Action<bool> OnPlayerDied
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<bool> OnRunEnded
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public static event Action<bool, bool, bool, bool> OnRunStarted
	{
		 add { } //Length: 209
		 remove { } //Length: 209
	}

	public event Action OnStageMenuSequence
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event Action<int> OnTurboHeadstartInput
	{
		 add { } //Length: 11
		 remove { } //Length: 111
	}

	public Character Character
	{
		 get { } //Length: 9
	}

	public static CharacterController Charactercontroller
	{
		 get { } //Length: 71
	}

	public float CurrentLevelSpeed
	{
		 get { } //Length: 6
	}

	public float CurrentSpeed
	{
		 get { } //Length: 6
	}

	public float CurrentSpeedNormalized
	{
		 get { } //Length: 6
	}

	public float ElapsedGameDuration
	{
		 get { } //Length: 6
	}

	public float ElapsedRunDuration
	{
		 get { } //Length: 15
	}

	public bool HasSuperSneakers
	{
		 get { } //Length: 89
	}

	public float HighSpeedFOVIncrease
	{
		 get { } //Length: 13
	}

	public static Game Instance
	{
		 get { } //Length: 306
	}

	public bool IsInJetpackMode
	{
		 get { } //Length: 7
	}

	public bool IsInPogostickMode
	{
		 get { } //Length: 89
	}

	public static bool IsInstantiated
	{
		 get { } //Length: 212
	}

	public bool isInStumbleDeathSequence
	{
		 get { } //Length: 56
	}

	public bool IsLockedGameSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool IsPaused
	{
		 get { } //Length: 7
	}

	public bool IsPausedPowerups
	{
		 get { } //Length: 10
		 set { } //Length: 11
	}

	public bool isReadyForSlideinPowerups
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool IsRunningOnTutorialTrack
	{
		 get { } //Length: 86
		 set { } //Length: 111
	}

	public CharacterModifierCollection Modifiers
	{
		 get { } //Length: 7
	}

	public float OffsetGameStartTime
	{
		 get { } //Length: 7
	}

	public SyboRandom RandomGenerator
	{
		 get { } //Length: 16
	}

	public float SpeedFOVIncrease
	{
		 get { } //Length: 6
	}

	private static Game() { }

	public Game() { }

	private void <Awake>b__154_1(bool value) { }

	public void ActivateHighSpeed(SpeedBoostType speedBoostType) { }

	public void add_OnCharacterModelRecreated(Action value) { }

	public void add_OnEndStumbleDeathSequence(Action value) { }

	public static void add_OnGameAwake(Action value) { }

	public static void add_OnGameDestroyed(Action value) { }

	public static void add_OnGameEnded(Action value) { }

	public static void add_OnGameRevived(Action value) { }

	public static void add_OnGameReviveOffer(Action value) { }

	public static void add_OnGameStarted(Action value) { }

	public void add_OnIntroRun(Action value) { }

	public static void add_OnMenuScreenShown(Action value) { }

	public void add_OnPauseChange(Action<bool> value) { }

	public static void add_OnPlayerDied(Action<bool> value) { }

	public static void add_OnRunEnded(Action<bool> value) { }

	public static void add_OnRunStarted(Action<bool, bool, bool, bool> value) { }

	public void add_OnStageMenuSequence(Action value) { }

	public void add_OnTurboHeadstartInput(Action<int> value) { }

	private void AddModifierSafe(CharacterModifier characterModifier) { }

	protected void Awake() { }

	public void ChangeCurrentSpeed(float timeOffset) { }

	private void CoinManager_OnCoinCollected(object sender, EventArgs args) { }

	public static float ConvertGameMetersToUnityUnits(float meters) { }

	public static float ConvertUnityUnitsToGameMeters(float unityUnits) { }

	public void DeactivateHighSpeed() { }

	private IEnumerator DebugRepeatedlySwipeLeftRightCoroutine() { }

	public void Die() { }

	public void DisableEnemy() { }

	private IEnumerator EnableCharacterDayEventAnimation() { }

	public void EnableEnemy() { }

	public float EvaluatePlayerDistanceTravelTime(float distanceFromCharacter) { }

	public Character get_Character() { }

	public static CharacterController get_Charactercontroller() { }

	public float get_CurrentLevelSpeed() { }

	public float get_CurrentSpeed() { }

	public float get_CurrentSpeedNormalized() { }

	public float get_ElapsedGameDuration() { }

	public float get_ElapsedRunDuration() { }

	public bool get_HasSuperSneakers() { }

	public float get_HighSpeedFOVIncrease() { }

	public static Game get_Instance() { }

	public bool get_IsInJetpackMode() { }

	public bool get_IsInPogostickMode() { }

	public static bool get_IsInstantiated() { }

	public bool get_isInStumbleDeathSequence() { }

	public bool get_IsLockedGameSpeed() { }

	public bool get_IsPaused() { }

	public bool get_IsPausedPowerups() { }

	public bool get_isReadyForSlideinPowerups() { }

	public bool get_IsRunningOnTutorialTrack() { }

	public CharacterModifierCollection get_Modifiers() { }

	public float get_OffsetGameStartTime() { }

	public SyboRandom get_RandomGenerator() { }

	public float get_SpeedFOVIncrease() { }

	public float GetSpeedAtTime(float t) { }

	private void HandleDebugInput(KeyCode keyCode) { }

	private void HandleProductionInput(InputType inputType) { }

	private void InputManager_OnInputEvent(object sender, InputEventArgs inputEventArgs) { }

	public static void InvokeOnGameEnded() { }

	public static void InvokeOnMenuScreenShown() { }

	public void InvokeOnStageMenuSequence() { }

	public static void InvokeReviveOffer() { }

	private void LoadFactories() { }

	public void LockGameSpeedTo(float gameSpeed = -1) { }

	public void Megaheadstart() { }

	public void OnCriticalHit(CriticalHitType type) { }

	protected void OnDestroy() { }

	public void OnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	public void PickupJetpack() { }

	public void PickupPogostick() { }

	public void RecreateCharacterModel() { }

	private void RegisterSpeedChange(float newSpeed) { }

	public void RegisterSpeedChangeHandler(Action<float> handler) { }

	public void remove_OnCharacterModelRecreated(Action value) { }

	public void remove_OnEndStumbleDeathSequence(Action value) { }

	public static void remove_OnGameAwake(Action value) { }

	public static void remove_OnGameDestroyed(Action value) { }

	public static void remove_OnGameEnded(Action value) { }

	public static void remove_OnGameRevived(Action value) { }

	public static void remove_OnGameReviveOffer(Action value) { }

	public static void remove_OnGameStarted(Action value) { }

	public void remove_OnIntroRun(Action value) { }

	public static void remove_OnMenuScreenShown(Action value) { }

	public void remove_OnPauseChange(Action<bool> value) { }

	public static void remove_OnPlayerDied(Action<bool> value) { }

	public static void remove_OnRunEnded(Action<bool> value) { }

	public static void remove_OnRunStarted(Action<bool, bool, bool, bool> value) { }

	public void remove_OnStageMenuSequence(Action value) { }

	public void remove_OnTurboHeadstartInput(Action<int> value) { }

	public void ResetEnemy() { }

	public void ResetEnemyForEnterPlay() { }

	public void ResetGameSpeed() { }

	public void Revive(bool revivedWithAds = false, bool adsWasAvailable = true, bool adsFailed = false) { }

	public void RewardCoin() { }

	public void set_IsLockedGameSpeed(bool value) { }

	public void set_IsPausedPowerups(bool value) { }

	public void set_isReadyForSlideinPowerups(bool value) { }

	public void set_IsRunningOnTutorialTrack(bool value) { }

	public void SetCurrentLevelSpeed(float levelSpeed) { }

	public void SetCurrentSpeed(float speed) { }

	public void SetGameSpeed(float gameSpeed) { }

	public void SetInitialSpeed() { }

	public void ShowNextSceneViewCameraTargetType() { }

	public void ShowNextSceneViewZoomType() { }

	private void SimulateOnApplicationFocus() { }

	private void SimulateOnApplicationPause() { }

	public IEnumerator SkipRevive() { }

	private float Speed(float time, SpeedInfo speedInfo) { }

	protected void Start() { }

	public void StartJetpack() { }

	public void StartNewGame() { }

	public void StartPogostick() { }

	public void StartTopMenu() { }

	private IEnumerator StumbleDeathSequence() { }

	private void ToggleSwipeLeftRight() { }

	public void TriggerPause(bool pauseGame) { }

	public void UnlockGameSpeed() { }

	public void Update() { }

	public void UpdateMeters() { }

}

