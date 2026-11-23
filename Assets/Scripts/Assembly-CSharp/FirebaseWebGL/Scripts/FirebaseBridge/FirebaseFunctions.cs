using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Proyecto26;
using RSG;

namespace FirebaseWebGL.Scripts.FirebaseBridge;

public static class FirebaseFunctions
{
	public static void CallCloudFunction(string functionName, Dictionary<string, string> parameters, Action<ResponseHelper> callback, Action<Exception> fallback)
	{
		//IL_007a: Expected Obj, but got I
		string currentProjectId = GetCurrentProjectId();
		RequestHelper requestHelper = default;
		requestHelper._002Ector();
		requestHelper._method = "POST";
		string uri = "https://us-central1-" + currentProjectId + ".cloudfunctions.net/" + functionName;
		requestHelper._uri = uri;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S4_v5 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v69 @ S5_v5+4] (should have been resolved before IL gen)");
		Dictionary<string, string> headers = default;
		requestHelper._headers = headers;
		requestHelper._params = parameters;
		IPromise<ResponseHelper> promise = RestClient.Request(requestHelper);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @250");
	}

	[PreserveSig]
	private static extern string GetCurrentProjectId();
}
