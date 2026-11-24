namespace System.Security.Cryptography;

public sealed class CspParameters
{
	public int ProviderType; //Field offset: 0x8
	public string ProviderName; //Field offset: 0xC
	public string KeyContainerName; //Field offset: 0x10
	public int KeyNumber; //Field offset: 0x14
	private int m_flags; //Field offset: 0x18
	private CryptoKeySecurity m_cryptoKeySecurity; //Field offset: 0x1C
	private SecureString m_keyPassword; //Field offset: 0x20
	private nint m_parentWindowHandle; //Field offset: 0x24

	public CryptoKeySecurity CryptoKeySecurity
	{
		 get { } //Length: 6
		 set { } //Length: 186
	}

	public CspProviderFlags Flags
	{
		 get { } //Length: 6
		 set { } //Length: 22
	}

	public SecureString KeyPassword
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public nint ParentWindowHandle
	{
		 get { } //Length: 6
		 set { } //Length: 52
	}

	public CspParameters() { }

	public CspParameters(int dwTypeIn) { }

	public CspParameters(int dwTypeIn, string strProviderNameIn) { }

	public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword) { }

	public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, nint parentWindowHandle) { }

	internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

	internal CspParameters(CspParameters parameters) { }

	public CryptoKeySecurity get_CryptoKeySecurity() { }

	public CspProviderFlags get_Flags() { }

	public SecureString get_KeyPassword() { }

	public nint get_ParentWindowHandle() { }

	public void set_CryptoKeySecurity(CryptoKeySecurity value) { }

	public void set_Flags(CspProviderFlags value) { }

	public void set_KeyPassword(SecureString value) { }

	public void set_ParentWindowHandle(nint value) { }

}

