using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using InAppPurchase.Internal;
using SYBO.Components.Json.Internal;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.DateTimeUtilities;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonClassInfo
{
	public readonly Type type;

	public readonly JsonFieldInfo[] CachedSerializedFields;

	public readonly JsonFieldInfo[] CachedSerializedStaticFields;

	private FieldInfo _keyField;

	private FieldInfo _jsonContextField;

	private static Dictionary<Type, JsonClassInfo> _cachedClassInfo;

	public bool TypeHasKey
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009d: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)JsonParser.ParseHex((string)(object)this) != 0;
		}
	}

	private JsonClassInfo(Type reflectedType)
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		type = reflectedType;
		object obj2 = this + 12;
		obj2 = "Singletons";
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj4 = (nint)0 + (nint)44;
		obj4 = this;
	}

	public unsafe string GetKey(object obj)
	{
		//IL_0033: Expected I, but got Obj
		//IL_0049: Expected Obj, but got I
		//IL_0074: Expected I, but got Obj
		bool flag = obj == null;
		bool flag2 = !flag;
		JsonCustomSerializer jsonCustomSerializer = (JsonCustomSerializer)obj;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer2 = default;
			jsonCustomSerializer2._002Ector();
			jsonCustomSerializer = jsonCustomSerializer2;
		}
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v9 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)JsonParser.ParseObject((string)(object)this, ref *(int*)jsonCustomSerializer);
	}

	public object Construct(JsonContext context)
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		if (context != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
			nint num = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v13 (Il2CppClass<System.Type>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v41 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = default;
			if (obj2 != type)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				object obj3 = default;
				if (obj3 == null)
				{
					string message = $"Object must be descendant of the type associated with the JsonClassInfo instance. ({(object[])(object)type})";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					JsonSerializationException ex = default;
					ex._002Ector(message);
					((JsonClassInfo)(object)ex).GetKey((object)null);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				object obj5 = default;
				if (obj5 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
					object result = default;
					return result;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	private JsonFieldInfo[] GetJsonFields(BindingFlags fieldFlags)
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_011d: Expected VT, but got Obj
		JsonFieldInfo[] result;
		if (ReflectionWrapper.IsValueType(type))
		{
			result = null;
		}
		else
		{
			object uninitializedObject = ReflectionWrapper.GetUninitializedObject(type);
			nint num = (nint)typeof(ConstructorInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v14 (Il2CppClass<System.Reflection.ConstructorInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(ConstructorInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<System.Reflection.ConstructorInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
			object obj2 = default;
			IEnumerable<Type> enumerable;
			if (obj2 != null)
			{
				bool flag = ((ConstructorInfo)uninitializedObject).Equals((object)null);
				enumerable = (IEnumerable<Type>)flag;
			}
			else
			{
				enumerable = ReflectionWrapper.GetDerivedTypes(type);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
			object obj3 = default;
			bool flag2 = obj3 == null;
			result = (JsonFieldInfo[])(object)enumerable;
			if (!flag2)
			{
				_jsonContextField.SetValueDirect((TypedReference)enumerable, fieldFlags);
				result = (JsonFieldInfo[])(object)enumerable;
			}
		}
		return result;
	}

	public unsafe static void DiscardClassInfoCache()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected I4, but got Unknown
		//IL_00e2: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I
		//IL_0026: Expected I4, but got Obj
		//IL_0041: Expected I, but got Obj
		//IL_0057: Expected Obj, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_0076: Expected Obj, but got I4
		//IL_009a: Expected I4, but got Obj
		//IL_00a8: Expected VT, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 28;
		obj = 0;
		CallingConvention callingConvention = (CallingConvention)(obj2 + 16);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		DateTimeUtils.RFC3339SplitSymbols = (char[])(object)unmanagedFunctionPointerAttribute;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = obj2 + 24;
		obj3 = 0;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute2 = default;
		unmanagedFunctionPointerAttribute2._002Ector(callingConvention);
		nint num = (nint)typeof(DateTimeUtils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v27 (Il2CppClass<SYBO.Components.Utilities.DateTimeUtilities.DateTimeUtils>)+5C]");
		object obj4 = (nint)0 + (nint)4;
		obj4 = unmanagedFunctionPointerAttribute2;
		object obj5 = obj2 + 8;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC8A");
		obj2 = obj5;
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj2;
		DateTimeUtils.FallbackDateTime = (DateTime)((CallingConvention*)(int)callingConvention)->value__;
	}

	public static bool IsClassInfoCached(Type reflectedType)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF49");
		bool result = default;
		return result;
	}

	public static JsonClassInfo GetJsonTypeReflection(Type reflectedType)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(JsonClassInfo);
		if (!flag)
		{
			nint num3 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(JsonClassInfo);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(JsonClassInfo);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		bool flag4 = (nint)obj7 > -1;
		return (JsonClassInfo)flag4;
	}

	public static JsonClassInfo GetNonCachedTypeReflection(Type reflectedType)
	{
		//IL_0105: Expected Obj, but got I4
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0146: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Obj, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_0069: Expected I, but got Obj
		//IL_00bd: Expected I, but got Obj
		object result = 0;
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(JsonClassInfo);
		if (!flag)
		{
			nint num3 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v37 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(JsonClassInfo);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(JsonClassInfo);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj2 = default;
		if (obj2 == null)
		{
			nint num4 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v23 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(JsonClassInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v33 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string serializedName = GetSerializedName((FieldInfo)(object)reflectedType);
			result = serializedName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S4_v3 (Il2CppMethodInfo)+C]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S4_v4+60]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v5+48]");
			object obj6 = 0;
			object obj7 = obj6 & 0x7FF;
			object obj8 = obj7 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59 @ S5_v5 (should have been resolved before IL gen)");
		}
		return (JsonClassInfo)result;
	}

	public static string GetSerializedName(FieldInfo field)
	{
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((object)field != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonContext jsonContext = default;
			jsonContext.RegisterSerializationCallBack((ISerializationCallbackReceiver)field);
			return (string)(object)jsonContext;
		}
		return null;
	}

	private unsafe static Type LookupValueType(FieldInfo field)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected I, but got Unknown
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_0133: Expected I, but got Obj
		//IL_005e: Expected I, but got Obj
		//IL_00ca: Expected Obj, but got I
		object obj = default;
		nint num = (nint)(obj + 4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FF48");
		object obj2 = default;
		if (obj2 != null)
		{
			return null;
		}
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<System.Type>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v29 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = typeof(SerializedAsAttribute);
		((IntPtr*)num)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8582");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj4 = default;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v24+8]");
			return (Type)0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type result = default;
		return result;
	}

	private unsafe static bool ShouldSerializeField(FieldInfo field, out bool serializeAsKey, out bool isKeyField, out bool enumAsString, out string serializedName, out int sizeLimit, out bool failOnSizeLimit)
	{
		//IL_0117: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_015d: Expected I4, but got Obj
		//IL_015d: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected Obj, but got Unknown
		nint num = (nint)typeof(AndroidPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((string)System.Runtime.CompilerServices.Unsafe.AsPointer(ref serializeAsKey)).Substring((int)AndroidPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		ref bool reference;
		ref bool reference2;
		ref bool reference3;
		ref string reference4;
		ref int reference5;
		if (text.m_firstChar == '\u0005')
		{
			object obj2 = text + 16;
			reference = ref *(bool*)obj2;
			object obj3 = text + 20;
			reference2 = ref *(bool*)obj3;
			object obj4 = text + 24;
			reference3 = ref *(bool*)obj4;
			object obj5 = text + 28;
			reference4 = ref *(string*)obj5;
			object obj6 = text + 32;
			reference5 = ref *(int*)obj6;
			return true;
		}
		reference = ref *(bool*)"";
		reference2 = ref *(bool*)"";
		reference3 = ref *(bool*)"";
		reference4 = ref *(string*)"";
		reference5 = ref *(int*)"";
		return false;
	}

	static JsonClassInfo()
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(JsonClassInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(JsonClassInfo);
		if (!flag)
		{
			nint num3 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(JsonClassInfo);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(JsonClassInfo);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		object obj2 = default;
		((Dictionary<TKey, TValue>)obj2).Resize();
	}
}
