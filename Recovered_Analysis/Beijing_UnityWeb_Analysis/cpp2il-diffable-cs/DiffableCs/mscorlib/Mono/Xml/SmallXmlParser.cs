namespace Mono.Xml;

internal class SmallXmlParser
{
	private class AttrListImpl : IAttrList
	{
		private List<string> attrNames; //Field offset: 0x8
		private List<string> attrValues; //Field offset: 0xC

		public int Length
		{
			 get { } //Length: 188
		}

		public string[] Names
		{
			 get { } //Length: 52
		}

		public string[] Values
		{
			 get { } //Length: 52
		}

		public AttrListImpl() { }

		internal void Add(string name, string value) { }

		internal void Clear() { }

		public int get_Length() { }

		public string[] get_Names() { }

		public string[] get_Values() { }

		public string GetName(int i) { }

		public string GetValue(int i) { }

		public string GetValue(string name) { }

	}

	public interface IAttrList
	{

		public int Length
		{
			 get { } //Length: 0
		}

		public string[] Names
		{
			 get { } //Length: 0
		}

		public string[] Values
		{
			 get { } //Length: 0
		}

		public int get_Length() { }

		public string[] get_Names() { }

		public string[] get_Values() { }

		public string GetName(int i) { }

		public string GetValue(int i) { }

		public string GetValue(string name) { }

	}

	public interface IContentHandler
	{

		public void OnChars(string text) { }

		public void OnEndElement(string name) { }

		public void OnEndParsing(SmallXmlParser parser) { }

		public void OnIgnorableWhitespace(string text) { }

		public void OnProcessingInstruction(string name, string text) { }

		public void OnStartElement(string name, IAttrList attrs) { }

		public void OnStartParsing(SmallXmlParser parser) { }

	}

	private IContentHandler handler; //Field offset: 0x8
	private TextReader reader; //Field offset: 0xC
	private Stack elementNames; //Field offset: 0x10
	private Stack xmlSpaces; //Field offset: 0x14
	private string xmlSpace; //Field offset: 0x18
	private StringBuilder buffer; //Field offset: 0x1C
	private char[] nameBuffer; //Field offset: 0x20
	private bool isWhitespace; //Field offset: 0x24
	private AttrListImpl attributes; //Field offset: 0x28
	private int line; //Field offset: 0x2C
	private int column; //Field offset: 0x30
	private bool resetColumn; //Field offset: 0x34

	public SmallXmlParser() { }

	private void Cleanup() { }

	private Exception Error(string msg) { }

	public void Expect(int c) { }

	private void HandleBufferedContent() { }

	private void HandleWhitespaces() { }

	private bool IsNameChar(char c, bool start) { }

	private bool IsWhitespace(int c) { }

	public void Parse(TextReader input, IContentHandler handler) { }

	private int Peek() { }

	private int Read() { }

	private void ReadAttribute(AttrListImpl a) { }

	private void ReadCDATASection() { }

	private int ReadCharacterReference() { }

	private void ReadCharacters() { }

	private void ReadComment() { }

	public void ReadContent() { }

	public string ReadName() { }

	private void ReadReference() { }

	private string ReadUntil(char until, bool handleReferences) { }

	public void SkipWhitespaces(bool expected) { }

	public void SkipWhitespaces() { }

	private Exception UnexpectedEndError() { }

}

