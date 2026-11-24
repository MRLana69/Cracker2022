using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonCustomSerializerCollection
{
	private Dictionary<Type, JsonCustomSerializer> _customSerializers;

	public int CustomSerializerCount
	{
		get
		{
			//IL_0078: Expected Obj, but got I
			//IL_0088: Expected Obj, but got I
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected Obj, but got Unknown
			//IL_00c6: Expected Obj, but got I
			//IL_0058: Expected I4, but got Obj
			//IL_0015: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I
			//IL_004e: Expected Obj, but got I
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonCustomSerializerCollection)+24]");
			Type objType = default;
			JsonContext jsonContext = default;
			for (object obj6 = 0; obj6 != null; obj6 = 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ L1_v3+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ L1_v3+10]");
				JsonReflectionParser.ReflectionDeserializeOnto(objType, 0, (JsonDict)(object)this, jsonContext);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ L1_v3+14]");
			}
			return (int)jsonContext;
		}
	}

	public unsafe bool HasSerializer(Type type)
	{
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected I, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_025f: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0276: Expected Obj, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_028d: Expected Obj, but got I4
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I4
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_032a: Expected I, but got Obj
		//IL_036c: Expected I, but got Obj
		//IL_0382: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_0113: Expected I, but got Obj
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected Obj, but got Unknown
		//IL_0180: Expected I, but got Obj
		//IL_0196: Expected Obj, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected Obj, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected Obj, but got Unknown
		//IL_01c1: Expected I, but got Obj
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		object obj = default;
		nint num = (nint)(obj + 12);
		object obj2 = obj + 19;
		obj2 = 0;
		object obj3 = obj + 18;
		obj3 = 0;
		object obj4 = obj + 17;
		obj4 = 0;
		object obj5 = obj + 8;
		obj5 = 0;
		object obj6 = obj + 16;
		obj6 = 0;
		object obj7 = obj + 4;
		obj7 = 0;
		Type type2 = ReflectionWrapper.GetInterface((Type)(object)_customSerializers, type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj8 = type2 + 12;
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)obj8);
		object obj9 = default;
		object obj14 = default;
		object obj17 = default;
		IEnumerable<_00210> enumerable = default;
		object obj23 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			object obj10 = type2 + 16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v33 (Il2CppClass<System.Type>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v74 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj = typeof(JsonContext);
			((IntPtr*)num)->m_value = (void*)(nint)obj;
			Type type3 = Type.internal_from_handle((IntPtr)num);
			if (obj14 == type3)
			{
				object obj15 = this + 24;
				obj15 = obj12;
			}
			nint num4 = (nint)typeof(JsonClassInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v38 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num5 = (nint)typeof(JsonClassInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v75 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1B0");
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj18 = enumerable + 8;
				obj18 = obj12;
				nint num6 = (nint)typeof(JsonClassInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v52 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+BA]");
				object obj19 = (nint)0 & (nint)0x200;
				if (obj19 != null)
				{
					nint num7 = (nint)typeof(JsonClassInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v71 (Il2CppClass<SYBO.Components.Json.JsonClassInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj20 = enumerable + 12;
				JsonContext jsonContext = ((JsonContext)obj12).Duplicate();
				obj20 = jsonContext;
				bool flag = obj2 != null;
				bool flag2 = obj4 != null;
				object obj21 = enumerable + 20;
				obj21 = obj7;
				bool flag3 = obj6 != null;
				if (obj3 != null)
				{
					object obj22 = this + 20;
					obj22 = obj12;
				}
				((List<T>)(object)list).AddRange((IEnumerable<T>)enumerable);
			}
			obj9 = obj23 + 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		bool result = default;
		return result;
	}

	public unsafe JsonDict Serialize(Type type, object obj, JsonContext context)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0095: Expected I, but got Obj
		//IL_00ab: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected VT, but got Unknown
		//IL_00e3: Expected F4, but got Obj
		//IL_00de: Expected native int or pointer, but got VT
		//IL_00f8: Expected F4, but got I
		//IL_00f3: Expected native int or pointer, but got VT
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected VT, but got Unknown
		//IL_0113: Expected F4, but got Obj
		//IL_010e: Expected native int or pointer, but got VT
		//IL_0128: Expected F4, but got I
		//IL_0123: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		object obj3 = default;
		object obj2 = obj3 + 16;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ L2 (System.Object)+8]");
		_ = 0;
		obj3 = context;
		_ = context.ObjectStore;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj3 + 28);
		((Vector3*)(nint)vector)->x = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Quaternion quaternion = (Quaternion)(obj3 + 40);
		((Quaternion*)(nint)quaternion)->x = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		return (JsonDict)(object)UnityEngine.Object.Instantiate((GameObject)(object)type, vector, quaternion);
	}

	public object Deserialize(Type type, JsonDict json, JsonContext context)
	{
		JsonCustomSerializer jsonCustomSerializer = _customSerializers.get_Item(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		object result = default;
		return result;
	}

	public JsonList SerializeList(Type type, object obj, JsonContext context)
	{
		JsonCustomSerializer jsonCustomSerializer = _customSerializers.get_Item(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		JsonList result = default;
		return result;
	}

	public object DeserializeList(Type type, JsonList json, JsonContext context)
	{
		JsonCustomSerializer jsonCustomSerializer = _customSerializers.get_Item(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		object result = default;
		return result;
	}

	public void AddSerializer(Type type, JsonCustomSerializer serializer)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonCustomSerializerCollection)+10]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			obj = type;
			object obj3 = obj2 + 12;
			obj3 = serializer;
			object obj4 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonCustomSerializerCollection)+28]");
			obj4 = 0;
			object obj5 = this + 40;
			obj5 = obj2;
		}
	}

	public JsonCustomSerializerCollection Duplicate()
	{
		//IL_0026: Expected Obj, but got I4
		Dictionary<Type, JsonCustomSerializer> customSerializers = _customSerializers;
		return (JsonCustomSerializerCollection)(customSerializers.count - customSerializers.freeCount);
	}
}
