namespace System.Security.Cryptography.X509Certificates;

public sealed class X509ChainPolicy
{
	private OidCollection apps; //Field offset: 0x8
	private OidCollection cert; //Field offset: 0xC
	private X509CertificateCollection store; //Field offset: 0x10
	private X509Certificate2Collection store2; //Field offset: 0x14
	private X509RevocationFlag rflag; //Field offset: 0x18
	private X509RevocationMode mode; //Field offset: 0x1C
	private TimeSpan timeout; //Field offset: 0x20
	private X509VerificationFlags vflags; //Field offset: 0x28
	private DateTime vtime; //Field offset: 0x30

	public X509Certificate2Collection ExtraStore
	{
		 get { } //Length: 235
	}

	public X509RevocationFlag RevocationFlag
	{
		 get { } //Length: 507
	}

	public X509RevocationMode RevocationMode
	{
		 get { } //Length: 6
		 set { } //Length: 19
	}

	public X509VerificationFlags VerificationFlags
	{
		 get { } //Length: 6
	}

	public DateTime VerificationTime
	{
		 get { } //Length: 20
	}

	public X509ChainPolicy() { }

	internal X509ChainPolicy(X509CertificateCollection store) { }

	public X509Certificate2Collection get_ExtraStore() { }

	public X509RevocationFlag get_RevocationFlag() { }

	public X509RevocationMode get_RevocationMode() { }

	public X509VerificationFlags get_VerificationFlags() { }

	public DateTime get_VerificationTime() { }

	public void Reset() { }

	public void set_RevocationMode(X509RevocationMode value) { }

}

