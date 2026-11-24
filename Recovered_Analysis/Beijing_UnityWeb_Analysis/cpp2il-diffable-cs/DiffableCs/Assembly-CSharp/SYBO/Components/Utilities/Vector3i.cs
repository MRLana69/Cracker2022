namespace SYBO.Components.Utilities;

public struct Vector3i
{
	public int x; //Field offset: 0x0
	public int y; //Field offset: 0x4
	public int z; //Field offset: 0x8

	public static Vector3i back
	{
		 get { } //Length: 36
	}

	public static Vector3i down
	{
		 get { } //Length: 36
	}

	public static Vector3i forward
	{
		 get { } //Length: 36
	}

	public static Vector3i left
	{
		 get { } //Length: 36
	}

	public static Vector3i one
	{
		 get { } //Length: 36
	}

	public static Vector3i right
	{
		 get { } //Length: 36
	}

	public static Vector3i up
	{
		 get { } //Length: 36
	}

	public static Vector3i zero
	{
		 get { } //Length: 79
	}

	public Vector3i(int x, int y, int z) { }

	public Vector3 AsVector3() { }

	public bool Equals(Vector3i other) { }

	public override bool Equals(object obj) { }

	public static Vector3i get_back() { }

	public static Vector3i get_down() { }

	public static Vector3i get_forward() { }

	public static Vector3i get_left() { }

	public static Vector3i get_one() { }

	public static Vector3i get_right() { }

	public static Vector3i get_up() { }

	public static Vector3i get_zero() { }

	public override int GetHashCode() { }

	public static int Manhatten(Vector3i a, Vector3i b) { }

	public static Vector3i op_Addition(Vector3i a, Vector3i b) { }

	public static bool op_Equality(Vector3i a, Vector3i b) { }

	public static Vector3 op_Implicit(Vector3i v3i) { }

	public static bool op_Inequality(Vector3i a, Vector3i b) { }

	public static Vector3i op_Multiply(Vector3i a, int scale) { }

	public static Vector3i op_Subtraction(Vector3i a, Vector3i b) { }

	public override string ToString() { }

}

