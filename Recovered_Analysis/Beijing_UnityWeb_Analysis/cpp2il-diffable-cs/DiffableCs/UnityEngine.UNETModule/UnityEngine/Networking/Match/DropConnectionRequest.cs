namespace UnityEngine.Networking.Match;

internal class DropConnectionRequest : Request
{
	private NetworkID <networkId>k__BackingField; //Field offset: 0x20
	private NodeID <nodeId>k__BackingField; //Field offset: 0x28

	public NetworkID networkId
	{
		 get { } //Length: 382
		 set { } //Length: 2
	}

	public NodeID nodeId
	{
		 get { } //Length: 180
		 set { } //Length: 11
	}

	public DropConnectionRequest() { }

	public NetworkID get_networkId() { }

	public NodeID get_nodeId() { }

	public void set_networkId(NetworkID value) { }

	public void set_nodeId(NodeID value) { }

	public override string ToString() { }

}

