namespace System.Runtime.InteropServices;

public interface ICustomMarshaler
{

	public void CleanUpManagedData(object ManagedObj) { }

	public void CleanUpNativeData(nint pNativeData) { }

	public int GetNativeDataSize() { }

	public nint MarshalManagedToNative(object ManagedObj) { }

	public object MarshalNativeToManaged(nint pNativeData) { }

}

