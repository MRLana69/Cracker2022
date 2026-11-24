namespace Microsoft.Win32;

internal class UnixRegistryApi : IRegistryApi
{

	public UnixRegistryApi() { }

	public void Close(RegistryKey rkey) { }

	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	public void Flush(RegistryKey rkey) { }

	public nint GetHandle(RegistryKey key) { }

	public string[] GetSubKeyNames(RegistryKey rkey) { }

	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	public string ToString(RegistryKey rkey) { }

	private static string ToUnix(string keyname) { }

}

