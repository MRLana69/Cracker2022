namespace UnityEngine.Networking.NetworkSystem;

internal class ClientAuthorityMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public bool authority; //Field offset: 0xC

	public ClientAuthorityMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

