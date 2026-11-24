namespace UnityEngine;

internal sealed class _AndroidJNIHelper
{

	public static AndroidJavaObject Box(object obj) { }

	public static ArrayType ConvertFromJNIArray(nint array) { }

	public static nint ConvertToJNIArray(Array array) { }

	public static nint CreateJavaProxy(nint delegateHandle, AndroidJavaProxy proxy) { }

	public static nint CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	public static jvalue[] CreateJNIArgArray(object[] args) { }

	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	public static nint GetConstructorID(nint jclass, object[] args) { }

	public static nint GetConstructorID(nint jclass, string signature) { }

	public static nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic) { }

	public static nint GetMethodID(nint jclass, string methodName, string signature, bool isStatic) { }

	private static nint GetMethodIDFallback(nint jclass, string methodName, string signature, bool isStatic) { }

	public static string GetSignature(object[] args) { }

	public static string GetSignature(object obj) { }

	public static string GetSignature(object[] args) { }

	public static nint InvokeJavaProxyMethod(AndroidJavaProxy proxy, nint jmethodName, nint jargs) { }

	public static object Unbox(AndroidJavaObject obj) { }

	public static object UnboxArray(AndroidJavaObject obj) { }

}

