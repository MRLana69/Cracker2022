namespace SYBO.Subway.Level.TrackEvents;

public class MovingObjectActivity : Activity
{
	private PlaceholderLifecycle _movingObject; //Field offset: 0x18
	private float _speed; //Field offset: 0x1C
	private float _desiredSpeed; //Field offset: 0x20
	private Transform _initialParent; //Field offset: 0x24
	private RouteChunk _routeChunk; //Field offset: 0x28

	public float Speed
	{
		 get { } //Length: 33
	}

	public MovingObjectActivity() { }

	protected override void Execute() { }

	public float get_Speed() { }

	protected override void Initialize() { }

	public override void Prepare(IActivityInitializer initializer) { }

	private void RouteChunk_OnDeactivate() { }

	public override void Stop() { }

	private void UpdateCurrentChunk() { }

}

