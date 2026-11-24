namespace UnityEngine.Networking.NetworkSystem;

internal class AnimationTriggerMessage : MessageBase
{
	public NetworkInstanceId netId; //Field offset: 0x8
	public int hash; //Field offset: 0xC

	public AnimationTriggerMessage() { }

	public override void Deserialize(NetworkReader reader) { }

	public override void Serialize(NetworkWriter writer) { }

}

