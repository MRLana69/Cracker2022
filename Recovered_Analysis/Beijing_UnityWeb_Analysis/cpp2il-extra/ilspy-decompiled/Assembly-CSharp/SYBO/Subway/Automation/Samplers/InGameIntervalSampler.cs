using System.Collections;
using Cpp2ILInjected;
using SYBO.Common.Automation.Samplers;

namespace SYBO.Subway.Automation.Samplers;

public class InGameIntervalSampler : IntervalSampler
{
	public InGameIntervalSampler(float sampleInterval)
	{
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0076: Expected F4, but got I4
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator a = ((UIScreenController)flag).DelayHideMainCamera();
		if (string.Equals((string)(object)a, "FrontScreen"))
		{
			base._sampleInterval = 1f;
		}
	}

	public override bool Update(float unscaledDeltaTime)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		return flag;
	}
}
