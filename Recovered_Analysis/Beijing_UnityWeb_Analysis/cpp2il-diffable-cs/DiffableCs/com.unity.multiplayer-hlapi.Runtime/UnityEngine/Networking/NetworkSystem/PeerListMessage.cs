namespace UnityEngine.Networking.NetworkSystem;

public class PeerListMessage : MessageBase
{
	public PeerInfoMessage[] peers; //Field offset: 0x8
	public int oldServerConnectionId; //Field offset: 0xC

	public PeerListMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

