using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Ionic.Crc;
using TopRun;

namespace Ionic.Zlib;

internal class ZlibBaseStream : Stream
{
	internal enum StreamMode
	{
		Writer,
		Reader,
		Undefined
	}

	protected internal ZlibCodec _z;

	protected internal StreamMode _streamMode;

	protected internal FlushType _flushMode;

	protected internal ZlibStreamFlavor _flavor;

	protected internal CompressionMode _compressionMode;

	protected internal CompressionLevel _level;

	protected internal bool _leaveOpen;

	protected internal byte[] _workingBuffer;

	protected internal int _bufferSize;

	protected internal byte[] _buf1;

	protected internal Stream _stream;

	protected internal CompressionStrategy Strategy;

	private CRC32 crc;

	protected internal string _GzipFileName;

	protected internal string _GzipComment;

	protected internal DateTime _GzipMtime;

	protected internal int _gzipHeaderByteCount;

	private bool _disposed;

	private bool nomoreinput;

	internal int Crc32
	{
		get
		{
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			int result = default;
			return result;
		}
	}

	protected internal bool _wantCompress
	{
		get
		{
			if (crc != null)
			{
				CRC32 cRC = crc;
				return (byte)(cRC._register ^ 0xFFFFFFFFu) != 0;
			}
			return false;
		}
	}

	private ZlibCodec z
	{
		get
		{
			//IL_0016: Expected Obj, but got I4
			bool flag = _compressionMode == CompressionMode.Compress;
			return (ZlibCodec)flag;
		}
	}

