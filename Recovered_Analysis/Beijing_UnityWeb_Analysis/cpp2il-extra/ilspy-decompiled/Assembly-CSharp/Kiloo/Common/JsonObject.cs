using System;
using System.Collections;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.Utility;
using Kiloo.Serialization;
using UnityEngine;

namespace Kiloo.Common;

public class JsonObject
{
	private readonly IDictionary _json;

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(string key)
	{
		return null;
	}

	public void set_Item(string key, object value)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = key;
		object obj2 = this + 12;
		obj2 = value;
	}

	public JsonObject(object json = null)
	{
	}

	public static JsonObject Deserialize(string json)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00bc: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected Obj, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		object obj2 = default;
		object obj = obj2 + 16;
		DateTime today = CDateTime.Today;
		obj = today;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBC");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v30 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		object obj5 = default;
		obj4 = obj5;
		object obj6 = default;
		obj2 = obj6;
		object obj7 = obj2 + 24;
		obj7 = obj4;
		object obj8 = obj2 + 32;
		obj8 = obj2;
		object obj9 = obj7 & 0x3FFFFFFFFFFFFFFFL;
		object obj10 = obj8 & 0x3FFFFFFFFFFFFFFFL;
		bool flag = obj9 == obj10;
		return (JsonObject)flag;
	}

	public string Serialize()
	{
		string key = KilooJson.Serialize(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonObject jsonObject = default;
		jsonObject.Remove(key);
		return (string)(object)jsonObject;
	}

	public void Remove(string key)
	{
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj = default;
		if (obj != null)
		{
			object obj2 = this + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v6+8]");
			obj2 = 0;
			return;
		}
		object obj3;
		if (key != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj4 = default;
			obj3 = obj4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S3_v4 (Il2CppMethodInfo)+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S3_v5+60]");
			object obj6 = 0;
			object obj7 = obj6;
			object obj8 = obj7 & 0x1FFF;
			object obj9 = obj8 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S4_v6 (should have been resolved before IL gen)");
			object obj10 = default;
			obj3 = obj10;
		}
		object obj11 = this + 8;
		obj11 = obj3;
	}

	public T Get<T>(string key, IFormatProvider provider = null)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0018: Expected VT, but got Obj
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (T)obj;
	}

	public T Get<T>(string key, T defaultValue, IFormatProvider provider = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0050: Expected I4, but got Obj
		//IL_0050: Expected I, but got Obj
		//IL_0054: Expected VT, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x3FFF;
		object obj4 = obj3 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S4_v4 (should have been resolved before IL gen)");
		string signature = default;
		return (T)(nint)UnityEngine.AndroidReflection.GetMethodMember((IntPtr)this, key, signature, (byte)(int)provider != 0);
	}

	public bool TryGet<T>(string key, out T result, IFormatProvider provider = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S5_v4 (should have been resolved before IL gen)");
		bool result2 = default;
		return result2;
	}

	public static T Get<T>(object jsonObject, string key, IFormatProvider provider = null)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		bool flag = HasKey(jsonObject, key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18 @ S3_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static T Get<T>(object jsonObject, string key, T defaultValue, IFormatProvider provider = null)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0019: Expected Obj, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_006c: Expected VT, but got Obj
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S5_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if (obj6 != null)
		{
			return (T)obj;
		}
		return defaultValue;
	}

	public unsafe static bool TryGet<T>(object jsonObject, string key, out T result, IFormatProvider provider = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0078: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L4 (Il2CppMethodInfo)+18]");
				object obj5 = 0;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1DC");
				object obj8 = default;
				object obj7 = obj8 << 32;
				object obj10 = default;
				object obj9 = obj10 | obj7;
				ref T reference = ref *(T*)obj9;
				goto IL_0190;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		goto IL_0190;
		IL_0190:
		return true;
	}

	public unsafe static T ConvertValue<T>(object json, IFormatProvider provider = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected Obj, but got Unknown
		//IL_07d0: Expected Obj, but got I4
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07de: Expected Obj, but got Unknown
		//IL_07ff: Expected Obj, but got I4
		//IL_080d: Expected I, but got Obj
		//IL_0823: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0897: Expected I4, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected I, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected Obj, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected Obj, but got Unknown
		//IL_013d: Expected I, but got Obj
		//IL_086a: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_09b3: Expected VT, but got Obj
		//IL_01f7: Expected Obj, but got I
		//IL_020d: Expected I, but got Obj
		//IL_0223: Expected Obj, but got I
		//IL_08d9: Expected I, but got Obj
		//IL_024e: Expected I, but got Obj
		//IL_02cb: Expected Obj, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_031f: Expected Obj, but got I4
		//IL_0363: Expected I, but got Obj
		//IL_0379: Expected Obj, but got I
		//IL_0952: Expected I, but got Obj
		//IL_03a4: Expected I, but got Obj
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 24;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj5 = 0;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v19 (Il2CppClass<Globals>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v322 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag;
		if (~(Globals.DEBUG_USE_EVENT_TESTER ? 1u : 0u) == 0)
		{
			nint num3 = (nint)typeof(EventTesterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v311 (Il2CppClass<EventTesterManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(EventTesterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v318 (Il2CppClass<EventTesterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInitialized = EventTesterManager.isInitialized;
			SSEventCategory eventCategory = ((EventTesterManager)isInitialized).GetEventCategory();
			flag = (byte)eventCategory != 0;
		}
		else
		{
			nint num5 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v299 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num6 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v306 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			flag = ((OnlineSettings)(object)saveDataPath).GetValue("event_value", (byte)(int)string.Empty != 0);
		}
		nint num7 = (nint)(obj2 + 28);
		object obj9 = obj2 + 20;
		object obj10 = obj2 + 16;
		bool flag2;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v26 (System.Boolean)+8]");
			flag2 = (nint)0 == 0;
		}
		else
		{
			flag2 = true;
		}
		if (!flag2)
		{
			nint num8 = default;
			object obj11 = num8 + 24;
			object obj12 = obj11;
			nint num9 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v44 (Il2CppClass<System.Type>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num10 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v290 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj9 = obj12;
			((IntPtr*)num7)->m_value = (void*)(nint)obj9;
			Type type = Type.internal_from_handle((IntPtr)num7);
			if (type.IsSzArray)
			{
				object obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				object obj15 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S0_v141+8]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj18 = default;
				object obj17 = obj18 + 16;
				obj17 = 59;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				object obj19 = obj11;
				nint num11 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v164 (Il2CppClass<System.Type>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num12 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ S0_v274 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj10 = obj19;
				((IntPtr*)num7)->m_value = (void*)(nint)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj22 = default;
				object obj21 = obj22 + 8;
				object obj23 = default;
				obj21 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj25 = default;
				object obj24 = obj25;
				object obj27 = default;
				object obj26 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj28 = default;
				if (obj26 == obj28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj30 = default;
					object obj29 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj32 = default;
					object obj31 = obj32;
				}
				else
				{
					object obj31 = obj24;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
		}
		return (T)obj3;
	}

	public static bool HasKey(object jsonObject, string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		bool result = default;
		return result;
	}

	public bool HasKey(string key)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			bool result = default;
			return result;
		}
		return false;
	}

	public bool CanSerialize()
	{
		//IL_0010: Expected I4, but got Obj
		return (byte)(int)((KilooSerializer)_json).ToJson((object)null) != 0;
	}

	public static bool CanSerialize(object value)
	{
		//IL_0011: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L0 (System.Object)+8]");
		return (byte)((ActionQueue)0).Count != 0;
	}
}
