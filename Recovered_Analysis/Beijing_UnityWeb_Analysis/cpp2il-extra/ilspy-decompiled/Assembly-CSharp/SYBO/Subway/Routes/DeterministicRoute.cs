using Cpp2ILInjected;
using SYBO.Subway.Routes.Builders;

namespace SYBO.Subway.Routes;

public class DeterministicRoute : Route
{
	private DeterministicRouteBuilder _deterministicRouteBuilder;

	public override RouteType Type => RouteType.Default;

	public override RouteBuilder Builder
	{
		get
		{
			//IL_0006: Expected Obj, but got I4
			return (RouteBuilder)1;
		}
	}

	public DeterministicRoute()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
