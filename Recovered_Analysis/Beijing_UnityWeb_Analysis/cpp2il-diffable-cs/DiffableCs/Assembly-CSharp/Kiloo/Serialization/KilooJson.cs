namespace Kiloo.Serialization;

public static class KilooJson
{
	private sealed class Parser : IDisposable
	{
		private enum TOKEN
		{
			NONE = 0,
			CURLY_OPEN = 1,
			CURLY_CLOSE = 2,
			SQUARED_OPEN = 3,
			SQUARED_CLOSE = 4,
			COLON = 5,
			COMMA = 6,
			STRING = 7,
			NUMBER = 8,
			TRUE = 9,
			FALSE = 10,
			NULL = 11,
		}

		private const string WHITE_SPACE = " 	
"; //Field offset: 0x0
		private const string WORD_BREAK = " 	
{}[],:""; //Field offset: 0x0
		private StringReader json; //Field offset: 0x8
		private readonly bool ignoreCase; //Field offset: 0xC

		private char NextChar
		{
			 get { } //Length: 88
		}

		private TOKEN NextToken
		{
			 get { } //Length: 133
		}

		private string NextWord
		{
			 get { } //Length: 88
		}

		private char PeekChar
		{
			 get { } //Length: 229
		}

		private Parser(string jsonString, bool ignoreCase) { }

		public void Dispose() { }

		private void EatWhitespace() { }

		private char get_NextChar() { }

		private TOKEN get_NextToken() { }

		private string get_NextWord() { }

		private char get_PeekChar() { }

		public static object Parse(string jsonString, bool ignoreCase) { }

		private List<object> ParseArray() { }

		private object ParseByToken(TOKEN token) { }

		private object ParseNumber() { }

		private Dictionary<string, object> ParseObject() { }

		private string ParseString() { }

		private object ParseValue() { }

	}

	private sealed class Serializer
	{
		private const char INDENT_CHAR = '\u20'; //Field offset: 0x0
		private const string NEWLINE = "
"; //Field offset: 0x0
		private const int INDENT_STEP = 2; //Field offset: 0x0
		private readonly StringBuilder builder; //Field offset: 0x8
		private readonly bool indent; //Field offset: 0xC
		private int currentIndentation; //Field offset: 0x10

		private Serializer(bool indent) { }

		public static string Serialize(object obj, bool indent) { }

		private void SerializeArray(IEnumerable anArray) { }

		private void SerializeObject(IDictionary obj) { }

		private void SerializeString(string str) { }

		private void SerializeValue(object value) { }

	}


	public static object Deserialize(string json, bool ignoreCase = false) { }

	public static string Serialize(object obj, bool indent = false) { }

}

