namespace UnityEngine.Networking.NetworkSystem;

public class PeerInfoMessage : MessageBase
{
	public int connectionId; //Field offset: 0x8
	public string address; //Field offset: 0xC
	public int port; //Field offset: 0x10
	public bool isHost; //Field offset: 0x14
	public bool isYou; //Field offset: 0x15
	public PeerInfoPlayer[] playerIds; //Field offset: 0x18

	public PeerInfoMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

	public override string ToString() { }

}

