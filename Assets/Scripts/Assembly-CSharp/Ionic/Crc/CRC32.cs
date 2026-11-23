using System;
using System.IO;
using Cpp2ILInjected;

namespace Ionic.Crc;

public class CRC32
{
	private uint dwPolynomial;

	private long _TotalBytesRead;

	private bool reverseBits;

	private uint[] crc32Table;

	private const int BUFFER_SIZE = 8192;

	private uint _register;

	public long TotalBytesRead => _TotalBytesRead;

	public int Crc32Result => (int)_register ^ -1;

	public CRC32()
		: this(reverseBits: false)
	{
	}

	public CRC32(bool reverseBits)
		: this(-306674912, reverseBits)
	{
	}

	public CRC32(int polynomial, bool reverseBits)
	{
		_register = uint.MaxValue;
		dwPolynomial = (uint)polynomial;
		this.reverseBits = reverseBits;
		GenerateLookupTable();
	}

	public int GetCrc32(Stream input)
	{
		return GetCrc32AndCopy(input, null);
	}

	public int GetCrc32AndCopy(Stream input, Stream output)
	{
		//IL_001a: Expected I8, but got I4
		//IL_0022: Expected I, but got Obj
		//IL_010f: Expected I4, but got Obj
		//IL_0051: Expected I, but got Obj
		//IL_007b: Expected I, but got Obj
		//IL_00aa: Expected I, but got Obj
		if (input != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			_TotalBytesRead = 0L;
			nint num = (nint)input;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S4_v2 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
			if (output != null)
			{
				nint num2 = (nint)output;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v44 @ S4_v15 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
			}
			int num4 = default;
			long num3 = _TotalBytesRead + num4;
			long totalBytesRead = num3;
			int num5 = num4;
			byte[] block = default;
			int num9 = default;
			while (true)
			{
				_TotalBytesRead = totalBytesRead;
				if (num5 <= 0)
				{
					break;
				}
				SlurpBlock(block, 0, num5);
				nint num6 = (nint)input;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S4_v8 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
				if (output != null)
				{
					nint num7 = (nint)output;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v144 @ S4_v12 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
				}
				long num8 = _TotalBytesRead + num9;
				totalBytesRead = num8;
				num5 = num9;
			}
			return (int)_register ^ -1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Exception ex = default;
		ex._002Ector("The input stream must not be null.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex;
	}

	public int ComputeCrc32(int W, byte B)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		int num = W & 0xFF;
		int num2 = num ^ B;
		int num3 = num2 << 2;
		object obj = crc32Table + num3;
		int num4 = W >> 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v3+10]");
		return (int)((nint)0 ^ (nint)num4);
	}

