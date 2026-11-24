using Cpp2ILInjected;

namespace SYBO.Common.Automation.Steps;

public class WaitUntilDoneStep : AutomationStep
{
	public WaitUntilDoneStep()
	{
		_ = 0f;
		base.IsDone__BackingField = false;
	}

	public override void Update(float unscaledDeltaTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Automation.Steps.WaitUntilDoneStep)+10]");
		float num = 0f + unscaledDeltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Automation.Steps.WaitUntilDoneStep)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Automation.Steps.WaitUntilDoneStep)+C]");
		if (num2 >= 0)
		{
			base.IsDone__BackingField = true;
		}
	}

	public void MarkAsDone()
	{
	}
}
