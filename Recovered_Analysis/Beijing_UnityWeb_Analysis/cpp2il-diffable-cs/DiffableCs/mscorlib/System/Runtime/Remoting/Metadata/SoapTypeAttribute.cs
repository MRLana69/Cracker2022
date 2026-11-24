namespace System.Runtime.Remoting.Metadata;

public sealed class SoapTypeAttribute : SoapAttribute
{
	private bool _useAttribute; //Field offset: 0x14
	private string _xmlElementName; //Field offset: 0x18
	private string _xmlNamespace; //Field offset: 0x1C
	private string _xmlTypeName; //Field offset: 0x20
	private string _xmlTypeNamespace; //Field offset: 0x24
	private bool _isType; //Field offset: 0x28
	private bool _isElement; //Field offset: 0x29

	internal bool IsInteropXmlElement
	{
		 get { } //Length: 6
	}

	internal bool IsInteropXmlType
	{
		 get { } //Length: 9
	}

	public override bool UseAttribute
	{
		 get { } //Length: 6
	}

	public string XmlElementName
	{
		 get { } //Length: 9
	}

	public override string XmlNamespace
	{
		 get { } //Length: 6
	}

	public string XmlTypeName
	{
		 get { } //Length: 6
	}

	public string XmlTypeNamespace
	{
		 get { } //Length: 6
	}

	public SoapTypeAttribute() { }

	internal bool get_IsInteropXmlElement() { }

	internal bool get_IsInteropXmlType() { }

	public override bool get_UseAttribute() { }

	public string get_XmlElementName() { }

	public override string get_XmlNamespace() { }

	public string get_XmlTypeName() { }

	public string get_XmlTypeNamespace() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

