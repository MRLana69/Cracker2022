using Cpp2ILInjected;
using UnityEngine;

public class customData : ScriptableObject
{
	public new string name;

	public customData()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
