using Cpp2ILInjected;
using SYBO.Components.Utilities.Validators;
using UnityEngine.Networking;

namespace SYBO.Common.Automation;

public class AutomationStepExecutor : IAutomationStepExecutor
{
	protected IAutomationStep[] _steps;

	private int _currentStepIndex;

	private IAutomationStep _currentStep;

	private float _startTime;

	public virtual bool RequiresConfirmation => _currentStep != null;

	public virtual string ConfirmationMessage => null;

	public bool IsDone
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)string.Empty != 0;
		}
	}

	public float ElapsedDuration
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0018: Expected F4, but got I
			object obj = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			return 0f;
		}
	}

	public AutomationStepExecutor(IAutomationStep[] steps)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_003d: Expected F4, but got I4
		if (_currentStep != null)
		{
			SDebug.LogFormat("Can only run one automation at a time. Cancelling new automation.", null);
			return;
		}
		object obj = this + 16;
		obj = steps;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		_startTime = 1f;
	}

	public virtual void Initialize()
	{
		((Validator<>)this)._002Ector();
	}

	public virtual void StartExecution()
	{
		//IL_00aa: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			IAutomationStep[] steps = _steps;
			if ((nint)obj >= steps.Length)
			{
				break;
			}
			object obj2 = _steps + 16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			object obj5 = obj + 1;
			obj = obj5;
		}
		_currentStepIndex = 0;
		object obj6 = this + 16;
		object obj7 = _steps + 16;
		int num = _currentStepIndex << 2;
		object obj8 = obj7 + num;
		obj6 = obj8;
	}

	public virtual void Terminate()
	{
		float maxDelay = NetworkServer.maxDelay;
		_startTime = maxDelay;
	}

	public virtual void Update(float unscaledDeltaTime)
	{
	}
}
