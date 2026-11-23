using SYBO.Subway.Routes.Builders;

namespace SYBO.Subway.Routes;

public class DefaultRoute : Route
{
	private DefaultRouteBuilder _defaultRouteBuilder;

	public override RouteBuilder Builder => _defaultRouteBuilder;

	public override RouteType Type => RouteType.Default;
}
