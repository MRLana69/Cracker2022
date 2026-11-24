using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
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
			//IL_01eb: Expected I, but got Obj
			//IL_0201: Expected Obj, but got I
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected Obj, but got Unknown
			//IL_02e8: Expected Obj, but got I4
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected Obj, but got Unknown
			//IL_02fc: Expected Obj, but got I4
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected Obj, but got Unknown
			//IL_0310: Expected Obj, but got I4
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Expected Obj, but got Unknown
			//IL_0324: Expected Obj, but got I4
			//IL_0332: Expected I, but got Obj
			//IL_0348: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0182: Expected I, but got Obj
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_012f: Expected I, but got Obj
			nint num = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v62 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)base._asyncActiveSemaphore != DeflateManager.INIT_STATE)
			{
				nint num3 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v34 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v55 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((nint)base._asyncActiveSemaphore != DeflateManager.BUSY_STATE)
				{
					nint num5 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v42 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S1_v49 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if ((nint)base._asyncActiveSemaphore != DeflateManager.FINISH_STATE)
					{
						return (FlushType)(-2);
					}
				}
			}
			object obj4 = this + 20;
			obj4 = 0;
			object obj5 = this - -64;
			obj5 = 0;
			object obj6 = this + 60;
			obj6 = 0;
			object obj7 = this + 52;
			obj7 = 0;
			nint num7 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v20 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v27 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)base._asyncActiveSemaphore == DeflateManager.BUSY_STATE)
			{
				return (FlushType)(-3);
			}
			return FlushType.None;
		}
		set
		{
			//IL_000e: Expected Obj, but got I4
			object obj = value & FlushType.Partial;
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
				obsoleteAttribute._002Ector("DeflateStream");
				((DeflateStream)(object)obsoleteAttribute).FlushMode = FlushType.None;
			}
			else
			{
				ZlibBaseStream baseStream = _baseStream;
				baseStream._flushMode = (FlushType)value;
			}
		}
	}

	public CompressionStrategy Strategy
	{
		get
		{
			ZlibBaseStream baseStream = _baseStream;
			return (CompressionStrategy)baseStream._bufferSize;
		}
		set
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
				obsoleteAttribute._002Ector("DeflateStream");
				((DeflateStream)(object)obsoleteAttribute).BufferSize = 0;
			}
			ZlibBaseStream baseStream = _baseStream;
			if (baseStream._workingBuffer != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream = default;
				zlibBaseStream.Dispose((byte)(int)"The working buffer is already set." != 0);
				((DeflateStream)(object)zlibBaseStream).BufferSize = 0;
			}
			object obj2 = default;
			object obj = obj2 + 4;
			if (value < (CompressionStrategy)1024)
			{
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj2 = 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string format = default;
				object arg = default;
				string text = string.Format((IFormatProvider)(object)"Don't be silly. {0} bytes?? Use a bigger buffer, at least {1}.", format, arg);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				ZlibBaseStream zlibBaseStream2 = default;
				zlibBaseStream2.Dispose((byte)(int)text != 0);
				((DeflateStream)(object)zlibBaseStream2).BufferSize = 0;
			}
			else
			{
				ZlibBaseStream baseStream2 = _baseStream;
				baseStream2._bufferSize = (int)value;
			}
		}
	}

	public unsafe virtual long TotalIn
	{
		get
		{
			//IL_0054: Expected Obj, but got I
			//IL_0064: Expected Obj, but got I
			//IL_0074: Expected Obj, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected Obj, but got Unknown
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected Obj, but got Unknown
			//IL_0039: Expected I8, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
			object obj3 = 0;
			object obj4 = obj3 & 0x1FFF;
			object obj5 = obj4 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = default;
			if ((nint)obj6 > -1)
			{
				string text = ((Dictionary<string, string>)((MarshalByRefObject)this)._identity).get_Item("event_end");
				return ((TimeSpan*)text)->Ticks;
			}
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
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0015: Expected I4, but got Obj
			object obj = _baseStream - -64;
			return (byte)(int)obj != 0;
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
				obsoleteAttribute._002Ector("DeflateStream");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		}
	}

	public DeflateStream(Stream stream, CompressionMode mode)
	{
		//IL_05cb: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I
		//IL_057f: Expected I4, but got Obj
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Expected Obj, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected Obj, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_03b7: Expected I, but got Obj
		//IL_0380: Expected I4, but got Obj
		//IL_0380: Expected I4, but got Obj
		//IL_00e8: Expected I, but got Obj
		//IL_00fe: Expected Obj, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected Obj, but got Unknown
		//IL_0445: Expected I, but got Obj
		//IL_045b: Expected Obj, but got I
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_0628: Expected Obj, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected I4, but got Unknown
		//IL_0644: Expected I4, but got Obj
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_0129: Expected I, but got Obj
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected Obj, but got Unknown
		//IL_025f: Expected I, but got Obj
		//IL_0275: Expected Obj, but got I
		//IL_0176: Expected I, but got Obj
		//IL_04de: Expected I4, but got Obj
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Expected Obj, but got Unknown
		//IL_01c3: Expected I, but got Obj
		//IL_01d9: Expected Obj, but got I
		//IL_02a0: Expected I, but got Obj
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_02ed: Expected I, but got Obj
		//IL_0303: Expected Obj, but got I
		//IL_0204: Expected I, but got Obj
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected Obj, but got Unknown
		//IL_032e: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+B8]");
		if ((nint)0 != 0)
		{
			object obj3 = default;
			object obj36;
			do
			{
				object obj = _baseStream + 16;
				object obj2 = obj3 << 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+BC]");
				object obj4 = obj2 + 0;
				object obj5 = obj + obj4;
				object obj6 = obj5 << 8;
				object obj7 = (object)_baseStream + obj4;
				object obj8 = obj7 + 17;
				object obj9 = obj6 | obj8;
				object obj10 = _baseStream + 16;
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+B0]");
				object obj12 = obj11 + 0;
				object obj13 = obj10 + obj12;
				obj3++;
				if (obj9 != null)
				{
					nint num = (nint)typeof(Tree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v42 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num2 = (nint)typeof(Tree);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v116 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj15 = Tree.LengthCode + 16;
					object obj16 = obj15 + obj13;
					nint num3 = (nint)typeof(InternalConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v53 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					if (obj17 != null)
					{
						nint num4 = (nint)typeof(InternalConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v110 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj18 = obj16 << 24;
					object obj19 = obj18 >> 24;
					object obj20 = InternalConstants.LITERALS + obj19;
					int value = obj20 + 1;
					((DeflateManager)(object)this).send_bits(value, (int)stream);
					object obj21 = Tree.ExtraLengthBits + 16;
					object obj22 = obj19 << 2;
					object obj23 = obj21 + obj22;
					if (obj23 != null)
					{
						nint num5 = (nint)typeof(Tree);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v99 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num6 = (nint)typeof(Tree);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v104 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj25 = Tree.LengthBase + 16;
						object obj26 = obj19 << 2;
						object obj27 = obj25 + obj26;
						short[] ltree = (short[])(obj13 - obj27);
						((DeflateManager)(object)this).send_compressed_block(ltree, (short[])obj23);
					}
					string text = (string)(obj9 - 1);
					nint num7 = (nint)typeof(Tree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v69 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num8 = (nint)typeof(Tree);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v94 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					byte[] array = SharedUtils.ToByteArray(text);
					((DeflateManager)(object)this).send_bits((int)array, (int)mode);
					object obj29 = Tree.ExtraDistanceBits + 16;
					object obj30 = (object)array << 2;
					object obj31 = obj29 + obj30;
					if (obj31 != null)
					{
						nint num9 = (nint)typeof(Tree);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v83 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
						object obj32 = (nint)0 & (nint)0x200;
						if (obj32 != null)
						{
							nint num10 = (nint)typeof(Tree);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v88 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj33 = Tree.DistanceBase + 16;
						object obj34 = (object)array << 2;
						object obj35 = obj33 + obj34;
						short[] ltree2 = (short[])((object)text - obj35);
						((DeflateManager)(object)this).send_compressed_block(ltree2, (short[])obj31);
					}
				}
				else
				{
					((DeflateManager)(object)this).send_bits((int)obj13, (int)stream);
				}
				obj36 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+B8]");
			}
			while ((nint)obj36 < 0);
		}
		nint num11 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v9 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj37 = (nint)0 & (nint)0x200;
		if (obj37 != null)
		{
			nint num12 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v15 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DeflateManager)(object)this).send_bits(DeflateManager.END_BLOCK, (int)stream);
		int num13 = DeflateManager.END_BLOCK << 1;
		int num14 = num13 << 1;
		object obj38 = stream + num14;
		object obj39 = obj38 + 18;
	}

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level)
	{
		//IL_0036: Expected I, but got Obj
		//IL_004c: Expected Obj, but got I
		//IL_03ea: Expected Obj, but got I
		//IL_0013: Expected Obj, but got I4
		//IL_00d3: Expected Obj, but got I
		//IL_00e5: Expected Obj, but got I
		//IL_0077: Expected I, but got Obj
		//IL_039c: Expected Obj, but got I4
		//IL_03b7: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I
		//IL_012e: Expected Obj, but got I
		//IL_033e: Expected I4, but got Obj
		//IL_01a9: Expected I, but got Obj
		//IL_01bf: Expected Obj, but got I
		//IL_0519: Expected Obj, but got I4
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0544: Expected Obj, but got I4
		//IL_0552: Expected I, but got Obj
		//IL_0568: Expected Obj, but got I
		//IL_0595: Expected I4, but got Obj
		//IL_02a0: Expected I, but got Obj
		//IL_042e: Expected Obj, but got I4
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_0459: Expected Obj, but got I4
		//IL_0469: Expected Obj, but got I
		//IL_047f: Expected Obj, but got I
		//IL_048f: Expected Obj, but got I
		//IL_04e3: Expected Obj, but got I
		//IL_02ed: Expected I, but got Obj
		//IL_022a: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+7C]");
		object obj2;
		object obj3;
		bool flag3 = default;
		if ((nint)0 < (nint)1)
		{
			object obj = mode + 5;
			obj2 = obj;
			obj3 = obj;
		}
		else
		{
			nint num = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v62 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v84 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+20]");
			object obj4 = (nint)0 << 24;
			object obj5 = obj4 >> 24;
			if (DeflateManager.Z_UNKNOWN == (nint)obj5)
			{
				((DeflateManager)(object)this).bi_flush();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+90]");
			((ZlibException)0)._002Ector((string)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+94]");
			((ZlibException)0)._002Ector((string)(object)this);
			bool wantRfc1950HeaderBytes = ((DeflateManager)(object)this).WantRfc1950HeaderBytes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+C4]");
			object obj6 = (nint)0 + (nint)10;
			object obj7 = obj6 >> 3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+C0]");
			object obj8 = (nint)0 + (nint)10;
			object obj9 = obj8 >> 3;
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9);
			bool flag2 = !flag;
			flag3 = wantRfc1950HeaderBytes;
			obj2 = obj9;
			obj3 = obj7;
			if (!flag2)
			{
				flag3 = wantRfc1950HeaderBytes;
				obj2 = obj7;
				obj3 = obj7;
			}
		}
		bool flag4 = (nint)stream == -1;
		object obj10 = mode + 4;
		bool flag5 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2);
		object obj11 = flag4 | flag5;
		if (obj11 != null)
		{
			nint num3 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v19 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			bool flag6 = obj12 == null;
			if (obj3 != obj2)
			{
				if (!flag6)
				{
					nint num4 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v53 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj13 = level & CompressionLevel.BestSpeed;
				int num5 = DeflateManager.DYN_TREES << 1;
				short[] ltree = (short[])(obj13 + num5);
				((DeflateManager)(object)this).send_compressed_block(ltree, (short[])3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+90]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v26+C]");
				byte[] p = (byte[])((nint)0 + (nint)1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+94]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S2_v24+C]");
				int start = (int)((nint)0 + (nint)1);
				int len = (flag3 ? 1 : 0) + 1;
				((DeflateManager)(object)this).put_bytes(p, start, len);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+84]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+88]");
				this._002Ector((Stream)num6, CompressionMode.Compress);
			}
			else
			{
				if (!flag6)
				{
					nint num7 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v41 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj16 = level & CompressionLevel.BestSpeed;
				int num8 = DeflateManager.STATIC_TREES << 1;
				short[] ltree2 = (short[])(obj16 + num8);
				((DeflateManager)(object)this).send_compressed_block(ltree2, (short[])3);
				nint num9 = (nint)typeof(StaticTree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S0_v30 (Il2CppClass<Ionic.Zlib.StaticTree>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num10 = (nint)typeof(StaticTree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v35 (Il2CppClass<Ionic.Zlib.StaticTree>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				this._002Ector((Stream)(object)StaticTree.lengthAndLiteralsTreeCodes, (CompressionMode)StaticTree.distTreeCodes);
			}
		}
		else
		{
			((DeflateManager)(object)this)._tr_flush_block((int)stream, (int)mode, (byte)level != 0);
		}
		((DeflateManager)(object)this)._tr_align();
		if (level != CompressionLevel.None)
		{
			((DeflateManager)(object)this)._fillWindow();
		}
	}

	public DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen)
		: base(stream, mode, leaveOpen ? CompressionLevel.BestSpeed : CompressionLevel.None, false)
	{
	}

	public DeflateStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
	{
	}

	protected override void Dispose(bool disposing)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		if (~(_disposed ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("DeflateStream");
			((DeflateStream)(object)obsoleteAttribute).Strategy = CompressionStrategy.Default;
		}
		else
		{
			object obj = _baseStream - -64;
			obj = disposing;
		}
	}

	public override void Flush()
	{
		//IL_012d: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateStream)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+18]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+18]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6+18]");
				if ((nint)0 == 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num = 0;
					_ = 0;
					object obj3 = default;
					object obj2 = obj3 + 16;
					obj2 = this;
					object obj4 = this + 8;
					obj4 = obj3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num2 = 0;
				_ = 0;
				object obj6 = default;
				object obj5 = obj6 + 16;
				obj5 = this;
				object obj7 = this + 8;
				obj7 = obj6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			object obj9 = default;
			object obj8 = obj9 + 16;
			obj8 = this;
			object obj10 = this + 8;
			obj10 = obj9;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((InfTree)(object)this).inflate_trees_bits((int[])(object)buffer, (int[])offset, (int[])count, (int[])DeflateManager.MEM_LEVEL_DEFAULT, (ZlibCodec)null);
		return 0;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		//IL_0010: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0L;
	}

	public override void SetLength(long value)
	{
		//IL_0027: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NotSupportedException ex = default;
		ex._002Ector();
		((DeflateStream)(object)ex).Position = 0L;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		((GZipStream)this)._002Ector((Stream)(object)buffer, (CompressionMode)offset, CompressionLevel.Default, (byte)count != 0);
	}

	public static byte[] CompressString(string s)
	{
		//IL_0041: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [s @ L0 (System.String)+1C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ObsoleteAttribute obsoleteAttribute = default;
			obsoleteAttribute._002Ector("DeflateStream");
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
