namespace UnityEngine;

public struct Bounds : IEquatable<Bounds>
{
	private Vector3 m_Center; //Field offset: 0x0
	private Vector3 m_Extents; //Field offset: 0xC

	public Vector3 center
	{
		 get { } //Length: 10
		 set { } //Length: 14
	}

	public Vector3 extents
	{
		 get { } //Length: 49
		 set { } //Length: 14
	}

	public Vector3 max
	{
		 get { } //Length: 49
		 set { } //Length: 14
	}

	public Vector3 min
	{
		 get { } //Length: 49
		 set { } //Length: 14
	}

	public Vector3 size
	{
		 get { } //Length: 49
		 set { } //Length: 14
	}

	public Bounds(Vector3 center, Vector3 size) { }

	public bool Contains(Vector3 point) { }

	private static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	public void Encapsulate(Bounds bounds) { }

	public void Encapsulate(Vector3 point) { }

	public bool Equals(Bounds other) { }

	public override bool Equals(object other) { }

	public Vector3 get_center() { }

	public Vector3 get_extents() { }

	public Vector3 get_max() { }

	public Vector3 get_min() { }

	public Vector3 get_size() { }

	public override int GetHashCode() { }

	public bool Intersects(Bounds bounds) { }

	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	public void set_center(Vector3 value) { }

	public void set_extents(Vector3 value) { }

	public void set_max(Vector3 value) { }

	public void set_min(Vector3 value) { }

	public void set_size(Vector3 value) { }

	public void SetMinMax(Vector3 min, Vector3 max) { }

	public override string ToString() { }

}

