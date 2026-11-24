namespace UnityEngine.Networking.NetworkSystem;

internal class ObjectSpawnMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public NetworkHash128 assetId; //Field offset: 0xC
	public Vector3 position; //Field offset: 0x1C
	public byte[] payload; //Field offset: 0x28
	public Quaternion rotation; //Field offset: 0x2C

	public ObjectSpawnMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

