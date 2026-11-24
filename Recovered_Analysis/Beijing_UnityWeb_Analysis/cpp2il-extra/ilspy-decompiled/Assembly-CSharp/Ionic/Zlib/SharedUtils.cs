using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace Ionic.Zlib;

internal class SharedUtils
{
	public static int URShift(int number, int bits)
	{
		int num = 0;
		int num2 = default;
		int num5;
		int num6 = default;
		while (true)
		{
			num2 >>= 1;
			int num3 = num2 & 1;
			int num4 = num3 | num;
			num5 = num4 << 1;
			num6--;
			if (num6 < 1)
			{
				break;
			}
			num = num5;
		}
		return num5 >> 1;
	}

	public static int ReadInput(TextReader sourceTextReader, byte[] target, int start, int count)
	{
		//IL_0081: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sourceTextReader @ L0 (System.IO.TextReader)+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("GZipStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sourceTextReader @ L0 (System.IO.TextReader)+31]");
		if ((nint)0 == 0)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sourceTextReader @ L0 (System.IO.TextReader)+2C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v6+48]");
			((GZipStream)(object)sourceTextReader).FlushMode = FlushType.None;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sourceTextReader @ L0 (System.IO.TextReader)+2C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v9+4C]");
			((GZipStream)(object)sourceTextReader).FileName = (string)0;
		}
		int result = default;
		return result;
	}

	internal static byte[] ToByteArray(string sourceString)
	{
		//IL_00df: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0092: Expected I, but got Obj
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected Obj, but got Unknown
		//IL_002c: Expected I, but got Obj
		nint num = (nint)typeof(Tree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj != null;
		object obj5;
		if ((nint)sourceString > 255)
		{
			if (flag)
			{
				nint num2 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v37 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = (object)sourceString >> 7;
			object obj3 = (object)Tree._dist_code + obj2;
			object obj4 = obj3 + 272;
			obj5 = obj4;
		}
		else
		{
			if (flag)
			{
				nint num3 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v23 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = Tree._dist_code + 16;
			object obj7 = obj6 + sourceString;
			obj5 = obj7;
		}
		object obj8 = obj5 << 24;
		return (byte[])(obj8 >> 24);
	}

	internal static char[] ToCharArray(byte[] byteArray)
	{
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		char[] result = default;
		return result;
	}

	public SharedUtils()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Exception.ReportUnhandledException((Exception)(object)this);
	}
}
