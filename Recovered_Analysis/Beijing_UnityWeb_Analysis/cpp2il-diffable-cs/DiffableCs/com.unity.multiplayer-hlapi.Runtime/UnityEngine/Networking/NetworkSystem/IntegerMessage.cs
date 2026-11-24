namespace UnityEngine.Networking.NetworkSystem;

public class IntegerMessage : MessageBase
{
	public int value; //Field offset: 0x8

	public IntegerMessage() { }

	public IntegerMessage(int v) { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

