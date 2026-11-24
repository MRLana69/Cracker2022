namespace System.Text;

public abstract class Encoding : ICloneable
{
	internal class DefaultDecoder : Decoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding; //Field offset: 0x10
		private bool m_hasInitializedEncoding; //Field offset: 0x14

		public DefaultDecoder(Encoding encoding) { }

		internal DefaultDecoder(SerializationInfo info, StreamingContext context) { }

		public override int GetCharCount(byte[] bytes, int index, int count) { }

		public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

		public override int GetCharCount(byte* bytes, int count, bool flush) { }

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

		public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

		public object GetRealObject(StreamingContext context) { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal class DefaultEncoder : Encoder, ISerializable, IObjectReference
	{
		private Encoding m_encoding; //Field offset: 0x10
		private bool m_hasInitializedEncoding; //Field offset: 0x14
		internal char charLeftOver; //Field offset: 0x16

		public DefaultEncoder(Encoding encoding) { }

		internal DefaultEncoder(SerializationInfo info, StreamingContext context) { }

		public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

		public override int GetByteCount(char* chars, int count, bool flush) { }

		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

		public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

		public object GetRealObject(StreamingContext context) { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal class EncodingByteBuffer
	{
		private byte* bytes; //Field offset: 0x8
		private byte* byteStart; //Field offset: 0xC
		private byte* byteEnd; //Field offset: 0x10
		private char* chars; //Field offset: 0x14
		private char* charStart; //Field offset: 0x18
		private char* charEnd; //Field offset: 0x1C
		private int byteCountResult; //Field offset: 0x20
		private Encoding enc; //Field offset: 0x24
		private EncoderNLS encoder; //Field offset: 0x28
		internal EncoderFallbackBuffer fallbackBuffer; //Field offset: 0x2C

		internal int CharsUsed
		{
			 get { } //Length: 64
		}

		internal int Count
		{
			 get { } //Length: 15
		}

		internal bool MoreData
		{
			 get { } //Length: 6
		}

		internal EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount) { }

		internal bool AddByte(byte b, int moreBytesExpected) { }

		internal bool AddByte(byte b1) { }

		internal bool AddByte(byte b1, byte b2) { }

		internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

		internal int get_CharsUsed() { }

		internal int get_Count() { }

		internal bool get_MoreData() { }

		internal char GetNextChar() { }

		internal void MovePrevious(bool bThrow) { }

	}

	internal class EncodingCharBuffer
	{
		private char* chars; //Field offset: 0x8
		private char* charStart; //Field offset: 0xC
		private char* charEnd; //Field offset: 0x10
		private int charCountResult; //Field offset: 0x14
		private Encoding enc; //Field offset: 0x18
		private DecoderNLS decoder; //Field offset: 0x1C
		private byte* byteStart; //Field offset: 0x20
		private byte* byteEnd; //Field offset: 0x24
		private byte* bytes; //Field offset: 0x28
		private DecoderFallbackBuffer fallbackBuffer; //Field offset: 0x2C

		internal int BytesUsed
		{
			 get { } //Length: 38
		}

		internal int Count
		{
			 get { } //Length: 12
		}

		internal bool MoreData
		{
			 get { } //Length: 89
		}

		internal EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount) { }

		internal bool AddChar(char ch, int numBytes) { }

		internal bool AddChar(char ch) { }

		internal void AdjustBytes(int count) { }

		internal bool Fallback(byte fallbackByte) { }

		internal bool Fallback(byte[] byteBuffer) { }

		internal int get_BytesUsed() { }

		internal int get_Count() { }

		internal bool get_MoreData() { }

		internal byte GetNextByte() { }

	}

