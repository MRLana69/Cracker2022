namespace System.Security;

public sealed class SecureString : IDisposable
{
	private int length; //Field offset: 0x8
	private bool disposed; //Field offset: 0xC
	private byte[] data; //Field offset: 0x10

	public int Length
	{
		 get { } //Length: 13
	}

	public SecureString() { }

	public SecureString(char* value, int length) { }

	private void Alloc(int length, bool realloc) { }

	private void Decrypt() { }

	public void Dispose() { }

	private void Encrypt() { }

	public int get_Length() { }

	internal byte[] GetBuffer() { }

}

