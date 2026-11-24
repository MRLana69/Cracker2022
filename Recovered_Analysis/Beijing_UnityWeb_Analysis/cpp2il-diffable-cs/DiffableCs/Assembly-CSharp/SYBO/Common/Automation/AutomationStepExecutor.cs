namespace SYBO.Common.Automation;

public class AutomationStepExecutor : IAutomationStepExecutor
{
	protected IAutomationStep[] _steps; //Field offset: 0x8
	private int _currentStepIndex; //Field offset: 0xC
	private IAutomationStep _currentStep; //Field offset: 0x10
	private float _startTime; //Field offset: 0x14

	public virtual string ConfirmationMessage
	{
		 get { } //Length: 3
	}

	public float ElapsedDuration
	{
		 get { } //Length: 9
	}

	public bool IsDone
	{
		 get { } //Length: 49
	}

	public virtual bool RequiresConfirmation
	{
		 get { } //Length: 9
	}

	public AutomationStepExecutor(IAutomationStep[] steps) { }

	public virtual string get_ConfirmationMessage() { }

	public float get_ElapsedDuration() { }

	public bool get_IsDone() { }

	public virtual bool get_RequiresConfirmation() { }

	public virtual void Initialize() { }

	public virtual void StartExecution() { }

	public virtual void Terminate() { }

	public virtual void Update(float unscaledDeltaTime) { }

}

