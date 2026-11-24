namespace TopRun.Internal;

public class ManagerData
{
	public string country; //Field offset: 0x8
	public TournamentData currentTournament; //Field offset: 0xC
	public string localPlayerPrivateKey; //Field offset: 0x10
	public string localPlayerPublicKey; //Field offset: 0x14
	public string localPlayerFacebookId; //Field offset: 0x18
	public string lastSubmittedScoreCountry; //Field offset: 0x1C
	public DateTime lastSubmittedScoreStartTime; //Field offset: 0x20
	public DateTime lastSubmittedScoreEndTime; //Field offset: 0x28
	public Nullable<DateTime> nextTournamentTime; //Field offset: 0x30
	public TournamentData previousTournament; //Field offset: 0x40
	public int unsubmittedScoreNoTournament; //Field offset: 0x44
	public Nullable<DateTime> unsubmittedScoreNoTournamentTime; //Field offset: 0x48

	public ManagerData() { }

}

