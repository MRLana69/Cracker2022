namespace System.Security.Cryptography;

public sealed class CspKeyContainerInfo
{
	private CspParameters _params; //Field offset: 0x8
	internal bool _random; //Field offset: 0xC

	public bool Accessible
	{
		 get { } //Length: 1830
	}

	public CryptoKeySecurity CryptoKeySecurity
	{
		 get { } //Length: 3
	}

	public bool Exportable
	{
		 get { } //Length: 3
	}

	public bool HardwareDevice
	{
		 get { } //Length: 3
	}

	public string KeyContainerName
	{
		 get { } //Length: 3
	}

	public KeyNumber KeyNumber
	{
		 get { } //Length: 9
	}

	public bool MachineKeyStore
	{
		 get { } //Length: 9
	}

	public bool Protected
	{
		 get { } //Length: 3
	}

	public string ProviderName
	{
		 get { } //Length: 3
	}

	public int ProviderType
	{
		 get { } //Length: 9
	}

	public bool RandomlyGenerated
	{
		 get { } //Length: 9
	}

	public bool Removable
	{
		 get { } //Length: 9
	}

	public string UniqueKeyContainerName
	{
		 get { } //Length: 3
	}

	public CspKeyContainerInfo(CspParameters parameters) { }

	public bool get_Accessible() { }

	public CryptoKeySecurity get_CryptoKeySecurity() { }

	public bool get_Exportable() { }

	public bool get_HardwareDevice() { }

	public string get_KeyContainerName() { }

	public KeyNumber get_KeyNumber() { }

	public bool get_MachineKeyStore() { }

	public bool get_Protected() { }

	public string get_ProviderName() { }

	public int get_ProviderType() { }

	public bool get_RandomlyGenerated() { }

	public bool get_Removable() { }

	public string get_UniqueKeyContainerName() { }

}

