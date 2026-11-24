namespace System.Runtime.Serialization;

public class ObjectIDGenerator
{
	private static readonly int[] sizes; //Field offset: 0x0
	internal int m_currentCount; //Field offset: 0x8
	internal int m_currentSize; //Field offset: 0xC
	internal long[] m_ids; //Field offset: 0x10
	internal object[] m_objs; //Field offset: 0x14

	private static ObjectIDGenerator() { }

	public ObjectIDGenerator() { }

	private int FindElement(object obj, out bool found) { }

	public virtual long GetId(object obj, out bool firstTime) { }

	public virtual long HasId(object obj, out bool firstTime) { }

	private void Rehash() { }

}

