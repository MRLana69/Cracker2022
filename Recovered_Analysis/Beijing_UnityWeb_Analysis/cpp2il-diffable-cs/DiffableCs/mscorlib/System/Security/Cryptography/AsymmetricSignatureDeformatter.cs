namespace System.Security.Cryptography;

public abstract class AsymmetricSignatureDeformatter
{

	protected AsymmetricSignatureDeformatter() { }

	public abstract void SetHashAlgorithm(string strName) { }

	public abstract void SetKey(AsymmetricAlgorithm key) { }

	public virtual bool VerifySignature(HashAlgorithm hash, byte[] rgbSignature) { }

	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

