using Cpp2ILInjected;
using UI.MessageCenter;

public class DescriptionButtonHelper : UIBasicButton
{
	public override void Send()
	{
		CancelInvoke();
	}

	public DescriptionButtonHelper()
	{
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_026f: Expected Obj, but got I4
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_012e: Expected I, but got Obj
		//IL_0253: Expected Obj, but got I4
		//IL_00c8: Expected I, but got Obj
		//IL_01bc: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		bool flag2 = (string)isShowingPopup != "UpgradesUI_quick";
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v7 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag3 = obj2 != null;
		if (flag2)
		{
			if (flag3)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag4).QueuePopup("PrizeMBPopup_Keys");
		}
		else
		{
			if (flag3)
			{
				nint num5 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v28 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag5)._ActivateNextPopup("PrizeMBPopup_Keys");
		}
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v16 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v20 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
