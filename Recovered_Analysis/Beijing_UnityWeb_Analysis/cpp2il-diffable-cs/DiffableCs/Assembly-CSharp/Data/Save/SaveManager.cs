namespace Data.Save;

public static class SaveManager
{
	private const string LOCAL_FILE = "local"; //Field offset: 0x0
	private const string CLOUD_FILE_PREFIX = "cloud"; //Field offset: 0x0
	private const string SAVE_FOLDER_NAME = "Save"; //Field offset: 0x0
	private const string LAST_USED_KILOOTAG_KEY = "CloudSaveLastUsedKilooTag"; //Field offset: 0x0
	private static readonly string SAVE_PATH; //Field offset: 0x0
	private static readonly string LOCAL_FILE_PATH; //Field offset: 0x4
	private static Action saveGameChanged; //Field offset: 0x8
	private static SaveGame _activeSaveGame; //Field offset: 0xC
	private static bool _hasInited; //Field offset: 0x10

	public static event Action saveGameChanged
	{
		 add { } //Length: 143
		 remove { } //Length: 209
	}

	private static SaveManager() { }

	public static void add_saveGameChanged(Action value) { }

	private static void CreateSaveFolderIfNeeded(string basePath) { }

	public static void DebugSaveGameChange(string fakeTag) { }

	public static void DeleteFilesDebug(bool deleteLocal = true, bool deleteCloud = true) { }

	public static void DeleteFolderDebug() { }

	public static string GetCloudFileFullPath(string kilooTag = "") { }

	public static string GetCloudFolderFullPath() { }

	public static string GetCurrentCloudFilename() { }

	public static string GetKilooTag() { }

	private static string GetSavedKilooTag() { }

	public static void Init() { }

	public static void Inject(DataManager<T> manager) { }

	public static void Load() { }

	private static void MigrateCloudSave(string oldPath, string newPath) { }

	private static void OnAppRefresh(RefreshType refreshType) { }

	private static void OnAuthenticated() { }

	public static void remove_saveGameChanged(Action value) { }

	public static void Save() { }

	private static void SaveKilooTag(string s) { }

	private static void SetupSaveGame(string fakeTag = "") { }

}

