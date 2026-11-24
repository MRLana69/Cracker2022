using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Json.Internal;
using UnityEngine;

namespace SYBO.Components.Json;

public class JsonDict : Dictionary<string, object>
{
	public static JsonDict EmptyDict
	{
		get
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
			return (JsonDict)(object)JsonParser.GetIndentationString();
		}
	}

	public JsonDict()
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
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
		object obj6 = this + 8;
		object obj7 = default;
		obj6 = obj7;
	}

	public JsonDict(int capacity)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = capacity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonDict)+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonDict)+2C]");
			object obj3 = (nint)0 + (nint)12;
			obj3 = obj2;
		}
		else
		{
			object obj4 = this + 48;
			obj4 = obj2;
		}
		object obj5 = this + 44;
		obj5 = obj2;
	}

	public JsonDict GetDict(string name)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		return (JsonDict)flag;
	}

	public unsafe JsonDict GetOrCreateDict(string name)
	{
		if (TryGetValue(name, out *(object*)null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				JsonDict result = default;
				return result;
			}
		}
		return (JsonDict)(object)JsonList.EmptyList;
	}

	public unsafe JsonList GetList(string name)
	{
		//IL_0069: Expected Obj, but got I
		//IL_0079: Expected Obj, but got I
		//IL_0089: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		if (TryGetValue(name, out *(object*)null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				JsonList result = default;
				return result;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonFieldInfo jsonFieldInfo = default;
		jsonFieldInfo._002Ector();
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S4_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S4_v5+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v61 @ S5_v5 (should have been resolved before IL gen)");
		return (JsonList)(object)jsonFieldInfo;
	}

	public unsafe JsonList GetOrCreateList(string name)
	{
		//IL_004c: Expected Obj, but got I4
		if (TryGetValue(name, out *(object*)null))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
				JsonList result = default;
				return result;
			}
		}
		bool flag = JsonParser.LastDecodeSuccessful();
		return (JsonList)flag;
	}

	public int GetInt(string name, int defaultValue = 0)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0;
	}

	public long GetInt64(string name, long defaultValue = 0L)
	{
		//IL_0010: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0L;
	}

	public float GetFloat(string name, float defaultValue = 0f)
	{
		//IL_03de: Expected I, but got Obj
		//IL_03f4: Expected Obj, but got I
		//IL_0562: Expected I, but got Obj
		//IL_0578: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01cb: Expected I, but got Obj
		//IL_01e1: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0499: Expected I, but got Obj
		//IL_04af: Expected Obj, but got I
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_020c: Expected I, but got Obj
		//IL_0259: Expected I, but got Obj
		//IL_0140: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_02a6: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I
		//IL_0451: Expected Obj, but got I4
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_02e7: Expected I, but got Obj
		//IL_0334: Expected I, but got Obj
		//IL_034a: Expected Obj, but got I
		//IL_01aa: Expected Obj, but got I
		//IL_016f: Expected Obj, but got I4
		//IL_0188: Expected Obj, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_0375: Expected I, but got Obj
		nint num = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<NGUIText>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v87 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v48 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)NGUIText.bitmapFont).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v66 (Il2CppClass<NGUIText>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v81 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int texWidth = NGUIText.bitmapFont.texWidth;
			bool flag = (nint)this == 8201;
			int previousChar = ((!flag) ? ((int)this) : 32);
			int kerning = ((BMGlyph)texWidth).GetKerning(previousChar);
			if (kerning != 0)
			{
				object obj5;
				if (name != null)
				{
					bool flag2 = ((BMSymbol)kerning).Validate((UIAtlas)(object)name);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v74 (System.Int32)+24]");
					object obj4 = (nint)0 >> (flag ? 1 : 0);
					obj5 = flag2 + obj4;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v74 (System.Int32)+24]");
					obj5 = 0;
				}
				return defaultValue * (float)obj5;
			}
			return 0f;
		}
		nint num7 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<NGUIText>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v59 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)NGUIText.dynamicFont).FindKernel((string)null) != 0)
		{
			nint num11 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v26 (Il2CppClass<NGUIText>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num12 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v53 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = this & 0xFFFF;
			nint num13 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S2_v8 (Il2CppClass<NGUIText>)+5C]");
			object obj10 = (nint)0 + (nint)168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11588");
			object obj11 = default;
			if (obj11 != null)
			{
				nint num14 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v37 (Il2CppClass<NGUIText>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num15 = (nint)typeof(NGUIText);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v47 (Il2CppClass<NGUIText>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ArrayTypeMismatchException ex = new ArrayTypeMismatchException();
				float num16 = (float)ex * defaultValue;
				return num16 * NGUIText.pixelDensity;
			}
			return 0f;
		}
		return 0f;
	}

	public double GetDouble(string name, double defaultValue = 0.0)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0.0;
	}

	public unsafe bool GetBool(string name, bool defaultValue = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Ref, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_00e7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		ref object reference = ref *(object*)(obj2 + 8);
		reference = ref *(object*)null;
		obj2 = obj;
		_ = -1;
		if (TryGetValue(name, out reference))
		{
			object obj3 = reference;
			if (reference != null)
			{
				if ((object)obj3.GetType() != typeof(int))
				{
					obj3 = null;
				}
			}
			else
			{
				obj3 = null;
			}
			if (obj3 != null)
			{
				throw new NullReferenceException();
			}
			nint num = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v29 (Il2CppClass<System.Convert>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v79 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj6 = default;
			object obj5 = obj6;
			object obj8 = default;
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj9 = default;
			if (obj7 == obj9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj11 = default;
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj13 = default;
				object obj12 = obj13;
			}
			else
			{
				object obj12 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			bool result = default;
			return result;
		}
		return defaultValue;
	}

	public unsafe string GetString(string name, string defaultValue = "")
	{
		//IL_00cd: Expected Obj, but got I4
		ref object reference = ref *(object*)null;
		if (TryGetValue(name, out reference))
		{
			object obj = reference;
			if (reference != null)
			{
				if ((object)obj.GetType() != typeof(bool))
				{
					obj = null;
				}
			}
			else
			{
				obj = null;
			}
			if (obj != null)
			{
				throw new NullReferenceException();
			}
		}
		bool flag = default;
		return (string)flag;
	}

	public unsafe string Serialize()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected Obj, but got Unknown
		//IL_022f: Expected Obj, but got I4
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected Obj, but got Unknown
		//IL_0252: Expected Obj, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_0107: Expected Obj, but got I4
		//IL_016e: Expected Obj, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		JsonDict jsonDict = default;
		jsonDict._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Json.JsonDict)+8]");
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)null)->Current;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj6 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj7 = obj5 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj5 + obj9;
		obj10 = 78;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj5 + obj11;
			if ((nint)obj12 == 78)
			{
				object obj13 = obj5 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0305;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0305;
		IL_0305:
		return (string)(object)jsonDict;
	}

	public static JsonDict Deserialize(string json)
	{
		return (JsonDict)(object)((JsonClassInfo)(object)json).GetKey((object)null);
	}
}
