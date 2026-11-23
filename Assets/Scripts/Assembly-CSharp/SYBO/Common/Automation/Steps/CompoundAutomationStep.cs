using Cpp2ILInjected;

namespace SYBO.Common.Automation.Steps;

public class CompoundAutomationStep : IAutomationStep
{
	private IAutomationStep[] _steps;

	private int _currentStepIndex;

	public bool IsDone
	{
		get
		{
			//IL_001b: Expected Obj, but got I4
			IAutomationStep[] steps = _steps;
			if (steps.Length == 0)
			{
				return true;
			}
			object obj = steps.Length - 1;
			object obj2 = obj << 2;
			object obj3 = (object)steps + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			bool result = default;
			return result;
		}
	}

	public CompoundAutomationStep(IAutomationStep[] steps)
	{
		_steps = steps;
	}

	public virtual void Initialize()
	{
		//IL_004f: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			IAutomationStep[] steps = _steps;
			if (steps.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)steps + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			break;
		}
	}

	public virtual void Cleanup()
	{
		//IL_004f: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			IAutomationStep[] steps = _steps;
			if (steps.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)steps + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			break;
		}
	}

	public void Update(float unscaledDeltaTime)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		if (!IsDone)
		{
			int num = _currentStepIndex << 2;
			object obj = _steps + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj2 = default;
			bool flag = obj2 == null;
			int num2 = _currentStepIndex;
			if (!flag)
			{
				num2 = ++_currentStepIndex;
			}
			int num3 = num2 << 2;
			object obj3 = _steps + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		}
	}
}
