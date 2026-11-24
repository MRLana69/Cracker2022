namespace System.Collections.Generic;

internal class GenericEqualityComparer`1
{

	public GenericEqualityComparer`1() { }

	public override bool Equals(T x, T y) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode(T obj) { }

	public override int GetHashCode() { }

	internal override int IndexOf(T[] array, T value, int startIndex, int count) { }

	internal override int LastIndexOf(T[] array, T value, int startIndex, int count) { }

}

