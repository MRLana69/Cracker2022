namespace UnityEngine.Networking.Match;

public class MatchInfo
{
	private string <address>k__BackingField; //Field offset: 0x8
	private int <port>k__BackingField; //Field offset: 0xC
	private int <domain>k__BackingField; //Field offset: 0x10
	private NetworkID <networkId>k__BackingField; //Field offset: 0x18
	private NetworkAccessToken <accessToken>k__BackingField; //Field offset: 0x20
	private NodeID <nodeId>k__BackingField; //Field offset: 0x24
	private bool <usingRelay>k__BackingField; //Field offset: 0x26

	private NetworkAccessToken accessToken
	{
		 set { } //Length: 8
	}

	public string address
	{
		 get { } //Length: 70
		private set { } //Length: 140
	}

	public int domain
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	public NetworkID networkId
	{
		 get { } //Length: 181
		private set { } //Length: 705
	}

	public NodeID nodeId
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public int port
	{
		 get { } //Length: 6
		private set { } //Length: 11
	}

	public bool usingRelay
	{
		 get { } //Length: 6
		private set { } //Length: 8
	}

	internal MatchInfo(CreateMatchResponse matchResponse) { }

	internal MatchInfo(JoinMatchResponse matchResponse) { }

	public string get_address() { }

	public int get_domain() { }

	public NetworkID get_networkId() { }

	public NodeID get_nodeId() { }

	public int get_port() { }

	public bool get_usingRelay() { }

	private void set_accessToken(NetworkAccessToken value) { }

	private void set_address(string value) { }

	private void set_domain(int value) { }

	private void set_networkId(NetworkID value) { }

	private void set_nodeId(NodeID value) { }

	private void set_port(int value) { }

	private void set_usingRelay(bool value) { }

	public override string ToString() { }

}

