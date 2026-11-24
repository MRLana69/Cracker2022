using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Common.Automation.Steps;

namespace SYBO.Subway.Automation.Steps;

public class SetCollisionsStep : AutomationStep
{
	private bool _enable;

	public SetCollisionsStep(bool enable)
	{
		//IL_0016: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [enable @ L1 (System.Boolean)+8C]");
		object obj = (nint)0 + (nint)32;
		SetCollisionsStep setCollisionsStep = (SetCollisionsStep)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S1_v3+8]");
		base.IsDone__BackingField = false;
	}

	public override void Update(float unscaledDeltaTime)
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_0209: Expected I4, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I4
		//IL_026d: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		if (~(_enable ? 1u : 0u) == 0)
		{
			nint num = (nint)typeof(SaveMeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v35 (Il2CppClass<SaveMeManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SaveMeManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v42 (Il2CppClass<SaveMeManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72BF");
			UpgradeType type = default;
			InventorySave.IncreaseAmount(type, (int)"Revive");
			base.IsDone__BackingField = true;
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v9 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v30 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		if (!((UIScreenController)flag).IsPopupQueueEmpty())
		{
			return;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v26 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag2).isShowingPopup;
		if (string.Equals((string)isShowingPopup, "SaveMePopup"))
		{
			_enable = true;
		}
	}
}
