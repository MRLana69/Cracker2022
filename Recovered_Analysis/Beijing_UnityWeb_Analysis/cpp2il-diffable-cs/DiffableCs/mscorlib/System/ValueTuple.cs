namespace System;

public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>
{

	internal static int CombineHashCodes(int h1, int h2) { }

	public int CompareTo(ValueTuple other) { }

	public override bool Equals(object obj) { }

	public bool Equals(ValueTuple other) { }

	public override int GetHashCode() { }

	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private int System.IComparable.CompareTo(object other) { }

	public override string ToString() { }

}