	internal int _InternalComputeCrc32(uint W, byte B)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		int num = (int)(W & 0xFF);
		int num2 = num ^ B;
		int num3 = num2 << 2;
		object obj = crc32Table + num3;
		int num4 = (int)W >> 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v3+10]");
		return (int)((nint)0 ^ (nint)num4);
	}

	public void SlurpBlock(byte[] block, int offset, int count)
	{
		//IL_0022: Expected I, but got Obj
		//IL_0075: Expected Obj, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		nint num = default;
		Exception ex = default;
		if (block != null)
		{
			num = unchecked((nint)null);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("The data buffer must not be null.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		while (count > num)
		{
			object obj = offset + num;
			object obj2 = obj + (object)block;
			int register;
			if (~(((CRC32)(object)ex).reverseBits ? 1u : 0u) == 0)
			{
				int num2 = (int)((CRC32)(object)ex)._register >> 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v8+10]");
				int num3 = (int)((nint)num2 ^ (nint)0);
				int num4 = num3 << 2;
				object obj3 = ((CRC32)(object)ex).crc32Table + num4;
				int num5 = (int)(((CRC32)(object)ex)._register << 8);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v19+10]");
				register = (int)((nint)0 ^ (nint)num5);
			}
			else
			{
				int num6 = (int)(((CRC32)(object)ex)._register & 0xFF);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v8+10]");
				int num7 = (int)((nint)num6 ^ (nint)0);
				int num8 = num7 << 2;
				object obj4 = ((CRC32)(object)ex).crc32Table + num8;
				int num9 = (int)((CRC32)(object)ex)._register >> 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v14+10]");
				register = (int)((nint)0 ^ (nint)num9);
			}
			((CRC32)(object)ex)._register = (uint)register;
			nint num10 = num + 1;
			num = num10;
		}
		long totalBytesRead = ((CRC32)(object)ex)._TotalBytesRead + count;
		((CRC32)(object)ex)._TotalBytesRead = totalBytesRead;
	}

	public void UpdateCRC(byte b)
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		int register;
		if (~(reverseBits ? 1u : 0u) == 0)
		{
			int num = (int)_register >> 24;
			int num2 = num ^ b;
			int num3 = num2 << 2;
			object obj = crc32Table + num3;
			int num4 = (int)(_register << 8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v11+10]");
			register = (int)((nint)0 ^ (nint)num4);
		}
		else
		{
			int num5 = (int)(_register & 0xFF);
			int num6 = num5 ^ b;
			int num7 = num6 << 2;
			object obj2 = crc32Table + num7;
			int num8 = (int)_register >> 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v6+10]");
			register = (int)((nint)0 ^ (nint)num8);
		}
		_register = (uint)register;
	}

	public void UpdateCRC(byte b, int n)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		int num = default;
		while (true)
		{
			bool flag = num > 0;
			num--;
			if (flag)
			{
				int num2 = (int)_register >> 24;
				int num3 = (int)(_register & 0xFF);
				if (!reverseBits)
				{
					num2 = num3;
				}
				int num4 = num2 ^ b;
				int num5 = num4 << 2;
				object obj = crc32Table + num5;
				int num6 = (int)(_register << 8);
				int num7 = (int)_register >> 8;
				if (!reverseBits)
				{
					num6 = num7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v6+10]");
				int register = (int)((nint)0 ^ (nint)num6);
				_register = (uint)register;
				continue;
			}
			break;
		}
	}

	private static uint ReverseBits(uint data)
	{
		int num = (int)(data << 1);
		int num2 = num & -1431655766;
		int num3 = (int)data >> 1;
		int num4 = num3 & 0x55555555;
		int num5 = num2 | num4;
		int num6 = num5 << 2;
		int num7 = num6 & -858993460;
		int num8 = num5 >> 2;
		int num9 = num8 & 0x33333333;
		int num10 = num7 | num9;
		int num11 = num10 << 4;
		int num12 = num11 & -252645136;
		int num13 = num10 >> 4;
		int num14 = num13 & 0xF0F0F0F;
		int num15 = num12 | num14;
		int num16 = num15 << 8;
		int num17 = num16 & 0xFF0000;
		int num18 = num15 << 24;
		int num19 = num17 | num18;
		int num20 = num15 >> 8;
		int num21 = num20 & 0xFF00;
		int num22 = num19 | num21;
		int num23 = num15 >> 24;
		return (uint)(num22 | num23);
	}

	private static byte ReverseBits(byte data)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0061: Expected I4, but got Obj
		object obj = data * 131586;
		object obj2 = obj & 0x1044010;
		object obj3 = obj << 2;
		object obj4 = obj3 & 0x2088020;
		object obj5 = obj2 + obj4;
		object obj6 = obj5 * 16781313;
		return (byte)(obj6 >> 24);
	}

	private void GenerateLookupTable()
	{
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected I4, but got Unknown
		//IL_01fd: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_01a5: Expected Obj, but got I4
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		uint[] array = default;
		crc32Table = array;
		object obj = default;
		object obj16;
		do
		{
			uint num = (uint)(obj & 0xFF);
			uint num2 = num;
			object obj2 = 8;
			while (obj2 != null)
			{
				int num4;
				if ((num2 & 1) != 0)
				{
					int num3 = (int)num2 >> 1;
					num4 = (int)dwPolynomial ^ num3;
				}
				else
				{
					num4 = (int)num2 >> 1;
				}
				object obj3 = obj2 - 1;
				object obj4 = obj3 & 0xFF;
				num2 = (uint)num4;
				obj2 = obj4;
			}
			if (~(reverseBits ? 1u : 0u) == 0)
			{
				object obj5 = obj & 0xFF;
				object obj6 = obj5 * 131586;
				object obj7 = obj6 & 0x1044010;
				object obj8 = obj6 << 2;
				object obj9 = obj8 & 0x2088020;
				object obj10 = obj7 + obj9;
				object obj11 = obj10 * 16781313;
				object obj12 = obj11 >> 24;
				object obj13 = obj12 << 2;
				object obj14 = (object)crc32Table + obj13;
				uint num5 = ReverseBits(num2);
			}
			else
			{
				int num6 = (int)(num << 2);
				object obj15 = crc32Table + num6;
			}
			obj = num + 1;
			obj16 = obj & 0xFF;
		}
		while (obj16 != null);
	}

	private uint gf2_matrix_times(uint[] matrix, uint vec)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		uint num = 0u;
		object obj = 0;
		int num2 = default;
		uint num7 = default;
		while (num2 != 0)
		{
			int num3 = num2 & 1;
			bool flag = num3 == 0;
			int num4 = (int)num;
			if (!flag)
			{
				object obj2 = obj << 2;
				object obj3 = (object)matrix + obj2;
				uint num5 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v7+10]");
				int num6 = (int)((nint)(int)num5 ^ (nint)0);
				num4 = num6;
			}
			num2 = (int)num7 >> 1;
			object obj4 = obj + 1;
			num = (uint)num4;
			obj = obj4;
		}
		return num;
	}

	private void gf2_matrix_square(uint[] square, uint[] mat)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		CRC32 cRC = null;
		while ((nint)cRC < 32)
		{
			object obj = (object)cRC << 2;
			object obj2 = (object)square + obj;
			object obj3 = (object)cRC << 2;
			object obj4 = (object)mat + obj3;
			CRC32 cRC2 = cRC;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v3+10]");
			uint num = cRC2.gf2_matrix_times(mat, 0u);
			CRC32 cRC3 = (CRC32)(cRC + 1);
			cRC = cRC3;
		}
	}

	public void Combine(int crc, int length)
	{
		//IL_0022: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0231: Expected I4, but got Obj
		//IL_00b9: Expected I4, but got Obj
		//IL_00db: Expected Obj, but got I4
		//IL_01ed: Expected Obj, but got I4
		//IL_0117: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int num = default;
		if (num == 0)
		{
			return;
		}
		uint[] array = default;
		array[0] = dwPolynomial;
		CRC32 cRC = (CRC32)1;
		while ((nint)cRC < 32)
		{
			object obj = (object)cRC << 2;
			object obj2 = (object)array + obj;
			_ = 1;
			CRC32 cRC2 = (CRC32)(cRC + 1);
			cRC = cRC2;
		}
		uint[] array2 = default;
		cRC.gf2_matrix_square(array2, array);
		cRC.gf2_matrix_square(array, array2);
		int num2 = (int)_register ^ -1;
		CRC32 cRC3 = (CRC32)num2;
		int num4 = default;
		uint num5;
		do
		{
			cRC3.gf2_matrix_square(array2, array);
			int num3 = num4 & 1;
			bool flag = num3 == 0;
			num5 = (uint)(int)cRC3;
			if (!flag)
			{
				uint num6 = cRC3.gf2_matrix_times(array2, (uint)(int)cRC3);
				num5 = num6;
			}
			if (num4 < 2)
			{
				break;
			}
			((CRC32)num5).gf2_matrix_square(array, array2);
			if ((num4 & 2) != 0)
			{
				uint num7 = ((CRC32)num5).gf2_matrix_times(array, num5);
				num5 = num7;
			}
			num4 = num >> 2;
			cRC3 = (CRC32)num5;
		}
		while (num4 != 0);
		int num8 = crc ^ (int)num5;
		int register = num8 ^ -1;
		_register = (uint)register;
	}

	public void Reset()
	{
		_register = uint.MaxValue;
	}
}
