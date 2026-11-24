namespace SYBO.Subway.StateSystem.States;

public class RunningState : InGameState
{

	public RunningState(int id) { }

	public override void Enter(State fromState) { }

	public override void HandleCriticalHit() { }

	public override void HandleDoubleTap() { }

	public override void HandleSwipe(SwipeDir swipeDir) { }

	private void LogEventForHoverboardStartAttempt(bool successful) { }

	public override void OnUpdate() { }

}

