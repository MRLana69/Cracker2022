namespace Mono.Net.Security.Private;

internal static class CallbackHelpers
{
	private sealed class <>c__DisplayClass0_0
	{
		public RemoteCertificateValidationCallback callback; //Field offset: 0x8

		public <>c__DisplayClass0_0() { }

		internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }

	}

	private sealed class <>c__DisplayClass1_0
	{
		public LocalCertificateSelectionCallback callback; //Field offset: 0x8

		public <>c__DisplayClass1_0() { }

		internal X509Certificate <PublicToMono>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

	}

	private sealed class <>c__DisplayClass5_0
	{
		public MonoRemoteCertificateValidationCallback callback; //Field offset: 0x8

		public <>c__DisplayClass5_0() { }

		internal bool <MonoToPublic>b__0(object t, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

	}

	private sealed class <>c__DisplayClass8_0
	{
		public MonoLocalCertificateSelectionCallback callback; //Field offset: 0x8

		public <>c__DisplayClass8_0() { }

		internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }

	}


	internal static LocalCertSelectionCallback MonoToInternal(MonoLocalCertificateSelectionCallback callback) { }

	internal static RemoteCertificateValidationCallback MonoToPublic(MonoRemoteCertificateValidationCallback callback) { }

	internal static MonoRemoteCertificateValidationCallback PublicToMono(RemoteCertificateValidationCallback callback) { }

	internal static MonoLocalCertificateSelectionCallback PublicToMono(LocalCertificateSelectionCallback callback) { }

}

