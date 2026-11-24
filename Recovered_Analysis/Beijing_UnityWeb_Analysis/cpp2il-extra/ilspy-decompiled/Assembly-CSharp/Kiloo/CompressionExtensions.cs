using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;

namespace Kiloo;

public static class CompressionExtensions
{
	private static string DEBUG_TAG;

	public static byte[] Compress(byte[] source, string signature)
	{
		//IL_0027: Expected I4, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		byte[] array = default;
		array[0] = (byte)(int)source;
		object obj = array + 20;
		obj = signature;
		return array;
	}

	public static byte[] Decompress(byte[] source, string expectedSignature)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06b7: Expected Obj, but got I
		//IL_05a3: Expected Obj, but got I
		//IL_05cf: Expected Obj, but got I4
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected Obj, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		byte[] array = null;
		object obj4 = default;
		object obj3 = obj4;
		object obj6 = default;
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj7 = default;
		byte[] result = default;
		object obj14 = default;
		if (obj5 == obj7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj9 = default;
			object obj8 = obj9;
			object obj10 = default;
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 == -1)
			{
				if (obj8 == null)
				{
					result = array;
					goto IL_08be;
				}
			}
			else
			{
				bool flag = obj8 != null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj2 + obj11;
				bool flag2 = (nint)obj12 != 119;
				object obj13 = flag & flag2;
				if (obj13 == null)
				{
					obj14 = obj8;
					result = array;
					goto IL_08be;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj15 = default;
			obj3 = obj15;
			obj5 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj16 = default;
		if (obj5 == obj16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj17 = default;
			obj14 = obj17;
			result = array;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_08be;
		IL_099d:
		return result;
		IL_08be:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj2 + obj18;
			if ((nint)obj19 == 119)
			{
				object obj20 = obj2 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_099d;
			}
		}
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_099d;
	}

	public static string ToContentString<T>(IEnumerable<T> collection, string separator = ", ")
	{
		//IL_0009: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I
		object result = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		if (separator != null)
		{
			nint num = default;
			object obj = num + 24;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			object obj3 = default;
			if (obj3 == null)
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			}
		}
		return (string)result;
	}

	private static void Log(string msg)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private static void LogWarning(string msg)
	{
	}

	private static void LogError(string msg)
	{
	}
}
