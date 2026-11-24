namespace System.Security.Cryptography;

public sealed class SHA1CryptoServiceProvider : SHA1
{
	private SHA1Internal sha; //Field offset: 0x18

	public SHA1CryptoServiceProvider() { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected override byte[] HashFinal() { }

	public override void Initialize() { }

}

