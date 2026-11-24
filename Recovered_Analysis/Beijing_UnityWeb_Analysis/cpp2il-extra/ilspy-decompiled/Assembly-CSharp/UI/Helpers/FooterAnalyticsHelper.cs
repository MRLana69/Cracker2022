using Cpp2ILInjected;
using UnityEngine;

namespace UI.Helpers;

public class FooterAnalyticsHelper : MonoBehaviour
{
	private string _buttonName;

	private string[] GetButtonNames()
	{
		//IL_005d: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Helpers.FooterAnalyticsHelper)+10]");
		if ((nint)0 == 3)
		{
			return (string[])1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Helpers.FooterAnalyticsHelper)+10]");
		bool flag = (nint)0 == 5;
		return (string[])flag;
	}

	private void OnClick()
	{
		//IL_000b: Expected Obj, but got F4
		_buttonName = (string)225f;
		_ = 110f;
		CancelInvoke();
	}

	public FooterAnalyticsHelper()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
