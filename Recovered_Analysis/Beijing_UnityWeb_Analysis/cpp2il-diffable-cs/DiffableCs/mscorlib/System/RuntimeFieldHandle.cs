namespace System;

public struct RuntimeFieldHandle : ISerializable
{
	private nint value; //Field offset: 0x0

	public nint Value
	{
		 get { } //Length: 368
	}

	internal RuntimeFieldHandle(nint v) { }

	private RuntimeFieldHandle(SerializationInfo info, StreamingContext context) { }

	public override bool Equals(object obj) { }

	public nint get_Value() { }

	public override int GetHashCode() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal static void SetValue(RtFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized) { }

	internal static void SetValueDirect(RtFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType) { }

	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

}

