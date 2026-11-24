namespace SYBO.Components.Json.Internal;

public class JsonParser
{
	protected enum Token
	{
		None = 0,
		CurlyOpen = 1,
		CurlyClose = 2,
		SquaredOpen = 3,
		SquaredClose = 4,
		Colon = 5,
		Comma = 6,
		String = 7,
		Number = 8,
		True = 9,
		False = 10,
		Null = 11,
	}

	public static int BuilderCapacity; //Field offset: 0x0
	protected static int _lastErrorIndex; //Field offset: 0x4
	protected static string _lastDecode; //Field offset: 0x8
	private static int _indentation; //Field offset: 0xC
	private static List<string> _indentations; //Field offset: 0x10
	private static StringBuilder _stringParsingBuffer; //Field offset: 0x14
	private static HashSet<char> _possibleNumberChars; //Field offset: 0x18

	private static JsonParser() { }

	public JsonParser() { }

	protected static void AppendIndentation(StringBuilder builder, JsonContext context) { }

	public static T Deserialize(string json, JsonContext context = null) { }

	public static object DeserializeDom(string json) { }

	protected static void EatWhitespace(string json, ref int index) { }

	protected static string GetIndentationString() { }

	public static int GetLastErrorIndex() { }

	public static string GetLastErrorSnippet() { }

	protected static int GetLastIndexOfNumber(string json, int index) { }

	public static bool LastDecodeSuccessful() { }

	protected static Token LookAhead(string json, int index) { }

	protected static Token NextToken(string json, ref int index) { }

	protected static JsonList ParseArray(string json, ref int index) { }

	private static object ParseHex(string hexString) { }

	protected static object ParseNumber(string json, ref int index) { }

	protected static JsonDict ParseObject(string json, ref int index) { }

	protected static string ParseString(string json, ref int index) { }

	protected static object ParseValue(string json, ref int index, ref bool success) { }

	public static string Serialize(T obj, JsonContext context = null) { }

	protected static bool SerializeArray(Array anArray, StringBuilder builder, JsonContext context) { }

	protected static bool SerializeArray(IList anArray, StringBuilder builder, JsonContext context) { }

	public static string SerializeDom(object json, JsonContext context) { }

	protected static void SerializeNumber(double number, StringBuilder builder) { }

	protected static bool SerializeObject(IDictionary dict, StringBuilder builder, JsonContext context) { }

	protected static void SerializeString(string aString, StringBuilder builder) { }

	protected static bool SerializeValue(object value, StringBuilder builder, JsonContext context) { }

	private static IDictionaryEnumerator SetupDictionaryEnumerator(IDictionary dict) { }

}

