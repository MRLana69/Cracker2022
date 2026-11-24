using System;
using System.IO;
using Cpp2ILInjected;
using Ionic.Crc;

namespace Kiloo.Common.Utility;

public static class KRandom
{
	private static Random _internalRandom;

	private static Random random
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int nextTicket = Depository._nextTicket + 1;
			Depository._nextTicket = nextTicket;
			return (Random)Depository._nextTicket;
		}
	}

	public static float Range(float min, float max)
	{
		//IL_0077: Expected F4, but got I4
		//IL_00b0: Expected F4, but got I4
		//IL_00e9: Expected F4, but got I4
		if (max == 0f)
		{
			return min;
		}
		float num = min / max;
		if (num != num)
		{
			num = -2.1474836E+09f;
		}
		else if (!(num < 2.1474836E+09f))
		{
			num = -2.1474836E+09f;
		}
		else if (!(num > -2.1474836E+09f))
		{
			num = -2.1474836E+09f;
		}
		return num * max;
	}

	public static int Range(int min, int max)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		//IL_0096: Expected Obj, but got I4
		//IL_01f0: Expected Obj, but got I
		//IL_021c: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 50;
		object obj7 = 0;
		int num2 = default;
		int num = num2;
		object obj8 = default;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		int result = default;
		object obj12 = default;
		if ((nint)0 == -1)
		{
			if (obj7 == null)
			{
				result = num;
				goto IL_0430;
			}
		}
		else
		{
			bool flag = obj7 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			bool flag2 = (nint)obj10 != 50;
			object obj11 = flag & flag2;
			if (obj11 == null)
			{
				obj12 = obj7;
				result = num;
				goto IL_0430;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj14 = default;
		object obj13 = obj14;
		object obj16 = default;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj17 = default;
		if (obj15 == obj17)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj18 = default;
			obj12 = obj18;
			result = num;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0430;
		IL_0430:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj2 + obj19;
			if ((nint)obj20 == 50)
			{
				object obj21 = obj2 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_04ab;
			}
		}
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04ab;
		IL_04ab:
		return result;
	}

	private static double NextTriangularDouble(double min, double max, double mean)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0.0;
	}

	public static int RangeTriangle(int min, int max, int mean)
	{
		//IL_0045: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CRC32 cRC = default;
		cRC.Reset();
		((CrcCalculatorStream)(object)cRC).Write((byte[])min, max, mean);
		return (int)cRC._register ^ -1;
	}

	public static float RangeTriangle(float min, float max, float mean)
	{
		float num = min * mean;
		float num2 = max * mean;
		return num - num2;
	}
}
