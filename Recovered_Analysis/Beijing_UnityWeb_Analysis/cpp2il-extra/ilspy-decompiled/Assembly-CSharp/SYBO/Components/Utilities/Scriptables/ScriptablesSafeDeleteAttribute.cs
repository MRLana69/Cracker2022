using System;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities.Scriptables;

public class ScriptablesSafeDeleteAttribute : Attribute
{
	public bool IsEnabled;

	public ScriptablesSafeDeleteAttribute()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F5BB");
	}
}
