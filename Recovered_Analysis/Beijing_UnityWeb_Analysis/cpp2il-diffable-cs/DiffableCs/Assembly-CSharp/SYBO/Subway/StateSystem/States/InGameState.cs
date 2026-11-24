namespace SYBO.Subway.StateSystem.States;

public abstract class InGameState : State
{
	protected const float CharacterChangeTrackLength = 30; //Field offset: 0x0
	protected Game _game; //Field offset: 0xC
	protected Character _character; //Field offset: 0x10
	protected CharacterCamera _characterCamera; //Field offset: 0x14

	public InGameState(int id) { }

	public virtual void HandleCriticalHit() { }

	public virtual void HandleDoubleTap() { }

	public virtual void HandleSwipe(SwipeDir swipeDir) { }

	public override void OnUpdate() { }

}

