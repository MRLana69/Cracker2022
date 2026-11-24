namespace System.Reflection;

internal struct MonoMethodInfo
{
	private Type parent; //Field offset: 0x0
	private Type ret; //Field offset: 0x4
	internal MethodAttributes attrs; //Field offset: 0x8
	internal MethodImplAttributes iattrs; //Field offset: 0xC
	private CallingConventions callconv; //Field offset: 0x10

	private static int get_method_attributes(nint handle) { }

	private static void get_method_info(nint handle, out MonoMethodInfo info) { }

	private static ParameterInfo[] get_parameter_info(nint handle, MemberInfo member) { }

	internal static MethodAttributes GetAttributes(nint handle) { }

	internal static CallingConventions GetCallingConvention(nint handle) { }

	internal static Type GetDeclaringType(nint handle) { }

	internal static MethodImplAttributes GetMethodImplementationFlags(nint handle) { }

	internal static MonoMethodInfo GetMethodInfo(nint handle) { }

	internal static ParameterInfo[] GetParametersInfo(nint handle, MemberInfo member) { }

	internal static Type GetReturnType(nint handle) { }

}

