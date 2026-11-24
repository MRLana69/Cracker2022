using System;
using System.IO;
using System.Threading;
using Cpp2ILInjected;
using Ionic.Zlib;

namespace Ionic.Crc;

public class CrcCalculatorStream : Stream
{
	private static readonly long UnsetLengthLimit;

	internal Stream _innerStream;

	private CRC32 _Crc32;

	private long _lengthLimit;

	private bool _leaveOpen;

	private bool _disposed;

	public long TotalBytesSlurped
	{
		get
		{
			//IL_0007: Expected I8, but got Obj
			return (long)base._asyncActiveSemaphore;
		}
	}

	public int Crc
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected Obj, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected Obj, but got Unknown
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected Obj, but got Unknown
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected Obj, but got Unknown
			//IL_006c: Expected I4, but got Obj
			object obj = this & 0xFF;
			object obj2 = obj * 131586;
			object obj3 = obj2 & 0x1044010;
			object obj4 = obj2 << 2;
			object obj5 = obj4 & 0x2088020;
			object obj6 = obj5 + obj3;
			object obj7 = obj6 * 16781313;
			return obj7 >> 24;
		}
	}

	public bool LeaveOpen
	{
		get
		{
			CRC32 crc = _Crc32;
			return (byte)(crc._register ^ 0xFFFFFFFFu) != 0;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CrcCalculatorStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CrcCalculatorStream);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8AA2");
		}
	}

	public override bool CanRead => _leaveOpen;

	public override bool CanSeek
	{
		get
		{
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
			CRC32 crc = _Crc32;
			return crc._TotalBytesRead;
		}
	}

	public override long Position
	{
		get
		{
			//IL_007e: Expected I, but got Obj
			//IL_0094: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CrcCalculatorStream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CrcCalculatorStream);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<Ionic.Crc.CrcCalculatorStream>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_lengthLimit == UnsetLengthLimit)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
				long result = default;
				return result;
			}
			return _lengthLimit;
		}
		set
		{
			//IL_0027: Expected I8, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			((ZlibStream)(object)ex).SetLength(0L);
		}
	}

	public CrcCalculatorStream(Stream stream)
		: this((Stream)(-306674912), (byte)(int)stream != 0)
	{
		//IL_000f: Expected I4, but got Obj
		//IL_000f: Expected Obj, but got I4
	}

	public CrcCalculatorStream(Stream stream, bool leaveOpen)
	{
		//IL_000b: Expected I8, but got I4
		//IL_0015: Expected Obj, but got I4
		_lengthLimit = -1L;
		_Crc32 = (CRC32)leaveOpen;
		((MarshalByRefObject)this)._identity = stream;
		((CRC32)(object)this)._002Ector();
	}

	public CrcCalculatorStream(Stream stream, long length)
	{
		//IL_0014: Expected Obj, but got I8
		((MarshalByRefObject)this)._identity = stream;
		base._asyncActiveSemaphore = (SemaphoreSlim)length;
	}

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8AA2");
		if (length < 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex = default;
			ex._002Ector("length");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (_Crc32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("ZlibStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
		int result = default;
		return result;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_003a: Expected Obj, but got I4
		//IL_001d: Expected I4, but got Obj
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected I8, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected I8, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_009c: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected I8, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected I8, but got Unknown
		if (buffer == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Exception ex = default;
			ex.SetErrorCode((int)"The data buffer must not be null.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		object obj = 0;
		while ((nint)obj < count)
		{
			object obj2 = buffer + 16;
			object obj3 = obj + offset;
			object obj4 = obj2 + obj3;
			if (_Crc32 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CrcCalculatorStream)+1C]");
				object obj5 = (nint)0 + (nint)16;
				long num = _lengthLimit >> 24;
				long num2 = num ^ obj4;
				long num3 = num2 << 2;
				object obj6 = obj5 + num3;
				long num4 = _lengthLimit << 8;
				long lengthLimit = obj6 ^ num4;
				_lengthLimit = lengthLimit;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Crc.CrcCalculatorStream)+1C]");
				object obj7 = (nint)0 + (nint)16;
				long num5 = _lengthLimit & 0xFF;
				long num6 = num5 ^ obj4;
				long num7 = num6 << 2;
				object obj8 = obj7 + num7;
				long num8 = _lengthLimit >> 8;
				long lengthLimit2 = obj8 ^ num8;
				_lengthLimit = lengthLimit2;
			}
			object obj9 = obj + 1;
			obj = obj9;
		}
		SemaphoreSlim asyncActiveSemaphore = (SemaphoreSlim)(count + base._asyncActiveSemaphore);
		base._asyncActiveSemaphore = asyncActiveSemaphore;
	}

	public override void Flush()
	{
		//IL_000b: Expected I8, but got I4
		_lengthLimit = -1L;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_000b: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		return 0L;
	}

	public override void SetLength(long value)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector();
		((CrcCalculatorStream)(object)ex).Position = 0L;
	}

	protected override void Dispose(bool disposing)
	{
		_leaveOpen = disposing;
	}

	~CrcCalculatorStream()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	static CrcCalculatorStream()
	{
		Adler.BASE = 65521u;
		Adler.NMAX = 5552;
	}
}
