namespace System.Security.Cryptography;

public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter
{
	private RSA rsa; //Field offset: 0x8
	private string hashName; //Field offset: 0xC

	public RSAPKCS1SignatureDeformatter() { }

	public RSAPKCS1SignatureDeformatter(AsymmetricAlgorithm key) { }

	public override void SetHashAlgorithm(string strName) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

