namespace UnityEngine.Networking;

public class SyncListStruct`1
{

	public ushort Count
	{
		 get { } //Length: 0
	}

	public SyncListStruct`1() { }

	public void AddInternal(T item) { }

	protected override T DeserializeItem(NetworkReader reader) { }

	public ushort get_Count() { }

	public T GetItem(int i) { }

	protected override void SerializeItem(NetworkWriter writer, T item) { }

}

