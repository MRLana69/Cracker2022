namespace System.Text;

public abstract class EncodingProvider
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private static EncodingProvider[] s_providers; //Field offset: 0x4

	private static EncodingProvider() { }

	public abstract Encoding GetEncoding(string name) { }

	public abstract Encoding GetEncoding(int codepage) { }

	internal static Encoding GetEncodingFromProvider(int codepage) { }

	internal static Encoding GetEncodingFromProvider(string encodingName) { }

}

