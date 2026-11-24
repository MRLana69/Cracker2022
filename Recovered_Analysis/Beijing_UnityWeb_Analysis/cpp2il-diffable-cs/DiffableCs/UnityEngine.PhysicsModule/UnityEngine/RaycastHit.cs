namespace UnityEngine;

public struct RaycastHit
{
	internal Vector3 m_Point; //Field offset: 0x0
	internal Vector3 m_Normal; //Field offset: 0xC
	internal uint m_FaceID; //Field offset: 0x18
	internal float m_Distance; //Field offset: 0x1C
	internal Vector2 m_UV; //Field offset: 0x20
	internal int m_Collider; //Field offset: 0x28

	public Collider collider
	{
		 get { } //Length: 49
	}

	public float distance
	{
		 get { } //Length: 49
	}

	public Vector3 normal
	{
		 get { } //Length: 14
	}

	public Vector3 point
	{
		 get { } //Length: 53
	}

	public Collider get_collider() { }

	public float get_distance() { }

	public Vector3 get_normal() { }

	public Vector3 get_point() { }

}

