namespace SYBO.Subway.StateSystem.States;

public class MenuState : State
{
	private Game _game; //Field offset: 0xC
	private Character _character; //Field offset: 0x10
	private FollowingGuard _followingGuard; //Field offset: 0x14

	public MenuState(int id) { }

	public override void Enter(State fromState) { }

	private void SetMenuCamera() { }

}

