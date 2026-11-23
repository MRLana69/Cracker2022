using System;
using Cpp2ILInjected;

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

	public CompressionLevel CompressLevel = CompressionLevel.Default;

	public int WindowBits;

	public CompressionStrategy Strategy;

	public int Adler32 => (int)_Adler32;

	public ZlibCodec()
	{
		//IL_000f: Expected I4, but got I8
	}

	public ZlibCodec(CompressionMode mode)
	{
		//IL_000f: Expected I4, but got I8
		if (mode != CompressionMode.Compress)
		{
			if (mode == CompressionMode.Decompress)
			{
				goto IL_00e4;
			}
		}
		else
		{
			if (InitializeDeflate() == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("Cannot initialize for deflate.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex2 = default;
		ex2._002Ector("Invalid ZlibStreamFlavor.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		goto IL_00e4;
		IL_00e4:
		int num = ((ZlibCodec)(object)ex2).InitializeInflate();
	}

	public int InitializeInflate()
	{
		int num = InitializeInflate(WindowBits);
		return 0;
	}

	public int InitializeInflate(bool expectRfc1950Header)
	{
		int num = InitializeInflate(WindowBits, expectRfc1950Header);
		return 0;
	}

	public int InitializeInflate(int windowBits)
	{
		WindowBits = windowBits;
		int num = InitializeInflate(windowBits, expectRfc1950Header: true);
		return 0;
	}

	public int InitializeInflate(int windowBits, bool expectRfc1950Header)
	{
		WindowBits = windowBits;
		ZlibException ex = default;
		if (dstate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("You may not call InitializeInflate() after calling InitializeDeflate().");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		InflateManager inflateManager = default;
		inflateManager._handleRfc1950HeaderBytes = true;
		inflateManager._handleRfc1950HeaderBytes = expectRfc1950Header;
		((ZlibCodec)(object)ex).istate = inflateManager;
		int num = ((ZlibCodec)(object)ex).istate.Initialize((ZlibCodec)(object)ex, windowBits);
		return 0;
	}

	public int Inflate(FlushType flush)
	{
		//IL_008a: Expected I4, but got Obj
		bool flag = istate == null;
		bool flag2 = !flag;
		InflateManager inflateManager = istate;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("No Inflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			inflateManager = (InflateManager)(object)ex;
		}
		return inflateManager.Inflate((FlushType)inflateManager);
	}

	public int EndInflate()
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		//IL_0091: Expected Obj, but got I4
		ZlibException ex = default;
		if (istate == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("No Inflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		int num = istate.End();
		object obj = ex - -64;
		obj = 0;
		return 0;
	}

	public int SyncInflate()
	{
		bool flag = istate == null;
		bool flag2 = !flag;
		InflateManager inflateManager = istate;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("No Inflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			inflateManager = (InflateManager)(object)ex;
		}
		return inflateManager.Sync();
	}

	public int InitializeDeflate()
	{
		return _InternalInitializeDeflate(wantRfc1950Header: true);
	}

	public int InitializeDeflate(CompressionLevel level)
	{
		CompressLevel = level;
		return _InternalInitializeDeflate(wantRfc1950Header: true);
	}

	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
	{
		CompressLevel = level;
		return _InternalInitializeDeflate(wantRfc1950Header);
	}

	public int InitializeDeflate(CompressionLevel level, int bits)
	{
		WindowBits = bits;
		CompressLevel = level;
		return _InternalInitializeDeflate(wantRfc1950Header: true);
	}

	public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
	{
		WindowBits = bits;
		CompressLevel = level;
		return _InternalInitializeDeflate(wantRfc1950Header);
	}

	private int _InternalInitializeDeflate(bool wantRfc1950Header)
	{
		ZlibException ex = default;
		if (istate != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("You may not call InitializeDeflate() after calling InitializeInflate().");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		DeflateManager deflateManager = default;
		deflateManager._002Ector();
		((ZlibCodec)(object)ex).dstate = deflateManager;
		DeflateManager deflateManager2 = ((ZlibCodec)(object)ex).dstate;
		deflateManager2._WantRfc1950HeaderBytes = wantRfc1950Header;
		return deflateManager2.Initialize((ZlibCodec)(object)ex, ((ZlibCodec)(object)ex).CompressLevel, ((ZlibCodec)(object)ex).WindowBits, ((ZlibCodec)(object)ex).Strategy);
	}

	public int Deflate(FlushType flush)
	{
		bool flag = dstate == null;
		bool flag2 = !flag;
		DeflateManager deflateManager = dstate;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("No Deflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			deflateManager = (DeflateManager)(object)ex;
		}
		return deflateManager.Deflate(flush);
	}

	public int EndDeflate()
	{
		ZlibException ex = default;
		if (dstate == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("No Deflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		((ZlibCodec)(object)ex).dstate = null;
		return 0;
	}

	public void ResetDeflate()
	{
		bool flag = dstate == null;
		bool flag2 = !flag;
		DeflateManager deflateManager = dstate;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("No Deflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			deflateManager = (DeflateManager)(object)ex;
		}
		deflateManager.Reset();
	}

	public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
	{
		bool flag = dstate == null;
		bool flag2 = !flag;
		DeflateManager deflateManager = dstate;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ZlibException ex = default;
			ex._002Ector("No Deflate State!");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			deflateManager = (DeflateManager)(object)ex;
		}
		return deflateManager.SetParams(level, strategy);
	}

	public int SetDictionary(byte[] dictionary)
	{
		//IL_00af: Expected I4, but got Obj
		if (istate != null)
		{
			return istate.SetDictionary(dictionary);
		}
		if (dstate != null)
		{
			return dstate.SetDictionary(dictionary);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex = default;
		ex._002Ector("No Inflate or Deflate state!");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		return (int)ex;
	}

	internal void flush_pending()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_00c9: Expected Obj, but got I4
		//IL_0100: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		int num = AvailableBytesOut;
		DeflateManager deflateManager = dstate;
		if (AvailableBytesOut >= deflateManager.pendingCount)
		{
			num = deflateManager.pendingCount;
		}
		if (num == 0)
		{
			return;
		}
		byte[] pending = deflateManager.pending;
		if (pending.Length > deflateManager.nextPending)
		{
			byte[] outputBuffer = OutputBuffer;
			if (outputBuffer.Length > NextOut)
			{
				object obj3 = num + deflateManager.nextPending;
				if (pending.Length >= (nint)obj3)
				{
					byte[] outputBuffer2 = OutputBuffer;
					object obj4 = num + NextOut;
					if (outputBuffer2.Length >= (nint)obj4)
					{
						DeflateManager deflateManager2 = dstate;
						Array.Copy(deflateManager2.pending, deflateManager2.nextPending, OutputBuffer, NextOut, num);
						int nextOut = num + NextOut;
						NextOut = nextOut;
						DeflateManager deflateManager3 = dstate;
						int nextPending = num + deflateManager3.nextPending;
						deflateManager3.nextPending = nextPending;
						long totalBytesOut = TotalBytesOut + num;
						TotalBytesOut = totalBytesOut;
						int availableBytesOut = AvailableBytesOut - num;
						AvailableBytesOut = availableBytesOut;
						DeflateManager deflateManager4 = dstate;
						int pendingCount = deflateManager4.pendingCount - num;
						deflateManager4.pendingCount = pendingCount;
						DeflateManager deflateManager5 = dstate;
						if (deflateManager5.pendingCount == 0)
						{
							deflateManager5.nextPending = 0;
						}
						return;
					}
				}
			}
		}
		DeflateManager deflateManager6 = dstate;
		byte[] pending2 = deflateManager6.pending;
		_ = pending2.Length;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj5 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		DeflateManager deflateManager7 = dstate;
		_ = deflateManager7.pendingCount;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		object obj6 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string s = $"Invalid State. (pending.Length={arg}, pendingCount={arg2})";
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		ZlibException ex = default;
		ex._002Ector(s);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
	}

	internal int read_buf(byte[] buf, int start, int size)
	{
		bool flag = size < AvailableBytesIn;
		int num = size;
		if (!flag)
		{
			num = AvailableBytesIn;
		}
		if (num != 0)
		{
			int availableBytesIn = AvailableBytesIn - num;
			AvailableBytesIn = availableBytesIn;
			DeflateManager deflateManager = dstate;
			if (~(deflateManager._WantRfc1950HeaderBytes ? 1u : 0u) == 0)
			{
				uint adler = Adler.Adler32(_Adler32, InputBuffer, NextIn, num);
				_Adler32 = adler;
			}
			Array.Copy(InputBuffer, NextIn, buf, start, num);
			int nextIn = num + NextIn;
			NextIn = nextIn;
			long totalBytesIn = TotalBytesIn + num;
			TotalBytesIn = totalBytesIn;
		}
		return num;
	}
}
