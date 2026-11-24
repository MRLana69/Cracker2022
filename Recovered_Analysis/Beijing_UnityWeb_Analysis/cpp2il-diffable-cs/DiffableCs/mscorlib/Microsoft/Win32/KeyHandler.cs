namespace Microsoft.Win32;

internal class KeyHandler
{
	private static Hashtable key_to_handler; //Field offset: 0x0
	private static Hashtable dir_to_handler; //Field offset: 0x4
	private static string user_store; //Field offset: 0x8
	private static string machine_store; //Field offset: 0xC
	public string Dir; //Field offset: 0x8
	private string ActualDir; //Field offset: 0xC
	public bool IsVolatile; //Field offset: 0x10
	private Hashtable values; //Field offset: 0x14
	private string file; //Field offset: 0x18
	private bool dirty; //Field offset: 0x1C

	public bool IsMarkedForDeletion
	{
		 get { } //Length: 1143
	}

	private static string MachineStore
	{
		 get { } //Length: 266
	}

	private static string UserStore
	{
		 get { } //Length: 81
	}

	private static KeyHandler() { }

	private KeyHandler(RegistryKey rkey, string basedir) { }

	private KeyHandler(RegistryKey rkey, string basedir, bool is_volatile) { }

	private static void CleanVolatileKeys() { }

	private static string CombineName(RegistryKey rkey, string extra) { }

	public static void Drop(RegistryKey rkey) { }

	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	protected override void Finalize() { }

	public void Flush() { }

	public bool get_IsMarkedForDeletion() { }

	private static string get_MachineStore() { }

	private static string get_UserStore() { }

	private static long GetRegisteredBootTime(string path) { }

	private static string GetRootFromDir(string dir) { }

	public string[] GetSubKeyNames() { }

	private static long GetSystemBootTime() { }

	public object GetValue(string name, RegistryValueOptions options) { }

	public static string GetVolatileDir(string dir) { }

	public void Load() { }

	private void LoadKey(SecurityElement se) { }

	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	private void Save() { }

	private static void SaveRegisteredBootTime(string path, long btime) { }

	public bool ValueExists(string name) { }

	public static bool VolatileKeyExists(string dir) { }

}