	private static Encoding defaultEncoding; //Field offset: 0x0
	private const int ChineseHZ = 52936; //Field offset: 0x0
	private const int DuplicateEUCCN = 51936; //Field offset: 0x0
	private const int EUCCN = 936; //Field offset: 0x0
	private const int EUCKR = 51949; //Field offset: 0x0
	internal const int CodePageASCII = 20127; //Field offset: 0x0
	internal const int ISO_8859_1 = 28591; //Field offset: 0x0
	private const int ISCIIAssemese = 57006; //Field offset: 0x0
	private const int ISCIIBengali = 57003; //Field offset: 0x0
	private const int ISCIIDevanagari = 57002; //Field offset: 0x0
	private const int ISCIIGujarathi = 57010; //Field offset: 0x0
	private const int ISCIIKannada = 57008; //Field offset: 0x0
	private const int ISOSimplifiedCN = 50227; //Field offset: 0x0
	private const int ISCIIMalayalam = 57009; //Field offset: 0x0
	private const int ISCIIPanjabi = 57011; //Field offset: 0x0
	private const int ISCIITamil = 57004; //Field offset: 0x0
	private const int ISCIITelugu = 57005; //Field offset: 0x0
	private const int GB18030 = 54936; //Field offset: 0x0
	private const int ISO_8859_8I = 38598; //Field offset: 0x0
	private const int ISO_8859_8_Visual = 28598; //Field offset: 0x0
	private const int ENC50229 = 50229; //Field offset: 0x0
	private const int CodePageUTF7 = 65000; //Field offset: 0x0
	private const int CodePageUTF8 = 65001; //Field offset: 0x0
	private const int CodePageUTF32 = 12000; //Field offset: 0x0
	private const int CodePageUTF32BE = 12001; //Field offset: 0x0
	private const int ISCIIOriya = 57007; //Field offset: 0x0
	private const int ISOKorean = 50225; //Field offset: 0x0
	private const int EUCJP = 51932; //Field offset: 0x0
	private const int ISO2022JPESC = 50221; //Field offset: 0x0
	private const int MIMECONTF_MAILNEWS = 1; //Field offset: 0x0
	private const int MIMECONTF_BROWSER = 2; //Field offset: 0x0
	private const int ISO2022JPSISO = 50222; //Field offset: 0x0
	private const int MIMECONTF_SAVABLE_BROWSER = 512; //Field offset: 0x0
	private const int CodePageDefault = 0; //Field offset: 0x0
	private const int CodePageNoOEM = 1; //Field offset: 0x0
	private const int CodePageNoMac = 2; //Field offset: 0x0
	private const int CodePageNoThread = 3; //Field offset: 0x0
	private const int CodePageNoSymbol = 42; //Field offset: 0x0
	private const int MIMECONTF_SAVABLE_MAILNEWS = 256; //Field offset: 0x0
	private const int CodePageBigEndian = 1201; //Field offset: 0x0
	private const int CodePageWindows1252 = 1252; //Field offset: 0x0
	private const int CodePageMacGB2312 = 10008; //Field offset: 0x0
	private const int CodePageGB2312 = 20936; //Field offset: 0x0
	private const int CodePageMacKorean = 10003; //Field offset: 0x0
	private const int CodePageDLLKorean = 20949; //Field offset: 0x0
	private const int ISO2022JP = 50220; //Field offset: 0x0
	private const int CodePageUnicode = 1200; //Field offset: 0x0
	private static Encoding unicodeEncoding; //Field offset: 0x4
	private static Encoding bigEndianUnicode; //Field offset: 0x8
	private static Encoding utf7Encoding; //Field offset: 0xC
	private static Encoding utf8Encoding; //Field offset: 0x10
	private static Encoding utf32Encoding; //Field offset: 0x14
	private static Encoding asciiEncoding; //Field offset: 0x18
	private static Encoding latin1Encoding; //Field offset: 0x1C
	private static Hashtable encodings; //Field offset: 0x20
	private static object s_InternalSyncObject; //Field offset: 0x24
	internal int m_codePage; //Field offset: 0x8
	internal CodePageDataItem dataItem; //Field offset: 0xC
	internal bool m_deserializedFromEverett; //Field offset: 0x10
	private bool m_isReadOnly; //Field offset: 0x11
	internal EncoderFallback encoderFallback; //Field offset: 0x14
	internal DecoderFallback decoderFallback; //Field offset: 0x18

	public static Encoding ASCII
	{
		 get { } //Length: 118
	}

