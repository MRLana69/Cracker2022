namespace System.Security.Cryptography;

public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
{
	private static CspProviderFlags s_UseMachineKeyStore; //Field offset: 0x0
	private const int PROV_RSA_FULL = 1; //Field offset: 0x0
	private const int AT_KEYEXCHANGE = 1; //Field offset: 0x0
	private const int AT_SIGNATURE = 2; //Field offset: 0x0
	private KeyPairPersistence store; //Field offset: 0x10
	private bool persistKey; //Field offset: 0x14
	private bool persisted; //Field offset: 0x15
	private bool privateKeyExportable; //Field offset: 0x16
	private bool m_disposed; //Field offset: 0x17
	private RSAManaged rsa; //Field offset: 0x18

	public CspKeyContainerInfo CspKeyContainerInfo
	{
		 get { } //Length: 206
	}

	public override string KeyExchangeAlgorithm
	{
		 get { } //Length: 265
	}

	public override int KeySize
	{
		 get { } //Length: 43
	}

	public bool PersistKeyInCsp
	{
		 get { } //Length: 26
		 set { } //Length: 184
	}

	public bool PublicOnly
	{
		 get { } //Length: 9
	}

	public override string SignatureAlgorithm
	{
		 get { } //Length: 43
	}

	public static bool UseMachineKeyStore
	{
		 get { } //Length: 77
		 set { } //Length: 2
	}

	private static RSACryptoServiceProvider() { }

	public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters) { }

	public RSACryptoServiceProvider(int dwKeySize) { }

	public RSACryptoServiceProvider(CspParameters parameters) { }

	public RSACryptoServiceProvider() { }

	private void Common(CspParameters p) { }

	private void Common(int dwKeySize, bool parameters) { }

	public byte[] Decrypt(byte[] rgb, bool fOAEP) { }

	public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding) { }

	public override byte[] DecryptValue(byte[] rgb) { }

	protected override void Dispose(bool disposing) { }

	public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding) { }

	public byte[] Encrypt(byte[] rgb, bool fOAEP) { }

	public override byte[] EncryptValue(byte[] rgb) { }

	public byte[] ExportCspBlob(bool includePrivateParameters) { }

	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	protected override void Finalize() { }

	public CspKeyContainerInfo get_CspKeyContainerInfo() { }

	public override string get_KeyExchangeAlgorithm() { }

	public override int get_KeySize() { }

	public bool get_PersistKeyInCsp() { }

	public bool get_PublicOnly() { }

	public override string get_SignatureAlgorithm() { }

	public static bool get_UseMachineKeyStore() { }

	private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm) { }

	private HashAlgorithm GetHash(object halg) { }

	private HashAlgorithm GetHashFromString(string name) { }

	private string GetHashNameFromOID(string oid) { }

	protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	protected override byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	public void ImportCspBlob(byte[] keyBlob) { }

	public override void ImportParameters(RSAParameters parameters) { }

	private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash) { }

	private void OnKeyGenerated(object sender, EventArgs e) { }

	private static Exception PaddingModeNotSupported() { }

	public void set_PersistKeyInCsp(bool value) { }

	public static void set_UseMachineKeyStore(bool value) { }

	public byte[] SignData(byte[] buffer, object halg) { }

	public byte[] SignData(Stream inputStream, object halg) { }

	public byte[] SignData(byte[] buffer, int offset, int count, object halg) { }

	public byte[] SignHash(byte[] rgbHash, string str) { }

	private byte[] SignHash(byte[] rgbHash, int calgHash) { }

	public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public bool VerifyData(byte[] buffer, object halg, byte[] signature) { }

	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature) { }

	public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

}

