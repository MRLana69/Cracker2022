using System.Collections.Generic;
using UnityEngine;

namespace SYBO.Subway.Routes;

public class RouteSectionGroup : MonoBehaviour
{
	private List<WeightedRouteSection> _routeSections;

	public List<WeightedRouteSection> RouteSections => _routeSections;

	public RouteSectionGroup()
	{
		List<WeightedRouteSection> list = default;
		list._002Ector();
		_routeSections = list;
		base._002Ector();
	}
}
