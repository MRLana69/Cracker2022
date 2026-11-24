namespace Mono.Net.Security;

internal class MonoTlsStream
{
	private readonly HttpWebRequest request; //Field offset: 0x8
	private bool <CertificateValidationFailed>k__BackingField; //Field offset: 0xC

	internal bool CertificateValidationFailed
	{
		 set { } //Length: 2
	}

	internal HttpWebRequest Request
	{
		 get { } //Length: 6
	}

	internal HttpWebRequest get_Request() { }

	internal void set_CertificateValidationFailed(bool value) { }

}

