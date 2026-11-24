namespace System.Runtime.Serialization;

internal class ValueTypeFixupInfo
{
	private long m_containerID; //Field offset: 0x8
	private FieldInfo m_parentField; //Field offset: 0x10
	private int[] m_parentIndex; //Field offset: 0x14

	public long ContainerID
	{
		 get { } //Length: 21
	}

	public FieldInfo ParentField
	{
		 get { } //Length: 9
	}

	public int[] ParentIndex
	{
		 get { } //Length: 6
	}

	public ValueTypeFixupInfo(long containerID, FieldInfo member, int[] parentIndex) { }

	public long get_ContainerID() { }

	public FieldInfo get_ParentField() { }

	public int[] get_ParentIndex() { }

}

