namespace SYBO.Subway.Routes;

public struct RouteConstraint
{
	public static RouteConstraint None; //Field offset: 0x0
	public readonly EnvironmentKind[] AllowedEnvironmentKinds; //Field offset: 0x0

	private static RouteConstraint() { }

	public RouteConstraint(EnvironmentKind[] allowedEnvironmentKinds) { }

}

