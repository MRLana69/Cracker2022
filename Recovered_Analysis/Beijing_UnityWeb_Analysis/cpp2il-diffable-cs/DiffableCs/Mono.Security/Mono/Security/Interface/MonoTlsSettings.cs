namespace Mono.Security.Interface;

public sealed class MonoTlsSettings
{
	private static MonoTlsSettings defaultSettings; //Field offset: 0x0
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x8
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; //Field offset: 0xC
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; //Field offset: 0x10
	private X509CertificateCollection <TrustAnchors>k__BackingField; //Field offset: 0x20
	private object <UserSettings>k__BackingField; //Field offset: 0x24
	private string[] <CertificateSearchPaths>k__BackingField; //Field offset: 0x28
	private bool <SendCloseNotify>k__BackingField; //Field offset: 0x2C
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; //Field offset: 0x30
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; //Field offset: 0x38
	private bool cloned; //Field offset: 0x3C
	private bool checkCertName; //Field offset: 0x3D
	private bool checkCertRevocationStatus; //Field offset: 0x3E
	private Nullable<bool> useServicePointManagerCallback; //Field offset: 0x3F
	private bool skipSystemValidators; //Field offset: 0x41
	private bool callbackNeedsChain; //Field offset: 0x42
	private ICertificateValidator certificateValidator; //Field offset: 0x44

	public bool CallbackNeedsCertificateChain
	{
		 get { } //Length: 6
	}

	internal string[] CertificateSearchPaths
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Nullable<DateTime> CertificateValidationTime
	{
		 get { } //Length: 51
		 set { } //Length: 26
	}

	public ICertificateValidator CertificateValidator
	{
		 get { } //Length: 6
	}

	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public static MonoTlsSettings DefaultSettings
	{
		 get { } //Length: 53
	}

	public CipherSuiteCode[] EnabledCiphers
	{
		 get { } //Length: 9
		 set { } //Length: 51
	}

	public Nullable<TlsProtocols> EnabledProtocols
	{
		 get { } //Length: 11
		 set { } //Length: 11
	}

	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		 get { } //Length: 125
		 set { } //Length: 11
	}

	internal bool SendCloseNotify
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public X509CertificateCollection TrustAnchors
	{
		 get { } //Length: 9
		 set { } //Length: 61
	}

	public object UserSettings
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Nullable<bool> UseServicePointManagerCallback
	{
		 get { } //Length: 11
		 set { } //Length: 11
	}

	private MonoTlsSettings(MonoTlsSettings other) { }

	public MonoTlsSettings() { }

	public MonoTlsSettings Clone() { }

	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	public static MonoTlsSettings CopyDefaultSettings() { }

	public bool get_CallbackNeedsCertificateChain() { }

	internal string[] get_CertificateSearchPaths() { }

	public Nullable<DateTime> get_CertificateValidationTime() { }

	public ICertificateValidator get_CertificateValidator() { }

	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	public static MonoTlsSettings get_DefaultSettings() { }

	public CipherSuiteCode[] get_EnabledCiphers() { }

	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	internal bool get_SendCloseNotify() { }

	public X509CertificateCollection get_TrustAnchors() { }

	public object get_UserSettings() { }

	public Nullable<bool> get_UseServicePointManagerCallback() { }

	internal void set_CertificateSearchPaths(string[] value) { }

	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	internal void set_SendCloseNotify(bool value) { }

	public void set_TrustAnchors(X509CertificateCollection value) { }

	public void set_UserSettings(object value) { }

	public void set_UseServicePointManagerCallback(Nullable<bool> value) { }

}

