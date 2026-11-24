using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

namespace SYBO.Common.Utilities;

public class EnumUtility
{
	public static int[] ConvertEnumToIntArray<T>()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_004d: Expected Obj, but got I
		//IL_017a: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I
		//IL_010b: Expected Obj, but got I
		//IL_011b: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0084: Expected Obj, but got I
		//IL_00dd: Expected Obj, but got I
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v7+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v22+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v25+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v30+60]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v16+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v5+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v6+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11+60]");
		object obj10 = 0;
		object obj11 = obj9 & 0x3FFF;
		object obj12 = obj11 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S2_v3 (should have been resolved before IL gen)");
		int[] result = default;
		return result;
	}

	public static T ConvertIntToEnumValue<T>(int i)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected Obj, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected Obj, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v45 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 48;
		Vector3 one = Vector3.one;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v41 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3 + 32;
		Vector2 zero = Vector2.zero;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L1 (Il2CppMethodInfo)+18]");
		object obj6 = 0;
		object obj7 = obj6;
		object obj8 = obj3 + 16;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		_ = 0;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v21+8]");
		_ = 0;
		object obj9 = obj3 + 60;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v27+8]");
		_ = 0;
		object obj10 = obj3 + 72;
		obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj11 = obj7 & 0x1FFF;
		object obj12 = obj11 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S4_v3 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public unsafe static T ConvertIntToFlagEnumValue<T>(int i)
	{
		//IL_00b2: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected I, but got Unknown
		//IL_0150: Expected I, but got Obj
		//IL_016b: Expected I, but got Obj
		//IL_0181: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v24 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type enumType = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<System.Enum>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v21 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = Enum.ToObject(enumType, (byte)i);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		T result = default;
		return result;
	}

	public static T ConvertIndexToEnumValue<T>(int index)
	{
		//IL_012c: Expected Obj, but got I4
		//IL_014d: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_0175: Expected Obj, but got I
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01a4: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I
		//IL_002d: Expected Obj, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0123: Expected VT, but got Obj
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected Obj, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected Obj, but got Unknown
		//IL_00c6: Expected I4, but got Obj
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		nint num = default;
		object obj2 = num + 12;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v7+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v8+C]");
		object obj5 = 0;
		object obj6 = obj5 & 0x3FFF;
		object obj7 = obj6 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S2_v5 (should have been resolved before IL gen)");
		object obj8 = 0;
		object obj9 = default;
		object obj15 = default;
		string value = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
		{
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S3_v5+60]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v6+10]");
			object obj12 = 0;
			object obj13 = obj12 & 0x1FFF;
			object obj14 = obj13 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S4_v5 (should have been resolved before IL gen)");
			obj = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			StringBuilder stringBuilder2 = stringBuilder.AppendLine(value);
			object obj16 = obj9 - 1;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
			{
				CharacterController charactercontroller = Game.Charactercontroller;
				StringBuilder stringBuilder3 = stringBuilder.Append((int)charactercontroller);
			}
			object obj17 = obj8 + 1;
			obj8 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string item = default;
		list.Add(item);
		return (T)list;
	}

	public unsafe static int ConvertEnumValueToIndex<T>(T enumValue)
	{
		//IL_00db: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected I, but got Unknown
		//IL_0175: Expected I, but got Obj
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got VT
		//IL_00cd: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v27 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2;
		nint num4 = (nint)(obj4 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj4;
		Type enumType = Type.internal_from_handle((IntPtr)num4);
		nint num5 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v11 (Il2CppClass<System.Enum>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v24 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ulong[] array = Enum.InternalGetValues((System.RuntimeType)enumType);
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		object obj8 = default;
		object obj7 = obj8 + 16;
		object obj9 = enumValue << 2;
		object obj10 = obj7 + obj9;
		return (int)obj10;
	}

	public EnumUtility()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
