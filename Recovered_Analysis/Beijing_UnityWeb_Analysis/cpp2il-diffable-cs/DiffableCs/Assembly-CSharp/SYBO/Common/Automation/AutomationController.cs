namespace SYBO.Common.Automation;

public class AutomationController
{
	private IAutomationStepExecutor _executor; //Field offset: 0x10
	private bool _skipInitialFrame; //Field offset: 0x14

	public bool IsRunning
	{
		 get { } //Length: 66
	}

	public AutomationController() { }

	public bool get_IsRunning() { }

	public void StartAutomation(IAutomationStepExecutor executor) { }

	protected void Update() { }

}

