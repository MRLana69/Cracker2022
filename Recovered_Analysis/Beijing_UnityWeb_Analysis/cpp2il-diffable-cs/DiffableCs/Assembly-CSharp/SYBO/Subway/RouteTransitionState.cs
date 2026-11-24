namespace SYBO.Subway;

public class RouteTransitionState : MonoBehaviour, IGameState
{
	protected Route _sourceRoute; //Field offset: 0xC
	protected RouteType _targetRouteType; //Field offset: 0x10
	private bool <IsCompleted>k__BackingField; //Field offset: 0x14
	private bool <IsReadyToEnter>k__BackingField; //Field offset: 0x15

	public bool IsCompleted
	{
		 get { } //Length: 66
		private set { } //Length: 18
	}

	public bool IsReadyToEnter
	{
		 get { } //Length: 9
		private set { } //Length: 11
	}

	public RouteTransitionState() { }

	public virtual void Enter() { }

	public virtual void Exit() { }

	public bool get_IsCompleted() { }

	public bool get_IsReadyToEnter() { }

	public virtual void Initialize() { }

	public void Prepare(Route sourceRoute, RouteType targetRouteType) { }

	private void set_IsCompleted(bool value) { }

	private void set_IsReadyToEnter(bool value) { }

	public virtual void UpdateState() { }

}

