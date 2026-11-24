using System.IO;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;

namespace Kiloo.Common.Utility;

public static class Checksum
{
	public static byte[] ComputeSHA1(byte[] data)
	{
		//IL_0015: Expected Obj, but got I
		//IL_0022: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ L0 (System.Byte[])+8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+C]");
		return (byte[])0;
	}

	public static byte[] ComputeMD5(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		SHA256 sHA = SHA256.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 26;
		if (sHA != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 26)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_020e;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_020e;
		IL_020e:
		byte[] result = default;
		return result;
	}

	public static byte[] ComputeSHA256(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 26;
		if (randomNumberGenerator != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 26)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_020e;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_020e;
		IL_020e:
		byte[] result = default;
		return result;
	}

	public static byte[] ComputeSHA1(string data, Encoding encoding = null)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		byte[] result = default;
		return result;
	}

	public static byte[] ComputeMD5(string data, Encoding encoding = null)
	{
		if (encoding != null)
		{
			Encoding encoding2 = encoding;
		}
		else
		{
			Encoding encoding2 = Encoding.UTF32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		byte[] data2 = default;
		return ComputeMD5(data2);
	}

	public static byte[] ComputeSHA256(string data, Encoding encoding = null)
	{
		if (encoding != null)
		{
			Encoding encoding2 = encoding;
		}
		else
		{
			Encoding encoding2 = Encoding.UTF32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		byte[] data2 = default;
		return ComputeSHA256(data2);
	}

	public static int ComputeCrc32(byte[] data)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		SHA384 sHA = SHA384.Create();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 26;
		if (sHA != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 26)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				goto IL_020e;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_020e;
		IL_020e:
		int result = default;
		return result;
	}

	public static int ComputeCrc32(byte[] data, int offset, int length)
	{
		return 0;
	}

	public static int ComputeCrc32(Stream stream)
	{
		//IL_0017: Expected I4, but got Obj
		//IL_0017: Expected I4, but got Obj
		return KRandom.RangeTriangle((int)stream, 0, (int)stream._activeReadWriteTask);
	}
}
