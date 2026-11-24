using System;
using System.Collections;
using Cpp2ILInjected;
using SYBO.Common.Benchmarking;
using SYBO.Subway.StateSystem.States;
using SYBO.Subway.UI;

namespace SYBO.Subway.Automation.Samplers;

public class ScreenOpenedSampler : IMetricSampler
{
	private bool _shouldSample;

	public void Initialize()
	{
	}

	public void Cleanup()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v30 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnNavigatedToScreen -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		Action<string> action2 = default;
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnPopupShown -= action2;
	}

	public bool Update(float unscaledDeltaTime)
	{
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f6: Expected I4, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v18 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v29 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23 (System.Boolean)+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v24+8]");
			if ((nint)0 != 0)
			{
				IEnumerator enumerator = ((PogostickState)this).RemovePickups(unscaledDeltaTime);
				return (byte)(int)enumerator != 0;
			}
		}
		_ = 0f;
		return false;
	}

	private void UIScreenController_OnNavigateToScreen(string screenId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = screenId & 1;
	}

	private void UIScreenController_OnPopupShown(string popupId)
	{
		if (!string.Equals(popupId, "IngameUI"))
		{
			_shouldSample = true;
		}
	}

	public unsafe ScreenOpenedSampler()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<string> action = default;
		object obj = action + 16;
		obj = this;
		nint num2 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15 (Il2CppClass<UIScreenController>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v30 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIScreenController.OnWillShowScreen += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(ScreenOpenedSampler.UIScreenController_OnPopupShown);
		object obj3 = action2 + 16;
		obj3 = this;
		UIScreenController.OnLastPopupClosed += action2;
	}
}
