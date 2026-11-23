using System;
using System.IO;
using Cpp2ILInjected;

namespace Ionic.Zlib;

public class DeflateStream : Stream
{
	internal ZlibBaseStream _baseStream;

	internal Stream _innerStream;

	private bool _disposed;

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
				ex._002Ector("DeflateStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
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
				ex._002Ector("DeflateStream");
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

	public CompressionStrategy Strategy
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			return baseStream.Strategy;
		}
		set
		{
			ObjectDisposedException ex = default;
			if (~(_disposed ? 1u : 0u) == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				ex._002Ector("DeflateStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
			baseStream.Strategy = value;
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
				ex._002Ector("DeflateStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
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
				ex._002Ector("DeflateStream");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			}
			ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
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
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected Obj, but got Unknown
			//IL_0088: Expected I8, but got Obj
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected Obj, but got Unknown
			ZlibBaseStream baseStream = _baseStream;
			object obj = default;
			if (baseStream._streamMode != ZlibBaseStream.StreamMode.Writer)
			{
				if (baseStream._streamMode == ZlibBaseStream.StreamMode.Reader)
				{
					obj = baseStream._z + 24;
				}
			}
			else
			{
				obj = baseStream._z + 48;
			}
			return (long)obj;
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

	public DeflateStream(Stream stream, CompressionMode mode)
		: this(stream, mode, CompressionLevel.Default, leaveOpen: false)
	{
	}

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
		: this(stream, mode, level, leaveOpen: false)
	{
	}

	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		: this(stream, mode, CompressionLevel.Default, leaveOpen)
	{
	}

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		_innerStream = stream;
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream._002Ector(stream, mode, level, ZlibStreamFlavor.DEFLATE, leaveOpen);
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
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		object obj3 = obj + 28;
		object obj4 = obj + 27;
		obj = obj4;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10+1C]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10+14]");
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
								goto IL_023c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							object obj10 = default;
							obj8 = obj10;
						}
						_ = 0;
						object obj11 = obj + 8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
						goto IL_023c;
					}
				}
			}
			_ = 1;
		}
		goto IL_023c;
		IL_023c:
		object obj12 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A77");
	}

	public override void Flush()
	{
		//IL_006f: Expected I, but got Obj
		ObjectDisposedException ex = default;
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("DeflateStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
		nint num = (nint)baseStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v3 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+15C] (should have been resolved before IL gen)");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_006f: Expected I, but got Obj
		ObjectDisposedException ex = default;
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("DeflateStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
		nint num = (nint)baseStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v2 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+1B4] (should have been resolved before IL gen)");
		int result = default;
		return result;
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
		//IL_006f: Expected I, but got Obj
		ObjectDisposedException ex = default;
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			ex._002Ector("DeflateStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
		ZlibBaseStream baseStream = ((DeflateStream)(object)ex)._baseStream;
		nint num = (nint)baseStream;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v2 (Il2CppClass<Ionic.Zlib.ZlibBaseStream>)+1CC] (should have been resolved before IL gen)");
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
}
