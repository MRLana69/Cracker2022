using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;

namespace SYBO.Components.Utilities;

public static class ReflectionWrapper
{
	public static IEnumerable<object> GetCustomAttributes(MemberInfo type, bool inherit)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<System.Reflection.MemberInfo>)+124] (should have been resolved before IL gen)");
		IEnumerable<object> result = default;
		return result;
	}

	public static bool HasCustomAttributes(MemberInfo type, bool inherit)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<System.Reflection.MemberInfo>)+124] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+C]");
		return (nint)0 != 0;
	}

	public static bool HasCustomAttributes(Type type, bool inherit)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 104;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<System.Type>)+124] (should have been resolved before IL gen)");
		object obj2 = default;
		if (obj2 == null)
		{
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v2+C]");
		return (nint)0 != 0;
	}

	public static Attribute GetCustomAttribute(MemberInfo type, Type attributeType)
	{
		return Attribute.GetCustomAttribute(type, attributeType);
	}

	public static Attribute GetCustomAttribute(Type type, Type attributeType)
	{
		return Attribute.GetCustomAttribute(type, attributeType);
	}

	public static MethodInfo GetMethod(Type type, string methodName, BindingFlags bindingFlags)
	{
		return type.GetMethod(methodName, bindingFlags);
	}

	public static ConstructorInfo GetConstructor(Type type)
	{
		return type.GetConstructor(Type.EmptyTypes);
	}

	public static ConstructorInfo GetConstructor(Type type, Type[] types)
	{
		return type.GetConstructor(types);
	}

	public static object GetUninitializedObject(Type type)
	{
		return FormatterServices.GetUninitializedObject(type);
	}

	public static FieldInfo[] GetFields(Type type, BindingFlags bindingFlags)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<System.Type>)+374] (should have been resolved before IL gen)");
		FieldInfo[] result = default;
		return result;
	}

	public static FieldInfo[] GetFieldsForTree(Type type, BindingFlags bindingFlags)
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_0058: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		object obj = type + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v4+BC] (should have been resolved before IL gen)");
		Type type2 = default;
		List<FieldInfo> list2;
		if ((object)type2 == null)
		{
			List<FieldInfo> list = default;
			list._002Ector();
			list2 = list;
		}
		else
		{
			FieldInfo[] fieldsForTree = GetFieldsForTree(type2, bindingFlags);
			List<FieldInfo> list3 = default;
			list3._002Ector((IEnumerable<FieldInfo>)fieldsForTree);
			list2 = list3;
		}
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v60 @ S2_v6 (Il2CppClass<System.Type>)+374] (should have been resolved before IL gen)");
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<System.Reflection.FieldInfo>>)+3C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v80 @ S4_v4+4] (should have been resolved before IL gen)");
		return list2.ToArray();
	}

	public static Type GetInterface(Type type, Type interfaceType)
	{
		//IL_0008: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		nint num = (nint)interfaceType;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S2_v2 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
		object obj = type + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S3_v5+BC] (should have been resolved before IL gen)");
		Type result = default;
		return result;
	}

	public static Type[] GetGenericArguments(Type type)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 400;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
		Type[] result = default;
		return result;
	}

	public static bool IsPrimitive(Type type)
	{
		//IL_0008: Expected I, but got Obj
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+30C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool IsGenericType(Type type)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool IsValueType(Type type)
	{
		//IL_0008: Expected I, but got Obj
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+31C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool IsEnum(Type type)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 560;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+2EC] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static Assembly GetAssembly(Type type)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+194] (should have been resolved before IL gen)");
		Assembly result = default;
		return result;
	}

	public static Type[] GetTypes(Assembly assembly)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)assembly;
		object obj = assembly + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Reflection.Assembly>)+13C] (should have been resolved before IL gen)");
		Type[] result = default;
		return result;
	}

	internal static Type GetBaseType(Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = type + 896;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3+BC] (should have been resolved before IL gen)");
		Type result = default;
		return result;
	}
}
