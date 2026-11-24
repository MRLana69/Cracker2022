namespace System.Collections.Generic;

public abstract class Comparer`1 : IComparer, IComparer<T>
{
	private static Comparer<T> defaultComparer; //Field offset: 0x0

	public static Comparer<T> Default
	{
		 get { } //Length: 82
	}

	protected Comparer`1() { }

	public abstract int Compare(T x, T y) { }

	private static Comparer<T> CreateComparer() { }

	public static Comparer<T> get_Default() { }

	private int System.Collections.IComparer.Compare(object x, object y) { }

}

