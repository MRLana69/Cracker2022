namespace System.Security.Cryptography;

internal abstract class RSAPKCS1SignatureDescription : SignatureDescription
{
	private string _hashAlgorithm; //Field offset: 0x18

	protected RSAPKCS1SignatureDescription(string hashAlgorithm, string digestAlgorithm) { }

	public sealed override AsymmetricSignatureDeformatter CreateDeformatter(AsymmetricAlgorithm key) { }

	public sealed override AsymmetricSignatureFormatter CreateFormatter(AsymmetricAlgorithm key) { }

}

