using System;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Json;

public abstract class JsonCustomSerializer
{
	public virtual object Deserialize(JsonDict json, JsonContext context)
	{
		return JsonReflectionParser.RecursiveReadValue((Type)(object)this, (object)json, context);
	}

	public virtual JsonDict Serialize(object obj, JsonContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}

	public virtual object DeserializeList(JsonList jsonList, JsonContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}

	public virtual JsonList SerializeList(object obj, JsonContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return null;
	}

	protected JsonCustomSerializer()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonReflectionException ex = default;
		ex._002Ector();
		object obj = this + 8;
		obj = ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonDict jsonDict = default;
		jsonDict._002Ector();
		object obj2 = this + 12;
		obj2 = jsonDict;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 24;
		object obj4 = default;
		obj3 = obj4;
	}
}
