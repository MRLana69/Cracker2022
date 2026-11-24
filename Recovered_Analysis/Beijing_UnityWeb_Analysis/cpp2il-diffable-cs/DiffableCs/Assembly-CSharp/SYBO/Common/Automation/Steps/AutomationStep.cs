namespace SYBO.Common.Automation.Steps;

public abstract class AutomationStep : IAutomationStep
{
	private bool <IsDone>k__BackingField; //Field offset: 0x8

	public bool IsDone
	{
		 get { } //Length: 86
		protected set { } //Length: 11
	}

	protected AutomationStep() { }

	public virtual void Cleanup() { }

	public bool get_IsDone() { }

	public virtual void Initialize() { }

	protected void set_IsDone(bool value) { }

	public abstract void Update(float unscaledDeltaTime) { }

}

