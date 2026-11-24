namespace UnityEngine;

public static class AndroidJNIHelper
{

	public static ArrayType ConvertFromJNIArray(nint array) { }

	public static nint CreateJavaProxy(AndroidJavaProxy proxy) { }

	public static nint CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	public static jvalue[] CreateJNIArgArray(object[] args) { }

	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	public static nint GetConstructorID(nint javaClass, string signature) { }

	public static nint GetConstructorID(nint jclass, object[] args) { }

	public static nint GetMethodID(nint javaClass, string methodName, string signature, bool isStatic) { }

	public static nint GetMethodID(nint jclass, string methodName, object[] args, bool isStatic) { }

}

