namespace System.Security.Cryptography;

public abstract class DSA : AsymmetricAlgorithm
{

	protected DSA() { }

	public static DSA Create() { }

	public static DSA Create(string algName) { }

	public abstract byte[] CreateSignature(byte[] rgbHash) { }

	private static Exception DerivedClassMustOverride() { }

	public abstract DSAParameters ExportParameters(bool includePrivateParameters) { }

	public override void FromXmlString(string xmlString) { }

	internal static Exception HashAlgorithmNameNullOrEmpty() { }

	protected virtual byte[] HashData(Stream data, HashAlgorithmName hashAlgorithm) { }

	protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	public abstract void ImportParameters(DSAParameters parameters) { }

	public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm) { }

	public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm) { }

	public virtual byte[] SignData(Stream data, HashAlgorithmName hashAlgorithm) { }

	public override string ToXmlString(bool includePrivateParameters) { }

	public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm) { }

	public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm) { }

	public virtual bool VerifyData(Stream data, byte[] signature, HashAlgorithmName hashAlgorithm) { }

	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

