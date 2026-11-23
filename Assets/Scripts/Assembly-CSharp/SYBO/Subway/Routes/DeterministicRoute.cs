using SYBO.Subway.Routes.Builders;

namespace SYBO.Subway.Routes;

public class DeterministicRoute : Route
{
	private DeterministicRouteBuilder _deterministicRouteBuilder;

	public override RouteType Type => RouteType.Default;

	public override RouteBuilder Builder => _deterministicRouteBuilder;
}
