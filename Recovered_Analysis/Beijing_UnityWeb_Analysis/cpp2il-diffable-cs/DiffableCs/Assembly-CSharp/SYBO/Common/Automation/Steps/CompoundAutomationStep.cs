namespace SYBO.Common.Automation.Steps;

public class CompoundAutomationStep : IAutomationStep
{
	private IAutomationStep[] _steps; //Field offset: 0x8
	private int _currentStepIndex; //Field offset: 0xC

	public bool IsDone
	{
		 get { } //Length: 9
	}

	public CompoundAutomationStep(IAutomationStep[] steps) { }

	public virtual void Cleanup() { }

	public bool get_IsDone() { }

	public virtual void Initialize() { }

	public void Update(float unscaledDeltaTime) { }

}

