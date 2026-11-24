namespace SYBO.Subway.StateSystem.States;

public abstract class FlyingState : InGameState
{
	private const float MaxJetpackFlightDurationIncreaseSeconds = 4; //Field offset: 0x0
	private FlyingStateSettings _settings; //Field offset: 0x18
	public Action OnStart; //Field offset: 0x1C
	public Action OnStop; //Field offset: 0x20
	public Action OnFlyAheadStart; //Field offset: 0x24
	public Action<float> OnFlyAheadUpdate; //Field offset: 0x28
	private ActivePowerup _powerup; //Field offset: 0x2C
	private List<Action> _startHandlers; //Field offset: 0x30
	protected float _flyAheadDistance; //Field offset: 0x34
	protected float _speedPositionAdjustment; //Field offset: 0x38
	private float _startGamePositionZ; //Field offset: 0x3C
	protected int _targetGamePositionZ; //Field offset: 0x40
	private float _startY; //Field offset: 0x44
	private Vector3 _startCameraOffset; //Field offset: 0x48
	private float _startCameraAimOffset; //Field offset: 0x54
	private SmoothDampFloat _smoothCameraX; //Field offset: 0x58
	private Vector3 _cameraPositionStart; //Field offset: 0x5C
	private Vector3 _cameraTargetStart; //Field offset: 0x68
	private bool _hasExploded; //Field offset: 0x74

	protected FlyingStateSettings FlyingStateSettings
	{
		 get { } //Length: 56
	}

	public int TargetGamePositionZ
	{
		 get { } //Length: 6
	}

	protected abstract UpgradeType UpgradeType
	{
		 get { } //Length: 0
	}

	public FlyingState(int id) { }

	public override void Enter(State fromState) { }

	protected FlyingStateSettings get_FlyingStateSettings() { }

	public int get_TargetGamePositionZ() { }

	protected abstract UpgradeType get_UpgradeType() { }

	protected virtual float GetFlyHeight() { }

	protected float GetFlyingDuration() { }

	protected abstract float GetFlyingSpeed() { }

	private float GetRatioRemainingForFlyAhead() { }

	private float GetRatioRemainingForFlying() { }

	public float GetTotalRemainingRatio() { }

	public override void HandleSwipe(SwipeDir swipeDir) { }

	public override void Leave(State toState) { }

	private void NotifyOnStart() { }

	private void NotifyOnStop() { }

	public override void OnUpdate() { }

	public void RegisterStartHandler(Action handler) { }

	private void UpdateFlyAhead(float remainingRatio) { }

	protected virtual void UpdateFlying(float remainingRatio) { }

}

