namespace SYBO.Common.Automation;

public interface IAutomationStep
{

	public bool IsDone
	{
		 get { } //Length: 0
	}

	public void Cleanup() { }

	public bool get_IsDone() { }

	public void Initialize() { }

	public void Update(float unscaledDeltaTime) { }

}

