namespace SYBO.Common.Automation.Steps;

public class WaitForSecondsStep : AutomationStep
{
	private float _durationSeconds; //Field offset: 0xC
	private float _elapsedDurationSeconds; //Field offset: 0x10

	public WaitForSecondsStep(float durationSeconds) { }

	public override void Cleanup() { }

	public override void Update(float unscaledDeltaTime) { }

}

