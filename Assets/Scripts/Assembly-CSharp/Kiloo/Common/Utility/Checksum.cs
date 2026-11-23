using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class Checksum
{
	public static byte[] ComputeSHA1(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		SHA1 sHA = SHA1.Create();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
					goto IL_0204;
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
		goto IL_0204;
		IL_0204:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static byte[] ComputeMD5(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		MD5 mD = MD5.Create();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
					goto IL_0204;
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
		goto IL_0204;
		IL_0204:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static byte[] ComputeSHA256(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_016d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		SHA256 sHA = SHA256.Create();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
					goto IL_0204;
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
		goto IL_0204;
		IL_0204:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static byte[] ComputeSHA1(string data, Encoding encoding = null)
	{
		//IL_003e: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Encoding encoding2 = default;
		Encoding uTF = default;
		if (encoding2 == null)
		{
			uTF = Encoding.UTF8;
		}
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] data2 = default;
		return ComputeSHA1(data2);
	}

	public static byte[] ComputeMD5(string data, Encoding encoding = null)
	{
		//IL_003e: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Encoding encoding2 = default;
		Encoding uTF = default;
		if (encoding2 == null)
		{
			uTF = Encoding.UTF8;
		}
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] data2 = default;
		return ComputeMD5(data2);
	}

	public static byte[] ComputeSHA256(string data, Encoding encoding = null)
	{
		//IL_003e: Expected I, but got Obj
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Encoding encoding2 = default;
		Encoding uTF = default;
		if (encoding2 == null)
		{
			uTF = Encoding.UTF8;
		}
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v14 @ S2_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] data2 = default;
		return ComputeSHA256(data2);
	}
}