	private byte[] workingBuffer
	{
		get
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected Obj, but got Unknown
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected Obj, but got Unknown
			//IL_00a1: Expected I4, but got Obj
			if (_z == null)
			{
				bool flag = _flavor == ZlibStreamFlavor.ZLIB;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 6;
				_ = 15;
				object obj = this + 20;
				object obj2 = default;
				obj = obj2;
				ZlibCodec zlibCodec = _z;
				if (_compressionMode == CompressionMode.Decompress)
				{
					int num = zlibCodec.InitializeInflate(flag ? 1 : 0);
				}
				else
				{
					object obj3 = this - -64;
					zlibCodec.Strategy = (CompressionStrategy)obj3;
					int num2 = _z.InitializeDeflate(_level, flag ? 1 : 0);
				}
			}
			return (byte[])(object)_z;
		}
	}

	public override bool CanRead
	{
		get
		{
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Expected Obj, but got Unknown
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Expected Obj, but got Unknown
			//IL_047d: Expected Obj, but got I4
			//IL_0156: Expected I4, but got Obj
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected Obj, but got Unknown
			//IL_04c2: Expected I4, but got Obj
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Expected Obj, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected Obj, but got Unknown
			//IL_021a: Expected I, but got Obj
			//IL_0230: Expected Obj, but got I
			//IL_04e9: Expected I, but got Obj
			//IL_04ff: Expected Obj, but got I
			//IL_0525: Expected Obj, but got VT
			//IL_0549: Expected VT, but got Obj
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Expected Obj, but got Unknown
			//IL_0560: Unknown result type (might be due to invalid IL or missing references)
			//IL_0565: Expected Obj, but got Unknown
			//IL_025b: Expected I, but got Obj
			//IL_02a8: Expected I, but got Obj
			//IL_058b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Expected Obj, but got Unknown
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Expected Obj, but got Unknown
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ff: Expected Obj, but got Unknown
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_030d: Expected Obj, but got Unknown
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Expected Obj, but got Unknown
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_060d: Expected Obj, but got Unknown
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Expected Obj, but got Unknown
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Expected Obj, but got Unknown
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Expected Obj, but got Unknown
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Expected Obj, but got Unknown
			//IL_0408: Expected Obj, but got I4
			//IL_03c4: Expected I4, but got Obj
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Expected Obj, but got Unknown
			//IL_042a: Expected Obj, but got I4
			//IL_039f: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = obj2 + 8;
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			bool flag = default;
			object obj5 = default;
			bool result = default;
			switch (flag)
			{
			case false:
				return flag;
			default:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream2 = default;
				zlibBaseStream2.Dispose((byte)(int)"Not a valid GZIP stream." != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				goto IL_0453;
			}
			case true:
				{
					object obj4 = obj5 + 16;
					if ((nint)obj4 == 31)
					{
						object obj6 = obj5 + 17;
						if ((nint)obj6 == 139)
						{
							object obj7 = obj5 + 18;
							if ((nint)obj7 == 8)
							{
								nint num = (nint)typeof(BitConverter);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v43 (Il2CppClass<System.BitConverter>)+BA]");
								object obj8 = (nint)0 & (nint)0x200;
								if (obj8 != null)
								{
									nint num2 = (nint)typeof(BitConverter);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v109 (Il2CppClass<System.BitConverter>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								break;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ZlibBaseStream zlibBaseStream = default;
					zlibBaseStream.Dispose((byte)(int)"Bad GZIP header." != 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					goto IL_0453;
				}
				IL_0453:
				return result;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E234");
			nint num3 = (nint)typeof(GZipStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v50 (Il2CppClass<Ionic.Zlib.GZipStream>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(GZipStream);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v103 (Il2CppClass<Ionic.Zlib.GZipStream>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj3 = GZipStream._unixEpoch;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCA5");
			object obj10 = default;
			obj2 = obj10;
			obj = obj2;
			_GzipMtime = (DateTime)obj;
			object obj11 = obj5 + 19;
			object obj12 = obj11 & 4;
			bool result2 = default;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				object obj14 = default;
				object obj13 = obj14 + 10;
				object obj15 = obj5 + 17;
				object obj16 = obj15 << 8;
				object obj17 = obj5 + 16;
				object obj18 = obj16 + obj17;
				object obj19 = obj18 << 16;
				object obj20 = obj19 >> 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				object obj21 = default;
				if (obj21 == obj20)
				{
					bool flag2 = (byte)(int)(obj20 + obj13) != 0;
					result2 = flag2;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ZlibBaseStream zlibBaseStream3 = default;
					zlibBaseStream3.Dispose((byte)(int)"Unexpected end-of-file reading GZIP header." != 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			else
			{
				result2 = true;
			}
			object obj22 = obj5 + 19;
			object obj23 = obj22 & 8;
			if (obj23 != null)
			{
				object obj24 = this + 72;
				int num5 = _ReadAndValidateGzipHeader();
				obj24 = num5;
			}
			object obj25 = obj5 + 19;
			object obj26 = obj25 & 0x10;
			if (obj26 != null)
			{
				object obj27 = this + 76;
				int num6 = _ReadAndValidateGzipHeader();
				obj27 = num6;
			}
			object obj28 = obj5 + 19;
			object obj29 = obj28 & 2;
			if (obj29 == null)
			{
				return result2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			return result2;
		}
	}

	public override bool CanSeek
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
	}

	public override bool CanWrite
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
	}

	public override long Length
	{
		get
		{
			//IL_00c7: Expected Obj, but got I
			//IL_00e1: Expected Obj, but got I
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected I8, but got Unknown
			//IL_00ef: Expected I8, but got I4
			//IL_0083: Expected Obj, but got I
			//IL_00ad: Expected Obj, but got I
			bool leaveOpen = _leaveOpen;
			bool leaveOpen2 = _leaveOpen;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v4 (System.Boolean)+18]");
			CompressionLevel compressionLevel;
			object obj2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (System.Boolean)+18]");
				if ((nint)0 != 1)
				{
					return 0L;
				}
				bool leaveOpen3 = _leaveOpen;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v20 (System.Boolean)+14]");
				object obj = 0;
				bool leaveOpen4 = _leaveOpen;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v24 (System.Boolean)+58]");
				compressionLevel = CompressionLevel.None;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v21+18]");
				obj2 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (System.Boolean)+14]");
				object obj3 = 0;
				compressionLevel = _level;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v11+30]");
				obj2 = 0;
			}
			return (long)(compressionLevel + obj2);
		}
	}

	public override long Position
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
			long result = default;
			return result;
		}
		set
		{
			//IL_0014: Expected VT, but got I8
			//IL_0014: Expected I4, but got Obj
			//IL_0014: Expected Obj, but got I4
			((IManager)24).SubmitScore((int)_stream, (DateTime)value);
		}
	}

	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I4
		object obj = this + 8;
		obj = stream;
		object obj2 = this + 12;
		obj2 = compressionMode;
		base._asyncActiveSemaphore = (SemaphoreSlim)level;
		_z = (ZlibCodec)flavor;
		_streamMode = (leaveOpen ? StreamMode.Reader : StreamMode.Writer);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_0026: Expected Obj, but got I4
		//IL_0030: Expected Obj, but got I4
		Array.ConstrainedCopy(buffer, offset, (Array)(object)_stream, 0, count);
		_GzipFileName = (string)count;
		crc = (CRC32)count;
	}

	private void finish()
	{
	}

	private void end()
	{
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cb: Expected Obj, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_0402: Expected Obj, but got I4
		//IL_0453: Expected Obj, but got I4
		//IL_08e0: Expected I4, but got Obj
		//IL_0634: Expected Obj, but got I4
		//IL_0670: Expected I4, but got Obj
		//IL_00aa: Expected I4, but got Obj
		//IL_07f9: Expected I, but got Obj
		//IL_080f: Expected Obj, but got I
		//IL_072e: Expected I, but got Obj
		//IL_0744: Expected Obj, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_093f: Expected I4, but got I8
		//IL_06ef: Expected I4, but got Obj
		//IL_029f: Expected I, but got Obj
		//IL_027d: Expected I4, but got Obj
		//IL_076f: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I4
		//IL_0376: Expected Obj, but got I8
		//IL_0339: Expected I4, but got Obj
		//IL_03c9: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		if (_z == null)
		{
			return;
		}
		if (_streamMode != StreamMode.Writer)
		{
			if (_streamMode != StreamMode.Reader || _flavor != ZlibStreamFlavor.GZIP)
			{
				return;
			}
			if (_compressionMode == CompressionMode.Compress)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream = default;
				zlibBaseStream.Dispose((byte)(int)"Reading with compression is not supported." != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			ZlibCodec zlibCodec = _z;
			if (zlibCodec.TotalBytesOut == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			ZlibCodec zlibCodec2 = _z;
			ZlibCodec zlibCodec3 = _z;
			ZlibCodec zlibCodec4 = _z;
			Array destinationArray = default;
			if (zlibCodec4.AvailableBytesIn > 7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v139 (System.Array)+C]");
				int num = 0;
				byte[] inputBuffer = zlibCodec2.InputBuffer;
				int nextIn = zlibCodec3.NextIn;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v139 (System.Array)+C]");
				Array.ConstrainedCopy(inputBuffer, nextIn, destinationArray, 0, 0);
			}
			else
			{
				ZlibCodec zlibCodec5 = _z;
				Array.ConstrainedCopy(zlibCodec2.InputBuffer, zlibCodec3.NextIn, destinationArray, 0, zlibCodec5.AvailableBytesIn);
				ZlibCodec zlibCodec6 = _z;
				int num2 = 8 - zlibCodec6.AvailableBytesIn;
				ZlibCodec zlibCodec7 = _z;
				int num = zlibCodec7.AvailableBytesIn;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
				object obj3 = default;
				if (num2 != (nint)obj3)
				{
					ZlibCodec zlibCodec8 = _z;
					object obj4 = obj3 + zlibCodec8.AvailableBytesIn;
					obj = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					object[] args = default;
					string text = $"Missing or incomplete GZIP trailer. Expected 8 bytes, got {args}.";
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ZlibBaseStream zlibBaseStream2 = default;
					zlibBaseStream2.Dispose((byte)(int)text != 0);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
			nint num3 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v152 (Il2CppClass<System.BitConverter>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v202 (Il2CppClass<System.BitConverter>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E234");
			CRC32 cRC = crc;
			int num5 = (int)cRC._register ^ -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E234");
			ZlibCodec zlibCodec9 = _z;
			object obj6 = default;
			if (num5 != (nint)obj6)
			{
				obj = num5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj2 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string format = default;
				object arg = default;
				string text2 = string.Format((IFormatProvider)(object)"Bad CRC32 in GZIP trailer. (actual({0:X8})!=expected({1:X8}))", format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream3 = default;
				zlibBaseStream3.Dispose((byte)(int)text2 != 0);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			object obj7 = default;
			if ((long)obj7 == zlibCodec9.TotalBytesOut)
			{
				return;
			}
			obj = zlibCodec9.TotalBytesOut;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format2 = default;
			object arg2 = default;
			string text3 = string.Format((IFormatProvider)(object)"Bad size in GZIP trailer. (actual({0})!=expected({1}))", format2, arg2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream4 = default;
			zlibBaseStream4.Dispose((byte)(int)text3 != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		bool flag3;
		object arg3 = default;
		ZlibBaseStream zlibBaseStream5 = default;
		do
		{
			IL_0856:
			object obj8 = _z + 32;
			string text4 = ReadZeroTerminatedString();
			obj8 = text4;
			ZlibCodec zlibCodec10 = _z;
			zlibCodec10.NextOut = 0;
			ZlibCodec zlibCodec11 = _z;
			byte[] array = _workingBuffer;
			zlibCodec11.AvailableBytesOut = array.Length;
			int num6 = ((_compressionMode == CompressionMode.Compress) ? _z.SetDictionary((byte[])4) : _z.InitializeDeflate(CompressionLevel.None));
			if (num6 < 2)
			{
				byte[] array2 = _workingBuffer;
				ZlibCodec zlibCodec12 = _z;
				object obj9 = array2.Length - zlibCodec12.AvailableBytesOut;
				if ((nint)obj9 >= 1)
				{
					byte[] array3 = _workingBuffer;
					ZlibCodec zlibCodec13 = _z;
					int num = array3.Length - zlibCodec13.AvailableBytesOut;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
				}
				ZlibCodec zlibCodec14 = _z;
				bool flag;
				if (zlibCodec14.AvailableBytesIn != 0)
				{
					flag = false;
				}
				else
				{
					ZlibCodec zlibCodec15 = _z;
					flag = zlibCodec15.AvailableBytesOut != 0;
				}
				bool flag2 = _flavor != ZlibStreamFlavor.GZIP;
				flag3 = flag;
				if (flag2)
				{
					continue;
				}
				bool flag4 = _compressionMode == CompressionMode.Compress;
				flag3 = flag;
				if (!flag4)
				{
					ZlibCodec zlibCodec16 = _z;
					if (zlibCodec16.AvailableBytesIn != 8)
					{
						goto IL_0856;
					}
					ZlibCodec zlibCodec17 = _z;
					bool flag5 = zlibCodec17.AvailableBytesOut != 0;
					flag3 = flag5;
				}
				continue;
			}
			string[] values = (string[])(object)((_compressionMode == CompressionMode.Compress) ? "de" : "in");
			string text5 = string.ConcatArray(values, (int)"flating");
			ZlibCodec zlibCodec18 = _z;
			string text6;
			if (zlibCodec18.Message != null)
			{
				ZlibCodec zlibCodec19 = _z;
				object obj10 = ((IConvertible)text5).ToType((Type)(object)": ", (IFormatProvider)(object)zlibCodec19.Message);
				text6 = (string)obj10;
			}
			else
			{
				obj = num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				text6 = string.Format((IFormatProvider)(object)"{0}: (rc = {1})", text5, arg3);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			zlibBaseStream5.Dispose((byte)(int)text6 != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			break;
		}
		while (!flag3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		if (_flavor != ZlibStreamFlavor.GZIP)
		{
			return;
		}
		if (_compressionMode != CompressionMode.Compress)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream6 = default;
			zlibBaseStream6.Dispose((byte)(int)"Writing with decompression is not supported." != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		CRC32 cRC2 = crc;
		ushort value = (ushort)(cRC2._register ^ 0xFFFFFFFFu);
		nint num7 = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ S0_v45 (Il2CppClass<System.BitConverter>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v51 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] bytes = BitConverter.GetBytes(value);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		CRC32 cRC3 = crc;
		byte[] bytes2 = BitConverter.GetBytes((ushort)cRC3._TotalBytesRead);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
	}

	protected override void Dispose(bool disposing)
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
		((Exception)(object)this).SetErrorCode(disposing ? 1 : 0);
	}

	~ZlibBaseStream()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got I4
		byte[] array = workingBuffer;
		if (array != null)
		{
			if (_compressionMode != CompressionMode.Compress)
			{
				int num = _z.SyncInflate();
			}
			else
			{
				FlushType flushMode = ((ZlibStream)(object)_z).FlushMode;
			}
			object obj = this + 20;
			obj = 0;
		}
	}

	public override void Flush()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00e5: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		object obj3 = obj + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj + obj5;
		obj6 = 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj + obj7;
			if ((nint)obj8 == 16)
			{
				object obj9 = obj + 4;
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

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_000b: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0L;
	}

	public override void SetLength(long value)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		((GZipStream)(object)ex).SetLength(0L);
	}

	private string ReadZeroTerminatedString()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		if (_workingBuffer == null)
		{
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj2 = default;
			obj = obj2;
		}
		return (string)(object)_workingBuffer;
	}

	private int _ReadAndValidateGzipHeader()
	{
		//IL_009b: Expected I4, but got Obj
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected Obj, but got Unknown
		//IL_0108: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = default;
		ZlibBaseStream zlibBaseStream = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			if ((nint)obj == 1)
			{
				object obj2 = _buf1 + 16;
				if (obj2 != null)
				{
					object obj3 = _buf1 + 16;
					Dictionary<_00210, _00211>.ValueCollection.Enumerator enumerator = (Dictionary<_00210, _00211>.ValueCollection.Enumerator)((Dictionary<TKey, TValue>.ValueCollection)obj3).GetEnumerator();
					continue;
				}
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			zlibBaseStream.Dispose((byte)(int)"Unexpected EOF reading GZIP header." != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
		nint num = (nint)typeof(GZipStream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v16 (Il2CppClass<Ionic.Zlib.GZipStream>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(GZipStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v22 (Il2CppClass<Ionic.Zlib.GZipStream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		int result = default;
		return result;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_06fb: Expected I4, but got Obj
		//IL_004e: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_00e9: Expected I, but got Obj
		//IL_00ff: Expected Obj, but got I
		//IL_008f: Expected I, but got Obj
		//IL_012a: Expected I, but got Obj
		//IL_07bc: Expected I, but got Obj
		//IL_07d2: Expected Obj, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected Obj, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_01ac: Expected Obj, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected Obj, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected Obj, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected Obj, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected Obj, but got Unknown
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected Obj, but got Unknown
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected Obj, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected Obj, but got Unknown
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected I4, but got Unknown
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected Obj, but got Unknown
		//IL_069f: Expected Obj, but got I4
		//IL_0629: Expected I, but got Obj
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected Obj, but got Unknown
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected I4, but got Unknown
		//IL_0684: Expected Obj, but got I4
		//IL_06db: Expected Obj, but got I4
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected I4, but got Unknown
		//IL_06c0: Expected Obj, but got I4
		if (buffer != null)
		{
			object obj = this & 0xFFFF;
			object obj2 = (object)this >> 16;
			object obj3 = obj2;
			object obj4 = obj;
			int num = offset;
			int num2 = count;
			while (num2 >= 1)
			{
				nint num3 = (nint)typeof(Adler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v21 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v42 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num5;
				if (num2 < Adler.NMAX)
				{
					num5 = num2;
				}
				else
				{
					nint num6 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v171 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num7 = (nint)typeof(Adler);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v178 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num5 = Adler.NMAX;
				}
				int num8 = num2 - num5;
				object obj7 = obj3;
				int num9 = num5;
				while (num9 >= 16)
				{
					object obj8 = buffer + 16;
					object obj9 = obj8 + num;
					object obj10 = obj9 + obj4;
					object obj11 = obj10 + obj7;
					object obj12 = num + 1;
					object obj13 = obj12 + 1;
					object obj14 = buffer + 16;
					object obj15 = obj14 + obj12;
					object obj16 = obj15 + obj10;
					object obj17 = obj16 + obj11;
					object obj18 = buffer + 16;
					object obj19 = obj18 + obj13;
					object obj20 = obj19 + obj16;
					object obj21 = obj20 + obj17;
					object obj22 = obj13 + 1;
					object obj23 = obj22 + 1;
					object obj24 = buffer + 16;
					object obj25 = obj24 + obj22;
					object obj26 = obj25 + obj20;
					object obj27 = obj26 + obj21;
					object obj28 = buffer + 16;
					object obj29 = obj28 + obj23;
					object obj30 = obj29 + obj26;
					object obj31 = obj30 + obj27;
					object obj32 = obj23 + 1;
					object obj33 = obj32 + 1;
					object obj34 = buffer + 16;
					object obj35 = obj34 + obj32;
					object obj36 = obj35 + obj30;
					object obj37 = obj36 + obj31;
					object obj38 = buffer + 16;
					object obj39 = obj38 + obj33;
					object obj40 = obj39 + obj36;
					object obj41 = obj40 + obj37;
					object obj42 = obj33 + 1;
					object obj43 = obj42 + 1;
					object obj44 = buffer + 16;
					object obj45 = obj44 + obj42;
					object obj46 = obj45 + obj40;
					object obj47 = obj46 + obj41;
					object obj48 = buffer + 16;
					object obj49 = obj48 + obj43;
					object obj50 = obj49 + obj46;
					object obj51 = obj50 + obj47;
					object obj52 = obj43 + 1;
					object obj53 = obj52 + 1;
					object obj54 = buffer + 16;
					object obj55 = obj54 + obj52;
					object obj56 = obj55 + obj50;
					object obj57 = obj56 + obj51;
					object obj58 = buffer + 16;
					object obj59 = obj58 + obj53;
					object obj60 = obj59 + obj56;
					object obj61 = obj60 + obj57;
					object obj62 = obj53 + 1;
					object obj63 = obj62 + 1;
					object obj64 = buffer + 16;
					object obj65 = obj64 + obj62;
					object obj66 = obj65 + obj60;
					object obj67 = obj66 + obj61;
					object obj68 = buffer + 16;
					object obj69 = obj68 + obj63;
					object obj70 = obj69 + obj66;
					object obj71 = obj70 + obj67;
					object obj72 = obj63 + 1;
					object obj73 = obj72 + 1;
					object obj74 = buffer + 16;
					object obj75 = obj74 + obj72;
					object obj76 = obj75 + obj70;
					object obj77 = obj76 + obj71;
					object obj78 = buffer + 16;
					object obj79 = obj78 + obj73;
					object obj80 = obj79 + obj76;
					object obj81 = obj80 + obj77;
					object obj82 = obj73 + 1;
					int num10 = obj82 + 1;
					object obj83 = buffer + 16;
					object obj84 = obj83 + obj82;
					object obj85 = obj84 + obj80;
					object obj86 = obj85 + obj81;
					int num11 = num9 - 16;
					obj7 = obj86;
					obj4 = obj85;
					num = num10;
					num9 = num11;
				}
				if (num9 != 0)
				{
					int num12 = num;
					while (true)
					{
						int num13 = num12 + 1;
						object obj87 = buffer + 16;
						object obj88 = obj87 + num12;
						object obj89 = obj88 + obj4;
						object obj90 = obj89 + obj7;
						int num14 = num9 - 1;
						bool flag = num9 == 1;
						obj7 = obj90;
						obj4 = obj89;
						num = num13;
						if (flag)
						{
							break;
						}
						num12 = num13;
						obj7 = obj90;
						obj4 = obj89;
						num9 = num14;
					}
				}
				nint num15 = (nint)typeof(Adler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S1_v21 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
				object obj91 = (nint)0 & (nint)0x200;
				if (obj91 != null)
				{
					nint num16 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ S1_v29 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj93;
				if (Adler.BASE != 0)
				{
					int num17 = (int)(obj4 / Adler.BASE);
					object obj92 = num17 * (int)Adler.BASE;
					obj93 = obj4 - obj92;
				}
				else
				{
					obj93 = 0;
				}
				object obj95;
				if (Adler.BASE != 0)
				{
					int num18 = (int)(obj7 / Adler.BASE);
					object obj94 = num18 * (int)Adler.BASE;
					obj95 = obj7 - obj94;
				}
				else
				{
					obj95 = 0;
				}
				obj3 = obj95;
				obj4 = obj93;
				num2 = num8;
			}
			object obj96 = obj3 << 16;
			return obj96 | obj4;
		}
		return 1;
	}

	public static void CompressString(string s, Stream compressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_0157: Expected Obj, but got I4
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 8;
		obj = obj2;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+5C]");
		if ((nint)0 != 0)
		{
			return;
		}
		if (compressor != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+3C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				object obj3 = obj + 4;
				object obj4 = obj3 + 1;
				obj3 = obj4;
				object obj5 = obj4 << 2;
				object obj6 = obj + obj5;
				obj6 = 60;
				((ZlibBaseStream)(object)s).Finalize();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+2C]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
				}
				object obj7 = s + 60;
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
					object obj8 = (nint)0 << 2;
					object obj9 = obj + obj8;
					if ((nint)obj9 == 60)
					{
						object obj10 = obj + 4;
						if ((nint)obj10 > -1)
						{
							object obj11 = obj10 + -1;
							obj10 = obj11;
						}
						goto IL_02bc;
					}
				}
				object obj12 = default;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
			}
		}
		goto IL_02bc;
		IL_02bc:
		_ = 1;
	}

	public static void CompressBuffer(byte[] b, Stream compressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_0121: Expected Obj, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 37;
		if (compressor != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj7 = (nint)0 << 2;
			object obj8 = obj2 + obj7;
			if ((nint)obj8 == 37)
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

	public static string UncompressString(byte[] compressed, Stream decompressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = decompressor & 0x1F;
		return (string)((object)compressed >> (int)obj);
	}

	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_0187: Expected Obj, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_038f: Expected Obj, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected Obj, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Encoding uTF = Encoding.UTF32;
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
		obj9 = 65;
		object obj10 = 0;
		if (decompressor != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj2 + obj11;
			if ((nint)obj12 == 65)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0531;
			}
		}
		object obj17;
		object obj18 = default;
		object obj15;
		if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj16 = default;
			obj15 = obj16;
			obj17 = obj18;
			goto IL_0495;
		}
		goto IL_0531;
		IL_0531:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj19 = default;
		obj15 = obj19;
		obj17 = obj18;
		goto IL_0495;
		IL_0495:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj20 = default;
		object obj21 = default;
		if (obj17 == obj20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj22 = default;
			obj21 = obj22;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj2 + obj23;
			if ((nint)obj24 == 101)
			{
				object obj25 = obj2 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_0540;
			}
		}
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0540;
		IL_0540:
		byte[] result = default;
		return result;
	}
}
