namespace UnityEngine;

public struct ContactPoint2D
{
	private Vector2 m_Point; //Field offset: 0x0
	private Vector2 m_Normal; //Field offset: 0x8
	private Vector2 m_RelativeVelocity; //Field offset: 0x10
	private float m_Separation; //Field offset: 0x18
	private float m_NormalImpulse; //Field offset: 0x1C
	private float m_TangentImpulse; //Field offset: 0x20
	private int m_Collider; //Field offset: 0x24
	private int m_OtherCollider; //Field offset: 0x28
	private int m_Rigidbody; //Field offset: 0x2C
	private int m_OtherRigidbody; //Field offset: 0x30
	private int m_Enabled; //Field offset: 0x34

}

