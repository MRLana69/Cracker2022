namespace System.Security.Util;

internal sealed class Tokenizer
{
	internal interface ITokenReader
	{

		public int Read() { }

	}

	internal class StreamTokenReader : ITokenReader
	{
		internal StreamReader _in; //Field offset: 0x8
		internal int _numCharRead; //Field offset: 0xC

		internal int NumCharEncountered
		{
			 get { } //Length: 40
		}

		internal StreamTokenReader(StreamReader input) { }

		internal int get_NumCharEncountered() { }

		public virtual int Read() { }

	}

	internal sealed class StringMaker
	{
		private string[] aStrings; //Field offset: 0x8
		private uint cStringsMax; //Field offset: 0xC
		private uint cStringsUsed; //Field offset: 0x10
		public StringBuilder _outStringBuilder; //Field offset: 0x14
		public char[] _outChars; //Field offset: 0x18
		public int _outIndex; //Field offset: 0x1C

		public StringMaker() { }

		private bool CompareStringAndChars(string str, char[] a, int l) { }

		private static uint HashCharArray(char[] a, int l) { }

		private static uint HashString(string str) { }

		public string MakeString() { }

	}

	private enum TokenSource
	{
		UnicodeByteArray = 0,
		UTF8ByteArray = 1,
		ASCIIByteArray = 2,
		CharArray = 3,
		String = 4,
		NestedStrings = 5,
		Other = 6,
	}

	public int LineNo; //Field offset: 0x8
	private int _inProcessingTag; //Field offset: 0xC
	private byte[] _inBytes; //Field offset: 0x10
	private char[] _inChars; //Field offset: 0x14
	private string _inString; //Field offset: 0x18
	private int _inIndex; //Field offset: 0x1C
	private int _inSize; //Field offset: 0x20
	private int _inSavedCharacter; //Field offset: 0x24
	private TokenSource _inTokenSource; //Field offset: 0x28
	private ITokenReader _inTokenReader; //Field offset: 0x2C
	private StringMaker _maker; //Field offset: 0x30
	private string[] _searchStrings; //Field offset: 0x34
	private string[] _replaceStrings; //Field offset: 0x38
	private int _inNestedIndex; //Field offset: 0x3C
	private int _inNestedSize; //Field offset: 0x40
	private string _inNestedString; //Field offset: 0x44

	internal Tokenizer(string input) { }

	internal void BasicInitialization() { }

	internal void ChangeFormat(Encoding encoding) { }

	private string GetStringToken() { }

	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	public void Recycle() { }

}

