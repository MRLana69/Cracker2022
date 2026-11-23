namespace SYBO.Subway.Level;

public class BlockerObstacle : Obstacle
{
	private BlockerObstacleType _blockerTypes = BlockerObstacleType.All;

	private bool _withCoins;

	private bool _noLaneRailsUntilNextBlocker;
}
