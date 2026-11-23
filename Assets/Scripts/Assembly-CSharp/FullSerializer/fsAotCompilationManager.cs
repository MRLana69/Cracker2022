using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using FullSerializer.Internal;

namespace FullSerializer;

public class fsAotCompilationManager
{
	public static HashSet<Type> AotCandidateTypes;

	private unsafe static bool HasMember(fsAotVersionInfo versionInfo, fsAotVersionInfo.Member member)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0024: Expected Obj, but got I4
		//IL_0085: Expected native int or pointer, but got VT
		//IL_0097: Expected native int or pointer, but got VT
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected VT, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected Obj, but got Unknown
		object obj = default;
		fsAotVersionInfo.Member member2 = (fsAotVersionInfo.Member)(obj - 48);
		fsAotVersionInfo.Member[] members = versionInfo.Members;
		object obj2 = 0;
		bool flag;
		while (true)
		{
			flag = (nint)obj2 < members.Length;
			if (!flag)
			{
				break;
			}
			object obj3 = obj2 << 4;
			object obj4 = (object)members + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8+18]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v8+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+20]");
			_ = 0;
			System.Runtime.CompilerServices.Unsafe.Write(&((fsAotVersionInfo.Member*)(nint)member2)->StorageType, member.StorageType);
			System.Runtime.CompilerServices.Unsafe.Write(&((fsAotVersionInfo.Member*)(nint)member2)->MemberName, member.MemberName);
			fsAotVersionInfo.Member member3 = (fsAotVersionInfo.Member)(member2 + 16);
			if (!(member3 != member2))
			{
				break;
			}
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
		return flag;
	}

	public unsafe static bool IsAotModelUpToDate(fsMetaType currentModel, fsIAotConverter aotModel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected Obj, but got Unknown
		//IL_01d5: Expected Obj, but got I
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected VT, but got Unknown
		//IL_00ee: Expected Obj, but got I
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_0108: Expected Obj, but got I
		//IL_0103: Expected native int or pointer, but got VT
		//IL_012a: Expected Obj, but got I
		//IL_0125: Expected native int or pointer, but got VT
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected VT, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		object obj = default;
		fsAotVersionInfo.Member member = (fsAotVersionInfo.Member)(obj - 48);
		bool isDefaultConstructorPublic = currentModel.IsDefaultConstructorPublic;
		object obj2 = member + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C2");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+20]");
		object obj3 = (nint)0 & (nint)1;
		bool flag = obj3 == null;
		if (isDefaultConstructorPublic != flag)
		{
			fsMetaProperty[] array = currentModel.Properties__BackingField;
			object obj4 = member + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C2");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+24]");
			object obj5 = 0;
			int num = array.Length;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v15+C]");
			if ((nint)num == 0)
			{
				fsMetaProperty[] array2 = currentModel.Properties__BackingField;
				object obj6 = 0;
				while ((nint)obj6 < array2.Length)
				{
					object obj7 = obj6 << 2;
					object obj8 = (object)array2 + obj7;
					object obj9 = member + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C2");
					_ = 0;
					_ = 0;
					fsAotVersionInfo.Member member2 = (fsAotVersionInfo.Member)(member + 32);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v34+10]");
					System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)member2, new fsAotVersionInfo.Member((fsMetaProperty)0));
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+28]");
					System.Runtime.CompilerServices.Unsafe.Write(&((fsAotVersionInfo.Member*)(nint)member)->StorageType, (string)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (FullSerializer.fsAotVersionInfo+Member)+20]");
					System.Runtime.CompilerServices.Unsafe.Write(&((fsAotVersionInfo.Member*)(nint)member)->MemberName, (string)0);
					fsAotVersionInfo versionInfo = (fsAotVersionInfo)(member + 16);
					if (!HasMember(versionInfo, member))
					{
						break;
					}
					object obj10 = obj6 + 1;
					obj6 = obj10;
				}
				return (nint)obj6 >= array2.Length;
			}
		}
		bool result = default;
		return result;
	}

	public static string RunAotCompilationForType(fsConfig config, Type type)
	{
		fsMetaType fsMetaType2 = fsMetaType.Get(config, type);
		fsMetaType2.EmitAotData(throwException: true);
		bool isDefaultConstructorPublic = fsMetaType2.IsDefaultConstructorPublic;
		return GenerateDirectConverterForTypeInCSharp(type, fsMetaType2.Properties__BackingField, isDefaultConstructorPublic);
	}

	private static string EmitVersionInfo(string prefix, Type type, fsMetaProperty[] members, bool isConstructorPublic)
	{
		//IL_0044: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I
		//IL_026e: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00f4: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		StringBuilder stringBuilder2 = stringBuilder.AppendLine("new fsAotVersionInfo {");
		object obj = "true";
		if (!isConstructorPublic)
		{
			obj = "false";
		}
		string value = prefix + "    IsConstructorPublic = " + (string)obj + ",";
		StringBuilder stringBuilder3 = stringBuilder.AppendLine(value);
		string value2 = prefix + "    Members = new fsAotVersionInfo.Member[] {";
		StringBuilder stringBuilder4 = stringBuilder.AppendLine(value2);
		object obj2 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [members @ L2 (System.Type)+C]");
			if (0 <= (nint)obj2)
			{
				break;
			}
			object obj3 = obj2 << 2;
			object obj4 = (object)members + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v26+10]");
			object obj5 = 0;
			string value3 = prefix + "        new fsAotVersionInfo.Member {";
			StringBuilder stringBuilder5 = stringBuilder.AppendLine(value3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27+1C]");
			string value4 = prefix + "            MemberName = \"" + (string)0 + "\",";
			StringBuilder stringBuilder6 = stringBuilder.AppendLine(value4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27+18]");
			string value5 = prefix + "            JsonName = \"" + (string)0 + "\",";
			StringBuilder stringBuilder7 = stringBuilder.AppendLine(value5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27+C]");
			string text = fsTypeExtensions.CSharpName((Type)0, includeNamespace: true);
			string value6 = prefix + "            StorageType = \"" + text + "\",";
			StringBuilder stringBuilder8 = stringBuilder.AppendLine(value6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v27+10]");
				string text2 = fsTypeExtensions.CSharpName((Type)0, includeNamespace: true);
				string value7 = prefix + "            OverrideConverterType = \"" + text2 + "\",";
				StringBuilder stringBuilder9 = stringBuilder.AppendLine(value7);
			}
			string value8 = prefix + "        },";
			StringBuilder stringBuilder10 = stringBuilder.AppendLine(value8);
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		string value9 = prefix + "    }";
		StringBuilder stringBuilder11 = stringBuilder.AppendLine(value9);
		string value10 = prefix + "}";
		StringBuilder stringBuilder12 = stringBuilder.Append(value10);
		nint num = (nint)stringBuilder;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v144 @ S1_v16 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private static string GetConverterString(fsMetaProperty member)
	{
		if ((object)member.OverrideConverterType__BackingField == null)
		{
			return "null";
		}
		string arg = fsTypeExtensions.CSharpName(member.OverrideConverterType__BackingField, includeNamespace: true);
		return $"typeof({arg})";
	}

	public static string GetQualifiedConverterNameForType(Type type)
	{
		string text = fsTypeExtensions.CSharpName(type, includeNamespace: true, ensureSafeDeclarationName: true);
		return "FullSerializer.Speedup." + text + "_DirectConverter";
	}

	private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		string text = fsTypeExtensions.CSharpName(type, includeNamespace: true);
		string text2 = fsTypeExtensions.CSharpName(type, includeNamespace: true, ensureSafeDeclarationName: true);
		StringBuilder stringBuilder2 = stringBuilder.AppendLine("using System;");
		StringBuilder stringBuilder3 = stringBuilder.AppendLine("using System.Collections.Generic;");
		StringBuilder stringBuilder4 = stringBuilder.AppendLine();
		StringBuilder stringBuilder5 = stringBuilder.AppendLine("namespace FullSerializer {");
		StringBuilder stringBuilder6 = stringBuilder.AppendLine("    partial class fsConverterRegistrar {");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	static fsAotCompilationManager()
	{
		HashSet<Type> hashSet = default;
		hashSet._002Ector();
		AotCandidateTypes = hashSet;
	}
}
