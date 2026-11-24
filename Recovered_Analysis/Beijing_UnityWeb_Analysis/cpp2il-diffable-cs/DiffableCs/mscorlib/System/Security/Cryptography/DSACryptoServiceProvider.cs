namespace System.Security.Cryptography;

public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
{
	private const int PROV_DSS_DH = 13; //Field offset: 0x0
	private static bool useMachineKeyStore; //Field offset: 0x0
	private KeyPairPersistence store; //Field offset: 0x10
	private bool persistKey; //Field offset: 0x14
	private bool persisted; //Field offset: 0x15
	private bool privateKeyExportable; //Field offset: 0x16
	private bool m_disposed; //Field offset: 0x17
	private DSAManaged dsa; //Field offset: 0x18

	public CspKeyContainerInfo CspKeyContainerInfo
	{
		 get { } //Length: 43
	}

	public override string KeyExchangeAlgorithm
	{
		 get { } //Length: 65
	}

	public override int KeySize
	{
		 get { } //Length: 3
	}

	public bool PersistKeyInCsp
	{
		 get { } //Length: 12
		 set { } //Length: 127
	}

	public bool PublicOnly
	{
		 get { } //Length: 9
	}

	public override string SignatureAlgorithm
	{
		 get { } //Length: 12
	}

	public static bool UseMachineKeyStore
	{
		 get { } //Length: 248
		 set { } //Length: 230
	}

	public DSACryptoServiceProvider() { }

	public DSACryptoServiceProvider(CspParameters parameters) { }

	public DSACryptoServiceProvider(int dwKeySize) { }

	public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	private void Common(int dwKeySize, bool parameters) { }

	private void Common(CspParameters parameters) { }

	public override byte[] CreateSignature(byte[] rgbHash) { }

	protected override void Dispose(bool disposing) { }

	public byte[] ExportCspBlob(bool includePrivateParameters) { }

	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	protected override void Finalize() { }

	public CspKeyContainerInfo get_CspKeyContainerInfo() { }

	public override string get_KeyExchangeAlgorithm() { }

	public override int get_KeySize() { }

	public bool get_PersistKeyInCsp() { }

	public bool get_PublicOnly() { }

	public override string get_SignatureAlgorithm() { }

	public static bool get_UseMachineKeyStore() { }

	protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	public void ImportCspBlob(byte[] keyBlob) { }

	public override void ImportParameters(DSAParameters parameters) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

	public void set_PersistKeyInCsp(bool value) { }

	public static void set_UseMachineKeyStore(bool value) { }

	public byte[] SignData(byte[] buffer, int offset, int count) { }

	public byte[] SignData(byte[] buffer) { }

	public byte[] SignData(Stream inputStream) { }

	public byte[] SignHash(byte[] rgbHash, string str) { }

	public bool VerifyData(byte[] rgbData, byte[] rgbSignature) { }

	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

