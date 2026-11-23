using System;
using Cpp2ILInjected;

namespace SYBO.Components.Json;

public abstract class JsonCustomSerializer
{
	public virtual object Deserialize(JsonDict json, JsonContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return ex;
	}

	public virtual JsonDict Serialize(object obj, JsonContext context)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (JsonDict)(object)ex;
	}
}
