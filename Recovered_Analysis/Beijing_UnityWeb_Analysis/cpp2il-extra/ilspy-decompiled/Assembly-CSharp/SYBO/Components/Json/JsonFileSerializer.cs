using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonFileSerializer
{
	public delegate string GetFileTextDelegate(string filename);

	public delegate void WriteFileTextDelegate(string filename, string text);

	private GetFileTextDelegate _getFileText;

	private WriteFileTextDelegate _writeFileText;

	public JsonFileSerializer(GetFileTextDelegate getFileText, WriteFileTextDelegate writeFileText)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v4 (should have been resolved before IL gen)");
	}

	public void SerializeToMultipleFiles(Type type, object obj, string filename, JsonContext context = null)
	{
		//IL_0333: Expected Obj, but got I
		//IL_0232: Expected I, but got Obj
		//IL_0248: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I
		//IL_001a: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_0273: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_006d: Expected I, but got Obj
		//IL_02f0: Expected I, but got Obj
		//IL_0306: Expected Obj, but got I
		//IL_03c6: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		//IL_03f3: Expected VT, but got I
		int num = 0;
		Type type2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+38]");
			object obj2 = 0;
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v4+C]");
			if ((nint)num2 < (nint)0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+38]");
				PrefabPool prefabPool = ((List<PrefabPool>)0).get_Item(num);
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (prefabPool.prefabGO == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+38]");
					PrefabPool prefabPool2 = ((List<PrefabPool>)0).get_Item(num);
					UnityEngine.Object obj4 = UnityEngine.Object.Instantiate((UnityEngine.Object)prefabPool2.prefabGO);
					if ((string)(object)obj4 == (string)obj)
					{
						int num5 = num + 1;
						num = num5;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+38]");
					PrefabPool prefabPool3 = ((List<PrefabPool>)0).get_Item(num);
					((PrefabsDict)(object)prefabPool3)._Add((string)(object)type, (Transform)(object)filename);
					if (context != null)
					{
						if ((object)type == null)
						{
							type2 = null;
						}
						else
						{
							type2 = (((object)((object)type).GetType() != typeof(RectTransform)) ? null : type);
						}
						break;
					}
					return;
				}
				nint num6 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v32 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num7 = (nint)typeof(Log);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v39 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string tag = ((Component)this).tag;
				PoolManagerLogCategory poolManager = Log.PoolManager;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+14]");
				poolManager.LogErrorFormat((UnityEngine.Object)(object)tag, (Enum)0, "Unexpected Error: PrefabPool.prefabGO is null");
				return;
			}
			nint num8 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v13 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(Log);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v20 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string tag2 = ((Component)this).tag;
			PoolManagerLogCategory poolManager2 = Log.PoolManager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+14]");
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+18]");
			poolManager2.LogErrorFormat((UnityEngine.Object)(object)tag2, (Enum)num10, "SpawnPool {0}: PrefabPool {1} not found.", 0, obj);
			return;
		}
		bool relativeTo = (object)type2 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonFileSerializer)+2C]");
		((Transform)(object)type).Translate((Vector3)0, relativeTo ? Space.Self : Space.World);
	}

	public object DeserializeFromMultipleFiles(Type type, string filename, JsonContext context = null)
	{
		JsonCustomSerializer jsonCustomSerializer = ((Dictionary<Type, JsonCustomSerializer>)(object)_getFileText).get_Item(type);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @726B");
		object result = default;
		return result;
	}

	private void SerializeToFile(Type type, object obj, string filename, JsonContext context)
	{
		//IL_0050: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I
		bool flag = context == null;
		bool flag2 = !flag;
		JsonCustomSerializer arg = (JsonCustomSerializer)(object)context;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer = default;
			jsonCustomSerializer._002Ector();
			arg = jsonCustomSerializer;
		}
		((LogCategory)this).LogFormat((string)(object)type, obj, (object)filename, (object)arg);
		string format = default;
		object arg2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L4_v1 (SYBO.Components.Json.JsonCustomSerializer)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v13+C]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L4_v1 (SYBO.Components.Json.JsonCustomSerializer)+18]");
				JsonContext.SubtreeFileReference subtreeFileReference = ((List<JsonContext.SubtreeFileReference>)0).get_Item(0);
				JsonFieldInfo field = subtreeFileReference.Field;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				JsonFieldInfo field2 = subtreeFileReference.Field;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
				((LogCategory)this).LogFormat(format, arg2, (object)subtreeFileReference.Filename, (object)arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L4_v1 (SYBO.Components.Json.JsonCustomSerializer)+18]");
				bool flag3 = ((List<JsonContext.SubtreeFileReference>)0).Remove(subtreeFileReference);
				continue;
			}
			break;
		}
	}

	private object DeserializeFromFile(Type type, string filename, JsonContext context)
	{
		//IL_0050: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I
		//IL_00fc: Expected VT, but got Obj
		//IL_0116: Expected Obj, but got I
		bool flag = context == null;
		bool flag2 = !flag;
		JsonCustomSerializer context2 = (JsonCustomSerializer)(object)context;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			JsonCustomSerializer jsonCustomSerializer = default;
			jsonCustomSerializer._002Ector();
			context2 = jsonCustomSerializer;
		}
		object result = JsonReflectionParser.RecursiveWriteValue((object)this, type, (JsonFieldInfo)(object)filename, (JsonContext)(object)context2);
		Type ft = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L3_v1 (SYBO.Components.Json.JsonCustomSerializer)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v8+C]");
			if ((nint)0 < (nint)1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L3_v1 (SYBO.Components.Json.JsonCustomSerializer)+18]");
			JsonContext.SubtreeFileReference subtreeFileReference = ((List<JsonContext.SubtreeFileReference>)0).get_Item(0);
			JsonFieldInfo field = subtreeFileReference.Field;
			JsonFieldInfo field2 = subtreeFileReference.Field;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object value = JsonReflectionParser.RecursiveWriteValue((object)this, ft, (JsonFieldInfo)(object)subtreeFileReference.Filename, (JsonContext)(object)context2);
			field.Field.SetValueDirect((TypedReference)subtreeFileReference.SubObject, value);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ L3_v1 (SYBO.Components.Json.JsonCustomSerializer)+18]");
			bool flag3 = ((List<JsonContext.SubtreeFileReference>)0).Remove(subtreeFileReference);
		}
		return result;
	}
}
