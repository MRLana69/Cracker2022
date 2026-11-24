namespace SYBO.Subway.Routes;

public class DeterministicRouteBuilder : DefaultRouteBuilder
{
	private int _midSectionIndex; //Field offset: 0x100

	public DeterministicRouteBuilder() { }

	protected override bool CanSpawnSection(RouteSection section) { }

	protected override RouteSection GetNextSectionPrefab() { }

}

