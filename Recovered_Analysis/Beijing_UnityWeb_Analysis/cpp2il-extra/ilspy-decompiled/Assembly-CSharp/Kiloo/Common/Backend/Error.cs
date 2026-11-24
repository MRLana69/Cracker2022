using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Backend;

[Serializable]
public class Error
{
	public string category;

	public int code = 96;

	public string message;

	public string exception;

	public Dictionary<string, string> info;

	public override string ToString()
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CultureInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string str = ((string)this).ToLowerInvariant();
		TextInfo textInfo = default;
		return (string)textInfo.GetCaseInsensitiveHashCode(str);
	}

	public ErrorCategory GetErrorCategory()
	{
		//IL_00d1: Expected Obj, but got I4
		//IL_0101: Expected I4, but got Obj
		if (exception != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
		object obj = code;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"{0} error {1}: {2}", category, arg, message);
		return (ErrorCategory)text;
	}

	public static ErrorCategory GetErrorCategory(string category)
	{
		//IL_000e: Expected Obj, but got I4
		return ((EventRemoteLogger)category.m_stringLength).isSending ? ErrorCategory.HTTP : ErrorCategory.Unknown;
	}

	public Error()
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got F4
		//IL_0048: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_00bb: Expected Obj, but got F4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected Obj, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 16;
		object obj2 = default;
		obj = obj2;
		int height = Screen.height;
		int sleepTimeout = Screen.sleepTimeout;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = 0;
		_ = 0;
		obj3 = 20f;
		_ = 20f;
		object obj5 = height - 40;
		object obj6 = sleepTimeout - 40;
		object obj7 = obj4 + 32;
		obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+8]");
		_ = 0;
		object obj8 = this + 32;
		obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
		_ = 0;
		obj4 = 0;
		_ = 0;
		obj4 = 0f;
		_ = 0f;
		_ = 10000f;
		_ = 20f;
		obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = this + 48;
		obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v26+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GUIContent gUIContent = default;
		GUILayout.DoLabel(gUIContent, (GUIStyle)"Hide", (GUILayoutOption[])(object)"Hide the console window");
		object obj10 = this - -64;
		obj10 = gUIContent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GUIContent gUIContent2 = default;
		GUILayout.DoLabel(gUIContent2, (GUIStyle)"Clear", (GUILayoutOption[])(object)"Clear the contents of the console.");
		object obj11 = this + 68;
		obj11 = gUIContent2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GUIContent gUIContent3 = default;
		GUILayout.DoLabel(gUIContent3, (GUIStyle)"Collapse", (GUILayoutOption[])(object)"Hide repeated messages.");
		object obj12 = this + 72;
		obj12 = gUIContent3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
