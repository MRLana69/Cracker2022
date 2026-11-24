namespace SYBO.Subway.Level.TrackEvents;

public interface IMoveObjectActivityInitializer : IActivityInitializer
{

	public RouteChunk RouteChunk
	{
		 get { } //Length: 0
	}

	public float Speed
	{
		 get { } //Length: 0
	}

	public Transform Transform
	{
		 get { } //Length: 0
	}

	public RouteChunk get_RouteChunk() { }

	public float get_Speed() { }

	public Transform get_Transform() { }

}

