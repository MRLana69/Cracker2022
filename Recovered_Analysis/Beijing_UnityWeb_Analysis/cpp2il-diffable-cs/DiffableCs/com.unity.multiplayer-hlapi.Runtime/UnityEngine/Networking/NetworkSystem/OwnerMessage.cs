namespace UnityEngine.Networking.NetworkSystem;

internal class OwnerMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public short playerControllerId; //Field offset: 0xC

	public OwnerMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

