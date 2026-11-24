using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using InApp;
using InAppPurchase.Internal;
using Kiloo.Common.Backend.PurchaseValidation;
using WordHunt;

namespace Ionic.Zlib;

internal sealed class DeflateManager
{
	internal delegate BlockState CompressFunc(FlushType flush);

	internal class Config
	{
		internal int GoodLength;

		internal int MaxLazy;

		internal int NiceLength;

		internal int MaxChainLength;

		internal DeflateFlavor Flavor;

		private static readonly Config[] Table;

		private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_061e: Expected Obj, but got I
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_062c: Expected I4, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected I4, but got Unknown
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676: Expected Obj, but got Unknown
			//IL_05b9: Expected Obj, but got I
			//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c7: Expected I4, but got Unknown
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected I4, but got Unknown
			//IL_0402: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I
			//IL_04c8: Expected Obj, but got I
			//IL_02f1: Expected Obj, but got I
			//IL_048c: Expected Obj, but got I
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049a: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateManager+Config)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateManager+Config)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Ionic.Zlib.DeflateManager+Config)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj25 = default;
			object obj17 = default;
			object obj23 = default;
			for (; obj5 != obj3; obj5 = obj25 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+14]");
				DeflateFlavor deflateFlavor = DeflateFlavor.Store;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v19 (Ionic.Zlib.DeflateFlavor)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v19 (Ionic.Zlib.DeflateFlavor)+2A]");
				bool flag = (nint)0 == 5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v19 (Ionic.Zlib.DeflateFlavor)+24]");
				object obj10 = (nint)0 & (nint)0x10;
				bool flag2 = obj10 == null;
				object obj11 = (flag2 ? 1 : 0) ^ 1;
				DeflateFlavor deflateFlavor3;
				DeflateFlavor deflateFlavor2;
				if (obj11 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+8]");
						object obj12 = (nint)0 & (nint)0x3FF;
						deflateFlavor2 = (DeflateFlavor)(obj12 + 123986);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v215 @ S6_v16 (Ionic.Zlib.DeflateFlavor) (should have been resolved before IL gen)");
						deflateFlavor3 = (DeflateFlavor)123986;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0xFF;
						deflateFlavor3 = (DeflateFlavor)(obj13 + 125020);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213 @ S7_v6 (Ionic.Zlib.DeflateFlavor) (should have been resolved before IL gen)");
						deflateFlavor2 = deflateFlavor;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v19 (Ionic.Zlib.DeflateFlavor)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj14 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v94+9C]");
							object obj15 = (nint)0 & (nint)0x100;
							flag4 = obj15 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4 && MaxLazy != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v19 (Ionic.Zlib.DeflateFlavor)+2B]");
							object obj16 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj16 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj17 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8963");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8964");
								}
							}
							else if (obj17 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8965");
								deflateFlavor2 = flavor;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8966");
							}
							continue;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+8]");
					object obj18 = (nint)0 & (nint)0x3FF;
					deflateFlavor2 = (DeflateFlavor)(obj18 + 123986);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v215 @ S6_v16 (Ionic.Zlib.DeflateFlavor) (should have been resolved before IL gen)");
					deflateFlavor3 = (DeflateFlavor)123986;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj19 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v66+9C]");
						object obj20 = (nint)0 & (nint)0x100;
						flag6 = obj20 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6 && MaxLazy != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+8]");
							object obj21 = (nint)0 & (nint)0x3FF;
							deflateFlavor2 = (DeflateFlavor)(obj21 + 123986);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v215 @ S6_v16 (Ionic.Zlib.DeflateFlavor) (should have been resolved before IL gen)");
							deflateFlavor3 = (DeflateFlavor)123986;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v19 (Ionic.Zlib.DeflateFlavor)+2B]");
						object obj22 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj22 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj23 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8941");
								deflateFlavor2 = flavor;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8942");
								deflateFlavor2 = flavor;
							}
						}
						else if (obj23 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8943");
							deflateFlavor3 = flavor;
							deflateFlavor2 = (DeflateFlavor)maxChainLength;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8944");
							deflateFlavor2 = flavor;
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v14+8]");
				object obj24 = (nint)0 & (nint)0xFF;
				deflateFlavor3 = (DeflateFlavor)(obj24 + 125020);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v213 @ S7_v6 (Ionic.Zlib.DeflateFlavor) (should have been resolved before IL gen)");
				deflateFlavor2 = deflateFlavor;
			}
		}

		public static Config Lookup(CompressionLevel level)
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [level @ L0 (Ionic.Zlib.CompressionLevel)+10]");
			return (Config)0;
		}

		static Config()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			UICamera._003C_003Ec obj = default;
			UICamera._003C_003Ec._003C_003E9 = obj;
		}
	}

	private static readonly int MEM_LEVEL_MAX;

	private static readonly int MEM_LEVEL_DEFAULT;

	private CompressFunc DeflateFunction;

	private static readonly string[] _ErrorMessage;

	private static readonly int PRESET_DICT;

	private static readonly int INIT_STATE;

	private static readonly int BUSY_STATE;

	private static readonly int FINISH_STATE;

	private static readonly int Z_DEFLATED;

	private static readonly int STORED_BLOCK;

	private static readonly int STATIC_TREES;

	private static readonly int DYN_TREES;

	private static readonly int Z_BINARY;

	private static readonly int Z_ASCII;

	private static readonly int Z_UNKNOWN;

	private static readonly int Buf_size;

	private static readonly int MIN_MATCH;

	private static readonly int MAX_MATCH;

	private static readonly int MIN_LOOKAHEAD;

	private static readonly int HEAP_SIZE;

	private static readonly int END_BLOCK;

	internal ZlibCodec _codec;

	internal int status;

	internal byte[] pending;

	internal int nextPending;

	internal int pendingCount;

	internal sbyte data_type;

	internal int last_flush;

	internal int w_size;

	internal int w_bits;

	internal int w_mask;

	internal byte[] window;

	internal int window_size;

	internal short[] prev;

	internal short[] head;

	internal int ins_h;

	internal int hash_size;

	internal int hash_bits;

	internal int hash_mask;

	internal int hash_shift;

	internal int block_start;

	private Config config;

	internal int match_length;

	internal int prev_match;

	internal int match_available;

	internal int strstart;

	internal int match_start;

	internal int lookahead;

	internal int prev_length;

	internal CompressionLevel compressionLevel;

	internal CompressionStrategy compressionStrategy;

	internal short[] dyn_ltree;

	internal short[] dyn_dtree;

	internal short[] bl_tree;

	internal Tree treeLiterals;

	internal Tree treeDistances;

	internal Tree treeBitLengths;

	internal short[] bl_count;

	internal int[] heap;

	internal int heap_len;

	internal int heap_max;

	internal sbyte[] depth;

	internal int _lengthOffset;

	internal int lit_bufsize;

	internal int last_lit;

	internal int _distanceOffset;

	internal int opt_len;

	internal int static_len;

	internal int matches;

	internal int last_eob_len;

	internal short bi_buf;

	internal int bi_valid;

	private bool Rfc1950BytesEmitted;

	private bool _WantRfc1950HeaderBytes;

	internal bool WantRfc1950HeaderBytes
	{
		get
		{
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_012f: Expected Obj, but got I4
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Expected Obj, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected I4, but got Unknown
			//IL_00a1: Expected I, but got Obj
			//IL_00b7: Expected Obj, but got I
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected Obj, but got Unknown
			//IL_00e2: Expected I, but got Obj
			Tree tree = treeLiterals;
			send_tree(dyn_ltree, tree.max_code);
			Tree tree2 = treeDistances;
			send_tree(dyn_dtree, tree2.max_code);
			((ZlibException)(object)treeBitLengths)._002Ector((string)(object)this);
			nint num = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v30 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = (byte)InternalConstants.BL_CODES != 0;
			bool flag2;
			bool flag3;
			do
			{
				flag2 = (byte)((flag ? 1u : 0u) - 1u) != 0;
				if ((flag2 ? 1 : 0) < 3)
				{
					break;
				}
				nint num3 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Tree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v30 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj3 = Tree.bl_order + 16;
				object obj4 = obj3 + flag2;
				object obj5 = obj4 << 1;
				object obj6 = obj5 << 1;
				object obj7 = (object)bl_tree + obj6;
				object obj8 = obj7 + 18;
				flag3 = obj8 == null;
				flag = flag2;
			}
			while (flag3);
			object obj9 = (flag2 ? 1 : 0) * 3;
			object obj10 = obj9 + 17;
			int num5 = obj10 + opt_len;
			opt_len = num5;
			return flag2;
		}
		set
		{
			//IL_0042: Expected Obj, but got I4
			//IL_0034: Expected Obj, but got I4
			Stream stream = ((block_start <= -1) ? ((Stream)(-1)) : ((Stream)block_start));
			CompressionMode mode = (CompressionMode)(strstart - block_start);
			((DeflateStream)this)._002Ector(stream, mode, value ? CompressionLevel.BestSpeed : CompressionLevel.None);
			block_start = strstart;
			((ZlibStream)(object)_codec).Flush();
		}
	}

	internal DeflateManager()
	{
	}

	private void _InitializeLazyMatch()
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01ed: Expected Obj, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0227: Expected Obj, but got I4
		//IL_00bc: Expected I, but got Obj
		//IL_00d2: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_028a: Expected Obj, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_00fd: Expected I, but got Obj
		object obj = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		obj = obj2;
		object obj3 = this + 148;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = default;
		obj3 = obj4;
		object obj5 = this + 152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj6 = default;
		obj5 = obj6;
		nint num = (nint)typeof(InternalConstants);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v40 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj8 = this + 156;
		object obj9 = InternalConstants.MAX_BITS + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj10 = default;
		obj8 = obj10;
		object obj11 = this + 160;
		int num3 = InternalConstants.L_CODES << 1;
		object obj12 = num3 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj13 = default;
		obj11 = obj13;
		object obj14 = this + 172;
		int num4 = InternalConstants.L_CODES << 1;
		object obj15 = num4 + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj16 = default;
		obj14 = obj16;
		_WantRfc1950HeaderBytes = true;
		nint num5 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v24 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num6 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v34 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj18 = this + 132;
		int num7 = HEAP_SIZE << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj19 = default;
		obj18 = obj19;
		object obj20 = this + 136;
		int num8 = InternalConstants.D_CODES << 1;
		object obj21 = num8 + 1;
		object obj22 = obj21 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj23 = default;
		obj20 = obj23;
		object obj24 = this + 140;
		int num9 = InternalConstants.BL_CODES << 1;
		object obj25 = num9 + 1;
		object obj26 = obj25 << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj27 = default;
		obj24 = obj27;
	}

	private void _InitializeTreeData()
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected Obj, but got Unknown
		//IL_00e6: Expected I, but got Obj
		//IL_00fc: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012f: Expected Obj, but got I4
		//IL_013b: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		//IL_0186: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		int num = w_size << 1;
		window_size = num;
		object a = this - -64;
		Array.ClearInternal((Array)a, 0, hash_size);
		nint num2 = (nint)typeof(Config);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v12 (Il2CppClass<Ionic.Zlib.DeflateManager+Config>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num3 = (nint)typeof(Config);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v37 (Il2CppClass<Ionic.Zlib.DeflateManager+Config>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 92;
		bool flag = ((WordHuntManager._003CDownloadDailyCoroutine_003Ed__10)compressionLevel).MoveNext();
		obj2 = flag;
		((DeflateStream)this).Flush();
		strstart = 0;
		block_start = 0;
		lookahead = 0;
		nint num4 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v23 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v31 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		match_length = (prev_length = MIN_MATCH - 1);
		match_available = 0;
		ins_h = 0;
	}

	internal void _InitializeBlocks()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected Obj, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected Obj, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		object obj = treeLiterals + 8;
		obj = dyn_ltree;
		nint num = (nint)typeof(StaticTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v6 (Il2CppClass<Ionic.Zlib.StaticTree>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(StaticTree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v34 (Il2CppClass<Ionic.Zlib.StaticTree>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = treeLiterals + 16;
		obj3 = StaticTree.Literals;
		object obj4 = treeDistances + 8;
		obj4 = dyn_dtree;
		object obj5 = treeDistances + 16;
		obj5 = StaticTree.Distances;
		object obj6 = treeBitLengths + 8;
		obj6 = bl_tree;
		object obj7 = treeBitLengths + 16;
		obj7 = StaticTree.BitLengths;
		bi_buf = 0;
		bi_valid = 0;
		last_eob_len = 8;
		_tr_align();
	}

	internal void pqdownheap(short[] tree, int k)
	{
		if (status != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
		}
	}

	internal unsafe static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_0114: Expected I4, but got Obj
		//IL_0114: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got Obj
		//IL_00b2: Expected I4, but got Obj
		//IL_00ad: Expected native int or pointer, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected I4, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0088: Expected I4, but got Obj
		//IL_0083: Expected native int or pointer, but got Obj
		nint num = (nint)typeof(KindlePurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KindlePurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((string)n).Substring((int)KindlePurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		if (text.m_firstChar == '\u0002')
		{
			object obj2 = text + 16;
			((int*)m)->m_value = (int)obj2;
			object obj3 = text + 20;
			((int*)(nint)depth)->m_value = (int)obj3;
			return true;
		}
		((int*)m)->m_value = (int)"";
		((int*)(nint)depth)->m_value = (int)"";
		return false;
	}

	internal void scan_tree(short[] tree, int max_code)
	{
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected Obj, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected Obj, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_0348: Expected I4, but got Obj
		//IL_0348: Expected I4, but got Obj
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0143: Expected I, but got Obj
		//IL_02dc: Expected I4, but got Obj
		//IL_02dc: Expected I4, but got Obj
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_00db: Expected I, but got Obj
		object obj = heap + 16;
		int num = max_code << 2;
		object obj2 = obj + num;
		int num2 = max_code;
		while (true)
		{
			int num3 = num2 << 1;
			if (num3 > heap_len)
			{
				break;
			}
			bool flag = num3 < heap_len;
			bool flag2 = !flag;
			int num4 = num3;
			if (!flag2)
			{
				int num5 = num3 << 2;
				object obj3 = heap + num5;
				object codec = obj3 + 20;
				object obj4 = heap + 16;
				int num6 = num3 << 2;
				object obj5 = obj4 + num6;
				nint num7 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v59 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num8 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v67 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num9 = ((DeflateManager)(object)tree).Initialize((ZlibCodec)codec, (CompressionLevel)obj5, (int)depth);
				bool flag3 = num9 == 0;
				num4 = num3;
				if (!flag3)
				{
					int num10 = num3 + 1;
					num4 = num10;
				}
			}
			object obj7 = heap + 16;
			int num11 = num4 << 2;
			object obj8 = obj7 + num11;
			nint num12 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v31 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num13 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S0_v42 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((DeflateManager)(object)tree).Initialize((ZlibCodec)obj2, (CompressionLevel)obj8, (int)depth) != 0)
			{
				break;
			}
			object obj10 = heap + 16;
			int num14 = num2 << 2;
			object obj11 = obj10 + num14;
			object obj12 = heap + 16;
			int num15 = num4 << 2;
			object obj13 = obj12 + num15;
			obj11 = obj13;
			num2 = num4;
		}
		object obj14 = heap + 16;
		int num16 = num2 << 2;
		object obj15 = obj14 + num16;
		obj15 = obj2;
	}

	internal int build_bl_tree()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(PurchaseValidationExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PurchaseValidationExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return PurchaseValidationExtensions._hasDetectedAnyInvalidPurchases ? 1 : 0;
	}

	internal void send_all_trees(int lcodes, int dcodes, int blcodes)
	{
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected Obj, but got Unknown
		//IL_02ea: Expected Obj, but got I4
		//IL_02c5: Expected Obj, but got I
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_004a: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0233: Expected I, but got Obj
		//IL_0249: Expected Obj, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_03f0: Expected Obj, but got I4
		//IL_0400: Expected Obj, but got I
		//IL_0415: Expected Obj, but got I
		//IL_0274: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_0153: Expected I, but got Obj
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_01e1: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = blcodes;
		if (this != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj4 = default;
			object obj3 = obj4 + 12;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj6 = default;
			object obj5 = obj6 + 8;
			obj5 = lcodes;
			object obj7 = obj6 + 12;
			obj7 = dcodes;
			object obj8 = obj4 + 8;
			obj8 = obj6;
			bool flag;
			if (lcodes != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [lcodes @ L1 (System.Int32)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				bool flag2;
				if (dcodes != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dcodes @ L2 (System.Int32)+8]");
					flag2 = (nint)0 == 0;
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					nint num = (nint)typeof(PurchaseValidationExtensions);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v54 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num2 = (nint)typeof(PurchaseValidationExtensions);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v87 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(PurchaseValidationExtensions._hasDetectedAnyInvalidPurchases ? 1u : 0u) != 0)
					{
						nint num3 = (nint)typeof(InAppManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v63 (Il2CppClass<InApp.InAppManager>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num4 = (nint)typeof(InAppManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v83 (Il2CppClass<InApp.InAppManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Dictionary<string, InAppItemModel> activeInAppOffers = InAppManager.GetActiveInAppOffers();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num5 = 0;
						_ = 0;
						object obj12 = default;
						object obj11 = obj12 + 16;
						obj11 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 2;
			Encoding uTF = Encoding.UTF32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
			nint num6 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v35 (Il2CppClass<System.Convert>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num7 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v46 (Il2CppClass<System.Convert>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			IPurchaseValidationResult purchaseValidationResult = default;
			object obj14 = purchaseValidationResult + 12;
			string s = default;
			byte[] array = Convert.FromBase64String(s);
			obj14 = array;
			object obj15 = purchaseValidationResult + 16;
			obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v15+C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v44+8]");
			((Action<IPurchaseValidationResult>)0)(purchaseValidationResult);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((Action<IPurchaseValidationResult>)0)(null);
		}
	}

	internal void send_tree(short[] tree, int max_code)
	{
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected Obj, but got Unknown
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected Obj, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0465: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_0497: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected Obj, but got Unknown
		//IL_0252: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected Obj, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Expected Obj, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected Obj, but got Unknown
		//IL_04cd: Expected I, but got Obj
		//IL_04e3: Expected Obj, but got I
		//IL_0398: Expected Obj, but got I4
		//IL_0342: Expected I, but got Obj
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0627: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected Obj, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected Obj, but got Unknown
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0656: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected Obj, but got Unknown
		//IL_059b: Expected Obj, but got I4
		//IL_038a: Expected Obj, but got I4
		//IL_02d1: Expected I, but got Obj
		//IL_0205: Expected I, but got Obj
		//IL_03b4: Expected Obj, but got I4
		//IL_05e4: Expected Obj, but got I4
		//IL_03a6: Expected Obj, but got I4
		//IL_03c2: Expected Obj, but got I4
		//IL_03db: Expected Obj, but got I4
		object obj = tree + 18;
		object obj2 = obj & 0xFFFF;
		bool flag = obj2 == null;
		object obj3 = ((!flag) ? ((object)4) : ((object)3));
		int num = max_code << 1;
		int num2 = num << 1;
		object obj4 = tree + num2;
		object obj5 = obj4 + 22;
		obj5 = 32767;
		object obj6 = ((!flag) ? ((object)7) : ((object)138));
		object obj7 = obj;
		object obj8 = obj6;
		object obj9 = -1;
		object obj10 = obj3;
		object obj11 = default;
		object obj13 = default;
		object obj45 = default;
		while ((nint)obj11 <= max_code)
		{
			object obj12 = obj13 + 1;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
			object obj14 = obj11 << 1;
			object obj15 = obj14 << 1;
			object obj16 = (object)tree + obj15;
			object obj17 = obj16 + 22;
			bool flag3 = obj7 == obj17;
			object obj18 = flag2 & flag3;
			if (obj18 == null)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10))
				{
					object obj19 = bl_tree + 16;
					object obj20 = obj7 << 2;
					object obj21 = obj19 + obj20;
					object obj22 = bl_tree + 16;
					object obj23 = obj7 << 2;
					object obj24 = obj22 + obj23;
					object obj25 = obj12 + obj24;
					obj21 = obj25;
				}
				else if (obj7 != null)
				{
					if (obj7 != obj9)
					{
						object obj26 = bl_tree + 16;
						object obj27 = obj7 << 2;
						object obj28 = obj26 + obj27;
						object obj29 = obj28 + 1;
						obj28 = obj29;
					}
					nint num3 = (nint)typeof(InternalConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S1_v42 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
					object obj30 = (nint)0 & (nint)0x200;
					if (obj30 != null)
					{
						nint num4 = (nint)typeof(InternalConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S1_v54 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj31 = bl_tree + 16;
					int num5 = InternalConstants.REP_3_6 << 2;
					object obj32 = obj31 + num5;
					object obj33 = obj32 + 1;
					obj32 = obj33;
				}
				else
				{
					nint num6 = (nint)typeof(InternalConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v53 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
					object obj34 = (nint)0 & (nint)0x200;
					bool flag4 = obj34 == null;
					if ((nint)obj12 > 10)
					{
						if (!flag4)
						{
							nint num7 = (nint)typeof(InternalConstants);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v77 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj35 = bl_tree + 16;
						int num8 = InternalConstants.REPZ_11_138 << 2;
						object obj36 = obj35 + num8;
						object obj37 = obj36 + 1;
						obj36 = obj37;
					}
					else
					{
						if (!flag4)
						{
							nint num9 = (nint)typeof(InternalConstants);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v65 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj38 = bl_tree + 16;
						int num10 = InternalConstants.REPZ_3_10 << 2;
						object obj39 = obj38 + num10;
						object obj40 = obj39 + 1;
						obj39 = obj40;
					}
				}
				object obj41 = obj17 & 0xFFFF;
				bool flag5 = obj41 == null;
				object obj42 = ((!flag3) ? ((object)7) : ((object)6));
				object obj43 = flag5 | flag3;
				object obj44 = ((obj43 == null) ? ((object)4) : ((object)3));
				bool flag6 = !flag5;
				obj8 = obj42;
				obj9 = obj7;
				obj10 = obj44;
				obj13 = 0;
				if (!flag6)
				{
					obj8 = 138;
					obj9 = obj7;
					obj10 = obj44;
					obj13 = 0;
				}
			}
			obj11 = obj45 + 1;
			obj7 = obj17;
		}
	}

	private void put_bytes(byte[] p, int start, int len)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0127: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I4
		//IL_0144: Expected Obj, but got I4
		//IL_0153: Expected Obj, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected Obj, but got Unknown
		//IL_00d8: Expected I4, but got Obj
		//IL_00e6: Expected Obj, but got I4
		//IL_00f6: Expected I4, but got Obj
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		short[] ltree = (short[])(p - 257);
		send_compressed_block(ltree, (short[])5);
		short[] ltree2 = (short[])(start - 1);
		send_compressed_block(ltree2, (short[])5);
		short[] ltree3 = (short[])(len - 4);
		send_compressed_block(ltree3, (short[])4);
		object obj = default;
		object obj5 = default;
		while ((nint)obj < len)
		{
			nint num = (nint)typeof(Tree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v23 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = Tree.bl_order + 16;
			object obj4 = obj3 + obj5;
			object obj6 = obj4 << 1;
			object obj7 = obj6 << 1;
			object obj8 = (object)bl_tree + obj7;
			object ltree4 = obj8 + 18;
			send_compressed_block((short[])ltree4, (short[])3);
			obj = obj5 + 1;
		}
		short[] tree = (short[])(p - 1);
		send_code((int)dyn_ltree, tree);
		short[] tree2 = (short[])(start - 1);
		send_code((int)dyn_dtree, tree2);
	}

	internal void send_code(int c, short[] tree)
	{
		//IL_0385: Expected Obj, but got I4
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected I4, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0038: Expected Obj, but got I4
		//IL_03dc: Expected I4, but got Obj
		//IL_002a: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00ac: Expected Obj, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_0410: Expected I4, but got Obj
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_010b: Expected I4, but got Obj
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_04d0: Expected I4, but got Obj
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected Obj, but got Unknown
		//IL_04ed: Expected Obj, but got I4
		//IL_0423: Expected I, but got Obj
		//IL_0439: Expected Obj, but got I
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected I4, but got Unknown
		//IL_02f1: Expected I, but got Obj
		//IL_049d: Expected I4, but got Obj
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected Obj, but got Unknown
		//IL_04ba: Expected Obj, but got I4
		//IL_0578: Expected I4, but got Obj
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected Obj, but got Unknown
		//IL_0595: Expected Obj, but got I4
		//IL_018b: Expected I4, but got Obj
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0347: Expected Obj, but got I4
		//IL_0280: Expected I, but got Obj
		//IL_01b4: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I4
		//IL_0339: Expected Obj, but got I4
		//IL_0363: Expected Obj, but got I4
		//IL_0355: Expected Obj, but got I4
		//IL_0371: Expected Obj, but got I4
		object obj = c + 18;
		int num = obj & 0xFFFF;
		bool flag = num == 0;
		object obj2 = ((!flag) ? ((object)4) : ((object)3));
		object obj3 = ((!flag) ? ((object)7) : ((object)138));
		int num2 = (int)obj;
		object obj4 = obj3;
		int num3 = -1;
		object obj5 = obj2;
		object obj6 = default;
		object obj21 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) <= System.Runtime.CompilerServices.Unsafe.As<short[], UIntPtr>(ref tree))
		{
			object obj7 = 0 + 1;
			bool flag2 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4);
			object obj8 = obj6 << 1;
			object obj9 = obj8 << 1;
			object obj10 = c + obj9;
			object obj11 = obj10 + 22;
			bool flag3 = num2 == (nint)obj11;
			object obj12 = flag2 & flag3;
			if (obj12 == null)
			{
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
				{
					object obj13;
					do
					{
						send_bits(num2, (int)bl_tree);
						obj13 = obj7 - 1;
					}
					while (obj13 != null);
				}
				else if (num2 != 0)
				{
					bool flag4 = num2 != num3;
					bool flag5 = !flag4;
					object obj14 = obj7;
					if (!flag5)
					{
						send_bits(num2, (int)bl_tree);
						object obj15 = obj7 - 1;
						obj14 = obj15;
					}
					nint num4 = (nint)typeof(InternalConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v81 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num5 = (nint)typeof(InternalConstants);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v87 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					send_bits(InternalConstants.REP_3_6, (int)bl_tree);
					short[] ltree = (short[])(obj14 - 3);
					send_compressed_block(ltree, (short[])2);
				}
				else
				{
					nint num6 = (nint)typeof(InternalConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v49 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
					object obj17 = (nint)0 & (nint)0x200;
					bool flag6 = obj17 == null;
					if ((nint)obj7 > 10)
					{
						if (!flag6)
						{
							nint num7 = (nint)typeof(InternalConstants);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v71 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						send_bits(InternalConstants.REPZ_11_138, (int)bl_tree);
						short[] ltree2 = (short[])(obj7 - 11);
						send_compressed_block(ltree2, (short[])7);
					}
					else
					{
						if (!flag6)
						{
							nint num8 = (nint)typeof(InternalConstants);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v60 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						send_bits(InternalConstants.REPZ_3_10, (int)bl_tree);
						short[] ltree3 = (short[])(obj7 - 3);
						send_compressed_block(ltree3, (short[])3);
					}
				}
				int num9 = obj11 & 0xFFFF;
				bool flag7 = num9 == 0;
				object obj18 = ((!flag3) ? ((object)7) : ((object)6));
				object obj19 = flag7 | flag3;
				object obj20 = ((obj19 == null) ? ((object)4) : ((object)3));
				bool flag8 = !flag7;
				obj4 = obj18;
				if (!flag8)
				{
					obj4 = 138;
				}
				num3 = num2;
				obj5 = obj20;
			}
			obj6 = obj21 + 1;
			num2 = (int)obj11;
		}
	}

	internal void send_bits(int value, int length)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		object obj = length + 16;
		int num = value << 1;
		int num2 = num << 1;
		object ltree = obj + num2;
		int num3 = num << 1;
		object obj2 = length + num3;
		object dtree = obj2 + 18;
		send_compressed_block((short[])ltree, (short[])dtree);
	}

	internal void _tr_align()
	{
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_00a2: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_02f2: Expected I, but got Obj
		//IL_0308: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_014c: Expected Obj, but got I4
		//IL_00b5: Expected I, but got Obj
		//IL_035b: Expected I, but got Obj
		//IL_0371: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_0128: Expected Obj, but got I4
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_01fb: Expected I, but got Obj
		//IL_0211: Expected Obj, but got I
		//IL_015f: Expected I, but got Obj
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03c3: Expected Obj, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01d2: Expected Obj, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Obj, but got Unknown
		//IL_023c: Expected I, but got Obj
		object obj2 = default;
		object obj5 = default;
		while (true)
		{
			nint num = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v6 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v68 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj2 >= InternalConstants.L_CODES)
			{
				break;
			}
			object obj3 = dyn_ltree + 16;
			object obj4 = obj5 << 2;
			object obj6 = obj3 + obj4;
			obj6 = 0;
			obj2 = obj5 + 1;
		}
		object obj7 = 0;
		while (true)
		{
			nint num3 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v15 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v56 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj7 >= InternalConstants.D_CODES)
			{
				break;
			}
			object obj9 = dyn_dtree + 16;
			object obj10 = obj7 << 2;
			object obj11 = obj9 + obj10;
			obj11 = 0;
			object obj12 = obj7 + 1;
			obj7 = obj12;
		}
		object obj13 = 0;
		while (true)
		{
			nint num5 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v24 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num6 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v44 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj13 >= InternalConstants.BL_CODES)
			{
				break;
			}
			object obj15 = bl_tree + 16;
			object obj16 = obj13 << 2;
			object obj17 = obj15 + obj16;
			obj17 = 0;
			object obj18 = obj13 + 1;
			obj13 = obj18;
		}
		nint num7 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S1_v17 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num8 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v31 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj20 = dyn_ltree + 16;
		int num9 = END_BLOCK << 2;
		object obj21 = obj20 + num9;
		obj21 = 1;
		static_len = 0;
		opt_len = 0;
		matches = 0;
		last_lit = 0;
	}

	internal unsafe bool _tr_tally(int dist, int lc)
	{
		//IL_0274: Expected Obj, but got I4
		//IL_0282: Expected I, but got Obj
		//IL_0298: Expected Obj, but got I
		//IL_02ef: Expected I4, but got Obj
		//IL_02ef: Expected Obj, but got I4
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01ab: Expected Obj, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		IFormatProvider formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(KindlePurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(KindlePurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v67 (Il2CppClass<InAppPurchase.Internal.KindlePurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((string)dist).Substring((int)KindlePurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		object obj2 = text + 12;
		if ((nint)obj2 >= 1)
		{
			object obj3 = text + 16;
			if (((int*)obj3)->System_002EIConvertible_002EToBoolean(formatProvider))
			{
				object obj4 = (object)formatProvider << 2;
				object obj5 = obj4 + 1;
				if (obj2 == obj5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj6 = 0;
					int num3 = default;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<IFormatProvider, UIntPtr>(ref formatProvider))
					{
						object obj7 = text + 16;
						object obj8 = obj6 << 2;
						object obj9 = obj8 + 1;
						object obj10 = obj9 << 2;
						object obj11 = obj7 + obj10;
						object obj12 = obj9 << 2;
						object obj13 = text + obj12;
						object obj14 = obj13 + 20;
						object obj15 = obj9 << 2;
						object obj16 = text + obj15;
						object obj17 = obj16 + 24;
						object obj18 = obj9 << 2;
						object obj19 = text + obj18;
						object obj20 = obj19 + 28;
						object obj21 = num3 + 16;
						object obj22 = obj6 << 4;
						object obj23 = obj21 + obj22;
						obj23 = obj11;
						object obj24 = obj23 + 4;
						obj24 = obj14;
						object obj25 = obj23 + 8;
						obj25 = obj17;
						object obj26 = obj23 + 12;
						obj26 = obj20;
						object obj27 = obj6 + 1;
						obj6 = obj27;
					}
					((int*)lc)->m_value = num3;
					return true;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int value = default;
		((int*)lc)->m_value = value;
		return false;
	}

	internal void send_compressed_block(short[] ltree, short[] dtree)
	{
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_026f: Expected I4, but got Obj
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected I4, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0095: Expected Obj, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00e6: Expected Obj, but got I4
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_01e3: Expected Obj, but got I4
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_01fe: Expected I4, but got Obj
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected I4, but got Unknown
		//IL_0135: Expected I, but got Obj
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = Buf_size - dtree;
		bool flag = bi_valid > (nint)obj2;
		int num3 = bi_valid & 0x1F;
		int num4 = (object)ltree << num3;
		int num5 = num4 | bi_buf;
		bi_buf = (short)num5;
		if (flag)
		{
			int num6 = pendingCount + 1;
			pendingCount = num6;
			object obj3 = pending + 16;
			object obj4 = obj3 + pendingCount;
			obj4 = bi_buf;
			int num7 = pendingCount + 1;
			pendingCount = num7;
			object obj5 = pending + 16;
			object obj6 = obj5 + pendingCount;
			int num8 = bi_buf >> 8;
			obj6 = num8;
			nint num9 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num10 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v25 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj8 = Buf_size - bi_valid;
			object obj9 = obj8 & 0x1F;
			short num11 = (short)((object)ltree >> (int)obj9);
			bi_buf = num11;
			object obj10 = dtree - Buf_size;
			int num12 = obj10 + bi_valid;
			bi_valid = num12;
		}
		else
		{
			int num13 = dtree + bi_valid;
			bi_valid = num13;
		}
	}

	internal void set_data_type()
	{
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_02ad: Expected Obj, but got I4
		//IL_02bc: Expected Obj, but got I4
		//IL_02ca: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_01d7: Expected I4, but got Obj
		//IL_01ed: Expected Obj, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0233: Expected Obj, but got I4
		//IL_0242: Expected Obj, but got I4
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_0293: Expected I4, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v64 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		short[] ltree = (short[])(STATIC_TREES << 1);
		send_compressed_block(ltree, (short[])3);
		nint num3 = (nint)typeof(StaticTree);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v16 (Il2CppClass<Ionic.Zlib.StaticTree>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(StaticTree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v58 (Il2CppClass<Ionic.Zlib.StaticTree>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		send_bits(END_BLOCK, (int)StaticTree.lengthAndLiteralsTreeCodes);
		bi_windup();
		object obj3 = last_eob_len + 11;
		object obj4 = obj3 - bi_valid;
		if ((nint)obj4 < 9)
		{
			nint num5 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v30 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v52 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			short[] ltree2 = (short[])(STATIC_TREES << 1);
			send_compressed_block(ltree2, (short[])3);
			nint num7 = (nint)typeof(StaticTree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v40 (Il2CppClass<Ionic.Zlib.StaticTree>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(StaticTree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v46 (Il2CppClass<Ionic.Zlib.StaticTree>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			send_bits(END_BLOCK, (int)StaticTree.lengthAndLiteralsTreeCodes);
			bi_windup();
		}
		last_eob_len = 7;
	}

	internal void bi_flush()
	{
		//IL_02bb: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_034c: Expected I, but got Obj
		//IL_0362: Expected Obj, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_00ce: Expected I, but got Obj
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0273: Expected I, but got Obj
		//IL_0202: Expected I, but got Obj
		object obj = 0;
		object obj2 = default;
		while ((nint)obj2 <= 6)
		{
			object obj3 = dyn_ltree + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			object obj6 = obj5 + obj;
			object obj7 = obj2 + 1;
			obj2 = obj7;
			obj = obj6;
		}
		object obj11 = default;
		object obj12 = default;
		while ((nint)obj2 <= 127)
		{
			object obj8 = dyn_ltree + 16;
			object obj9 = obj2 << 2;
			object obj10 = obj8 + obj9;
			obj11 = obj10 + obj12;
			object obj13 = obj2 + 1;
			obj2 = obj13;
		}
		object obj14 = obj;
		while (true)
		{
			nint num = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v15 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num2 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v35 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((nint)obj2 >= InternalConstants.LITERALS)
			{
				break;
			}
			object obj16 = dyn_ltree + 16;
			object obj17 = obj2 << 2;
			object obj18 = obj16 + obj17;
			object obj19 = obj18 + obj14;
			object obj20 = obj2 + 1;
			obj14 = obj19;
			obj2 = obj20;
		}
		nint num3 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v22 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		bool flag = obj21 == null;
		object obj22 = obj11 >> 2;
		sbyte b;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v33 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			b = (sbyte)Z_BINARY;
		}
		else
		{
			if (!flag)
			{
				nint num5 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S1_v21 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			b = (sbyte)Z_ASCII;
		}
		data_type = b;
	}

	internal void bi_windup()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006d: Expected Obj, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		if (bi_valid == 16)
		{
			int num = pendingCount + 1;
			pendingCount = num;
			object obj = pending + 16;
			object obj2 = obj + pendingCount;
			obj2 = bi_buf;
			int num2 = pendingCount + 1;
			pendingCount = num2;
			object obj3 = pending + 16;
			object obj4 = obj3 + pendingCount;
			int num3 = bi_buf >> 8;
			obj4 = num3;
			bi_buf = 0;
			bi_valid = 0;
		}
		else if (bi_valid > 7)
		{
			int num4 = pendingCount + 1;
			pendingCount = num4;
			object obj5 = pending + 16;
			object obj6 = obj5 + pendingCount;
			obj6 = bi_buf;
			int num5 = bi_buf << 16;
			int num6 = num5 >> 24;
			bi_buf = (short)num6;
			int num7 = bi_valid - 8;
			bi_valid = num7;
		}
	}

	internal void copy_block(int buf, int len, bool header)
	{
		//IL_001d: Expected Obj, but got I4
		Array.ConstrainedCopy((Array)buf, len, pending, pendingCount, header ? 1 : 0);
		int num = (header ? 1 : 0) + pendingCount;
		pendingCount = num;
	}

	internal void flush_block_only(bool eof)
	{
		//IL_000f: Expected Obj, but got I4
		//IL_000f: Expected Obj, but got I4
		((KindlePurchaseProvider)this).HandleRestore((string)eof, (string)6);
	}

	internal BlockState DeflateNone(FlushType flush)
	{
		return BlockState.NeedMore;
	}

	internal void _tr_stored_block(int buf, int stored_len, bool eof)
	{
		//IL_0171: Expected I4, but got Obj
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected Obj, but got Unknown
		//IL_00ba: Expected Obj, but got I4
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected Obj, but got Unknown
		//IL_0109: Expected Obj, but got I4
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_0158: Expected Obj, but got I4
		_fillWindow();
		last_eob_len = 8;
		if (eof)
		{
			int num = pendingCount + 1;
			pendingCount = num;
			object obj = pending + 16;
			object obj2 = obj + pendingCount;
			obj2 = stored_len;
			int num2 = pendingCount + 1;
			pendingCount = num2;
			object obj3 = pending + 16;
			object obj4 = obj3 + pendingCount;
			int num3 = stored_len >> 8;
			obj4 = num3;
			int num4 = pendingCount + 1;
			pendingCount = num4;
			object obj5 = pending + 16;
			object obj6 = obj5 + pendingCount;
			int num5 = stored_len ^ -1;
			obj6 = num5;
			int num6 = pendingCount + 1;
			pendingCount = num6;
			object obj7 = pending + 16;
			object obj8 = obj7 + pendingCount;
			int num7 = num5 >> 8;
			obj8 = num7;
		}
		copy_block((int)window, buf, (byte)stored_len != 0);
	}

	internal void _tr_flush_block(int buf, int stored_len, bool eof)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00af: Expected Obj, but got I4
		//IL_00be: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = STORED_BLOCK << 1;
		short[] ltree = (short[])((eof ? 1 : 0) + num3);
		send_compressed_block(ltree, (short[])3);
		_tr_stored_block(buf, stored_len, eof: true);
	}

	private void _fillWindow()
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_00e2: Expected Obj, but got I4
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0133: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		if (bi_valid < 9)
		{
			if (bi_valid >= 1)
			{
				int num = pendingCount + 1;
				pendingCount = num;
				object obj = pending + 16;
				object obj2 = obj + pendingCount;
				obj2 = bi_buf;
			}
		}
		else
		{
			int num2 = pendingCount + 1;
			pendingCount = num2;
			object obj3 = pending + 16;
			object obj4 = obj3 + pendingCount;
			obj4 = bi_buf;
			int num3 = pendingCount + 1;
			pendingCount = num3;
			object obj5 = pending + 16;
			object obj6 = obj5 + pendingCount;
			int num4 = bi_buf >> 8;
			obj6 = num4;
		}
		bi_buf = 0;
		bi_valid = 0;
	}

	internal BlockState DeflateFast(FlushType flush)
	{
		//IL_02f8: Expected Obj, but got I4
		//IL_002d: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected I4, but got Unknown
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_0331: Expected Obj, but got I4
		//IL_0341: Expected Obj, but got I4
		//IL_01a6: Expected I, but got Obj
		byte[] array = pending;
		object obj = array.Length - 5;
		object obj2;
		if ((nint)obj > 65534)
		{
			obj2 = 65535;
		}
		else
		{
			byte[] array2 = pending;
			obj2 = array2.Length - 5;
		}
		while (true)
		{
			if (lookahead <= 1)
			{
				Reset();
				if (((uint)lookahead | (uint)flush) == 0)
				{
					goto IL_0221;
				}
				if (lookahead == 0)
				{
					break;
				}
			}
			int num = lookahead + strstart;
			strstart = num;
			lookahead = 0;
			int num2 = obj2 + block_start;
			if (strstart == 0 || strstart >= num2)
			{
				int num3 = strstart - num2;
				lookahead = num3;
				strstart = num2;
				WantRfc1950HeaderBytes = false;
				ZlibCodec codec = _codec;
				if (codec.AvailableBytesOut == 0)
				{
					goto IL_0221;
				}
			}
			nint num4 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v10 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num5 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S2_v19 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = strstart - block_start;
			object obj5 = w_size - MIN_LOOKAHEAD;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
			{
				WantRfc1950HeaderBytes = false;
				ZlibCodec codec2 = _codec;
				if (codec2.AvailableBytesOut != 0)
				{
					continue;
				}
				goto IL_0221;
			}
			continue;
			IL_0221:
			return BlockState.NeedMore;
		}
		bool flag = (WantRfc1950HeaderBytes = flush == FlushType.Finish);
		ZlibCodec codec3 = _codec;
		if (codec3.AvailableBytesOut != 0)
		{
			if (flag)
			{
				return BlockState.FinishDone;
			}
			return BlockState.BlockDone;
		}
		if (flag)
		{
			return BlockState.FinishStarted;
		}
		return BlockState.NeedMore;
	}

	internal BlockState DeflateSlow(FlushType flush)
	{
		//IL_0c75: Expected I, but got Obj
		//IL_0c8b: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0154: Expected I, but got Obj
		//IL_071f: Expected Obj, but got I4
		//IL_0d67: Expected I, but got Obj
		//IL_0d7d: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_00a7: Expected I, but got Obj
		//IL_022f: Expected I, but got Obj
		//IL_0245: Expected Obj, but got I
		//IL_0789: Expected Obj, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected Obj, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Expected I4, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected Obj, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected Obj, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected Obj, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected Obj, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_083e: Expected Obj, but got Unknown
		//IL_0844: Unknown result type (might be due to invalid IL or missing references)
		//IL_0849: Expected Obj, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected Obj, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08bc: Expected Obj, but got I4
		//IL_03ed: Expected I, but got Obj
		//IL_0403: Expected Obj, but got I
		//IL_031b: Expected I, but got Obj
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected Obj, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I4
		//IL_0930: Expected Obj, but got I4
		//IL_01e2: Expected I, but got Obj
		//IL_094f: Expected Obj, but got I4
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Expected Obj, but got Unknown
		//IL_0384: Expected I4, but got Obj
		//IL_0270: Expected I, but got Obj
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected Obj, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected Obj, but got Unknown
		//IL_0a16: Expected I4, but got Obj
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected Obj, but got Unknown
		//IL_0a4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a54: Expected Obj, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected I4, but got Unknown
		//IL_0aa2: Expected Obj, but got I4
		//IL_042e: Expected I, but got Obj
		//IL_02d8: Expected Obj, but got I4
		//IL_047b: Expected I, but got Obj
		//IL_0491: Expected Obj, but got I
		//IL_03da: Expected I4, but got Obj
		//IL_05ea: Expected Obj, but got I4
		//IL_0308: Expected Obj, but got I4
		//IL_04bc: Expected I, but got Obj
		//IL_0cfc: Expected I, but got Obj
		//IL_0d12: Expected Obj, but got I
		//IL_0aed: Expected Obj, but got I4
		//IL_0b0c: Expected Obj, but got I4
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected Obj, but got Unknown
		//IL_0b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected I4, but got Unknown
		//IL_0b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5a: Expected Obj, but got Unknown
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected Obj, but got Unknown
		//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b85: Expected Obj, but got Unknown
		//IL_0b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b95: Expected Obj, but got Unknown
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected Obj, but got Unknown
		//IL_0bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected Obj, but got Unknown
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected Obj, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Expected Obj, but got Unknown
		//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0a: Expected Obj, but got Unknown
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected Obj, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Expected Obj, but got Unknown
		//IL_0c3f: Expected Obj, but got I4
		//IL_0528: Expected I, but got Obj
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_05a1: Expected I4, but got Obj
		//IL_05ab: Expected Obj, but got I4
		//IL_05cb: Expected I4, but got Obj
		//IL_05d5: Expected Obj, but got I4
		bool flag = flush == FlushType.None;
		byte[] array = null;
		int num18 = default;
		byte[] array2 = default;
		while (true)
		{
			nint num = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v4 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v176 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (lookahead < MIN_LOOKAHEAD)
			{
				Reset();
				nint num3 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v171 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v192 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = lookahead < MIN_LOOKAHEAD;
				object obj3 = flag & flag2;
				if (obj3 != null)
				{
					goto IL_062b;
				}
				if (lookahead == 0)
				{
					break;
				}
			}
			nint num5 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S1_v15 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v163 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (lookahead >= MIN_MATCH)
			{
				nint num7 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v141 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ S0_v161 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num9 = hash_shift & 0x1F;
				int num10 = ins_h << num9;
				object obj6 = MIN_MATCH + strstart;
				object obj7 = (object)window + obj6;
				object obj8 = obj7 + 15;
				int num11 = num10 ^ obj8;
				int num12 = num11 & hash_mask;
				ins_h = num12;
				object obj9 = this - -64;
				object obj10 = obj9 + 16;
				int num13 = ins_h << 1;
				object obj11 = obj10 + num13;
				object obj12 = prev + 16;
				int num14 = w_mask & strstart;
				int num15 = num14 << 1;
				object obj13 = obj12 + num15;
				object obj14 = this - -64;
				object obj15 = obj14 + 16;
				int num16 = ins_h << 1;
				object obj16 = obj15 + num16;
				obj13 = obj16;
				object obj17 = this - -64;
				object obj18 = obj17 + 16;
				int num17 = ins_h << 1;
				object obj19 = obj18 + num17;
				obj19 = strstart;
				array = (byte[])obj11;
				num18 = strstart;
				array2 = window;
			}
			if (array != null)
			{
				nint num19 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S1_v118 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj20 = (nint)0 & (nint)0x200;
				if (obj20 != null)
				{
					nint num20 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ S1_v129 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj21 = strstart - array;
				object obj22 = obj21 & 0xFFFF;
				object obj23 = w_size - MIN_LOOKAHEAD;
				bool flag3 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23);
				bool flag4 = !flag3;
				array2 = (byte[])w_size;
				if (!flag4)
				{
					bool flag5 = compressionStrategy != CompressionStrategy.HuffmanOnly;
					bool flag6 = !flag5;
					array2 = (byte[])w_size;
					if (!flag6)
					{
						int num21 = SetDictionary(array);
						match_length = num21;
						array2 = (byte[])w_size;
					}
				}
			}
			nint num22 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ S0_v25 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num23 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v117 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num27;
			int num28;
			if (match_length < MIN_MATCH)
			{
				object obj25 = window + 16;
				object obj26 = obj25 + strstart;
				int num24 = Initialize(null, (CompressionLevel)obj26);
				int num25 = lookahead - 1;
				lookahead = num25;
				int num26 = strstart + 1;
				strstart = num26;
				if (num24 == 0)
				{
					num27 = num18;
					num28 = (int)array2;
					goto IL_05da;
				}
			}
			else
			{
				nint num29 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S0_v46 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj27 = (nint)0 & (nint)0x200;
				if (obj27 != null)
				{
					nint num30 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ S0_v109 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				ZlibCodec codec = (ZlibCodec)(strstart - match_start);
				CompressionLevel level = (CompressionLevel)(match_length - MIN_MATCH);
				int num31 = Initialize(codec, level);
				int num32 = lookahead - match_length;
				lookahead = num32;
				Config config = this.config;
				if (match_length <= config.MaxLazy)
				{
					nint num33 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v57 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num34 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ S1_v106 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (lookahead >= MIN_MATCH)
					{
						int num35 = match_length - 1;
						match_length = num35;
						object obj36;
						do
						{
							int num36 = strstart + 1;
							strstart = num36;
							nint num37 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ S0_v77 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
							object obj29 = (nint)0 & (nint)0x200;
							if (obj29 != null)
							{
								nint num38 = (nint)typeof(DeflateManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ S0_v103 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							object obj30 = hash_shift & 0x1F;
							int num39 = ins_h << (int)obj30;
							object obj31 = MIN_MATCH + strstart;
							object obj32 = (object)window + obj31;
							object obj33 = obj32 + 15;
							int num40 = num39 ^ obj33;
							int num41 = num40 & hash_mask;
							ins_h = num41;
							object obj34 = this - -64;
							object obj35 = obj34 + 16;
							int num42 = ins_h << 1;
							obj36 = obj35 + num42;
							object obj37 = prev + 16;
							int num43 = w_mask & strstart;
							int num44 = num43 << 1;
							object obj38 = obj37 + num44;
							object obj39 = this - -64;
							object obj40 = obj39 + 16;
							int num45 = ins_h << 1;
							object obj41 = obj40 + num45;
							obj38 = obj41;
							object obj42 = this - -64;
							object obj43 = obj42 + 16;
							int num46 = ins_h << 1;
							object obj44 = obj43 + num46;
							obj44 = strstart;
						}
						while (--match_length != 0);
						byte[] array3 = (byte[])(obj36 & 0xFFFF);
						int num47 = strstart + 1;
						strstart = num47;
						array = array3;
						num18 = (int)window;
						array2 = (byte[])hash_shift;
						if (num31 == 0)
						{
							array = array3;
							num18 = (int)window;
							array2 = (byte[])hash_shift;
							continue;
						}
						goto IL_05ef;
					}
				}
				int num48 = match_length + strstart;
				strstart = num48;
				match_length = 0;
				object obj45 = window + 16;
				object obj46 = obj45 + strstart;
				ins_h = (int)obj46;
				int num49 = hash_shift & 0x1F;
				int num50 = ins_h << num49;
				object obj47 = window + strstart;
				object obj48 = obj47 + 17;
				int num51 = num50 ^ obj48;
				int num52 = num51 & hash_mask;
				ins_h = num52;
				num27 = match_length;
				num28 = match_start;
				num18 = match_length;
				array2 = (byte[])match_start;
				if (num31 == 0)
				{
					goto IL_05da;
				}
			}
			goto IL_05ef;
			IL_05ef:
			WantRfc1950HeaderBytes = false;
			ZlibCodec codec2 = _codec;
			if (codec2.AvailableBytesOut != 0)
			{
				continue;
			}
			goto IL_062b;
			IL_05da:
			num18 = num27;
			array2 = (byte[])num28;
			continue;
			IL_062b:
			return BlockState.NeedMore;
		}
		bool flag7 = (WantRfc1950HeaderBytes = flush == FlushType.Finish);
		ZlibCodec codec3 = _codec;
		if (codec3.AvailableBytesOut != 0)
		{
			if (flag7)
			{
				return BlockState.FinishDone;
			}
			return BlockState.BlockDone;
		}
		if (flag7)
		{
			return BlockState.FinishStarted;
		}
		return BlockState.NeedMore;
	}

	internal int longest_match(int cur_match)
	{
		//IL_0edf: Expected I, but got Obj
		//IL_0ef5: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0f8c: Expected I, but got Obj
		//IL_0fa2: Expected Obj, but got I
		//IL_0154: Expected I, but got Obj
		//IL_0990: Expected Obj, but got I4
		//IL_01a1: Expected I, but got Obj
		//IL_01b7: Expected Obj, but got I
		//IL_00a7: Expected I, but got Obj
		//IL_0bef: Expected I, but got Obj
		//IL_0c05: Expected Obj, but got I
		//IL_022f: Expected I, but got Obj
		//IL_09fa: Expected Obj, but got I4
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected Obj, but got Unknown
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected I4, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected Obj, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Expected Obj, but got Unknown
		//IL_0a6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected Obj, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected Obj, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected Obj, but got Unknown
		//IL_0ab5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected Obj, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected Obj, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected Obj, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected Obj, but got Unknown
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected Obj, but got Unknown
		//IL_0b1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected Obj, but got Unknown
		//IL_0b2d: Expected Obj, but got I4
		//IL_01e2: Expected I, but got Obj
		//IL_0504: Expected I, but got Obj
		//IL_07cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected Obj, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected Obj, but got Unknown
		//IL_07ed: Expected I4, but got Obj
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected Obj, but got Unknown
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Expected Obj, but got Unknown
		//IL_08db: Expected I4, but got Obj
		//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected Obj, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected Obj, but got Unknown
		//IL_0b68: Expected Obj, but got I4
		//IL_0571: Expected I, but got Obj
		//IL_0587: Expected Obj, but got I
		//IL_02f5: Expected I, but got Obj
		//IL_0c51: Expected Obj, but got I4
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected Obj, but got Unknown
		//IL_0c6f: Expected Obj, but got I4
		//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7e: Expected Obj, but got Unknown
		//IL_0cb0: Expected Obj, but got I4
		//IL_0cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbf: Expected I4, but got Unknown
		//IL_05b2: Expected I, but got Obj
		//IL_0cf9: Expected Obj, but got I4
		//IL_0d03: Expected I4, but got Obj
		//IL_05ff: Expected I, but got Obj
		//IL_0615: Expected Obj, but got I
		//IL_0698: Expected I, but got Obj
		//IL_06ae: Expected Obj, but got I
		//IL_0d40: Expected Obj, but got I4
		//IL_0d58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected Obj, but got Unknown
		//IL_0d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6a: Expected I4, but got Unknown
		//IL_0d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8e: Expected Obj, but got Unknown
		//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9c: Expected Obj, but got Unknown
		//IL_0db4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db9: Expected Obj, but got Unknown
		//IL_0dc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc9: Expected Obj, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0dfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Expected Obj, but got Unknown
		//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0e: Expected Obj, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2b: Expected Obj, but got Unknown
		//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3e: Expected Obj, but got Unknown
		//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4c: Expected Obj, but got Unknown
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected Obj, but got Unknown
		//IL_0e73: Expected Obj, but got I4
		//IL_0476: Expected I, but got Obj
		//IL_048c: Expected Obj, but got I
		//IL_0640: Expected I, but got Obj
		//IL_03ba: Expected I, but got Obj
		//IL_03d0: Expected Obj, but got I
		//IL_06d9: Expected I, but got Obj
		//IL_04b7: Expected I, but got Obj
		//IL_03fb: Expected I, but got Obj
		//IL_044b: Expected Obj, but got I4
		bool flag = cur_match == 0;
		byte[] array = null;
		while (true)
		{
			nint num = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v4 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v229 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (lookahead < MIN_LOOKAHEAD)
			{
				Reset();
				nint num3 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v164 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v191 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = lookahead < MIN_LOOKAHEAD;
				object obj3 = flag & flag2;
				if (obj3 != null)
				{
					goto IL_0884;
				}
				if (lookahead == 0)
				{
					break;
				}
			}
			nint num5 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S1_v15 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v213 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (lookahead >= MIN_MATCH)
			{
				nint num7 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v134 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v154 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num9 = hash_shift & 0x1F;
				int num10 = ins_h << num9;
				object obj6 = MIN_MATCH + strstart;
				object obj7 = (object)window + obj6;
				object obj8 = obj7 + 15;
				int num11 = num10 ^ obj8;
				int num12 = num11 & hash_mask;
				ins_h = num12;
				object obj9 = this - -64;
				object obj10 = obj9 + 16;
				int num13 = ins_h << 1;
				object obj11 = obj10 + num13;
				object obj12 = prev + 16;
				int num14 = w_mask & strstart;
				int num15 = num14 << 1;
				object obj13 = obj12 + num15;
				object obj14 = this - -64;
				object obj15 = obj14 + 16;
				int num16 = ins_h << 1;
				object obj16 = obj15 + num16;
				obj13 = obj16;
				object obj17 = this - -64;
				object obj18 = obj17 + 16;
				int num17 = ins_h << 1;
				object obj19 = obj18 + num17;
				obj19 = strstart;
				array = (byte[])obj11;
			}
			prev_length = match_length;
			prev_match = match_start;
			nint num18 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v23 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num19 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S0_v119 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num20 = MIN_MATCH - 1;
			match_length = num20;
			if (array != null)
			{
				Config config = this.config;
				if (prev_length < config.MaxLazy)
				{
					nint num21 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S1_v142 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj21 = (nint)0 & (nint)0x200;
					if (obj21 != null)
					{
						nint num22 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ S1_v179 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj22 = strstart - array;
					object obj23 = obj22 & 0xFFFF;
					object obj24 = w_size - MIN_LOOKAHEAD;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj24))
					{
						if (compressionStrategy != CompressionStrategy.HuffmanOnly)
						{
							int num23 = SetDictionary(array);
							match_length = num23;
						}
						if (match_length <= 5)
						{
							if (compressionStrategy == CompressionStrategy.Filtered)
							{
								goto IL_0468;
							}
							nint num24 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S1_v161 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
							object obj25 = (nint)0 & (nint)0x200;
							if (obj25 != null)
							{
								nint num25 = (nint)typeof(DeflateManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ S1_v171 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (match_length == MIN_MATCH)
							{
								object obj26 = strstart - match_start;
								if ((nint)obj26 >= 4097)
								{
									goto IL_0468;
								}
							}
						}
					}
				}
			}
			goto IL_0be1;
			IL_0468:
			nint num26 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S0_v100 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num27 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ S0_v105 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num28 = MIN_MATCH - 1;
			match_length = num28;
			goto IL_0be1;
			IL_0884:
			return 0;
			IL_0be1:
			nint num29 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S0_v33 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num30 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v74 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (prev_length >= MIN_MATCH && match_length <= prev_length)
			{
				nint num31 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S1_v58 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num32 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S1_v130 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj30 = lookahead + strstart;
				object obj31 = obj30 - MIN_MATCH;
				object obj32 = strstart - 1;
				ZlibCodec codec = (ZlibCodec)(obj32 - prev_match);
				CompressionLevel level = (CompressionLevel)(prev_length - MIN_MATCH);
				int num33 = Initialize(codec, level);
				object obj33 = prev_length - 1;
				int num34 = lookahead - obj33;
				lookahead = num34;
				int num35 = prev_length - 2;
				prev_length = num35;
				byte[] array2;
				do
				{
					if (++strstart <= (nint)obj31)
					{
						nint num36 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ S1_v104 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
						object obj34 = (nint)0 & (nint)0x200;
						if (obj34 != null)
						{
							nint num37 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ S1_v124 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num38 = hash_shift & 0x1F;
						int num39 = ins_h << num38;
						object obj35 = MIN_MATCH + strstart;
						object obj36 = (object)window + obj35;
						object obj37 = obj36 + 15;
						int num40 = num39 ^ obj37;
						int num41 = num40 & hash_mask;
						ins_h = num41;
						object obj38 = this - -64;
						object obj39 = obj38 + 16;
						int num42 = ins_h << 1;
						object obj40 = obj39 + num42;
						object obj41 = prev + 16;
						int num43 = w_mask & strstart;
						int num44 = num43 << 1;
						object obj42 = obj41 + num44;
						object obj43 = this - -64;
						object obj44 = obj43 + 16;
						int num45 = ins_h << 1;
						object obj45 = obj44 + num45;
						obj42 = obj45;
						object obj46 = this - -64;
						object obj47 = obj46 + 16;
						int num46 = ins_h << 1;
						object obj48 = obj47 + num46;
						obj48 = strstart;
						array = (byte[])obj40;
					}
					array2 = (byte[])(prev_length - 1);
					prev_length = (int)array2;
				}
				while (array2 != null);
				match_available = 0;
				nint num47 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ S1_v81 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj49 = (nint)0 & (nint)0x200;
				if (obj49 != null)
				{
					nint num48 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ S1_v89 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num49 = MIN_MATCH - 1;
				match_length = num49;
				int num50 = strstart + 1;
				strstart = num50;
				if (num33 == 0)
				{
					continue;
				}
				WantRfc1950HeaderBytes = false;
				ZlibCodec codec2 = _codec;
				if (codec2.AvailableBytesOut != 0)
				{
					continue;
				}
			}
			else
			{
				if (match_available == 0)
				{
					match_available = 1;
					int num51 = strstart + 1;
					strstart = num51;
					int num52 = lookahead - 1;
					lookahead = num52;
					continue;
				}
				object obj50 = window + strstart;
				object obj51 = obj50 + 15;
				if (Initialize(null, (CompressionLevel)obj51) != 0)
				{
					WantRfc1950HeaderBytes = false;
				}
				int num53 = strstart + 1;
				strstart = num53;
				int num54 = lookahead - 1;
				lookahead = num54;
				ZlibCodec codec3 = _codec;
				if (codec3.AvailableBytesOut != 0)
				{
					continue;
				}
			}
			goto IL_0884;
		}
		if (match_available != 0)
		{
			object obj52 = window + strstart;
			object obj53 = obj52 + 15;
			int num55 = Initialize(null, (CompressionLevel)obj53);
			match_available = 0;
		}
		bool flag3 = (WantRfc1950HeaderBytes = cur_match == 4);
		ZlibCodec codec4 = _codec;
		if (codec4.AvailableBytesOut != 0)
		{
			if (flag3)
			{
				return 3;
			}
			return 1;
		}
		if (flag3)
		{
			return 2;
		}
		return 0;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level)
	{
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_0382: Expected Obj, but got I4
		//IL_03c4: Expected Obj, but got I4
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected Obj, but got Unknown
		//IL_040a: Expected Obj, but got I4
		//IL_041f: Expected Obj, but got I4
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected Obj, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_003b: Expected I, but got Obj
		//IL_0051: Expected Obj, but got I
		//IL_02fd: Expected Obj, but got I4
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_0480: Expected I, but got Obj
		//IL_0496: Expected Obj, but got I
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected Obj, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected Obj, but got Unknown
		//IL_007c: Expected I, but got Obj
		//IL_00c9: Expected I, but got Obj
		//IL_0157: Expected Obj, but got I4
		//IL_0160: Expected Obj, but got I4
		//IL_063f: Expected I, but got Obj
		//IL_0655: Expected Obj, but got I
		//IL_017b: Expected I, but got Obj
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		//IL_01f3: Expected I, but got Obj
		//IL_0209: Expected Obj, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected Obj, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected Obj, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected I4, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected Obj, but got Unknown
		//IL_0234: Expected I, but got Obj
		object obj = pending + 16;
		int num = last_lit << 1;
		object obj2 = num + _distanceOffset;
		object obj3 = obj + obj2;
		object obj4 = (object)codec >> 8;
		obj3 = obj4;
		int num2 = last_lit << 1;
		object obj5 = num2 + _distanceOffset;
		object obj6 = (object)pending + obj5;
		object obj7 = obj6 + 17;
		obj7 = codec;
		object obj8 = pending + 16;
		object obj9 = last_lit + _lengthOffset;
		object obj10 = obj8 + obj9;
		CompressionLevel compressionLevel = default;
		obj10 = compressionLevel;
		int num3 = last_lit + 1;
		last_lit = num3;
		byte[] array = default;
		short[] array2;
		if (codec != null)
		{
			int num4 = matches + 1;
			matches = num4;
			string sourceString = (string)(codec - 1);
			nint num5 = (nint)typeof(Tree);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S2_v24 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num6 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S2_v54 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj12 = Tree.LengthCode + 16;
			object obj13 = obj12 + compressionLevel;
			nint num7 = (nint)typeof(InternalConstants);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S2_v35 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num8 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v48 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj15 = obj13 << 24;
			object obj16 = obj15 >> 24;
			object obj17 = InternalConstants.LITERALS + obj16;
			object obj18 = obj17 << 2;
			object obj19 = (object)dyn_ltree + obj18;
			object obj20 = obj19 + 20;
			object obj21 = obj20 + 1;
			obj20 = obj21;
			array = SharedUtils.ToByteArray(sourceString);
			array2 = dyn_dtree;
		}
		else
		{
			array2 = dyn_ltree;
		}
		object obj22 = array2 + 16;
		object obj23 = (object)array << 2;
		object obj24 = obj22 + obj23;
		object obj25 = obj24 + 1;
		obj24 = obj25;
		if ((last_lit & 0x1FFF) == 0 && this.compressionLevel >= CompressionLevel.Level3)
		{
			int num9 = last_lit << 3;
			object obj26 = strstart - block_start;
			object obj27 = 0;
			int num10 = num9;
			while (true)
			{
				nint num11 = (nint)typeof(InternalConstants);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v47 (Il2CppClass<Ionic.Zlib.InternalConstants>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num12 = (nint)typeof(InternalConstants);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v87 (Il2CppClass<Ionic.Zlib.InternalConstants>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((nint)obj27 >= InternalConstants.D_CODES)
				{
					break;
				}
				object obj29 = dyn_dtree + 16;
				object obj30 = obj27 << 2;
				object obj31 = obj29 + obj30;
				nint num13 = (nint)typeof(Tree);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v66 (Il2CppClass<Ionic.Zlib.Tree>)+BA]");
				object obj32 = (nint)0 & (nint)0x200;
				if (obj32 != null)
				{
					nint num14 = (nint)typeof(Tree);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v81 (Il2CppClass<Ionic.Zlib.Tree>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj33 = Tree.ExtraDistanceBits + 16;
				object obj34 = obj27 << 2;
				object obj35 = obj33 + obj34;
				object obj36 = obj35 + 5;
				object obj37 = obj36 * obj31;
				int num15 = obj37 + num10;
				object obj38 = obj27 + 1;
				obj27 = obj38;
				num10 = num15;
			}
			int num16 = last_lit / 2;
			if (matches < num16)
			{
				int num17 = num10 >> 3;
				object obj39 = obj26 / 2;
				if (num17 < (nint)obj39)
				{
					return 1;
				}
			}
		}
		object obj40 = lit_bufsize - 1;
		if (last_lit == (nint)obj40)
		{
			return 1;
		}
		return (last_lit == lit_bufsize) ? 1 : 0;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003f: Expected Obj, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00d2: Expected Obj, but got I4
		//IL_00ed: Expected Obj, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		object obj = this + 16;
		object obj2 = (object)codec << 2;
		object obj3 = obj + obj2;
		object obj4 = this + 16;
		object obj5 = (int)level << 2;
		object obj6 = obj4 + obj5;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			return 1;
		}
		object obj7 = obj3 & 0xFFFF;
		object obj8 = obj6 & 0xFFFF;
		if (obj7 == obj8)
		{
			object obj9 = bits + 16;
			object obj10 = obj9 + (object)codec;
			object obj11 = bits + 16;
			object obj12 = obj11 + level;
			return (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12)) ? 1 : 0;
		}
		return 0;
	}

	internal unsafe int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
	{
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_013d: Expected I4, but got Obj
		//IL_00bf: Expected I4, but got Obj
		//IL_00cd: Expected I4, but got Obj
		//IL_00db: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006d: Expected I4, but got Obj
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0088: Expected I4, but got Obj
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected Obj, but got Unknown
		//IL_00a3: Expected I4, but got Obj
		nint num = (nint)typeof(IOSPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<InAppPurchase.Internal.IOSPurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(IOSPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<InAppPurchase.Internal.IOSPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((string)(object)codec).Substring((int)IOSPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		if (text.m_firstChar == '\u0003')
		{
			object obj2 = text + 16;
			((CompressionLevel*)(int)level)->value__ = (int)obj2;
			object obj3 = text + 20;
			((int*)bits)->m_value = (int)obj3;
			object obj4 = text + 24;
			((CompressionStrategy*)(int)compressionStrategy)->value__ = (int)obj4;
			return 1;
		}
		((CompressionLevel*)(int)level)->value__ = (int)"";
		((int*)bits)->m_value = (int)"";
		((CompressionStrategy*)(int)compressionStrategy)->value__ = (int)"";
		return 0;
	}

	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
	{
		//IL_0009: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		obj = codec;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
		int result = default;
		return result;
	}

	internal void Reset()
	{
		//IL_04e2: Expected Obj, but got I4
		//IL_04ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected I4, but got Unknown
		//IL_04ff: Expected Obj, but got I4
		//IL_0235: Expected I, but got Obj
		//IL_024b: Expected Obj, but got I
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_03ef: Expected Obj, but got I4
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected Obj, but got Unknown
		//IL_0656: Expected I, but got Obj
		//IL_066c: Expected Obj, but got I
		//IL_0276: Expected I, but got Obj
		//IL_00b3: Expected I, but got Obj
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected Obj, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_02de: Expected I4, but got Obj
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected I4, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected Obj, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected Obj, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected Obj, but got Unknown
		//IL_0355: Expected I, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_0182: Expected Obj, but got I4
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_05ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_061a: Unknown result type (might be due to invalid IL or missing references)
		//IL_061f: Expected Obj, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01b3: Expected Obj, but got I4
		ZlibCodec codec2;
		do
		{
			object obj = window_size - lookahead;
			int num = obj - strstart;
			object obj2 = num - -1;
			if (num != -1)
			{
				if ((nint)obj2 == 1 && strstart == 0 && lookahead == 0)
				{
					num = w_size;
				}
				else
				{
					nint num2 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v25 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num3 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S2_v57 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj4 = w_size + w_size;
					object obj5 = obj4 - MIN_LOOKAHEAD;
					if (strstart >= (nint)obj5)
					{
						Array.ConstrainedCopy(window, w_size, window, 0, w_size);
						int num4 = match_start - w_size;
						match_start = num4;
						int num5 = strstart - w_size;
						strstart = num5;
						int num6 = block_start - w_size;
						block_start = num6;
						int num7 = hash_size;
						int num11;
						do
						{
							object obj6 = this - -64;
							object obj7 = obj6 + 16;
							int num8 = num7 - 1;
							int num9 = num8 << 1;
							object obj8 = obj7 + num9;
							object obj9 = this - -64;
							object obj10 = obj9 + 16;
							int num10 = num8 << 1;
							object obj11 = obj10 + num10;
							object obj12 = ((w_size <= (nint)obj8) ? ((object)(obj8 - w_size)) : ((object)0));
							obj11 = obj12;
							num11 = hash_size - 1;
							num7 = num8;
						}
						while (num11 != 0);
						int num12 = w_size;
						int num16;
						do
						{
							object obj13 = prev + 16;
							int num13 = num12 - 1;
							int num14 = num13 << 1;
							object obj14 = obj13 + num14;
							object obj15 = prev + 16;
							int num15 = num13 << 1;
							object obj16 = obj15 + num15;
							object obj17 = ((w_size <= (nint)obj14) ? ((object)(obj14 - w_size)) : ((object)0));
							obj16 = obj17;
							num16 = w_size - 1;
							num12 = num13;
						}
						while (num16 != 0);
						num = w_size + num;
					}
				}
			}
			else
			{
				num = -2;
			}
			ZlibCodec codec = _codec;
			if (codec.AvailableBytesIn == 0)
			{
				break;
			}
			int offset = lookahead + strstart;
			int num17 = ((ZlibStream)(object)_codec).Read(window, offset, num);
			int num18 = num17 + lookahead;
			lookahead = num18;
			nint num19 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v14 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num20 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v46 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (lookahead >= MIN_MATCH)
			{
				object obj19 = window + 16;
				object obj20 = obj19 + strstart;
				ins_h = (int)obj20;
				int num21 = hash_shift & 0x1F;
				int num22 = ins_h << num21;
				object obj21 = window + strstart;
				object obj22 = obj21 + 17;
				int num23 = num22 ^ obj22;
				int num24 = num23 & hash_mask;
				ins_h = num24;
			}
			nint num25 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v23 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num26 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S1_v30 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (lookahead < MIN_LOOKAHEAD)
			{
				codec2 = _codec;
				continue;
			}
			break;
		}
		while (codec2.AvailableBytesIn != 0);
	}

	internal int End()
	{
		return _WantRfc1950HeaderBytes ? 1 : 0;
	}

	private void SetDeflater()
	{
		//IL_0157: Expected I8, but got I4
		//IL_0165: Expected I8, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_01ad: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_0229: Expected I, but got Obj
		//IL_023f: Expected Obj, but got I
		//IL_00a8: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		//IL_00f5: Expected I, but got Obj
		ZlibCodec codec = _codec;
		ZlibCodec codec2 = _codec;
		codec2.TotalBytesOut = 0L;
		codec.TotalBytesIn = 0L;
		object obj = _codec + 56;
		obj = 0;
		pendingCount = 0;
		nextPending = 0;
		Rfc1950BytesEmitted = false;
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		int num3;
		if (~(_WantRfc1950HeaderBytes ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v46 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num3 = INIT_STATE;
		}
		else
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v34 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			num3 = BUSY_STATE;
		}
		status = num3;
		ZlibCodec codec3 = _codec;
		nint num5 = (nint)typeof(Adler);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v15 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Adler);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v24 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int adler = ((ZlibBaseStream)null).Read((byte[])null, 0, 0);
		codec3._Adler32 = (uint)adler;
		last_flush = 0;
		_InitializeBlocks();
		_InitializeTreeData();
	}

	internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
	{
		//IL_0013: Expected Obj, but got I4
		int num = ((DeflateStream)this).Read((byte[])level, (int)strategy, 15);
		return 0;
	}

	internal int SetDictionary(byte[] dictionary)
	{
		//IL_08fe: Expected I, but got Obj
		//IL_0914: Expected Obj, but got I
		//IL_0ca3: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0ce4: Expected I, but got Obj
		//IL_0cfa: Expected Obj, but got I
		//IL_0d17: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_096b: Expected Obj, but got I
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected Obj, but got Unknown
		//IL_098b: Expected Obj, but got I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected Obj, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected Obj, but got Unknown
		//IL_09c9: Expected Obj, but got I4
		//IL_0941: Expected Obj, but got I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected Obj, but got Unknown
		//IL_00fc: Expected I, but got Obj
		//IL_012c: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_0c3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected Obj, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c51: Expected Obj, but got Unknown
		//IL_0c67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6c: Expected Obj, but got Unknown
		//IL_0152: Expected I, but got Obj
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0beb: Expected Obj, but got Unknown
		//IL_0bf5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfa: Expected I4, but got Unknown
		//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c15: Expected Obj, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected Obj, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Expected Obj, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02ee: Expected Obj, but got I4
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected Obj, but got Unknown
		//IL_0aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa9: Expected Obj, but got Unknown
		//IL_0ac1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected Obj, but got Unknown
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad4: Expected Obj, but got Unknown
		//IL_0702: Expected I, but got Obj
		//IL_0718: Expected Obj, but got I
		//IL_0735: Expected I, but got Obj
		//IL_0b26: Expected Obj, but got I
		//IL_0b40: Expected I4, but got Obj
		//IL_0b4e: Expected I, but got Obj
		//IL_0b64: Expected Obj, but got I
		//IL_0b71: Expected I4, but got Obj
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected Obj, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0751: Expected I, but got Obj
		//IL_0781: Expected I, but got Obj
		//IL_07b6: Expected I4, but got Obj
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_07a7: Expected I, but got Obj
		//IL_07ea: Expected Obj, but got I4
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_0807: Expected Obj, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_0824: Expected Obj, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected Obj, but got Unknown
		//IL_045f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected Obj, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected Obj, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected Obj, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected Obj, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected Obj, but got Unknown
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Expected Obj, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Obj, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Expected Obj, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected Obj, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected Obj, but got Unknown
		//IL_0671: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected Obj, but got Unknown
		//IL_0681: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Expected Obj, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected Obj, but got Unknown
		//IL_06bc: Expected Obj, but got I4
		//IL_06c5: Expected Obj, but got I4
		//IL_06d6: Expected Obj, but got I4
		Config config = this.config;
		nint num = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S2_v2 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v92 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = w_size - MIN_LOOKAHEAD;
		object obj5;
		if (strstart > (nint)obj2)
		{
			nint num3 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v79 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S2_v86 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = w_size - MIN_LOOKAHEAD;
			obj5 = strstart - obj4;
		}
		else
		{
			obj5 = 0;
		}
		Config config2 = this.config;
		nint num5 = (nint)typeof(DeflateManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v24 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		bool flag = obj6 == null;
		nint num6 = (nint)typeof(DeflateManager);
		if (!flag)
		{
			nint num7 = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v179 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num6 = (nint)typeof(DeflateManager);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num6 = (nint)typeof(DeflateManager);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ L2_v5 (Il2CppClass<Ionic.Zlib.DeflateManager>)+5C]");
		object obj7 = -(-64);
		object obj8 = obj7 + strstart;
		object obj9 = prev_length + strstart;
		object obj10 = (object)window + obj9;
		object obj11 = obj10 + 15;
		object obj12 = window + 16;
		object obj13 = prev_length + strstart;
		object obj14 = obj12 + obj13;
		Config config3 = this.config;
		int num8 = ((config2.NiceLength <= lookahead) ? config2.NiceLength : lookahead);
		int num9 = config.MaxChainLength >> 2;
		bool flag4 = prev_length >= config3.GoodLength;
		bool flag5 = !flag4;
		byte[] array = dictionary;
		object obj15 = obj14;
		object obj16 = obj11;
		int num10 = strstart;
		int num11 = config.MaxChainLength;
		int num12 = prev_length;
		if (!flag5)
		{
			array = dictionary;
			obj15 = obj14;
			obj16 = obj11;
			num10 = strstart;
			num11 = num9;
			num12 = prev_length;
		}
		object obj45 = default;
		int num19;
		while (true)
		{
			object obj17 = window + 16;
			object obj18 = num12 + array;
			object obj19 = obj17 + obj18;
			object obj20 = obj15 & 0xFF;
			if (obj19 == obj20)
			{
				object obj21 = num12 + array;
				object obj22 = (object)window + obj21;
				object obj23 = obj22 + 15;
				object obj24 = obj16 & 0xFF;
				if (obj23 == obj24)
				{
					object obj25 = window + 16;
					object obj26 = obj25 + (object)array;
					object obj27 = window + 16;
					object obj28 = obj27 + num10;
					if (obj26 == obj28)
					{
						object obj29 = window + 16;
						object obj30 = array + 1;
						object obj31 = obj29 + obj30;
						object obj32 = window + num10;
						object obj33 = obj32 + 17;
						if (obj31 == obj33)
						{
							object obj34 = num10 + 2;
							object obj35 = obj30 + 1;
							object obj36 = obj35;
							object obj37 = obj34;
							object obj44;
							object obj46;
							object obj90;
							do
							{
								object obj38 = window + 16;
								object obj39 = obj37 + 1;
								object obj40 = obj38 + obj39;
								object obj41 = window + 16;
								object obj42 = obj36 + 1;
								object obj43 = obj41 + obj42;
								bool flag6 = obj40 != obj43;
								obj44 = obj45;
								obj46 = obj39;
								if (flag6)
								{
									break;
								}
								object obj47 = window + 16;
								object obj48 = obj39 + 1;
								object obj49 = obj47 + obj48;
								object obj50 = window + 16;
								object obj51 = obj42 + 1;
								object obj52 = obj50 + obj51;
								bool flag7 = obj49 != obj52;
								obj44 = obj45;
								obj46 = obj48;
								if (flag7)
								{
									break;
								}
								object obj53 = window + 16;
								object obj54 = obj48 + 1;
								object obj55 = obj53 + obj54;
								object obj56 = window + 16;
								object obj57 = obj51 + 1;
								object obj58 = obj56 + obj57;
								bool flag8 = obj55 != obj58;
								obj44 = obj45;
								obj46 = obj54;
								if (flag8)
								{
									break;
								}
								object obj59 = window + 16;
								object obj60 = obj54 + 1;
								object obj61 = obj59 + obj60;
								object obj62 = window + 16;
								object obj63 = obj57 + 1;
								object obj64 = obj62 + obj63;
								bool flag9 = obj61 != obj64;
								obj44 = obj45;
								obj46 = obj60;
								if (flag9)
								{
									break;
								}
								object obj65 = window + 16;
								object obj66 = obj60 + 1;
								object obj67 = obj65 + obj66;
								object obj68 = window + 16;
								object obj69 = obj63 + 1;
								object obj70 = obj68 + obj69;
								bool flag10 = obj67 != obj70;
								obj44 = obj45;
								obj46 = obj66;
								if (flag10)
								{
									break;
								}
								object obj71 = window + 16;
								object obj72 = obj66 + 1;
								object obj73 = obj71 + obj72;
								object obj74 = window + 16;
								object obj75 = obj69 + 1;
								object obj76 = obj74 + obj75;
								bool flag11 = obj73 != obj76;
								obj44 = obj45;
								obj46 = obj72;
								if (flag11)
								{
									break;
								}
								object obj77 = window + 16;
								object obj78 = obj72 + 1;
								object obj79 = obj77 + obj78;
								object obj80 = window + 16;
								object obj81 = obj75 + 1;
								object obj82 = obj80 + obj81;
								bool flag12 = obj79 != obj82;
								obj44 = obj45;
								obj46 = obj78;
								if (flag12)
								{
									break;
								}
								object obj83 = window + 16;
								object obj84 = obj78 + 1;
								object obj85 = obj83 + obj84;
								bool flag13 = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj84) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8);
								object obj86 = obj85 & 0xFF;
								object obj87 = window + 16;
								object obj88 = obj81 + 1;
								object obj89 = obj87 + obj88;
								bool flag14 = obj86 == obj89;
								obj90 = flag13 & flag14;
								obj44 = 1;
								obj46 = obj84;
								obj45 = 1;
								obj36 = obj88;
								obj37 = obj84;
							}
							while (obj90 != null);
							nint num13 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v100 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
							object obj91 = (nint)0 & (nint)0x200;
							bool flag15 = obj91 == null;
							nint num14 = (nint)typeof(DeflateManager);
							if (!flag15)
							{
								nint num15 = (nint)typeof(DeflateManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ S0_v128 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
								bool flag16 = (nint)0 == 0;
								bool flag17 = !flag16;
								num14 = (nint)typeof(DeflateManager);
								if (!flag17)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									num14 = (nint)typeof(DeflateManager);
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ L3_v13 (Il2CppClass<Ionic.Zlib.DeflateManager>)+5C]");
							object obj92 = -(-64);
							object obj93 = obj8 - obj46;
							int num16 = obj92 - obj93;
							nint num17 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ S1_v86 (Il2CppClass<Ionic.Zlib.DeflateManager>)+5C]");
							object obj94 = -(-64);
							int num18 = obj8 - obj94;
							if (num16 > num12)
							{
								match_start = (int)array;
								bool flag18 = num16 >= num8;
								num19 = num16;
								if (flag18)
								{
									break;
								}
								object obj95 = num16 + num18;
								object obj96 = (object)window + obj95;
								object obj97 = obj96 + 15;
								object obj98 = window + 16;
								object obj99 = num16 + num18;
								object obj100 = obj98 + obj99;
								obj15 = obj100;
								obj16 = obj97;
								num19 = num16;
							}
							else
							{
								num19 = num12;
							}
							obj45 = obj44;
							num10 = num18;
						}
						else
						{
							num19 = num12;
						}
					}
					else
					{
						num19 = num12;
					}
				}
				else
				{
					num19 = num12;
				}
			}
			else
			{
				num19 = num12;
			}
			object obj101 = prev + 16;
			int num20 = array & w_mask;
			int num21 = num20 << 1;
			object obj102 = obj101 + num21;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj102))
			{
				break;
			}
			int num22 = num11 - 1;
			if (num11 == 1)
			{
				break;
			}
			array = (byte[])obj102;
			num11 = num22;
			num12 = num19;
		}
		if (num19 > lookahead)
		{
			num19 = lookahead;
		}
		return num19;
	}

	internal int Deflate(FlushType flush)
	{
		//IL_03a3: Expected Obj, but got I4
		//IL_0666: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0405: Expected I4, but got Obj
		//IL_0405: Expected Obj, but got I4
		//IL_0405: Expected Obj, but got I4
		//IL_0424: Expected I, but got Obj
		//IL_043a: Expected Obj, but got I
		//IL_00f6: Expected I, but got Obj
		//IL_0143: Expected I, but got Obj
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0492: Expected Obj, but got I4
		//IL_02a6: Expected I4, but got Obj
		//IL_01d1: Expected I, but got Obj
		//IL_0692: Expected Obj, but got I4
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b6: Expected Obj, but got Unknown
		//IL_06c0: Expected I4, but got Obj
		//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ef: Expected Obj, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected I4, but got Unknown
		//IL_071e: Expected Obj, but got I4
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_0737: Expected I, but got Obj
		//IL_074d: Expected Obj, but got I
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected I4, but got Unknown
		//IL_04f1: Expected Obj, but got I4
		//IL_025f: Expected I, but got Obj
		//IL_02c2: Expected I, but got Obj
		//IL_030f: Expected I, but got Obj
		//IL_0325: Expected Obj, but got I
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected Obj, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected I4, but got Unknown
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected I4, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected Obj, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected Obj, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected Obj, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected Obj, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_062b: Expected Obj, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0641: Expected Obj, but got Unknown
		//IL_0350: Expected I, but got Obj
		object obj = flush + 12;
		if (flush != FlushType.None)
		{
			nint num = (nint)typeof(DeflateManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v8 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v73 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (status == INIT_STATE)
			{
				ZlibCodec codec = _codec;
				ZlibCodec codec2 = _codec;
				nint num3 = (nint)typeof(Adler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S2_v7 (Il2CppClass<Ionic.Zlib.Adler>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Adler);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S2_v63 (Il2CppClass<Ionic.Zlib.Adler>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int adler = ((ZlibBaseStream)codec2._Adler32).Read((byte[])flush, 0, (int)obj);
				codec._Adler32 = (uint)adler;
				nint num5 = (nint)typeof(DeflateManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v21 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num6 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v91 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if ((nint)obj >= MIN_MATCH)
				{
					nint num7 = (nint)typeof(DeflateManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v32 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num8 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v85 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj6 = w_size - MIN_LOOKAHEAD;
					int sourceIndex;
					int num12;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
					{
						nint num9 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v49 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num10 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S2_v57 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num11 = w_size - MIN_LOOKAHEAD;
						sourceIndex = obj - num11;
						num12 = num11;
					}
					else
					{
						num12 = (int)obj;
						sourceIndex = 0;
					}
					Array.ConstrainedCopy((Array)flush, sourceIndex, window, 0, num12);
					strstart = num12;
					block_start = num12;
					object obj8 = window + 16;
					ins_h = (int)obj8;
					int num13 = hash_shift & 0x1F;
					int num14 = ins_h << num13;
					object obj9 = window + 17;
					int num15 = num14 ^ obj9;
					int num16 = num15 & hash_mask;
					ins_h = num16;
					object obj10 = 0;
					while (true)
					{
						nint num17 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v44 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num18 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v79 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj12 = num12 - MIN_MATCH;
						if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
						{
							break;
						}
						nint num19 = (nint)typeof(DeflateManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v57 (Il2CppClass<Ionic.Zlib.DeflateManager>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num20 = (nint)typeof(DeflateManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v73 (Il2CppClass<Ionic.Zlib.DeflateManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						int num21 = hash_shift & 0x1F;
						int num22 = ins_h << num21;
						object obj14 = MIN_MATCH + obj10;
						object obj15 = (object)window + obj14;
						object obj16 = obj15 + 15;
						int num23 = num22 ^ obj16;
						int num24 = num23 & hash_mask;
						ins_h = num24;
						object obj17 = prev + 16;
						int num25 = w_mask & obj10;
						int num26 = num25 << 1;
						object obj18 = obj17 + num26;
						object obj19 = this - -64;
						object obj20 = obj19 + 16;
						int num27 = ins_h << 1;
						object obj21 = obj20 + num27;
						obj18 = obj21;
						object obj22 = this - -64;
						object obj23 = obj22 + 16;
						int num28 = ins_h << 1;
						object obj24 = obj23 + num28;
						obj24 = obj10;
						object obj25 = obj10 + 1;
						obj10 = obj25;
					}
				}
				return 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ZlibBaseStream zlibBaseStream = default;
		zlibBaseStream.Dispose((byte)(int)"Stream error." != 0);
		((DeflateManager)(object)zlibBaseStream).SetDictionary((byte[])null);
		return 0;
	}
}
