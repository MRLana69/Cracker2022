namespace UnityEngine.Networking.NetworkSystem;

internal class ObjectSpawnFinishedMessage : MessageBase
{
	public uint state; //Field offset: 0x8

	public ObjectSpawnFinishedMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

