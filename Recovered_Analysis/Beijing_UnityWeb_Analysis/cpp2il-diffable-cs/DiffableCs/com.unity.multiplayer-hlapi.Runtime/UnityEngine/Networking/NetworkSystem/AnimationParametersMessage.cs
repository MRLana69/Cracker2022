namespace UnityEngine.Networking.NetworkSystem;

internal class AnimationParametersMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public byte[] parameters; //Field offset: 0xC

	public AnimationParametersMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

