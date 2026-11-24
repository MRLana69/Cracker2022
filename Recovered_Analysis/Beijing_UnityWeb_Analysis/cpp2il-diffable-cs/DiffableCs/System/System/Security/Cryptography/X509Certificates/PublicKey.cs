namespace System.Security.Cryptography.X509Certificates;

public sealed class PublicKey
{
	private static byte[] Empty; //Field offset: 0x0
	private AsymmetricAlgorithm _key; //Field offset: 0x8
	private AsnEncodedData _keyValue; //Field offset: 0xC
	private AsnEncodedData _params; //Field offset: 0x10
	private Oid _oid; //Field offset: 0x14

	public AsnEncodedData EncodedKeyValue
	{
		 get { } //Length: 57
	}

	public AsnEncodedData EncodedParameters
	{
		 get { } //Length: 6
	}

	public AsymmetricAlgorithm Key
	{
		 get { } //Length: 6
	}

	public Oid Oid
	{
		 get { } //Length: 333
	}

	private static PublicKey() { }

	internal PublicKey(X509Certificate certificate) { }

	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	public AsnEncodedData get_EncodedKeyValue() { }

	public AsnEncodedData get_EncodedParameters() { }

	public AsymmetricAlgorithm get_Key() { }

	public Oid get_Oid() { }

	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

}

