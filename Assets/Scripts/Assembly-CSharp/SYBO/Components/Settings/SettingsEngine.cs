using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Settings;

public static class SettingsEngine
{
	private static bool loaded = false;

	private static readonly string RootResourceName = "SyboSettings";

	private static readonly string ResourcesLoadPath = "Settings/{0}";

	private static Dictionary<Type, FieldInfo[]> _cachedSerializedFields;

	private static Dictionary<Type, FieldInfo[]> _cachedSerializedReleaseFields;

	public static void Reload()
	{
		loaded = false;
		Load();
	}

	public static void Load()
	{
		//IL_00b1: Expected VT, but got Obj
		if (~(loaded ? 1u : 0u) != 0)
		{
			loaded = true;
			string path = string.Format(ResourcesLoadPath, RootResourceName);
			TextAsset textAsset = Resources.Load<TextAsset>(path);
			JsonDict json;
			if (textAsset != null)
			{
				string text = textAsset.text;
				JsonDict jsonDict = JsonDict.Deserialize(text);
				json = jsonDict;
			}
			else
			{
				JsonDict jsonDict2 = default;
				jsonDict2._002Ector();
				json = jsonDict2;
			}
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(StaticSettings));
			Load(typeFromHandle, json);
		}
	}

	public static void Save()
	{
	}

	public static void Backup()
	{
	}

	public static void Restore()
	{
	}

	public unsafe static FieldInfo[] GetAllSerializedFields(Type settingsType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0138: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Ref, but got Unknown
		//IL_01bd: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		RuntimeSettings runtime = StaticSettings.Runtime;
		nint num = (nint)typeof(SettingsEngine);
		object obj3 = 16;
		if (!runtime.IsFinalBuild)
		{
			obj3 = 12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v18 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+5C]");
		object obj4 = 0 + obj3;
		if (!((Dictionary<Type, FieldInfo[]>)obj4).TryGetValue(settingsType, out *(FieldInfo[]*)(obj + 12)))
		{
			nint num2 = (nint)settingsType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v6 (Il2CppClass<System.Type>)+374] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v31+C]");
			List<FieldInfo> list = default;
			list._002Ector(0);
			object obj5 = 0;
			object obj8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v31+C]");
				if (0 <= (nint)obj5)
				{
					break;
				}
				object obj6 = obj5 << 2;
				object obj7 = obj8 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44+10]");
				if (ShouldSerializeField((FieldInfo)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44+10]");
					list.Add((FieldInfo)0);
				}
				object obj9 = obj5 + 1;
				obj5 = obj9;
			}
			FieldInfo[] array = list.ToArray();
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Reflection.FieldInfo[]>>)+5C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (FieldInfo[])0;
	}

	public unsafe static FieldInfo[] GetAllSerializedFieldsStatic(Type settingsType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0138: Expected I, but got Obj
		//IL_0141: Expected Obj, but got I4
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Ref, but got Unknown
		//IL_01bd: Expected Obj, but got I
		//IL_001c: Expected Obj, but got I4
		//IL_0029: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I4
		//IL_010c: Expected Obj, but got I
		//IL_0087: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		RuntimeSettings runtime = StaticSettings.Runtime;
		nint num = (nint)typeof(SettingsEngine);
		object obj3 = 16;
		if (!runtime.IsFinalBuild)
		{
			obj3 = 12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v18 (Il2CppClass<SYBO.Components.Settings.SettingsEngine>)+5C]");
		object obj4 = 0 + obj3;
		if (!((Dictionary<Type, FieldInfo[]>)obj4).TryGetValue(settingsType, out *(FieldInfo[]*)(obj + 12)))
		{
			nint num2 = (nint)settingsType;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v56 @ S2_v6 (Il2CppClass<System.Type>)+374] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v31+C]");
			List<FieldInfo> list = default;
			list._002Ector(0);
			object obj5 = 0;
			object obj8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v31+C]");
				if (0 <= (nint)obj5)
				{
					break;
				}
				object obj6 = obj5 << 2;
				object obj7 = obj8 + obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44+10]");
				if (ShouldSerializeField((FieldInfo)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v44+10]");
					list.Add((FieldInfo)0);
				}
				object obj9 = obj5 + 1;
				obj5 = obj9;
			}
			FieldInfo[] array = list.ToArray();
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Reflection.FieldInfo[]>>)+5C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ S5_v5+4] (should have been resolved before IL gen)");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		return (FieldInfo[])0;
	}

	private static void Load(Type settingsType, JsonDict json)
	{
		//IL_002e: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		JsonDict jsonDict = default;
		JsonDict jsonDict2 = default;
		if (jsonDict == null)
		{
			jsonDict2._002Ector();
		}
		FieldInfo[] allSerializedFieldsStatic = GetAllSerializedFieldsStatic(settingsType);
		object obj = 0;
		while (allSerializedFieldsStatic.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)allSerializedFieldsStatic + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v18+10]");
			RecursiveReadField(null, (FieldInfo)0, jsonDict2);
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	private static void RecursiveReadField(object obj, FieldInfo field, JsonDict json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0ff8: Expected I, but got Obj
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1010: Expected Obj, but got Unknown
		//IL_1036: Expected Obj, but got I
		//IL_1049: Unknown result type (might be due to invalid IL or missing references)
		//IL_104e: Expected Obj, but got Unknown
		//IL_0061: Expected VT, but got Obj
		//IL_0022: Expected VT, but got Obj
		//IL_0106: Expected VT, but got Obj
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_108c: Expected I, but got Obj
		//IL_01ab: Expected VT, but got Obj
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected Obj, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_0c2d: Expected I, but got Obj
		//IL_0250: Expected VT, but got Obj
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_0205: Expected I8, but got I4
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0c76: Expected VT, but got Obj
		//IL_02f5: Expected VT, but got Obj
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_039a: Expected VT, but got Obj
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_1144: Expected I, but got Obj
		//IL_112f: Expected Obj, but got I
		//IL_0443: Expected VT, but got Obj
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_04e8: Expected VT, but got Obj
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected Obj, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_0570: Expected VT, but got Obj
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Expected Obj, but got Unknown
		//IL_05f9: Expected VT, but got Obj
		//IL_05a8: Expected I, but got Obj
		//IL_0675: Expected I, but got Obj
		//IL_0d40: Expected I, but got Obj
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected Obj, but got Unknown
		//IL_0ed6: Expected I, but got Obj
		//IL_06a4: Expected I, but got Obj
		//IL_06bd: Expected VT, but got Obj
		//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d75: Expected Obj, but got Unknown
		//IL_0d98: Expected I, but got Obj
		//IL_0fca: Expected I, but got Obj
		//IL_0f10: Expected I, but got Obj
		//IL_06ed: Expected I, but got Obj
		//IL_0f5f: Expected I, but got Obj
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_07ae: Expected I, but got Obj
		//IL_07c9: Expected Obj, but got I
		//IL_0de7: Expected I, but got Obj
		//IL_07da: Expected I, but got Obj
		//IL_07f3: Expected VT, but got Obj
		//IL_0746: Expected I, but got Obj
		//IL_0e30: Expected I, but got Obj
		//IL_0e49: Expected VT, but got Obj
		//IL_0b68: Expected I, but got Obj
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected Obj, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected Obj, but got Unknown
		//IL_0e7f: Expected I, but got Obj
		//IL_10d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Expected Obj, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Expected Obj, but got Unknown
		//IL_08b4: Expected Obj, but got I
		//IL_0a5b: Expected Obj, but got I
		//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb7: Expected Obj, but got Unknown
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected Obj, but got Unknown
		object obj3 = default;
		object obj2 = obj3 - 48;
		_ = 0;
		_ = 0;
		FieldInfo fieldInfo = default;
		nint num = (nint)fieldInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v22 @ S1_v6 (Il2CppClass<System.Reflection.FieldInfo>)+144] (should have been resolved before IL gen)");
		object obj4 = fieldInfo - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v5+BC] (should have been resolved before IL gen)");
		nint num2 = 0;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Object>>)+54]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S3_v7+4] (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 ^ -1;
		object obj8 = obj6 >> 31;
		if (obj8 == null)
		{
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SerializeFileAttribute));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5435");
			object obj9 = default;
			if (obj9 == null)
			{
				goto IL_1084;
			}
		}
		Type typeFromHandle2 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(int));
		Type type = default;
		JsonDict jsonDict = default;
		object obj12 = default;
		if ((object)typeFromHandle2 == type)
		{
			object obj10 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v96 @ S3_v127+BC] (should have been resolved before IL gen)");
			string name = default;
			int num4 = jsonDict.GetInt(name);
			object obj11 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value = default;
			fieldInfo.SetValue(obj12, value);
			return;
		}
		Type typeFromHandle3 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(byte));
		if ((object)typeFromHandle3 == type)
		{
			object obj13 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v386 @ S3_v119+BC] (should have been resolved before IL gen)");
			string name2 = default;
			int num5 = jsonDict.GetInt(name2);
			object obj14 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value2 = default;
			fieldInfo.SetValue(obj12, value2);
			return;
		}
		Type typeFromHandle4 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(long));
		if ((object)typeFromHandle4 == type)
		{
			object obj15 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ S3_v111+BC] (should have been resolved before IL gen)");
			string name3 = default;
			long @int = jsonDict.GetInt64(name3, 0L);
			object obj16 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value3 = default;
			fieldInfo.SetValue(obj12, value3);
			return;
		}
		Type typeFromHandle5 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(short));
		if ((object)typeFromHandle5 == type)
		{
			object obj17 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v480 @ S3_v103+BC] (should have been resolved before IL gen)");
			string name4 = default;
			int num6 = jsonDict.GetInt(name4);
			object obj18 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value4 = default;
			fieldInfo.SetValue(obj12, value4);
			return;
		}
		Type typeFromHandle6 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(float));
		if ((object)typeFromHandle6 == type)
		{
			object obj19 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v529 @ S3_v95+BC] (should have been resolved before IL gen)");
			string name5 = default;
			float num7 = jsonDict.GetFloat(name5);
			object obj20 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value5 = default;
			fieldInfo.SetValue(obj12, value5);
			return;
		}
		Type typeFromHandle7 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(double));
		if ((object)typeFromHandle7 == type)
		{
			object obj21 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v559 @ S3_v87+BC] (should have been resolved before IL gen)");
			string name6 = default;
			double num8 = jsonDict.GetDouble(name6);
			object obj22 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value6 = default;
			fieldInfo.SetValue(obj12, value6);
			return;
		}
		Type typeFromHandle8 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(bool));
		if ((object)typeFromHandle8 == type)
		{
			object obj23 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v589 @ S3_v79+BC] (should have been resolved before IL gen)");
			string name7 = default;
			bool flag = jsonDict.GetBool(name7);
			object obj24 = obj2 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object value7 = default;
			fieldInfo.SetValue(obj12, value7);
			return;
		}
		Type typeFromHandle9 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
		if ((object)typeFromHandle9 == type)
		{
			object obj25 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ S4_v28+BC] (should have been resolved before IL gen)");
			string name8 = default;
			string value8 = jsonDict.GetString(name8, string.Empty);
			fieldInfo.SetValue(obj12, value8);
			return;
		}
		Type typeFromHandle10 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Type));
		if ((object)typeFromHandle10 == type)
		{
			nint num9 = (nint)fieldInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ S2_v137 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @235");
			JsonDict typeJson = GetTypeJson(fieldInfo, jsonDict);
			Type objType = default;
			RecursiveReadObject(null, objType, typeJson);
			return;
		}
		Type typeFromHandle11 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(JsonDict));
		if ((object)typeFromHandle11 == type)
		{
			object obj26 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v671 @ S4_v22+BC] (should have been resolved before IL gen)");
			string name9 = default;
			JsonDict dict = jsonDict.GetDict(name9);
			fieldInfo.SetValue(obj12, dict);
			return;
		}
		nint num10 = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v677 @ S1_v44 (Il2CppClass<System.Type>)+1FC] (should have been resolved before IL gen)");
		object obj27 = default;
		if (obj27 != null)
		{
			nint num11 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v687 @ S1_v95 (Il2CppClass<System.Type>)+23C] (should have been resolved before IL gen)");
			Type typeFromHandle12 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Dictionary<, >));
			object obj28 = default;
			if (typeFromHandle12 == obj28)
			{
				nint num12 = (nint)fieldInfo;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v771 @ S2_v96 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
				object obj29 = default;
				bool flag2 = obj29 == null;
				bool flag3 = !flag2;
				object obj30 = obj29;
				if (!flag3)
				{
					ConstructorInfo constructor = ReflectionWrapper.GetConstructor(type);
					nint num13 = (nint)constructor;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v889 @ S7_v14 (Il2CppClass<System.Reflection.ConstructorInfo>)+1FC] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
					object obj31 = default;
					fieldInfo.SetValue(obj12, obj31);
					obj30 = obj31;
				}
				object obj32 = fieldInfo - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v873 @ S2_v101+BC] (should have been resolved before IL gen)");
				string name10 = default;
				JsonDict dict2 = jsonDict.GetDict(name10);
				nint num14 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v897 @ S1_v106 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ S0_v182+14]");
				ConstructorInfo constructor2 = ReflectionWrapper.GetConstructor((Type)0);
				nint num15 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v926 @ S1_v110 (Il2CppClass<System.Type>)+24C] (should have been resolved before IL gen)");
				Type typeFromHandle13 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ S0_v186+10]");
				if ((object)typeFromHandle13 == null)
				{
					object obj33 = obj2 + 16;
					Dictionary<string, object>.KeyCollection keys = dict2.Keys;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @961");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
					_ = 0;
					object obj34 = obj2 + 32;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					object obj36 = default;
					JsonDict jsonDict2 = default;
					object obj37 = default;
					object obj38 = default;
					FieldInfo fieldInfo2 = default;
					FieldInfo fieldInfo3 = default;
					while (true)
					{
						_ = 0;
						object obj35 = obj2 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							jsonDict = (JsonDict)0;
						}
						else
						{
							if (obj36 == null)
							{
								goto IL_10a5;
							}
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													continue;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												jsonDict = jsonDict2;
												goto IL_0aa5;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									jsonDict = jsonDict2;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									jsonDict = jsonDict2;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								jsonDict = (JsonDict)0;
							}
						}
						goto IL_0aa5;
						IL_0aa5:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						bool flag4 = obj37 != obj38;
						fieldInfo = fieldInfo2;
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
							fieldInfo = fieldInfo3;
						}
						_ = 0;
						object obj39 = obj2 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							goto IL_0bfc;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						goto IL_10a5;
						IL_10a5:
						object obj40 = obj2 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5448");
						return;
					}
					object obj41 = obj2 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5448");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				nint num16 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1033 @ S2_v110 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
				throw new ArrayTypeMismatchException();
			}
		}
		nint num17 = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v707 @ S1_v48 (Il2CppClass<System.Type>)+1BC] (should have been resolved before IL gen)");
		object obj42 = default;
		if (obj42 != null)
		{
			object obj43 = fieldInfo - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v723 @ S2_v70+BC] (should have been resolved before IL gen)");
			string name11 = default;
			JsonList list = jsonDict.GetList(name11);
			nint num18 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v742 @ S1_v64 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v132 (SYBO.Components.Json.JsonList)+C]");
			Type elementType = default;
			Array array = Array.CreateInstance(elementType, 0);
			int num19 = 0;
			object obj46 = default;
			object obj47 = default;
			object obj48 = default;
			Type objType2 = default;
			JsonDict json2 = default;
			while (true)
			{
				int num20 = num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ S0_v132 (SYBO.Components.Json.JsonList)+C]");
				if ((nint)num20 >= (nint)0)
				{
					break;
				}
				object obj44 = ((List<object>)list).get_Item(num19);
				nint num21 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v909 @ S1_v76 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
				object obj45 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v917 @ S1_v79+1CC] (should have been resolved before IL gen)");
				bool flag5 = obj47 == null;
				object value9 = obj44;
				if (!flag5)
				{
					nint num22 = (nint)type;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v941 @ S1_v85 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
					Type typeFromHandle14 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
					bool flag6 = typeFromHandle14 == obj48;
					value9 = obj44;
					if (!flag6)
					{
						nint num23 = (nint)type;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v999 @ S1_v90 (Il2CppClass<System.Type>)+22C] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
						object obj49 = JsonApi.ReflectionDeserializeDomAsType(objType2, json2);
						value9 = obj49;
					}
				}
				array.SetValue(value9, num19);
				int num24 = num19 + 1;
				num19 = num24;
			}
			fieldInfo.SetValue(obj12, array);
		}
		else
		{
			nint num25 = (nint)type;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v733 @ S1_v51 (Il2CppClass<System.Type>)+31C] (should have been resolved before IL gen)");
			object obj50 = default;
			if (obj50 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				nint num26 = (nint)type;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v842 @ S2_v57 (Il2CppClass<System.Type>)+18C] (should have been resolved before IL gen)");
				throw new ArrayTypeMismatchException();
			}
			nint num27 = (nint)fieldInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v757 @ S2_v60 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
			object obj51 = default;
			bool flag7 = obj51 == null;
			bool flag8 = !flag7;
			object obj52 = obj51;
			if (!flag8)
			{
				ConstructorInfo constructor3 = ReflectionWrapper.GetConstructor(type);
				nint num28 = (nint)constructor3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v836 @ S7_v10 (Il2CppClass<System.Reflection.ConstructorInfo>)+1FC] (should have been resolved before IL gen)");
				object obj53 = default;
				fieldInfo.SetValue(obj12, obj53);
				obj52 = obj53;
			}
			JsonDict typeJson2 = GetTypeJson(fieldInfo, jsonDict);
			RecursiveReadObject(obj52, type, typeJson2);
		}
		return;
		IL_1084:
		nint num29 = (nint)type;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S1_v16 (Il2CppClass<System.Type>)+31C] (should have been resolved before IL gen)");
		object obj54 = default;
		if (obj54 != null)
		{
			return;
		}
		nint num30 = (nint)fieldInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v180 @ S2_v17 (Il2CppClass<System.Reflection.FieldInfo>)+184] (should have been resolved before IL gen)");
		object obj55 = default;
		bool flag9 = obj55 == null;
		bool flag10 = !flag9;
		object obj56 = obj55;
		if (!flag10)
		{
			Type typeFromHandle15 = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(string));
			object empty = default;
			if ((object)typeFromHandle15 == type)
			{
				empty = string.Empty;
			}
			else
			{
				ConstructorInfo constructor4 = ReflectionWrapper.GetConstructor(type);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3");
				object obj57 = default;
				if (obj57 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					throw new ArrayTypeMismatchException();
				}
				nint num31 = (nint)constructor4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v502 @ S7_v6 (Il2CppClass<System.Reflection.ConstructorInfo>)+1FC] (should have been resolved before IL gen)");
			}
			FieldInfo fieldInfo4 = fieldInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			fieldInfo4.SetValue(0, empty);
			obj56 = empty;
		}
		JsonDict typeJson3 = GetTypeJson(fieldInfo, jsonDict);
		RecursiveReadObject(obj56, type, typeJson3);
		return;
		IL_0bfc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_1084;
	}

	private static string GetFilePath(FieldInfo field)
	{
		//IL_003d: Expected VT, but got Obj
		//IL_0049: Expected I, but got Obj
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(SerializeFileAttribute));
		nint num = (nint)field;
		object obj = field + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S3_v2 (Il2CppClass<System.Reflection.FieldInfo>)+12C] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10+C]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17+8]");
			return (string)0;
		}
		return null;
	}

	private static JsonDict GetTypeJson(FieldInfo field, JsonDict json)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		string filePath = GetFilePath(field);
		if (filePath != null)
		{
			string path = string.Format(ResourcesLoadPath, filePath);
			TextAsset textAsset = Resources.Load<TextAsset>(path);
			if (textAsset != null)
			{
				string text = textAsset.text;
				return JsonDict.Deserialize(text);
			}
		}
		object obj = field - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S2_v4+BC] (should have been resolved before IL gen)");
		string name = default;
		return json.GetDict(name);
	}

	private static void RecursiveReadObject(object obj, Type objType, JsonDict json)
	{
		//IL_0070: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		FieldInfo[] allSerializedFields = GetAllSerializedFields(objType);
		object obj2 = 0;
		while (allSerializedFields.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)allSerializedFields + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v15+10]");
			RecursiveReadField(obj, (FieldInfo)0, json);
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
	}

	private static bool ShouldSerializeField(FieldInfo field)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_038a: Expected I, but got Obj
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03b9: Expected I, but got Obj
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected I4, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_014f: Expected Obj, but got I4
		//IL_036d: Expected Obj, but got I
		//IL_0421: Expected Obj, but got I4
		//IL_0439: Expected Obj, but got I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected I4, but got Unknown
		//IL_0192: Expected Obj, but got I4
		//IL_01cc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 32;
		nint num = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v4 (Il2CppClass<System.Reflection.FieldInfo>)+13C] (should have been resolved before IL gen)");
		object obj4 = default;
		object obj3 = obj4 & 7;
		bool flag = (nint)obj3 == 6;
		nint num2 = (nint)field;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v32 @ S2_v4 (Il2CppClass<System.Reflection.FieldInfo>)+124] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
		object obj5 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		bool flag2 = flag;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj12 = default;
		object obj13 = default;
		bool flag12;
		bool flag13 = default;
		object obj14;
		bool flag15 = default;
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
				if (obj6 == null)
				{
					goto IL_01ef;
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
						if (obj7 != null)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								goto IL_0221;
							}
							RuntimeSettings runtime = StaticSettings.Runtime;
							if (runtime.IsFinalBuild)
							{
								goto IL_01ef;
							}
						}
						bool flag3 = obj8 == null;
						object obj9 = 0;
						if (!flag3)
						{
							bool flag4 = obj8 == typeof(NonSerializedAttribute);
							obj9 = obj8;
							if (!flag4)
							{
								obj9 = 0;
							}
						}
						bool flag5 = obj9 == null;
						object obj10 = flag2 & flag5;
						bool flag6 = obj8 == null;
						object obj11 = 0;
						if (!flag6)
						{
							bool flag7 = obj8 == typeof(SerializeField);
							obj11 = obj8;
							if (!flag7)
							{
								obj11 = 0;
							}
						}
						bool flag8 = obj11 != null;
						bool flag9 = (byte)((obj10 | flag8) ? 1 : 0) != 0;
						flag2 = flag9;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			goto IL_0221;
			IL_0221:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag10 = obj12 == obj13;
			bool flag11 = !flag10;
			flag12 = flag13;
			if (!flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag14 = (nint)0 != 1;
				flag12 = true;
				obj14 = obj;
				if (flag14)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				flag12 = flag15;
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj14 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return flag12;
			IL_01ef:
			bool flag16 = (byte)(obj6 ^ 1) != 0;
			flag12 = flag16;
			obj14 = obj;
			break;
		}
		object obj16 = obj14 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return flag12 & flag2;
	}

	static SettingsEngine()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v50 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Reflection.FieldInfo[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, FieldInfo[]> cachedSerializedFields = default;
		_cachedSerializedFields = cachedSerializedFields;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Type, System.Reflection.FieldInfo[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<Type, FieldInfo[]> cachedSerializedReleaseFields = default;
		_cachedSerializedReleaseFields = cachedSerializedReleaseFields;
	}
}
