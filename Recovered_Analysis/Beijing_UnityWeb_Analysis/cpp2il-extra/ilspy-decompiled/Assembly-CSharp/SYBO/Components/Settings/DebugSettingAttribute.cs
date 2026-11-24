using System;
using Cpp2ILInjected;

namespace SYBO.Components.Settings;

public class DebugSettingAttribute : Attribute
{
	public DebugSettingAttribute()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
