namespace UnityEngine;

public struct Plane
{
	internal const int size = 16; //Field offset: 0x0
	private Vector3 m_Normal; //Field offset: 0x0
	private float m_Distance; //Field offset: 0xC

	public float distance
	{
		 get { } //Length: 121
	}

	public Vector3 normal
	{
		 get { } //Length: 59
	}

	public Plane(Vector3 inNormal, Vector3 inPoint) { }

	public Plane(Vector3 inNormal, float d) { }

	public Plane(Vector3 a, Vector3 b, Vector3 c) { }

	public float get_distance() { }

	public Vector3 get_normal() { }

	public bool Raycast(Ray ray, out float enter) { }

	public override string ToString() { }

}

