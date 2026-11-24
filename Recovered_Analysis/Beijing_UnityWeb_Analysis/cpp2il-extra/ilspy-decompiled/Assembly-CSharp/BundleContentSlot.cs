using System.Collections;
using Cpp2ILInjected;
using InApp;
using SYBO.Subway.Info;
using UnityEngine;

public class BundleContentSlot : MonoBehaviour
{
	private UILabel amountField;

	public void UpdateAmount(string amount)
	{
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_0346: Expected Obj, but got I4
		//IL_0272: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_038b: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_0186: Expected I, but got Obj
		//IL_019c: Expected Obj, but got I
		//IL_01c7: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v56 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		bool flag2 = enumerator == null;
		bool flag3 = !flag2;
		IEnumerator a = enumerator;
		if (!flag3)
		{
			a = (IEnumerator)(object)string.Empty;
		}
		bool flag4 = string.Equals((string)(object)a, "UpgradesUI_shop");
		object obj2 = (flag4 ? 1 : 0) ^ 1;
		object obj3 = obj2 | (object)amount;
		if (obj3 == null)
		{
			return;
		}
		nint num3 = (nint)typeof(SSEventsManagerController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21 (Il2CppClass<SSEventsManagerController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v48 (Il2CppClass<SSEventsManagerController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string flurryUserId = Flurry.flurryUserId;
		if (((SSEventsManagerController)(object)flurryUserId).DoesCharacterMatchCurrentEvent(Characters.CharacterId.slick))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj5 = default;
			if ((nint)obj5 == 4)
			{
				_ = 5;
				return;
			}
		}
		nint num5 = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (BundleContentSlot)+30]");
		if (!Object.IsNativeObjectAlive((Object)0))
		{
			return;
		}
		nint num7 = (nint)typeof(InAppManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v33 (Il2CppClass<InApp.InAppManager>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(InAppManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v40 (Il2CppClass<InApp.InAppManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (InAppManager.IsAnyCurrencyDiscountActive)
		{
			_ = 12;
		}
	}

	public BundleContentSlot()
	{
		CancelInvoke();
	}
}
