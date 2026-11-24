namespace Data.DebugUtil;

public static class SaveGameDebug
{
	private sealed class <>c__DisplayClass11_0
	{
		public string saveDir; //Field offset: 0x8

		public <>c__DisplayClass11_0() { }

		internal string <GetPossibleSaves>b__0(string x) { }

	}

	private static readonly string[] _saveFiles; //Field offset: 0x0
	private static string _lastLoadedSave; //Field offset: 0x4

	private static string debugSaveDirectory
	{
		 get { } //Length: 274
	}

	private static string gameSaveDirectory
	{
		 get { } //Length: 49
	}

	public static string lastLoadedSave
	{
		 get { } //Length: 127
		private set { } //Length: 283
	}

	private static string saveInfoPath
	{
		 get { } //Length: 49
	}

	private static string tmpCloudPath
	{
		 get { } //Length: 91
	}

	private static string tmpLocalPath
	{
		 get { } //Length: 91
	}

	private static string tmpPlayerInfoPath
	{
		 get { } //Length: 184
	}

	private static SaveGameDebug() { }

	private static void CopySaveFiles(string from, string to) { }

	private static void DeleteExistingSaveFiles(string folder) { }

	public static void ExportPlayerInfoToExternal() { }

	public static void ExportToFiles() { }

	public static bool FilesExist() { }

	private static string get_debugSaveDirectory() { }

	private static string get_gameSaveDirectory() { }

	public static string get_lastLoadedSave() { }

	private static string get_saveInfoPath() { }

	private static string get_tmpCloudPath() { }

	private static string get_tmpLocalPath() { }

	private static string get_tmpPlayerInfoPath() { }

	public static IEnumerable<string> GetPossibleSaves() { }

	public static void ImportFromFiles() { }

	public static void ImportPlayerInfoFromExternal() { }

	private static void Log(string msg) { }

	private static void MakeSureDirectoryExists(string folderPath, string filePath) { }

	public static void OpenDebugSaveDirectory() { }

	public static void OpenFiles() { }

	public static void OpenGameSaveDirectory() { }

	private static void set_lastLoadedSave(string value) { }

	public static void StoreSaveGame(string saveFolder) { }

	public static void SwitchSaveGame(string newSave) { }

}

