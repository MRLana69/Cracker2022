namespace UnityEngine;

public struct AnimatorTransitionInfo
{
	private int m_FullPath; //Field offset: 0x0
	private int m_UserName; //Field offset: 0x4
	private int m_Name; //Field offset: 0x8
	private bool m_HasFixedDuration; //Field offset: 0xC
	private float m_Duration; //Field offset: 0x10
	private float m_NormalizedTime; //Field offset: 0x14
	private bool m_AnyState; //Field offset: 0x18
	private int m_TransitionType; //Field offset: 0x1C

	public int fullPathHash
	{
		 get { } //Length: 9
	}

	public int get_fullPathHash() { }

}

