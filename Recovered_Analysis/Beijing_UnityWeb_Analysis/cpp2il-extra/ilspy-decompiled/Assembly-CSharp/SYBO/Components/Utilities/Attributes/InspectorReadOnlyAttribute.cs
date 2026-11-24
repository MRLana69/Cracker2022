using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities.Attributes;

public class InspectorReadOnlyAttribute : PropertyAttribute
{
	public InspectorReadOnlyAttribute()
	{
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
