namespace SYBO.Subway.Characters;

public class Character : MonoBehaviour
{
	private sealed class <>c__DisplayClass374_0
	{
		public Character <>4__this; //Field offset: 0x8
		public float trackIndexPositionBegin; //Field offset: 0xC
		public int newTrackIndex; //Field offset: 0x10
		public float startX; //Field offset: 0x14
		public float endX; //Field offset: 0x18
		public float dir; //Field offset: 0x1C
		public float startRotation; //Field offset: 0x20

		public <>c__DisplayClass374_0() { }

		internal void <ChangeTrackCoroutine>b__0(float t) { }

	}

	private sealed class <ChangeTrackCoroutine>d__374 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Character <>4__this; //Field offset: 0x10
		public int move; //Field offset: 0x14
		public float duration; //Field offset: 0x18
		private <>c__DisplayClass374_0 <>8__1; //Field offset: 0x1C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 880
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ChangeTrackCoroutine>d__374(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <LaneSwitchJump>d__397 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Character <>4__this; //Field offset: 0x10
		public float jumpHeight; //Field offset: 0x14
		public Vector3 gamePositionStart; //Field offset: 0x18
		public Vector3 gamePositionEnd; //Field offset: 0x24
		public float jumpsPerLaneSwitch; //Field offset: 0x30
		private bool <hasLanded>5__2; //Field offset: 0x34
		private bool <jumpDone>5__3; //Field offset: 0x35

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 390
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LaneSwitchJump>d__397(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ResetAfterRouteDelayed>d__424 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Character <>4__this; //Field offset: 0x10
		public bool isRouteDestructing; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 87
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ResetAfterRouteDelayed>d__424(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StumbleDecay>d__393 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Character <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 139
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StumbleDecay>d__393(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ToggleDustWithDelay>d__357 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public Character <>4__this; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 204
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ToggleDustWithDelay>d__357(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public enum CriticalHitType
	{
		Train = 0,
		Barrier = 1,
		MovingTrain = 2,
		None = 3,
	}

	public enum DeathCause
	{
		None = 0,
		RepeatedStumble = 1,
		CriticalHit = 2,
		KillSwitch = 3,
	}

	private enum ImpactX
	{
		Left = 0,
		Middle = 1,
		Right = 2,
	}

	private enum ImpactY
	{
		Upper = 0,
		Middle = 1,
		Lower = 2,
	}

	private enum ImpactZ
	{
		Before = 0,
		Middle = 1,
		After = 2,
	}

	public enum ObstaclePassType
	{
		None = 0,
		Roll = 1,
		Jump = 2,
		JumpHigh = 3,
	}

	public enum ObstacleType
	{
		None = 0,
		Sides = 1,
		MinorObstacle = 2,
		Train = 3,
		MovingTrain = 4,
		TrainRamp = 5,
		BarrierStandard = 6,
		BarrierJump = 7,
		BarrierJumpHigh = 8,
		BarrierRoll = 9,
		Pillar = 10,
		Gates = 11,
		StationPlatform = 12,
		Blocker = 13,
		Environment = 14,
	}

	public delegate OnChangeTrackDelegate
	{

		public OnChangeTrackDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(OnChangeTrackDirection direction, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(OnChangeTrackDirection direction) { }

	}

	public enum OnChangeTrackDirection
	{
		Left = 0,
		Right = 1,
	}

	public delegate OnCriticalHitDelegate
	{

		public OnCriticalHitDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(CriticalHitType type, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(CriticalHitType type) { }

	}

	public delegate OnDoubleJumpDelegate
	{

		public OnDoubleJumpDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnGliderEndDelegate
	{

		public OnGliderEndDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnHangtimeDelegate
	{

		public OnHangtimeDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnHitByTrainDelegate
	{

		public OnHitByTrainDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnJumpDelegate
	{

		public OnJumpDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(float jumpHeight, bool willPlaySound, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(float jumpHeight, bool willPlaySound) { }

	}

	public delegate OnJumpIfHitByTrainDelegate
	{

		public OnJumpIfHitByTrainDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnJumpOverTrainDelegate
	{

		public OnJumpOverTrainDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnPassedObstacleDelegate
	{

		public OnPassedObstacleDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(ObstaclePassType type, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(ObstaclePassType type) { }

	}

	public delegate OnResetTeleportFXDelegate
	{

		public OnResetTeleportFXDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnReviveDelegate
	{

		public OnReviveDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnRollDelegate
	{

		public OnRollDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnRollGuardDelegate
	{

		public OnRollGuardDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public delegate OnStumbleDelegate
	{

		public OnStumbleDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	}

	public delegate OnTeleboardStartDelegate
	{

		public OnTeleboardStartDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(float duration, Vector3 offset, float gameSpeed, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(float duration, Vector3 offset, float gameSpeed) { }

	}

	public delegate OnTutorialMoveBackToCheckPointDelegate
	{

		public OnTutorialMoveBackToCheckPointDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(float duration, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(float duration) { }

	}

	public delegate OnTutorialStartFromCheckPointDelegate
	{

		public OnTutorialStartFromCheckPointDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	public enum RunPositions
	{
		ground = 0,
		station = 1,
		train = 2,
		movingTrain = 3,
		air = 4,
	}

	public enum StumbleHorizontalHit
	{
		Left = 0,
		LeftCorner = 1,
		Center = 2,
		RightCorner = 3,
		Right = 4,
	}

	public enum StumbleState
	{
		Standard = 0,
		Safe = 1,
		None = 2,
	}

	public enum StumbleType
	{
		Normal = 0,
		Bush = 1,
		Side = 2,
	}

	public enum StumbleVerticalHit
	{
		Upper = 0,
		Middle = 1,
		Lower = 2,
	}

	private struct SuperSneakersJump
	{
		public float StartGamePositionZ; //Field offset: 0x0
		public float Length; //Field offset: 0x4
		public float EndGamePositionZ; //Field offset: 0x8
		public float StartGamePositionY; //Field offset: 0xC

	}

	private static Character _instance; //Field offset: 0x0
	private const float RampingDistance = 50; //Field offset: 0x0
	public const float TRACK_SWITCH_SPEED_CONSTANT_TELEBORD = 20; //Field offset: 0x0
	public const float TRACK_SWITCH_SPEED_CONSTANT_DEFAULT = 30; //Field offset: 0x0
	public const int InitialTrackIndex = 1; //Field offset: 0x0
	private const float _HEIGHT_CONSIDERED_IS_ABOVE_ROUTES_GROUND = 20; //Field offset: 0x0
	private float _glideTime; //Field offset: 0xC
	private AnimationCurve _glideVerticalSpeed; //Field offset: 0x10
	public CapsuleCollider CharacterTrigger; //Field offset: 0x14
	public CollisionNotifier CharacterTriggerNotifier; //Field offset: 0x18
	public CollisionNotifier CoinMagnetCollider; //Field offset: 0x1C
	public CollisionNotifier CoinMagnetLongCollider; //Field offset: 0x20
	public ParticleSystem HoverboardCrashParticleSystem; //Field offset: 0x24
	public ParticleSystem MysteryPowerupParticleSystem; //Field offset: 0x28
	public ParticleSystem TurboHeadstartParticleSystem; //Field offset: 0x2C
	public float ColliderTrackWidth; //Field offset: 0x30
	public CharacterPickupParticles CharacterPickupParticleSystem; //Field offset: 0x34
	public bool ImmuneToCriticalHit; //Field offset: 0x38
	public float LastGroundedY; //Field offset: 0x3C
	public float SubwayMaxY; //Field offset: 0x40
	public bool StopColliding; //Field offset: 0x44
	public float JumpHeight; //Field offset: 0x48
	public float x; //Field offset: 0x4C
	private ReviveFX _reviveFX; //Field offset: 0x50
	private bool _killSwitchEnabled; //Field offset: 0x54
	public AnimationCurve superSneakersJumpCurve; //Field offset: 0x58
	public float hitPoistionDistance; //Field offset: 0x5C
	public float superSneakersJumpApexRatio; //Field offset: 0x60
	public float gliderGravity; //Field offset: 0x64
	public float gravity; //Field offset: 0x68
	public float jumpHeightNormal; //Field offset: 0x6C
	public float jumpHeightSuperSneakers; //Field offset: 0x70
	public float verticalFallSpeedLimit; //Field offset: 0x74
	public float stumbleCornerTolerance; //Field offset: 0x78
	public float stumbleDecayTime; //Field offset: 0x7C
	public bool inAirJump; //Field offset: 0x80
	public Variable<bool> IsGrounded; //Field offset: 0x84
	public float verticalSpeed; //Field offset: 0x88
	public float SetPieceForgivingJumpTime; //Field offset: 0x8C
	public float SetPieceForgivingJumpHeight; //Field offset: 0x90
	public bool SetPieceForcedForgivingJump; //Field offset: 0x94
	public Action OnSetPieceForgivingJump; //Field offset: 0x98
	private bool _isStumbling; //Field offset: 0x9C
	private bool _isFalling; //Field offset: 0x9D
	private bool __isJumping; //Field offset: 0x9E
	private bool <TransitioningFromHeight>k__BackingField; //Field offset: 0x9F
	private bool _isRolling; //Field offset: 0xA0
	private bool _isTucked; //Field offset: 0xA1
	private bool _isInsideSubway; //Field offset: 0xA2
	private int __trackIndex; //Field offset: 0xA4
	private float _offsetFromFloorY; //Field offset: 0xA8
	private int __trackIndexPrevious; //Field offset: 0xAC
	private bool _isJumpingHigher; //Field offset: 0xB0
	private bool _isTeleboard; //Field offset: 0xB1
	private bool _isDoubleJumping; //Field offset: 0xB2
	private bool _isGliderboard; //Field offset: 0xB3
	private bool _isVTol; //Field offset: 0xB4
	private CharacterController _characterController; //Field offset: 0xB8
	private CharacterModel _characterModel; //Field offset: 0xBC
	private CharacterCamera _characterCamera; //Field offset: 0xC0
	private CharacterRendering _characterRendering; //Field offset: 0xC4
	private Hoverboard _hoverboard; //Field offset: 0xC8
	private LongMagnet _longMagnet; //Field offset: 0xCC
	private SuperSneakers _superSneakers; //Field offset: 0xD0
	private Transform _characterRoot; //Field offset: 0xD4
	private VariableBool _squeezeCollider; //Field offset: 0xD8
	private float _characterAngle; //Field offset: 0xDC
	private RunPositions <CurrentRunPosition>k__BackingField; //Field offset: 0xE0
	private Queue<Collider> GrindedTrains; //Field offset: 0xE4
	private int GrindedTrainsBufferSize; //Field offset: 0xE8
	private Vector3 _gamePosition; //Field offset: 0xEC
	private Vector3 _transformPosition; //Field offset: 0xF8
	private Vector3 __previousFixedUpdateTransformPosition; //Field offset: 0x104
	private Vector3 __previousPreviousFixedUpdateTransformPosition; //Field offset: 0x110
	private StumbleState _stumbleState; //Field offset: 0x11C
	private OnStumbleDelegate OnStumble; //Field offset: 0x120
	public DeathCause LastDeathCause; //Field offset: 0x124
	private ObstacleType _lastObstacleType; //Field offset: 0x128
	private OnCriticalHitDelegate OnCriticalHit; //Field offset: 0x12C
	private OnReviveDelegate OnRevive; //Field offset: 0x130
	private OnJumpDelegate OnJump; //Field offset: 0x134
	private OnDoubleJumpDelegate OnDoubleJump; //Field offset: 0x138
	private OnJumpIfHitByTrainDelegate OnJumpIfHitByTrain; //Field offset: 0x13C
	private Action<Character> OnLanding; //Field offset: 0x140
	private OnHangtimeDelegate OnHangtime; //Field offset: 0x144
	private OnRollDelegate OnRoll; //Field offset: 0x148
	private OnRollGuardDelegate OnRollGuard; //Field offset: 0x14C
	private OnHitByTrainDelegate OnHitByTrain; //Field offset: 0x150
	private OnChangeTrackDelegate OnChangeTrack; //Field offset: 0x154
	private OnTutorialMoveBackToCheckPointDelegate OnTutorialMoveBackToCheckPoint; //Field offset: 0x158
	private OnTutorialStartFromCheckPointDelegate OnTutorialStartFromCheckPoint; //Field offset: 0x15C
	private OnPassedObstacleDelegate OnPassedObstacle; //Field offset: 0x160
	private OnJumpOverTrainDelegate OnJumpOverTrain; //Field offset: 0x164
	private OnTeleboardStartDelegate OnTeleboardStart; //Field offset: 0x168
	private OnGliderEndDelegate OnVTolEnd; //Field offset: 0x16C
	private OnResetTeleportFXDelegate OnResetTeleportFX; //Field offset: 0x170
	public Action<bool> OnRouteDone; //Field offset: 0x174
	public Action<bool> OnToggleDust; //Field offset: 0x178
	public Action OnEnterRoute; //Field offset: 0x17C
	public Action OnEnterRouteEnd; //Field offset: 0x180
	public Action OnExitRoute; //Field offset: 0x184
	private bool __isInLipFlight; //Field offset: 0x188
	private float _lastGamePositionZ; //Field offset: 0x18C
	private int _killSwitchUpdates; //Field offset: 0x190
	private Sound _currentlyPlayingGrindSound; //Field offset: 0x194
	private Vector3 _characterControllerCenter; //Field offset: 0x198
	private float _characterControllerHeight; //Field offset: 0x1A4
	private float _characterControllerSkinWidth; //Field offset: 0x1A8
	private Vector3 _characterColliderCenter; //Field offset: 0x1AC
	private float _characterColliderHeight; //Field offset: 0x1B8
	private int _trackMovement; //Field offset: 0x1BC
	private int _trackMovementNext; //Field offset: 0x1C0
	private int _ignoredMovement; //Field offset: 0x1C4
	private float _characterRotation; //Field offset: 0x1C8
	private int _trackIndexTarget; //Field offset: 0x1CC
	private float _trackIndexPosition; //Field offset: 0x1D0
	private bool _willSecondJump; //Field offset: 0x1D4
	private Game _game; //Field offset: 0x1D8
	private FollowingGuard _followingGuard; //Field offset: 0x1DC
	private RouteManager _routeManager; //Field offset: 0x1E0
	private float _originaljumpHeightSuperSneakers; //Field offset: 0x1E4
	private float _glideTimeLeft; //Field offset: 0x1E8
	private bool _vTolEnded; //Field offset: 0x1EC
	private bool _jumpUpperCollision; //Field offset: 0x1ED
	private float _jumpUpperCollisionColliderMinY; //Field offset: 0x1F0
	private bool _jumpUpperCollisionEvaded; //Field offset: 0x1F4
	private bool _movedSinceLastFixedUpdate; //Field offset: 0x1F5
	private Vector3 _posFixedUpdateLast; //Field offset: 0x1F8
	private Vector3 _posFixedUpdatePrevious; //Field offset: 0x204
	private HashSet<Collider> subwayColliders; //Field offset: 0x210
	private Nullable<SuperSneakersJump> _superSneakersJump; //Field offset: 0x214
	private string _lastHitTag; //Field offset: 0x228
	private bool _startedJumpFromGround; //Field offset: 0x22C
	private float _trainJumpSampleGamePositionZ; //Field offset: 0x230
	private float _trainJumpSampleLength; //Field offset: 0x234
	private bool _trainJump; //Field offset: 0x238
	private float _verticalSpeed_jumpTolerance; //Field offset: 0x23C
	private Layers _layers; //Field offset: 0x240
	private ObstaclePassType _lastObstaclePassType; //Field offset: 0x244
	private int _lastObstaclePassTrackIndex; //Field offset: 0x248
	private float _lastCheckpointGamePositionZ; //Field offset: 0x24C

	public event OnChangeTrackDelegate OnChangeTrack
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnCriticalHitDelegate OnCriticalHit
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnDoubleJumpDelegate OnDoubleJump
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnHangtimeDelegate OnHangtime
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnHitByTrainDelegate OnHitByTrain
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnJumpDelegate OnJump
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnJumpIfHitByTrainDelegate OnJumpIfHitByTrain
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnJumpOverTrainDelegate OnJumpOverTrain
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event Action<Character> OnLanding
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnPassedObstacleDelegate OnPassedObstacle
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnResetTeleportFXDelegate OnResetTeleportFX
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnReviveDelegate OnRevive
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnRollDelegate OnRoll
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnRollGuardDelegate OnRollGuard
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnStumbleDelegate OnStumble
	{
		 add { } //Length: 62
		 remove { } //Length: 113
	}

	public event OnTeleboardStartDelegate OnTeleboardStart
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnTutorialMoveBackToCheckPointDelegate OnTutorialMoveBackToCheckPoint
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnTutorialStartFromCheckPointDelegate OnTutorialStartFromCheckPoint
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public event OnGliderEndDelegate OnVTolEnd
	{
		 add { } //Length: 113
		 remove { } //Length: 113
	}

	public Bounds Bounds
	{
		 get { } //Length: 12
	}

	public float CharacterAngle
	{
		 get { } //Length: 7
	}

	public CharacterCamera CharacterCamera
	{
		 get { } //Length: 7
	}

	public float CharacterColliderLeadingZ
	{
		 get { } //Length: 7
	}

	public CharacterController CharacterController
	{
		 get { } //Length: 110
	}

	public CharacterModel CharacterModel
	{
		 get { } //Length: 7
	}

	public CharacterRendering CharacterRendering
	{
		 get { } //Length: 7
	}

	public Transform CharacterRoot
	{
		 get { } //Length: 7
	}

	public RunPositions CurrentRunPosition
	{
		 get { } //Length: 7
		private set { } //Length: 9
	}

	public StumbleState CurrentStumbleState
	{
		 get { } //Length: 7
		 set { } //Length: 14
	}

	public Vector3 GamePosition
	{
		 get { } //Length: 9
	}

	public Hoverboard Hoverboard
	{
		 get { } //Length: 7
	}

	public int IgnoredMovement
	{
		 set { } //Length: 113
	}

	public static Character Instance
	{
		 get { } //Length: 54
	}

	public bool IsAboveGroundOfCharacterRoute
	{
		 get { } //Length: 7
	}

	public bool IsChangingTracks
	{
		 get { } //Length: 10
	}

	public bool IsDoubleJumping
	{
		 get { } //Length: 110
		 set { } //Length: 12
	}

	public bool IsFalling
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public bool IsGliderboard
	{
		 get { } //Length: 119
		 set { } //Length: 12
	}

	public bool IsInLipFlight
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public bool IsInsideSubway
	{
		 get { } //Length: 10
	}

	public bool IsJumping
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public bool IsJumpingHigher
	{
		 get { } //Length: 162
		 set { } //Length: 9
	}

	public bool IsRolling
	{
		 get { } //Length: 10
	}

	public bool IsStumbling
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public bool IsTeleboard
	{
		 get { } //Length: 110
		 set { } //Length: 12
	}

	public bool IsTucked
	{
		 get { } //Length: 10
	}

	public bool IsVisibleShadow
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public bool IsVTol
	{
		 get { } //Length: 110
		 set { } //Length: 12
	}

	public bool KillSwitchEnabled
	{
		 get { } //Length: 6
		 set { } //Length: 14
	}

	public float LastCheckpointGamePositionZ
	{
		 get { } //Length: 105
	}

	public ObstacleType LastObstacleType
	{
		 get { } //Length: 7
	}

	public LongMagnet LongMagnet
	{
		 get { } //Length: 7
	}

	public float OffsetFromFloorY
	{
		 get { } //Length: 23
		private set { } //Length: 18
	}

	public Vector3 PreviousFixedUpdateTransformPosition
	{
		 get { } //Length: 27
		 set { } //Length: 27
	}

	public Vector3 PreviousPreviousFixedUpdateTransformPosition
	{
		 get { } //Length: 304
		private set { } //Length: 27
	}

	public ReviveFX ReviveFX
	{
		 get { } //Length: 6
	}

	public VariableBool SqueezeCollider
	{
		 get { } //Length: 7
	}

	public SuperSneakers SuperSneakers
	{
		 get { } //Length: 7
	}

	public int TrackIndexCurrent
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public float TrackIndexPosition
	{
		 get { } //Length: 7
		 set { } //Length: 9
	}

	public int TrackIndexPrevious
	{
		 get { } //Length: 7
		private set { } //Length: 33
	}

	public int TrackIndexTarget
	{
		 set { } //Length: 9
	}

	public int TrackMovement
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	public int TrackMovementNext
	{
		 set { } //Length: 9
	}

	public Vector3 TransformPosition
	{
		 get { } //Length: 27
	}

	public bool TransitioningFromHeight
	{
		 get { } //Length: 10
		 set { } //Length: 12
	}

	private static Character() { }

	public Character() { }

	private void <Initialize>b__323_0(bool isInGame) { }

	private void <Initialize>b__323_1(bool squeeze) { }

	public void add_OnChangeTrack(OnChangeTrackDelegate value) { }

	public void add_OnCriticalHit(OnCriticalHitDelegate value) { }

	public void add_OnDoubleJump(OnDoubleJumpDelegate value) { }

	public void add_OnHangtime(OnHangtimeDelegate value) { }

	public void add_OnHitByTrain(OnHitByTrainDelegate value) { }

	public void add_OnJump(OnJumpDelegate value) { }

	public void add_OnJumpIfHitByTrain(OnJumpIfHitByTrainDelegate value) { }

	public void add_OnJumpOverTrain(OnJumpOverTrainDelegate value) { }

	public void add_OnLanding(Action<Character> value) { }

	public void add_OnPassedObstacle(OnPassedObstacleDelegate value) { }

	public void add_OnResetTeleportFX(OnResetTeleportFXDelegate value) { }

	public void add_OnRevive(OnReviveDelegate value) { }

	public void add_OnRoll(OnRollDelegate value) { }

	public void add_OnRollGuard(OnRollGuardDelegate value) { }

	public void add_OnStumble(OnStumbleDelegate value) { }

	public void add_OnTeleboardStart(OnTeleboardStartDelegate value) { }

	public void add_OnTutorialMoveBackToCheckPoint(OnTutorialMoveBackToCheckPointDelegate value) { }

	public void add_OnTutorialStartFromCheckPoint(OnTutorialStartFromCheckPointDelegate value) { }

	public void add_OnVTolEnd(OnGliderEndDelegate value) { }

	private bool AllowDoubleJump() { }

	private void AlternateRoute_OnCharacterEntered(object sender, EventArgs args) { }

	private void AlternateRoute_OnCharacterEntrySkipped(object sender, CharacterEntrySkippedEventArgs args) { }

	private void AlternateRoute_OnCharacterEntryStarted(object sender, EventArgs args) { }

	private void AlternateRoute_OnDestructing(object sender, EventArgs args) { }

	public void ApplyGravity() { }

	protected void Awake() { }

	public void CachePositions() { }

	public float CalculateJumpVerticalSpeed() { }

	public float CalculateJumpVerticalSpeed(float jumpHeight) { }

	public void ChangeTrackBy(int trackDelta) { }

	public void ChangeTrackBy(int trackDelta, float duration) { }

	public void ChangeTrackCenter() { }

	private IEnumerator ChangeTrackCoroutine(int move, float duration) { }

	public void ChangeTrackLeft1() { }

	public void ChangeTrackLeft2() { }

	public void ChangeTrackRight1() { }

	public void ChangeTrackRight2() { }

	private void ChangeTrackTo(int newTrackIndex) { }

	public void CheckInAirJump() { }

	private void ClearLastObstacleType() { }

	public void CreateExplosionAtCharactersFeet() { }

	public void EndRoll() { }

	private bool EnteredColliderFromBelow(Collider collider, bool jumpUpperCollisionRepeated) { }

	public void EnterRoute() { }

	public void EnterRouteEnd() { }

	private void ExecuteKillSwitch() { }

	public void ExitRoute() { }

	private void ExpandColliders() { }

	protected void FixedUpdate() { }

	public void ForceChangeTrack(int movement, float duration) { }

	public void ForceLeaveSubway() { }

	public Bounds get_Bounds() { }

	public float get_CharacterAngle() { }

	public CharacterCamera get_CharacterCamera() { }

	public float get_CharacterColliderLeadingZ() { }

	public CharacterController get_CharacterController() { }

	public CharacterModel get_CharacterModel() { }

	public CharacterRendering get_CharacterRendering() { }

	public Transform get_CharacterRoot() { }

	public RunPositions get_CurrentRunPosition() { }

	public StumbleState get_CurrentStumbleState() { }

	public Vector3 get_GamePosition() { }

	public Hoverboard get_Hoverboard() { }

	public static Character get_Instance() { }

	public bool get_IsAboveGroundOfCharacterRoute() { }

	public bool get_IsChangingTracks() { }

	public bool get_IsDoubleJumping() { }

	public bool get_IsFalling() { }

	public bool get_IsGliderboard() { }

	public bool get_IsInLipFlight() { }

	public bool get_IsInsideSubway() { }

	public bool get_IsJumping() { }

	public bool get_IsJumpingHigher() { }

	public bool get_IsRolling() { }

	public bool get_IsStumbling() { }

	public bool get_IsTeleboard() { }

	public bool get_IsTucked() { }

	public bool get_IsVisibleShadow() { }

	public bool get_IsVTol() { }

	public bool get_KillSwitchEnabled() { }

	public float get_LastCheckpointGamePositionZ() { }

	public ObstacleType get_LastObstacleType() { }

	public LongMagnet get_LongMagnet() { }

	public float get_OffsetFromFloorY() { }

	public Vector3 get_PreviousFixedUpdateTransformPosition() { }

	public Vector3 get_PreviousPreviousFixedUpdateTransformPosition() { }

	public ReviveFX get_ReviveFX() { }

	public VariableBool get_SqueezeCollider() { }

	public SuperSneakers get_SuperSneakers() { }

	public int get_TrackIndexCurrent() { }

	public float get_TrackIndexPosition() { }

	public int get_TrackIndexPrevious() { }

	public int get_TrackMovement() { }

	public Vector3 get_TransformPosition() { }

	public bool get_TransitioningFromHeight() { }

	private ImpactY GetCharacterImpactY(Collider collider) { }

	public Quaternion GetCharacterModelLocalRotation() { }

	public TrackLane GetLaneFromIndex(int laneIndex) { }

	private ImpactX GetObstacleImpactX(Collider collider) { }

	private ImpactZ GetObstacleImpactZ(Collider collider) { }

	private ObstacleType GetObstacleTypeFromTag(Collider obstacleCollider) { }

	private ObstaclePassType GetPassTypeFromCollider(Collider obstacleCollider) { }

	public float GetTrackX() { }

	private void HandleStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble = false, bool isCriticalHit = false) { }

	private void HitByTrainSequence() { }

	public void InitForRun() { }

	public void Initialize() { }

	public bool IsDescending() { }

	private void IsGrounded_OnChange(bool value) { }

	private bool IsRunningFromTrain() { }

	private bool IsRunningOnGround() { }

	public void Jump() { }

	public void JumpAdvanced(float jumpHeight, bool willPlaySound = true, bool willPlayAnimation = true) { }

	public float JumpLength(float speed, float jumpHeight) { }

	private void LandedOnTrain(Collider trainCollider) { }

	private IEnumerator LaneSwitchJump(Vector3 gamePositionStart, Vector3 gamePositionEnd, float jumpHeight, float jumpsPerLaneSwitch) { }

	public void MoveForward() { }

	public void MoveWithGravity() { }

	private void NotifyCriticalHit() { }

	private void NotifyOnChangeTrack(OnChangeTrackDirection direction) { }

	private void NotifyOnCriticalHit(CriticalHitType type) { }

	private void NotifyOnDoubleJump() { }

	private void NotifyOnHangtime() { }

	private void NotifyOnHitByTrain() { }

	private void NotifyOnJump(float jumpHeight, bool willPlaySound) { }

	private void NotifyOnJumpIfHitByTrain() { }

	private void NotifyOnJumpOverTrain() { }

	public void NotifyOnLanding() { }

	private void NotifyOnRoll() { }

	private void NotifyOnStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName, bool safeStumble) { }

	public void NotifyOnTutorialMoveBackToCheckPoint(float duration) { }

	public void NotifyOnTutorialStartFromCheckPoint() { }

	private void OnCharacterTriggerEnter(Collider collider) { }

	private void OnCharacterTriggerExit(Collider collider) { }

	protected void OnDestroy() { }

	private void RaiseExitRoute() { }

	public void RaiseOnEnterRoute() { }

	public void RaiseOnEnterRouteEnd() { }

	private void RaiseOnToggleDust(bool active) { }

	public void RecreateCharacterModel() { }

	public void remove_OnChangeTrack(OnChangeTrackDelegate value) { }

	public void remove_OnCriticalHit(OnCriticalHitDelegate value) { }

	public void remove_OnDoubleJump(OnDoubleJumpDelegate value) { }

	public void remove_OnHangtime(OnHangtimeDelegate value) { }

	public void remove_OnHitByTrain(OnHitByTrainDelegate value) { }

	public void remove_OnJump(OnJumpDelegate value) { }

	public void remove_OnJumpIfHitByTrain(OnJumpIfHitByTrainDelegate value) { }

	public void remove_OnJumpOverTrain(OnJumpOverTrainDelegate value) { }

	public void remove_OnLanding(Action<Character> value) { }

	public void remove_OnPassedObstacle(OnPassedObstacleDelegate value) { }

	public void remove_OnResetTeleportFX(OnResetTeleportFXDelegate value) { }

	public void remove_OnRevive(OnReviveDelegate value) { }

	public void remove_OnRoll(OnRollDelegate value) { }

	public void remove_OnRollGuard(OnRollGuardDelegate value) { }

	public void remove_OnStumble(OnStumbleDelegate value) { }

	public void remove_OnTeleboardStart(OnTeleboardStartDelegate value) { }

	public void remove_OnTutorialMoveBackToCheckPoint(OnTutorialMoveBackToCheckPointDelegate value) { }

	public void remove_OnTutorialStartFromCheckPoint(OnTutorialStartFromCheckPointDelegate value) { }

	public void remove_OnVTolEnd(OnGliderEndDelegate value) { }

	public void RequestSafeStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName) { }

	public void RequestStumble(StumbleType stumbleType, StumbleHorizontalHit horizontalHit, StumbleVerticalHit verticalHit, string colliderName) { }

	public void Reset() { }

	public void ResetAfterRoute(bool isRouteDestructing) { }

	private IEnumerator ResetAfterRouteDelayed(bool isRouteDestructing) { }

	public void ResetCharacterModelLocalRotation() { }

	public void Revive() { }

	public void Roll() { }

	private void RouteManager_OnRouteCreated(object sender, RouteCreatedEventArgs args) { }

	private void set_CurrentRunPosition(RunPositions value) { }

	public void set_CurrentStumbleState(StumbleState value) { }

	public void set_IgnoredMovement(int value) { }

	public void set_IsDoubleJumping(bool value) { }

	public void set_IsFalling(bool value) { }

	public void set_IsGliderboard(bool value) { }

	public void set_IsInLipFlight(bool value) { }

	public void set_IsJumping(bool value) { }

	public void set_IsJumpingHigher(bool value) { }

	public void set_IsStumbling(bool value) { }

	public void set_IsTeleboard(bool value) { }

	public void set_IsVisibleShadow(bool value) { }

	public void set_IsVTol(bool value) { }

	public void set_KillSwitchEnabled(bool value) { }

	private void set_OffsetFromFloorY(float value) { }

	public void set_PreviousFixedUpdateTransformPosition(Vector3 value) { }

	private void set_PreviousPreviousFixedUpdateTransformPosition(Vector3 value) { }

	public void set_TrackIndexCurrent(int value) { }

	public void set_TrackIndexPosition(float value) { }

	private void set_TrackIndexPrevious(int value) { }

	public void set_TrackIndexTarget(int value) { }

	public void set_TrackMovement(int value) { }

	public void set_TrackMovementNext(int value) { }

	public void set_TransitioningFromHeight(bool value) { }

	public void SetCharacterModelLocalRotation(Quaternion rotation) { }

	public void SetGamePosition(Vector3 gamePosition) { }

	public void SetLastCheckpointGamePositionZ(float gamePositionZ) { }

	private void SetLastObstacleType(ObstacleType ot) { }

	private void StartStumble(bool safeStumble = false) { }

	public void StopStumble() { }

	private IEnumerator StumbleDecay() { }

	private void SubscribeToAlternateRoute(AlternateRoute alternateRoute) { }

	private void Teleboard(Vector3 offset) { }

	public void ToggleDust(bool active) { }

	private IEnumerator ToggleDustWithDelay(float delay) { }

	protected void Update() { }

	public void UpdateGroundTag(Character character) { }

	public void UpdateInAirRunPosition() { }

}

