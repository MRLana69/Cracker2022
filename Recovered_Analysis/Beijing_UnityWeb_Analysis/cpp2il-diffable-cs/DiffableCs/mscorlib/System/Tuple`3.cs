namespace System;

public class Tuple`3 : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal
{
	private readonly T1 m_Item1; //Field offset: 0x0
	private readonly T2 m_Item2; //Field offset: 0x0
	private readonly T3 m_Item3; //Field offset: 0x0

	public T1 Item1
	{
		 get { } //Length: 90
	}

	public T2 Item2
	{
		 get { } //Length: 6
	}

	public T3 Item3
	{
		 get { } //Length: 6
	}

	public Tuple`3(T1 item1, T2 item2, T3 item3) { }

	public override bool Equals(object obj) { }

	public T1 get_Item1() { }

	public T2 get_Item2() { }

	public T3 get_Item3() { }

	public override int GetHashCode() { }

	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	private int System.IComparable.CompareTo(object obj) { }

	private string System.ITupleInternal.ToString(StringBuilder sb) { }

	public override string ToString() { }

}

