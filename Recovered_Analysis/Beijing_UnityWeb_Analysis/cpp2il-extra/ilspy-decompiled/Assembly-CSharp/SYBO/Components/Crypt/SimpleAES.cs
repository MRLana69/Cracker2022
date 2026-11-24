using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using SYBO.Components.Json;
using SYBO.Components.Json.Internal;

namespace SYBO.Components.Crypt;

public class SimpleAES : ICrypt
{
	private const int KIVLength = 16;

	private Aes _aes;

	public static byte[] GenerateKey()
	{
		//IL_024e: Expected I, but got Obj
		//IL_0264: Expected Obj, but got I
		//IL_0375: Expected I, but got Obj
		//IL_038b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_02de: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I
		//IL_0130: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0297: Expected Obj, but got I
		//IL_0201: Expected I, but got Obj
		//IL_0350: Expected I4, but got Obj
		//IL_00c7: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_0196: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		nint num = (nint)typeof(JsonParser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v76 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (JsonParser._indentations == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			nint num3 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v59 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num4 = (nint)typeof(JsonParser);
			if (!flag)
			{
				nint num5 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v70 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(JsonParser);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(JsonParser);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ L0_v13 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+5C]");
			object obj3 = (nint)0 + (nint)16;
			obj3 = list;
			JsonParser._indentations.Add("\n");
		}
		bool flag5;
		while (true)
		{
			nint num6 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v49 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<string> indentations = JsonParser._indentations;
			bool flag4 = JsonParser._indentation < indentations._size;
			nint num8 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v11 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			flag5 = obj5 != null;
			if (flag4)
			{
				break;
			}
			if (flag5)
			{
				nint num9 = (nint)typeof(JsonParser);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v43 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			List<string> indentations2 = JsonParser._indentations;
			int index = indentations2._size - 1;
			string values = JsonParser._indentations.get_Item(index);
			string item = string.ConcatArray((string[])(object)values, (int)"\t");
			JsonParser._indentations.Add(item);
		}
		if (flag5)
		{
			nint num10 = (nint)typeof(JsonParser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v32 (Il2CppClass<SYBO.Components.Json.Internal.JsonParser>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte[])(object)JsonParser._indentations.get_Item(JsonParser._indentation);
	}

	public SimpleAES(byte[] key)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0032: Expected Obj, but got I
		//IL_005f: Expected I4, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		object obj = this + 32;
		obj = key;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Crypt.SimpleAES)+1C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Crypt.SimpleAES)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Crypt.SimpleAES)+14]");
		EncryptedCTRStream encryptedCTRStream = default;
		encryptedCTRStream.Write((byte[])num, (int)num2, 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Components.Crypt.SimpleAES)+20]");
		CryptoStream cryptoStream = default;
		cryptoStream.Write((byte[])0, (int)encryptedCTRStream, 0);
		object obj2 = this + 36;
		obj2 = cryptoStream;
	}

	public string Encrypt(string unencrypted)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		((JsonContext)(object)unencrypted).EndSerialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
		string text = default;
		JsonDict dict = ((JsonDict)unencrypted.m_firstChar).GetDict(text);
		string result;
		if (dict != null)
		{
			object obj = ((JsonCustomSerializerCollection)unencrypted.m_firstChar).Deserialize((Type)(object)text, (JsonDict)(object)this, (JsonContext)(object)unencrypted);
			result = (string)obj;
		}
		else
		{
			object obj2 = JsonReflectionParser.RecursiveReadValue((Type)(object)text, (object)this, (JsonContext)(object)unencrypted);
			result = (string)obj2;
		}
		((JsonContext)(object)unencrypted).ResolveKnownReferences();
		return result;
	}

	public string Decrypt(string encrypted)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		byte[] buffer = default;
		byte[] s = Decrypt(buffer);
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v5 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v10 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)Convert.FromBase64String((string)(object)s);
	}

	public byte[] Encrypt(byte[] buffer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v60 (Il2CppClass<System.Convert>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v90 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		byte[] result = default;
		return result;
	}

	public byte[] Decrypt(byte[] buffer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0205: Expected Obj, but got I
		//IL_0231: Expected Obj, but got I4
		//IL_01d3: Expected Obj, but got I4
		//IL_0324: Expected Obj, but got I
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected Obj, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected Obj, but got Unknown
		//IL_0454: Expected Obj, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_04ff: Expected Obj, but got I
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 91;
		object obj7 = 0;
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 == -1)
		{
			if (obj7 != null)
			{
				goto IL_024e;
			}
			obj7 = 0;
		}
		else
		{
			bool flag = obj7 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			bool flag2 = (nint)obj10 != 91;
			object obj11 = flag & flag2;
			if (obj11 != null)
			{
				goto IL_024e;
			}
		}
		goto IL_0650;
		IL_0650:
		object obj12 = default;
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj13 = (nint)0 << 2;
			object obj14 = obj2 + obj13;
			if ((nint)obj14 == 91)
			{
				object obj15 = obj2 + 4;
				if ((nint)obj15 > -1)
				{
					object obj16 = obj15 + -1;
					obj15 = obj16;
				}
				goto IL_06e9;
			}
		}
		object obj17;
		object obj18 = default;
		object obj19;
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj17 = obj18;
			object obj20 = default;
			obj19 = obj20;
			goto IL_05d9;
		}
		goto IL_06e9;
		IL_0672:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj2 + obj21;
			if ((nint)obj22 == 110)
			{
				object obj23 = obj2 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_06f8;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_06f8;
		IL_06e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj26 = obj2 + 4;
		object obj27 = obj26 + 1;
		obj26 = obj27;
		object obj28 = obj27 << 2;
		object obj29 = obj2 + obj28;
		obj29 = 110;
		obj25 = obj7;
		goto IL_0672;
		IL_05d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj30 = default;
		if (obj17 == obj30)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj31 = default;
			obj25 = obj31;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0672;
		IL_024e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		obj17 = obj18;
		object obj32 = default;
		obj19 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj33 = default;
		if (obj17 != obj33)
		{
			goto IL_05d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
		object obj34 = default;
		obj7 = obj34;
		goto IL_0650;
		IL_06f8:
		byte[] result = default;
		return result;
	}

	private unsafe static byte[] Transform(byte[] buffer, ICryptoTransform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0176: Expected Obj, but got I4
		//IL_017f: Expected Obj, but got I4
		//IL_0215: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I4
		//IL_01e3: Expected Obj, but got I4
		//IL_0334: Expected Obj, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_0464: Expected Obj, but got I4
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected Obj, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_0521: Expected Obj, but got I
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int a = default;
		((Array.SorterObjectArray*)transform)->SwapIfGreaterWithItems(a, 16);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [transform @ L1 (System.Security.Cryptography.ICryptoTransform)+C]");
		object obj3 = -16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		object obj4 = obj2 + 4;
		object obj5 = obj4 + 1;
		obj4 = obj5;
		object obj6 = obj5 << 2;
		object obj7 = obj2 + obj6;
		obj7 = 93;
		object obj8 = 0;
		object obj9 = default;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 == -1)
		{
			if (obj8 != null)
			{
				goto IL_025e;
			}
			obj8 = 0;
		}
		else
		{
			bool flag = obj8 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj2 + obj10;
			bool flag2 = (nint)obj11 != 93;
			object obj12 = flag & flag2;
			if (obj12 != null)
			{
				goto IL_025e;
			}
		}
		goto IL_064a;
		IL_064a:
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj2 + obj14;
			if ((nint)obj15 == 93)
			{
				object obj16 = obj2 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				goto IL_06e3;
			}
		}
		object obj18;
		object obj19 = default;
		object obj20;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj18 = obj19;
			object obj21 = default;
			obj20 = obj21;
			goto IL_0471;
		}
		goto IL_06e3;
		IL_066c:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj22 = (nint)0 << 2;
			object obj23 = obj2 + obj22;
			if ((nint)obj23 == 113)
			{
				object obj24 = obj2 + 4;
				if ((nint)obj24 > -1)
				{
					object obj25 = obj24 + -1;
					obj24 = obj25;
				}
				goto IL_06f2;
			}
		}
		object obj26 = default;
		if (obj26 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_06f2;
		IL_06e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj27 = obj2 + 4;
		object obj28 = obj27 + 1;
		obj27 = obj28;
		object obj29 = obj28 << 2;
		object obj30 = obj2 + obj29;
		obj30 = 113;
		obj26 = obj8;
		goto IL_066c;
		IL_0471:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj31 = default;
		if (obj18 == obj31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj32 = default;
			obj26 = obj32;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_066c;
		IL_025e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		obj18 = obj19;
		object obj33 = default;
		obj20 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj34 = default;
		if (obj18 != obj34)
		{
			goto IL_0471;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
		object obj35 = default;
		obj8 = obj35;
		goto IL_064a;
		IL_06f2:
		byte[] result = default;
		return result;
	}
}
