namespace UnityEngine.Networking;

public class SyncListInt
{

	public SyncListInt() { }

	protected override int DeserializeItem(NetworkReader reader) { }

	public static SyncListInt ReadInstance(NetworkReader reader) { }

	public static void ReadReference(NetworkReader reader, SyncListInt syncList) { }

	protected override void SerializeItem(NetworkWriter writer, int item) { }

	public static void WriteInstance(NetworkWriter writer, SyncListInt items) { }

}

