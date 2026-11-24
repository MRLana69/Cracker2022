namespace Mono.Xml;

internal class SecurityParser : SmallXmlParser, IContentHandler
{
	private SecurityElement root; //Field offset: 0x38
	private SecurityElement current; //Field offset: 0x3C
	private Stack stack; //Field offset: 0x40

	public SecurityParser() { }

	public void LoadXml(string xml) { }

	public void OnChars(string ch) { }

	public void OnEndElement(string name) { }

	public void OnEndParsing(SmallXmlParser parser) { }

	public void OnIgnorableWhitespace(string s) { }

	public void OnProcessingInstruction(string name, string text) { }

	public void OnStartElement(string name, IAttrList attrs) { }

	public void OnStartParsing(SmallXmlParser parser) { }

	public SecurityElement ToXml() { }

}

