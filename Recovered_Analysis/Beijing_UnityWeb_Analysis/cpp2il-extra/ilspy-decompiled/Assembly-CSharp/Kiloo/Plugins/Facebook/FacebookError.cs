using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kiloo.Plugins.Facebook;

public class FacebookError
{
	public enum Category
	{
		INVALID,
		AUTHENTICATION_RETRY,
		AUTHENTICATION_REOPEN_SESSION,
		PERMISSION,
		SERVER,
		THROTTLING,
		CANCELED,
		OTHER,
		BAD_REQUEST,
		CLIENT
	}

	public const int INVALID_ERROR_CODE = -1;

	public const int INVALID_HTTP_STATUS_CODE = -1;

	public Category category;

	public int requestStatusCode;

	public int errorCode;

	public int subErrorCode;

	public string errorType;

	public string errorMessage;

	public bool shouldNotifyUser;

	public string userActionMessage;

	public string exceptionType;

	public string exceptionMessage;

	public FacebookError()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public FacebookError(IDictionary<string, object> error)
	{
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		//IL_0092: Expected I, but got Obj
		//IL_0137: Expected Obj, but got I4
		//IL_002c: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj != null;
		if (error != null)
		{
			if (flag)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v24 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).ShowTransitionAdsOverlay();
			return;
		}
		if (flag)
		{
			nint num3 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v16 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3).HideAdsOverlay();
	}

	public override string ToString()
	{
		return "";
	}
}
