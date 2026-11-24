namespace Kiloo.Common.HTTP;

public static class TrustedRoots
{
	private static X509Certificate2Collection _trusted; //Field offset: 0x0

	public static void Init() { }

	private static X509Certificate2Collection LoadTrusted() { }

	private static void Log(string msg) { }

	private static void LogError(string msg) { }

	public static bool VerifyTrust(X509Certificate2 certificate) { }

}

