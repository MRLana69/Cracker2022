using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;

namespace SYBO.Components.Crypt;

public class SimpleAES : ICrypt
{
	private const int KIVLength = 16;

	private Aes _aes;

	public SimpleAES(byte[] key)
	{
		//IL_002a: Expected I, but got Obj
		//IL_0046: Expected I, but got Obj
		//IL_0062: Expected I, but got Obj
		AesManaged aesManaged = default;
		aesManaged._002Ector();
		_aes = aesManaged;
		Aes aes = _aes;
		nint num = (nint)aes;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S2_v2 (Il2CppClass<System.Security.Cryptography.Aes>)+11C] (should have been resolved before IL gen)");
		Aes aes2 = _aes;
		nint num2 = (nint)aes2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v35 @ S2_v5 (Il2CppClass<System.Security.Cryptography.Aes>)+144] (should have been resolved before IL gen)");
		Aes aes3 = _aes;
		nint num3 = (nint)aes3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S2_v8 (Il2CppClass<System.Security.Cryptography.Aes>)+154] (should have been resolved before IL gen)");
	}

	public static byte[] GenerateKey()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		AesManaged aesManaged = default;
		aesManaged._002Ector();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 != 1;
		byte[] array = default;
		byte[] result = array;
		object obj4 = obj;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj5 = default;
			object obj6 = default;
			bool flag2 = obj5 == obj6;
			bool flag3 = !flag2;
			byte[] array3 = default;
			byte[] array2 = array3;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				result = null;
				obj4 = obj;
				if (flag4)
				{
					goto IL_0209;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				byte[] array4 = default;
				array2 = array4;
			}
			_ = 0;
			object obj7 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return array2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
		}
		goto IL_0209;
		IL_0209:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public string Encrypt(string unencrypted)
	{
		//IL_0028: Expected I, but got Obj
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S3_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] buffer = default;
		byte[] inArray = Encrypt(buffer);
		return Convert.ToBase64String(inArray);
	}

	public string Decrypt(string encrypted)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected Obj, but got Unknown
		//IL_040b: Expected Obj, but got I
		//IL_0436: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected Obj, but got Unknown
		//IL_036f: Expected Obj, but got I
		//IL_01e7: Expected I, but got Obj
		//IL_028f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		string result;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
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
						bool flag = (nint)0 != 1;
						string text = default;
						result = text;
						if (flag)
						{
							goto IL_03f0;
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
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj4 = default;
		object obj5 = default;
		bool flag2 = obj4 != obj5;
		string text3 = default;
		string text2 = text3;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				string text4 = default;
				nint num = (nint)text4;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					text2 = text4;
					object obj6 = default;
					if (obj6 != null)
					{
						goto IL_03f5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj7 = text4;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					result = (string)0;
					if (flag3)
					{
						goto IL_03f0;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			string text5 = default;
			text2 = text5;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				result = text5;
				goto IL_03f0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_03f5;
		IL_03f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj8 = (nint)0 << 2;
		object obj9 = obj3 + obj8;
		obj9 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj10 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj11 = (nint)0 << 2;
		object obj12 = obj11 + obj3;
		object innerException = obj12 - 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		DecryptionException ex = default;
		ex._002Ector("Failed to decrypt message", (Exception)innerException);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
		object obj13 = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (string)(object)ex;
		IL_03f0:
		return result;
	}

	public byte[] Encrypt(byte[] buffer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0625: Expected I, but got Obj
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected Obj, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_05c0: Expected Obj, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected Obj, but got Unknown
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected Obj, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_03d9: Expected Obj, but got I4
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected Obj, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected Obj, but got Unknown
		//IL_0272: Expected Obj, but got I4
		//IL_027b: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Aes aes = _aes;
		nint num = (nint)aes;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S1_v6 (Il2CppClass<System.Security.Cryptography.Aes>)+184] (should have been resolved before IL gen)");
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj3 = obj + 44;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj6;
		object obj7;
		byte[] result;
		byte[] array3;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj4 = obj + 40;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
							object obj5 = obj + 36;
							obj = obj5;
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 != 1;
							obj6 = 2;
							obj7 = 0;
							if (flag)
							{
								goto IL_02e9;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
							byte[] array = default;
							object obj8 = default;
							bool flag2 = array == obj8;
							bool flag3 = !flag2;
							byte[] array2 = default;
							result = array2;
							array3 = array;
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag4 = (nint)0 != 1;
								obj6 = 0;
								obj7 = 1;
								if (flag4)
								{
									goto IL_02e9;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
								byte[] array4 = default;
								result = array4;
								byte[] array5 = default;
								array3 = array5;
							}
							_ = 0;
							object obj9 = obj + 8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 == 1)
							{
								goto IL_05ce;
							}
							goto IL_06c4;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					goto IL_0362;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_04db;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_04db;
		IL_0790:
		object obj10 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return array3;
		IL_02e9:
		_ = 0;
		object obj11 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj7 != null)
			{
				goto IL_03d0;
			}
			goto IL_06ed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0362;
		IL_0362:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		byte[] array6 = default;
		result = array6;
		byte[] array7 = default;
		array3 = array7;
		goto IL_06c4;
		IL_06ed:
		_ = 0;
		object obj12 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj6 == null)
			{
				goto IL_0486;
			}
			bool flag5 = (nint)obj6 == 1;
			array3 = null;
			if (!flag5)
			{
				if ((nint)obj6 == 2)
				{
					goto IL_0486;
				}
				array3 = null;
			}
			goto IL_0790;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_04db;
		IL_04db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		byte[] array8 = default;
		result = array8;
		byte[] array9 = default;
		array3 = array9;
		goto IL_07ad;
		IL_06c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj13 = default;
		if (obj13 == array3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_03d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array10 = default;
			result = array10;
			byte[] array11 = default;
			array3 = array11;
		}
		_ = 0;
		object obj14 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			goto IL_05ce;
		}
		goto IL_07ad;
		IL_07ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj15 = default;
		if (obj15 == array3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			array3 = null;
			if (flag6)
			{
				goto IL_0790;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array12 = default;
			result = array12;
		}
		_ = 0;
		object obj16 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag7 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		array3 = (byte[])0;
		if (!flag7)
		{
			goto IL_05ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
		IL_05ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_0790;
		IL_0486:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag8 = (nint)0 != 1;
		byte[] array13 = default;
		array3 = array13;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_04db;
		}
		goto IL_0790;
		IL_03d0:
		obj6 = 0;
		goto IL_06ed;
	}

	public byte[] Decrypt(byte[] buffer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0623: Expected I, but got Obj
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_05a2: Expected Obj, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_016c: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I4
		//IL_01ae: Expected Obj, but got I4
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected Obj, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I4
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected Obj, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected Obj, but got Unknown
		//IL_0263: Expected Obj, but got I4
		//IL_026c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Array destinationArray = default;
		Array.Copy(buffer, destinationArray, 16);
		Aes aes = _aes;
		nint num = (nint)aes;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S2_v4 (Il2CppClass<System.Security.Cryptography.Aes>)+10C] (should have been resolved before IL gen)");
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj3 = obj + 44;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		object obj7;
		object obj8;
		byte[] result;
		byte[] array3;
		if ((nint)0 != 1)
		{
			object obj4 = obj + 40;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
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
					object obj5 = obj + 36;
					obj = obj5;
					_ = 0;
					object obj6 = buffer.Length - 16;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					obj7 = 2;
					obj8 = 0;
					if (flag)
					{
						goto IL_02cb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
					byte[] array = default;
					object obj9 = default;
					bool flag2 = array == obj9;
					bool flag3 = !flag2;
					byte[] array2 = default;
					result = array2;
					array3 = array;
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag4 = (nint)0 != 1;
						obj7 = 0;
						obj8 = 1;
						if (flag4)
						{
							goto IL_02cb;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						byte[] array4 = default;
						result = array4;
						byte[] array5 = default;
						array3 = array5;
					}
					_ = 0;
					object obj10 = obj + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						goto IL_05b0;
					}
					goto IL_067e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_0344;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_04bd;
		IL_06a7:
		_ = 0;
		object obj11 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj7 == null)
			{
				goto IL_0468;
			}
			bool flag5 = (nint)obj7 == 1;
			array3 = null;
			if (!flag5)
			{
				if ((nint)obj7 == 2)
				{
					goto IL_0468;
				}
				array3 = null;
			}
			goto IL_074a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_04bd;
		IL_04bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		byte[] array6 = default;
		result = array6;
		byte[] array7 = default;
		array3 = array7;
		goto IL_0767;
		IL_067e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj12 = default;
		if (obj12 == array3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_03b2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array8 = default;
			result = array8;
			byte[] array9 = default;
			array3 = array9;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			goto IL_05b0;
		}
		goto IL_0767;
		IL_0767:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj14 = default;
		if (obj14 == array3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag6 = (nint)0 != 1;
			array3 = null;
			if (flag6)
			{
				goto IL_074a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array10 = default;
			result = array10;
		}
		_ = 0;
		object obj15 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag7 = (nint)0 != 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		array3 = (byte[])0;
		if (!flag7)
		{
			goto IL_05b0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
		IL_05b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_074a;
		IL_0468:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag8 = (nint)0 != 1;
		byte[] array11 = default;
		array3 = array11;
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			goto IL_04bd;
		}
		goto IL_074a;
		IL_03b2:
		obj7 = 0;
		goto IL_06a7;
		IL_02cb:
		_ = 0;
		object obj16 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			if (obj8 != null)
			{
				goto IL_03b2;
			}
			goto IL_06a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0344;
		IL_074a:
		object obj17 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return array3;
		IL_0344:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		byte[] array12 = default;
		result = array12;
		byte[] array13 = default;
		array3 = array13;
		goto IL_067e;
	}

	private static byte[] Transform(byte[] buffer, ICryptoTransform transform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_020f: Expected I, but got Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		CryptoStream cryptoStream = default;
		cryptoStream._002Ector(memoryStream, transform, CryptoStreamMode.Write);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj4 = default;
			object obj5 = default;
			bool flag = obj4 == obj5;
			bool flag2 = !flag;
			byte[] array = default;
			byte[] result = array;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01ef;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				byte[] array2 = default;
				result = array2;
			}
			_ = 0;
			object obj6 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		goto IL_01ef;
		IL_01ef:
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		nint num = (nint)memoryStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ S1_v18 (Il2CppClass<System.IO.MemoryStream>)+1FC] (should have been resolved before IL gen)");
		byte[] result2 = default;
		return result2;
	}
}
