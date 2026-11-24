using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

public class EnvironmentObject : MonoBehaviour
{
	private void Start()
	{
		_ = 3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	private void Update()
	{
	}
}
