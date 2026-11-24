namespace System.Security.Cryptography;

public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
{
	private DSA _dsaKey; //Field offset: 0x8
	private string _oid; //Field offset: 0xC

	public DSASignatureDeformatter() { }

	public DSASignatureDeformatter(AsymmetricAlgorithm key) { }

	public override void SetHashAlgorithm(string strName) { }

	public override void SetKey(AsymmetricAlgorithm key) { }

	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

