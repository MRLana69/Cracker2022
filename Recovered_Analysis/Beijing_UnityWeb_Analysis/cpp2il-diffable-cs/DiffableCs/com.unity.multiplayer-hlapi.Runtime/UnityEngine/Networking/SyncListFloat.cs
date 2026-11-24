namespace UnityEngine.Networking;

public sealed class SyncListFloat
{

	public SyncListFloat() { }

	protected override float DeserializeItem(NetworkReader reader) { }

	public static SyncListFloat ReadInstance(NetworkReader reader) { }

	public static void ReadReference(NetworkReader reader, SyncListFloat syncList) { }

	protected override void SerializeItem(NetworkWriter writer, float item) { }

	public static void WriteInstance(NetworkWriter writer, SyncListFloat items) { }

}

