using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;

namespace Ionic.Zlib;

public class GZipStream : Stream
{
	public DateTime? LastModified;

	private int _headerByteCount;

	internal ZlibBaseStream _baseStream;

	private bool _disposed;

	private bool _firstReadDone;

	private string _FileName;

	private string _Comment;

	private int _Crc32;

	internal static readonly DateTime _unixEpoch;

	internal static readonly Encoding iso8859dash1;

	public string Comment
	{
		get
		{
			return _Comment;
		}
		set
		{
			ObjectDisposedException ex = default;
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ex._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			((GZipStream)(object)ex)._Comment = value;
		}
	}

	public string FileName
	{
		get
		{
			return _FileName;
		}
		set
		{
			if (~(_disposed ? 1u : 0u) != 0)
			{
				_FileName = value;
				if (_FileName == null)
				{
					return;
				}
				int num = _FileName.IndexOf("/");
				if (num != -1)
				{
					string fileName = _FileName.Replace("/", "\\");
					_FileName = fileName;
				}
				if (!_FileName.EndsWith("\\"))
				{
					int num2 = _FileName.IndexOf("\\");
					if (num2 != -1)
					{
						string fileName2 = Path.GetFileName(_FileName);
						_FileName = fileName2;
					}
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ObjectDisposedException ex = default;
				ex._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Exception ex2 = default;
			ex2._002Ector("Illegal filename");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public int Crc32 => _Crc32;

	public virtual FlushType FlushMode
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			return baseStream._flushMode;
		}
		set
		{
			ObjectDisposedException ex = default;
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ex._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((GZipStream)(object)ex)._baseStream;
			baseStream._flushMode = value;
		}
	}

	public int BufferSize
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			return baseStream._bufferSize;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected Obj, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - 16;
			if (~(_disposed ? 1u : 0u) != 0)
			{
				ZlibBaseStream baseStream = _baseStream;
				if (baseStream._workingBuffer == null)
				{
					if (value > 1023)
					{
						baseStream._bufferSize = value;
						return;
					}
					goto IL_0169;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ObjectDisposedException ex = default;
				ex._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex2 = default;
			ex2._002Ector("The working buffer is already set.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			goto IL_0169;
			IL_0169:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			_ = 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			object obj4 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			object arg2 = default;
			string s = $"Don't be silly. {arg} bytes?? Use a bigger buffer, at least {arg2}.";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex3 = default;
			ex3._002Ector(s);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public virtual long TotalIn
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			ZlibCodec z = baseStream._z;
			return z.TotalBytesIn;
		}
	}

	public virtual long TotalOut
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			ZlibCodec z = baseStream._z;
			return z.TotalBytesOut;
		}
	}

	public override bool CanRead
	{
		get
		{
			//IL_007c: Expected I, but got Obj
			ObjectDisposedException ex = default;
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ex._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((GZipStream)(object)ex)._baseStream;
			Stream stream = baseStream._stream;
			nint num = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v3 (Il2CppClass<System.IO.Stream>)+F4] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			//IL_007c: Expected I, but got Obj
			ObjectDisposedException ex = default;
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ex._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((GZipStream)(object)ex)._baseStream;
			Stream stream = baseStream._stream;
			nint num = (nint)stream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v21 @ S1_v3 (Il2CppClass<System.IO.Stream>)+10C] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override long Length
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
	}

