namespace SYBO.Subway.Routes;

public class RouteCollection
{
	private List<Route> _routes; //Field offset: 0x8
	private bool _hasAddedRouteSinceUpdate; //Field offset: 0xC

	public List<Route> Routes
	{
		 get { } //Length: 49
	}

	public RouteCollection(RouteManager routeManager) { }

	public void Add(Route route) { }

	private void DrawBounds(Bounds bounds) { }

	private void DrawBounds(Bounds bounds, Color color) { }

	private void DrawBounds(Bounds bounds, Color color, float duration) { }

	private void DrawBounds(Bounds bounds, Transform theTransform, Color color, float duration = 0) { }

	private void DrawBoundsInternal(Bounds bounds, Transform theTransform, Color color, float duration = 0) { }

	public List<Route> get_Routes() { }

	public Route GetRouteContainingBounds(Bounds bounds) { }

	public Route GetRouteContainingPoint(Vector3 gamePosition) { }

	public void Remove(Route route) { }

	public void RemoveAll() { }

	private int SortRoutes(Route aRoute, Route bRoute) { }

	public void Update(float characterGamePositionZ, SyboRandom random) { }

}

