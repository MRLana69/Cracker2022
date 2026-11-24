namespace SYBO.Subway.Level;

public class BlockerObstacle : Obstacle
{
	private BlockerObstacleType _blockerTypes; //Field offset: 0xC
	private bool _withCoins; //Field offset: 0x10
	private bool _noLaneRailsUntilNextBlocker; //Field offset: 0x11

	public BlockerObstacle() { }

}

