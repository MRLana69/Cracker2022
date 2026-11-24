namespace UnityEngine.Networking.Match;

public class MatchInfoSnapshot
{
	public class MatchInfoDirectConnectSnapshot
	{
		private NodeID <nodeId>k__BackingField; //Field offset: 0x8
		private string <publicAddress>k__BackingField; //Field offset: 0xC
		private string <privateAddress>k__BackingField; //Field offset: 0x10
		private HostPriority <hostPriority>k__BackingField; //Field offset: 0x14

		private HostPriority hostPriority
		{
			 set { } //Length: 11
		}

		private NodeID nodeId
		{
			 set { } //Length: 47
		}

		private string privateAddress
		{
			 set { } //Length: 11
		}

		private string publicAddress
		{
			 set { } //Length: 8
		}

		internal MatchInfoDirectConnectSnapshot(MatchDirectConnectInfo matchDirectConnectInfo) { }

		private void set_hostPriority(HostPriority value) { }

		private void set_nodeId(NodeID value) { }

		private void set_privateAddress(string value) { }

		private void set_publicAddress(string value) { }

	}

	private NetworkID <networkId>k__BackingField; //Field offset: 0x8
	private NodeID <hostNodeId>k__BackingField; //Field offset: 0x10
	private string <name>k__BackingField; //Field offset: 0x14
	private int <averageEloScore>k__BackingField; //Field offset: 0x18
	private int <maxSize>k__BackingField; //Field offset: 0x1C
	private int <currentSize>k__BackingField; //Field offset: 0x20
	private bool <isPrivate>k__BackingField; //Field offset: 0x24
	private Dictionary<string, long> <matchAttributes>k__BackingField; //Field offset: 0x28
	private List<MatchInfoDirectConnectSnapshot> <directConnectInfos>k__BackingField; //Field offset: 0x2C

	private int averageEloScore
	{
		 set { } //Length: 11
	}

	private int currentSize
	{
		 set { } //Length: 8
	}

	public List<MatchInfoDirectConnectSnapshot> directConnectInfos
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	private NodeID hostNodeId
	{
		 set { } //Length: 637
	}

	private bool isPrivate
	{
		 set { } //Length: 8
	}

	private Dictionary<string, long> matchAttributes
	{
		 set { } //Length: 11
	}

	private int maxSize
	{
		 set { } //Length: 8
	}

	public string name
	{
		 get { } //Length: 291
		private set { } //Length: 8
	}

	public NetworkID networkId
	{
		 get { } //Length: 181
		private set { } //Length: 15
	}

	internal MatchInfoSnapshot(MatchDesc matchDesc) { }

	public List<MatchInfoDirectConnectSnapshot> get_directConnectInfos() { }

	public string get_name() { }

	public NetworkID get_networkId() { }

	private void set_averageEloScore(int value) { }

	private void set_currentSize(int value) { }

	private void set_directConnectInfos(List<MatchInfoDirectConnectSnapshot> value) { }

	private void set_hostNodeId(NodeID value) { }

	private void set_isPrivate(bool value) { }

	private void set_matchAttributes(Dictionary<string, long> value) { }

	private void set_maxSize(int value) { }

	private void set_name(string value) { }

	private void set_networkId(NetworkID value) { }

}

