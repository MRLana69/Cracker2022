namespace System;

public struct ValueTuple`2 : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>
{
	public T1 Item1; //Field offset: 0x0
	public T2 Item2; //Field offset: 0x0

	public ValueTuple`2(T1 item1, T2 item2) { }

	public int CompareTo(ValueTuple<T1, T2> other) { }

	public override bool Equals(object obj) { }

	public bool Equals(ValueTuple<T1, T2> other) { }

	public override int GetHashCode() { }

	private int GetHashCodeCore(IEqualityComparer comparer) { }

	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private int System.IComparable.CompareTo(object other) { }

	public override string ToString() { }

}

