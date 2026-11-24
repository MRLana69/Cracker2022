using System.Collections.Generic;
using Cpp2ILInjected;
using InApp;
using UI.Screens;
using UnityEngine;

namespace UI.DebugPopup;

public class InAppManagerDebugPopupDataEntries
{
	private static Dictionary<InAppManagerPopupType, InAppManagerPopupData> _appManagerPopupDatas;

	public static InAppManagerPopupData GetPopupData(InAppManagerPopupType inAppManagerPopupType)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		UIWidget component = ((Component)inAppManagerPopupType).GetComponent<UIWidget>();
		return (InAppManagerPopupData)component.mHeight;
	}

	public InAppManagerDebugPopupDataEntries()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	static InAppManagerDebugPopupDataEntries()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_0030: Expected Obj, but got I4
		//IL_003e: Expected I, but got Obj
		//IL_0054: Expected Obj, but got I
		UpgradeScreen.forceScrollRearange = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 59;
		nint num = (nint)typeof(UpgradeScreen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13 (Il2CppClass<UI.Screens.UpgradeScreen>)+5C]");
		object obj3 = (nint)0 + (nint)4;
		obj3 = obj2;
	}
}
