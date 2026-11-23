using SYBO.Common.Automation.Steps;

namespace SYBO.Subway.Automation.Steps;

public class WaitForHomeScreenStep : AutomationStep
{
	public override void Update(float unscaledDeltaTime)
	{
		UIScreenController instance = UIScreenController.Instance;
		string topScreenName = instance.GetTopScreenName();
		if (topScreenName.Equals("FrontUI"))
		{
			base.IsDone__BackingField = true;
		}
	}
}
