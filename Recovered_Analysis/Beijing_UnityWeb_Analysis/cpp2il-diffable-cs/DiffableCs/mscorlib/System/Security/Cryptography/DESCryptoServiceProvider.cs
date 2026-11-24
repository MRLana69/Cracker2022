namespace System.Security.Cryptography;

public sealed class DESCryptoServiceProvider : DES
{

	public DESCryptoServiceProvider() { }

	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	public override void GenerateIV() { }

	public override void GenerateKey() { }

}

