using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.LocalizationManager;

public class TermKeys : ScriptableObject
{
	public List<string> keys;

	public TermKeys()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		object obj = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3+60]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36 @ S4_v4 (should have been resolved before IL gen)");
		object obj8 = this + 16;
		object obj9 = default;
		obj8 = obj9;
		ScriptableObject.CreateScriptableObject((ScriptableObject)this);
	}
}
