using System;
using System.IO;
using Cpp2ILInjected;

namespace Ionic.Crc;

public class CrcCalculatorStream : Stream
{
	private static readonly long UnsetLengthLimit = -99L;

	internal Stream _innerStream;

	private CRC32 _Crc32;

	private long _lengthLimit;

	private bool _leaveOpen;

	private bool _disposed;

	public long TotalBytesSlurped
	{
		get
		{
			CRC32 crc = _Crc32;
			return crc._TotalBytesRead;
		}
	}

	public int Crc
	{
		get
		{
			CRC32 crc = _Crc32;
			return (int)crc._register ^ -1;
		}
	}

	public bool LeaveOpen
	{
		get
		{
			return _leaveOpen;
		}
		set
		{
			_leaveOpen = value;
		}
	}

	public override bool CanRead
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Stream innerStream = _innerStream;
			nint num = (nint)innerStream;
			object obj = innerStream + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+F4] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override bool CanSeek => false;

	public override bool CanWrite
	{
		get
		{
			//IL_0012: Expected I, but got Obj
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected Obj, but got Unknown
			Stream innerStream = _innerStream;
			nint num = (nint)innerStream;
			object obj = innerStream + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+10C] (should have been resolved before IL gen)");
			bool result = default;
			return result;
		}
	}

	public override long Length
	{
		get
		{
			//IL_0017: Expected I, but got Obj
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			if (UnsetLengthLimit == _lengthLimit)
			{
				Stream innerStream = _innerStream;
				nint num = (nint)innerStream;
				object obj = innerStream + 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S1_v4 (Il2CppClass<System.IO.Stream>)+114] (should have been resolved before IL gen)");
				long result = default;
				return result;
			}
			return _lengthLimit;
		}
	}

	public override long Position
	{
		get
		{
			CRC32 crc = _Crc32;
			return crc._TotalBytesRead;
		}
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public CrcCalculatorStream(Stream stream)
		: this(leaveOpen: true, UnsetLengthLimit, stream, null)
	{
	}

	public CrcCalculatorStream(Stream stream, bool leaveOpen)
		: this(leaveOpen, UnsetLengthLimit, stream, null)
	{
	}

	public CrcCalculatorStream(Stream stream, long length)
		: this(leaveOpen: true, length, stream, null)
	{
		if (length <= -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentException ex = default;
			ex._002Ector("length");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
		: this(leaveOpen, length, stream, null)
	{
		if (length <= -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentException ex = default;
			ex._002Ector("length");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
		: this(leaveOpen, length, stream, crc32)
	{
		if (length <= -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ArgumentException ex = default;
			ex._002Ector("length");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
	{
		//IL_003d: Expected I8, but got I4
		_lengthLimit = -99L;
		_innerStream = stream;
		CRC32 cRC = default;
		CRC32 cRC2 = default;
		if (cRC == null)
		{
			cRC2._002Ector();
		}
		_Crc32 = cRC2;
		_leaveOpen = leaveOpen;
		_lengthLimit = length;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_00e3: Expected I, but got Obj
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0052: Expected I4, but got I8
		int result;
		if (UnsetLengthLimit != _lengthLimit)
		{
			CRC32 crc = _Crc32;
			bool flag = crc._TotalBytesRead >= _lengthLimit;
			result = 0;
			if (flag)
			{
				goto IL_009f;
			}
			int num = (int)(_lengthLimit - crc._TotalBytesRead);
			int num2 = default;
			if (num >= num2)
			{
				num = num2;
			}
		}
		Stream innerStream = _innerStream;
		nint num3 = (nint)innerStream;
		object obj = innerStream + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S4_v2 (Il2CppClass<System.IO.Stream>)+1B4] (should have been resolved before IL gen)");
		int num4 = default;
		bool flag2 = num4 < 1;
		result = num4;
		if (!flag2)
		{
			_Crc32.SlurpBlock(buffer, offset, num4);
			result = num4;
		}
		goto IL_009f;
		IL_009f:
		return result;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_0059: Expected I, but got Obj
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		if (count >= 1)
		{
			_Crc32.SlurpBlock(buffer, offset, count);
		}
		Stream innerStream = _innerStream;
		nint num = (nint)innerStream;
		object obj = innerStream + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v29 @ S4_v3 (Il2CppClass<System.IO.Stream>)+1CC] (should have been resolved before IL gen)");
	}

	public override void Flush()
	{
		//IL_0012: Expected I, but got Obj
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Stream innerStream = _innerStream;
		nint num = (nint)innerStream;
		object obj = innerStream + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v2 (Il2CppClass<System.IO.Stream>)+15C] (should have been resolved before IL gen)");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_0037: Expected I8, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (long)ex;
	}

	public override void SetLength(long value)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		NotSupportedException ex = default;
		ex._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0092: Expected I, but got Obj
		if (~(_disposed ? 1u : 0u) == 0)
		{
			return;
		}
		if (disposing)
		{
			Stream innerStream = _innerStream;
			if (_innerStream != null)
			{
				if (~(_leaveOpen ? 1u : 0u) != 0)
				{
					nint num = (nint)innerStream;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S1_v7 (Il2CppClass<System.IO.Stream>)+14C] (should have been resolved before IL gen)");
				}
				_innerStream = null;
			}
		}
		_disposed = true;
	}

	~CrcCalculatorStream()
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

	static CrcCalculatorStream()
	{
		//IL_000f: Expected I8, but got I4
	}
}
