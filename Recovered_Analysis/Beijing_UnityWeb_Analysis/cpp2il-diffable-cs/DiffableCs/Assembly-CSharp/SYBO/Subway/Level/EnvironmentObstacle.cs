namespace SYBO.Subway.Level;

public class EnvironmentObstacle : Obstacle
{
	private EnvironmentObstacleType _obstacleType; //Field offset: 0xC
	private TrackLane _blockedLanes; //Field offset: 0x10
	private EnvironmentSegmentLength _obstacleLength; //Field offset: 0x14
	private EnvironmentConstraint _environmentConstraint; //Field offset: 0x18

	public TrackLane BlockedLanes
	{
		 get { } //Length: 6
	}

	public EnvironmentConstraint EnvironmentConstraint
	{
		 get { } //Length: 301
	}

	public EnvironmentSegmentLength ObstacleLength
	{
		 get { } //Length: 6
	}

	public EnvironmentObstacleType ObstacleType
	{
		 get { } //Length: 6
	}

	public EnvironmentObstacle() { }

	public TrackLane get_BlockedLanes() { }

	public EnvironmentConstraint get_EnvironmentConstraint() { }

	public EnvironmentSegmentLength get_ObstacleLength() { }

	public EnvironmentObstacleType get_ObstacleType() { }

	private void OnValidate() { }

}

