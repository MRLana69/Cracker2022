namespace SYBO.Subway.StateSystem.States;

public class ReturnToCheckpointState : InGameState
{
	private const float ReturnToCheckpointDelay = 0.5; //Field offset: 0x0
	private const float ReturnToCheckpointDuration = 1; //Field offset: 0x0
	private float _returnTime; //Field offset: 0x18
	private bool _startedMovingBack; //Field offset: 0x1C
	private Vector3 _initialPosition; //Field offset: 0x20
	private Vector3 _targetPosition; //Field offset: 0x2C

	public ReturnToCheckpointState(int id) { }

	public override void Enter(State fromState) { }

	public override void Leave(State toState) { }

	public override void OnUpdate() { }

}

