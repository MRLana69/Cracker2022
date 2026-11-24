namespace SYBO.Subway.Routes;

public class RouteTransitionTrigger : MonoBehaviour, IRouteTransitionTrigger
{
	private CharacterCollisionTrigger _characterTrigger; //Field offset: 0xC
	private Route <TargetRoute>k__BackingField; //Field offset: 0x10

	public Route TargetRoute
	{
		 get { } //Length: 6
		 set { } //Length: 55
	}

	public RouteTransitionTrigger() { }

	private void Awake() { }

	private void CharacterTrigger_OnCharacterEnter(object sender, EventArgs args) { }

	public Route get_TargetRoute() { }

	public void set_TargetRoute(Route value) { }

}

