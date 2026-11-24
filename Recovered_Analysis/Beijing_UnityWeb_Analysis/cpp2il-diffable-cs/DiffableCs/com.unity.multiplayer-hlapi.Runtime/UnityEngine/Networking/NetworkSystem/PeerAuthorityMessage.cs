namespace UnityEngine.Networking.NetworkSystem;

public class PeerAuthorityMessage : MessageBase
{
	public int connectionId; //Field offset: 0x8
	public NetworkInstanceId netId; //Field offset: 0xC
	public bool authorityState; //Field offset: 0x10

	public PeerAuthorityMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

