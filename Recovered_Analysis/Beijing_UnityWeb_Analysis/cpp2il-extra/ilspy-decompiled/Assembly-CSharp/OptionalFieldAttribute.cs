using System;
using Cpp2ILInjected;

public class OptionalFieldAttribute : Attribute
{
	public OptionalFieldAttribute()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
