namespace SYBO.Subway.StateSystem.States;

public class EnterPlayState : State
{
	private const string EnterPlayAnimationName = "introRun"; //Field offset: 0x0
	private const string EnterPlayCameraAnimationName = "startPan"; //Field offset: 0x0
	private Camera _camera; //Field offset: 0xC
	private Animation _characterAnimation; //Field offset: 0x10
	private float _fovStart; //Field offset: 0x14

	public EnterPlayState(int id) { }

	public override void Enter(State fromState) { }

	public override void Leave(State toState) { }

	public override void OnUpdate() { }

}

