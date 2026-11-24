namespace SYBO.Subway.Routes;

public class RouteSectionGroup : MonoBehaviour
{
	private List<WeightedRouteSection> _routeSections; //Field offset: 0xC

	public List<WeightedRouteSection> RouteSections
	{
		 get { } //Length: 9
	}

	public RouteSectionGroup() { }

	public List<WeightedRouteSection> get_RouteSections() { }

}