	public override long Position
	{
		get
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_00be: Expected I8, but got Obj
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected Obj, but got Unknown
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected Obj, but got Unknown
			ZlibBaseStream baseStream = _baseStream;
			object obj2;
			object obj3;
			if (baseStream._streamMode != ZlibBaseStream.StreamMode.Writer)
			{
				if (baseStream._streamMode != ZlibBaseStream.StreamMode.Reader)
				{
					long result = default;
					return result;
				}
				object obj = baseStream + 88;
				obj2 = baseStream._z + 24;
				obj3 = obj;
			}
			else
			{
				object obj4 = this + 40;
				obj2 = baseStream._z + 48;
				obj3 = obj4;
			}
			return (long)(obj2 + obj3);
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

	public GZipStream(Stream stream, CompressionMode mode)
		: this(stream, mode, CompressionLevel.Default, leaveOpen: false)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		: this(stream, mode, level, leaveOpen: false)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		: this(stream, mode, CompressionLevel.Default, leaveOpen)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream._002Ector(stream, mode, level, ZlibStreamFlavor.GZIP, leaveOpen);
		_baseStream = zlibBaseStream;
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0059: Expected Obj, but got I
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_016d: Expected Obj, but got I4
		//IL_015f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		object obj4 = obj + 27;
		obj = obj4;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10+30]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10+2C]");
				if ((nint)0 != 0)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
						object obj6 = default;
						object obj7 = default;
						bool flag = obj6 == obj7;
						bool flag2 = !flag;
						object obj9 = default;
						object obj8 = obj9;
						if (!flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								goto IL_029c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							object obj10 = default;
							obj8 = obj10;
						}
						_ = 0;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						goto IL_029c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v62+2C]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v35+44]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v35+44]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v36+20]");
						object obj14 = (nint)0 ^ (nint)(-1);
					}
					else
					{
						object obj14 = 0;
					}
				}
			}
			_ = 1;
		}
		goto IL_029c;
		IL_029c:
		object obj15 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A77");
	}

	public override void Flush()
	{
		//IL_006f: Expected I, but got Obj
		ObjectDisposedException ex = default;
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("GZipStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		ZlibBaseStream baseStream = ((GZipStream)(object)ex)._baseStream;
		nint num = (nint)baseStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v3 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+15C] (should have been resolved before IL gen)");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_0036: Expected I, but got Obj
		//IL_00ec: Expected I4, but got Obj
		if (~(_disposed ? 1u : 0u) != 0)
		{
			ZlibBaseStream baseStream = _baseStream;
			nint num = (nint)baseStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S4_v2 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+1B4] (should have been resolved before IL gen)");
			if (~(_firstReadDone ? 1u : 0u) != 0)
			{
				_firstReadDone = true;
				ZlibBaseStream baseStream2 = _baseStream;
				FileName = baseStream2._GzipFileName;
				ZlibBaseStream baseStream3 = _baseStream;
				Comment = baseStream3._GzipComment;
			}
			int result = default;
			return result;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ObjectDisposedException ex = default;
		ex._002Ector("GZipStream");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotImplementedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_00fd: Expected I, but got Obj
		if (~(_disposed ? 1u : 0u) != 0)
		{
			ZlibBaseStream baseStream = _baseStream;
			bool flag = baseStream._streamMode == ZlibBaseStream.StreamMode.Undefined;
			bool flag2 = !flag;
			ZlibBaseStream zlibBaseStream = baseStream;
			if (!flag2)
			{
				if (baseStream._compressionMode != CompressionMode.Compress)
				{
					goto IL_0108;
				}
				int headerByteCount = EmitHeader();
				_headerByteCount = headerByteCount;
				zlibBaseStream = _baseStream;
			}
			nint num = (nint)zlibBaseStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v33 @ S4_v2 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+1CC] (should have been resolved before IL gen)");
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ObjectDisposedException ex = default;
		ex._002Ector("GZipStream");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_0108;
		IL_0108:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		InvalidOperationException ex2 = default;
		ex2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	private unsafe int EmitHeader()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0024: Expected I, but got Obj
		//IL_0044: Expected I, but got Obj
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected VT, but got Unknown
		//IL_0302: Invalid comparison between VT and I4
		//IL_0084: Expected Obj, but got I
		//IL_03e0: Expected Ref, but got VT
		//IL_00d8: Expected VT, but got I
		//IL_015b: Expected I4, but got F8
		//IL_0408: Expected I, but got Obj
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected I4, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected I4, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected I4, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected Obj, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		if (_Comment != null)
		{
			Encoding encoding = iso8859dash1;
			nint num = (nint)encoding;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v51 @ S2_v24 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		}
		if (_FileName != null)
		{
			Encoding encoding2 = iso8859dash1;
			nint num2 = (nint)encoding2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v81 @ S2_v21 (Il2CppClass<System.Text.Encoding>)+154] (should have been resolved before IL gen)");
		}
		object obj3 = default;
		if (_Comment != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v103 (System.Array)+C]");
			obj3 = (nint)0 + (nint)1;
		}
		object obj4 = default;
		if (_FileName != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v96 (System.Array)+C]");
			obj4 = (nint)0 + (nint)1;
		}
		object obj5 = obj3 + 10;
		object obj6 = obj4 + obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = 31;
		_ = 139;
		_ = 8;
		bool flag = _Comment != null;
		object obj7 = (flag ? 1u : 0u) << 4;
		object obj8 = obj7 | 8;
		if (_FileName == null)
		{
			obj8 = obj7;
		}
		DateTime? dateTime = (DateTime?)(object)(this + 24);
		if ((DateTime)dateTime == (DateTime)(object)0)
		{
			DateTime now = DateTime.Now;
			_ = 0;
			_ = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			dateTime = (DateTime?)(object)0;
		}
		DateTime value = ((DateTime?*)dateTime)->Value;
		TimeSpan timeSpan = value - _unixEpoch;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		double num3 = 0.0 * 1E-07;
		double num4 = Math.Abs(num3);
		int value2 = ((!(num4 < 2147483648.0)) ? int.MinValue : ((int)num3));
		byte[] bytes = BitConverter.GetBytes(value2);
		Array array = default;
		Array.Copy(bytes, 0, array, 4, 4);
		_ = 0;
		_ = 255;
		bool flag2 = obj4 == null;
		int num5 = 10;
		if (!flag2)
		{
			int length = obj4 - 1;
			Array sourceArray = default;
			Array.Copy(sourceArray, 0, array, 10, length);
			object obj9 = obj4 + 9;
			int num6 = obj9 + 1;
			object obj10 = (object)array + obj9;
			_ = 0;
			num5 = num6;
		}
		if (obj3 != null)
		{
			int length2 = obj3 - 1;
			Array sourceArray2 = default;
			Array.Copy(sourceArray2, 0, array, num5, length2);
			object obj11 = obj3 - 1;
			object obj12 = obj11 + num5;
			object obj13 = obj12 + (object)array;
			_ = 0;
		}
		ZlibBaseStream baseStream = _baseStream;
		Stream stream = baseStream._stream;
		nint num7 = (nint)stream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ S4_v5 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v16 (System.Array)+C]");
		return 0;
	}

	public static byte[] CompressString(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] result;
		object obj4;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					byte[] array = default;
					result = array;
					obj4 = obj;
					if (flag)
					{
						goto IL_02dd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_012f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_012f;
		IL_012f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		byte[] array3 = default;
		byte[] array2 = array3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			obj4 = obj;
			if (flag4)
			{
				goto IL_02dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array4 = default;
			array2 = array4;
		}
		_ = 0;
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
			goto IL_02dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return array2;
		IL_02dd:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static byte[] CompressBuffer(byte[] b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected Obj, but got Unknown
		//IL_027f: Expected Obj, but got I
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		MemoryStream memoryStream = default;
		memoryStream._002Ector();
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] result;
		object obj4;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 != 1;
					byte[] array = default;
					result = array;
					obj4 = obj;
					if (flag)
					{
						goto IL_02dd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_012f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_012f;
		IL_012f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag2 = obj5 == obj6;
		bool flag3 = !flag2;
		byte[] array3 = default;
		byte[] array2 = array3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			obj4 = obj;
			if (flag4)
			{
				goto IL_02dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array4 = default;
			array2 = array4;
		}
		_ = 0;
		object obj7 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
			goto IL_02dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return array2;
		IL_02dd:
		object obj8 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
	}

	public static string UncompressString(byte[] compressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		MemoryStream memoryStream = default;
		memoryStream._002Ector(compressed);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		string result;
		object obj4;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				string text = default;
				result = text;
				obj4 = obj;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					goto IL_00e5;
				}
				goto IL_028f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_00e5;
		IL_028f:
		object obj5 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag2 = obj6 == obj7;
		bool flag3 = !flag2;
		string text2 = default;
		result = text2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			obj4 = obj;
			if (flag4)
			{
				goto IL_028f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			string text3 = default;
			result = text3;
		}
		_ = 0;
		object obj8 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
			goto IL_028f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return result;
	}

	public static byte[] UncompressBuffer(byte[] compressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected Obj, but got Unknown
		//IL_0235: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		MemoryStream memoryStream = default;
		memoryStream._002Ector(compressed);
		object obj3 = obj + 28;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		byte[] result;
		object obj4;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag = (nint)0 != 1;
				byte[] array = default;
				result = array;
				obj4 = obj;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					goto IL_00e5;
				}
				goto IL_0297;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_00e5;
		IL_0297:
		object obj5 = obj4 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @245");
		return result;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj6 = default;
		object obj7 = default;
		bool flag2 = obj6 == obj7;
		bool flag3 = !flag2;
		byte[] array3 = default;
		byte[] array2 = array3;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 != 1;
			result = null;
			obj4 = obj;
			if (flag4)
			{
				goto IL_0297;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			byte[] array4 = default;
			array2 = array4;
		}
		_ = 0;
		object obj8 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			result = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj4 = 0;
			goto IL_0297;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return array2;
	}

	unsafe static GZipStream()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected VT, but got Unknown
		//IL_004e: Expected native int or pointer, but got VT
		//IL_0064: Expected VT, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		DateTime dateTime = (DateTime)(obj + 8);
		*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_unixEpoch = (DateTime)0;
		Encoding encoding = Encoding.GetEncoding("iso-8859-1");
		iso8859dash1 = encoding;
	}
}
