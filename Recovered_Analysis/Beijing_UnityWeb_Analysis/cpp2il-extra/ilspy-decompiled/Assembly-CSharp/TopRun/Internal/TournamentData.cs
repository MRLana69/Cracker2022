using System;
using System.Collections;
using Cpp2ILInjected;

namespace TopRun.Internal;

public class TournamentData
{
	public string id;

	public string country;

	public IList participants;

	public IList scoreMatchedParticipants;

	public DateTime? participantsTimeStamp;

	public DateTime? scoreMatchedParticipantsTimeStamp;

	public DateTime startTime;

	public DateTime endTime;

	public DateTime nextStartTime;

	public int sequenceId;

	public int unsubmittedScore;

	public int submittedScore;

	public bool closed;

	public int rank;

	public TournamentData()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = this + 12;
		object obj7 = default;
		obj6 = obj7;
	}
}
