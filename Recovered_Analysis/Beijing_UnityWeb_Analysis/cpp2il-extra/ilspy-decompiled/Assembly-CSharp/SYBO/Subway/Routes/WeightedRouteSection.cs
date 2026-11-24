using System;

namespace SYBO.Subway.Routes;

[Serializable]
public class WeightedRouteSection : WeightedPrefab<RouteSection>
{
	public WeightedRouteSection(RouteSection prefab, int weight)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0013: Expected I4, but got Obj
		((WeightRandomizedPrefabContainter<, >)(object)this).set_Item((int)prefab, (TWeighted)weight);
	}
}
