namespace UnityEngine.Networking.Match;

internal class MatchDesc
{
	public ulong networkId; //Field offset: 0x8
	public string name; //Field offset: 0x10
	public int averageEloScore; //Field offset: 0x14
	public int maxSize; //Field offset: 0x18
	public int currentSize; //Field offset: 0x1C
	public bool isPrivate; //Field offset: 0x20
	public Dictionary<string, long> matchAttributes; //Field offset: 0x24
	public NodeID hostNodeId; //Field offset: 0x28
	public List<MatchDirectConnectInfo> directConnectInfos; //Field offset: 0x2C

	public MatchDesc() { }

	public override string ToString() { }

}

