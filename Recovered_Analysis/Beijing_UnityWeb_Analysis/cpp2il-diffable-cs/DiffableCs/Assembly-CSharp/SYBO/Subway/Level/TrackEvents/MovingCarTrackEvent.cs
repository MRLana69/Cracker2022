namespace SYBO.Subway.Level.TrackEvents;

public class MovingCarTrackEvent : CharacterTriggeredTrackEvent, IMoveObjectActivityInitializer, IActivityInitializer
{
	private MovingCarActivity _activityPrefab; //Field offset: 0x28
	private Transform _activityPrefabTransform; //Field offset: 0x2C
	private float _speed; //Field offset: 0x30
	private bool _randomize; //Field offset: 0x34
	private AnimationCurve spawnProbability; //Field offset: 0x38
	private float _speedMax; //Field offset: 0x3C
	private List<Collider> _collidersInSpawnArea; //Field offset: 0x40
	private RouteChunk <RouteChunk>k__BackingField; //Field offset: 0x44

	public RouteChunk RouteChunk
	{
		 get { } //Length: 6
		private set { } //Length: 217
	}

	public float Speed
	{
		 get { } //Length: 6
	}

	private Transform SYBO.Subway.Level.TrackEvents.IMoveObjectActivityInitializer.Transform
	{
		 get { } //Length: 6
	}

	public MovingCarTrackEvent() { }

	public RouteChunk get_RouteChunk() { }

	public float get_Speed() { }

	protected override void Initialize() { }

	protected override void Launch() { }

	private void OnTriggerEnter(Collider otherCollider) { }

	private void OnTriggerExit(Collider otherCollider) { }

	private void set_RouteChunk(RouteChunk value) { }

	private bool ShouldSpawn() { }

	private Transform SYBO.Subway.Level.TrackEvents.IMoveObjectActivityInitializer.get_Transform() { }

	protected override void TrackObject_OnActivate() { }

}

