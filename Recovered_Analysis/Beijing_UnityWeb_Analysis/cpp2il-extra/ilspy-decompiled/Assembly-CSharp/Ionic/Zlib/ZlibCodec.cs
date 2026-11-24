using System;
using System.IO;
using Cpp2ILInjected;
using Ionic.Crc;

namespace Ionic.Zlib;

public sealed class ZlibCodec
{
	public byte[] InputBuffer;

	public int NextIn;

	public int AvailableBytesIn;

	public long TotalBytesIn;

	public byte[] OutputBuffer;

	public int NextOut;

	public int AvailableBytesOut;

	public long TotalBytesOut;

	public string Message;

	internal DeflateManager dstate;

	internal InflateManager istate;

	internal uint _Adler32;

	public CompressionLevel CompressLevel;

	public int WindowBits;

	public CompressionStrategy Strategy;

	public int Adler32
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			int result = default;
			return result;
		}
	}

	public ZlibCodec()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	public ZlibCodec(CompressionMode mode)
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 25;
		if (mode != CompressionMode.Compress)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 25)
			{
				object obj9 = obj2 + 4;
				if ((nint)obj9 > -1)
				{
					object obj10 = obj9 + -1;
					obj9 = obj10;
				}
				return;
			}
		}
		object obj11 = default;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public int InitializeInflate()
	{
		return (int)_Adler32;
	}

	public int InitializeInflate(bool expectRfc1950Header)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected Obj, but got Unknown
		//IL_009f: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		//IL_0190: Expected Obj, but got I
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02c0: Expected Obj, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_037d: Expected Obj, but got I
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		object obj4 = default;
		object obj3 = obj4 + 12;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		}
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 57;
		object obj10 = 0;
		if (expectRfc1950Header)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 57)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_04cb;
			}
		}
		object obj20 = default;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj16 = default;
			object obj15 = obj16;
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj19 = default;
			if (obj15 == obj19)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				object obj21 = default;
				obj20 = obj21;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			}
			goto IL_0484;
		}
		goto IL_04cb;
		IL_04da:
		int result = default;
		return result;
		IL_0484:
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
			if ((nint)obj23 == 77)
			{
				object obj24 = obj2 + 4;
				if ((nint)obj24 > -1)
				{
					object obj25 = obj24 + -1;
					obj24 = obj25;
				}
				goto IL_04da;
			}
		}
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_04da;
		IL_04cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj26 = obj2 + 4;
		object obj27 = obj26 + 1;
		obj26 = obj27;
		object obj28 = obj27 << 2;
		object obj29 = obj2 + obj28;
		obj29 = 77;
		obj20 = obj10;
		goto IL_0484;
	}

	public int InitializeInflate(int windowBits)
	{
		int num = InitializeDeflate((CompressionLevel)WindowBits, (byte)windowBits != 0);
		return 0;
	}

	public int InitializeInflate(int windowBits, bool expectRfc1950Header)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0097: Expected Obj, but got I4
		//IL_00a7: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_00d2: Expected Obj, but got I4
		//IL_006f: Expected I4, but got Obj
		//IL_0112: Expected Obj, but got I4
		//IL_0135: Expected I4, but got Obj
		//IL_0135: Expected Obj, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = windowBits;
		object obj2 = NextIn + 56;
		obj2 = 0;
		object obj3 = this + 40;
		obj3 = 0;
		object obj4 = (expectRfc1950Header ? 1 : 0) & -8;
		if ((nint)obj4 == 8)
		{
			NextOut = (expectRfc1950Header ? 1 : 0);
			ZlibCodec zlibCodec = ((OutputBuffer == null) ? null : this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = (expectRfc1950Header ? 1 : 0) & 0x1F;
			int n = 1 << (int)obj5;
			InflateBlocks inflateBlocks = default;
			inflateBlocks.SetDictionary((byte[])windowBits, (int)zlibCodec, n);
			object obj6 = this + 40;
			obj6 = inflateBlocks;
			int num = ((InflateManager)this).End();
			return 0;
		}
		int num2 = ((InflateManager)this).Sync();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"Bad window size." != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0;
	}

	public int Inflate(FlushType flush)
	{
		WindowBits = (int)flush;
		int num = InitializeDeflate((CompressionLevel)flush, wantRfc1950Header: true);
		return 0;
	}

	public int EndInflate()
	{
		int num = Inflate((FlushType)WindowBits);
		return 0;
	}

	public int SyncInflate()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_004f: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0031: Expected Obj, but got I4
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			int num = ((InflateManager)obj2).Sync();
			object obj3 = this - -64;
			obj3 = 0;
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Inflate State!" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0;
	}

	public int InitializeDeflate()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_003a: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected I4, but got Obj
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			return Tree.DistanceCode((int)obj2);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Inflate State!" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0;
	}

	public int InitializeDeflate(CompressionLevel level)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_003b: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this - -64;
		if (obj != null)
		{
			object obj2 = this - -64;
			return ((InflateManager)obj2).SetDictionary((byte[])null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Inflate State!" != 0);
		((ZlibCodec)(object)zlibBaseStream).Inflate(FlushType.None);
		return 0;
	}

	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected Obj, but got Unknown
		//IL_0072: Expected I4, but got Obj
		//IL_001d: Expected I4, but got Obj
		WindowBits = (int)level;
		if (dstate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"You may not call InitializeInflate() after calling InitializeDeflate()." != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 1;
		object obj = this - -64;
		object obj2 = default;
		obj = obj2;
		object obj3 = this - -64;
		int num = ((ZlibCodec)obj3).InitializeInflate((int)this, (byte)level != 0);
		return 0;
	}

	public int InitializeDeflate(CompressionLevel level, int bits)
	{
		CompressLevel = level;
		return Deflate((FlushType)bits);
	}

	public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
	{
		//IL_0125: Expected I4, but got Obj
		//IL_006e: Expected I8, but got I4
		//IL_004f: Expected I4, but got Obj
		//IL_023c: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02ae: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I
		//IL_0323: Expected Obj, but got I4
		//IL_0333: Expected Obj, but got I
		//IL_0348: Expected Obj, but got I
		//IL_0363: Expected Obj, but got I
		//IL_0877: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		//IL_0473: Expected Obj, but got I
		//IL_04b2: Expected Obj, but got I4
		//IL_044d: Expected Obj, but got I
		//IL_050c: Expected Obj, but got I4
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_03bb: Expected Obj, but got I
		//IL_03d1: Expected Obj, but got I
		//IL_03fa: Expected Obj, but got I
		//IL_0633: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I
		//IL_08b7: Expected Obj, but got I
		//IL_08d5: Expected Obj, but got I
		//IL_08f0: Expected I4, but got Obj
		//IL_05ac: Expected Obj, but got I
		//IL_0578: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_05f8: Expected Obj, but got I4
		//IL_0905: Expected Obj, but got I
		//IL_07d9: Expected Obj, but got I4
		//IL_07d9: Expected Obj, but got I4
		//IL_0723: Expected Obj, but got I4
		//IL_0723: Expected Obj, but got I
		//IL_075a: Expected Obj, but got I4
		//IL_0774: Expected Obj, but got I
		//IL_078e: Expected Obj, but got I
		//IL_07ae: Expected I4, but got Obj
		if (TotalBytesIn == 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj = default;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream = default;
				zlibBaseStream.Dispose((byte)(int)"The stream is not readable." != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			TotalBytesIn = 1L;
			byte[] workingBuffer = ((ZlibBaseStream)this).workingBuffer;
			workingBuffer[0] = 0;
			if ((nint)OutputBuffer == 1952)
			{
				bool canRead = ((ZlibBaseStream)this).CanRead;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+58]");
				if ((nint)0 == 0)
				{
					return 0;
				}
			}
		}
		if (TotalBytesIn != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream2 = default;
			zlibBaseStream2.Dispose((byte)(int)"Cannot Read after Writing." != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (wantRfc1950Header)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+5D]");
			if ((nint)0 != 0 && NextOut == 0)
			{
				return 0;
			}
			if (level == CompressionLevel.None)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArgumentOutOfRangeException ex = default;
				ex._002Ector("buffer");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			if ((wantRfc1950Header ? 1 : 0) <= -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArithmeticException ex2 = default;
				ex2._002Ector("count");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			object value = ((Array)level).GetValue((int[])null);
			if ((nint)value > bits)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArithmeticException ex3 = default;
				ex3._002Ector("offset");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			object obj2 = (wantRfc1950Header ? 1 : 0) + bits;
			int lowerBound = ((Array)level).GetLowerBound(0);
			if ((nint)obj2 > lowerBound)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ArithmeticException ex4 = default;
				ex4._002Ector("count");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
			object obj3 = (nint)0 + (nint)32;
			obj3 = level;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
			object obj6 = (nint)0 + (nint)8;
			string text = ((ZlibBaseStream)this).ReadZeroTerminatedString();
			obj6 = text;
			bool flag4;
			object obj17;
			object arg = default;
			ZlibBaseStream zlibBaseStream3 = default;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v50+10]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+5D]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
						object obj8 = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
						object obj9 = 0;
						long totalBytesOut = TotalBytesOut;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
						object obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v146+10]");
						if ((nint)0 == 0)
						{
							_ = 1;
						}
					}
				}
				int num;
				if (NextOut != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
					num = ((ZlibCodec)0).InitializeDeflate(CompressionLevel.None);
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+1C]");
					num = ((ZlibCodec)num2).SetDictionary((byte[])0);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+5D]");
				bool flag = (nint)0 != 0;
				bool flag2 = num == -5;
				object obj11 = flag & flag2;
				if (obj11 != null)
				{
					return 0;
				}
				bool flag3 = num == 1;
				flag4 = num != 0;
				object obj12 = (flag4 ? 1 : 0) ^ 1;
				object obj13 = flag3 | obj12;
				if (obj13 != null)
				{
					bool flag5 = flag3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+5D]");
					object obj14 = (nint)(flag5 ? 1 : 0) | (nint)0;
					if (obj14 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v130+28]");
						if ((nint)0 == (wantRfc1950Header ? 1 : 0))
						{
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v123+28]");
					if ((nint)0 >= (nint)1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+5D]");
						bool flag6 = (nint)0 != 0;
						obj17 = flag4 | flag6;
						continue;
					}
					break;
				}
				bool flag7 = NextOut == 0;
				object obj18 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string format = ((!flag7) ? "in" : "de");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ S3_v11+38]");
				string text2 = string.Format((IFormatProvider)(object)"{0}flating:  rc={1}  msg={2}", format, arg, 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				zlibBaseStream3.Dispose((byte)(int)text2 != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				break;
			}
			while (obj17 == null);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v71+28]");
			if ((nint)0 >= (nint)1)
			{
				if (flag4)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+5D]");
					if ((nint)0 == 0)
					{
						goto IL_08f5;
					}
				}
				if (NextOut == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
					int num3 = ((ZlibCodec)0).SetDictionary((byte[])4);
					if (num3 >= 2)
					{
						object obj18 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ S2_v23+38]");
						string format2 = default;
						string text3 = string.Format((IFormatProvider)(object)"Deflating:  rc={0}  msg={1}", format2, 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						ZlibBaseStream zlibBaseStream4 = default;
						zlibBaseStream4.Dispose((byte)(int)text3 != 0);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
				}
			}
			goto IL_08f5;
		}
		return 0;
		IL_08f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibCodec)+14]");
		object obj22 = 0;
		bool flag8 = wantRfc1950Header;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S1_v39+28]");
		int num4 = (int)((nint)(flag8 ? 1 : 0) - (nint)0);
		if (_Adler32 != 0)
		{
			((CrcCalculatorStream)_Adler32).Write((byte[])level, bits, num4);
		}
		return num4;
	}

	private int _InternalInitializeDeflate(bool wantRfc1950Header)
	{
		CompressLevel = (wantRfc1950Header ? CompressionLevel.BestSpeed : CompressionLevel.None);
		return Deflate(FlushType.Partial);
	}

	public int Deflate(FlushType flush)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_00a4: Expected Obj, but got I4
		//IL_001d: Expected I4, but got Obj
		object obj = this - -64;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"You may not call InitializeDeflate() after calling InitializeInflate()." != 0);
			((ZlibCodec)(object)zlibBaseStream)._InternalInitializeDeflate(false);
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DeflateManager deflateManager = default;
		deflateManager._InitializeLazyMatch();
		object obj2 = this + 60;
		obj2 = deflateManager;
		DeflateManager deflateManager2 = dstate;
		bool wantRfc1950HeaderBytes = (byte)(flush & FlushType.Partial) != 0;
		deflateManager2._WantRfc1950HeaderBytes = wantRfc1950HeaderBytes;
		return InfTree.inflate_trees_fixed((int[])(object)dstate, (int[])(object)this, (int[][])CompressLevel, (int[][])WindowBits, (ZlibCodec)Strategy);
	}

	public int EndDeflate()
	{
		return Deflate(FlushType.Partial);
	}

	public void ResetDeflate()
	{
		CompressLevel = CompressionLevel.Default;
		WindowBits = 15;
	}

	public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
	{
		CompressLevel = level;
		WindowBits = (int)strategy;
		return Deflate(FlushType.Partial);
	}

	public int SetDictionary(byte[] dictionary)
	{
		//IL_0035: Expected I4, but got Obj
		//IL_0014: Expected I4, but got Obj
		if (dstate != null)
		{
			return ((InflateBlocks)(object)dstate).Process((int)dictionary);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Deflate State!" != 0);
		((ZlibCodec)(object)zlibBaseStream).Deflate(FlushType.None);
		return 0;
	}

	internal void flush_pending()
	{
		//IL_002d: Expected I4, but got Obj
		if (dstate != null)
		{
			dstate.SetDeflater();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"No Deflate State!" != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	internal int read_buf(byte[] buf, int start, int size)
	{
		//IL_000a: Expected I4, but got Obj
		CompressLevel = (CompressionLevel)buf;
		WindowBits = start;
		return Deflate((FlushType)size);
	}
}
