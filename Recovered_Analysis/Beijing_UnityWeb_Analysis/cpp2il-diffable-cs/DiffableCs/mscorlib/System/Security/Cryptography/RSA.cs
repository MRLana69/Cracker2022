namespace System.Security.Cryptography;

public abstract class RSA : AsymmetricAlgorithm
{

	public override string KeyExchangeAlgorithm
	{
		 get { } //Length: 55
	}

	public override string SignatureAlgorithm
	{
		 get { } //Length: 43
	}

	protected RSA() { }

	public static RSA Create() { }

	public static RSA Create(string algName) { }

	public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding) { }

	public virtual byte[] DecryptValue(byte[] rgb) { }

	private static Exception DerivedClassMustOverride() { }

	public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding) { }

	public virtual byte[] EncryptValue(byte[] rgb) { }

	public abstract RSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void FromXmlString(string xmlString) { }

	public override string get_KeyExchangeAlgorithm() { }

	public override string get_SignatureAlgorithm() { }

	internal static Exception HashAlgorithmNameNullOrEmpty() { }

	protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	public abstract void ImportParameters(RSAParameters parameters) { }

	public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public override string ToXmlString(bool includePrivateParameters) { }

	public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

	public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding) { }

}

