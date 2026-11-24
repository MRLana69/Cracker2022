namespace System.IO;

public class BinaryWriter : IDisposable
{
	public static readonly BinaryWriter Null; //Field offset: 0x0
	protected Stream OutStream; //Field offset: 0x8
	private byte[] _buffer; //Field offset: 0xC
	private Encoding _encoding; //Field offset: 0x10
	private Encoder _encoder; //Field offset: 0x14
	private bool _leaveOpen; //Field offset: 0x18
	private byte[] _largeByteBuffer; //Field offset: 0x1C
	private int _maxChars; //Field offset: 0x20

	private static BinaryWriter() { }

	public BinaryWriter(Stream output, Encoding encoding, bool leaveOpen) { }

	protected BinaryWriter() { }

	public BinaryWriter(Stream output) { }

	public BinaryWriter(Stream output, Encoding encoding) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public virtual void Flush() { }

	public virtual void Write(string value) { }

	public virtual void Write(float value) { }

	public virtual void Write(ulong value) { }

	public virtual void Write(long value) { }

	public virtual void Write(uint value) { }

	public virtual void Write(int value) { }

	public virtual void Write(ushort value) { }

	public virtual void Write(double value) { }

	public virtual void Write(decimal value) { }

	public virtual void Write(char ch) { }

	public virtual void Write(byte[] buffer, int index, int count) { }

	public virtual void Write(byte[] buffer) { }

	public virtual void Write(byte value) { }

	public virtual void Write(bool value) { }

	public virtual void Write(short value) { }

	public virtual void Write(char[] chars) { }

	protected void Write7BitEncodedInt(int value) { }

}

