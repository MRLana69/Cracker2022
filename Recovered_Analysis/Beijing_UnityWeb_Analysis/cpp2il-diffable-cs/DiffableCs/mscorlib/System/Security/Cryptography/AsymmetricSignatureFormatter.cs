namespace System.Security.Cryptography;

public abstract class AsymmetricSignatureFormatter
{

	protected AsymmetricSignatureFormatter() { }

	public virtual byte[] CreateSignature(HashAlgorithm hash) { }

	public abstract byte[] CreateSignature(byte[] rgbHash) { }

	public abstract void SetHashAlgorithm(string strName) { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

}

