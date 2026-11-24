using Cpp2ILInjected;

namespace SYBO.Common.Automation.Steps;

public class CompoundAutomationStep : IAutomationStep
{
	private IAutomationStep[] _steps;

	private int _currentStepIndex;

	public bool IsDone => _steps != null;

	public CompoundAutomationStep(IAutomationStep[] steps)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		IAutomationStep[] steps2 = (IAutomationStep[])(steps & 1);
		_steps = steps2;
	}

	public virtual void Initialize()
	{
	}

	public virtual void Cleanup()
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			IAutomationStep[] steps = _steps;
			if ((nint)obj < steps.Length)
			{
				object obj2 = _steps + 16;
				object obj3 = obj << 2;
				object obj4 = obj2 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj5 = obj + 1;
				obj = obj5;
				continue;
			}
			break;
		}
	}

	public void Update(float unscaledDeltaTime)
	{
		//IL_000a: Expected Obj, but got F4
		_steps = (IAutomationStep[])unscaledDeltaTime;
	}
}