	public static Encoding BigEndianUnicode
	{
		 get { } //Length: 110
	}

	public virtual int CodePage
	{
		 get { } //Length: 9
	}

	public DecoderFallback DecoderFallback
	{
		 get { } //Length: 6
		 set { } //Length: 151
	}

	public static Encoding Default
	{
		 get { } //Length: 86
	}

	public EncoderFallback EncoderFallback
	{
		 get { } //Length: 29
		 set { } //Length: 11
	}

	public virtual string EncodingName
	{
		 get { } //Length: 89
	}

	public virtual string HeaderName
	{
		 get { } //Length: 12
	}

	private static object InternalSyncObject
	{
		 get { } //Length: 520
	}

	public bool IsReadOnly
	{
		 get { } //Length: 62
	}

	private static Encoding Latin1
	{
		 get { } //Length: 106
	}

	public static Encoding Unicode
	{
		 get { } //Length: 91
	}

	public static Encoding UTF32
	{
		 get { } //Length: 108
	}

	public static Encoding UTF7
	{
		 get { } //Length: 110
	}

	public static Encoding UTF8
	{
		 get { } //Length: 106
	}

	public virtual string WebName
	{
		 get { } //Length: 29
	}

	protected Encoding() { }

	protected Encoding(int codePage) { }

	public virtual object Clone() { }

	private static Encoding CreateDefaultEncoding() { }

	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object value) { }

	public static Encoding get_ASCII() { }

	public static Encoding get_BigEndianUnicode() { }

	public virtual int get_CodePage() { }

	public DecoderFallback get_DecoderFallback() { }

	public static Encoding get_Default() { }

	public EncoderFallback get_EncoderFallback() { }

	public virtual string get_EncodingName() { }

	public virtual string get_HeaderName() { }

	private static object get_InternalSyncObject() { }

	public bool get_IsReadOnly() { }

	private static Encoding get_Latin1() { }

	public static Encoding get_Unicode() { }

	public static Encoding get_UTF32() { }

	public static Encoding get_UTF7() { }

	public static Encoding get_UTF8() { }

	public virtual string get_WebName() { }

	internal virtual char[] GetBestFitBytesToUnicodeData() { }

	internal virtual char[] GetBestFitUnicodeToBytesData() { }

	public virtual int GetByteCount(string s) { }

	public abstract int GetByteCount(char[] chars, int index, int count) { }

	public virtual int GetByteCount(char* chars, int count) { }

	internal virtual int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public virtual byte[] GetBytes(string s) { }

	internal virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public virtual byte[] GetBytes(char[] chars) { }

	public virtual byte[] GetBytes(char[] chars, int index, int count) { }

	public virtual int GetCharCount(byte[] bytes) { }

	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetCharCount(byte* bytes, int count) { }

	internal virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	public virtual char[] GetChars(byte[] bytes) { }

	public virtual char[] GetChars(byte[] bytes, int index, int count) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	internal virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	private void GetDataItem() { }

	public virtual Decoder GetDecoder() { }

	public virtual Encoder GetEncoder() { }

	public static Encoding GetEncoding(int codepage) { }

	public static Encoding GetEncoding(string name) { }

	public override int GetHashCode() { }

	public abstract int GetMaxByteCount(int charCount) { }

	public abstract int GetMaxCharCount(int byteCount) { }

	public virtual byte[] GetPreamble() { }

	public virtual string GetString(byte[] bytes) { }

	public virtual string GetString(byte[] bytes, int index, int count) { }

	private void OnDeserialized(StreamingContext ctx) { }

	internal void OnDeserialized() { }

	private void OnDeserializing(StreamingContext ctx) { }

	internal void OnDeserializing() { }

	private void OnSerializing(StreamingContext ctx) { }

	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	public void set_DecoderFallback(DecoderFallback value) { }

	public void set_EncoderFallback(EncoderFallback value) { }

	internal virtual void SetDefaultFallbacks() { }

	internal void setReadOnly(bool value = true) { }

	internal void ThrowBytesOverflow() { }

	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	internal void ThrowCharsOverflow() { }

	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

}

