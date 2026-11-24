namespace UnityEngine.Networking;

public class SyncListUInt
{

	public SyncListUInt() { }

	protected override uint DeserializeItem(NetworkReader reader) { }

	public static SyncListUInt ReadInstance(NetworkReader reader) { }

	public static void ReadReference(NetworkReader reader, SyncListUInt syncList) { }

	protected override void SerializeItem(NetworkWriter writer, uint item) { }

	public static void WriteInstance(NetworkWriter writer, SyncListUInt items) { }

}

