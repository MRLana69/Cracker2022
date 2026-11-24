using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Logging;

public class LogDefault : LogCategory
{
	public LogDefault(int categoryId)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 24;
		Vector2 mouseScrollDelta = Input.mouseScrollDelta;
		obj = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
		_ = 0;
		object obj4 = obj2 + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
		_ = 0;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		LogDefault logDefault = (LogDefault)0;
		logDefault = (LogDefault)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		_ = 0;
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_0019: Expected Obj, but got I4
		string categoryText = CategoryText;
		return (string[])categoryText.m_firstChar;
	}
}
