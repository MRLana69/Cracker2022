using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common.Automation;

public class AutomationController : Singleton<AutomationController>
{
	private IAutomationStepExecutor _executor;

	private bool _skipInitialFrame;

	public bool IsRunning => _executor != null;

	public void StartAutomation(IAutomationStepExecutor executor)
	{
		if (_executor == null)
		{
			_executor = executor;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			_skipInitialFrame = true;
		}
	}

	protected void Update()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_00c3: Expected Obj, but got I4
		if (_executor == null)
		{
			return;
		}
		if (~(_skipInitialFrame ? 1u : 0u) == 0)
		{
			_skipInitialFrame = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			return;
		}
		object obj = this + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj2 = default;
		if (obj2 == null)
		{
			float unscaledDeltaTime = Time.unscaledDeltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F46");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B7");
			obj = 0;
		}
	}
}
