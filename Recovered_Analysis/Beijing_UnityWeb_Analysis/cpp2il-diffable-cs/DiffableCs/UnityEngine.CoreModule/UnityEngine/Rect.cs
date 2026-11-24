namespace UnityEngine;

public struct Rect : IEquatable<Rect>
{
	private float m_XMin; //Field offset: 0x0
	private float m_YMin; //Field offset: 0x4
	private float m_Width; //Field offset: 0x8
	private float m_Height; //Field offset: 0xC

	public Vector2 center
	{
		 get { } //Length: 14
	}

	public float height
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public Vector2 max
	{
		 get { } //Length: 14
	}

	public Vector2 min
	{
		 get { } //Length: 14
	}

	public Vector2 position
	{
		 get { } //Length: 81
	}

	public Vector2 size
	{
		 get { } //Length: 14
	}

	public float width
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float x
	{
		 get { } //Length: 9
		 set { } //Length: 52
	}

	public float xMax
	{
		 get { } //Length: 9
		 set { } //Length: 39
	}

	public float xMin
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float y
	{
		 get { } //Length: 9
		 set { } //Length: 11
	}

	public float yMax
	{
		 get { } //Length: 17
		 set { } //Length: 19
	}

	public float yMin
	{
		 get { } //Length: 9
		 set { } //Length: 39
	}

	public static Rect zero
	{
		 get { } //Length: 158
	}

	public Rect(float x, float y, float width, float height) { }

	public Rect(Vector2 position, Vector2 size) { }

	public Rect(Rect source) { }

	public bool Contains(Vector3 point) { }

	public bool Contains(Vector2 point) { }

	public override bool Equals(object other) { }

	public bool Equals(Rect other) { }

	public Vector2 get_center() { }

	public float get_height() { }

	public Vector2 get_max() { }

	public Vector2 get_min() { }

	public Vector2 get_position() { }

	public Vector2 get_size() { }

	public float get_width() { }

	public float get_x() { }

	public float get_xMax() { }

	public float get_xMin() { }

	public float get_y() { }

	public float get_yMax() { }

	public float get_yMin() { }

	public static Rect get_zero() { }

	public override int GetHashCode() { }

	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	public static bool op_Equality(Rect lhs, Rect rhs) { }

	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	private static Rect OrderMinMax(Rect rect) { }

	public bool Overlaps(Rect other, bool allowInverse) { }

	public bool Overlaps(Rect other) { }

	public void set_height(float value) { }

	public void set_width(float value) { }

	public void set_x(float value) { }

	public void set_xMax(float value) { }

	public void set_xMin(float value) { }

	public void set_y(float value) { }

	public void set_yMax(float value) { }

	public void set_yMin(float value) { }

	public override string ToString() { }

}

