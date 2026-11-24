namespace UnityEngine.Networking.NetworkSystem;

internal class OverrideTransformMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public byte[] payload; //Field offset: 0xC
	public bool teleport; //Field offset: 0x10
	public int time; //Field offset: 0x14

	public OverrideTransformMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

