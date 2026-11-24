namespace UnityEngine;

public struct RaycastHit2D
{
	private Vector2 m_Centroid; //Field offset: 0x0
	private Vector2 m_Point; //Field offset: 0x8
	private Vector2 m_Normal; //Field offset: 0x10
	private float m_Distance; //Field offset: 0x18
	private float m_Fraction; //Field offset: 0x1C
	private int m_Collider; //Field offset: 0x20

	public Collider2D collider
	{
		 get { } //Length: 213
	}

	public float distance
	{
		 get { } //Length: 49
	}

	public Vector2 normal
	{
		 get { } //Length: 39
	}

	public Vector2 point
	{
		 get { } //Length: 54
	}

	public Collider2D get_collider() { }

	public float get_distance() { }

	public Vector2 get_normal() { }

	public Vector2 get_point() { }

}

