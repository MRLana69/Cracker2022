namespace UnityEngine;

internal class AndroidReflection
{
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; //Field offset: 0x0
	private static readonly nint s_ReflectionHelperGetConstructorID; //Field offset: 0x4
	private static readonly nint s_ReflectionHelperGetMethodID; //Field offset: 0x8
	private static readonly nint s_ReflectionHelperGetFieldID; //Field offset: 0xC
	private static readonly nint s_ReflectionHelperNewProxyInstance; //Field offset: 0x10
	private static readonly nint s_ReflectionHelperSetNativeExceptionOnProxy; //Field offset: 0x14

	private static AndroidReflection() { }

	public static nint GetConstructorMember(nint jclass, string signature) { }

	public static nint GetMethodMember(nint jclass, string methodName, string signature, bool isStatic) { }

	private static nint GetStaticMethodID(string clazz, string methodName, string signature) { }

	public static bool IsAssignableFrom(Type t, Type from) { }

	public static bool IsPrimitive(Type t) { }

	public static nint NewProxyInstance(nint delegateHandle, nint interfaze) { }

	public static void SetNativeExceptionOnProxy(nint proxy, Exception e, bool methodNotFound) { }

}

