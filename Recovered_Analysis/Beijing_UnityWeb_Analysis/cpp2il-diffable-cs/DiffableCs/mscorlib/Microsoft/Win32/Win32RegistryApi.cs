namespace Microsoft.Win32;

internal class Win32RegistryApi : IRegistryApi
{
	private readonly int NativeBytesPerCharacter; //Field offset: 0x8

	public Win32RegistryApi() { }

	public void Close(RegistryKey rkey) { }

	internal static string CombineName(RegistryKey rkey, string localName) { }

	public void Flush(RegistryKey rkey) { }

	private void GenerateException(int errorCode) { }

	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	public nint GetHandle(RegistryKey key) { }

	public string[] GetSubKeyNames(RegistryKey rkey) { }

	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	private static bool IsHandleValid(RegistryKey key) { }

	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	private static int RegCloseKey(nint keyHandle) { }

	internal static int RegEnumKeyEx(nint keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, out StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	private static int RegFlushKey(nint keyHandle) { }

	private static int RegOpenKeyEx(nint keyBase, string keyName, nint reserved, int access, out nint keyHandle) { }

	internal static int RegQueryInfoKey(nint hKey, out StringBuilder lpClass, int[] lpcbClass, nint lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	private static int RegQueryValueEx(nint keyBase, string valueName, nint reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	private static int RegQueryValueEx(nint keyBase, string valueName, nint reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	private static int RegQueryValueEx(nint keyBase, string valueName, nint reserved, ref RegistryValueKind type, out byte[] data, ref int dataSize) { }

	private static int RegQueryValueEx(nint keyBase, string valueName, nint reserved, ref RegistryValueKind type, nint zero, ref int dataSize) { }

	public int SubKeyCount(RegistryKey rkey) { }

	public string ToString(RegistryKey rkey) { }

}

