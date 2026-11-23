using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal class SharedUtils
{
	public static int URShift(int number, int bits)
	{
		return number >> bits;
	}

	public static int ReadInput(TextReader sourceTextReader, byte[] target, int start, int count)
	{
		//IL_0017: Expected I, but got Obj
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_00f4: Expected Obj, but got I4
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		bool flag = target.Length == 0;
		int result = 0;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			nint num = (nint)sourceTextReader;
			object obj = sourceTextReader + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S4_v3 (Il2CppClass<System.IO.TextReader>)+114] (should have been resolved before IL gen)");
			int num2 = default;
			if (num2 == 0)
			{
				return -1;
			}
			int num3 = start;
			object obj5 = default;
			while (true)
			{
				object obj2 = start + num2;
				bool flag2 = num3 >= (nint)obj2;
				result = num2;
				if (flag2)
				{
					break;
				}
				object obj3 = num3 + target;
				int num4 = num3 << 1;
				object obj4 = obj5 + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v11+10]");
				_ = 0;
				int num5 = num3 + 1;
				num3 = num5;
			}
		}
		return result;
	}

	internal static byte[] ToByteArray(string sourceString)
	{
		//IL_0011: Expected I, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		object obj = uTF + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		byte[] result = default;
		return result;
	}

	internal static char[] ToCharArray(byte[] byteArray)
	{
		//IL_0011: Expected I, but got Obj
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		object obj = uTF + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v6 @ S2_v2 (Il2CppClass<System.Text.Encoding>)+194] (should have been resolved before IL gen)");
		char[] result = default;
		return result;
	}
}
