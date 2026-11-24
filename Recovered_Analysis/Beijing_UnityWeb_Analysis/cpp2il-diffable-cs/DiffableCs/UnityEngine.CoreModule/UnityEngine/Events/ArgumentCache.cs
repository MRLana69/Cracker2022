namespace UnityEngine.Events;

internal class ArgumentCache : ISerializationCallbackReceiver
{
	private Object m_ObjectArgument; //Field offset: 0x8
	private string m_ObjectArgumentAssemblyTypeName; //Field offset: 0xC
	private int m_IntArgument; //Field offset: 0x10
	private float m_FloatArgument; //Field offset: 0x14
	private string m_StringArgument; //Field offset: 0x18
	private bool m_BoolArgument; //Field offset: 0x1C

	public bool boolArgument
	{
		 get { } //Length: 6
	}

	public float floatArgument
	{
		 get { } //Length: 6
	}

	public int intArgument
	{
		 get { } //Length: 6
	}

	public string stringArgument
	{
		 get { } //Length: 6
	}

	public Object unityObjectArgument
	{
		 get { } //Length: 6
	}

	public string unityObjectArgumentAssemblyTypeName
	{
		 get { } //Length: 6
	}

	public ArgumentCache() { }

	public bool get_boolArgument() { }

	public float get_floatArgument() { }

	public int get_intArgument() { }

	public string get_stringArgument() { }

	public Object get_unityObjectArgument() { }

	public string get_unityObjectArgumentAssemblyTypeName() { }

	public void OnAfterDeserialize() { }

	public void OnBeforeSerialize() { }

	private void TidyAssemblyTypeName() { }

}

