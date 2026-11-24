namespace UnityEngine.Networking;

public sealed class SyncListString
{

	public SyncListString() { }

	protected override string DeserializeItem(NetworkReader reader) { }

	public static SyncListString ReadInstance(NetworkReader reader) { }

	public static void ReadReference(NetworkReader reader, SyncListString syncList) { }

	protected override void SerializeItem(NetworkWriter writer, string item) { }

	public static void WriteInstance(NetworkWriter writer, SyncListString items) { }

}

