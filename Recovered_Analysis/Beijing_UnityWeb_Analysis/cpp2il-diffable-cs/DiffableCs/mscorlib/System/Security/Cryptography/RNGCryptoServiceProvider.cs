namespace System.Security.Cryptography;

public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	private static object _lock; //Field offset: 0x0
	private nint _handle; //Field offset: 0x8

	private static RNGCryptoServiceProvider() { }

	public RNGCryptoServiceProvider() { }

	public RNGCryptoServiceProvider(byte[] rgb) { }

	public RNGCryptoServiceProvider(CspParameters cspParams) { }

	public RNGCryptoServiceProvider(string str) { }

	private void Check() { }

	protected override void Dispose(bool disposing) { }

	protected override void Finalize() { }

	public override void GetBytes(byte[] data) { }

	public override void GetNonZeroBytes(byte[] data) { }

	private static void RngClose(nint handle) { }

	private static nint RngGetBytes(nint handle, byte[] data) { }

	private static nint RngInitialize(byte[] seed) { }

	private static bool RngOpen() { }

}

