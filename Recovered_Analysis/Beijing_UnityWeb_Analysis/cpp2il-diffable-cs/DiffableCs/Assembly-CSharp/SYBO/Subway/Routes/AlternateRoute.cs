namespace SYBO.Subway.Routes;

public abstract class AlternateRoute : Route
{
	protected Game _game; //Field offset: 0x4C

	public abstract ICustomAnimationClipList AlternateRouteAnimationClipList
	{
		 get { } //Length: 0
	}

	protected AlternateRoute() { }

	public abstract ICustomAnimationClipList get_AlternateRouteAnimationClipList() { }

	public override void Initialize(RouteManager routeManager, Vector3 originGamePosition, SectionSpawnMode sectionSpawnMode, ChunkBuildMode chunkBuildMode, RouteType previousRouteType, SyboRandom randomGenerator) { }

}

