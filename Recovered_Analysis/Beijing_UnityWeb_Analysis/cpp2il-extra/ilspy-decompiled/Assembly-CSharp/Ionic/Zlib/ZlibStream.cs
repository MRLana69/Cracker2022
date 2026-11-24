using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Ionic.Crc;
using SYBO.Subway.Info;
using UI;

namespace Ionic.Zlib;

public class ZlibStream : Stream
{
	internal ZlibBaseStream _baseStream;

	private bool _disposed;

	public virtual FlushType FlushMode
	{
		get
		{
			//IL_0037: Expected I4, but got Obj
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0019: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
			if ((nint)0 != 0)
			{
				object obj = this + 60;
				obj = 0;
				return FlushType.None;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"No Deflate State!" != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return FlushType.None;
		}
		set
		{
			//IL_0066: Expected I4, but got Obj
			//IL_00aa: Expected I4, but got Obj
			_ = 6;
			_ = 15;
			switch (value)
			{
			case FlushType.None:
				if (((ZlibCodec)(object)this).EndDeflate() != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ZlibBaseStream zlibBaseStream2 = default;
					zlibBaseStream2.Dispose((byte)(int)"Cannot initialize for deflate." != 0);
					((ZlibCodec)(object)zlibBaseStream2)._002Ector(CompressionMode.Compress);
				}
				break;
			case FlushType.Partial:
			{
				int num = ((ZlibCodec)(object)this).EndInflate();
				break;
			}
			default:
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream = default;
				zlibBaseStream.Dispose((byte)(int)"Invalid ZlibStreamFlavor." != 0);
				((ZlibCodec)(object)zlibBaseStream)._002Ector(CompressionMode.Compress);
				break;
			}
			}
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
				obsoleteAttribute._002Ector("ZlibStream");
				((ZlibStream)(object)obsoleteAttribute).FlushMode = FlushType.None;
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
			//IL_000b: Expected I8, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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
				obsoleteAttribute._002Ector("ZlibStream");
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
			NullReferenceException ex = default;
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
			((ZlibBaseStream)(object)ex).Position = 0L;
		}
	}

