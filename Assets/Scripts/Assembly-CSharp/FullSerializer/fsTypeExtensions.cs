using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;

namespace FullSerializer;

public static class fsTypeExtensions
{
	public static string CSharpName(Type type)
	{
		return CSharpName(type, includeNamespace: false);
	}

	public static string CSharpName(Type type, bool includeNamespace, bool ensureSafeDeclarationName)
	{
		string text = CSharpName(type, includeNamespace);
		if (ensureSafeDeclarationName)
		{
			string text2 = text.Replace('>', '_');
			string text3 = text2.Replace('<', '_');
			string text4 = text3.Replace('.', '_');
			text = text4.Replace(',', '_');
		}
		return text;
	}

	public static string CSharpName(Type type, bool includeNamespace)
	{
		//IL_0495: Expected VT, but got Obj
		//IL_0041: Expected VT, but got Obj
		//IL_0086: Expected VT, but got Obj
		//IL_00cb: Expected VT, but got Obj
		//IL_0110: Expected VT, but got Obj
		//IL_0155: Expected VT, but got Obj
		//IL_0193: Expected I, but got Obj
		//IL_01d9: Expected I, but got Obj
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_01c2: Expected I, but got Obj
		//IL_0222: Expected I, but got Obj
		//IL_025d: Expected I, but got Obj
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_02b6: Expected I, but got Obj
		//IL_041d: Expected I, but got Obj
		//IL_0454: Expected I, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(void));
		if ((object)typeFromHandle == type)
		{
			return "void";
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
		if ((object)typeFromHandle2 == type)
		{
			return "int";
		}
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
		if ((object)typeFromHandle3 == type)
		{
			return "float";
		}
		Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(bool));
		if ((object)typeFromHandle4 == type)
		{
			return "bool";
		}
		Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(double));
		if ((object)typeFromHandle5 == type)
		{
			return "double";
		}
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
		if ((object)typeFromHandle6 == type)
		{
			return "string";
		}
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ S1_v16 (Il2CppClass<System.Type>)+1EC] (should have been resolved before IL gen)");
		object obj = default;
		if (obj != null)
		{
			nint num2 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ S1_v67 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
			string result = default;
			return result;
		}
		nint num3 = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ S1_v19 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
		bool isNested = type.IsNested;
		bool flag = !isNested;
		IEnumerable<Type> enumerable = default;
		IEnumerable<Type> source = enumerable;
		string text = "";
		if (!flag)
		{
			nint num4 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v181 @ S2_v32 (Il2CppClass<System.Type>)+104] (should have been resolved before IL gen)");
			Type type2 = default;
			string text2 = CSharpName(type2);
			string text3 = "" + text2 + ".";
			nint num5 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ S1_v57 (Il2CppClass<System.Type>)+104] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v240 @ S1_v60+24C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ S0_v101+C]");
			bool flag2 = (nint)0 == 0;
			source = enumerable;
			text = text3;
			if (!flag2)
			{
				nint num6 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v255 @ S2_v42 (Il2CppClass<System.Type>)+104] (should have been resolved before IL gen)");
				object obj5 = default;
				object obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v263 @ S2_v45+24C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v64+C]");
				IEnumerable<Type> enumerable2 = Enumerable.Skip(enumerable, 0);
				source = enumerable2;
				text = text3;
			}
		}
		bool flag3 = Enumerable.Any(source);
		object obj6 = type - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ S1_v27+BC] (should have been resolved before IL gen)");
		string text5 = default;
		if (!flag3)
		{
			string text4 = text + text5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			bool flag4 = (nint)0 == 0;
			string result2 = text4;
			if (!flag4)
			{
				nint num7 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ S1_v32 (Il2CppClass<System.Type>)+17C] (should have been resolved before IL gen)");
				object obj7 = default;
				bool flag5 = obj7 == null;
				result2 = text4;
				if (!flag5)
				{
					nint num8 = (nint)type;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v339 @ S1_v35 (Il2CppClass<System.Type>)+17C] (should have been resolved before IL gen)");
					string text7 = default;
					string text6 = text7 + "." + text4;
					result2 = text6;
				}
			}
			return result2;
		}
		int num9 = text5.IndexOf('`');
		if (num9 >= 1)
		{
			object obj8 = type - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v296 @ S2_v26+BC] (should have been resolved before IL gen)");
			string text9 = default;
			string text8 = text9.Substring(0, num9);
			string text10 = text + text8;
			text = text10;
		}
		throw new ArgumentException();
	}

	public static bool IsInterface(Type type)
	{
		return type.IsInterface;
	}

	public static bool IsAbstract(Type type)
	{
		//IL_0008: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002e: Expected I4, but got Obj
		nint num = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v3 @ S1_v2 (Il2CppClass<System.Type>)+274] (should have been resolved before IL gen)");
		object obj2 = default;
		object obj = obj2 & 0x80;
		return (byte)(obj >> 7) != 0;
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
}
