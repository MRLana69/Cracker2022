namespace System.Collections.Generic;

internal class NullableEqualityComparer`1
{

	public NullableEqualityComparer`1() { }

	public override bool Equals(Nullable<T> x, Nullable<T> y) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode(Nullable<T> obj) { }

	public override int GetHashCode() { }

	internal override int IndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

	internal override int LastIndexOf(Nullable<T>[] array, Nullable<T> value, int startIndex, int count) { }

}

