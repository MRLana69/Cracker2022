using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.FreeStuff;

public static class RewardForVideoButtonHelper
{
	public static VideoButtonPayload[] rewards;

	private static Color32 SkyHighlight()
	{
		_ = 2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		Color32 result = default;
		return result;
	}

	private unsafe static Color32 SunHighlight()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected VT, but got Unknown
		//IL_00ff: Expected I4, but got Obj
		//IL_00fa: Expected native int or pointer, but got VT
		//IL_0134: Expected I4, but got Obj
		//IL_012f: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<UI.ColorData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v26 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj5 = (flag ? 1 : 0) + 28;
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v9+8]");
		_ = 0;
		Color32 color = (Color32)(obj2 + 32);
		((Color32*)(nint)color)->rgba = (int)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16+8]");
		_ = 0;
		Color color2 = color;
		obj = obj2;
		_ = -103;
		Color32 color3 = default;
		((Color32*)(nint)color3)->rgba = (int)obj;
		return color3;
	}

	static RewardForVideoButtonHelper()
	{
		//IL_016a: Expected I, but got Obj
		//IL_0180: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_01d0: Expected Obj, but got I4
		//IL_01dc: Expected I4, but got Obj
		//IL_011d: Expected I, but got Obj
		//IL_00cb: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		bool flag2;
		if (isShowingPopup)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v12 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		bool flag3 = !flag2;
		bool flag4 = isShowingPopup;
		if (!flag3)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v31 (Il2CppClass<UIScreenController>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = UIScreenController.ShouldShowOnlineScreen();
			IEnumerator enumerator = ((UIScreenController)flag5).DelayHideMainCamera();
			flag4 = (byte)(int)enumerator != 0;
		}
		if (flag4)
		{
		}
		nint num5 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v18 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v22 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
