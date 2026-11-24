namespace SYBO.Subway.Level;

public class BlockerObstacle : Obstacle
{
	private BlockerObstacleType _blockerTypes;

	private bool _withCoins;

	private bool _noLaneRailsUntilNextBlocker;

	public BlockerObstacle()
	{
		CancelInvoke();
	}
}
