namespace UnityEngine;

public class Collision2D
{
	internal int m_Collider; //Field offset: 0x8
	internal int m_OtherCollider; //Field offset: 0xC
	internal int m_Rigidbody; //Field offset: 0x10
	internal int m_OtherRigidbody; //Field offset: 0x14
	internal Vector2 m_RelativeVelocity; //Field offset: 0x18
	internal int m_Enabled; //Field offset: 0x20
	internal int m_ContactCount; //Field offset: 0x24
	internal ContactPoint2D[] m_ReusedContacts; //Field offset: 0x28
	internal ContactPoint2D[] m_LegacyContacts; //Field offset: 0x2C

}

