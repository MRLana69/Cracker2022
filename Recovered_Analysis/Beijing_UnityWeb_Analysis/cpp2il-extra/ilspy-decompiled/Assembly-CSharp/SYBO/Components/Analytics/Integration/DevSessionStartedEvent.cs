using Cpp2ILInjected;

namespace SYBO.Components.Analytics.Integration;

public class DevSessionStartedEvent : SubwayBaseSessionEvent
{
	public readonly string OnlineSettings;

	public readonly string Branch;

	public readonly int Revision;

	public readonly int Modifications;

	public override string EventName => "unsampled_ingame_currency_purchases";

	public DevSessionStartedEvent(string onlineSettings, string branch, int revision, bool modifications)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = obj;
		_ = -1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Analytics.Integration.DevSessionStartedEvent)+45]");
		bool flag = (nint)0 != 0;
		object obj4 = flag & onlineSettings;
		if (obj4 != null)
		{
			object obj5 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj6 = default;
			object obj7 = default;
			if (obj6 == obj7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj9 = default;
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj11 = default;
				object obj10 = obj11;
			}
			else
			{
				object obj12 = default;
				object obj10 = obj12;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}
}
