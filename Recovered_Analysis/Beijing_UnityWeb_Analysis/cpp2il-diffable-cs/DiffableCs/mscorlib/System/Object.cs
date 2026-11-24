namespace System;

public class object
{

	public object() { }

	public virtual bool Equals(object obj) { }

	public static bool Equals(object objA, object objB) { }

	private void FieldGetter(string typeName, string fieldName, ref object val) { }

	private void FieldSetter(string typeName, string fieldName, object val) { }

	protected virtual void Finalize() { }

	public virtual int GetHashCode() { }

	public Type GetType() { }

	internal static int InternalGetHashCode(object o) { }

	protected object MemberwiseClone() { }

	public static bool ReferenceEquals(object objA, object objB) { }

	public virtual string ToString() { }

}

