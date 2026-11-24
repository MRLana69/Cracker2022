using Cpp2ILInjected;
using SYBO.Components.Analytics;
using UnityEngine;

namespace UI.Helpers;

public class WelcomePackButtonHelper : MonoBehaviour
{
	private UILabel _timerLabel;

	public void OnWelcomePackButtonClicked()
	{
		CancelInvoke();
	}

	private void Update()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag)._ActivateNextPopup("WelcomePackPopup");
	}

	public WelcomePackButtonHelper()
	{
		//IL_0011: Expected Obj, but got I8
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		object obj = msTicksSinceDeviceStartup;
		object obj2 = obj + 8;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
		int fontSize = default;
		_timerLabel.fontSize = fontSize;
	}
}
