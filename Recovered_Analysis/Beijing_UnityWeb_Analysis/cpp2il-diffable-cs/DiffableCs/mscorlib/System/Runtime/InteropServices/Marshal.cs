namespace System.Runtime.InteropServices;

public static class Marshal
{
	public static readonly int SystemMaxDBCSCharSize; //Field offset: 0x0
	public static readonly int SystemDefaultCharSize; //Field offset: 0x4

	private static Marshal() { }

	public static nint AllocHGlobal(nint cb) { }

	public static nint AllocHGlobal(int cb) { }

	private static nint BufferToBSTR(Array ptr, int slen) { }

	private static void ClearBSTR(nint ptr) { }

	public static void Copy(byte[] source, int startIndex, nint destination, int length) { }

	public static void Copy(nint source, byte[] destination, int startIndex, int length) { }

	public static void Copy(nint source, char[] destination, int startIndex, int length) { }

	internal static void copy_from_unmanaged(nint source, int startIndex, Array destination, int length) { }

	internal static void copy_to_unmanaged(Array source, int startIndex, nint destination, int length) { }

	public static void FreeBSTR(nint ptr) { }

	public static void FreeHGlobal(nint hglobal) { }

	public static nint GetFunctionPointerForDelegate(TDelegate d) { }

	private static nint GetFunctionPointerForDelegateInternal(Delegate d) { }

	public static int GetHRForException(Exception e) { }

	public static int GetLastWin32Error() { }

	public static string PtrToStringAnsi(nint ptr) { }

	public static T PtrToStructure(nint ptr) { }

	public static object PtrToStructure(nint ptr, Type structureType) { }

	public static int ReadInt32(nint ptr, int ofs) { }

	public static int ReadInt32(nint ptr) { }

	public static long ReadInt64(nint ptr) { }

	public static nint ReadIntPtr(nint ptr) { }

	public static int Release(nint pUnk) { }

	private static int ReleaseInternal(nint pUnk) { }

	public static nint SecureStringToBSTR(SecureString s) { }

	public static void StructureToPtr(object structure, nint ptr, bool fDeleteOld) { }

	public static void StructureToPtr(T structure, nint ptr, bool fDeleteOld) { }

	public static nint UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	public static nint UnsafeAddrOfPinnedArrayElement(T[] arr, int index) { }

	public static void WriteByte(nint ptr, int ofs, byte val) { }

	public static void ZeroFreeBSTR(nint s) { }

}

