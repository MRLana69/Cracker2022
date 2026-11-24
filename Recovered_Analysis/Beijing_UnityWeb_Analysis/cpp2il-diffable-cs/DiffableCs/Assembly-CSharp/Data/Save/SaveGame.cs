namespace Data.Save;

public class SaveGame
{
	private const string DEBUG_SUFFIX = "_debug"; //Field offset: 0x0
	private SaveData<LocalData> _local; //Field offset: 0x8
	private SaveData<CloudData> _cloud; //Field offset: 0xC
	private SaveData<LocalDebugData> _localDebug; //Field offset: 0x10

	public CloudData cloud
	{
		 get { } //Length: 52
	}

	public SaveDataStrings debug_dataSerialized
	{
		 get { } //Length: 52
		 set { } //Length: 65
	}

	public LocalData local
	{
		 get { } //Length: 63
	}

	public LocalDebugData localDebug
	{
		 get { } //Length: 52
	}

	public SaveGame(string localPath, string cloudPath) { }

	public CloudData get_cloud() { }

	public SaveDataStrings get_debug_dataSerialized() { }

	public LocalData get_local() { }

	public LocalDebugData get_localDebug() { }

	public void Load() { }

	public void MigrateToCloud(string newCloudPath) { }

	public void Save() { }

	public void set_debug_dataSerialized(SaveDataStrings value) { }

}

