namespace UnityEngine.Serialization;

public class FormerlySerializedAsAttribute : Attribute
{
	private string m_oldName; //Field offset: 0x8

	public FormerlySerializedAsAttribute(string oldName) { }

}

