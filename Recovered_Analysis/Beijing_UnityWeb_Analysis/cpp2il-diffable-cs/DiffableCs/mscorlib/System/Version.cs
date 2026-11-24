namespace System;

public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>
{
	private static readonly char[] SeparatorsArray; //Field offset: 0x0
	private const int ZERO_CHAR_VALUE = 48; //Field offset: 0x0
	private int _Major; //Field offset: 0x8
	private int _Minor; //Field offset: 0xC
	private int _Build; //Field offset: 0x10
	private int _Revision; //Field offset: 0x14

	public int Build
	{
		 get { } //Length: 6
	}

	public int Major
	{
		 get { } //Length: 9
	}

	public int Minor
	{
		 get { } //Length: 6
	}

	public int Revision
	{
		 get { } //Length: 6
	}

	private static Version() { }

	public Version() { }

	public Version(int major, int minor, int build, int revision) { }

	public Version(int major, int minor) { }

	private static void AppendPositiveNumber(int num, StringBuilder sb) { }

	public object Clone() { }

	public int CompareTo(object version) { }

	public int CompareTo(Version value) { }

	public override bool Equals(object obj) { }

	public bool Equals(Version obj) { }

	public int get_Build() { }

	public int get_Major() { }

	public int get_Minor() { }

	public int get_Revision() { }

	public override int GetHashCode() { }

	public static bool op_Equality(Version v1, Version v2) { }

	public static bool op_Inequality(Version v1, Version v2) { }

	public override string ToString() { }

	public string ToString(int fieldCount) { }

}

