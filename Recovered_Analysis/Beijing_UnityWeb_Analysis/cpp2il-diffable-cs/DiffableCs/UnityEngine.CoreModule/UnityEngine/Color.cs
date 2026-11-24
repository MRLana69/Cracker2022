namespace UnityEngine;

public struct Color : IEquatable<Color>
{
	public float r; //Field offset: 0x0
	public float g; //Field offset: 0x4
	public float b; //Field offset: 0x8
	public float a; //Field offset: 0xC

	public static Color black
	{
		 get { } //Length: 129
	}

	public static Color blue
	{
		 get { } //Length: 129
	}

	public static Color clear
	{
		 get { } //Length: 129
	}

	public static Color green
	{
		 get { } //Length: 129
	}

	public static Color grey
	{
		 get { } //Length: 129
	}

	public Color linear
	{
		 get { } //Length: 8
	}

	public static Color magenta
	{
		 get { } //Length: 129
	}

	public float maxColorComponent
	{
		 get { } //Length: 49
	}

	public static Color red
	{
		 get { } //Length: 2
	}

	public static Color white
	{
		 get { } //Length: 129
	}

	public static Color yellow
	{
		 get { } //Length: 129
	}

	public Color(float r, float g, float b, float a) { }

	public Color(float r, float g, float b) { }

	public override bool Equals(object other) { }

	public bool Equals(Color other) { }

	public static Color get_black() { }

	public static Color get_blue() { }

	public static Color get_clear() { }

	public static Color get_green() { }

	public static Color get_grey() { }

	public Color get_linear() { }

	public static Color get_magenta() { }

	public float get_maxColorComponent() { }

	public static Color get_red() { }

	public static Color get_white() { }

	public static Color get_yellow() { }

	public override int GetHashCode() { }

	public static Color Lerp(Color a, Color b, float t) { }

	public static Color op_Division(Color a, float b) { }

	public static bool op_Equality(Color lhs, Color rhs) { }

	public static Color op_Implicit(Vector4 v) { }

	public static Vector4 op_Implicit(Color c) { }

	public static bool op_Inequality(Color lhs, Color rhs) { }

	public static Color op_Multiply(Color a, float b) { }

	public static Color op_Multiply(Color a, Color b) { }

	internal Color RGBMultiplied(float multiplier) { }

	public override string ToString() { }

}

