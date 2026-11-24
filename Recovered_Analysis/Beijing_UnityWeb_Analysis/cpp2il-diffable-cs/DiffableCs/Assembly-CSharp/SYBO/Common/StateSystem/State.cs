namespace SYBO.Common.StateSystem;

public class State
{
	public readonly int Id; //Field offset: 0x8

	public State(int id) { }

	public virtual void Enter(State fromState) { }

	public virtual void Leave(State toState) { }

	public virtual void OnLateUpdate() { }

	public virtual void OnUpdate() { }

}

