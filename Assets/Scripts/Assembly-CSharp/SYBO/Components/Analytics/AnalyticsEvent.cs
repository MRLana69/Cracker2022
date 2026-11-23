using System;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public abstract class AnalyticsEvent
{
	protected string UserId;

	protected string EventId;

	public static Func<string> GetGameVersion;

	public static Func<DateTime> GetDeviceStartupTime;

	public static Func<string> GetUserId;

	public static Func<float> GetSamplingKey;

	public abstract string EventName { get; }

	public unsafe AnalyticsEvent()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected VT, but got Unknown
		//IL_0051: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		Guid guid = Guid.NewGuid();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		Guid guid2 = (Guid)(obj + 16);
		string eventId = ((Guid*)guid2)->ToString();
		EventId = eventId;
		Func<string> getUserId = GetUserId;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S1_v16 (System.Func`1<System.String>)+C] (should have been resolved before IL gen)");
		string userId = default;
		UserId = userId;
	}

	protected unsafe string GetEventTimeText()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected VT, but got Unknown
		//IL_002e: Expected F8, but got I8
		//IL_002e: Expected Ref, but got VT
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Func<DateTime> getDeviceStartupTime = GetDeviceStartupTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v7 (System.Func`1<System.DateTime>)+C] (should have been resolved before IL gen)");
		long msTicksSinceDeviceStartup = AnalyticsManager.GetMsTicksSinceDeviceStartup();
		DateTime dateTime = (DateTime)(obj + 8);
		DateTime time = ((DateTime*)dateTime)->AddMilliseconds(msTicksSinceDeviceStartup);
		return GetTimeText(time);
	}

	public unsafe static string GetTimeText(DateTime time)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected VT, but got Unknown
		//IL_0297: Expected Ref, but got VT
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		DateTime dateTime = (DateTime)(obj + 40);
		int year = ((DateTime*)dateTime)->Year;
		object obj3 = obj + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public override string ToString()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @252");
		object obj2 = default;
		object obj = obj2 - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v4+BC] (should have been resolved before IL gen)");
		string text = default;
		return text + " for user " + UserId;
	}
}
