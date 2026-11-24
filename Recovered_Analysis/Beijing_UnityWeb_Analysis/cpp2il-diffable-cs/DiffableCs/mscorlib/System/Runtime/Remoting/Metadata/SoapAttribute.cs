namespace System.Runtime.Remoting.Metadata;

public class SoapAttribute : Attribute
{
	private bool _useAttribute; //Field offset: 0x8
	protected string ProtXmlNamespace; //Field offset: 0xC
	protected object ReflectInfo; //Field offset: 0x10

	public virtual bool UseAttribute
	{
		 get { } //Length: 46
	}

	public virtual string XmlNamespace
	{
		 get { } //Length: 9
	}

	public SoapAttribute() { }

	public virtual bool get_UseAttribute() { }

	public virtual string get_XmlNamespace() { }

	internal virtual void SetReflectionObject(object reflectionObject) { }

}

