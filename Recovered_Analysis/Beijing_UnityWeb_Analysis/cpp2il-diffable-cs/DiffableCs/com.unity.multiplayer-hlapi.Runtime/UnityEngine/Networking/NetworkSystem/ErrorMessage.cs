namespace UnityEngine.Networking.NetworkSystem;

public class ErrorMessage : MessageBase
{
	public int errorCode; //Field offset: 0x8

	public ErrorMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

