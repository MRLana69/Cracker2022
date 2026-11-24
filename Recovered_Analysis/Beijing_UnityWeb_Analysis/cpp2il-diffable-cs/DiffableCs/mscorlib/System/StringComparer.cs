namespace System;

public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
{
	private static readonly StringComparer _invariantCulture; //Field offset: 0x0
	private static readonly StringComparer _invariantCultureIgnoreCase; //Field offset: 0x4
	private static readonly StringComparer _ordinal; //Field offset: 0x8
	private static readonly StringComparer _ordinalIgnoreCase; //Field offset: 0xC

	public static StringComparer CurrentCultureIgnoreCase
	{
		 get { } //Length: 89
	}

	public static StringComparer InvariantCulture
	{
		 get { } //Length: 644
	}

	public static StringComparer InvariantCultureIgnoreCase
	{
		 get { } //Length: 89
	}

	public static StringComparer Ordinal
	{
		 get { } //Length: 105
	}

	public static StringComparer OrdinalIgnoreCase
	{
		 get { } //Length: 89
	}

	private static StringComparer() { }

	protected StringComparer() { }

	public int Compare(object x, object y) { }

	public abstract int Compare(string x, string y) { }

	public bool Equals(object x, object y) { }

	public abstract bool Equals(string x, string y) { }

	public static StringComparer get_CurrentCultureIgnoreCase() { }

	public static StringComparer get_InvariantCulture() { }

	public static StringComparer get_InvariantCultureIgnoreCase() { }

	public static StringComparer get_Ordinal() { }

	public static StringComparer get_OrdinalIgnoreCase() { }

	public int GetHashCode(object obj) { }

	public abstract int GetHashCode(string obj) { }

}

