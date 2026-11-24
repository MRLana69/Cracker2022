namespace System.Security.Cryptography.X509Certificates;

internal static class X509Helper2
{
	private class MyNativeHelper : INativeCertificateHelper
	{

		public MyNativeHelper() { }

		public X509CertificateImpl Import(X509Certificate cert) { }

	}


	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	internal static Exception GetInvalidChainContextException() { }

	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	internal static X509Certificate2Impl Import(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags, bool disableProvider = false) { }

	internal static X509Certificate2Impl Import(X509Certificate cert, bool disableProvider = false) { }

	internal static void Initialize() { }

	public static bool IsValid(X509ChainImpl impl) { }

	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

}

