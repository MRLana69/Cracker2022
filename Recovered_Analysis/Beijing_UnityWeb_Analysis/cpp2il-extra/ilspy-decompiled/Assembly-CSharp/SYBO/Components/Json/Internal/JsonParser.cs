using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

namespace SYBO.Components.Json.Internal;

public class JsonParser
{
	protected enum Token
	{
		None,
		CurlyOpen,
		CurlyClose,
		SquaredOpen,
		SquaredClose,
		Colon,
		Comma,
		String,
		Number,
		True,
		False,
		Null
	}

	public static int BuilderCapacity;

	protected static int _lastErrorIndex;

	protected static string _lastDecode;

	private static int _indentation;

	private static List<string> _indentations;

	private static StringBuilder _stringParsingBuffer;

	private static HashSet<char> _possibleNumberChars;

	public unsafe static T Deserialize<T>(string json, JsonContext context = null)
	{
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected Ref, but got Unknown
		//IL_017d: Expected Obj, but got I
		//IL_0193: Expected I, but got Obj
		//IL_01a9: Expected Obj, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected I, but got Unknown
		//IL_023a: Expected I, but got Obj
		//IL_025d: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01db: Expected I, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_0158: Expected VT, but got Obj
		object obj = default;
		ref JsonObjectStore.JsonObjectStoreTypeEntry reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)(obj + 8);
		reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)null;
		nint num = default;
		object obj2 = num + 24;
		object obj3 = obj2;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<System.Type>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v37 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj + 4;
		obj5 = obj3;
		nint num4 = (nint)(obj + 12);
		((IntPtr*)num4)->m_value = (void*)(nint)obj5;
		Type key = Type.internal_from_handle((IntPtr)num4);
		if (((Dictionary<Type, JsonObjectStore.JsonObjectStoreTypeEntry>)json.m_stringLength).TryGetValue(key, out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string key2 = default;
			bool flag = reference.Contains(key2);
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			T result = default;
			return result;
		}
		object obj7 = obj2;
		nint num5 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v17 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v33 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj = obj7;
		((IntPtr*)num4)->m_value = (void*)(nint)obj;
		Type type = Type.internal_from_handle((IntPtr)num4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object[] args = default;
		string message = $"JsonObjectStore doesn't contain any objects of type {args}";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonReflectionException ex = default;
		ex._002Ector(message);
		((JsonObjectStore)(object)ex).Get<object>((object)null);
		return (T)null;
	}

	public static string Serialize<T>(T obj, JsonContext context = null)
	{
		//IL_0127: Expected Obj, but got I4
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_0176: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected Obj, but got I
		//IL_00dc: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		object result = 0;
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v27 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = ParseHex((string)obj);
		if (obj3 != null)
		{
			nint num3 = default;
			object obj4 = num3 + 24;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AE");
			object obj6 = default;
			if (obj6 != null)
			{
				object obj7 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			}
			else
			{
				object obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v5+4]");
				object obj9 = 0;
				object obj10 = obj9 & 0x1FFF;
				object obj11 = obj10 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S3_v6 (should have been resolved before IL gen)");
			}
			string result2 = default;
			return result2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		return (string)result;
	}

	public static object DeserializeDom(string json)
	{
		//IL_0030: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DateTimeFormatInfo dateTimeFormatInfo = default;
		dateTimeFormatInfo.InsertHash((System.Globalization.TokenHashValue[])json.m_stringLength, (string)4, System.TokenType.Am, 3);
		return dateTimeFormatInfo;
	}

	public static string SerializeDom(object json, JsonContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected Obj, but got Unknown
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected Obj, but got Unknown
		//IL_0753: Expected Obj, but got I4
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0761: Expected Obj, but got Unknown
		//IL_077c: Expected Obj, but got I4
		//IL_039c: Expected Obj, but got I4
		//IL_0463: Expected Obj, but got I
		//IL_0796: Expected Obj, but got I4
		//IL_052a: Expected Obj, but got I
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected Obj, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = default;
		bool flag;
		object obj9;
		object obj11;
		object obj13;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E8");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj6 = default;
				object obj5 = obj6;
				object obj8 = default;
				object obj7 = obj8;
				flag = false;
				obj9 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj10 = default;
				if (obj5 == obj10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
					object obj12 = default;
					obj11 = obj12;
					goto IL_040b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				goto IL_068c;
			}
			obj13 = 0;
		}
		else
		{
			obj13 = 0;
		}
		object obj14 = obj13;
		object obj15 = obj2 + 4;
		object obj16 = obj15 + 1;
		obj15 = obj16;
		object obj17 = obj16 << 2;
		object obj18 = obj2 + obj17;
		obj18 = 79;
		object obj19 = obj14 & 1;
		bool flag2 = obj19 != null;
		obj11 = 0;
		flag = flag2;
		obj9 = obj3;
		goto IL_040b;
		IL_068c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj2 + obj20;
			if ((nint)obj21 == 81)
			{
				object obj22 = obj2 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0791;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj24 = (nint)0 << 2;
			object obj25 = obj2 + obj24;
			if ((nint)obj25 == 79)
			{
				object obj26 = obj2 + 4;
				if ((nint)obj26 > -1)
				{
					object obj27 = obj26 + -1;
					obj26 = obj27;
				}
				goto IL_0791;
			}
		}
		object obj28 = default;
		if (obj28 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0791;
		IL_0791:
		bool flag3 = default;
		return (string)flag3;
		IL_040b:
		if (obj9 == null)
		{
			flag3 = flag;
			obj28 = obj11;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E4D3");
			flag3 = flag;
			obj28 = obj11;
		}
		goto IL_068c;
	}

	public static bool LastDecodeSuccessful()
	{
		//IL_001d: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonObjectStore jsonObjectStore = default;
		jsonObjectStore._002Ector();
		return (byte)(int)jsonObjectStore != 0;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (_lastErrorIndex == -1) ? 1 : 0;
	}

	public static string GetLastErrorSnippet()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected Obj, but got I4
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
		return (string)_lastErrorIndex;
	}

	protected unsafe static JsonDict ParseObject(string json, ref int index)
	{
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_00f0: Expected Obj, but got I4
		//IL_0101: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_indentation = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector((string)BuilderCapacity);
		object obj2 = JsonReflectionParser.Deserialize((Type)(object)json, stringBuilder, (JsonContext)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			JsonDict result = default;
			return result;
		}
		return null;
	}

	protected unsafe static JsonList ParseArray(string json, ref int index)
	{
		//IL_04e2: Expected Obj, but got I4
		//IL_0503: Expected I, but got Obj
		//IL_0519: Expected Obj, but got I
		//IL_0543: Expected Obj, but got Ref
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0239: Expected I, but got Obj
		//IL_024f: Expected Obj, but got I
		//IL_027a: Expected I, but got Obj
		//IL_02c7: Expected I, but got Obj
		//IL_02dd: Expected Obj, but got I
		//IL_0459: Expected I, but got Obj
		//IL_046f: Expected Obj, but got I
		//IL_05d5: Expected Obj, but got Ref
		//IL_063d: Expected Obj, but got Ref
		//IL_0308: Expected I, but got Obj
		//IL_049a: Expected I, but got Obj
		//IL_0350: Expected Obj, but got I4
		//IL_035e: Expected I, but got Obj
		//IL_0374: Expected Obj, but got I
		//IL_060a: Expected Obj, but got Ref
		//IL_039f: Expected I, but got Obj
		//IL_03f4: Expected Obj, but got I
		//IL_0404: Expected Obj, but got I
		//IL_0414: Expected Obj, but got I
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Obj, but got Unknown
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected Obj, but got Unknown
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_058c: Expected Obj, but got Ref
		//IL_01ec: Expected I, but got Obj
		JsonContext jsonContext = (JsonContext)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonFieldInfo jsonFieldInfo = default;
		jsonFieldInfo._002Ector();
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v101 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string key = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
		while (true)
		{
			nint num3 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v23 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v97 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Token token = NextToken(json, ref *(int*)index);
			if (token == Token.None)
			{
				break;
			}
			if (token != Token.CurlyOpen)
			{
				switch (token)
				{
				case Token.Comma:
				{
					nint num7 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v87 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v93 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string key3 = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
					continue;
				}
				case Token.CurlyClose:
				{
					nint num5 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v75 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v82 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string key2 = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
					return (JsonList)(object)jsonFieldInfo;
				}
				}
			}
			nint num9 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v34 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v70 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = ParseNumber(json, ref index);
			if (obj6 == null)
			{
				break;
			}
			nint num11 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v42 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num12 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v66 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string key4 = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
			if ((nint)key4 != 5)
			{
				break;
			}
			jsonContext = (JsonContext)1;
			nint num13 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v51 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num14 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v62 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = SerializeObject((IDictionary)(object)json, (StringBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index), jsonContext);
			if (jsonContext == null)
			{
				break;
			}
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S4_v4 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S4_v5+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S4_v6+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S5_v2 (should have been resolved before IL gen)");
		}
		return null;
	}

	protected unsafe static object ParseValue(string json, ref int index, ref bool success)
	{
		//IL_005c: Expected Obj, but got Ref
		//IL_005c: Expected Obj, but got I4
		ref JsonObjectStore.JsonObjectStoreTypeEntry reference = ref *(JsonObjectStore.JsonObjectStoreTypeEntry*)null;
		if (((Dictionary<Type, JsonObjectStore.JsonObjectStoreTypeEntry>)json.m_stringLength).TryGetValue((Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index), out reference))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string path = default;
			return reference(path);
		}
		return null;
	}

	protected unsafe static string ParseString(string json, ref int index)
	{
		//IL_037b: Expected Obj, but got I4
		//IL_039c: Expected I, but got Obj
		//IL_03b2: Expected Obj, but got I
		//IL_03dc: Expected Obj, but got Ref
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I4
		//IL_0242: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I
		//IL_043f: Expected Obj, but got Ref
		//IL_0283: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I4
		//IL_02f2: Expected I, but got Obj
		//IL_0308: Expected Obj, but got I
		//IL_0472: Expected Obj, but got Ref
		//IL_0333: Expected I, but got Obj
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_0425: Expected Obj, but got Ref
		//IL_01ec: Expected I, but got Obj
		JsonContext jsonContext = (JsonContext)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonObjectStore jsonObjectStore = default;
		jsonObjectStore._002Ector();
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v76 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string key = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
		while (true)
		{
			nint num3 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v23 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v72 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Token token = NextToken(json, ref *(int*)index);
			if (token == Token.None)
			{
				break;
			}
			if (token != Token.CurlyOpen)
			{
				switch (token)
				{
				case Token.Comma:
				{
					nint num7 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v62 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj4 = (nint)0 & (nint)0x200;
					if (obj4 != null)
					{
						nint num8 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v68 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string key3 = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
					continue;
				}
				case Token.SquaredClose:
				{
					nint num5 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v50 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v57 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string key2 = JsonReflectionParser.GetKey((object)json, (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
					return (string)(object)jsonObjectStore;
				}
				}
			}
			jsonContext = (JsonContext)1;
			nint num9 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v35 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v45 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = SerializeObject((IDictionary)(object)json, (StringBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index), jsonContext);
			if (jsonContext == null)
			{
				break;
			}
			((List<object>)(object)jsonObjectStore).Add((object)flag);
		}
		return null;
	}

	protected unsafe static object ParseNumber(string json, ref int index)
	{
		//IL_19ac: Expected I, but got Obj
		//IL_19c2: Expected Obj, but got I
		//IL_1b77: Expected Obj, but got Ref
		//IL_19ed: Expected I, but got Obj
		//IL_1a03: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_1bbe: Expected Obj, but got I4
		//IL_1bd8: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got I4
		//IL_0135: Expected I, but got Obj
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		//IL_1a36: Expected Obj, but got I
		//IL_01ad: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_00cc: Expected I, but got Obj
		//IL_00fc: Expected I, but got Obj
		//IL_1919: Expected I, but got Obj
		//IL_192f: Expected Obj, but got I
		//IL_0122: Expected I, but got Obj
		//IL_187c: Expected I, but got Obj
		//IL_1892: Expected Obj, but got I
		//IL_195a: Expected I, but got Obj
		//IL_1b52: Expected I4, but got Obj
		//IL_18bd: Expected I, but got Obj
		//IL_08e7: Expected Obj, but got I4
		//IL_0901: Expected Obj, but got I4
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected Obj, but got Unknown
		//IL_12c6: Expected I, but got Obj
		//IL_12dc: Expected Obj, but got I
		//IL_1307: Expected I, but got Obj
		//IL_13e2: Expected I, but got Obj
		//IL_13f8: Expected Obj, but got I
		//IL_1423: Expected I, but got Obj
		//IL_1354: Expected I, but got Obj
		//IL_136a: Expected Obj, but got I
		//IL_1395: Expected I, but got Obj
		//IL_1470: Expected I, but got Obj
		//IL_1486: Expected Obj, but got I
		//IL_14b1: Expected I, but got Obj
		//IL_14fe: Expected I, but got Obj
		//IL_1514: Expected Obj, but got I
		//IL_153f: Expected I, but got Obj
		//IL_158c: Expected I, but got Obj
		//IL_15a2: Expected Obj, but got I
		//IL_15cd: Expected I, but got Obj
		//IL_161a: Expected I, but got Obj
		//IL_1630: Expected Obj, but got I
		//IL_165b: Expected I, but got Obj
		//IL_16a8: Expected I, but got Obj
		//IL_16be: Expected Obj, but got I
		//IL_16e9: Expected I, but got Obj
		//IL_173f: Expected Obj, but got I4
		//IL_1785: Expected Obj, but got I4
		//IL_179c: Expected I, but got Obj
		//IL_17b2: Expected Obj, but got I
		//IL_1b11: Expected I, but got Obj
		//IL_1b27: Expected Obj, but got I
		//IL_1bea: Expected Obj, but got I4
		//IL_1c13: Expected Obj, but got I4
		//IL_17dd: Expected I, but got Obj
		//IL_182a: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v245 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SerializeString(json, (StringBuilder)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index));
		if (_stringParsingBuffer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector((string)1024);
			nint num3 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v232 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num4 = (nint)typeof(JsonParser);
			if (!flag)
			{
				nint num5 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v239 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(JsonParser);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(JsonParser);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L2_v45 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+5C]");
			object obj3 = (nint)0 + (nint)20;
			obj3 = stringBuilder;
		}
		nint num6 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v18 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v222 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_stringParsingBuffer.AppendHelper((string)null);
		object obj5 = index + 1;
		ref int reference = ref *(int*)obj5;
		string[] array = json.Split((char[])index);
		while (true)
		{
			if (index != json.m_stringLength)
			{
				object obj6 = index + 1;
				reference = ref *(int*)obj6;
				string[] array2 = json.Split((char[])index);
				object obj7 = (object)array2 << 16;
				object obj8 = obj7 >> 16;
				object obj9 = obj8 - 34;
				if ((nint)obj8 == 34)
				{
					break;
				}
				if ((nint)obj9 == 1 || (nint)obj9 == 2 || (nint)obj9 == 3 || (nint)obj9 == 4 || (nint)obj9 == 5 || (nint)obj9 == 6 || (nint)obj9 == 7 || (nint)obj9 == 8 || (nint)obj9 == 9 || (nint)obj9 == 10 || (nint)obj9 == 11 || (nint)obj9 == 12 || (nint)obj9 == 13 || (nint)obj9 == 14 || (nint)obj9 == 15 || (nint)obj9 == 16 || (nint)obj9 == 17 || (nint)obj9 == 18 || (nint)obj9 == 19 || (nint)obj9 == 20 || (nint)obj9 == 21 || (nint)obj9 == 22 || (nint)obj9 == 23 || (nint)obj9 == 24 || (nint)obj9 == 25 || (nint)obj9 == 26 || (nint)obj9 == 27 || (nint)obj9 == 28 || (nint)obj9 == 29 || (nint)obj9 == 30 || (nint)obj9 == 31 || (nint)obj9 == 32 || (nint)obj9 == 33 || (nint)obj9 == 34 || (nint)obj9 == 35 || (nint)obj9 == 36 || (nint)obj9 == 37 || (nint)obj9 == 38 || (nint)obj9 == 39 || (nint)obj9 == 40 || (nint)obj9 == 41 || (nint)obj9 == 42 || (nint)obj9 == 43 || (nint)obj9 == 44 || (nint)obj9 == 45 || (nint)obj9 == 46 || (nint)obj9 == 47 || (nint)obj9 == 48 || (nint)obj9 == 49 || (nint)obj9 == 50 || (nint)obj9 == 51 || (nint)obj9 == 52 || (nint)obj9 == 53 || (nint)obj9 == 54 || (nint)obj9 == 55 || (nint)obj9 == 56 || (nint)obj9 == 57 || (nint)obj9 != 58)
				{
					nint num8 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v56 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num9 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S0_v64 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					StringBuilder stringBuilder2 = _stringParsingBuffer.Append((int)array2);
					continue;
				}
				if (index != json.m_stringLength)
				{
					object obj11 = index + 1;
					reference = ref *(int*)obj11;
					string[] array3 = json.Split((char[])index);
					object obj12 = (object)array3 << 16;
					object obj13 = obj12 >> 16;
					object obj14 = obj13 - 34;
					if ((nint)obj13 == 34)
					{
						nint num10 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ S0_v80 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj15 = (nint)0 & (nint)0x200;
						if (obj15 != null)
						{
							nint num11 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S0_v88 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder3 = _stringParsingBuffer.Append(34);
						continue;
					}
					if ((nint)obj14 == 1 || (nint)obj14 == 2 || (nint)obj14 == 3 || (nint)obj14 == 4 || (nint)obj14 == 5 || (nint)obj14 == 6 || (nint)obj14 == 7 || (nint)obj14 == 8 || (nint)obj14 == 9 || (nint)obj14 == 10 || (nint)obj14 == 11 || (nint)obj14 == 12)
					{
						continue;
					}
					if ((nint)obj14 == 13)
					{
						nint num12 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v95 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj16 = (nint)0 & (nint)0x200;
						if (obj16 != null)
						{
							nint num13 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v103 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder4 = _stringParsingBuffer.Append(47);
						continue;
					}
					if ((nint)obj14 == 14 || (nint)obj14 == 15 || (nint)obj14 == 16 || (nint)obj14 == 17 || (nint)obj14 == 18 || (nint)obj14 == 19 || (nint)obj14 == 20 || (nint)obj14 == 21 || (nint)obj14 == 22 || (nint)obj14 == 23 || (nint)obj14 == 24 || (nint)obj14 == 25 || (nint)obj14 == 26 || (nint)obj14 == 27 || (nint)obj14 == 28 || (nint)obj14 == 29 || (nint)obj14 == 30 || (nint)obj14 == 31 || (nint)obj14 == 32 || (nint)obj14 == 33 || (nint)obj14 == 34 || (nint)obj14 == 35 || (nint)obj14 == 36 || (nint)obj14 == 37 || (nint)obj14 == 38 || (nint)obj14 == 39 || (nint)obj14 == 40 || (nint)obj14 == 41 || (nint)obj14 == 42 || (nint)obj14 == 43 || (nint)obj14 == 44 || (nint)obj14 == 45 || (nint)obj14 == 46 || (nint)obj14 == 47 || (nint)obj14 == 48 || (nint)obj14 == 49 || (nint)obj14 == 50 || (nint)obj14 == 51 || (nint)obj14 == 52 || (nint)obj14 == 53 || (nint)obj14 == 54 || (nint)obj14 == 55 || (nint)obj14 == 56 || (nint)obj14 == 57)
					{
						continue;
					}
					if ((nint)obj14 == 58)
					{
						nint num14 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ S0_v110 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj17 = (nint)0 & (nint)0x200;
						if (obj17 != null)
						{
							nint num15 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ S0_v118 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder5 = _stringParsingBuffer.Append(92);
						continue;
					}
					if ((nint)obj14 == 59 || (nint)obj14 == 60 || (nint)obj14 == 61 || (nint)obj14 == 62 || (nint)obj14 == 63)
					{
						continue;
					}
					if ((nint)obj14 == 64)
					{
						nint num16 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v125 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj18 = (nint)0 & (nint)0x200;
						if (obj18 != null)
						{
							nint num17 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S0_v133 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder6 = _stringParsingBuffer.Append(8);
						continue;
					}
					if ((nint)obj14 == 65 || (nint)obj14 == 66 || (nint)obj14 == 67)
					{
						continue;
					}
					if ((nint)obj14 == 68)
					{
						nint num18 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v140 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num19 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ S0_v148 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder7 = _stringParsingBuffer.Append(12);
						continue;
					}
					if ((nint)obj14 == 69 || (nint)obj14 == 70 || (nint)obj14 == 71 || (nint)obj14 == 72 || (nint)obj14 == 73 || (nint)obj14 == 74 || (nint)obj14 == 75)
					{
						continue;
					}
					if ((nint)obj14 == 76)
					{
						nint num20 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S0_v155 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj20 = (nint)0 & (nint)0x200;
						if (obj20 != null)
						{
							nint num21 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S0_v163 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder8 = _stringParsingBuffer.Append(10);
						continue;
					}
					if ((nint)obj14 == 77 || (nint)obj14 == 78 || (nint)obj14 == 79)
					{
						continue;
					}
					if ((nint)obj14 == 80)
					{
						nint num22 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v170 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj21 = (nint)0 & (nint)0x200;
						if (obj21 != null)
						{
							nint num23 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ S0_v178 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder9 = _stringParsingBuffer.Append(13);
						continue;
					}
					if ((nint)obj14 == 81)
					{
						continue;
					}
					if ((nint)obj14 == 82)
					{
						nint num24 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v185 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj22 = (nint)0 & (nint)0x200;
						if (obj22 != null)
						{
							nint num25 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S0_v193 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						StringBuilder stringBuilder10 = _stringParsingBuffer.Append(9);
						continue;
					}
					if ((nint)obj14 != 83)
					{
						continue;
					}
					object obj23 = json.m_stringLength - index;
					if ((nint)obj23 >= 4)
					{
						string s = json.InternalSubString(index, 4);
						uint num26 = uint.Parse(s, (IFormatProvider)515);
						nint num27 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ S0_v207 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num28 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v216 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						nint num29 = (nint)typeof(char);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ S1_v63 (Il2CppClass<System.Char>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num30 = (nint)typeof(char);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ S1_v72 (Il2CppClass<System.Char>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object value = ((CharEnumerator)num26).Clone();
						StringBuilder stringBuilder11 = _stringParsingBuffer.AppendLine((string)value);
						object obj26 = index + 4;
						reference = ref *(int*)obj26;
						continue;
					}
				}
			}
			return null;
		}
		nint num31 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v42 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num32 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v48 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object result = default;
		return result;
	}

	private static object ParseHex(string hexString)
	{
		//IL_0241: Expected Obj, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected Obj, but got Unknown
		//IL_0258: Expected Obj, but got I4
		//IL_0266: Expected I, but got Obj
		//IL_027c: Expected Obj, but got I
		//IL_0299: Expected I, but got Obj
		//IL_030c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0343: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0069: Expected I, but got Obj
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_00cf: Expected I, but got Obj
		//IL_02f1: Expected I4, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_01eb: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		StringBuilder stringBuilder = (StringBuilder)0;
		JsonContext jsonContext = (JsonContext)(stringBuilder + 4);
		jsonContext = (JsonContext)0;
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(JsonParser);
		if (!flag)
		{
			nint num3 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v68 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(JsonParser);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(JsonParser);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ L1_v3 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = hexString;
		bool flag5;
		if (hexString != null)
		{
			stringBuilder = (StringBuilder)0;
			jsonContext = (JsonContext)1;
			nint num4 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v27 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v64 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = SerializeObject((IDictionary)(object)hexString, stringBuilder, jsonContext);
			if (jsonContext != null)
			{
				nint num6 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v52 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num7 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v58 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_lastErrorIndex = -1;
			}
			else
			{
				nint num8 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v39 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num9 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v45 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				_lastErrorIndex = (int)stringBuilder;
			}
			flag5 = flag4;
		}
		else
		{
			flag5 = false;
		}
		return flag5;
	}

	protected unsafe static int GetLastIndexOfNumber(string json, int index)
	{
		//IL_03ab: Expected I, but got Obj
		//IL_03c1: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I4
		//IL_049f: Expected Obj, but got I4
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_02cb: Expected I, but got Obj
		//IL_02e1: Expected Obj, but got I
		//IL_040f: Expected I, but got Obj
		//IL_0425: Expected Obj, but got I
		//IL_02a9: Expected Obj, but got I8
		//IL_00a9: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_045b: Expected Obj, but got F8
		//IL_030c: Expected I, but got Obj
		//IL_01a4: Expected I, but got Obj
		//IL_01ba: Expected Obj, but got I
		//IL_0359: Expected I, but got Obj
		//IL_03f3: Expected I4, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_01e5: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v71 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SerializeString(json, (StringBuilder)index);
		Token token = LookAhead(json, ((int*)index)->m_value);
		object obj2 = token - ((int*)index)->m_value;
		int num3 = obj2 + 1;
		if (num3 >= 3)
		{
			string[] array = json.Split((char[])((int*)index)->m_value);
			object obj3 = array & 0xFFFF;
			if ((nint)obj3 == 48)
			{
				char[] separator = (char[])(((int*)index)->m_value + 1);
				string[] array2 = json.Split(separator);
				object obj4 = array2 & 0xFFFF;
				if ((nint)obj4 != 120)
				{
					char[] separator2 = (char[])(((int*)index)->m_value + 1);
					string[] array3 = json.Split(separator2);
					object obj5 = array3 & 0xFFFF;
					if ((nint)obj5 != 88)
					{
						goto IL_0224;
					}
				}
				int startIndex = ((int*)index)->m_value + 2;
				int length = num3 - 2;
				string dict = json.InternalSubString(startIndex, length);
				int value = (int)(token + 1);
				((int*)index)->m_value = value;
				nint num4 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S1_v43 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num5 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v48 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				IDictionaryEnumerator dictionaryEnumerator = SetupDictionaryEnumerator((IDictionary)(object)dict);
				return (int)dictionaryEnumerator;
			}
		}
		goto IL_0224;
		IL_0224:
		string text = json.InternalSubString(((int*)index)->m_value, num3);
		int value2 = (int)(token + 1);
		((int*)index)->m_value = value2;
		if (!text.EndsWith("."))
		{
			long ticks = ((TimeSpan*)text)->Ticks;
			object obj7 = ticks;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		}
		else
		{
			nint num6 = (nint)typeof(CultureInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v28 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num7 = (nint)typeof(CultureInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v47 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CultureInfo currentCulture = CultureInfo.CurrentCulture;
			nint num8 = (nint)typeof(double);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v35 (Il2CppClass<System.Double>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num9 = (nint)typeof(double);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v43 (Il2CppClass<System.Double>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			double num10 = ((double*)text)->System_002EIConvertible_002EToDouble((IFormatProvider)currentCulture);
			object obj7 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		}
		int result = default;
		return result;
	}

	protected unsafe static void EatWhitespace(string json, ref int index)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got Ref
		object obj = json + 8;
		obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
	}

	protected static Token LookAhead(string json, int index)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_00ed: Expected I4, but got Obj
		//IL_0054: Expected I, but got Obj
		int num = index;
		while (num < json.m_stringLength)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v13 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v24 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = json.Split((char[])num);
			if (!_possibleNumberChars.Contains((char)(int)array))
			{
				break;
			}
			int num4 = num + 1;
			num = num4;
		}
		return (Token)(num - 1);
	}

	protected unsafe static Token NextToken(string json, ref int index)
	{
		//IL_005a: Expected Obj, but got Ref
		//IL_0068: Expected I, but got Obj
		//IL_007e: Expected Obj, but got I
		//IL_00ac: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		Type type = (Type)System.Runtime.CompilerServices.Unsafe.AsPointer(ref index);
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (Token)JsonReflectionParser.GetKey((object)json, type);
	}

	protected unsafe static bool SerializeObject(IDictionary dict, StringBuilder builder, JsonContext context)
	{
		//IL_061a: Expected I, but got Obj
		//IL_0630: Expected Obj, but got I
		//IL_0812: Expected Obj, but got I4
		//IL_0215: Expected I, but got Obj
		//IL_022b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_068a: Expected I4, but got Obj
		//IL_0256: Expected I, but got Obj
		//IL_05fe: Expected Obj, but got I4
		//IL_037e: Expected I, but got Obj
		//IL_0394: Expected Obj, but got I
		//IL_072d: Expected I4, but got Obj
		//IL_03bf: Expected I, but got Obj
		//IL_0575: Expected I, but got Obj
		//IL_058b: Expected Obj, but got I
		//IL_07ee: Expected I4, but got Obj
		//IL_05b6: Expected I, but got Obj
		//IL_04e7: Expected I, but got Obj
		//IL_04fd: Expected Obj, but got I
		//IL_07c4: Expected I4, but got Obj
		//IL_0528: Expected I, but got Obj
		//IL_040c: Expected I, but got Obj
		//IL_0422: Expected Obj, but got I
		//IL_0751: Expected I, but got Obj
		//IL_0767: Expected Obj, but got I
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected Obj, but got Unknown
		//IL_044d: Expected I, but got Obj
		//IL_02a3: Expected I, but got Obj
		//IL_02b9: Expected Obj, but got I
		//IL_049a: Expected I, but got Obj
		//IL_06ae: Expected I, but got Obj
		//IL_06c4: Expected Obj, but got I
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_02e4: Expected I, but got Obj
		//IL_0187: Expected I, but got Obj
		//IL_019d: Expected Obj, but got I
		//IL_0331: Expected I, but got Obj
		//IL_01c8: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v125 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Token token = NextToken((string)(object)dict, ref *(int*)builder);
		object obj2 = token - 1;
		if (token != Token.CurlyOpen)
		{
			if ((nint)obj2 != 1)
			{
				if ((nint)obj2 == 2)
				{
					nint num3 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v33 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v39 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = ParseString((string)(object)dict, ref *(int*)builder);
					return (byte)(int)text != 0;
				}
				if ((nint)obj2 != 3 && (nint)obj2 != 4 && (nint)obj2 != 5)
				{
					if ((nint)obj2 != 6)
					{
						if ((nint)obj2 != 7)
						{
							if ((nint)obj2 != 8)
							{
								if ((nint)obj2 != 9)
								{
									if ((nint)obj2 != 10)
									{
										goto IL_05f5;
									}
									nint num5 = (nint)typeof(JsonParser);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v114 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
									object obj4 = (nint)0 & (nint)0x200;
									if (obj4 != null)
									{
										nint num6 = (nint)typeof(JsonParser);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v121 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									string key = JsonReflectionParser.GetKey((object)dict, (Type)(object)builder);
									return false;
								}
								nint num7 = (nint)typeof(JsonParser);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v90 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
								object obj5 = (nint)0 & (nint)0x200;
								if (obj5 != null)
								{
									nint num8 = (nint)typeof(JsonParser);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v109 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string key2 = JsonReflectionParser.GetKey((object)dict, (Type)(object)builder);
								nint num9 = (nint)typeof(bool);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v97 (Il2CppClass<System.Boolean>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num10 = (nint)typeof(bool);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v105 (Il2CppClass<System.Boolean>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string text2 = bool.TrimWhiteSpaceAndNull("FALSE");
								object obj7 = text2 & 1;
								object obj8 = obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							}
							else
							{
								nint num11 = (nint)typeof(JsonParser);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v66 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
								object obj9 = (nint)0 & (nint)0x200;
								if (obj9 != null)
								{
									nint num12 = (nint)typeof(JsonParser);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v85 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string key3 = JsonReflectionParser.GetKey((object)dict, (Type)(object)builder);
								nint num13 = (nint)typeof(bool);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v73 (Il2CppClass<System.Boolean>)+BA]");
								object obj10 = (nint)0 & (nint)0x200;
								if (obj10 != null)
								{
									nint num14 = (nint)typeof(bool);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v81 (Il2CppClass<System.Boolean>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string text3 = bool.TrimWhiteSpaceAndNull("TRUE");
								object obj11 = text3 & 1;
								object obj8 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							}
							bool result = default;
							return result;
						}
						nint num15 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v55 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
						object obj12 = (nint)0 & (nint)0x200;
						if (obj12 != null)
						{
							nint num16 = (nint)typeof(JsonParser);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v61 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						return (byte)GetLastIndexOfNumber((string)(object)dict, (int)builder) != 0;
					}
					nint num17 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v44 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num18 = (nint)typeof(JsonParser);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v50 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj14 = ParseNumber((string)(object)dict, ref *(int*)builder);
					return (byte)(int)obj14 != 0;
				}
			}
			goto IL_05f5;
		}
		nint num19 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v20 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num20 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		JsonList jsonList = ParseArray((string)(object)dict, ref *(int*)builder);
		return (byte)(int)jsonList != 0;
		IL_05f5:
		JsonContext jsonContext = (JsonContext)0;
		return false;
	}

	private static IDictionaryEnumerator SetupDictionaryEnumerator(IDictionary dict)
	{
		//IL_0041: Expected Obj, but got I4
		//IL_004d: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_001f: Expected Obj, but got I8
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dict @ L0 (System.Collections.IDictionary)+8]");
		if ((nint)0 > (nint)8)
		{
			long num = long.Parse((string)(object)dict, (IFormatProvider)515);
			object obj = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		}
		else
		{
			int num2 = int.Parse((string)(object)dict, (IFormatProvider)515);
			object obj = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		}
		IDictionaryEnumerator result = default;
		return result;
	}

	protected static string GetIndentationString()
	{
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02a6: Expected Obj, but got I4
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_03e5: Expected I, but got Obj
		//IL_03fb: Expected Obj, but got I
		//IL_00fc: Expected I, but got Obj
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I4
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected I4, but got Unknown
		//IL_018a: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v82 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_lastErrorIndex == -1)
		{
			return "";
		}
		nint num3 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v16 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v74 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = _lastErrorIndex - 5;
		object obj3 = _lastErrorIndex + 15;
		nint num6 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v30 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v68 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string lastDecode = _lastDecode;
		bool flag = (nint)obj3 >= lastDecode.m_stringLength;
		bool flag2 = !flag;
		object obj5 = obj3;
		if (!flag2)
		{
			nint num8 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v53 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num9 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v62 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string lastDecode2 = _lastDecode;
			object obj7 = lastDecode2.m_stringLength - 1;
			obj5 = obj7;
		}
		nint num10 = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v38 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v46 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num12;
		int startIndex;
		if (num5 > 0)
		{
			num12 = num5;
			startIndex = num5;
		}
		else
		{
			num12 = 0;
			startIndex = 0;
		}
		object obj9 = obj5 - num12;
		int length = obj9 + 1;
		return _lastDecode.InternalSubString(startIndex, length);
	}

	protected static bool SerializeArray(Array anArray, StringBuilder builder, JsonContext context)
	{
		//IL_02be: Expected I, but got Obj
		//IL_02d4: Expected Obj, but got I
		//IL_031f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_025f: Expected I, but got Obj
		//IL_00c2: Expected I, but got Obj
		//IL_00d8: Expected Obj, but got I
		//IL_0103: Expected I, but got Obj
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_017d: Expected Obj, but got I4
		//IL_01d1: Expected I, but got Obj
		StringBuilder stringBuilder = builder.AppendLine("{");
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v63 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int indentation = _indentation + 1;
		_indentation = indentation;
		bool flag = JsonReflectionParser.NeedsFileReference((JsonFieldInfo)(object)anArray);
		object obj2 = 1;
		object obj3 = default;
		StringBuilder builder2 = default;
		Type type = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				if (obj2 == null)
				{
					StringBuilder stringBuilder2 = builder.AppendLine(",");
				}
				nint num3 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v30 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v44 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				JsonReflectionParser.PrepareReflectionRecursively((Type)(object)builder, (HashSet<Type>)(object)context);
				AppendIndentation(builder2, (JsonContext)(object)builder);
				StringBuilder stringBuilder3 = builder.AppendLine(":");
				object obj5 = JsonReflectionParser.Deserialize(type, builder, context);
				if (obj5 != null)
				{
					obj2 = 0;
					continue;
				}
				nint num5 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v48 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v56 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				break;
			}
			nint num7 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v24 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v35 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int indentation2 = _indentation - 1;
			_indentation = indentation2;
			JsonReflectionParser.PrepareReflectionRecursively((Type)(object)builder, (HashSet<Type>)(object)context);
			StringBuilder stringBuilder4 = builder.AppendLine("}");
			return true;
		}
		int indentation3 = _indentation - 1;
		_indentation = indentation3;
		return false;
	}

	protected static bool SerializeArray(IList anArray, StringBuilder builder, JsonContext context)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02ae: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_01a3: Expected I, but got Obj
		//IL_01b9: Expected Obj, but got I
		//IL_01e4: Expected I, but got Obj
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0132: Expected I, but got Obj
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I4
		StringBuilder stringBuilder = builder.AppendLine("[");
		int rank = ((Array)anArray).Rank;
		bool result;
		if (rank >= 1)
		{
			nint num = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v16 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v64 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int indentation = _indentation + 1;
			_indentation = indentation;
			object obj2 = 1;
			int[] array = null;
			while (true)
			{
				int rank2 = ((Array)anArray).Rank;
				if ((nint)array >= rank2)
				{
					break;
				}
				Array type = Array.UnsafeCreateInstance((Type)anArray, array);
				if (obj2 == null)
				{
					StringBuilder stringBuilder2 = builder.AppendLine(",");
				}
				nint num3 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v49 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v58 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				JsonReflectionParser.PrepareReflectionRecursively((Type)(object)builder, (HashSet<Type>)(object)context);
				object obj4 = JsonReflectionParser.Deserialize((Type)(object)type, builder, context);
				bool flag = obj4 == null;
				result = false;
				if (!flag)
				{
					int[] array2 = (int[])(array + 1);
					obj2 = 0;
					array = array2;
					continue;
				}
				goto IL_0300;
			}
			nint num5 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v29 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v37 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int indentation2 = _indentation - 1;
			_indentation = indentation2;
			JsonReflectionParser.PrepareReflectionRecursively((Type)(object)builder, (HashSet<Type>)(object)context);
		}
		StringBuilder stringBuilder3 = builder.AppendLine("]");
		result = true;
		goto IL_0300;
		IL_0300:
		return result;
	}

	protected static bool SerializeValue(object value, StringBuilder builder, JsonContext context)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_01dd: Expected I, but got Obj
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_012b: Expected I, but got Obj
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I4
		StringBuilder stringBuilder = builder.AppendLine("[");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		bool result;
		if ((nint)obj >= 1)
		{
			nint num = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v64 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int indentation = _indentation + 1;
			_indentation = indentation;
			object obj3 = 1;
			object obj4 = 0;
			object obj5 = default;
			Type type = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				if (obj3 == null)
				{
					StringBuilder stringBuilder2 = builder.AppendLine(",");
				}
				nint num3 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v49 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(JsonParser);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v58 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				JsonReflectionParser.PrepareReflectionRecursively((Type)(object)builder, (HashSet<Type>)(object)context);
				object obj7 = JsonReflectionParser.Deserialize(type, builder, context);
				bool flag = obj7 == null;
				result = false;
				if (!flag)
				{
					object obj8 = obj4 + 1;
					obj3 = 0;
					obj4 = obj8;
					continue;
				}
				goto IL_02fa;
			}
			nint num5 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v29 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v37 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int indentation2 = _indentation - 1;
			_indentation = indentation2;
			JsonReflectionParser.PrepareReflectionRecursively((Type)(object)builder, (HashSet<Type>)(object)context);
		}
		StringBuilder stringBuilder3 = builder.AppendLine("]");
		result = true;
		goto IL_02fa;
		IL_02fa:
		return result;
	}

	protected static void SerializeString(string aString, StringBuilder builder)
	{
		//IL_0076: Expected I, but got Obj
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected I, but got Unknown
		//IL_0060: Expected Obj, but got I
		nint num = (nint)builder;
		while (num < aString.m_stringLength)
		{
			string[] anyOf = aString.Split((char[])(object)builder);
			int num2 = " \t\n\r".IndexOfAny((char[])(object)anyOf);
			if (num2 != -1)
			{
				nint num3 = (nint)(builder + 1);
				StringBuilder stringBuilder = (StringBuilder)num3;
				num = num3;
				continue;
			}
			break;
		}
	}

	protected static void SerializeNumber(double number, StringBuilder builder)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	protected static void AppendIndentation(StringBuilder builder, JsonContext context)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_0bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected Obj, but got Unknown
		//IL_0a95: Expected I, but got Obj
		//IL_0aab: Expected Obj, but got I
		//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c28: Expected I4, but got Unknown
		//IL_0c36: Expected Obj, but got I4
		//IL_0b39: Expected I, but got Obj
		//IL_0b4f: Expected Obj, but got I
		//IL_0ad6: Expected I, but got Obj
		//IL_0c86: Expected Obj, but got I4
		//IL_0c98: Expected I4, but got Obj
		//IL_0b22: Expected I4, but got Obj
		//IL_0b7a: Expected I, but got Obj
		StringBuilder stringBuilder = ((StringBuilder)(object)context).AppendLine("\"");
		char[] array = null;
		while (true)
		{
			char[] array2 = array;
			char[] chunkChars = builder.m_ChunkChars;
			if (System.Runtime.CompilerServices.Unsafe.As<char[], UIntPtr>(ref array2) >= System.Runtime.CompilerServices.Unsafe.As<char[], UIntPtr>(ref chunkChars))
			{
				break;
			}
			string[] array3 = ((string)(object)builder).Split(array);
			object obj = (object)array3 << 16;
			object obj2 = obj >> 16;
			object obj3 = obj2 - 8;
			if ((nint)obj2 != 8)
			{
				if ((nint)obj3 != 1)
				{
					if ((nint)obj3 != 2)
					{
						if ((nint)obj3 != 3)
						{
							if ((nint)obj3 == 4)
							{
								StringBuilder stringBuilder2 = ((StringBuilder)(object)context).AppendLine("\\f");
								goto IL_0bd0;
							}
							if ((nint)obj3 == 5)
							{
								StringBuilder stringBuilder3 = ((StringBuilder)(object)context).AppendLine("\\r");
								goto IL_0bd0;
							}
							if ((nint)obj3 != 6 && (nint)obj3 != 7 && (nint)obj3 != 8 && (nint)obj3 != 9 && (nint)obj3 != 10 && (nint)obj3 != 11 && (nint)obj3 != 12 && (nint)obj3 != 13 && (nint)obj3 != 14 && (nint)obj3 != 15 && (nint)obj3 != 16 && (nint)obj3 != 17 && (nint)obj3 != 18 && (nint)obj3 != 19 && (nint)obj3 != 20 && (nint)obj3 != 21 && (nint)obj3 != 22 && (nint)obj3 != 23 && (nint)obj3 != 24 && (nint)obj3 != 25)
							{
								if ((nint)obj3 == 26)
								{
									StringBuilder stringBuilder4 = ((StringBuilder)(object)context).AppendLine("\\\"");
									goto IL_0bd0;
								}
								if ((nint)obj3 != 27 && (nint)obj3 != 28 && (nint)obj3 != 29 && (nint)obj3 != 30 && (nint)obj3 != 31 && (nint)obj3 != 32 && (nint)obj3 != 33 && (nint)obj3 != 34 && (nint)obj3 != 35 && (nint)obj3 != 36 && (nint)obj3 != 37 && (nint)obj3 != 38 && (nint)obj3 != 39 && (nint)obj3 != 40 && (nint)obj3 != 41 && (nint)obj3 != 42 && (nint)obj3 != 43 && (nint)obj3 != 44 && (nint)obj3 != 45 && (nint)obj3 != 46 && (nint)obj3 != 47 && (nint)obj3 != 48 && (nint)obj3 != 49 && (nint)obj3 != 50 && (nint)obj3 != 51 && (nint)obj3 != 52 && (nint)obj3 != 53 && (nint)obj3 != 54 && (nint)obj3 != 55 && (nint)obj3 != 56 && (nint)obj3 != 57 && (nint)obj3 != 58 && (nint)obj3 != 59 && (nint)obj3 != 60 && (nint)obj3 != 61 && (nint)obj3 != 62 && (nint)obj3 != 63 && (nint)obj3 != 64 && (nint)obj3 != 65 && (nint)obj3 != 66 && (nint)obj3 != 67 && (nint)obj3 != 68 && (nint)obj3 != 69 && (nint)obj3 != 70 && (nint)obj3 != 71 && (nint)obj3 != 72 && (nint)obj3 != 73 && (nint)obj3 != 74 && (nint)obj3 != 75 && (nint)obj3 != 76 && (nint)obj3 != 77 && (nint)obj3 != 78 && (nint)obj3 != 79 && (nint)obj3 != 80 && (nint)obj3 != 81 && (nint)obj3 != 82 && (nint)obj3 != 83 && (nint)obj3 == 84)
								{
									StringBuilder stringBuilder5 = ((StringBuilder)(object)context).AppendLine("\\\\");
									goto IL_0bd0;
								}
							}
						}
						nint num = (nint)typeof(Convert);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v28 (Il2CppClass<System.Convert>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num2 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v52 (Il2CppClass<System.Convert>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num3 = array3 & 0xFFFF;
						object obj5 = num3 + -32;
						if ((nint)obj5 <= 94)
						{
							StringBuilder stringBuilder6 = ((StringBuilder)(object)context).Append((int)array3);
						}
						else
						{
							nint num4 = (nint)typeof(Convert);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v37 (Il2CppClass<System.Convert>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num5 = (nint)typeof(Convert);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v46 (Il2CppClass<System.Convert>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							int num6 = Convert.ToBase64_CalculateAndValidateOutputLength(num3, true);
							string text = ((string)num6).PadRight(4, '0');
							string value = string.ConcatArray((string[])(object)"\\u", (int)text);
							StringBuilder stringBuilder7 = ((StringBuilder)(object)context).AppendLine(value);
						}
					}
					else
					{
						StringBuilder stringBuilder8 = ((StringBuilder)(object)context).AppendLine("\\n");
					}
				}
				else
				{
					StringBuilder stringBuilder9 = ((StringBuilder)(object)context).AppendLine("\\t");
				}
			}
			else
			{
				StringBuilder stringBuilder10 = ((StringBuilder)(object)context).AppendLine("\\b");
			}
			goto IL_0bd0;
			IL_0bd0:
			char[] array4 = (char[])(array + 1);
			array = array4;
		}
		StringBuilder stringBuilder11 = ((StringBuilder)(object)context).AppendLine("\"");
	}

	static JsonParser()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A7");
		object obj7 = default;
		object obj6 = obj7;
	}
}
