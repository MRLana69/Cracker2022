using Cpp2ILInjected;
using UnityEngine;

namespace UI.Generic.Layout;

public class IgnoreLayout : MonoBehaviour
{
	public IgnoreLayout()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @84C8");
	}
}
