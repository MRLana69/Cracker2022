using System;

namespace SYBO.Subway.Routes;

[Serializable]
public class WeightRandomizedRouteSectionContainter : WeightRandomizedPrefabContainter<WeightedRouteSection, RouteSection>
{
	public WeightRandomizedRouteSectionContainter()
	{
		((IDisposable)this).Dispose();
	}
}
