namespace System.Net;

public class WebHeaderCollection : NameValueCollection, ISerializable
{
	private enum RfcChar
	{
		High = 0,
		Reg = 1,
		Ctl = 2,
		CR = 3,
		LF = 4,
		WS = 5,
		Colon = 6,
		Delim = 7,
	}

	private static readonly HeaderInfoTable HInfo; //Field offset: 0x0
	private static readonly string[] s_CommonHeaderNames; //Field offset: 0x4
	private static readonly sbyte[] s_CommonHeaderHints; //Field offset: 0x8
	private static readonly char[] HttpTrimCharacters; //Field offset: 0xC
	private static RfcChar[] RfcCharMap; //Field offset: 0x10
	private string[] m_CommonHeaders; //Field offset: 0x2C
	private int m_NumCommonHeaders; //Field offset: 0x30
	private NameValueCollection m_InnerCollection; //Field offset: 0x34
	private WebHeaderCollectionType m_Type; //Field offset: 0x38

	public override int Count
	{
		 get { } //Length: 99
	}

	private NameValueCollection InnerCollection
	{
		 get { } //Length: 363
	}

	private static WebHeaderCollection() { }

	protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public WebHeaderCollection() { }

	internal WebHeaderCollection(WebHeaderCollectionType type) { }

	public override void Add(string name, string value) { }

	internal void AddInternal(string name, string value) { }

	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	internal static bool ContainsNonAsciiChars(string token) { }

	public override string Get(int index) { }

	public override string Get(string name) { }

	public override int get_Count() { }

	private NameValueCollection get_InnerCollection() { }

	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	public override IEnumerator GetEnumerator() { }

	public override string GetKey(int index) { }

	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void NormalizeCommonHeaders() { }

	public override void OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal void ThrowOnRestrictedHeader(string headerName) { }

	public override string ToString() { }

}

