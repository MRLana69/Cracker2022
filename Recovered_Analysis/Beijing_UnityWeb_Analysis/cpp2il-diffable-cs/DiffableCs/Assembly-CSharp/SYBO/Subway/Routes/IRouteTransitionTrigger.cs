namespace SYBO.Subway.Routes;

public interface IRouteTransitionTrigger
{

	public Route TargetRoute
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Route get_TargetRoute() { }

	public void set_TargetRoute(Route value) { }

}

