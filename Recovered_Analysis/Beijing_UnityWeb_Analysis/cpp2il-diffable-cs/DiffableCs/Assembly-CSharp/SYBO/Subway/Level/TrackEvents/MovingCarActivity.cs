namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarActivity : Activity
{
	private PlaceholderLifecycle _carPlaceholderLifecycle; //Field offset: 0x18
	private CollisionNotifier _brakingTrigger; //Field offset: 0x1C
	private ITurnable _turnableBehaviour; //Field offset: 0x20
	private float _speed; //Field offset: 0x24
	private float <Acceleration>k__BackingField; //Field offset: 0x28
	private float _desiredSpeed; //Field offset: 0x2C
	private float _brakeStartSpeed; //Field offset: 0x30
	private float _brakeStartDistance; //Field offset: 0x34
	private bool _braking; //Field offset: 0x38
	private bool _carAheadMoveOpposite; //Field offset: 0x39
	private MovingCarActivity _carAhead; //Field offset: 0x3C
	private Transform _carAheadTransforn; //Field offset: 0x40
	private BoxCollider _collider; //Field offset: 0x44
	private RouteChunk _routeChunk; //Field offset: 0x48

	public float Acceleration
	{
		 get { } //Length: 6
		 set { } //Length: 825
	}

	public float Speed
	{
		 get { } //Length: 6
	}

	public MovingCarActivity() { }

	private void Brake() { }

	private void BrakingTrigger_OnEnter(Collider otherCollider) { }

	private void BrakingTrigger_OnExit(Collider otherCollider) { }

	protected override void Execute() { }

	private Vector3 GapEndPoint() { }

	private Vector3 GapStartPoint() { }

	public float get_Acceleration() { }

	public float get_Speed() { }

	protected override void Initialize() { }

	private void OnTriggerEnter(Collider trigger) { }

	public override void Prepare(IActivityInitializer initializer) { }

	private void RouteChunk_OnDeactivate() { }

	public void set_Acceleration(float value) { }

	public override void Stop() { }

	private void UpdateCurrentChunk() { }

}

