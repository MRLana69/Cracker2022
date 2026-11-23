using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Ionic.Crc;

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

	protected internal StreamMode _streamMode = StreamMode.Undefined;

	protected internal FlushType _flushMode;

	protected internal ZlibStreamFlavor _flavor;

	protected internal CompressionMode _compressionMode;

	protected internal CompressionLevel _level;

	protected internal bool _leaveOpen;

	protected internal byte[] _workingBuffer;

	protected internal int _bufferSize = 16384;

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
			CRC32 cRC = crc;
			if (crc == null)
			{
				return 0;
			}
			return (int)cRC._register ^ -1;
		}
	}

	protected internal bool _wantCompress => _compressionMode == CompressionMode.Compress;

	private ZlibCodec z
	{
		get
		{
			//IL_0017: Expected I4, but got I8
			if (_z == null)
			{
				ZlibCodec zlibCodec = default;
				zlibCodec.CompressLevel = CompressionLevel.Default;
				_z = zlibCodec;
				ZlibCodec zlibCodec2 = _z;
				if (_compressionMode == CompressionMode.Decompress)
				{
					bool expectRfc1950Header = _flavor == ZlibStreamFlavor.ZLIB;
					int num = zlibCodec2.InitializeInflate(expectRfc1950Header);
				}
				else
				{
					zlibCodec2.Strategy = Strategy;
					bool wantRfc1950Header = _flavor == ZlibStreamFlavor.ZLIB;
					int num2 = zlibCodec2.InitializeDeflate(_level, wantRfc1950Header);
				}
			}
			return _z;
		}
	}

	private byte[] workingBuffer
	{
		get
		{
			if (_workingBuffer != null)
			{
				return _workingBuffer;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			byte[] array = default;
			_workingBuffer = array;
			return _workingBuffer;
		}
	}

	public override bool CanRead
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Stream stream = _stream;
			nint num = (nint)stream;
			object obj = stream + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+F4] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override bool CanSeek
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected Obj, but got Unknown
			Stream stream = _stream;
			object obj = stream - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3+BC] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override bool CanWrite
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Stream stream = _stream;
			nint num = (nint)stream;
			object obj = stream + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+10C] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override long Length
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Stream stream = _stream;
			nint num = (nint)stream;
			object obj = stream + 88;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+114] (should have been resolved before IL gen)");
			long result = default;
			return result;
		}
	}

	public override long Position
	{
		get
		{
			//IL_0037: Expected I8, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (long)ex;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotImplementedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		byte[] buf = default;
		_buf1 = buf;
		_stream = stream;
		_flushMode = FlushType.None;
		_compressionMode = compressionMode;
		_leaveOpen = leaveOpen;
		_level = level;
		_flavor = flavor;
		if (flavor == ZlibStreamFlavor.GZIP)
		{
			CRC32 cRC = default;
			cRC._002Ector();
			crc = cRC;
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_0150: Expected I4, but got Obj
		//IL_01b6: Expected Obj, but got I4
		//IL_01be: Expected I, but got Obj
		int num = default;
		int num2 = default;
		if (crc != null)
		{
			crc.SlurpBlock(buffer, num, num2);
		}
		if (_streamMode != StreamMode.Writer)
		{
			if (_streamMode == StreamMode.Reader || _streamMode != StreamMode.Undefined)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ZlibException ex = default;
				ex._002Ector("Cannot Write after Reading.");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
				ZlibBaseStream zlibBaseStream = (ZlibBaseStream)(object)ex;
			}
			_streamMode = StreamMode.Writer;
		}
		if (num2 == 0)
		{
			return;
		}
		ZlibCodec zlibCodec = z;
		zlibCodec.InputBuffer = buffer;
		ZlibCodec zlibCodec2 = _z;
		zlibCodec2.AvailableBytesIn = num2;
		zlibCodec2.NextIn = num;
		ZlibCodec zlibCodec3 = zlibCodec2;
		string text2 = default;
		ZlibException ex2 = default;
		do
		{
			IL_0395:
			byte[] outputBuffer = workingBuffer;
			zlibCodec3.OutputBuffer = outputBuffer;
			ZlibCodec zlibCodec4 = _z;
			zlibCodec4.NextOut = 0;
			byte[] array = _workingBuffer;
			zlibCodec4.AvailableBytesOut = array.Length;
			int num3 = ((_compressionMode != CompressionMode.Compress) ? zlibCodec4.Inflate((FlushType)this) : zlibCodec4.Deflate(_flushMode));
			if (num3 <= 1)
			{
				Stream stream = _stream;
				byte[] array2 = _workingBuffer;
				ZlibCodec zlibCodec5 = _z;
				object obj = array2.Length - zlibCodec5.AvailableBytesOut;
				nint num4 = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ S4_v9 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
				ZlibCodec zlibCodec6 = _z;
				bool flag = zlibCodec6.AvailableBytesIn == 0;
				bool flag2 = !flag;
				num2 = 0;
				if (!flag2)
				{
					bool flag3 = zlibCodec6.AvailableBytesOut != 0;
					num2 = (flag3 ? 1 : 0);
				}
				bool flag4 = _flavor != ZlibStreamFlavor.GZIP;
				zlibCodec3 = zlibCodec6;
				if (flag4)
				{
					continue;
				}
				bool flag5 = _compressionMode == CompressionMode.Compress;
				zlibCodec3 = zlibCodec6;
				if (flag5)
				{
					continue;
				}
				bool flag6 = zlibCodec6.AvailableBytesIn != 8;
				zlibCodec3 = zlibCodec6;
				if (!flag6)
				{
					bool flag7 = zlibCodec6.AvailableBytesOut == 0;
					zlibCodec3 = zlibCodec6;
					if (!flag7)
					{
						break;
					}
				}
				goto IL_0395;
			}
			object obj2 = "in";
			if (_compressionMode == CompressionMode.Compress)
			{
				obj2 = "de";
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibCodec zlibCodec7 = _z;
			string text = text2 + "flating: " + zlibCodec7.Message;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex2._002Ector(text);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			zlibCodec3 = (ZlibCodec)(object)ex2;
			ZlibBaseStream zlibBaseStream = (ZlibBaseStream)(object)text;
		}
		while (num2 == 0);
	}

	private void finish()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0081: Expected I4, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_01b2: Expected Obj, but got I4
		//IL_01ba: Expected I, but got Obj
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_028e: Expected I, but got Obj
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected Obj, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected Obj, but got Unknown
		//IL_0453: Expected Obj, but got I4
		//IL_045b: Expected I, but got Obj
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_030b: Expected I, but got Obj
		//IL_0337: Expected I4, but got I8
		//IL_0343: Expected I, but got Obj
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected Obj, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_0707: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		ZlibCodec zlibCodec = _z;
		if (_z == null)
		{
			return;
		}
		bool flag = _streamMode == StreamMode.Writer;
		ZlibCodec zlibCodec2 = _z;
		string s;
		ZlibCodec zlibCodec11;
		if (!flag)
		{
			if (_streamMode != StreamMode.Reader || _flavor != ZlibStreamFlavor.GZIP)
			{
				return;
			}
			if (_compressionMode == CompressionMode.Compress)
			{
				goto IL_0864;
			}
			if (zlibCodec.TotalBytesOut == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			ZlibCodec zlibCodec3 = _z;
			Array array = default;
			if (zlibCodec3.AvailableBytesIn <= 7)
			{
				Array.Copy(zlibCodec3.InputBuffer, zlibCodec3.NextIn, array, 0, zlibCodec3.AvailableBytesIn);
				Stream stream = _stream;
				ZlibCodec zlibCodec4 = _z;
				ZlibCodec zlibCodec5 = _z;
				object obj3 = 8 - zlibCodec5.AvailableBytesIn;
				nint num = (nint)stream;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ S4_v27 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
				object obj4 = default;
				if (obj4 != obj3)
				{
					ZlibCodec zlibCodec6 = _z;
					object obj5 = obj4 + zlibCodec6.AvailableBytesIn;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
					object obj6 = obj + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
					object arg = default;
					s = $"Missing or incomplete GZIP trailer. Expected 8 bytes, got {arg}.";
					goto IL_0731;
				}
			}
			else
			{
				byte[] inputBuffer = zlibCodec3.InputBuffer;
				int nextIn = zlibCodec3.NextIn;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v133 (System.Array)+C]");
				Array.Copy(inputBuffer, nextIn, array, 0, 0);
			}
			int num2 = BitConverter.ToInt32((byte[])array, 0);
			CRC32 cRC = crc;
			int num3 = (int)cRC._register ^ -1;
			int num4 = BitConverter.ToInt32((byte[])array, 4);
			bool flag2 = num2 != num3;
			int num5 = num3;
			bool flag3 = (byte)num2 != 0;
			if (flag2)
			{
				goto IL_0873;
			}
			ZlibCodec zlibCodec7 = _z;
			if (num4 == zlibCodec7.TotalBytesOut)
			{
				return;
			}
			_ = zlibCodec7.TotalBytesOut;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			object obj7 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			object obj8 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg2 = default;
			object arg3 = default;
			s = $"Bad size in GZIP trailer. (actual({arg2})!=expected({arg3}))";
		}
		else
		{
			while (true)
			{
				byte[] outputBuffer = workingBuffer;
				zlibCodec2.OutputBuffer = outputBuffer;
				ZlibCodec zlibCodec8 = _z;
				zlibCodec8.NextOut = 0;
				byte[] array2 = _workingBuffer;
				zlibCodec8.AvailableBytesOut = array2.Length;
				int num6 = ((_compressionMode != CompressionMode.Compress) ? zlibCodec8.Inflate((FlushType)this) : zlibCodec8.Deflate(FlushType.Finish));
				if (num6 >= 2)
				{
					break;
				}
				byte[] array3 = _workingBuffer;
				ZlibCodec zlibCodec9 = _z;
				object obj9 = array3.Length - zlibCodec9.AvailableBytesOut;
				if ((nint)obj9 >= 1)
				{
					Stream stream2 = _stream;
					byte[] array4 = _workingBuffer;
					ZlibCodec zlibCodec10 = _z;
					object obj10 = array4.Length - zlibCodec10.AvailableBytesOut;
					nint num7 = (nint)stream2;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v242 @ S4_v16 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
				}
				zlibCodec11 = _z;
				bool flag4 = zlibCodec11.AvailableBytesIn == 0;
				bool flag5 = !flag4;
				bool flag3 = false;
				if (!flag5)
				{
					bool flag6 = zlibCodec11.AvailableBytesOut != 0;
					flag3 = flag6;
				}
				if (_flavor == ZlibStreamFlavor.GZIP && _compressionMode != CompressionMode.Compress)
				{
					bool flag7 = zlibCodec11.AvailableBytesIn != 8;
					zlibCodec2 = zlibCodec11;
					if (flag7)
					{
						continue;
					}
					bool flag8 = zlibCodec11.AvailableBytesOut == 0;
					zlibCodec2 = zlibCodec11;
					if (flag8)
					{
						continue;
					}
				}
				else
				{
					bool flag9 = !flag3;
					zlibCodec2 = zlibCodec11;
					if (flag9)
					{
						continue;
					}
				}
				goto IL_0289;
			}
			object obj11 = "in";
			if (_compressionMode == CompressionMode.Compress)
			{
				obj11 = "de";
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			string text2 = default;
			string text = text2 + "flating";
			ZlibCodec zlibCodec12 = _z;
			if (zlibCodec12.Message != null)
			{
				s = text + ": " + zlibCodec12.Message;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				object obj12 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				object arg4 = default;
				s = $"{text}: (rc = {arg4})";
			}
		}
		goto IL_0731;
		IL_0864:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex = default;
		ex._002Ector("Reading with compression is not supported.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0873;
		IL_0873:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj13 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj14 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg5 = default;
		object arg6 = default;
		s = $"Bad CRC32 in GZIP trailer. (actual({arg5:X8})!=expected({arg6:X8}))";
		goto IL_0731;
		IL_0289:
		nint num8 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v347 @ S1_v36 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+15C] (should have been resolved before IL gen)");
		if (_flavor == ZlibStreamFlavor.GZIP)
		{
			if (_compressionMode == CompressionMode.Compress)
			{
				CRC32 cRC2 = crc;
				int value = (int)cRC2._register ^ -1;
				Stream stream3 = _stream;
				byte[] bytes = BitConverter.GetBytes(value);
				nint num9 = (nint)stream3;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v469 @ S4_v7 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
				Stream stream4 = _stream;
				CRC32 cRC3 = crc;
				byte[] bytes2 = BitConverter.GetBytes((int)cRC3._TotalBytesRead);
				nint num10 = (nint)stream4;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v492 @ S4_v10 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex2 = default;
			ex2._002Ector("Writing with decompression is not supported.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			int num5 = zlibCodec11.AvailableBytesIn;
			goto IL_0864;
		}
		return;
		IL_0731:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex3 = default;
		ex3._002Ector(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private void end()
	{
		ZlibCodec zlibCodec = z;
		if (zlibCodec != null)
		{
			if (_compressionMode == CompressionMode.Compress)
			{
				int num = _z.EndDeflate();
			}
			else
			{
				int num2 = _z.EndInflate();
			}
			_z = null;
		}
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0199: Expected Obj, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(_disposed ? 1u : 0u) == 0)
		{
			return;
		}
		if (disposing && _stream != null)
		{
			object obj3 = obj + 28;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj4 = default;
				object obj5 = default;
				bool flag = obj4 != obj5;
				object obj7 = default;
				object obj6 = obj7;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						goto IL_0171;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					object obj8 = default;
					obj6 = obj8;
				}
				_ = 0;
				object obj9 = obj + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
			goto IL_0171;
		}
		goto IL_0229;
		IL_0229:
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream._disposed = true;
		return;
		IL_0171:
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9591");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		zlibBaseStream = (ZlibBaseStream)0;
		goto IL_0229;
	}

	~ZlibBaseStream()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_01c9: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag = (nint)0 != 1;
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
			object obj8 = default;
			object obj7 = obj8;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj4 = obj;
				if (flag4)
				{
					goto IL_01da;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj9 = default;
				obj7 = obj9;
			}
			_ = 0;
			object obj10 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
		}
		goto IL_01da;
		IL_01da:
		object obj11 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @36E");
	}

	public override void Flush()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Stream stream = _stream;
		nint num = (nint)stream;
		object obj = stream + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+15C] (should have been resolved before IL gen)");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_0037: Expected I8, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (long)ex;
	}

	public override void SetLength(long value)
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Stream stream = _stream;
		nint num = (nint)stream;
		object obj = stream + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S2_v2 (Il2CppClass<System.IO.Stream>)+1AC] (should have been resolved before IL gen)");
	}

	private string ReadZeroTerminatedString()
	{
		//IL_0017: Expected I, but got Obj
		//IL_00bb: Expected I, but got Obj
		List<byte> list = default;
		list._002Ector();
		object obj = default;
		string result = default;
		while (true)
		{
			Stream stream = _stream;
			nint num = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S4_v3 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
			if ((nint)obj != 1)
			{
				break;
			}
			byte[] buf = _buf1;
			if (buf[0] != 0)
			{
				byte[] buf2 = _buf1;
				list.Add(buf2[0]);
				continue;
			}
			byte[] array = list.ToArray();
			Encoding iso8859dash = GZipStream.iso8859dash1;
			nint num2 = (nint)iso8859dash;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S4_v6 (Il2CppClass<System.Text.Encoding>)+1F4] (should have been resolved before IL gen)");
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex = default;
		ex._002Ector("Unexpected EOF reading GZIP header.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (string)(object)ex;
	}

	private unsafe int _ReadAndValidateGzipHeader()
	{
		//IL_0306: Expected I, but got Obj
		//IL_02ea: Expected I4, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00dd: Expected F8, but got I4
		//IL_013b: Expected I, but got Obj
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_01ba: Expected I, but got Obj
		//IL_01f0: Expected I4, but got Obj
		//IL_0234: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Stream stream = _stream;
		nint num = (nint)stream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v25 @ S4_v2 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
		int num2 = default;
		bool flag = num2 == 0;
		int result = num2;
		ZlibException ex2;
		if (!flag)
		{
			if (num2 == 10)
			{
				byte[] array = default;
				if (array[0] == 31 && array[1] == 139 && array[2] == 8)
				{
					int num3 = BitConverter.ToInt32(array, 4);
					nint num4 = (nint)typeof(GZipStream);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v19 (Il2CppClass<Ionic.Zlib.GZipStream>)+5C]");
					DateTime gzipMtime = ((DateTime*)null)->AddSeconds(num3);
					_GzipMtime = gzipMtime;
					int num5 = array[3] & 4;
					bool flag2 = num5 == 0;
					result = 10;
					if (!flag2)
					{
						Stream stream2 = _stream;
						nint num6 = (nint)stream2;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v170 @ S4_v11 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
						object obj2 = default;
						object obj = obj2 + 10;
						int num7 = array[1] << 8;
						object obj3 = array[0] + num7;
						object obj4 = obj3 << 16;
						object obj5 = obj4 >> 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
						Stream stream3 = _stream;
						nint num8 = (nint)stream3;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v210 @ S4_v14 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
						object obj6 = default;
						if (obj6 != obj5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
							ZlibException ex = default;
							ex._002Ector("Unexpected end-of-file reading GZIP header.");
							ex2 = ex;
							goto IL_02cb;
						}
						int num9 = (int)(obj5 + obj);
						result = num9;
					}
					if ((array[3] & 8) != 0)
					{
						string gzipFileName = ReadZeroTerminatedString();
						_GzipFileName = gzipFileName;
					}
					if ((array[3] & 0x10) != 0)
					{
						string gzipComment = ReadZeroTerminatedString();
						_GzipComment = gzipComment;
					}
					if ((array[3] & 2) != 0)
					{
						nint num10 = (nint)this;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v241 @ S4_v8 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+1B4] (should have been resolved before IL gen)");
					}
					goto IL_0335;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ZlibException ex3 = default;
				ex3._002Ector("Bad GZIP header.");
				ex2 = ex3;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ZlibException ex4 = default;
				ex4._002Ector("Not a valid GZIP stream.");
				ex2 = ex4;
			}
			goto IL_02cb;
		}
		goto IL_0335;
		IL_0335:
		return result;
		IL_02cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex2;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		//IL_0767: Expected I4, but got Obj
		//IL_0202: Expected Obj, but got I4
		//IL_0335: Expected I4, but got Obj
		//IL_02b9: Expected I, but got Obj
		//IL_046f: Expected Obj, but got I4
		//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected Obj, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		StreamMode streamMode = _streamMode;
		ZlibException ex2;
		int result;
		if (_streamMode == StreamMode.Undefined)
		{
			Stream stream = _stream;
			nint num = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v17 @ S1_v67 (Il2CppClass<System.IO.Stream>)+F4] (should have been resolved before IL gen)");
			object obj3 = default;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ZlibException ex = default;
				ex._002Ector("The stream is not readable.");
				ex2 = ex;
				goto IL_0748;
			}
			_streamMode = StreamMode.Reader;
			ZlibCodec zlibCodec = z;
			zlibCodec.AvailableBytesIn = 0;
			if (_flavor == ZlibStreamFlavor.GZIP)
			{
				bool flag = (_gzipHeaderByteCount = _ReadAndValidateGzipHeader()) == 0;
				result = 0;
				if (flag)
				{
					goto IL_05db;
				}
			}
			streamMode = _streamMode;
		}
		ZlibCodec zlibCodec6;
		int num4;
		if (streamMode == StreamMode.Reader)
		{
			bool flag2 = count == 0;
			result = 0;
			if (flag2)
			{
				goto IL_05db;
			}
			if (~(nomoreinput ? 1u : 0u) == 0)
			{
				bool flag3 = _compressionMode == CompressionMode.Compress;
				result = 0;
				if (flag3)
				{
					goto IL_05db;
				}
			}
			if (buffer != null)
			{
				if (count > -1)
				{
					int lowerBound = buffer.GetLowerBound(0);
					if (lowerBound > offset)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						ArgumentOutOfRangeException ex3 = default;
						ex3._002Ector("offset");
						ex2 = (ZlibException)(object)ex3;
						goto IL_0748;
					}
					int length = buffer.GetLength(0);
					object obj4 = offset + count;
					if (length >= (nint)obj4)
					{
						ZlibCodec zlibCodec2 = _z;
						zlibCodec2.OutputBuffer = buffer;
						ZlibCodec zlibCodec3 = _z;
						zlibCodec3.AvailableBytesOut = count;
						zlibCodec3.NextOut = offset;
						byte[] inputBuffer = workingBuffer;
						zlibCodec3.InputBuffer = inputBuffer;
						ZlibCodec zlibCodec4 = _z;
						int availableBytesIn = default;
						while (true)
						{
							if (zlibCodec4.AvailableBytesIn == 0 && !nomoreinput)
							{
								zlibCodec4.NextIn = 0;
								Stream stream2 = _stream;
								byte[] array = _workingBuffer;
								nint num2 = (nint)stream2;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v301 @ S5_v5 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
								zlibCodec4.AvailableBytesIn = availableBytesIn;
								ZlibCodec zlibCodec5 = _z;
								zlibCodec4 = _z;
								if (zlibCodec5.AvailableBytesIn == 0)
								{
									nomoreinput = true;
									zlibCodec4 = _z;
								}
							}
							int num3 = ((_compressionMode != CompressionMode.Compress) ? zlibCodec4.Inflate((FlushType)this) : zlibCodec4.Deflate(_flushMode));
							if (~(nomoreinput ? 1u : 0u) == 0 && num3 == -5)
							{
								break;
							}
							if (num3 >= 2)
							{
								goto IL_03b0;
							}
							zlibCodec6 = _z;
							bool flag4 = (byte)(~(nomoreinput ? 1u : 0u)) != 0;
							bool flag5 = num3 != 1;
							object obj5 = flag4 & flag5;
							if (obj5 == null && count == zlibCodec6.AvailableBytesOut)
							{
								num4 = count;
							}
							else
							{
								bool flag6 = zlibCodec6.AvailableBytesOut < 1;
								num4 = zlibCodec6.AvailableBytesOut;
								if (!flag6)
								{
									num4 = zlibCodec6.AvailableBytesOut;
									if (num3 == 0)
									{
										bool flag7 = (byte)(~(nomoreinput ? 1u : 0u)) != 0;
										num4 = zlibCodec6.AvailableBytesOut;
										zlibCodec4 = zlibCodec6;
										if (flag7)
										{
											continue;
										}
									}
								}
							}
							goto IL_0526;
						}
						result = 0;
						goto IL_05db;
					}
				}
				goto IL_0787;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentNullException ex4 = default;
			ex4._002Ector("buffer");
			ex2 = (ZlibException)(object)ex4;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex5 = default;
			ex5._002Ector("Cannot Read after Writing.");
			ex2 = ex5;
		}
		goto IL_0748;
		IL_06f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex6 = default;
		string s;
		ex6._002Ector(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0787;
		IL_03b0:
		bool flag8 = _compressionMode == CompressionMode.Compress;
		bool flag9 = !flag8;
		bool flag10 = !flag9;
		string format = "{0}flating:  rc={1}  msg={2}";
		object obj6 = "de";
		if (!flag10)
		{
			format = "{0}flating:  rc={1}  msg={2}";
			obj6 = "in";
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj7 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		ZlibCodec zlibCodec7 = _z;
		object arg = default;
		object arg2 = default;
		s = string.Format(format, arg, arg2, zlibCodec7.Message);
		goto IL_06f2;
		IL_0787:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ArgumentOutOfRangeException ex7 = default;
		ex7._002Ector("count");
		ex2 = (ZlibException)(object)ex7;
		goto IL_0748;
		IL_05db:
		return result;
		IL_0748:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex2;
		IL_0526:
		if (num4 >= 1 && ~(nomoreinput ? 1u : 0u) == 0 && _compressionMode == CompressionMode.Compress)
		{
			int num5 = zlibCodec6.Deflate(FlushType.Finish);
			if (num5 > 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				object obj8 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				ZlibCodec zlibCodec8 = _z;
				object arg3 = default;
				s = $"Deflating:  rc={arg3}  msg={zlibCodec8.Message}";
				goto IL_06f2;
			}
			ZlibCodec zlibCodec9 = _z;
			num4 = zlibCodec9.AvailableBytesOut;
		}
		int num6 = count - num4;
		bool flag11 = crc == null;
		result = num6;
		if (!flag11)
		{
			crc.SlurpBlock(buffer, offset, num6);
			result = num6;
		}
		goto IL_05db;
	}

	public static void CompressString(string s, Stream compressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_016a: Expected I, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		Encoding uTF = Encoding.UTF8;
		nint num = (nint)uTF;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S2_v2 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj4 = default;
			object obj5 = default;
			bool flag = obj4 == obj5;
			bool flag2 = !flag;
			object obj7 = default;
			object obj6 = obj7;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01dd;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj8 = default;
				obj6 = obj8;
			}
			_ = 0;
			object obj9 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		goto IL_01dd;
		IL_01dd:
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	public static void CompressBuffer(byte[] b, Stream compressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected Obj, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			object obj4 = default;
			object obj5 = default;
			bool flag = obj4 == obj5;
			bool flag2 = !flag;
			object obj7 = default;
			object obj6 = obj7;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_01c2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				object obj8 = default;
				obj6 = obj8;
			}
			_ = 0;
			object obj9 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		goto IL_01c2;
		IL_01c2:
		object obj10 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
	}

	public static string UncompressString(byte[] compressed, Stream decompressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected Obj, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected Obj, but got Unknown
		//IL_043c: Expected Obj, but got I
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Encoding uTF = Encoding.UTF8;
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 24;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		string result;
		string text = default;
		string text2 = default;
		object obj9 = default;
		object obj11;
		object obj12 = default;
		string text3 = default;
		string text4 = default;
		object obj14 = default;
		string text5 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_0182;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 != obj7;
			result = text;
			object obj8 = obj6;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0182;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = text2;
				obj8 = obj9;
			}
			_ = 0;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				obj11 = obj;
				goto IL_044a;
			}
			goto IL_0545;
			IL_0545:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj12 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag2 = (nint)0 != 1;
				result = null;
				obj11 = obj;
				if (flag2)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				result = text3;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj11 = 0;
			if (!flag3)
			{
				goto IL_044a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return result;
			IL_044a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
			IL_034f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			result = text4;
			obj8 = obj14;
			goto IL_0545;
			IL_0182:
			_ = 0;
			object obj15 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D25");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							result = text5;
							obj11 = obj;
							if (flag4)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							goto IL_034f;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_034f;
		}
		object obj16 = obj11 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected Obj, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected Obj, but got Unknown
		//IL_03af: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 24;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		byte[] array;
		byte[] array2 = default;
		byte[] array3 = default;
		object obj9 = default;
		object obj11;
		object obj12 = default;
		byte[] array5 = default;
		byte[] array6 = default;
		byte[] array7 = default;
		object obj15 = default;
		byte[] array8 = default;
		object obj16 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_0179;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 != obj7;
			array = array2;
			object obj8 = obj6;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_0179;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				array = array3;
				obj8 = obj9;
			}
			_ = 0;
			object obj10 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag2 = (nint)0 == 1;
			byte[] array4 = array;
			obj11 = obj;
			if (!flag2)
			{
				goto IL_02a8;
			}
			goto IL_03bd;
			IL_02a8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj12 == obj8)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag3 = (nint)0 != 1;
				array = null;
				obj11 = obj;
				if (flag3)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				array4 = array5;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			array = array4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj11 = 0;
			if (!flag4)
			{
				goto IL_03bd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return array4;
			IL_0179:
			_ = 0;
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag5 = (nint)0 != 1;
				array = array6;
				obj11 = obj;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				array4 = array7;
				obj8 = obj15;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				array4 = array8;
				obj8 = obj16;
			}
			goto IL_02a8;
			IL_03bd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
		}
		object obj17 = obj11 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return array;
	}
}
