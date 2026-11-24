using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Components.Utilities;

public static class ReflectionWrapper
{
	private sealed class _003CGetDerivedTypes_003Ed__10(int _003C_003E1__state) : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private Type _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Type parentType;

		public Type _003C_003E3__parentType;

		private Assembly[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private Type[] _003C_003E7__wrap3;

		private int _003C_003E7__wrap4;

		Type IEnumerator<Type>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0090: Expected Obj, but got I4
				//IL_00a9: Expected Obj, but got I4
				//IL_00b7: Expected Obj, but got I4
				//IL_0233: Unknown result type (might be due to invalid IL or missing references)
				//IL_0238: Expected Obj, but got Unknown
				//IL_0250: Unknown result type (might be due to invalid IL or missing references)
				//IL_0255: Expected Obj, but got Unknown
				//IL_0264: Expected I4, but got Obj
				//IL_0198: Unknown result type (might be due to invalid IL or missing references)
				//IL_019d: Expected Obj, but got Unknown
				//IL_01a6: Expected Obj, but got I4
				//IL_01af: Expected Obj, but got I4
				//IL_02c3: Expected Obj, but got I4
				//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f7: Expected Obj, but got Unknown
				//IL_0200: Expected Obj, but got I4
				//IL_0223: Expected Obj, but got I4
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Expected Obj, but got Unknown
				//IL_014e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Expected Obj, but got Unknown
				//IL_016b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Expected Obj, but got Unknown
				//IL_028b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0290: Expected Obj, but got Unknown
				//IL_02ac: Expected Obj, but got I4
				//IL_02b5: Expected Obj, but got I4
				object obj;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						obj = 7;
					}
					else
					{
						obj = 12;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					object obj2 = this + 28;
					AppDomain currentDomain = AppDomain.CurrentDomain;
					object obj3 = currentDomain.InitializeLifetimeService();
					obj2 = obj3;
					_003C_003E7__wrap2 = 0;
					obj = 10;
				}
				object obj4 = obj;
				Type result = default;
				object obj9 = default;
				while (true)
				{
					if ((nint)obj4 == 7)
					{
						int num = _003C_003E7__wrap4 + 1;
						_003C_003E7__wrap4 = num;
					}
					else if ((nint)obj4 == 10)
					{
						Assembly[] array = _003C_003E7__wrap1;
						if (_003C_003E7__wrap2 >= array.Length)
						{
							object obj5 = this + 28;
							obj5 = 0;
							obj4 = 12;
							result = null;
							continue;
						}
						object obj6 = this + 36;
						object obj7 = _003C_003E7__wrap1 + 16;
						int num2 = _003C_003E7__wrap2 << 2;
						object obj8 = obj7 + num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						obj6 = obj9;
						_003C_003E7__wrap4 = 0;
					}
					else if ((nint)obj4 == 12)
					{
						break;
					}
					Type[] array2 = _003C_003E7__wrap3;
					if (_003C_003E7__wrap4 >= array2.Length)
					{
						object obj10 = this + 36;
						obj10 = 0;
						int num3 = _003C_003E7__wrap2 + 1;
						_003C_003E7__wrap2 = num3;
						obj4 = 10;
						continue;
					}
					object obj11 = _003C_003E7__wrap3 + 16;
					int num4 = _003C_003E7__wrap4 << 2;
					object obj12 = obj11 + num4;
					FieldInfo[] fields = GetFields((Type)obj12, (BindingFlags)parentType);
					object obj14;
					if (fields != null)
					{
						object obj13 = this + 12;
						obj13 = obj12;
						_003C_003E1__state = 1;
						result = (Type)1;
						obj14 = 12;
					}
					else
					{
						obj14 = 7;
					}
					obj4 = obj14;
				}
				return result;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}

		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return (IEnumerator<Type>)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected Obj, but got Unknown
			_003CGetDerivedTypes_003Ed__10 obj;
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_0065;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
			_003CGetDerivedTypes_003Ed__10 obj2 = default;
			obj = obj2;
			goto IL_0065;
			IL_0065:
			object obj3 = obj + 20;
			obj3 = _003C_003E3__parentType;
			return obj;
		}
	}

	public static IEnumerable<object> GetCustomAttributes(MemberInfo type, bool inherit)
	{
		//IL_002d: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Read-only");
		((PrefabsDict)(object)ex).Remove((KeyValuePair<string, Transform>)0);
		return null;
	}

	public static bool HasCustomAttributes(MemberInfo type, bool inherit)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		bool result = default;
		return result;
	}

	public static bool HasCustomAttributes(Type type, bool inherit)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+C]");
			return (nint)0 != 0;
		}
		return false;
	}

	public static Attribute GetCustomAttribute(MemberInfo type, Type attributeType)
	{
		//IL_0049: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v2+C]");
			bool flag = (nint)0 != 0;
			return (Attribute)flag;
		}
		return null;
	}

	public static Attribute GetCustomAttribute(Type type, Type attributeType)
	{
		return Attribute.GetCustomAttribute((Assembly)(object)type, attributeType);
	}

	public static MethodInfo GetMethod(Type type, string methodName, BindingFlags bindingFlags)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		MethodInfo result = default;
		return result;
	}

	public static ConstructorInfo GetConstructor(Type type)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		ConstructorInfo result = default;
		return result;
	}

	public static ConstructorInfo GetConstructor(Type type, Type[] types)
	{
		return (ConstructorInfo)(object)Attribute.GetCustomAttribute((Assembly)(object)type, (Type)(object)types);
	}

	public static ConstructorInfo[] GetConstructors(Type type, BindingFlags bindingFlags)
	{
		//IL_000d: Expected Obj, but got I4
		return (ConstructorInfo[])(object)type.GetMethod((string)bindingFlags);
	}

	public static object GetUninitializedObject(Type type)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return type.GetMethod((string)(object)Type.EmptyTypes);
	}

	public static IEnumerable<Type> GetDerivedTypes(Type parentType)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FormatterServices);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Runtime.Serialization.FormatterServices>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FormatterServices);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<System.Runtime.Serialization.FormatterServices>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IEnumerable<Type>)FormatterServices.nativeGetUninitializedObject((System.RuntimeType)parentType);
	}

	public static bool DerivesFrom(Type type, Type parentType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		bool result = default;
		return result;
	}

	public static FieldInfo[] GetFields(Type type, BindingFlags bindingFlags)
	{
		//IL_0137: Expected I, but got Obj
		//IL_014d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I4
		Type type2 = default;
		FieldInfo[] result;
		while (true)
		{
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v6 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v26 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (object)type2 == null;
			result = null;
			if (flag)
			{
				break;
			}
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)type2 == (nint)bindingFlags)
			{
				result = (FieldInfo[])1;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		}
		return result;
	}

	public static FieldInfo[] GetFieldsForTree(Type type, BindingFlags bindingFlags)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		FieldInfo[] result = default;
		return result;
	}

	public static Type GetInterface(Type type, Type interfaceType)
	{
		//IL_004b: Expected Obj, but got I
		//IL_005b: Expected Obj, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		string assetName = default;
		((AssetLoaderPathAttribute)(object)type)._002Ector((string)(object)interfaceType, assetName);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.String)+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (System.String)+1C]");
		object obj6 = num2 - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @CE18");
		Dictionary<IntPtr, FieldInfo>.ValueCollection valueCollection = default;
		FieldInfo[] array = default;
		valueCollection.CopyTo(array, 0);
		return (Type)(object)array;
	}

	public static Type[] GetGenericArguments(Type type)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
		Type[] array = default;
		object obj = array + 24;
		obj = type;
		return array;
	}

	public static bool IsPrimitive(Type type)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	public static bool IsGenericType(Type type)
	{
		return type.IsCOMObject;
	}

	public static bool IsAbstract(Type type)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		bool result = default;
		return result;
	}

	public static bool IsValueType(Type type)
	{
		return type.IsSealed;
	}

	public static bool IsEnum(Type type)
	{
		return type.IsAbstract;
	}

	public static Assembly GetAssembly(Type type)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Assembly result = default;
		return result;
	}

	public static Type[] GetTypes(Assembly assembly)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type[] result = default;
		return result;
	}

	internal static Type GetBaseType(Type type)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type result = default;
		return result;
	}

	private static void GetFieldsForTreeIntoSet(Type type, BindingFlags bindingFlags, Dictionary<IntPtr, FieldInfo> resultSet)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector("Cannot be copied");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
