namespace SYBO.Subway.Level.TrackEvents;

public class MovingObjectTrackEvent : TrackEvent, IMoveObjectActivityInitializer, IActivityInitializer
{
	private MovingObjectActivity _activityPrefab; //Field offset: 0x24
	private Transform _activityPrefabTransform; //Field offset: 0x28
	private float _speed; //Field offset: 0x2C
	private bool _randomize; //Field offset: 0x30
	private float _speedMax; //Field offset: 0x34
	private RouteChunk _routeChunk; //Field offset: 0x38

	public RouteChunk RouteChunk
	{
		 get { } //Length: 141
	}

	public float Speed
	{
		 get { } //Length: 6
	}

	private Transform SYBO.Subway.Level.TrackEvents.IMoveObjectActivityInitializer.Transform
	{
		 get { } //Length: 6
	}

	public MovingObjectTrackEvent() { }

	public RouteChunk get_RouteChunk() { }

	public float get_Speed() { }

	protected override void Initialize() { }

	protected override void Launch() { }

	private Transform SYBO.Subway.Level.TrackEvents.IMoveObjectActivityInitializer.get_Transform() { }

}

