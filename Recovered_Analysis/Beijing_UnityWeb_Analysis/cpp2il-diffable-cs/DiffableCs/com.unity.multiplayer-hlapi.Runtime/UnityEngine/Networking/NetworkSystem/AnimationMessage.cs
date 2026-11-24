namespace UnityEngine.Networking.NetworkSystem;

internal class AnimationMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public int stateHash; //Field offset: 0xC
	public float normalizedTime; //Field offset: 0x10
	public byte[] parameters; //Field offset: 0x14

	public AnimationMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

