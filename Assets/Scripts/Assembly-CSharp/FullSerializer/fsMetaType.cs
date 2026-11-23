using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using FullSerializer.Internal;
using UnityEngine;

namespace FullSerializer;

public class fsMetaType
{
	public class AotFailureException : Exception
	{
		public AotFailureException(string reason)
			: base(reason)
		{
		}
	}

	private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

	public Type ReflectedType;

	private fsMetaProperty[] Properties__BackingField;

	private bool? _hasDefaultConstructorCache;

	private bool? _isDefaultConstructorPublicCache;

	public fsMetaProperty[] Properties
	{
		get
		{
			return Properties__BackingField;
		}
		private set
		{
			Properties__BackingField = value;
		}
	}

	public unsafe bool HasDefaultConstructor
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Expected VT, but got Unknown
			//IL_020e: Expected Ref, but got VT
			//IL_0025: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			//IL_0070: Expected VT, but got I
			//IL_0094: Expected VT, but got I
			//IL_00f6: Expected VT, but got I
			//IL_011a: Expected VT, but got I
			//IL_016e: Expected VT, but got I
			//IL_019d: Expected I, but got Obj
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected Obj, but got Unknown
			//IL_01e7: Expected VT, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			bool? flag = (bool?)(object)(this + 16);
			if ((int)flag == 0)
			{
				Type reflectedType = ReflectedType;
				nint num = (nint)reflectedType;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S1_v9 (Il2CppClass<System.Type>)+1BC] (should have been resolved before IL gen)");
				object obj3 = default;
				if (obj3 != null)
				{
					_ = 0;
					_ = 1;
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E]");
					_hasDefaultConstructorCache = (bool?)(object)0;
					_ = 0;
					_ = 1;
					_ = 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
					_isDefaultConstructorPublicCache = (bool?)(object)0;
				}
				else
				{
					Type reflectedType2 = ReflectedType;
					nint num2 = (nint)reflectedType2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v12 (Il2CppClass<System.Type>)+31C] (should have been resolved before IL gen)");
					object obj4 = default;
					if (obj4 != null)
					{
						_ = 0;
						_ = 1;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+A]");
						_hasDefaultConstructorCache = (bool?)(object)0;
						_ = 0;
						_ = 1;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						_isDefaultConstructorPublicCache = (bool?)(object)0;
					}
					else
					{
						ConstructorInfo declaredConstructor = fsPortableReflection.GetDeclaredConstructor(ReflectedType, fsPortableReflection.EmptyTypes);
						bool flag2 = declaredConstructor != null;
						_ = 0;
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+6]");
						_hasDefaultConstructorCache = (bool?)(object)0;
						if (declaredConstructor != null)
						{
							nint num3 = (nint)declaredConstructor;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ S1_v26 (Il2CppClass<System.Reflection.ConstructorInfo>)+144] (should have been resolved before IL gen)");
							object obj6 = default;
							object obj5 = obj6 & 7;
							bool flag3 = (nint)obj5 == 6;
							_ = 0;
							_ = 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
							_isDefaultConstructorPublicCache = (bool?)(object)0;
						}
					}
				}
			}
			return ((bool?*)flag)->Value;
		}
	}

	public unsafe bool IsDefaultConstructorPublic
	{
		get
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected VT, but got Unknown
			//IL_003a: Invalid comparison between VT and I4
			//IL_001d: Expected Ref, but got VT
			bool? flag = (bool?)(object)(this + 18);
			if (flag == (object)0)
			{
				bool hasDefaultConstructor = HasDefaultConstructor;
			}
			return ((bool?*)flag)->Value;
		}
	}

	public static fsMetaType Get(fsConfig config, Type type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e9: Expected VT, but got Obj
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected Obj, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(fsMetaType));
		_ = 0;
		object obj3 = obj + 36;
		object obj4 = obj + 35;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		object obj5 = obj + 35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				object obj6 = obj + 44;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj7 = default;
					if (obj7 != null)
					{
						goto IL_02a0;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									goto IL_02a0;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_0211;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0211;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0211;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag = obj8 != obj9;
		object obj11 = default;
		object obj10 = obj11;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_02a0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj12 = default;
			obj10 = obj12;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		fsMetaType result = default;
		return result;
		IL_02a0:
		throw new ArgumentNullException();
	}

	public static void ClearCache()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0270: Expected VT, but got Obj
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(fsMetaType));
		_ = 0;
		object obj3 = obj + 28;
		object obj4 = obj + 27;
		obj = obj4;
		_ = 0;
		_ = 0;
		object obj5 = obj + 27;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						Dictionary<fsConfig, Dictionary<Type, fsMetaType>> configMetaTypes = default;
						_configMetaTypes = configMetaTypes;
						goto IL_02d6;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag = obj6 == obj7;
		bool flag2 = !flag;
		object obj9 = default;
		object obj8 = obj9;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_02d6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			object obj10 = default;
			obj8 = obj10;
		}
		_ = 0;
		object obj11 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_02d6;
		IL_02d6:
		throw new ArgumentNullException();
	}

	private fsMetaType(fsConfig config, Type reflectedType)
	{
		ReflectedType = reflectedType;
		List<fsMetaProperty> list = default;
		list._002Ector();
		CollectProperties(config, list, reflectedType);
		Properties__BackingField = list.ToArray();
	}

	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
	{
		//IL_04c1: Expected Obj, but got I4
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Expected Obj, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected Obj, but got Unknown
		Type type = default;
		object obj5 = default;
		while (true)
		{
			fsObjectAttribute attribute = fsPortableReflection.GetAttribute<fsObjectAttribute>(type);
			bool flag = attribute == null;
			fsMemberSerialization defaultMemberSerialization = config.DefaultMemberSerialization;
			if (!flag)
			{
				defaultMemberSerialization = attribute.MemberSerialization;
			}
			MemberInfo[] declaredMembers = fsPortableReflection.GetDeclaredMembers(type);
			object obj = 0;
			if (declaredMembers.Length > (nint)obj)
			{
				object obj2 = obj << 2;
				object obj3 = (object)declaredMembers + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v17+10]");
				_ = 0;
				throw new ArgumentException();
			}
			object obj4 = type + 896;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ S1_v10+BC] (should have been resolved before IL gen)");
			if (obj5 != null)
			{
				object obj6 = type + 896;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ S1_v14+BC] (should have been resolved before IL gen)");
				continue;
			}
			break;
		}
	}

	private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members)
	{
		//IL_008e: Expected I, but got Obj
		//IL_000d: Expected I, but got Obj
		//IL_0045: Expected I, but got Obj
		//IL_005e: Expected VT, but got Obj
		nint num = (nint)property;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.Reflection.PropertyInfo>)+15C] (should have been resolved before IL gen)");
		object obj = default;
		bool flag = obj == null;
		bool result = false;
		if (!flag)
		{
			nint num2 = (nint)property;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S1_v7 (Il2CppClass<System.Reflection.PropertyInfo>)+154] (should have been resolved before IL gen)");
			object obj2 = default;
			bool flag2 = obj2 == null;
			result = false;
			if (!flag2)
			{
				nint num3 = (nint)property;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v54 @ S2_v7 (Il2CppClass<System.Reflection.PropertyInfo>)+174] (should have been resolved before IL gen)");
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CompilerGeneratedAttribute));
				object obj4 = default;
				object obj3 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v74 @ S3_v5+11C] (should have been resolved before IL gen)");
				bool flag3 = default;
				result = flag3;
			}
		}
		return result;
	}

	private static bool CanSerializeProperty(fsConfig config, PropertyInfo property, MemberInfo[] members, bool annotationFreeValue)
	{
		//IL_0390: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_002f: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_017c: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Delegate));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S2_v2+13C] (should have been resolved before IL gen)");
		nint num = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S2_v5 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		bool result = false;
		object obj3 = default;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+8]");
			object obj4 = 0;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S2_v9+174] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+8]");
			object obj6 = 0;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v65 @ S2_v12+184] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			object obj8 = default;
			if (obj8 != null)
			{
				object obj10 = default;
				object obj9 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S1_v39+144] (should have been resolved before IL gen)");
				object obj12 = default;
				object obj11 = obj12 & 0x10;
				object obj13 = obj11 >> 4;
				result = false;
				if (obj13 != null)
				{
					goto IL_0399;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			object obj14 = default;
			if (obj14 != null)
			{
				object obj16 = default;
				object obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S1_v34+144] (should have been resolved before IL gen)");
				object obj18 = default;
				object obj17 = obj18 & 0x10;
				object obj19 = obj17 >> 4;
				result = false;
				if (obj19 != null)
				{
					goto IL_0399;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+8]");
			object obj20 = 0;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ S1_v15+144] (should have been resolved before IL gen)");
			result = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v32+C]");
			if ((nint)0 == 0)
			{
				throw new ArgumentException();
			}
		}
		goto IL_0399;
		IL_0399:
		return result;
	}

	private static bool CanSerializeField(fsConfig config, FieldInfo field, bool annotationFreeValue)
	{
		//IL_01e1: Expected VT, but got Obj
		//IL_0015: Expected Obj, but got I
		//IL_002f: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0066: Expected VT, but got Obj
		//IL_009f: Expected Obj, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Delegate));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
		object obj = 0;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S2_v2+144] (should have been resolved before IL gen)");
		nint num = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S2_v5 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		object obj3 = default;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
			object obj4 = 0;
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(CompilerGeneratedAttribute));
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v108 @ S3_v7+11C] (should have been resolved before IL gen)");
			object obj6 = default;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7+8]");
				object obj7 = 0;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v115 @ S1_v11+13C] (should have been resolved before IL gen)");
				object obj10 = default;
				object obj9 = obj10 & 0x10;
				object obj11 = obj9 >> 4;
				if (obj11 == null)
				{
					throw new ArgumentException();
				}
			}
		}
		bool result = default;
		return result;
	}

	public void EmitAotData(bool throwException)
	{
		//IL_024e: Expected Obj, but got I
		//IL_000e: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		//IL_0126: Expected Obj, but got I
		//IL_014a: Expected Obj, but got I
		//IL_0090: Expected Obj, but got I
		//IL_0199: Expected Obj, but got I
		//IL_01bd: Expected Obj, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.HashSet`1<System.Type>>)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S3_v4+4] (should have been resolved before IL gen)");
		if (!throwException)
		{
			return;
		}
		object obj2 = 0;
		string reason;
		while (true)
		{
			fsMetaProperty[] array = Properties__BackingField;
			if (array.Length > (nint)obj2)
			{
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v33+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v34+20]");
				if ((nint)0 != 0)
				{
					object obj6 = obj2 << 2;
					object obj7 = (object)Properties__BackingField + obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v49+10]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v50+21]");
					if ((nint)0 == 0)
					{
						object obj9 = obj2 + 1;
						obj2 = obj9;
						continue;
					}
					string text = fsTypeExtensions.CSharpName(ReflectedType, includeNamespace: true);
					object obj10 = obj2 << 2;
					object obj11 = (object)Properties__BackingField + obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v57+10]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v58+1C]");
					reason = text + "::" + (string)0 + " is readonly";
					break;
				}
				string text2 = fsTypeExtensions.CSharpName(ReflectedType, includeNamespace: true);
				object obj13 = obj2 << 2;
				object obj14 = (object)Properties__BackingField + obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v42+10]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v43+1C]");
				reason = text2 + "::" + (string)0 + " is not public";
				break;
			}
			if (HasDefaultConstructor)
			{
				return;
			}
			string text3 = fsTypeExtensions.CSharpName(ReflectedType, includeNamespace: true);
			reason = text3 + " does not have a default constructor";
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		AotFailureException ex = default;
		ex._002Ector(reason);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public object CreateInstance()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected Obj, but got Unknown
		//IL_0025: Expected I, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_0833: Expected VT, but got Obj
		//IL_083f: Expected I, but got Obj
		//IL_0126: Expected VT, but got Obj
		//IL_01c5: Expected I, but got Obj
		//IL_01fe: Expected I, but got Obj
		//IL_08a1: Expected Obj, but got I
		//IL_08cc: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected Obj, but got Unknown
		//IL_0563: Expected I, but got Obj
		//IL_07b9: Expected Obj, but got I
		//IL_052d: Expected Obj, but got I
		//IL_0319: Expected I, but got Obj
		//IL_03ad: Expected I, but got Obj
		//IL_0599: Expected Obj, but got I
		//IL_05c4: Expected Obj, but got I
		//IL_05e9: Expected Obj, but got I
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0648: Expected I, but got Obj
		//IL_0439: Expected I, but got Obj
		//IL_067e: Expected Obj, but got I
		//IL_06a9: Expected Obj, but got I
		//IL_06ce: Expected Obj, but got I
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected Obj, but got Unknown
		//IL_072d: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		if (!ReflectedType.IsInterface)
		{
			Type reflectedType = ReflectedType;
			nint num = (nint)reflectedType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S1_v133 (Il2CppClass<System.Type>)+274] (should have been resolved before IL gen)");
			object obj5 = default;
			object obj4 = obj5 & 0x80;
			object obj6 = obj4 >> 7;
			if (obj6 == null)
			{
				goto IL_0824;
			}
		}
		Type reflectedType2 = ReflectedType;
		bool flag = (object)ReflectedType == null;
		string text = null;
		string text2 = "Cannot create an instance of an interface or abstract type for ";
		if (!flag)
		{
			nint num2 = (nint)reflectedType2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v109 @ S1_v130 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
			string text3 = default;
			text = text3;
			text2 = "Cannot create an instance of an interface or abstract type for ";
		}
		string text4 = text2 + text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector(text4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		fsMetaType fsMetaType2 = (fsMetaType)(object)text4;
		goto IL_0824;
		IL_0886:
		ScriptableObject result;
		return result;
		IL_0775:
		ScriptableObject scriptableObject = default;
		result = scriptableObject;
		goto IL_0886;
		IL_088b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj7 = (nint)0 << 2;
		object obj8 = obj3 + obj7;
		ScriptableObject scriptableObject2;
		obj8 = scriptableObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj9 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj10 = (nint)0 << 2;
		object obj11 = obj10 + obj3;
		object obj12 = obj11 - 4;
		Type reflectedType3 = ReflectedType;
		bool flag2 = (object)ReflectedType == null;
		string text5 = null;
		string text6 = "Unable to create instance of ";
		if (!flag2)
		{
			nint num3 = (nint)reflectedType3;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ S1_v39 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
			string text7 = default;
			text5 = text7;
			text6 = "Unable to create instance of ";
		}
		string text8 = text6 + text5 + "; there is no default constructor";
		Exception innerException = (Exception)obj12;
		string message = text8;
		goto IL_0783;
		IL_0783:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex2 = default;
		ex2._002Ector(message, innerException);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj13 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return ex2;
		IL_0824:
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ScriptableObject));
		nint num4 = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v117 @ S2_v3 (Il2CppClass<System.Type>)+16C] (should have been resolved before IL gen)");
		object obj14 = default;
		if (obj14 != null)
		{
			ScriptableObject scriptableObject3 = ScriptableObject.CreateInstance(ReflectedType);
			result = scriptableObject3;
		}
		else
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
			if ((object)typeFromHandle2 == ReflectedType)
			{
				result = (ScriptableObject)(object)string.Empty;
			}
			else
			{
				bool hasDefaultConstructor = HasDefaultConstructor;
				Type reflectedType4 = ReflectedType;
				if (!hasDefaultConstructor)
				{
					object safeUninitializedObject = FormatterServices.GetSafeUninitializedObject(reflectedType4);
					result = (ScriptableObject)safeUninitializedObject;
				}
				else
				{
					nint num5 = (nint)reflectedType4;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v224 @ S1_v17 (Il2CppClass<System.Type>)+1BC] (should have been resolved before IL gen)");
					object obj15 = default;
					if (obj15 != null)
					{
						Type reflectedType5 = ReflectedType;
						nint num6 = (nint)reflectedType5;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ S1_v117 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
						Type elementType = default;
						Array array = Array.CreateInstance(elementType, 0);
						result = (ScriptableObject)(object)array;
					}
					else
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag3 = (nint)0 != 1;
						ScriptableObject scriptableObject4 = default;
						result = scriptableObject4;
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							object obj16 = default;
							object obj17 = default;
							bool flag4 = obj16 == obj17;
							bool flag5 = !flag4;
							scriptableObject2 = scriptableObject4;
							object obj19 = default;
							object obj18 = obj19;
							if (!flag5)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									nint num7 = (nint)scriptableObject;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										scriptableObject2 = scriptableObject;
										object obj20 = default;
										if (obj20 != null)
										{
											goto IL_088b;
										}
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											nint num8 = (nint)scriptableObject;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												object obj21 = default;
												if (obj21 != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
													object obj22 = (nint)0 << 2;
													object obj23 = obj3 + obj22;
													obj23 = scriptableObject;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
													object obj24 = (nint)0 + (nint)1;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
													object obj25 = (nint)0 << 2;
													object obj26 = obj25 + obj3;
													object obj27 = obj26 - 4;
													Type reflectedType6 = ReflectedType;
													bool flag6 = (object)ReflectedType == null;
													string text9 = null;
													string text10 = "Constructor of ";
													if (!flag6)
													{
														nint num9 = (nint)reflectedType6;
														Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v553 @ S1_v85 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
														string text11 = default;
														text9 = text11;
														text10 = "Constructor of ";
													}
													string text12 = text10 + text9 + " threw an exception when creating an instance";
													innerException = (Exception)obj27;
													message = text12;
													goto IL_0783;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													nint num10 = (nint)scriptableObject;
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj28 = default;
														if (obj28 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
															object obj29 = (nint)0 << 2;
															object obj30 = obj3 + obj29;
															obj30 = scriptableObject;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
															object obj31 = (nint)0 + (nint)1;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
															object obj32 = (nint)0 << 2;
															object obj33 = obj32 + obj3;
															object obj34 = obj33 - 4;
															Type reflectedType7 = ReflectedType;
															bool flag7 = (object)ReflectedType == null;
															string text13 = null;
															string text14 = "Unable to access constructor of ";
															if (!flag7)
															{
																nint num11 = (nint)reflectedType7;
																Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v615 @ S1_v108 (Il2CppClass<System.Type>)+D4] (should have been resolved before IL gen)");
																string text15 = default;
																text13 = text15;
																text14 = "Unable to access constructor of ";
															}
															string text16 = text14 + text13;
															innerException = (Exception)obj34;
															message = text16;
															goto IL_0783;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
														object obj35 = scriptableObject;
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															goto IL_0775;
														}
													}
												}
											}
										}
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag8 = (nint)0 == 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								fsMetaType2 = (fsMetaType)0;
								scriptableObject2 = scriptableObject;
								object obj36 = default;
								obj18 = obj36;
								if (flag8)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
									goto IL_0775;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
							goto IL_088b;
						}
					}
				}
			}
		}
		goto IL_0886;
	}

	static fsMetaType()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<FullSerializer.fsConfig, System.Collections.Generic.Dictionary`2<System.Type, FullSerializer.fsMetaType>>>>)+4] (should have been resolved before IL gen)");
		Dictionary<fsConfig, Dictionary<Type, fsMetaType>> configMetaTypes = default;
		_configMetaTypes = configMetaTypes;
	}
}
