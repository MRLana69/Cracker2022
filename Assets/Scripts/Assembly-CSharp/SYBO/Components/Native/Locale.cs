using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Native;

public class Locale
{
	private static AndroidJavaClass _nativePlugin;

	private static AndroidJavaClass NativePlugin
	{
		get
		{
			if (_nativePlugin == null)
			{
				AndroidJavaClass androidJavaClass = default;
				androidJavaClass._002Ector("com.SYBO.nativeplugin.LocaleAPI");
				_nativePlugin = androidJavaClass;
			}
			return _nativePlugin;
		}
	}

	public static string GetISOThreeLetterLanguageCode()
	{
		AndroidJavaClass nativePlugin = NativePlugin;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::CallStatic>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}
}
