namespace SYBO.Subway.Routes.Builders;

public interface IConstrainingRouteBuilder
{

	public ICollection<RouteBuilder> ConstrainedBuilders
	{
		 get { } //Length: 0
	}

	public ICollection<RouteType> ConstrainedRouteTypes
	{
		 get { } //Length: 0
	}

	public int ConstraintEndZ
	{
		 get { } //Length: 0
	}

	public int ConstraintStartZ
	{
		 get { } //Length: 0
	}

	public ICollection<RouteBuilder> get_ConstrainedBuilders() { }

	public ICollection<RouteType> get_ConstrainedRouteTypes() { }

	public int get_ConstraintEndZ() { }

	public int get_ConstraintStartZ() { }

	public RouteConstraint GetConstraint(RouteType routeType) { }

	public bool IsConstrainingEndAt(int positionZ) { }

	public bool IsConstrainingRange(int startZ, int endZ) { }

	public bool IsConstrainingStartAt(int positionZ) { }

}

