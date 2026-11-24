namespace SYBO.Subway.Characters;

public class CharacterRendering : MonoBehaviour
{
	private sealed class <>c__DisplayClass120_0
	{
		public AnimationState caught; //Field offset: 0x8

		public <>c__DisplayClass120_0() { }

		internal void <CatchPlayerAnimStarter>b__0(float t) { }

	}

	private sealed class <>c__DisplayClass99_0
	{
		public CharacterRendering <>4__this; //Field offset: 0x8
		public Vector3 currentPos; //Field offset: 0xC
		public Vector3 camPos; //Field offset: 0x18

		public <>c__DisplayClass99_0() { }

		internal void <OnHitByTrain>b__0(float t) { }

	}

	private sealed class <CatchPlayerAnimStarter>d__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AnimationState caught; //Field offset: 0x10
		public float delay; //Field offset: 0x14
		public CharacterRendering <>4__this; //Field offset: 0x18
		private <>c__DisplayClass120_0 <>8__1; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 310
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CatchPlayerAnimStarter>d__120(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <OnRollPlayAnimation>d__95 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterRendering <>4__this; //Field offset: 0x10
		private string <rollAnimation>5__2; //Field offset: 0x14
		private float <endTime>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 517
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <OnRollPlayAnimation>d__95(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <RouteCelebrate_Coroutine>d__141 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CharacterRendering <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 118
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RouteCelebrate_Coroutine>d__141(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TeleboardEndScale>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float duration; //Field offset: 0x10
		public CharacterRendering <>4__this; //Field offset: 0x14
		private float <time>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 289
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TeleboardEndScale>d__147(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <TeleboardStartScale>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float duration; //Field offset: 0x10
		public CharacterRendering <>4__this; //Field offset: 0x14
		public float gameSpeed; //Field offset: 0x18
		private float <time>5__2; //Field offset: 0x1C
		private float <endDuration>5__3; //Field offset: 0x20
		private Vector3 <model1position>5__4; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 864
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <TeleboardStartScale>d__145(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public class AnimationClipLists
	{
		public AnimationClip[] topMenu; //Field offset: 0x8
		public AnimationClip[] introRun; //Field offset: 0xC
		public AnimationClip[] run; //Field offset: 0x10
		public AnimationClip[] jump; //Field offset: 0x14
		public AnimationClip[] hangtime; //Field offset: 0x18
		public AnimationClip[] doubleJump; //Field offset: 0x1C
		public AnimationClip[] doubleHangtime; //Field offset: 0x20
		public AnimationClip[] landing; //Field offset: 0x24
		public AnimationClip[] dodgeLeft; //Field offset: 0x28
		public AnimationClip[] dodgeRight; //Field offset: 0x2C
		public AnimationClip[] roll; //Field offset: 0x30
		public AnimationClip[] hitMid; //Field offset: 0x34
		public AnimationClip[] hitUpper; //Field offset: 0x38
		public AnimationClip[] hitLower; //Field offset: 0x3C
		public AnimationClip[] hitMoving; //Field offset: 0x40
		public AnimationClip[] stumble; //Field offset: 0x44
		public AnimationClip[] stumbleMix; //Field offset: 0x48
		public AnimationClip[] stumbleDeath; //Field offset: 0x4C
		public AnimationClip[] stumbleLeftSide; //Field offset: 0x50
		public AnimationClip[] stumbleRightSide; //Field offset: 0x54
		public AnimationClip[] stumbleLeftCorner; //Field offset: 0x58
		public AnimationClip[] stumbleRightCorner; //Field offset: 0x5C
		public AnimationClip[] holdMagnet; //Field offset: 0x60

		public AnimationClipLists() { }

	}

	public class Animations
	{
		public List<string> TOP_MENU; //Field offset: 0x8
		public List<string> INTRO_RUN; //Field offset: 0xC
		public List<string> RUN; //Field offset: 0x10
		public List<string> LAND; //Field offset: 0x14
		public List<string> BIG_LAND; //Field offset: 0x18
		public List<string> SMALL_LAND; //Field offset: 0x1C
		public List<string> JUMP; //Field offset: 0x20
		public List<string> SMALL_JUMP; //Field offset: 0x24
		public List<string> TUCK; //Field offset: 0x28
		public List<string> HANGTIME; //Field offset: 0x2C
		public List<string> DOUBLEJUMP; //Field offset: 0x30
		public List<string> DOUBLEHANGTIME; //Field offset: 0x34
		public List<string> ROLL; //Field offset: 0x38
		public List<string> DODGE_LEFT; //Field offset: 0x3C
		public List<string> DODGE_RIGHT; //Field offset: 0x40
		public List<string> TURBO_HEADSTART1; //Field offset: 0x44
		public List<string> TURBO_HEADSTART2; //Field offset: 0x48
		public List<string> STARTGRIND; //Field offset: 0x4C
		public List<string> GRIND; //Field offset: 0x50
		public List<string> GET_ON_BOARD; //Field offset: 0x54
		public List<string> HIT_MID; //Field offset: 0x58
		public List<string> HIT_UPPER; //Field offset: 0x5C
		public List<string> HIT_LOWER; //Field offset: 0x60
		public List<string> HIT_MOVING; //Field offset: 0x64
		public List<string> STUMBLE; //Field offset: 0x68
		public List<string> STUMBLEDEATH; //Field offset: 0x6C
		public List<string> STUMBLE_MIX; //Field offset: 0x70
		public List<string> STUMBLE_LEFT_SIDE; //Field offset: 0x74
		public List<string> STUMBLE_RIGHT_SIDE; //Field offset: 0x78
		public List<string> STUMBLE_LEFT_CORNER; //Field offset: 0x7C
		public List<string> STUMBLE_RIGHT_CORNER; //Field offset: 0x80
		public List<string> HOLDMAGNET; //Field offset: 0x84
		public List<string> WALLRIDELEFT; //Field offset: 0x88
		public List<string> WALLRIDELEFTEXIT; //Field offset: 0x8C
		public List<string> WALLRIDERIGHT; //Field offset: 0x90
		public List<string> WALLRIDERIGHTEXIT; //Field offset: 0x94
		public List<string> WALLGRINDLEFT; //Field offset: 0x98
		public List<string> WALLGRINDLEFTEXIT; //Field offset: 0x9C
		public List<string> WALLGRINDRIGHT; //Field offset: 0xA0
		public List<string> WALLGRINDRIGHTEXIT; //Field offset: 0xA4
		public List<string> ROUTE_CELEBRATE; //Field offset: 0xA8
		public List<string> BIG_AIR_TRICK; //Field offset: 0xAC
		public List<string> ROUTE_ENTER; //Field offset: 0xB0
		public List<string> ROUTE_EXIT; //Field offset: 0xB4
		public string DEFAULT_HOVERBOARD_ANIMATION; //Field offset: 0xB8
		private List<string> _animationNamesFiltered; //Field offset: 0xBC
		private List<string> _animationNamesExcluded; //Field offset: 0xC0

		public string BigAirTrick
		{
			 get { } //Length: 15
		}

		public string BigLand
		{
			 get { } //Length: 14
		}

		public string DodgeLeft
		{
			 get { } //Length: 14
		}

		public string DodgeRight
		{
			 get { } //Length: 14
		}

		public string DoubleHangtime
		{
			 get { } //Length: 14
		}

		public string DoubleJump
		{
			 get { } //Length: 14
		}

		public string GetOnBoard
		{
			 get { } //Length: 14
		}

		public string Hangtime
		{
			 get { } //Length: 14
		}

		public string HitLower
		{
			 get { } //Length: 14
		}

		public string HitMid
		{
			 get { } //Length: 14
		}

		public string HitMoving
		{
			 get { } //Length: 14
		}

		public string HitUpper
		{
			 get { } //Length: 14
		}

		public List<string> HoverboardJump
		{
			 get { } //Length: 14
		}

		public string IntroRun
		{
			 get { } //Length: 14
		}

		public string Jump
		{
			 get { } //Length: 14
		}

		public string Land
		{
			 get { } //Length: 14
		}

		public string Roll
		{
			 get { } //Length: 19
		}

		public string RouteCelebrate
		{
			 get { } //Length: 15
		}

		public string RouteEnter
		{
			 get { } //Length: 15
		}

		public string RouteExit
		{
			 get { } //Length: 15
		}

		public string Run
		{
			 get { } //Length: 14
		}

		public string SmallJump
		{
			 get { } //Length: 14
		}

		public string SmallLand
		{
			 get { } //Length: 14
		}

		public string StartGrind
		{
			 get { } //Length: 17
		}

		public string Stumble
		{
			 get { } //Length: 14
		}

		public string StumbleDeath
		{
			 get { } //Length: 14
		}

		public string StumbleLeftCorner
		{
			 get { } //Length: 14
		}

		public string StumbleLeftSide
		{
			 get { } //Length: 14
		}

		public string StumbleMix
		{
			 get { } //Length: 14
		}

		public string StumbleRightCorner
		{
			 get { } //Length: 14
		}

		public string StumbleRightSide
		{
			 get { } //Length: 14
		}

		public string TopMenu
		{
			 get { } //Length: 6
		}

		public string Tuck
		{
			 get { } //Length: 14
		}

		public string TurboHeadstart1
		{
			 get { } //Length: 14
		}

		public string TurboHeadstart2
		{
			 get { } //Length: 14
		}

		public string WallGrindLeft
		{
			 get { } //Length: 15
		}

		public string WallGrindLeftExit
		{
			 get { } //Length: 15
		}

		public string WallGrindRight
		{
			 get { } //Length: 15
		}

		public string WallGrindRightExit
		{
			 get { } //Length: 15
		}

		public string WallRideLeft
		{
			 get { } //Length: 15
		}

		public string WallRideLeftExit
		{
			 get { } //Length: 15
		}

		public string WallRideRight
		{
			 get { } //Length: 15
		}

		public string WallRideRightExit
		{
			 get { } //Length: 15
		}

		public Animations() { }

		public string get_BigAirTrick() { }

		public string get_BigLand() { }

		public string get_DodgeLeft() { }

		public string get_DodgeRight() { }

		public string get_DoubleHangtime() { }

		public string get_DoubleJump() { }

		public string get_GetOnBoard() { }

		public string get_Hangtime() { }

		public string get_HitLower() { }

		public string get_HitMid() { }

		public string get_HitMoving() { }

		public string get_HitUpper() { }

		public List<string> get_HoverboardJump() { }

		public string get_IntroRun() { }

		public string get_Jump() { }

		public string get_Land() { }

		public string get_Roll() { }

		public string get_RouteCelebrate() { }

		public string get_RouteEnter() { }

		public string get_RouteExit() { }

		public string get_Run() { }

		public string get_SmallJump() { }

		public string get_SmallLand() { }

		public string get_StartGrind() { }

		public string get_Stumble() { }

		public string get_StumbleDeath() { }

		public string get_StumbleLeftCorner() { }

		public string get_StumbleLeftSide() { }

		public string get_StumbleMix() { }

		public string get_StumbleRightCorner() { }

		public string get_StumbleRightSide() { }

		public string get_TopMenu() { }

		public string get_Tuck() { }

		public string get_TurboHeadstart1() { }

		public string get_TurboHeadstart2() { }

		public string get_WallGrindLeft() { }

		public string get_WallGrindLeftExit() { }

		public string get_WallGrindRight() { }

		public string get_WallGrindRightExit() { }

		public string get_WallRideLeft() { }

		public string get_WallRideLeftExit() { }

		public string get_WallRideRight() { }

		public string get_WallRideRightExit() { }

		private string GetRandomAnimationName(List<string> animationsNames) { }

		private string GetRandomAnimationNameExcluding(List<string> animationNames, string excludeAnimationName) { }

		private string GetRandomAnimationNameExcluding(List<string> animationNames, IEnumerable<string> excludeAnimationNames) { }

		private List<string> GetRandomHoverJumps(List<string> hoverboardJump, List<string> hoverboardHangtime) { }

		public string Grind(string lastAnimationName) { }

	}

	public interface ICustomAnimationClipList
	{

		public void Initialize(Animations animations, CharacterRendering characterRendering) { }

	}

	public class JetpackClips
	{
		public AnimationClip[] run; //Field offset: 0x8
		public AnimationClip[] dodgeLeft; //Field offset: 0xC
		public AnimationClip[] dodgeRight; //Field offset: 0x10
		public AnimationClip[] turboHeadstart1; //Field offset: 0x14
		public AnimationClip[] turboHeadstart2; //Field offset: 0x18

		public JetpackClips() { }

	}

	public class PogostickClips
	{
		public AnimationClip[] run; //Field offset: 0x8
		public AnimationClip[] hangtime; //Field offset: 0xC
		public AnimationClip[] dodgeLeft; //Field offset: 0x10
		public AnimationClip[] dodgeRight; //Field offset: 0x14

		public PogostickClips() { }

	}

	public class SuperSneaksClips
	{
		public AnimationClip[] run; //Field offset: 0x8

		public SuperSneaksClips() { }

	}

	private const int GrindIndexCornerGrindLeft = 0; //Field offset: 0x0
	private const int GrindIndexOnRail = 1; //Field offset: 0x0
	private const int GrindIndexCornerGrindRight = 2; //Field offset: 0x0
	private const float FaceLengthJumpAnimation = 0.15; //Field offset: 0x0
	private const float FadeLengthJumpAnimationAfterTuck = 1; //Field offset: 0x0
	private const float CameraShakeAmountForTurboHeadstart = 20; //Field offset: 0x0
	private static CharacterRendering _instance; //Field offset: 0x0
	private static float _DEFAULT_SPEED_RUN_ANIMATION; //Field offset: 0x4
	private AnimationClipLists defaultAnimations; //Field offset: 0xC
	private JetpackClips jetpackAnimations; //Field offset: 0x10
	private SuperSneaksClips SuperSneaksAnimations; //Field offset: 0x14
	private PogostickClips pogostickClips; //Field offset: 0x18
	private GameObject teleboardWarpPrefab; //Field offset: 0x1C
	private Material teleboardFXMaterial; //Field offset: 0x20
	private AnimationCurve jetpackParticleOffsetCurve; //Field offset: 0x24
	private GameObject characterModelPrefab; //Field offset: 0x28
	private GameObject characterRenderingEffectsPrefab; //Field offset: 0x2C
	public Animations animations; //Field offset: 0x30
	private CharacterModel _characterModel; //Field offset: 0x34
	private Game _game; //Field offset: 0x38
	private Character _character; //Field offset: 0x3C
	private Hoverboard _hoverboard; //Field offset: 0x40
	private SuperSneakers _superSneakers; //Field offset: 0x44
	private FollowingGuard _followingGuard; //Field offset: 0x48
	private CharacterController _characterController; //Field offset: 0x4C
	private MeshRenderer _shadowMeshRenderer; //Field offset: 0x50
	private CharacterRenderingEffects _characterRenderingEffects; //Field offset: 0x54
	private Revive _revive; //Field offset: 0x58
	private SafeAnimation _characterSafeAnimation; //Field offset: 0x5C
	private SafeAnimation _hoverboardSafeAnimation; //Field offset: 0x60
	private bool _initialized; //Field offset: 0x64
	private HoverboardRendering _defaultHoverboardRendering; //Field offset: 0x68
	private AbilityAnimationList _defaultHoverboardAnimationList; //Field offset: 0x6C
	private GameObject _teleboardWarpGameObject; //Field offset: 0x70
	private Renderer _telewarpRenderer; //Field offset: 0x74
	private AnimationState _teleboardAnimation; //Field offset: 0x78
	private Vector3 _teleboardWarpPosition; //Field offset: 0x7C
	private CharacterCamera _characterCamera; //Field offset: 0x88
	private HoverboardRendering _hoverboardRendering; //Field offset: 0x8C
	private List<AnimationClip> _addedAnimClipsNames; //Field offset: 0x90
	private HoverboardBundle _cachedHoverboardBundle; //Field offset: 0x94
	private BoardAbility[] _currentBoardAbilities; //Field offset: 0x98
	private Vector3 _initRot; //Field offset: 0x9C
	private Vector3 _initScale; //Field offset: 0xA8
	private ParticleSystem[] _killParticleSystem; //Field offset: 0xB4
	private AnimationState _caughtAnimationState; //Field offset: 0xB8
	private Material _cachedModelMaterial; //Field offset: 0xBC
	private Material[] _cachedHeadMaterials; //Field offset: 0xC0
	private Material _cachedCustomizationMaterial; //Field offset: 0xC4
	private Material _cachedHoverboardMaterial; //Field offset: 0xC8
	private Material _cachedSupersneakersMaterial; //Field offset: 0xCC
	private Material _cachedDoubleJumperMaterial; //Field offset: 0xD0
	private Material[] _cachedCustomHoverboardModelMaterials; //Field offset: 0xD4
	private Transform _extraTeleportFX; //Field offset: 0xD8
	private bool _isTeleportFxActive; //Field offset: 0xDC
	private bool _isCachedCustomizationState; //Field offset: 0xDD
	private bool _isDoublejump; //Field offset: 0xDE
	private bool _isRolling; //Field offset: 0xDF
	private bool _isDeath; //Field offset: 0xE0
	private RouteManager _routeManager; //Field offset: 0xE4
	private string _lastGrindAnimation; //Field offset: 0xE8
	private string jumpAnimation; //Field offset: 0xEC
	private string hangtimeAnimation; //Field offset: 0xF0
	private bool _queuedHangtime; //Field offset: 0xF4

	public Animation CharacterAnimation
	{
		 get { } //Length: 6
	}

	public CharacterModel CharacterModel
	{
		 get { } //Length: 66
	}

	public SafeAnimation CharacterSafeAnimation
	{
		 get { } //Length: 9
	}

	public SafeAnimation HoverboardSafeAnimation
	{
		 get { } //Length: 6
	}

	public static CharacterRendering Instance
	{
		 get { } //Length: 395
	}

	private static CharacterRendering() { }

	public CharacterRendering() { }

	private void <HandleOnTurboHeadstart>b__130_0(float t) { }

	private void AlternateRoute_OnCharacterEntrySkipped(object sender, CharacterEntrySkippedEventArgs args) { }

	private void AlternateRoute_OnCharacterEntryStarted(object sender, CharacterEntryStartedEventArgs args) { }

	private void AlternateRoute_OnCharacterExited(object sender, CharacterExitedEventArgs args) { }

	private void AlternateRoute_OnDestructing(object sender, EventArgs args) { }

	protected void Awake() { }

	private IEnumerator CatchPlayerAnimStarter(AnimationState caught, float delay) { }

	private void Character_OnEnterRoute() { }

	private void Character_OnEnterRouteEnd() { }

	private void Character_OnExitRoute() { }

	public void Character_OnHangtime() { }

	private void Character_OnHangtime_AfterAlternateRoute() { }

	private void DebugLog(string message) { }

	public void EndGrind() { }

	private void EndRollAnimation() { }

	private void Game_OnEndStumbleDeathSequence() { }

	public Animation get_CharacterAnimation() { }

	public CharacterModel get_CharacterModel() { }

	public SafeAnimation get_CharacterSafeAnimation() { }

	public SafeAnimation get_HoverboardSafeAnimation() { }

	public static CharacterRendering get_Instance() { }

	private string GetHoverboardAnimationName(string animationName) { }

	private void HandleOnScorebooster(int tier) { }

	public void HandleOnTeleboardEnd(float duration, float gameSpeed) { }

	private void HandleOnTeleboardStart(float duration, Vector3 offset, float gameSpeed) { }

	private void HandleOnTurboHeadstart(int version) { }

	private bool HasHoverboardAnimation(string animationToCheck) { }

	public void Initialize() { }

	private void InitializeAnimations() { }

	private void InitializeCharacterModel() { }

	private void InitializeCharacterRenderingEffects() { }

	public List<string> InitializeClips(AnimationClip[] clips, IEnumerable<string> excludedAnimationNames = null) { }

	private void IsInGame_OnChange(bool isInGame) { }

	private void JetpackOnFlyAheadStart() { }

	private void JetpackOnFlyAheadUpdate(float ratio) { }

	private void JetpackOnStop() { }

	private void OnApplicationPause(bool isApplicationPaused) { }

	private void OnCatchPlayer(string currentCharacterCaught, float catchUpTime, float waitTimeBeforeScreen) { }

	private void OnChangeIsGrounded(bool isGrounded) { }

	private void OnChangeTrack(OnChangeTrackDirection direction) { }

	protected void OnDestroy() { }

	private void OnDoubleHangtime() { }

	private void OnDoubleJump() { }

	private void OnGrindExit(int side) { }

	private void OnHitByTrain() { }

	private void OnIntroRun() { }

	private void OnJump(int intensity) { }

	private void OnJump() { }

	private void OnJump(float jumpHeight, bool willPlaySound) { }

	private void OnLanding(Character character) { }

	private void OnRevive() { }

	private void OnRoll() { }

	private IEnumerator OnRollPlayAnimation() { }

	private void OnRouteDone(bool isRouteDestructing) { }

	public void OnRun() { }

	private void OnStageMenuSequence() { }

	private void OnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	private void OnSwitchToHoverboard(HoverboardBundle hoverBoardBundle, BoardAbility[] abilities) { }

	private void OnSwitchToJetpack() { }

	public void OnSwitchToRunning() { }

	internal void OnSwitchToRunningAfterAlternateRoute() { }

	private void OnSwitchToSuperSneakers() { }

	private void OnTutorialMoveBackToCheckPoint(float duration) { }

	private void OnTutorialStartFromCheckPoint() { }

	private void OverrideRollTransition() { }

	private void PogostickOnHangtime() { }

	private void PogostickOnStart() { }

	private void PogostickOnStop() { }

	public CharacterModel RecreateCharacterModel() { }

	private void ResetCharacterTeleportFX() { }

	private void ResetJetpackTrusters() { }

	public void ResetTeleportFx() { }

	private IEnumerator RouteCelebrate_Coroutine() { }

	private void RouteManager_OnRouteCreated(object sender, RouteCreatedEventArgs args) { }

	private void SetPieceTransitionTriggerState_OnEnd() { }

	private void SetPieceTransitionTriggerState_OnHangtime() { }

	private void StartGrind(int side) { }

	private void StartWallRide(int side) { }

	private void StopWallRide(int side) { }

	private void SuperSneakersOnStop() { }

	private void SwitchFromAlternateRoute(bool isExitingFromAir) { }

	private void SwitchToAlternateRoute(AlternateRoute route) { }

	private IEnumerator TeleboardEndScale(float duration) { }

	private IEnumerator TeleboardStartScale(float duration, float gameSpeed) { }

	private void ToggleCustomHoverboard(HoverboardBundle newHoverboardBundle, BoardAbility[] abilities) { }

	private void ToggleDust(bool active) { }

}

