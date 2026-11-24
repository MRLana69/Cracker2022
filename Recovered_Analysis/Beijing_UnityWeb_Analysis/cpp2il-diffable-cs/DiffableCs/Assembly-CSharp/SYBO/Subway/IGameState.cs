namespace SYBO.Subway;

public interface IGameState
{

	public bool IsCompleted
	{
		 get { } //Length: 0
	}

	public bool IsReadyToEnter
	{
		 get { } //Length: 0
	}

	public void Enter() { }

	public void Exit() { }

	public bool get_IsCompleted() { }

	public bool get_IsReadyToEnter() { }

	public void Initialize() { }

	public void UpdateState() { }

}

