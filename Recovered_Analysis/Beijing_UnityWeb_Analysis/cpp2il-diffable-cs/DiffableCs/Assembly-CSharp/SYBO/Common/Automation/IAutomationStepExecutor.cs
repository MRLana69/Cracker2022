namespace SYBO.Common.Automation;

public interface IAutomationStepExecutor
{

	public float ElapsedDuration
	{
		 get { } //Length: 0
	}

	public bool IsDone
	{
		 get { } //Length: 0
	}

	public float get_ElapsedDuration() { }

	public bool get_IsDone() { }

	public void Initialize() { }

	public void StartExecution() { }

	public void Terminate() { }

	public void Update(float unscaledDeltaTime) { }

}

