namespace UnityEngine.Networking.NetworkSystem;

public class RemovePlayerMessage : MessageBase
{
	public short playerControllerId; //Field offset: 0x8

	public RemovePlayerMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

