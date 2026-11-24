namespace UnityEngine.Networking.Match;

internal class ListMatchResponse : BasicResponse
{
	public List<MatchDesc> matches; //Field offset: 0x10

	public ListMatchResponse() { }

	public override string ToString() { }

}

