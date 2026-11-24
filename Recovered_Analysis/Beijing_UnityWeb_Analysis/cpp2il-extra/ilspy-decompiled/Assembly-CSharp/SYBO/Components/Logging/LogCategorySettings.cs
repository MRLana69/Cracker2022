using System;
using Cpp2ILInjected;

namespace SYBO.Components.Logging;

[Serializable]
public class LogCategorySettings
{
	public string categoryText = (string)0.1f;

	public string categoryClassName;

	public bool pauseOnError;

	public bool pauseOnWarning;

	public int logLevel;

	public int hideStackLevel;

	public string messagePrefix;

	public bool hasInitializedMessagePrefix;

	public LogCategorySettings()
	{
		//IL_0024: Expected Obj, but got F4
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v3+60]");
		object obj2 = (object)((object)0 & 0x1FFF) + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S4_v4 (should have been resolved before IL gen)");
		object obj3 = this + 12;
		object obj4 = default;
		obj3 = obj4;
		object obj5 = this + 16;
		obj5 = "\\\\sybonas.sybogames.local\\Logs\\Brim\\UnityLogs\\{0}";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		LogGUI logGUI = default;
		logGUI._002Ector();
		object obj6 = this + 20;
		obj6 = logGUI;
	}
}
