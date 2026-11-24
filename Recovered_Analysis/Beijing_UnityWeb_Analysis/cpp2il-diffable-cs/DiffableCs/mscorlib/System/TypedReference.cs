namespace System;

public struct TypedReference
{
	private RuntimeTypeHandle type; //Field offset: 0x0
	private nint Value; //Field offset: 0x4
	private nint Type; //Field offset: 0x8

	internal bool IsNull
	{
		 get { } //Length: 12
	}

	public override bool Equals(object o) { }

	internal bool get_IsNull() { }

	public override int GetHashCode() { }

	public static TypedReference MakeTypedReference(object target, FieldInfo[] flds) { }

	private static TypedReference MakeTypedReferenceInternal(object target, FieldInfo[] fields) { }

	public static void SetTypedReference(TypedReference target, object value) { }

}

