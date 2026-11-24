namespace UnityEngine.Networking.Match;

internal class JoinMatchResponse : BasicResponse
{
	public string address; //Field offset: 0x10
	public int port; //Field offset: 0x14
	public int domain; //Field offset: 0x18
	public ulong networkId; //Field offset: 0x20
	public string accessTokenString; //Field offset: 0x28
	public NodeID nodeId; //Field offset: 0x2C
	public bool usingRelay; //Field offset: 0x2E

	public JoinMatchResponse() { }

	public override string ToString() { }

}

