namespace SYBO.Components.Crypt;

public class SimpleAES : ICrypt
{
	private const int KIVLength = 16; //Field offset: 0x0
	private Aes _aes; //Field offset: 0x8

	public SimpleAES(byte[] key) { }

	public string Decrypt(string encrypted) { }

	public byte[] Decrypt(byte[] buffer) { }

	public string Encrypt(string unencrypted) { }

	public byte[] Encrypt(byte[] buffer) { }

	public static byte[] GenerateKey() { }

	private static byte[] Transform(byte[] buffer, ICryptoTransform transform) { }

}

