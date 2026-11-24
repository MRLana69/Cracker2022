using System;
using System.IO;
using Cpp2ILInjected;
using SYBO.Components.Crypt;
using SYBO.Components.Json.Internal;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.DateTimeUtilities;
using SYBO.Components.Utilities.IO;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonApi
{
	public static int BuilderCapacity
	{
		get
		{
			return (int)SystemInfo.GetOperatingSystemFamily();
		}
		set
		{
		}
	}

	public static T Deserialize<T>(string json, JsonContext context = null)
	{
		//IL_001f: Expected Obj, but got I4
		//IL_0023: Expected VT, but got I4
		UnityEngine.Object obj = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)context);
		return (T)((string)(object)obj != (string)json.m_stringLength);
	}

	public static string Serialize<T>(T obj, JsonContext context = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S3_v4 (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public static object DeserializeDom(string json)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object result = default;
		return result;
	}

	public static string SerializeDom(object json, JsonContext context = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0439: Expected Obj, but got I4
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		//IL_0463: Expected I, but got Obj
		//IL_0479: Expected Obj, but got I
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_05a6: Expected I, but got Obj
		//IL_05bc: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0107: Expected I, but got Obj
		//IL_011d: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0148: Expected I, but got Obj
		//IL_042a: Expected Obj, but got VT
		//IL_0430: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		obj2 = 0;
		object obj3 = obj2 + 16;
		obj3 = obj;
		_ = -1;
		nint num = (nint)typeof(DateTimeUtils);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<SYBO.Components.Utilities.DateTimeUtilities.DateTimeUtils>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(DateTimeUtils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v211 (Il2CppClass<SYBO.Components.Utilities.DateTimeUtilities.DateTimeUtils>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 8;
		string[] array = ((string)json).Split((string[])(object)DateTimeUtils.RFC822SplitSymbols, StringSplitOptions.RemoveEmptyEntries);
		nint num3 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<System.Type>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v201 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		obj6 = typeof(DateTimeUtils.Months);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj8 = array + 24;
		nint num5 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v95 (Il2CppClass<System.Enum>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v184 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj14 = default;
		if (obj12 == obj14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj16 = default;
			object obj15 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj18 = default;
			object obj17 = obj18;
		}
		else
		{
			object obj17 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		DateTime dateTime = default;
		JsonContext jsonContext = (JsonContext)dateTime;
		return (string)1;
	}

	public static T ReflectionDeserializeDom<T>(object jsonobj, JsonContext context = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a3: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S3_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public static object ReflectionDeserializeDom(Type type, object jsonobj, JsonContext context = null)
	{
		//IL_0072: Expected Obj, but got I4
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_019f: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		bool flag = ((PersistentDataPathUtility)(object)type).DeleteStorageLocation((string)jsonobj);
		if (context == null || context.ObjectStore == null)
		{
			string paramName = $"The filename must exist. value={(object[])(object)context}";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex = default;
			ex._002Ector(paramName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (!Directory.IsRootDirectory((string)flag))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectoriesInternal((string)flag);
		}
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v15 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v22 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = Path.SameRoot((string)flag, (string)(object)context);
		return FileUtility.IsLocalPath((string)flag2);
	}

	public static object ReflectionSerializeDom<T>(T data, JsonContext context = null)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v14 @ S3_v4 (should have been resolved before IL gen)");
		object result = default;
		return result;
	}

	public static object ReflectionSerializeDom(Type type, object data, JsonContext context = null)
	{
		return JsonReflectionParser.Serialize(type, data, context);
	}

	public static object ReflectionDeserializeDomAsType(Type objType, JsonDict json, JsonContext context = null)
	{
		return JsonReflectionParser.ReadReference(objType, json, context);
	}

	public static JsonDict ReflectionSerializeDomAsType(Type objType, object obj, JsonContext context = null)
	{
		return JsonReflectionParser.ReflectionSerialize(objType, obj, context);
	}

	public static bool LastDecodeSuccessful()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)JsonParser.BuilderCapacity != 0;
	}

	public static int GetLastErrorIndex()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
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
		return JsonParser.GetLastErrorIndex();
	}

	public static string GetLastErrorSnippet()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B1EF");
		string result = default;
		return result;
	}

	public static void PrepareReflectionForSerialization(Type[] serializationObjectTypes)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected I4, but got Obj
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
		JsonParser.BuilderCapacity = (int)serializationObjectTypes;
	}

	public JsonApi()
	{
		((Aes128CounterMode)this).GenerateKey();
	}
}
