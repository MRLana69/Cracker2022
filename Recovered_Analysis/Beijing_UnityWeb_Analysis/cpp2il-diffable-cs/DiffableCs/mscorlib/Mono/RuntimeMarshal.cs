namespace Mono;

internal static class RuntimeMarshal
{

	internal static int AsciHexDigitValue(int c) { }

	internal static byte[] DecodeBlobArray(nint ptr) { }

	private static int DecodeBlobSize(nint in_ptr, out nint out_ptr) { }

	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }

	internal static SafeStringMarshal MarshalString(string str) { }

	internal static string PtrToUtf8String(nint ptr) { }

}

