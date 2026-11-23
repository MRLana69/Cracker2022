using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Inputs;

public class Swipe
{
	public Vector3 start;

	public Vector3 end;

	public float startTime;

	public float endTime;

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_005b: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Inputs.Swipe)+10]");
		_ = 0;
		_ = start;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Inputs.Swipe)+1C]");
		_ = 0;
		obj = end;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		return $"[Swipe (start:{arg}, end:{arg2}]";
	}
}
