namespace UnityEngine;

public class AndroidJavaProxy
{
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; //Field offset: 0x0
	private static readonly nint s_HashCodeMethodID; //Field offset: 0x4
	public readonly AndroidJavaClass javaInterface; //Field offset: 0x8
	internal nint proxyObject; //Field offset: 0xC

	private static AndroidJavaProxy() { }

	public AndroidJavaProxy(string javaInterface) { }

	public AndroidJavaProxy(AndroidJavaClass javaInterface) { }

	protected override void Finalize() { }

	internal AndroidJavaObject GetProxyObject() { }

	internal nint GetRawProxy() { }

	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

}

