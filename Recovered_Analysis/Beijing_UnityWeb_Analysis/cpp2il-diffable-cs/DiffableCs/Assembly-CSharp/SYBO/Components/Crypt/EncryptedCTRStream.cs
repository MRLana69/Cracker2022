namespace SYBO.Components.Crypt;

public class EncryptedCTRStream : Stream, IDisposable
{
	private const int KeySize = 16; //Field offset: 0x0
	private const int HeaderSize = 32; //Field offset: 0x0
	private byte[] _counter; //Field offset: 0x14
	private byte[] _key; //Field offset: 0x18
	private AesManaged _aes; //Field offset: 0x1C
	private Stream _stream; //Field offset: 0x20
	private CryptoStream _cryptoStream; //Field offset: 0x24

	public override bool CanRead
	{
		 get { } //Length: 81
	}

	public override bool CanSeek
	{
		 get { } //Length: 12
	}

	public override bool CanWrite
	{
		 get { } //Length: 3
	}

	public override long Length
	{
		 get { } //Length: 23
	}

	public override long Position
	{
		 get { } //Length: 15
		 set { } //Length: 94
	}

	public EncryptedCTRStream() { }

	public void Dispose() { }

	protected override void Finalize() { }

	public override void Flush() { }

	public override bool get_CanRead() { }

	public override bool get_CanSeek() { }

	public override bool get_CanWrite() { }

	public override long get_Length() { }

	public override long get_Position() { }

	public override int Read(byte[] buffer, int offset, int count) { }

	public static EncryptedCTRStream ReadStream(Stream stream) { }

	public override long Seek(long offset, SeekOrigin origin) { }

	public override void set_Position(long value) { }

	public override void SetLength(long value) { }

	private void SetupRead(Stream stream) { }

	private void SetupWrite(Stream stream) { }

	public override void Write(byte[] buffer, int offset, int count) { }

	public static EncryptedCTRStream WriteStream(Stream stream) { }

}

