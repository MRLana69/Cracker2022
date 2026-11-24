namespace System.Runtime.Serialization;

public struct SerializationEntry
{
	private Type m_type; //Field offset: 0x0
	private object m_value; //Field offset: 0x4
	private string m_name; //Field offset: 0x8

	public string Name
	{
		 get { } //Length: 9
	}

	public object Value
	{
		 get { } //Length: 93
	}

	internal SerializationEntry(string entryName, object entryValue, Type entryType) { }

	public string get_Name() { }

	public object get_Value() { }

}

