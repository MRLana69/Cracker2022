namespace System.Runtime.Remoting.Metadata;

public sealed class SoapMethodAttribute : SoapAttribute
{
	private string _responseElement; //Field offset: 0x14
	private string _responseNamespace; //Field offset: 0x18
	private string _returnElement; //Field offset: 0x1C
	private string _soapAction; //Field offset: 0x20
	private bool _useAttribute; //Field offset: 0x24
	private string _namespace; //Field offset: 0x28

	public override bool UseAttribute
	{
		 get { } //Length: 9
	}

	public override string XmlNamespace
	{
		 get { } //Length: 9
	}

	public SoapMethodAttribute() { }

	public override bool get_UseAttribute() { }

	public override string get_XmlNamespace() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

