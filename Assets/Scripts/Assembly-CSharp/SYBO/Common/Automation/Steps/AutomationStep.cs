namespace SYBO.Common.Automation.Steps;

public abstract class AutomationStep : IAutomationStep
{
	private bool IsDone__BackingField;

	public bool IsDone
	{
		get
		{
			return IsDone__BackingField;
		}
		protected set
		{
			IsDone__BackingField = value;
		}
	}

	public virtual void Initialize()
	{
	}

	public virtual void Cleanup()
	{
		IsDone__BackingField = false;
	}

	public abstract void Update(float unscaledDeltaTime);
}
