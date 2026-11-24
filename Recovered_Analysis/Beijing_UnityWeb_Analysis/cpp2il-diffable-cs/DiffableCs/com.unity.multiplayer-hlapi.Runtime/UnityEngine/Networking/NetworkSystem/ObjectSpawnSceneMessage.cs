namespace UnityEngine.Networking.NetworkSystem;

internal class ObjectSpawnSceneMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public NetworkSceneId sceneId; //Field offset: 0xC
	public Vector3 position; //Field offset: 0x10
	public byte[] payload; //Field offset: 0x1C

	public ObjectSpawnSceneMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

