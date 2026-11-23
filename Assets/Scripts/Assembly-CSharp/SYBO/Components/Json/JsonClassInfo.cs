using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonClassInfo
{
	public JsonFieldInfo[] CachedSerializedFields;

	public Type type;

	private FieldInfo _keyField;

	private FieldInfo _jsonContextField;

	private static Dictionary<Type, JsonClassInfo> _cachedSerializedFields;

	public bool TypeHasKey
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
			bool result = default;
			return result;
		}
	}

	public string GetKey(object obj)
	{
		//IL_0043: Expected I, but got Obj
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj2 = default;
		if (obj2 != null)
		{
			return null;
		}
		FieldInfo keyField = _keyField;
		nint num = (nint)keyField;
		object obj3 = keyField + 200;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v4 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5;
		object obj6 = obj5 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S1_v5+D4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public void SetKeyField(FieldInfo field)
	{
		_keyField = field;
	}

	public object Construct(JsonContext context)
	{
		//IL_0035: Expected I, but got Obj
		ConstructorInfo constructor = ReflectionWrapper.GetConstructor(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
		object obj = default;
		object uninitializedObject = default;
		if (obj == null)
		{
			nint num = (nint)constructor;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S5_v3 (Il2CppClass<System.Reflection.ConstructorInfo>)+1FC] (should have been resolved before IL gen)");
		}
		else
		{
			uninitializedObject = ReflectionWrapper.GetUninitializedObject(type);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E4");
		object obj2 = default;
		if (obj2 != null)
		{
			_jsonContextField.SetValue(uninitializedObject, context);
		}
		return uninitializedObject;
	}

	public unsafe static JsonClassInfo GetJsonTypeReflection(Type settingsType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Ref, but got Unknown
		//IL_02bf: Expected Obj, but got I
		//IL_01fe: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I
		//IL_009c: Expected Obj, but got I
		//IL_00a4: Expected I, but got Obj
		//IL_00bd: Expected VT, but got Obj
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Ref, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected Ref, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Ref, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Ref, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Ref, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Ref, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_00fd: Expected Obj, but got I
		//IL_0172: Expected Obj, but got I
		//IL_01d1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		if (!_cachedSerializedFields.TryGetValue(settingsType, out *(JsonClassInfo*)(obj + 28)))
		{
			FieldInfo[] fieldsForTree = ReflectionWrapper.GetFieldsForTree(settingsType, (BindingFlags)52);
			List<JsonFieldInfo> list = default;
			list._002Ector(fieldsForTree.Length);
			object obj3 = default;
			object obj6 = default;
			JsonFieldInfo jsonFieldInfo = default;
			object obj9 = default;
			while (fieldsForTree.Length > (nint)obj3)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)fieldsForTree + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v49+10]");
				FieldInfo fieldInfo = (FieldInfo)0;
				nint num = (nint)fieldInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ S1_v28 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
				Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonContext));
				if (typeFromHandle == obj6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj7 = 0;
				}
				if (ShouldSerializeField(fieldInfo, out *(bool*)(obj + 27), out *(bool*)(obj + 26), out *(bool*)(obj + 25), out *(string*)(obj + 20), out *(int*)(obj + 16), out *(bool*)(obj + 15)))
				{
					jsonFieldInfo.Field = fieldInfo;
					Type valueType = LookupValueType(fieldInfo);
					jsonFieldInfo.ValueType = valueType;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B]");
					jsonFieldInfo.SerializeByKey = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+19]");
					jsonFieldInfo.EnumAsString = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+14]");
					jsonFieldInfo.SerializedName = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					jsonFieldInfo.SizeLimit = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
					jsonFieldInfo.FailOnSizeLimit = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
						object obj8 = 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B]");
					jsonFieldInfo.SerializeByKey = false;
					list.Add(jsonFieldInfo);
				}
				obj3 = obj9 + 1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
			object obj10 = 0;
			JsonFieldInfo[] array = list.ToArray();
			nint num2 = 0;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, SYBO.Components.Json.JsonClassInfo>>)+5C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v192 @ S5_v6+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		return (JsonClassInfo)0;
	}

	private static Type LookupValueType(FieldInfo field)
	{
		//IL_00c7: Expected I, but got Obj
		//IL_00e0: Expected VT, but got Obj
		//IL_00ec: Expected I, but got Obj
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0139: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		//IL_0014: Expected VT, but got Obj
		//IL_0025: Expected I, but got Obj
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0067: Expected Obj, but got I4
		nint num = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v3 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IList<>));
		nint num2 = (nint)typeFromHandle;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v5 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
		Type type = default;
		object obj = type + 920;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v45 @ S3_v5+BC] (should have been resolved before IL gen)");
		object obj2 = default;
		bool flag = obj2 == null;
		bool flag2 = !flag;
		object obj3 = obj2;
		object obj4 = 0;
		Type result;
		if (!flag2)
		{
			Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(IDictionary<, >));
			nint num3 = (nint)typeFromHandle2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S2_v15 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
			object obj5 = type + 920;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S3_v13+BC] (should have been resolved before IL gen)");
			object obj6 = default;
			bool flag3 = obj6 == null;
			obj3 = obj6;
			obj4 = 1;
			result = type;
			if (flag3)
			{
				goto IL_0147;
			}
		}
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S1_v11+24C] (should have been resolved before IL gen)");
		object obj8 = obj4 << 2;
		object obj10 = default;
		object obj9 = obj10 + obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v20+10]");
		result = (Type)0;
		goto IL_0147;
		IL_0147:
		return result;
	}

	private unsafe static bool ShouldSerializeField(FieldInfo field, out bool serializeAsKey, out bool isKeyField, out bool enumAsString, out string serializedName, out int sizeLimit, out bool failOnSizeLimit)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04c0: Expected I, but got Obj
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Expected Obj, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_053c: Expected I, but got Obj
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected Obj, but got Unknown
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected Obj, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected Obj, but got Unknown
		//IL_0633: Expected Obj, but got I4
		//IL_06ea: Expected Obj, but got I4
		//IL_073c: Expected Obj, but got I4
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected I4, but got Unknown
		//IL_0246: Expected Obj, but got I4
		//IL_027e: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		nint num = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<System.Reflection.FieldInfo>)+13C] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4 & 7;
		bool flag = (nint)obj3 == 6;
		ref bool reference = ref *(bool*)null;
		ref bool reference2 = ref *(bool*)null;
		ref bool reference3 = ref *(bool*)null;
		object obj5 = field - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S2_v5+BC] (should have been resolved before IL gen)");
		object obj6 = default;
		ref string reference4 = ref *(string*)obj6;
		ref int reference5 = ref *(int*)(-1);
		ref bool reference6 = ref *(bool*)null;
		nint num2 = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ S2_v8 (Il2CppClass<System.Reflection.FieldInfo>)+124] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj7 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag2 = flag;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		object obj22 = default;
		object obj23 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				if (obj8 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj9 == null)
						{
							goto IL_05a5;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v169+C]");
							reference5 = ref *(int*)null;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v180+8]");
								reference6 = ref *(bool*)null;
								goto IL_05a5;
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
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_0380;
			IL_0380:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag3 = obj10 == obj11;
			bool flag4 = !flag3;
			object obj12 = obj13;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj12 = obj14;
			}
			_ = 0;
			object obj15 = obj + 16;
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
			break;
			IL_05a5:
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj16 != null)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0380;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v158+8]");
					reference4 = ref *(string*)null;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj17 != null)
					{
						reference3 = ref *(bool*)1;
					}
					bool flag5 = obj18 == null;
					object obj19 = 0;
					if (!flag5)
					{
						bool flag6 = obj18 == typeof(SerializeField);
						obj19 = obj18;
						if (!flag6)
						{
							obj19 = 0;
						}
					}
					bool flag7 = obj18 == null;
					object obj20 = 0;
					if (!flag7)
					{
						bool flag8 = obj18 == typeof(NonSerializedAttribute);
						obj20 = obj18;
						if (!flag8)
						{
							obj20 = 0;
						}
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
					_ = 0;
					bool flag9 = obj20 == null;
					bool flag10 = obj19 != null;
					object obj21 = flag2 | flag10;
					bool flag11 = (byte)((flag9 & obj21) ? 1 : 0) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (obj22 != null)
						{
							reference2 = ref *(bool*)1;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							bool flag12 = obj23 == null;
							flag2 = flag11;
							if (!flag12)
							{
								reference = ref *(bool*)1;
								flag2 = flag11;
							}
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						flag2 = flag11;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						flag2 = flag11;
					}
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
			goto IL_0380;
		}
		object obj24 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return flag2;
	}

	static JsonClassInfo()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, SYBO.Components.Json.JsonClassInfo>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, JsonClassInfo> cachedSerializedFields = default;
		_cachedSerializedFields = cachedSerializedFields;
	}
}
