using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Proyecto26;

public static class JsonHelper
{
	[Serializable]
	private class Wrapper<T>
	{
		public T[] Items;
	}

	public static T[] ArrayFromJson<T>(string json)
	{
		//IL_0047: Expected Obj, but got I
		string text = "{ \"Items\": " + json + "}";
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S2_v5 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.JsonHelper::ArrayFromJson>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v8+8]");
		return (T[])0;
	}

	public static T[] FromJsonString<T>(string json)
	{
		//IL_002b: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v8 @ S2_v3 (Il2CppClass<Il2CppMethodRgctx<Proyecto26.JsonHelper::FromJsonString>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S0_v2+8]");
		return (T[])0;
	}

	public static string ArrayToJsonString<T>(T[] array)
	{
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.JsonHelper::ArrayToJsonString>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		object obj2 = default;
		return JsonUtility.ToJson(obj2);
	}

	public static string ArrayToJsonString<T>(T[] array, bool prettyPrint)
	{
		//IL_002b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v2 (Il2CppMethodRgctx<Proyecto26.JsonHelper::ArrayToJsonString>)+4]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v12 @ S2_v3+4] (should have been resolved before IL gen)");
		object obj2 = default;
		return JsonUtility.ToJson(obj2, prettyPrint);
	}
}
