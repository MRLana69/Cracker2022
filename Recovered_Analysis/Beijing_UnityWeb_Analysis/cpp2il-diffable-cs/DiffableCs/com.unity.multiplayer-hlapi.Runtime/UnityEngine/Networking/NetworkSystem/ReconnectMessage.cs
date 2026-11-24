namespace UnityEngine.Networking.NetworkSystem;

public class ReconnectMessage : MessageBase
{
	public int oldConnectionId; //Field offset: 0x8
	public short playerControllerId; //Field offset: 0xC
	public NetworkInstanceId netId; //Field offset: 0x10
	public int msgSize; //Field offset: 0x14
	public byte[] msgData; //Field offset: 0x18

	public ReconnectMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

