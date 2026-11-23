namespace SYBO.Common.Automation.Steps;

public class WaitForSecondsStep(float durationSeconds) : AutomationStep
{
	private float _durationSeconds = durationSeconds;

	private float _elapsedDurationSeconds;

	public override void Cleanup()
	{
		_elapsedDurationSeconds = 0f;
		base.IsDone__BackingField = false;
	}

	public override void Update(float unscaledDeltaTime)
	{
		float num = (_elapsedDurationSeconds += unscaledDeltaTime);
		if (!(_durationSeconds > num))
		{
			base.IsDone__BackingField = true;
		}
	}
}
