namespace System;

public abstract class ValueType
{

	protected ValueType() { }

	internal static bool DefaultEquals(object o1, object o2) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	internal static int InternalGetHashCode(object o, out object[] fields) { }

	public override string ToString() { }

}