	public ZlibStream(Stream stream, CompressionMode mode)
	{
		//IL_0295: Expected I, but got Obj
		//IL_02ab: Expected Obj, but got I
		//IL_03b1: Expected Obj, but got I4
		//IL_0301: Expected I, but got Obj
		//IL_0317: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected Obj, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected I4, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d5: Expected I4, but got Obj
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0206: Expected I, but got Obj
		//IL_021c: Expected Obj, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0382: Expected I4, but got Obj
		//IL_0382: Expected I4, but got Obj
		//IL_038e: Expected Obj, but got I4
		//IL_039d: Expected I, but got Obj
		//IL_0247: Expected I, but got Obj
		nint num = (nint)typeof(InternalConstants);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v63 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = InternalConstants.MAX_BITS + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num3 = 1;
		object obj5 = default;
		object obj12 = default;
		while (true)
		{
			nint num4 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v57 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num3 > InternalConstants.MAX_BITS)
			{
				break;
			}
			object obj4 = obj5 + 16;
			object obj6 = num3 << 1;
			object obj7 = obj4 + obj6;
			object obj8 = num3 << 1;
			object obj9 = mode + obj8;
			object obj10 = obj9 + 14;
			object obj11 = obj12 << 16;
			object obj13 = obj11 >> 16;
			object obj14 = obj10 + obj13;
			object obj15 = obj14 << 1;
			obj7 = obj15;
			nint num6 = num3 + 1;
			num3 = num6;
		}
		object obj16 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16) <= System.Runtime.CompilerServices.Unsafe.As<Stream, UIntPtr>(ref stream))
		{
			object obj17 = obj16 << 1;
			object obj18 = obj17 << 1;
			object obj19 = (object)this + obj18;
			object obj20 = obj19 + 18;
			if ((obj20 & 0xFFFF) != 0)
			{
				object obj21 = obj5 + 16;
				int num7 = obj20 << 1;
				object obj22 = obj21 + num7;
				object obj23 = obj22 + 1;
				obj22 = obj23;
				nint num8 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v41 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
				object obj24 = (nint)0 & (nint)0x200;
				if (obj24 != null)
				{
					nint num9 = (nint)typeof(Tree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v48 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj25 = this + 16;
				object obj26 = obj16 << 2;
				object obj27 = obj25 + obj26;
				int num10 = SharedUtils.URShift((int)obj22, (int)obj20);
				obj27 = num10;
				num3 = (nint)typeof(Tree);
			}
			object obj28 = obj16 + 1;
			obj16 = obj28;
		}
	}

	public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
	{
		//IL_0022: Expected Obj, but got I
		//IL_0092: Expected I4, but got Obj
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00dd: Expected Obj, but got I4
		//IL_00f4: Expected Obj, but got I4
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_03c6: Expected Obj, but got I
		//IL_0129: Expected Obj, but got I
		//IL_0162: Expected Obj, but got I
		//IL_0186: Expected Obj, but got I
		//IL_0432: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+44]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+44]");
			((CrcCalculatorStream)0).Write((byte[])(object)stream, (int)mode, (int)level);
		}
		if ((_disposed ? 1 : 0) == 2)
		{
			_disposed = false;
		}
		else if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"Cannot Write after Reading." != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		if (level == CompressionLevel.None)
		{
			return;
		}
		byte[] workingBuffer = ((ZlibBaseStream)this).workingBuffer;
		object obj = workingBuffer + 8;
		obj = stream;
		ZlibBaseStream baseStream = _baseStream;
		((Stream)baseStream)._activeReadWriteTask = (Stream.ReadWriteTask)mode;
		ZlibBaseStream baseStream2 = _baseStream;
		((Stream)baseStream2)._asyncActiveSemaphore = (SemaphoreSlim)level;
		bool flag3;
		ZlibBaseStream zlibBaseStream2 = default;
		do
		{
			IL_0372:
			object obj2 = _baseStream + 32;
			string text = ((ZlibBaseStream)this).ReadZeroTerminatedString();
			obj2 = text;
			ZlibBaseStream baseStream3 = _baseStream;
			baseStream3._compressionMode = CompressionMode.Compress;
			ZlibBaseStream baseStream4 = _baseStream;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+30]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S1_v17+C]");
			baseStream4._level = CompressionLevel.None;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
			int num;
			if ((nint)0 != 0)
			{
				num = ((ZlibCodec)(object)_baseStream).InitializeDeflate(CompressionLevel.None);
			}
			else
			{
				ZlibBaseStream baseStream5 = _baseStream;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+1C]");
				num = ((ZlibCodec)(object)baseStream5).SetDictionary((byte[])0);
			}
			if (num < 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+30]");
				object obj4 = 0;
				ZlibBaseStream baseStream6 = _baseStream;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S4_v5+C]");
				object obj5 = (nint)0 - (nint)baseStream6._level;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
				ZlibBaseStream baseStream7 = _baseStream;
				bool flag;
				if (((Stream)baseStream7)._asyncActiveSemaphore != null)
				{
					flag = false;
				}
				else
				{
					ZlibBaseStream baseStream8 = _baseStream;
					flag = baseStream8._level != CompressionLevel.None;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+20]");
				bool flag2 = (nint)0 != 1952;
				flag3 = flag;
				if (flag2)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
				bool flag4 = (nint)0 == 0;
				flag3 = flag;
				if (!flag4)
				{
					ZlibBaseStream baseStream9 = _baseStream;
					if ((nint)((Stream)baseStream9)._asyncActiveSemaphore != 8)
					{
						goto IL_0372;
					}
					ZlibBaseStream baseStream10 = _baseStream;
					bool flag5 = baseStream10._level != CompressionLevel.None;
					flag3 = flag5;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
			bool flag6 = (nint)0 == 0;
			ZlibBaseStream baseStream11 = _baseStream;
			string text2 = ((!flag6) ? "in" : "de");
			object obj6 = ((IConvertible)text2).ToType((Type)(object)"flating: ", (IFormatProvider)(object)baseStream11._buf1);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			zlibBaseStream2.Dispose((byte)(int)obj6 != 0);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			break;
		}
		while (!flag3);
	}

	public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
	{
		//IL_0017: Expected I4, but got Obj
		((CelebrationPopupLabelTemplate)(object)this).SetupToken((Characters.CharacterId)stream, (int)mode, leaveOpen ? 1 : 0, false);
	}

	public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Stream);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Stream>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Stream);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<System.IO.Stream>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FriendsLoginFBButton friendsLoginFBButton = default;
		friendsLoginFBButton.Init((Action)(object)stream, (byte)mode != 0, (byte)level != 0, isGameOverScreen: true, (Action)leaveOpen);
		object obj2 = this + 44;
		obj2 = friendsLoginFBButton;
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
			obsoleteAttribute._002Ector("ZlibStream");
			((ZlibStream)(object)obsoleteAttribute).BufferSize = 0;
		}
		ZlibBaseStream baseStream = _baseStream;
		if (baseStream._workingBuffer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ZlibBaseStream zlibBaseStream = default;
			zlibBaseStream.Dispose((byte)(int)"The working buffer is already set." != 0);
			((ZlibStream)(object)zlibBaseStream).BufferSize = 0;
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
			((ZlibStream)(object)zlibBaseStream2).BufferSize = 0;
		}
		else
		{
			ZlibBaseStream baseStream2 = _baseStream;
			baseStream2._bufferSize = (disposing ? 1 : 0);
		}
	}

	public override void Flush()
	{
		//IL_030d: Expected Obj, but got I
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_002a: Expected Obj, but got I
		//IL_003a: Expected Obj, but got I
		//IL_004a: Expected Obj, but got I
		//IL_0364: Expected Obj, but got I
		//IL_0374: Expected Obj, but got I
		//IL_0384: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03ae: Expected Obj, but got I
		//IL_02e9: Expected I4, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_00d8: Expected Obj, but got I
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I
		//IL_01a6: Expected Obj, but got I
		//IL_01b6: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_0204: Expected Obj, but got I
		//IL_0219: Expected Obj, but got I
		//IL_022e: Expected Obj, but got I
		//IL_0248: Expected Obj, but got I
		//IL_0262: Expected Obj, but got I
		//IL_0277: Expected Obj, but got I
		//IL_028c: Expected Obj, but got I
		//IL_02a1: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+1C]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+28]");
		bool flag = num > 0;
		bool flag2 = !flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+1C]");
		int num2 = 0;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+28]");
			num2 = 0;
		}
		object obj3 = default;
		object obj2 = obj3 + 4;
		if (num2 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v19+14]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v20+C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v8+18]");
		if (num3 > 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+20]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v40+C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
			if (num4 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v44+14]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
				object obj10 = 0;
				int num5 = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S2_v8+18]");
				object obj11 = (nint)num5 + (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v45+C]");
				if (0 >= (nint)obj11)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+20]");
					object obj12 = 0;
					int num6 = num2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
					object obj13 = (nint)num6 + (nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v49+C]");
					if (0 >= (nint)obj13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
						object obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v53+14]");
						nint num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v30+18]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+20]");
						nint num9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
						Array.ConstrainedCopy((Array)num7, (int)num8, (Array)num9, 0, num2);
						int num10 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+24]");
						object obj16 = (nint)num10 + (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
						object obj17 = 0;
						int num11 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v57+18]");
						object obj18 = (nint)num11 + (nint)0;
						int num12 = num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+30]");
						object obj19 = (nint)num12 + (nint)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+28]");
						object obj20 = -num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
						object obj21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v61+1C]");
						object obj22 = -num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
						object obj23 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v63+1C]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
							object obj24 = 0;
							_ = 0;
						}
						return;
					}
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v12+14]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v13+C]");
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v17+1C]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string format = default;
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"Invalid State. (pending.Length={0}, pendingCount={1})", format, arg);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)text != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_001c: Expected I4, but got Obj
		//IL_0026: Expected I4, but got Obj
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I
		//IL_0178: Expected I4, but got Obj
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected Obj, but got Unknown
		//IL_0087: Expected I, but got Obj
		//IL_009d: Expected Obj, but got I
		//IL_01d0: Expected I4, but got Obj
		//IL_01d0: Expected Obj, but got I
		//IL_00c8: Expected I, but got Obj
		int num = default;
		int num2;
		if ((nint)base._asyncActiveSemaphore > num)
		{
			num2 = num;
		}
		else
		{
			num = (int)base._asyncActiveSemaphore;
			num2 = (int)base._asyncActiveSemaphore;
		}
		if (num2 != 0)
		{
			SemaphoreSlim asyncActiveSemaphore = (SemaphoreSlim)(base._asyncActiveSemaphore - num);
			base._asyncActiveSemaphore = asyncActiveSemaphore;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+3C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+D9]");
			if ((nint)0 != 0)
			{
				nint num3 = (nint)typeof(Adler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v28 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v33 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.ZlibStream)+44]");
				int num5 = ((ZlibBaseStream)0).Read((byte[])((MarshalByRefObject)this)._identity, (int)base._activeReadWriteTask, num);
			}
			Array.ConstrainedCopy((Array)((MarshalByRefObject)this)._identity, (int)base._activeReadWriteTask, buffer, offset, num);
			Stream.ReadWriteTask activeReadWriteTask = (Stream.ReadWriteTask)(num + base._activeReadWriteTask);
			base._activeReadWriteTask = activeReadWriteTask;
			bool disposed = (byte)((uint)num + (_disposed ? 1u : 0u)) != 0;
			_disposed = disposed;
		}
		else
		{
			num = 0;
		}
		return num;
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
		NullReferenceException ex = default;
		ex._002Ector();
		((ZlibStream)(object)ex).Position = 0L;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		//IL_0017: Expected I4, but got Obj
		((CelebrationPopupLabelTemplate)(object)this).SetupToken((Characters.CharacterId)buffer, offset, 6, (byte)count != 0);
	}

	public static byte[] CompressString(string s)
	{
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("ZlibStream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+14]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		byte[] result = default;
		return result;
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
}
