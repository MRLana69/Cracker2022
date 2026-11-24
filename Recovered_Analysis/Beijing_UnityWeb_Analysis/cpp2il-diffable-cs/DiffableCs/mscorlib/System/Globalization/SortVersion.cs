namespace System.Globalization;

public sealed class SortVersion
{
	private int m_NlsVersion; //Field offset: 0x8
	private Guid m_SortId; //Field offset: 0xC

	public override bool Equals(object obj) { }

	public bool Equals(SortVersion other) { }

	public override int GetHashCode() { }

	public static bool op_Equality(SortVersion left, SortVersion right) { }

	public static bool op_Inequality(SortVersion left, SortVersion right) { }

}

