using System;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Common.Automation;

public class AutomationController : SingletonMonoBehaviour<AutomationController>
{
	private IAutomationStepExecutor _executor;

	private bool _skipInitialFrame;

	public bool IsRunning
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public void StartAutomation(IAutomationStepExecutor executor)
	{
		//IL_001a: Expected I4, but got Obj
		//IL_001a: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Automation.AutomationController)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Automation.AutomationController)+1C]");
			((Action<bool>)0)((byte)(int)executor != 0);
		}
	}

	protected void Update()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public AutomationController()
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		if (_executor == null)
		{
			return;
		}
		if (~(_skipInitialFrame ? 1u : 0u) == 0)
		{
			_skipInitialFrame = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if (obj == null)
		{
			float fixedDeltaTime = Time.fixedDeltaTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			object obj3 = this + 16;
			obj3 = 0;
		}
	}
}
