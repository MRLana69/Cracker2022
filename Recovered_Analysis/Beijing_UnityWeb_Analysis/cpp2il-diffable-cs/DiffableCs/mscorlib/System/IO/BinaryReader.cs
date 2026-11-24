namespace System.IO;

public class BinaryReader : IDisposable
{
	private Stream m_stream; //Field offset: 0x8
	private byte[] m_buffer; //Field offset: 0xC
	private Decoder m_decoder; //Field offset: 0x10
	private byte[] m_charBytes; //Field offset: 0x14
	private char[] m_singleChar; //Field offset: 0x18
	private char[] m_charBuffer; //Field offset: 0x1C
	private int m_maxCharsSize; //Field offset: 0x20
	private bool m_2BytesPerChar; //Field offset: 0x24
	private bool m_isMemoryStream; //Field offset: 0x25
	private bool m_leaveOpen; //Field offset: 0x26

	public virtual Stream BaseStream
	{
		 get { } //Length: 49
	}

	public BinaryReader(Stream input) { }

	public BinaryReader(Stream input, Encoding encoding) { }

	public BinaryReader(Stream input, Encoding encoding, bool leaveOpen) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	protected virtual void FillBuffer(int numBytes) { }

	public virtual Stream get_BaseStream() { }

	private int InternalReadChars(char[] buffer, int index, int count) { }

	private int InternalReadOneChar() { }

	public virtual int Read() { }

	public virtual int Read(byte[] buffer, int index, int count) { }

	protected internal int Read7BitEncodedInt() { }

	public virtual bool ReadBoolean() { }

	public virtual byte ReadByte() { }

	public virtual byte[] ReadBytes(int count) { }

	public virtual char ReadChar() { }

	public virtual char[] ReadChars(int count) { }

	public virtual decimal ReadDecimal() { }

	public virtual double ReadDouble() { }

	public virtual short ReadInt16() { }

	public virtual int ReadInt32() { }

	public virtual long ReadInt64() { }

	public virtual sbyte ReadSByte() { }

	public virtual float ReadSingle() { }

	public virtual string ReadString() { }

	public virtual ushort ReadUInt16() { }

	public virtual uint ReadUInt32() { }

	public virtual ulong ReadUInt64() { }

}

