namespace System.Runtime.Serialization;

public sealed class SerializationInfoEnumerator : IEnumerator
{
	private string[] m_members; //Field offset: 0x8
	private object[] m_data; //Field offset: 0xC
	private Type[] m_types; //Field offset: 0x10
	private int m_numItems; //Field offset: 0x14
	private int m_currItem; //Field offset: 0x18
	private bool m_current; //Field offset: 0x1C

	public SerializationEntry Current
	{
		 get { } //Length: 12
	}

	public string Name
	{
		 get { } //Length: 258
	}

	public Type ObjectType
	{
		 get { } //Length: 115
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 51
	}

	public object Value
	{
		 get { } //Length: 115
	}

	internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems) { }

	public SerializationEntry get_Current() { }

	public string get_Name() { }

	public Type get_ObjectType() { }

	public object get_Value() { }

	public bool MoveNext() { }

	public void Reset() { }

	private object System.Collections.IEnumerator.get_Current() { }

}

