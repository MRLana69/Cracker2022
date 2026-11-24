namespace UnityEngine.Networking.NetworkSystem;

internal class LobbyReadyToBeginMessage : MessageBase
{
	public byte slotId; //Field offset: 0x8
	public bool readyState; //Field offset: 0x9

	public LobbyReadyToBeginMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

