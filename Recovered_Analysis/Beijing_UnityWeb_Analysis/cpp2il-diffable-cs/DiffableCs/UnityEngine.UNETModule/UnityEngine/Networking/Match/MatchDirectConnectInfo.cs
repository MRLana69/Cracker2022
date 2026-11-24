namespace UnityEngine.Networking.Match;

internal class MatchDirectConnectInfo
{
	public NodeID nodeId; //Field offset: 0x8
	public string publicAddress; //Field offset: 0xC
	public string privateAddress; //Field offset: 0x10
	public HostPriority hostPriority; //Field offset: 0x14

	public MatchDirectConnectInfo() { }

	public override string ToString() { }

}

