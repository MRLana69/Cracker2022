namespace Microsoft.Win32;

public sealed class RegistryKey : MarshalByRefObject, IDisposable
{
	private static readonly IRegistryApi RegistryApi; //Field offset: 0x0
	private object handle; //Field offset: 0xC
	private SafeRegistryHandle safe_handle; //Field offset: 0x10
	private object hive; //Field offset: 0x14
	private readonly string qname; //Field offset: 0x18
	private readonly bool isRemoteRoot; //Field offset: 0x1C
	private readonly bool isWritable; //Field offset: 0x1D

	public SafeRegistryHandle Handle
	{
		 get { } //Length: 6
	}

	internal RegistryHive Hive
	{
		 get { } //Length: 9
	}

	internal object InternalHandle
	{
		 get { } //Length: 103
	}

	internal bool IsRoot
	{
		 get { } //Length: 113
	}

	public string Name
	{
		 get { } //Length: 3
	}

	private static RegistryKey() { }

	internal RegistryKey(RegistryHive hiveId) { }

	internal RegistryKey(RegistryHive hiveId, nint keyHandle, bool remoteRoot) { }

	internal RegistryKey(object data, string keyName, bool writable) { }

	private void AssertKeyNameLength(string name) { }

	private void AssertKeyStillValid() { }

	public void Close() { }

	internal static IOException CreateMarkedForDeletionException() { }

	internal static string DecodeString(byte[] data) { }

	public void Dispose() { }

	public void Flush() { }

	public SafeRegistryHandle get_Handle() { }

	internal RegistryHive get_Hive() { }

	internal object get_InternalHandle() { }

	internal bool get_IsRoot() { }

	public string get_Name() { }

	private static string GetHiveName(RegistryHive hive) { }

	public string[] GetSubKeyNames() { }

	public object GetValue(string name, object defaultValue) { }

	public object GetValue(string name) { }

	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	public RegistryKey OpenSubKey(string name) { }

	public RegistryKey OpenSubKey(string name, bool writable) { }

	public override string ToString() { }

}

