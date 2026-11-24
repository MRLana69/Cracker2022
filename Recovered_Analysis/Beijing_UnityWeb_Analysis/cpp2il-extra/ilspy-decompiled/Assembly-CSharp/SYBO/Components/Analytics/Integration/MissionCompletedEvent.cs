using System;
using Cpp2ILInjected;
using Info;

namespace SYBO.Components.Analytics.Integration;

public class MissionCompletedEvent : SubwayBaseSessionEvent
{
	public readonly string MissionSet;

	public readonly short MissionIndex;

	public readonly long SourceId;

	public override string EventName => "ab_test_segment_joined";

	public MissionCompletedEvent(string missionSet, short missionIndex, long sourceId)
	{
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_00bc: Expected I4, but got Obj
		//IL_00ce: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(ItemInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.ItemInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ItemInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Info.ItemInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string itemTitleId = ItemInfo.GetItemTitleId((Boards.BoardId)missionSet, HoverboardThemes.ThemeIdentifier.none);
		string text = string.ConcatArray((string[])(object)"skipcharacter_", (int)itemTitleId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		throw new ArrayTypeMismatchException();
	}
}
