namespace UnityEngine.Networking.NetworkSystem;

public class StringMessage : MessageBase
{
	public string value; //Field offset: 0x8

	public StringMessage() { }

	public StringMessage(string v) { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

