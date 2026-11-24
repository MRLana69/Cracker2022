using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using UI;

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
			string result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Expected Obj, but got Unknown
			//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ee: Expected Obj, but got Unknown
			//IL_021a: Expected Obj, but got I4
			//IL_0223: Expected Obj, but got I4
			//IL_0128: Expected Obj, but got I
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected Obj, but got Unknown
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+1C]");
			if ((nint)0 == 0)
			{
				if (value != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+14]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
					}
				}
				_ = 1;
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
	}

	public string FileName
	{
		get
		{
			return _Comment;
		}
		set
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ObsoleteAttribute obsoleteAttribute = default;
				obsoleteAttribute._002Ector("GZipStream");
				((GZipStream)(object)obsoleteAttribute).Comment = null;
			}
			else
			{
				object obj = this + 56;
				obj = value;
			}
		}
	}

	public int Crc32
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)_FileName;
		}
	}

	public virtual FlushType FlushMode
	{
		get
		{
			return (FlushType)_Crc32;
		}
		set
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected Obj, but got Unknown
			//IL_0044: Expected Obj, but got I4
			//IL_0073: Expected I4, but got Obj
			//IL_01f6: Expected I4, but got Obj
			//IL_010f: Expected I4, but got Obj
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Expected Obj, but got Unknown
			//IL_00c2: Expected I4, but got Obj
			//IL_00c2: Expected I4, but got Obj
			//IL_00eb: Expected I4, but got Obj
			//IL_014c: Expected I, but got Obj
			//IL_0162: Expected Obj, but got I
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Expected Obj, but got Unknown
			//IL_018d: Expected I, but got Obj
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ObsoleteAttribute obsoleteAttribute = default;
				obsoleteAttribute._002Ector("GZipStream");
				((GZipStream)(object)obsoleteAttribute).FileName = null;
			}
			object obj = this + 52;
			obj = value;
			if (_FileName == null)
			{
				return;
			}
			int num = _FileName.LastIndexOf((char)(int)"/");
			if (num != -1)
			{
				object obj2 = this + 52;
				string text = _FileName.Remove((int)"/", (int)"\\");
				obj2 = text;
			}
			if (_FileName.EndsWith((char)(int)"\\"))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Exception ex = default;
				ex.SetErrorCode((int)"Illegal filename");
				((GZipStream)(object)ex).FileName = null;
			}
			int num2 = _FileName.LastIndexOf((char)(int)"\\");
			if (num2 == -1)
			{
				return;
			}
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v29 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v35 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = this + 52;
			string fullPath = Path.GetFullPath(_FileName);
			obj4 = fullPath;
		}
	}

	public int BufferSize
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			return (int)baseStream._flushMode;
		}
		set
		{
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ObsoleteAttribute obsoleteAttribute = default;
				obsoleteAttribute._002Ector("GZipStream");
				((GZipStream)(object)obsoleteAttribute).FlushMode = FlushType.None;
			}
			else
			{
				ZlibBaseStream baseStream = _baseStream;
				baseStream._flushMode = (FlushType)value;
			}
		}
	}

	public virtual long TotalIn
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+14]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+14]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v4+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2+18]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+14]");
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

	public virtual long TotalOut
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			ZlibCodec z = baseStream._z;
			return z.TotalBytesIn;
		}
	}

	public override bool CanRead
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			return (byte)baseStream._bufferSize != 0;
		}
	}

	public override bool CanSeek
	{
		get
		{
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ObsoleteAttribute obsoleteAttribute = default;
				obsoleteAttribute._002Ector("GZipStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				return false;
			}
			ZlibBaseStream baseStream = _baseStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
	}

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			ZlibCodec z = baseStream._z;
			return z.TotalBytesOut;
		}
	}

	public override long Position
	{
		get
		{
			//IL_000b: Expected I8, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return 0L;
		}
		set
		{
			//IL_0027: Expected I8, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector();
			((DeflateStream)(object)ex).SetLength(0L);
		}
	}

	public GZipStream(Stream stream, CompressionMode mode)
		: this(stream, mode, CompressionLevel.Default, leaveOpen: false)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("DeflateStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		}
	}

	public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		: base(stream, mode, leaveOpen ? CompressionLevel.BestSpeed : CompressionLevel.None, false)
	{
	}

	public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Stream>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Stream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<System.IO.Stream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 24;
		obj2 = stream;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FriendsLoginFBButton friendsLoginFBButton = default;
		friendsLoginFBButton.Init((Action)(object)stream, (byte)mode != 0, (byte)level != 0, isGameOverScreen: true, (Action)leaveOpen);
		object obj3 = this + 20;
		obj3 = friendsLoginFBButton;
	}

	protected override void Dispose(bool disposing)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_0079: Expected I4, but got Obj
		//IL_00cf: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_0123: Expected I4, but got Obj
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("GZipStream");
			((GZipStream)(object)obsoleteAttribute).BufferSize = 0;
		}
		ZlibBaseStream baseStream = _baseStream;
		if (baseStream._workingBuffer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"The working buffer is already set." != 0);
			((GZipStream)(object)zlibBaseStream).BufferSize = 0;
		}
		object obj2 = default;
		object obj = obj2 + 4;
		if ((disposing ? 1 : 0) < 1024)
		{
			obj = disposing;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format = default;
			object arg = default;
			string text = string.Format((IFormatProvider)(object)"Don't be silly. {0} bytes?? Use a bigger buffer, at least {1}.", format, arg);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream2 = default;
			zlibBaseStream2.Dispose((byte)(int)text != 0);
			((GZipStream)(object)zlibBaseStream2).BufferSize = 0;
		}
		else
		{
			ZlibBaseStream baseStream2 = _baseStream;
			baseStream2._bufferSize = (disposing ? 1 : 0);
		}
	}

	public override void Flush()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("DeflateStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.GZipStream)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("DeflateStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		int result = default;
		return result;
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
		((GZipStream)(object)ex).Position = 0L;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		((ZlibStream)this)._002Ector((Stream)(object)buffer, (CompressionMode)offset, CompressionLevel.Default, (byte)count != 0);
	}

	private int EmitHeader()
	{
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("GZipStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return 0;
		}
		ZlibBaseStream baseStream = _baseStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int result = default;
		return result;
	}

	public unsafe static byte[] CompressString(string s)
	{
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a5: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I4
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected Obj, but got Unknown
		//IL_014b: Expected Obj, but got I
		//IL_00ec: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I4
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05a1: Expected Obj, but got I4
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05b8: Expected Obj, but got I4
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_05cf: Expected Obj, but got I4
		//IL_0174: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I4
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0190: Expected Obj, but got I4
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081a: Expected VT, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected Obj, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected Obj, but got Unknown
		//IL_0847: Unknown result type (might be due to invalid IL or missing references)
		//IL_084c: Expected Obj, but got Unknown
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected VT, but got Unknown
		//IL_0646: Expected Ref, but got VT
		//IL_0658: Expected I, but got Obj
		//IL_066e: Expected Obj, but got I
		//IL_0715: Expected I, but got Obj
		//IL_072b: Expected Obj, but got I
		//IL_01be: Expected I, but got Obj
		//IL_01d4: Expected Obj, but got I
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088a: Expected Obj, but got Unknown
		//IL_0892: Expected Obj, but got VT
		//IL_089b: Expected Obj, but got VT
		//IL_08a8: Expected I8, but got Obj
		//IL_08a3: Expected native int or pointer, but got VT
		//IL_08bd: Expected Ref, but got VT
		//IL_08c9: Expected Obj, but got I8
		//IL_08eb: Expected I, but got Obj
		//IL_0901: Expected Obj, but got I
		//IL_024c: Expected I, but got Obj
		//IL_06a2: Expected I8, but got I4
		//IL_069d: Expected native int or pointer, but got VT
		//IL_06b0: Expected Obj, but got VT
		//IL_06c5: Expected VT, but got Obj
		//IL_06c0: Expected native int or pointer, but got VT
		//IL_06d2: Expected Obj, but got I8
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected Obj, but got Unknown
		//IL_0299: Expected I, but got Obj
		//IL_01ff: Expected I, but got Obj
		//IL_02e6: Expected I, but got Obj
		//IL_03b5: Expected I4, but got F8
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected Obj, but got Unknown
		//IL_07b2: Expected Obj, but got I4
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected Obj, but got Unknown
		//IL_07c9: Expected Obj, but got I4
		//IL_092e: Expected Obj, but got I
		//IL_0937: Unknown result type (might be due to invalid IL or missing references)
		//IL_093c: Expected Obj, but got Unknown
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected I4, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected I4, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0423: Expected Obj, but got I4
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected I4, but got Unknown
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected Obj, but got Unknown
		//IL_0489: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+38]");
		Array sourceArray = default;
		if ((nint)0 != 0)
		{
			nint num = (nint)typeof(GZipStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v174 (Il2CppClass<Ionic.Zlib.GZipStream>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(GZipStream);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v180 (Il2CppClass<Ionic.Zlib.GZipStream>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
		else
		{
			sourceArray = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+34]");
		Array sourceArray2 = default;
		if ((nint)0 != 0)
		{
			nint num3 = (nint)typeof(GZipStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v160 (Il2CppClass<Ionic.Zlib.GZipStream>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(GZipStream);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v166 (Il2CppClass<Ionic.Zlib.GZipStream>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		}
		else
		{
			sourceArray2 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+38]");
		object obj5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v12 (System.Array)+C]");
			obj5 = (nint)0 + (nint)1;
		}
		else
		{
			obj5 = 0;
		}
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 48);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+34]");
		object obj6;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v15 (System.Array)+C]");
			obj6 = (nint)0 + (nint)1;
		}
		else
		{
			obj6 = 0;
		}
		object obj7 = obj5 + 10;
		object obj8 = obj6 + obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Array array = default;
		object obj9 = array + 16;
		obj9 = 31;
		object obj10 = array + 17;
		obj10 = -117;
		object obj11 = array + 18;
		obj11 = 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+38]");
		object obj12 = (((nint)0 == 0) ? ((object)0) : ((object)16));
		object obj13 = obj12 | 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+34]");
		bool flag = (nint)0 == 0;
		object obj14 = obj12;
		if (!flag)
		{
			obj14 = obj13;
		}
		DateTime dateTime = (DateTime)(obj2 + 32);
		object obj15 = obj2 + 24;
		object obj16 = array + 19;
		obj16 = obj14;
		object obj17 = s + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v45+8]");
		if ((nint)0 == 0)
		{
			nint num5 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v129 (Il2CppClass<System.DateTime>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num6 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v147 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			DateTime utcNow = DateTime.UtcNow;
			((DateTime*)(nint)dateTime)->dateData = 0uL;
			_ = 0;
			obj15 = utcNow;
			formatProvider = (IFormatProvider)obj15;
			*(DateTime?*)(nint)dateTime = (DateTime)formatProvider;
			formatProvider = (IFormatProvider)dateTime.dateData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v37 (System.DateTime)+8]");
			_ = 0;
			object obj19 = s + 24;
			obj19 = formatProvider;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v20 (System.IFormatProvider)+8]");
			_ = 0;
		}
		DateTime? dateTime2 = (DateTime?)(object)(s + 24);
		DateTime value = ((DateTime?*)dateTime2)->Value;
		nint num7 = (nint)typeof(GZipStream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v53 (Il2CppClass<Ionic.Zlib.GZipStream>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num8 = (nint)typeof(GZipStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v122 (Il2CppClass<Ionic.Zlib.GZipStream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num9 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v61 (Il2CppClass<System.DateTime>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num10 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v118 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = obj2 + 16;
		obj22 = value;
		obj2 = _unixEpoch;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj22;
		formatProvider = (IFormatProvider)obj2;
		long num11 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num11;
		double num12 = (double)obj * 1E-07;
		nint num13 = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ S0_v75 (Il2CppClass<System.BitConverter>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num14 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v114 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ushort value2;
		if (num12 != num12)
		{
			value2 = 0;
		}
		else if (num12 < 2147483648.0)
		{
			value2 = ((num12 > -2147483649.0) ? ((ushort)(int)num12) : ((ushort)0));
		}
		else
		{
			value2 = 0;
		}
		byte[] bytes = BitConverter.GetBytes(value2);
		Array.ConstrainedCopy(bytes, 0, array, 4, 4);
		object obj24 = array + 24;
		obj24 = 0;
		object obj25 = array + 25;
		obj25 = -1;
		bool flag2 = obj6 == null;
		int num15 = 10;
		if (!flag2)
		{
			int length = obj6 - 1;
			Array.ConstrainedCopy(sourceArray2, 0, array, 10, length);
			object obj26 = obj6 + 9;
			int num16 = obj26 + 1;
			object obj27 = array + 16;
			object obj28 = obj27 + obj26;
			obj28 = 0;
			num15 = num16;
		}
		if (obj5 != null)
		{
			int length2 = obj5 - 1;
			Array.ConstrainedCopy(sourceArray, 0, array, num15, length2);
			object obj29 = obj5 + num15;
			object obj30 = (object)array + obj29;
			object obj31 = obj30 + 15;
			obj31 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+2C]");
		object obj32 = 0;
		object result = array + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
		return (byte[])result;
	}

	public static byte[] CompressBuffer(byte[] b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 42;
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
			if ((nint)obj9 == 42)
			{
				object obj10 = obj2 + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
				goto IL_02a4;
			}
		}
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02a4;
		IL_02a4:
		byte[] result = default;
		return result;
	}

	public static string UncompressString(byte[] compressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_00d4: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.EnsureWriteable();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 42;
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
			if ((nint)obj9 == 42)
			{
				object obj10 = obj2 + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
				goto IL_02a4;
			}
		}
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_02a4;
		IL_02a4:
		string result = default;
		return result;
	}

	public static byte[] UncompressBuffer(byte[] compressed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0218: Expected I4, but got Obj
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
		memoryStream.Dispose((byte)(int)compressed != 0);
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
				goto IL_027a;
			}
		}
		if (obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_027a;
		IL_027a:
		byte[] result = default;
		return result;
	}

	static GZipStream()
	{
		DeflateManager.MEM_LEVEL_MAX = 9;
		DeflateManager.MEM_LEVEL_DEFAULT = 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}
}
