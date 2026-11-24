namespace Microsoft.Win32;

internal interface IRegistryApi
{

	public void Close(RegistryKey rkey) { }

	public void Flush(RegistryKey rkey) { }

	public nint GetHandle(RegistryKey key) { }

	public string[] GetSubKeyNames(RegistryKey rkey) { }

	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writtable) { }

	public string ToString(RegistryKey rkey) { }

}

