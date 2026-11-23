using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Common.Automation;

public class AutomationStepExecutor : IAutomationStepExecutor
{
	protected IAutomationStep[] _steps;

	private int _currentStepIndex;

	private IAutomationStep _currentStep;

	private float _startTime;

	public virtual bool RequiresConfirmation => false;

	public virtual string ConfirmationMessage => string.Empty;

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

	public float ElapsedDuration
	{
		get
		{
			float realtimeSinceStartup = Time.realtimeSinceStartup;
			return realtimeSinceStartup - _startTime;
		}
	}

	public AutomationStepExecutor(IAutomationStep[] steps)
	{
		_steps = steps;
	}

	public virtual void Initialize()
	{
		//IL_006e: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		object obj = 0;
		IAutomationStep[] steps;
		while (true)
		{
			steps = _steps;
			if (steps.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)steps + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			object obj4 = obj + 1;
			obj = obj4;
		}
		_currentStepIndex = 0;
		_currentStep = steps[0];
	}

	public virtual void StartExecution()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		_startTime = realtimeSinceStartup;
	}

	public virtual void Terminate()
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

	public virtual void Update(float unscaledDeltaTime)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I
		if (!IsDone)
		{
			int num = _currentStepIndex << 2;
			object obj = _steps + num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj2 = default;
			if (obj2 != null)
			{
				int num2 = ++_currentStepIndex << 2;
				object obj3 = _steps + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v14+10]");
				_currentStep = (IAutomationStep)0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		}
	}
}
