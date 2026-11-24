using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.LocalizationManager;
using UnityEngine;

namespace Kiloo.Common.HTTP;

public static class TrustedRoots
{
	private static X509Certificate2Collection _trusted;

	public static void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static bool VerifyTrust(X509Certificate2 certificate)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		int current = default;
		int low = default;
		return NumberExtensions.IsBetween(current, low, int.MaxValue);
	}

	private static X509Certificate2Collection LoadTrusted()
	{
		//IL_008c: Expected I, but got Obj
		//IL_00a2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (LocaleData._instance != null)
		{
			_0021_00210[] instance = (_0021_00210[])(object)Resources.LoadAll<T>("Kiloo/LocalizationManager/LocaleData");
			LocaleData._instance = (LocaleData)(object)instance;
			LocaleData._instance._002Ector();
		}
		return (X509Certificate2Collection)(object)LocaleData._instance;
	}

	private static void LogError(string msg)
	{
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[TrustedRoots] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}
}
