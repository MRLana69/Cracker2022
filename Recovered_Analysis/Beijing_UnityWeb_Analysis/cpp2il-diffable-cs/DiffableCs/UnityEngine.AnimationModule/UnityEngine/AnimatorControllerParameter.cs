namespace UnityEngine;

public class AnimatorControllerParameter
{
	internal string m_Name; //Field offset: 0x8
	internal AnimatorControllerParameterType m_Type; //Field offset: 0xC
	internal float m_DefaultFloat; //Field offset: 0x10
	internal int m_DefaultInt; //Field offset: 0x14
	internal bool m_DefaultBool; //Field offset: 0x18

	public string name
	{
		 get { } //Length: 49
	}

	public int nameHash
	{
		 get { } //Length: 6
	}

	public AnimatorControllerParameterType type
	{
		 get { } //Length: 12
	}

	public AnimatorControllerParameter() { }

	public override bool Equals(object o) { }

	public string get_name() { }

	public int get_nameHash() { }

	public AnimatorControllerParameterType get_type() { }

	public override int GetHashCode() { }

}

