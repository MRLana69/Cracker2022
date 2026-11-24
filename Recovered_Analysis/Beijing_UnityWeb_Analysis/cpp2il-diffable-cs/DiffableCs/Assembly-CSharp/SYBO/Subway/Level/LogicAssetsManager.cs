namespace SYBO.Subway.Level;

public class LogicAssetsManager
{
	public class BasicObstaclePrefab
	{
		public BasicObstacleType Type; //Field offset: 0x8
		public GameObject Prefab; //Field offset: 0xC

		internal BasicObstaclePrefab(BasicObstacleType type) { }

	}

	public class BlockerObstaclePrefab
	{
		public BlockerObstacleType Type; //Field offset: 0x8
		public GameObject Prefab; //Field offset: 0xC

		internal BlockerObstaclePrefab(BlockerObstacleType type) { }

	}

	public class EnvironmentObstaclePrefab
	{
		public EnvironmentObstacleType Type; //Field offset: 0x8
		public GameObject Prefab; //Field offset: 0xC

		internal EnvironmentObstaclePrefab(EnvironmentObstacleType type) { }

	}

	public class ObstacleAssets
	{
		public List<BasicObstaclePrefab> basicObstacles; //Field offset: 0x8
		public List<BasicObstaclePrefab> basicObstaclesWithCoins; //Field offset: 0xC
		public List<BlockerObstaclePrefab> blockerObstacles; //Field offset: 0x10
		public List<BlockerObstaclePrefab> blockerObstaclesWithCoins; //Field offset: 0x14
		public List<EnvironmentObstaclePrefab> environmentObstacles; //Field offset: 0x18
		public List<EnvironmentObstaclePrefab> environmentObstaclesExtended; //Field offset: 0x1C

		internal ObstacleAssets() { }

	}

	public ObstacleAssets obstacles; //Field offset: 0x10
	public EnvironmentAssets environment; //Field offset: 0x14

	public LogicAssetsManager() { }

	public void DespawnEnvironmentSegmentLogic(Transform segmentTransform) { }

	public bool HasEnvironmentSegmentLogic(EnvironmentType envType) { }

	public Transform SpawnEnvironmentSegmentLogic(EnvironmentType envType, EnvironmentSequence sequence) { }

	protected override void SubclassInitialize() { }

}

