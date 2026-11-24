using System;
using System.IO;
using Cpp2ILInjected;
using Ionic.Zlib;
using SYBO.Subway.Info;
using UI;
using WordHunt;

namespace Ionic.Crc;

public class CRC32
{
	private uint dwPolynomial;

	private long _TotalBytesRead;

	private bool reverseBits;

	private uint[] crc32Table;

	private const int BUFFER_SIZE = 8192;

	private uint _register;

	public long TotalBytesRead
	{
		get
		{
			//IL_0010: Expected Obj, but got I
			//IL_0020: Expected Obj, but got I
			//IL_00c8: Expected Obj, but got I
			//IL_00d8: Expected I8, but got I
			//IL_00b3: Expected I8, but got I4
			//IL_0085: Expected Obj, but got I
			//IL_0095: Expected Obj, but got I
			//IL_00a5: Expected I8, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+14]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+14]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v4+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+18]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+14]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v16+14]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17+18]");
					return 0L;
				}
				return 0L;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+14]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v8+30]");
			return 0L;
		}
	}

	public int Crc32Result
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0215: Expected I4, but got Obj
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_009d: Expected Obj, but got I4
			//IL_00a6: Expected Obj, but got I4
			//IL_0149: Expected Obj, but got I
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected Obj, but got Unknown
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			MemoryStream memoryStream = default;
			memoryStream.Dispose((byte)(int)this != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj3 = obj2 + 4;
			object obj4 = obj3 + 1;
			obj3 = obj4;
			object obj5 = obj4 << 2;
			object obj6 = obj2 + obj5;
			obj6 = 35;
			object obj7 = 0;
			if (memoryStream != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				object obj8 = (nint)0 << 2;
				object obj9 = obj2 + obj8;
				if ((nint)obj9 == 35)
				{
					object obj10 = obj2 + 4;
					if ((nint)obj10 > -1)
					{
						object obj11 = obj10 + -1;
						obj10 = obj11;
					}
					goto IL_0277;
				}
			}
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0277;
			IL_0277:
			int result = default;
			return result;
		}
	}

	public int GetCrc32(Stream input)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_0091: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0068: Expected I4, but got Obj
		//IL_0068: Expected Obj, but got I
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			return ((InflateManager)obj2).SyncPoint((ZlibCodec)(object)input);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+3C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+3C]");
			return ((DeflateManager)0).Deflate((FlushType)input);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Inflate or Deflate state!" != 0);
		((ZlibCodec)(object)zlibBaseStream).SetDictionary((byte[])null);
		int result = default;
		return result;
	}

	public int GetCrc32AndCopy(Stream input, Stream output)
	{
		//IL_003f: Expected I4, but got Obj
		//IL_001e: Expected I4, but got Obj
		//IL_001e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+3C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+3C]");
			return ((InflateCodes)0).Process((InflateBlocks)(object)input, (int)output);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Deflate State!" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0;
	}

	public int ComputeCrc32(int W, byte B)
	{
		//IL_0046: Expected I8, but got I4
		//IL_001d: Expected I4, but got Obj
		if (W == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"The input stream must not be null.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		_TotalBytesRead = 0L;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		bool flag = B != 0;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		}
		int num = default;
		long totalBytesRead = num + _TotalBytesRead;
		_TotalBytesRead = totalBytesRead;
		int num3 = default;
		byte[] buffer = default;
		for (int num2 = num; num2 >= 1; num2 = num3)
		{
			((CrcCalculatorStream)this).Write(buffer, 0, num2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
			}
			long totalBytesRead2 = num3 + _TotalBytesRead;
			_TotalBytesRead = totalBytesRead2;
		}
		return (int)_register ^ -1;
	}

	internal int _InternalComputeCrc32(uint W, byte B)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected I4, but got Unknown
		object obj = crc32Table + 16;
		int num = (int)(W & 0xFF);
		int num2 = B & 0xFF;
		int num3 = num ^ num2;
		int num4 = num3 << 2;
		object obj2 = obj + num4;
		int num5 = (int)W >> 8;
		return obj2 ^ num5;
	}

	public void SlurpBlock(byte[] block, int offset, int count)
	{
		if (~(reverseBits ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("ZlibStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		}
	}

	public void UpdateCRC(byte b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected Obj, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_020e: Expected Obj, but got I4
		//IL_0217: Expected Obj, but got I4
		//IL_011c: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = obj2;
		_ = -1;
		if (~(reverseBits ? 1u : 0u) != 0)
		{
			if (b != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CRC32)+14]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				}
			}
			reverseBits = true;
		}
		object obj3 = obj + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj + obj5;
		obj6 = 47;
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 47)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
				return;
			}
		}
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void UpdateCRC(byte b, int n)
	{
		((CelebrationPopupLabelTemplate)this).SetupToken((Characters.CharacterId)b, n, 6, false);
	}

	private static uint ReverseBits(uint data)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ L0 (System.UInt32)+20]");
		return (uint)((nuint)0u ^ unchecked((nuint)(-1)));
	}

	private static byte ReverseBits(byte data)
	{
		int num = data << 1;
		int num2 = num & -1431655766;
		int num3 = data >> 1;
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
		int num16 = num15 >> 24;
		int num17 = num15 << 24;
		int num18 = num16 | num17;
		int num19 = num15 << 8;
		int num20 = num19 & 0xFF0000;
		int num21 = num18 | num20;
		int num22 = num15 >> 8;
		int num23 = num22 & 0xFF00;
		return (byte)(num21 | num23);
	}

	private void GenerateLookupTable()
	{
		if (~(reverseBits ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("ZlibStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	private uint gf2_matrix_times(uint[] matrix, uint vec)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_006f: Expected I4, but got Obj
		object obj = crc32Table + 16;
		object obj2 = matrix & 0xFF;
		int num = (int)(vec & 0xFF);
		int num2 = obj2 ^ num;
		int num3 = num2 << 2;
		object obj3 = obj + num3;
		object obj4 = (object)matrix >> 8;
		return (uint)(obj3 ^ obj4);
	}

	private void gf2_matrix_square(uint[] square, uint[] mat)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected I4, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected I4, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected I4, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected I4, but got Unknown
		object obj = square & 0xFF;
		uint[] array = default;
		while (true)
		{
			array = (uint[])(array - 1);
			if ((nint)array >= 1)
			{
				if (~(reverseBits ? 1u : 0u) == 0)
				{
					object obj2 = crc32Table + 16;
					int num = (int)_register >> 24;
					int num2 = num ^ obj;
					int num3 = num2 << 2;
					object obj3 = obj2 + num3;
					int num4 = (int)(_register << 8);
					int register = obj3 ^ num4;
					_register = (uint)register;
				}
				else
				{
					object obj4 = crc32Table + 16;
					int num5 = (int)(_register & 0xFF);
					int num6 = num5 ^ obj;
					int num7 = num6 << 2;
					object obj5 = obj4 + num7;
					int num8 = (int)_register >> 8;
					int register2 = obj5 ^ num8;
					_register = (uint)register2;
				}
				continue;
			}
			break;
		}
	}

	public void Combine(int crc, int length)
	{
		//IL_0039: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		object obj = default;
		object obj4 = default;
		while ((nint)obj <= 31)
		{
			object obj2 = crc + 16;
			object obj3 = obj4 << 2;
			object obj5 = obj2 + obj3;
			object obj6 = length + 16;
			object obj7 = obj4 << 2;
			object key = obj6 + obj7;
			bool flag = ((WordHuntManager)null).SHA1HashCheck((string[])length, (string)key);
			obj5 = flag;
			obj = obj4 + 1;
		}
	}

	public CRC32()
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_01c2: Expected I4, but got Obj
		//IL_01cb: Expected Obj, but got I4
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got I4
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		object obj = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		CrcCalculatorStream crcCalculatorStream = default;
		CrcCalculatorStream crcCalculatorStream2 = default;
		do
		{
			byte b = (byte)(int)crcCalculatorStream;
			object obj3 = 8;
			while (true)
			{
				object obj4 = obj3 & 0xFF;
				if (obj4 == null)
				{
					break;
				}
				int num2;
				if ((b & 1) != 0)
				{
					int num = b >> 1;
					num2 = (int)dwPolynomial ^ num;
				}
				else
				{
					num2 = b >> 1;
				}
				object obj5 = obj4 - 1;
				b = (byte)num2;
				obj3 = obj5;
			}
			if (~(reverseBits ? 1u : 0u) == 0)
			{
				object obj6 = crc32Table + 16;
				int crc = crcCalculatorStream.Crc;
				int num3 = crc & 0xFF;
				int num4 = num3 << 2;
				object obj7 = obj6 + num4;
				byte b2 = ReverseBits(b);
				obj7 = b2;
			}
			else
			{
				object obj8 = crc32Table + 16;
				object obj9 = (object)crcCalculatorStream << 2;
				object obj10 = obj8 + obj9;
				obj10 = b;
			}
			object obj11 = crcCalculatorStream2 + 1;
			crcCalculatorStream = (CrcCalculatorStream)(obj11 & 0xFF);
		}
		while (crcCalculatorStream != null);
	}

	public CRC32(bool reverseBits)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected I4, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected I4, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0047: Expected Obj, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected I4, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected I4, but got Unknown
		if (~(this.reverseBits ? 1u : 0u) == 0)
		{
			object obj = crc32Table + 16;
			int num = (int)_register >> 24;
			object obj2 = (reverseBits ? 1 : 0) & 0xFF;
			int num2 = num ^ obj2;
			int num3 = num2 << 2;
			object obj3 = obj + num3;
			int num4 = (int)(_register << 8);
			int register = obj3 ^ num4;
			_register = (uint)register;
		}
		else
		{
			object obj4 = crc32Table + 16;
			int num5 = (int)(_register & 0xFF);
			object obj5 = (reverseBits ? 1 : 0) & 0xFF;
			int num6 = num5 ^ obj5;
			int num7 = num6 << 2;
			object obj6 = obj4 + num7;
			int num8 = (int)_register >> 8;
			int register2 = obj6 ^ num8;
			_register = (uint)register2;
		}
	}

	public CRC32(int polynomial, bool reverseBits)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_001d: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I4
		//IL_0039: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_00cd: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected I4, but got Unknown
		//IL_0107: Expected Obj, but got I4
		//IL_013a: Expected Obj, but got I4
		//IL_0146: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		if (!reverseBits)
		{
			return;
		}
		int num = default;
		object obj = num + 16;
		obj = dwPolynomial;
		object obj2 = 1;
		while ((nint)obj2 <= 31)
		{
			object obj3 = num + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			obj5 = 1;
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		int num2 = default;
		((CRC32)null).Combine(num2, num);
		((CRC32)null).Combine(num, num2);
		int num3 = (int)_register ^ -1;
		bool flag = reverseBits;
		string text = (string)num3;
		string text3;
		while (true)
		{
			((CRC32)null).Combine(num2, num);
			string text2;
			if (flag)
			{
				bool flag2 = ((WordHuntManager)null).SHA1HashCheck((string[])num2, text);
				text2 = (string)flag2;
			}
			else
			{
				text2 = text;
			}
			bool flag3 = (flag ? 1 : 0) < 2;
			text3 = text2;
			if (flag3)
			{
				break;
			}
			((CRC32)null).Combine(num, num2);
			object obj7 = (flag ? 1 : 0) & 2;
			bool flag4 = obj7 == null;
			text3 = text2;
			if (!flag4)
			{
				bool flag5 = ((WordHuntManager)null).SHA1HashCheck((string[])num, text2);
				text3 = (string)flag5;
			}
			bool flag6 = (byte)((flag ? 1 : 0) >> 2) != 0;
			if (!flag6)
			{
				break;
			}
			flag = flag6;
			text = text3;
		}
		int num4 = polynomial ^ -1;
		int register = text3 ^ num4;
		_register = (uint)register;
	}

	public void Reset()
	{
		((CrcCalculatorStream)this)._002Ector((Stream)null);
	}
}
