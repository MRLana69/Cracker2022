namespace System.Runtime.Remoting.Metadata;

public sealed class SoapFieldAttribute : SoapAttribute
{
	private string _elementName; //Field offset: 0x14
	private bool _isElement; //Field offset: 0x18

	public string XmlElementName
	{
		 get { } //Length: 6
	}

	public SoapFieldAttribute() { }

	public string get_XmlElementName() { }

	public bool IsInteropXmlElement() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

