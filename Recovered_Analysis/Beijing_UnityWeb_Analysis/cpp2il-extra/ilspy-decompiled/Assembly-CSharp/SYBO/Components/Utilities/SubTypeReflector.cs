using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class SubTypeReflector
{
	public unsafe static List<Type> GetSubTypes<T>() where T : class
	{
		//IL_007b: Expected Obj, but got I
		//IL_0089: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected I, but got Unknown
		//IL_00f5: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10+60]");
		object obj = 0;
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v14 (Il2CppClass<System.Type>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v26 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+3C]");
		obj3 = 0;
		nint num3 = (nint)(obj4 + 8);
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Type type = Type.internal_from_handle((IntPtr)num3);
		obj4 = typeof(PrefabPathAttribute);
		((IntPtr*)num3)->m_value = (void*)(nint)obj4;
		Type type2 = Type.internal_from_handle((IntPtr)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8582");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
		List<Type> result = default;
		return result;
	}

	public static List<Type> GetSubTypes(Type typeT)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private static bool IsUnwantedAssembly(Assembly assembly)
	{
		//IL_0022: Expected VT, but got Obj
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_0080: Expected Obj, but got I4
		//IL_018e: Expected I4, but got Obj
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected Obj, but got Unknown
		if (!((Type)(object)assembly).IsInterface)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentException ex = default;
			ex._002Ector((SerializationInfo)(object)"Given type must be a class.", (StreamingContext)"typeT");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Type> list = default;
		list._002Ector();
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object obj = currentDomain.InitializeLifetimeService();
		object obj2 = obj + 12;
		object obj3 = 0;
		object obj8 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = obj + 16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			string text = ((ToStringObject)obj6).ToString();
			if (text == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj7 = obj8 + 12;
				object obj9 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
				{
					object obj10 = obj8 + 16;
					object obj11 = obj9 << 2;
					object obj12 = obj10 + obj11;
					if (IsSubclassOfGenericType((Type)obj12, (Type)(object)assembly))
					{
						list.Add((Type)obj12);
					}
					object obj13 = obj9 + 1;
					obj9 = obj13;
				}
			}
			object obj14 = obj3 + 1;
			obj3 = obj14;
		}
		return (byte)(int)list != 0;
	}

	private static bool IsCorrectType(Type type, Type typeT)
	{
		//IL_0184: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_00e1: Expected I, but got Obj
		//IL_00f7: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L0 (System.Type)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+C]");
		int num = (int)(-1);
		int num2 = num;
		object obj4 = default;
		object obj5 = default;
		while (true)
		{
			if (num2 < 0)
			{
				return true;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [type @ L0 (System.Type)+C]");
			SingletonMonoBehaviour singletonMonoBehaviour = ((List<SingletonMonoBehaviour>)0).get_Item(num2);
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v20 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)singletonMonoBehaviour).FindKernel((string)(object)typeT) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v8 (Il2CppClass<System.Type>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S2_v12 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (obj4 == obj5)
				{
					break;
				}
			}
			int num7 = num2 - 1;
			num2 = num7;
		}
		return false;
	}

	private static bool IsSubclassOfGenericType(Type type, Type genericType)
	{
		bool result;
		if (type.IsInterface)
		{
			if (type.IsSealed)
			{
				result = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj = default;
				if (obj != null)
				{
					string valueAsString = ((ToStringObject)(object)type).GetValueAsString((object)genericType);
					bool flag = valueAsString == null;
					result = false;
					if (!flag)
					{
						goto IL_00ed;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					object obj2 = default;
					bool flag2 = obj2 == null;
					result = false;
					if (!flag2)
					{
						goto IL_00ed;
					}
				}
			}
		}
		else
		{
			result = false;
		}
		goto IL_010e;
		IL_010e:
		return result;
		IL_00ed:
		result = true;
		goto IL_010e;
	}
}
