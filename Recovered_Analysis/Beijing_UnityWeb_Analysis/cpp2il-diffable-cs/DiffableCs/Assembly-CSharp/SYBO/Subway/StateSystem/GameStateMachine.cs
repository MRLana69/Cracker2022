namespace SYBO.Subway.StateSystem;

public class GameStateMachine : StateMachine
{
	private static GameStateMachine _instance; //Field offset: 0x0
	public const int ReturnToCheckpointTriggerId = 106; //Field offset: 0x0
	public const int PogostickTriggerId = 105; //Field offset: 0x0
	public const int JetpackTriggerId = 104; //Field offset: 0x0
	public const int HeadstartTriggerId = 103; //Field offset: 0x0
	public const int RunningTriggerId = 102; //Field offset: 0x0
	public const int EnterPlayTriggerId = 101; //Field offset: 0x0
	public const int MenuTriggerId = 100; //Field offset: 0x0
	public const int DieWhenGroundedTriggerId = 107; //Field offset: 0x0
	public const int DeathStateId = 8; //Field offset: 0x0
	public const int ReturnToCheckpointStateId = 6; //Field offset: 0x0
	public const int PogostickStateId = 5; //Field offset: 0x0
	public const int JetpackStateId = 4; //Field offset: 0x0
	public const int HeadstartStateId = 3; //Field offset: 0x0
	public const int RunningStateId = 2; //Field offset: 0x0
	public const int EnterPlayStateId = 1; //Field offset: 0x0
	public const int MenuStateId = 0; //Field offset: 0x0
	public const int DieWhenGroundedStateId = 7; //Field offset: 0x0
	public const int DeathTriggerId = 108; //Field offset: 0x0

	public static GameStateMachine Instance
	{
		 get { } //Length: 377
	}

	private static GameStateMachine() { }

	private GameStateMachine(IScheduler scheduler) { }

	public static void GenerateStateMachine() { }

	public static GameStateMachine get_Instance() { }

	public void HandleCriticalHit() { }

	public void HandleDoubleTap() { }

	public void HandleSwipe(SwipeDir swipeDir) { }

	public static void Initialize() { }

	public bool IsInGame() { }

}

