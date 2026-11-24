namespace System.Security.Cryptography;

public sealed class TripleDESCryptoServiceProvider : TripleDES
{

	public TripleDESCryptoServiceProvider() { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

}

