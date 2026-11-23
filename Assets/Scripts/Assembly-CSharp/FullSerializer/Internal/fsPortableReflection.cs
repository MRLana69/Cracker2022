using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace FullSerializer.Internal;

public static class fsPortableReflection
{
	private struct AttributeQuery
	{
		public MemberInfo MemberInfo;

		public Type AttributeType;
	}

	private class AttributeQueryComparator : IEqualityComparer<AttributeQuery>
	{
		public bool Equals(AttributeQuery x, AttributeQuery y)
		{
			if (x.MemberInfo == y.MemberInfo)
			{
				return (object)y.AttributeType == x.AttributeType;
			}
			return false;
		}

		public int GetHashCode(AttributeQuery obj)
		{
			//IL_0015: Expected I, but got Obj
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			//IL_0042: Expected I, but got Obj
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected Obj, but got Unknown
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected Obj, but got Unknown
			//IL_0075: Expected I4, but got Obj
			MemberInfo memberInfo = obj.MemberInfo;
			nint num = (nint)memberInfo;
			object obj2 = memberInfo + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.Reflection.MemberInfo>)+CC] (should have been resolved before IL gen)");
			Type attributeType = obj.AttributeType;
			nint num2 = (nint)attributeType;
			object obj3 = attributeType + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S2_v5 (Il2CppClass<System.Type>)+CC] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 * 17;
			object obj6 = default;
			return (int)(obj6 + obj4);
		}
	}

	private sealed class _003CGetFlattenedMethods_003Ed__18 : IEnumerable<MethodInfo>, IEnumerable, IEnumerator<MethodInfo>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private MethodInfo _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Type type;

		public Type _003C_003E3__type;

		private string methodName;

		public string _003C_003E3__methodName;

		private MethodInfo[] _003Cmethods_003E5__2;

		private int _003Ci_003E5__3;

		MethodInfo IEnumerator<MethodInfo>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetFlattenedMethods_003Ed__18(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			_003C_003El__initialThreadId = currentManagedThreadId;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005b: Expected Obj, but got I4
			//IL_004d: Expected Obj, but got I4
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Expected Obj, but got Unknown
			//IL_01ad: Expected Obj, but got I4
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_00eb: Expected Obj, but got I
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_01bb: Expected Obj, but got I4
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Expected Obj, but got Unknown
			//IL_0160: Expected Obj, but got I
			object obj;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01df;
				}
				_003C_003E1__state = -1;
				obj = 0;
			}
			else
			{
				_003C_003E1__state = -1;
				obj = 1;
			}
			object obj2 = obj;
			string text = default;
			Type type2 = default;
			while (true)
			{
				int num;
				if (obj2 == null)
				{
					num = _003Ci_003E5__3 + 1;
				}
				else
				{
					if ((object)this.type == null)
					{
						break;
					}
					MethodInfo[] declaredMethods = GetDeclaredMethods(this.type);
					_003Cmethods_003E5__2 = declaredMethods;
					num = 0;
				}
				_003Ci_003E5__3 = num;
				MethodInfo[] array = _003Cmethods_003E5__2;
				if (array.Length > num)
				{
					int num2 = num << 2;
					object obj3 = array + num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v22+10]");
					object obj4 = 0;
					object obj5 = obj4 - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v107 @ S1_v15+BC] (should have been resolved before IL gen)");
					if (text == methodName)
					{
						int num3 = _003Ci_003E5__3 << 2;
						object obj6 = _003Cmethods_003E5__2 + num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v21+10]");
						_003C_003E2__current = (MethodInfo)0;
						_003C_003E1__state = 1;
						return true;
					}
					obj2 = 0;
				}
				else
				{
					Type type = this.type;
					object obj7 = type + 896;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S2_v5+BC] (should have been resolved before IL gen)");
					this.type = type2;
					_003Cmethods_003E5__2 = null;
					obj2 = 1;
				}
			}
			goto IL_01df;
			IL_01df:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}

		IEnumerator<MethodInfo> IEnumerable<MethodInfo>.GetEnumerator()
		{
			_003CGetFlattenedMethods_003Ed__18 obj;
			if (_003C_003E1__state == -2)
			{
				int currentManagedThreadId = Environment.CurrentManagedThreadId;
				if (_003C_003El__initialThreadId == currentManagedThreadId)
				{
					_003C_003E1__state = 0;
					obj = this;
					goto IL_005f;
				}
			}
			_003CGetFlattenedMethods_003Ed__18 obj2 = default;
			obj2._002Ector(0);
			obj = obj2;
			goto IL_005f;
			IL_005f:
			obj.type = _003C_003E3__type;
			obj.methodName = _003C_003E3__methodName;
			return obj;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<MethodInfo>)this).GetEnumerator();
		}
	}

	public static Type[] EmptyTypes;

	private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries;

	private static BindingFlags DeclaredFlags;

	public static bool HasAttribute<TAttribute>(MemberInfo element)
	{
		//IL_002a: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		return HasAttribute(element, typeFromHandle);
	}

	public static bool HasAttribute<TAttribute>(MemberInfo element, bool shouldCache)
	{
		//IL_002b: Expected VT, but got I
		//IL_000d: Expected I, but got Obj
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		nint num2 = (nint)element;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S3_v2 (Il2CppClass<System.Reflection.MemberInfo>)+11C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool HasAttribute(MemberInfo element, Type attributeType)
	{
		//IL_000d: Expected I, but got Obj
		nint num = (nint)element;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S3_v2 (Il2CppClass<System.Reflection.MemberInfo>)+11C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static bool HasAttribute(MemberInfo element, Type attributeType, bool shouldCache)
	{
		//IL_0008: Expected I, but got Obj
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		nint num = (nint)element;
		object obj = element + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S3_v2 (Il2CppClass<System.Reflection.MemberInfo>)+11C] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I
		//IL_0029: Expected I, but got Obj
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_00aa: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		object obj4 = obj + 8;
		object obj5 = obj + 44;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38D6");
		object obj6 = default;
		if (obj6 == null)
		{
			nint num = (nint)element;
			object obj7 = element + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S3_v5 (Il2CppClass<System.Reflection.MemberInfo>)+12C] (should have been resolved before IL gen)");
			IEnumerable<object> source = default;
			if (Enumerable.Any(source))
			{
				object obj8 = Enumerable.First(source);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			}
			if (shouldCache)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C38");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
		return (Attribute)0;
	}

	public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache) where TAttribute : Attribute
	{
		//IL_0047: Expected VT, but got I
		nint num = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)num);
		Attribute attribute = GetAttribute(element, typeFromHandle, shouldCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		TAttribute result = default;
		return result;
	}

	public static TAttribute GetAttribute<TAttribute>(MemberInfo element) where TAttribute : Attribute
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<FullSerializer.Internal.fsPortableReflection::GetAttribute>>)+4] (should have been resolved before IL gen)");
		TAttribute result = default;
		return result;
	}

	public static PropertyInfo GetDeclaredProperty(Type type, string propertyName)
	{
		//IL_00cb: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I
		PropertyInfo[] declaredProperties = GetDeclaredProperties(type);
		object obj = 0;
		string text = default;
		while (declaredProperties.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)declaredProperties + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16+10]");
			object obj4 = 0;
			object obj5 = obj4 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v9+BC] (should have been resolved before IL gen)");
			if (text == propertyName)
			{
				object obj6 = obj << 2;
				object obj7 = (object)declaredProperties + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v23+10]");
				return (PropertyInfo)0;
			}
			object obj8 = obj + 1;
			obj = obj8;
		}
		return null;
	}

	public static MethodInfo GetDeclaredMethod(Type type, string methodName)
	{
		//IL_00cb: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I
		MethodInfo[] declaredMethods = GetDeclaredMethods(type);
		object obj = 0;
		string text = default;
		while (declaredMethods.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)declaredMethods + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16+10]");
			object obj4 = 0;
			object obj5 = obj4 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v9+BC] (should have been resolved before IL gen)");
			if (text == methodName)
			{
				object obj6 = obj << 2;
				object obj7 = (object)declaredMethods + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v23+10]");
				return (MethodInfo)0;
			}
			object obj8 = obj + 1;
			obj = obj8;
		}
		return null;
	}

	public static ConstructorInfo GetDeclaredConstructor(Type type, Type[] parameters)
	{
		//IL_0147: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_0038: Expected I, but got Obj
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		//IL_0074: Expected I, but got Obj
		//IL_00b1: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_00ea: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_011a: Expected Obj, but got I
		ConstructorInfo[] declaredConstructors = GetDeclaredConstructors(type);
		object obj = 0;
		object obj5 = default;
		ConstructorInfo result;
		object obj11 = default;
		while (true)
		{
			if (declaredConstructors.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)declaredConstructors + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v18+10]");
				ConstructorInfo constructorInfo = (ConstructorInfo)0;
				nint num = (nint)constructorInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v52 @ S1_v9 (Il2CppClass<System.Reflection.ConstructorInfo>)+144] (should have been resolved before IL gen)");
				object obj4 = obj5 & 0x10;
				object obj6 = obj4 >> 4;
				if (obj6 == null)
				{
					nint num2 = (nint)constructorInfo;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ S1_v16 (Il2CppClass<System.Reflection.ConstructorInfo>)+13C] (should have been resolved before IL gen)");
					int num3 = parameters.Length;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v27+C]");
					if ((nint)num3 == 0)
					{
						object obj7 = parameters.Length;
						object obj8 = 0;
						while (true)
						{
							bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
							result = constructorInfo;
							if (flag)
							{
								break;
							}
							object obj9 = obj8 << 2;
							object obj10 = obj11 + obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v36+10]");
							object obj12 = 0;
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S1_v25+114] (should have been resolved before IL gen)");
							object obj14 = obj8 + 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v27+C]");
							obj7 = 0;
							obj8 = obj14;
						}
						break;
					}
				}
				object obj15 = obj + 1;
				obj = obj15;
				continue;
			}
			result = null;
			break;
		}
		return result;
	}

	public static ConstructorInfo[] GetDeclaredConstructors(Type type)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 664;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S2_v2 (Il2CppClass<System.Type>)+354] (should have been resolved before IL gen)");
		ConstructorInfo[] result = default;
		return result;
	}

	public static MemberInfo[] GetFlattenedMember(Type type, string memberName)
	{
		//IL_003d: Expected Obj, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I
		List<MemberInfo> list = default;
		list._002Ector();
		Type type2 = default;
		string text = default;
		Type type3 = default;
		while ((object)type2 != null)
		{
			MemberInfo[] declaredMembers = GetDeclaredMembers(type2);
			object obj = 0;
			while (declaredMembers.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)declaredMembers + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v28+10]");
				object obj4 = 0;
				object obj5 = obj4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ S1_v18+BC] (should have been resolved before IL gen)");
				if (text == memberName)
				{
					object obj6 = obj << 2;
					object obj7 = (object)declaredMembers + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v24+10]");
					list.Add((MemberInfo)0);
				}
				object obj8 = obj + 1;
				obj = obj8;
			}
			object obj9 = type3 + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ S1_v12+BC] (should have been resolved before IL gen)");
		}
		return list.ToArray();
	}

	public static MethodInfo GetFlattenedMethod(Type type, string methodName)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		Type type2 = default;
		string text = default;
		Type type3 = default;
		while ((object)type2 != null)
		{
			MethodInfo[] declaredMethods = GetDeclaredMethods(type2);
			object obj = 0;
			while (declaredMethods.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)declaredMethods + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v24+10]");
				object obj4 = 0;
				object obj5 = obj4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S1_v13+BC] (should have been resolved before IL gen)");
				if (text == methodName)
				{
					object obj6 = obj << 2;
					object obj7 = (object)declaredMethods + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31+10]");
					return (MethodInfo)0;
				}
				object obj8 = obj + 1;
				obj = obj8;
			}
			object obj9 = type3 + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S1_v7+BC] (should have been resolved before IL gen)");
		}
		return null;
	}

	public static IEnumerable<MethodInfo> GetFlattenedMethods(Type type, string methodName)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @40F");
		IEnumerable<MethodInfo> result = default;
		return result;
	}

	public static PropertyInfo GetFlattenedProperty(Type type, string propertyName)
	{
		//IL_0020: Expected Obj, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected Obj, but got Unknown
		//IL_0050: Expected Obj, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I
		Type type2 = default;
		string text = default;
		Type type3 = default;
		while ((object)type2 != null)
		{
			PropertyInfo[] declaredProperties = GetDeclaredProperties(type2);
			object obj = 0;
			while (declaredProperties.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)declaredProperties + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v24+10]");
				object obj4 = 0;
				object obj5 = obj4 - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S1_v13+BC] (should have been resolved before IL gen)");
				if (text == propertyName)
				{
					object obj6 = obj << 2;
					object obj7 = (object)declaredProperties + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v31+10]");
					return (PropertyInfo)0;
				}
				object obj8 = obj + 1;
				obj = obj8;
			}
			object obj9 = type3 + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v90 @ S1_v7+BC] (should have been resolved before IL gen)");
		}
		return null;
	}

	public static MemberInfo GetDeclaredMember(Type type, string memberName)
	{
		//IL_00cb: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I
		MemberInfo[] declaredMembers = GetDeclaredMembers(type);
		object obj = 0;
		string text = default;
		while (declaredMembers.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)declaredMembers + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16+10]");
			object obj4 = 0;
			object obj5 = obj4 - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S1_v9+BC] (should have been resolved before IL gen)");
			if (text == memberName)
			{
				object obj6 = obj << 2;
				object obj7 = (object)declaredMembers + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v23+10]");
				return (MemberInfo)0;
			}
			object obj8 = obj + 1;
			obj = obj8;
		}
		return null;
	}

	public static MethodInfo[] GetDeclaredMethods(Type type)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S2_v2 (Il2CppClass<System.Type>)+3DC] (should have been resolved before IL gen)");
		MethodInfo[] result = default;
		return result;
	}

	public static PropertyInfo[] GetDeclaredProperties(Type type)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		object obj = type + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S2_v3+BC] (should have been resolved before IL gen)");
		PropertyInfo[] result = default;
		return result;
	}

	public static FieldInfo[] GetDeclaredFields(Type type)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S2_v2 (Il2CppClass<System.Type>)+374] (should have been resolved before IL gen)");
		FieldInfo[] result = default;
		return result;
	}

	public static MemberInfo[] GetDeclaredMembers(Type type)
	{
		//IL_000d: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		nint num = (nint)type;
		object obj = type + 728;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v19 @ S2_v2 (Il2CppClass<System.Type>)+394] (should have been resolved before IL gen)");
		MemberInfo[] result = default;
		return result;
	}

	public static MemberInfo AsMemberInfo(Type type)
	{
		return type;
	}

	public static bool IsType(MemberInfo member)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		object obj = default;
		return obj != null;
	}

	public static Type AsType(MemberInfo member)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
		Type result = default;
		return result;
	}

	public static Type Resolve(Type type)
	{
		return type;
	}

	static fsPortableReflection()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Type[] emptyTypes = default;
		EmptyTypes = emptyTypes;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<FullSerializer.Internal.fsPortableReflection+AttributeQuery, System.Attribute>>>)+4] (should have been resolved before IL gen)");
		IDictionary<AttributeQuery, Attribute> cachedAttributeQueries = default;
		_cachedAttributeQueries = cachedAttributeQueries;
		DeclaredFlags = (BindingFlags)62;
	}
}
