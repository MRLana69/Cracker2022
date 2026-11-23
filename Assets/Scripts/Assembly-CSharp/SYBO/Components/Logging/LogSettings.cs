using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Events;

namespace SYBO.Components.Logging;

[Serializable]
public class LogSettings
{
	public float MemoryBudget = 0.1f;

	public Dictionary<string, LogCategorySettings> Categories;

	public string LogsPathWin = "\\\\sybonas.sybogames.local\\Logs\\Brim\\UnityLogs\\{0}";

	public LogFTPSettings Ftp;

	[NonSerialized]
	public UnityEvent Changed;

	public unsafe int GetLogLevel(string categoryName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_0061: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (HasLogLevel(categoryName) && Categories.TryGetValue(categoryName, out *(LogCategorySettings*)(obj + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			object obj3 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20+14]");
		return 0;
	}

	public unsafe bool HasLogLevel(string categoryName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (Categories != null)
		{
			return Categories.TryGetValue(categoryName, out *(LogCategorySettings*)(obj + 12));
		}
		bool result = default;
		return result;
	}
}
