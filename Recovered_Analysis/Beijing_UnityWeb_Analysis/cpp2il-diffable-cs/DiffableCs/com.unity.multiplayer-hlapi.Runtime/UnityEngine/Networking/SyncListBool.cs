namespace UnityEngine.Networking;

public class SyncListBool
{

	public SyncListBool() { }

	protected override bool DeserializeItem(NetworkReader reader) { }

	public static SyncListBool ReadInstance(NetworkReader reader) { }

	public static void ReadReference(NetworkReader reader, SyncListBool syncList) { }

	protected override void SerializeItem(NetworkWriter writer, bool item) { }

	public static void WriteInstance(NetworkWriter writer, SyncListBool items) { }

}

