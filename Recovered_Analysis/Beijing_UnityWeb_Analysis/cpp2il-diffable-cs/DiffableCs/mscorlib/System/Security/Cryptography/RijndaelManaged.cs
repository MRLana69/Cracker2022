namespace System.Security.Cryptography;

public sealed class RijndaelManaged : Rijndael
{

	public RijndaelManaged() { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }

}

