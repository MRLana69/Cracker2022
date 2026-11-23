using System;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Json;

public class JsonApi
{
	public static int BuilderCapacity
	{
		get
		{
			return JsonParser.BuilderCapacity;
		}
		set
		{
			JsonParser.BuilderCapacity = value;
		}
	}

	public static T Deserialize<T>(string json, JsonContext context = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.JsonApi::Deserialize>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static string Serialize<T>(T obj, JsonContext context = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.JsonApi::Serialize>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public static object DeserializeDom(string json)
	{
		return JsonParser.DeserializeDom(json);
	}

	public static string SerializeDom(object json, JsonContext context = null)
	{
		JsonContext jsonContext = default;
		JsonContext jsonContext2 = default;
		if (jsonContext == null)
		{
			jsonContext2._002Ector();
		}
		return JsonParser.SerializeDom(json, jsonContext2);
	}

	public static T ReflectionDeserializeDom<T>(object jsonobj, JsonContext context = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.JsonApi::ReflectionDeserializeDom>>)+4] (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static object ReflectionSerializeDom<T>(T data, JsonContext context = null)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<SYBO.Components.Json.JsonApi::ReflectionSerializeDom>>)+4] (should have been resolved before IL gen)");
		object result = default;
		return result;
	}

	public static object ReflectionDeserializeDomAsType(Type objType, JsonDict json, JsonContext context = null)
	{
		return JsonReflectionParser.ReflectionDeserialize(objType, json, context);
	}

	public static JsonDict ReflectionSerializeDomAsType(Type objType, object obj, JsonContext context = null)
	{
		return JsonReflectionParser.ReflectionSerialize(objType, obj, context);
	}

	public static bool LastDecodeSuccessful()
	{
		return JsonParser.LastDecodeSuccessful();
	}

	public static int GetLastErrorIndex()
	{
		return JsonParser._lastErrorIndex;
	}

	public static string GetLastErrorSnippet()
	{
		return JsonParser.GetLastErrorSnippet();
	}
}
