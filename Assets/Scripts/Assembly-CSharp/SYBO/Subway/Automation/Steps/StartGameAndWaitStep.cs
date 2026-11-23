using Cpp2ILInjected;
using SYBO.Common.Automation.Steps;

namespace SYBO.Subway.Automation.Steps;

public class StartGameAndWaitStep : WaitForSecondsStep
{
	public StartGameAndWaitStep(float durationSeconds)
	{
		base._durationSeconds = durationSeconds;
	}

	public override void Update(float unscaledDeltaTime)
	{
		Game instance = Game.Instance;
		Variable<bool> isInGame = instance.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Variable`1<System.Boolean>)+8]");
		if ((nint)0 == 0)
		{
			Game instance2 = Game.Instance;
			instance2.StartNewGame(duel: false);
			UIScreenController instance3 = UIScreenController.Instance;
			instance3.PushScreen("IngameUI");
		}
		float num = (base._elapsedDurationSeconds += unscaledDeltaTime);
		if (!(base._durationSeconds > num))
		{
			((AutomationStep)this).IsDone__BackingField = true;
		}
	}
}
