namespace TopRun.Internal;

public class TournamentData
{
	public string id; //Field offset: 0x8
	public string country; //Field offset: 0xC
	public IList participants; //Field offset: 0x10
	public IList scoreMatchedParticipants; //Field offset: 0x14
	public Nullable<DateTime> participantsTimeStamp; //Field offset: 0x18
	public Nullable<DateTime> scoreMatchedParticipantsTimeStamp; //Field offset: 0x28
	public DateTime startTime; //Field offset: 0x38
	public DateTime endTime; //Field offset: 0x40
	public DateTime nextStartTime; //Field offset: 0x48
	public int sequenceId; //Field offset: 0x50
	public int unsubmittedScore; //Field offset: 0x54
	public int submittedScore; //Field offset: 0x58
	public bool closed; //Field offset: 0x5C
	public int rank; //Field offset: 0x60

	public TournamentData() { }

}

