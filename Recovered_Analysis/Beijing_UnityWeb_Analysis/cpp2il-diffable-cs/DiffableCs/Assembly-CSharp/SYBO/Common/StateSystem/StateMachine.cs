namespace SYBO.Common.StateSystem;

public class StateMachine
{
	private class Transition
	{
		public readonly State From; //Field offset: 0x8
		public readonly State To; //Field offset: 0xC
		public readonly Trigger Trigger; //Field offset: 0x10

		public Transition(State from, State to, Trigger trigger) { }

	}

	private class Trigger
	{
		public readonly int Id; //Field offset: 0x8
		public Action<Trigger> OnTriggered; //Field offset: 0xC

		public Trigger(int id) { }

		public void Set() { }

	}

	private State _currentState; //Field offset: 0x8
	private bool _initialStateEntered; //Field offset: 0xC
	private Dictionary<int, State> _states; //Field offset: 0x10
	private List<Transition> _transitions; //Field offset: 0x14
	private Dictionary<int, Trigger> _triggers; //Field offset: 0x18

	public StateMachine(IScheduler scheduler) { }

	public void ActivateTrigger(int id) { }

	public void AddState(State state) { }

	private void AddTransition(State from, State to, Trigger trigger) { }

	public void AddTransition(int fromId, int toId, int triggerId) { }

	public void EnterInitialState(int id) { }

	private Trigger GetOrAddTrigger(int id) { }

	public T GetState(int id) { }

	public bool IsCurrentState() { }

	private void OnLateUpdate() { }

	private void OnUpdate() { }

	private void Trigger_OnTriggered(Trigger trigger) { }

	public T TryGetCurrentState() { }

}

