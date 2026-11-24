namespace UnityEngine;

public class Collision
{
	internal Vector3 m_Impulse; //Field offset: 0x8
	internal Vector3 m_RelativeVelocity; //Field offset: 0x14
	internal Rigidbody m_Rigidbody; //Field offset: 0x20
	internal Collider m_Collider; //Field offset: 0x24
	internal int m_ContactCount; //Field offset: 0x28
	internal ContactPoint[] m_ReusedContacts; //Field offset: 0x2C
	internal ContactPoint[] m_LegacyContacts; //Field offset: 0x30

}

