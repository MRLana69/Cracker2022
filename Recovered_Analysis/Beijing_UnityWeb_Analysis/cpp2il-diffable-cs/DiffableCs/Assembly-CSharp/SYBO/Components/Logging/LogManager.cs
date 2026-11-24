namespace SYBO.Components.Logging;

public class LogManager
{
	private object _lockObject; //Field offset: 0x8
	private List<LogCategory> _categories; //Field offset: 0xC
	private LogCategorySettings[] _categorySettings; //Field offset: 0x10
	private LogSettings _settings; //Field offset: 0x14
	private string <UserData>k__BackingField; //Field offset: 0x18
	private string <CurrentScene>k__BackingField; //Field offset: 0x1C

	public IEnumerable<LogCategory> Categories
	{
		 get { } //Length: 6
	}

	public string CurrentScene
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public LogSettings Settings
	{
		 get { } //Length: 49
		 set { } //Length: 101
	}

	public string UserData
	{
		 get { } //Length: 6
		internal set { } //Length: 2
	}

	private LogManager() { }

	public IEnumerable<LogCategory> get_Categories() { }

	public string get_CurrentScene() { }

	public LogSettings get_Settings() { }

	public string get_UserData() { }

	public int GetCategoriesCount() { }

	public string GetCategoryText(int _filterCategory) { }

	public override void Initialize() { }

	public static void LogLongString(LogCategory category, int level, string data) { }

	public void NotifyEntry(LogEntry entry) { }

	private void OnLogSettingsChanged() { }

	private void ReflectionFindCategories() { }

	internal void set_CurrentScene(string value) { }

	public void set_Settings(LogSettings value) { }

	internal void set_UserData(string value) { }

	private void UpdateCategorySettings() { }

}

