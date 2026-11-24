namespace UnityEngine.Networking.NetworkSystem;

internal class ObjectDestroyMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8

	public ObjectDestroyMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

