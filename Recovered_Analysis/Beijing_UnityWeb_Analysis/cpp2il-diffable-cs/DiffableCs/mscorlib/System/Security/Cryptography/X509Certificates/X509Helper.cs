namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper
{
	private static INativeCertificateHelper nativeHelper; //Field offset: 0x0

	private static byte[] ConvertData(byte[] data) { }

	internal static Exception GetInvalidContextException() { }

	private static X509CertificateImpl Import(byte[] rawData) { }

	public static X509CertificateImpl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	private static X509CertificateImpl ImportCore(byte[] rawData) { }

	internal static X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	internal static void InstallNativeHelper(INativeCertificateHelper helper) { }

	public static bool IsValid(X509CertificateImpl impl) { }

	private static byte[] PEM(string type, byte[] data) { }

	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	public static string ToHexString(byte[] data) { }

}

