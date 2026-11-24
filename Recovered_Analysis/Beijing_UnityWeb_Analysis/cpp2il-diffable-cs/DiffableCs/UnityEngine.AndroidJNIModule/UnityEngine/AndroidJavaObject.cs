namespace UnityEngine;

public class AndroidJavaObject : IDisposable
{
	private static bool enableDebugPrints; //Field offset: 0x0
	internal GlobalJavaObjectRef m_jobject; //Field offset: 0x8
	internal GlobalJavaObjectRef m_jclass; //Field offset: 0xC

	private void _AndroidJavaObject(string className, object[] args) { }

	protected ReturnType _Call(string methodName, object[] args) { }

	protected ReturnType _CallStatic(string methodName, object[] args) { }

	protected nint _GetRawClass() { }

	protected nint _GetRawObject() { }

	private static AndroidJavaObject() { }

	internal AndroidJavaObject() { }

	internal AndroidJavaObject(nint jobject) { }

	public AndroidJavaObject(string className, object[] args) { }

	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(nint jclass) { }

	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(nint jobject) { }

	public ReturnType Call(string methodName, object[] args) { }

	public ReturnType CallStatic(string methodName, object[] args) { }

	protected void DebugPrint(string msg) { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	protected override void Finalize() { }

	public nint GetRawClass() { }

	public nint GetRawObject() { }

}

