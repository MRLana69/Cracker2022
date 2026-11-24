namespace Mono.Xml;

internal class SmallXmlParserException : SystemException
{
	private int line; //Field offset: 0x44
	private int column; //Field offset: 0x48

	public SmallXmlParserException(string msg, int line, int column) { }

}

