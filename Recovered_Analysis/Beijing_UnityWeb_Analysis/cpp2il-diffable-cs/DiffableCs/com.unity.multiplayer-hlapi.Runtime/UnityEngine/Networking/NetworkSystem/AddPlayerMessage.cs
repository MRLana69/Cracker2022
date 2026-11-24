namespace UnityEngine.Networking.NetworkSystem;

public class AddPlayerMessage : MessageBase
{
	public short playerControllerId; //Field offset: 0x8
	public int msgSize; //Field offset: 0xC
	public byte[] msgData; //Field offset: 0x10

	public AddPlayerMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

