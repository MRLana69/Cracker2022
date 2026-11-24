using Cpp2ILInjected;
using SYBO.Common.Automation.Steps;
using UnityEngine.Networking;

namespace SYBO.Subway.Automation.Steps;

public class StartGameAndWaitStep : WaitForSecondsStep
{
	public StartGameAndWaitStep(float durationSeconds)
	{
		//IL_00cc: Expected I, but got Obj
		//IL_00e2: Expected Obj, but got I
		//IL_0139: Expected Obj, but got I4
		//IL_015a: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I4
		//IL_00b2: Expected Obj, but got I
		//IL_00b2: Expected Obj, but got I
		nint num = (nint)typeof(Layers);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Layers>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Layers>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool startupFinished = LoadLevelCtrl.StartupFinished;
		bool startupFinished2 = LoadLevelCtrl.StartupFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.StartGameAndWaitStep)+9]");
		string method = (string)((((nint)0 != 0) ? 1 : 0) ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+14]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v4 (System.Boolean)+C]");
		((UnityWebRequest)num3)._002Ector((string)0, method);
		bool startupFinished3 = LoadLevelCtrl.StartupFinished;
		bool startupFinished4 = LoadLevelCtrl.StartupFinished;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Automation.Steps.StartGameAndWaitStep)+9]");
		string method2 = (string)((((nint)0 != 0) ? 1 : 0) ^ 1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v14 (System.Boolean)+14]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v7 (System.Boolean)+1C]");
		((UnityWebRequest)num4)._002Ector((string)0, method2);
		((AutomationStep)this).IsDone__BackingField = true;
	}

	public override void Update(float unscaledDeltaTime)
	{
		base._durationSeconds = unscaledDeltaTime;
	}
}
