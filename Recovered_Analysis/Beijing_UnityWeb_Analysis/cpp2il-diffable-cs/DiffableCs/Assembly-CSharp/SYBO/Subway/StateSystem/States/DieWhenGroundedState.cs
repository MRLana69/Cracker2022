namespace SYBO.Subway.StateSystem.States;

public class DieWhenGroundedState : State
{
	private Character _character; //Field offset: 0xC
	private int _frameCount; //Field offset: 0x10

	public DieWhenGroundedState(int id) { }

	public override void Enter(State fromState) { }

	public override void OnUpdate() { }

}

