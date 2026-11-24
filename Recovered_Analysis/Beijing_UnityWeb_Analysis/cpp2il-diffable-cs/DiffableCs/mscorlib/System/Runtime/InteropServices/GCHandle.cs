namespace System.Runtime.InteropServices;

public struct GCHandle
{
	private int handle; //Field offset: 0x0

	public bool IsAllocated
	{
		 get { } //Length: 12
	}

	public object Target
	{
		 get { } //Length: 12
		 set { } //Length: 14
	}

	private GCHandle(nint h) { }

	private GCHandle(object obj) { }

	internal GCHandle(object value, GCHandleType type) { }

	public nint AddrOfPinnedObject() { }

	public static GCHandle Alloc(object value) { }

	public static GCHandle Alloc(object value, GCHandleType type) { }

	private static bool CheckCurrentDomain(int handle) { }

	public override bool Equals(object o) { }

	public void Free() { }

	private static void FreeHandle(int handle) { }

	public static GCHandle FromIntPtr(nint value) { }

	public bool get_IsAllocated() { }

	public object get_Target() { }

	private static nint GetAddrOfPinnedObject(int handle) { }

	public override int GetHashCode() { }

	private static object GetTarget(int handle) { }

	private static int GetTargetHandle(object obj, int handle, GCHandleType type) { }

	public static bool op_Equality(GCHandle a, GCHandle b) { }

	public static nint op_Explicit(GCHandle value) { }

	public static GCHandle op_Explicit(nint value) { }

	public void set_Target(object value) { }

	public static nint ToIntPtr(GCHandle value) { }

}

