namespace Data.Save.Internal;

public class SaveData`1
{
	private const string SECRET = ""; //Field offset: 0x0
	private string _path; //Field offset: 0x0
	private T _diskData; //Field offset: 0x0
	private IBsonSerializer _serializer; //Field offset: 0x0
	private byte[] _lastSaved; //Field offset: 0x0

	public string debug_dataSerialized
	{
		 get { } //Length: 6
		 set { } //Length: 36
	}

	public T diskData
	{
		 get { } //Length: 6
	}

	public SaveData`1(string path) { }

	public SaveData`1(string path, T diskData) { }

	public void ChangeSavePath(string newSavePath) { }

	public string get_debug_dataSerialized() { }

	public T get_diskData() { }

	public void Load() { }

	public void Save() { }

	private void SaveIfDirty() { }

	public void set_debug_dataSerialized(string value) { }

}

