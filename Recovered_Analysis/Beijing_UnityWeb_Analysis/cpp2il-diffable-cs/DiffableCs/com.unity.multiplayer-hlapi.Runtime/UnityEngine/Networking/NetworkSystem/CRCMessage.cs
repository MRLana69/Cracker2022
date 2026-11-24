namespace UnityEngine.Networking.NetworkSystem;

internal class CRCMessage : MessageBase
{
	public CRCMessageEntry[] scripts; //Field offset: 0x8

	public CRCMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

