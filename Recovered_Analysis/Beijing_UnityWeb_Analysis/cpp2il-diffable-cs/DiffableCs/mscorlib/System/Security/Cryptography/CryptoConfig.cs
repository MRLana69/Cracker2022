namespace System.Security.Cryptography;

public class CryptoConfig
{

	public static bool AllowOnlyFipsAlgorithms
	{
		 get { } //Length: 3
	}

	public CryptoConfig() { }

	public static void AddAlgorithm(Type algorithm, string[] names) { }

	public static void AddOID(string oid, string[] names) { }

	public static object CreateFromName(string name) { }

	public static object CreateFromName(string name, object[] args) { }

	private static byte[] EncodeLongNumber(long x) { }

	public static byte[] EncodeOID(string str) { }

	public static bool get_AllowOnlyFipsAlgorithms() { }

	internal static string MapNameToOID(string name, object arg) { }

	public static string MapNameToOID(string name) { }

}

