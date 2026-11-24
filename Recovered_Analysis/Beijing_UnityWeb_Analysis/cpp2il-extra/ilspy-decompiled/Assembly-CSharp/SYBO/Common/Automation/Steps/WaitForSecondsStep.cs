using Cpp2ILInjected;
using SYBO.Subway;

namespace SYBO.Common.Automation.Steps;

public class WaitForSecondsStep : AutomationStep
{
	private float _durationSeconds;

	private float _elapsedDurationSeconds;

	public WaitForSecondsStep(float durationSeconds)
	{
		//IL_0015: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got F4
		//IL_00b9: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got F4
		if (!((Game)(object)this).IsRunningOnTutorialTrack)
		{
			object obj = (base.IsDone__BackingField ? 1 : 0) + 16;
			object obj2 = _durationSeconds << 2;
			object obj3 = obj + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj4 = default;
			if (obj4 != null)
			{
				float durationSeconds2 = _durationSeconds + 1f;
				_durationSeconds = durationSeconds2;
			}
			object obj5 = (base.IsDone__BackingField ? 1 : 0) + 16;
			object obj6 = _durationSeconds << 2;
			object obj7 = obj5 + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		}
	}

	public override void Cleanup()
	{
		//IL_005f: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			bool flag = base.IsDone__BackingField;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v4 (System.Boolean)+C]");
			if ((nint)obj2 < 0)
			{
				object obj3 = (base.IsDone__BackingField ? 1 : 0) + 16;
				object obj4 = obj << 2;
				object obj5 = obj3 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj6 = obj + 1;
				obj = obj6;
				continue;
			}
			break;
		}
	}

	public override void Update(float unscaledDeltaTime)
	{
		_durationSeconds = unscaledDeltaTime;
	}
}
