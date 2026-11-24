namespace System.Collections.Generic;

public abstract class EqualityComparer`1 : IEqualityComparer, IEqualityComparer<T>
{
	private static EqualityComparer<T> defaultComparer; //Field offset: 0x0

	public static EqualityComparer<T> Default
	{
		 get { } //Length: 851
	}

	protected EqualityComparer`1() { }

	private static EqualityComparer<T> CreateComparer() { }

	public abstract bool Equals(T x, T y) { }

	public static EqualityComparer<T> get_Default() { }

	public abstract int GetHashCode(T obj) { }

	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }

	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

}

